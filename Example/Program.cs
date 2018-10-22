using System;
using System.IO;
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
            if (args.Length != 3)
            {
                Console.Write("You must specify 3 arguments: <username> <password> <fulfillerId>");
                return;
            }

            try
            {
                new Program(args[0], args[1]).Execute(args[2]).Wait();
            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }

            Console.ReadLine();
        }

        public Program(string username, string password)
        {
            // logger factory / adjust to your needs to log to the desired destination
            var loggerFactory = new LoggerFactory();
            loggerFactory.AddConsole();
            logger = loggerFactory.CreateLogger<Program>();
            
            // create HTTP client with correct authentication and basic logging
            logger.LogInformation("Creating http client");
            var httpClient = CreateHttpClient(loggerFactory, username, password);

            // create instance of FOMA SDK
            logger.LogInformation("Creating foma SDK");
            fomaSdk = new FomaClient(httpClient, loggerFactory.CreateLogger<FomaClient>());
        }

        private async Task Execute(string fulfillerId)
        {
            // read all notifications
            logger.LogInformation("Querying FOMA for notifications");
            var notificationResult = await fomaSdk.GetNotifications(fulfillerId);
            logger.LogInformation($"Found {notificationResult.TotalCount} notifications.");

            // loop through all notifications
            foreach (var notification in notificationResult.Notifications)
            {
                logger.LogInformation($"Found notification {notification.NotificationId} of type {notification.Type}.");
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
            logger.LogInformation($"Accepting notification {notification.NotificationId}");
            var response = await fomaSdk.SendData<NotificationAcceptRejectDto>(notification.Links[LinkRels.Accept].Href);
            logger.LogInformation($"Accepting notification {notification.NotificationId} resulted in {response.StatusCode}.");
        }

        private async Task RejectNotification(NotificationDto notification, NotificationAcceptRejectDto acceptRejectDetails = null)
        {
            logger.LogWarning($"Rejecting notification {notification.NotificationId}");
            var response = await fomaSdk.SendData<NotificationAcceptRejectDto>(notification.Links[LinkRels.Accept].Href);
            logger.LogInformation($"Accepting notification {notification.NotificationId} resulted in {response.StatusCode}.");
        }

        private async Task ImportOrder(NotificationDto notification)
        {
            logger.LogInformation($"Processing notification for order {notification.Order.OrderId}");
            foreach (var nItem in notification.Items)
            {
                logger.LogInformation($"Downloading details for item {nItem.ItemId}: item details");
                var item = await fomaSdk.GetData<ItemDto>(nItem.Links[LinkRels.Self].Href);

                logger.LogInformation($"Downloading details for item {nItem.ItemId}: manufacturing details");
                var manufacturingDetails = await fomaSdk.GetData<ManufacturingDetailDto>(item.Links[LinkRels.ManufacturingDetails].Href);

                logger.LogInformation($"Downloading details for item {nItem.ItemId}: order details");
                var order = await fomaSdk.GetData<OrderDto>(item.Order.Links[LinkRels.Self].Href);

                logger.LogInformation($"Downloading details for item {nItem.ItemId}: artwork / document");
                using (var response = await fomaSdk.Download(item.Links[LinkRels.Document].Href))
                {
                    var suggestedFilename = response.Content.Headers.ContentDisposition.FileNameStar;
                    var ext = (string.IsNullOrEmpty(suggestedFilename) ? ".pdf" : Path.GetExtension(suggestedFilename)) ?? ".pdf";
                    using (var fileStream = File.OpenWrite($"imported-item-{item.ItemId}{ext}"))
                    {
                        await response.Content.CopyToAsync(fileStream);
                    }
                }

                logger.LogInformation($"Importing item {nItem.ItemId}");
                var dataToImport = (item, manufacturingDetails, order);
                File.WriteAllText($"imported-item-{item.ItemId}.json", JsonConvert.SerializeObject(dataToImport));
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