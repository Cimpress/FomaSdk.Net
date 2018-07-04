using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Cimpress.Auth0.Client;
using Cimpress.Clients.Foma.Model;
using Cimpress.Extensions.Http.MessageHandlers;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Cimpress.Clients.Foma.Example
{
    class Program
    {
        private readonly FomaClient fomaSdk;
        private readonly ILogger logger;

        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.Write("You must specify 2 arguments: <username> <password>");
                return;
            }

            try
            {
                new Program(args[0], args[1]).Execute().Wait();
            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }
        }

        public Program(string username, string password)
        {
            // logger factory / adjust to your needs to log to the desired destination
            var loggerFactory = new LoggerFactory();
            logger = loggerFactory.CreateLogger<Program>();

            // create HTTP client with correct authentication and basic logging
            var httpClient = CreateHttpClient(loggerFactory, username, password);

            // create instance of FOMA SDK
            fomaSdk = new FomaClient(httpClient, loggerFactory.CreateLogger<FomaClient>());
        }

        private async Task Execute()
        {
            // read all notifications
            var notificationResult = await fomaSdk.GetNotifications("kmr0f5gfvd");

            // loop through all notifications
            foreach (var notification in notificationResult.Notifications)
            {
                if (notification.Type == "OrderRequest")
                {
                    try
                    {
                        await ImportOrder(notification);
                        await AcceptNotification(notification);
                    }
                    catch (Exception ex)
                    {
                        logger.LogError(ex, "Error while importing order for notification {NotificationId}", notification.NotificationId);
                    }
                }
            }
        }

        private async Task AcceptNotification(NotificationDto notification, NotificationAcceptRejectDto acceptRejectDetails = null)
        {
            await fomaSdk.SendData<NotificationAcceptRejectDto>(notification.Links[LinkRels.Accept].Href);
        }

        private async Task RejectNotification(NotificationDto notification, NotificationAcceptRejectDto acceptRejectDetails = null)
        {
            await fomaSdk.SendData<NotificationAcceptRejectDto>(notification.Links[LinkRels.Accept].Href);
        }

        private async Task ImportOrder(NotificationDto notification)
        {
            foreach (var nItem in notification.Items)
            {
                var item = await fomaSdk.GetData<ItemDto>(nItem.Links[LinkRels.Self].Href);
                var manufacturingDetails = await fomaSdk.GetData<ManufacturingDetailDto>(item.Links[LinkRels.ManufacturingDetails].Href);
                var order = await fomaSdk.GetData<OrderDto>(item.Order.Links[LinkRels.Self].Href);

                var dataToImport = (item, manufacturingDetails, order);
                System.IO.File.WriteAllText($"imported-item-{item.ItemId}.json", JsonConvert.SerializeObject(dataToImport));
            }
        }

        private HttpClient CreateHttpClient(ILoggerFactory loggerFactory, string username, string password)
        {
            // settings take from the Cimpress documentation: https://cimpress-support.atlassian.net/wiki/spaces/CI/pages/168001556/Password-Realm+Grants
            Auth0ClientSettings clientSettings = new Auth0ClientSettings
            {
                Auth0ServerUrl = "https://cimpress.auth0.com/",
                Auth0Audience = "https://api.cimpress.io/",
                Auth0ClientId = "ST0wwOc0RavK6P6hhAPZ9Oc2XFD2dGUF",
                Auth0GrantType = "http://auth0.com/oauth/grant-type/password-realm",
                Auth0Realm = "default",
                Auth0Username = username,
                Auth0Password = password
            };
            IAuth0TokenProvider tokenProvider = new PasswordRealmTokenProvider(loggerFactory, clientSettings);
            var measurementHandler = new MeasurementHandler(loggerFactory.CreateLogger<Program>());
            var handler = new AuthHandler(measurementHandler, loggerFactory.CreateLogger<Program>(), tokenProvider);
            return new HttpClient(handler);
        }
    }
}