# FomaSdk.Net - A client SDK for the Fulfillment Order Manager API (FOMA)

## Usage

### Configuration

Accessing FOMA requires a valid JWT.
See <a href="https://cimpress-support.atlassian.net/wiki/spaces/CI/pages/168001556/Password-Realm+Grants" target="_blank">for further information on password realm grants.</a>

The easist way to get a valid JWT is to leverage library <a href="https://github.com/Cimpress-MCP/auth0-aspnet-core/" target="_blank">Auth0 for .NET Core</a>, which is
available on NuGet at <a href="https://www.nuget.org/packages/Cimpress.Auth0.Client">Cimpress.Auth0.Client</a>. Depending on this library means just to provide your credentials
to this library, and everything around injecting the JWT into the HTTP request is handled automatically by the library.

```csharp
// settings take from the Cimpress documentation: https://cimpress-support.atlassian.net/wiki/spaces/CI/pages/168001556/Password-Realm+Grants
Auth0ClientSettings clientSettings = new Auth0ClientSettings
{
    Auth0ServerUrl = "https://cimpress.auth0.com/",
    Auth0Audience = "https://api.cimpress.io/",
    Auth0ClientId = "ST0wwOc0RavK6P6hhAPZ9Oc2XFD2dGUF",
    Auth0GrantType = "http://auth0.com/oauth/grant-type/password-realm",
    Auth0Realm = "default",
    Auth0Username = username, // <-- your username, matching the Email address you registered with MCP
    Auth0Password = password // <-- your password for the account you registered with in MCP
};

// create the token provider, and use it in the AuthHandler
IAuth0TokenProvider tokenProvider = new PasswordRealmTokenProvider(loggerFactory, clientSettings);
var handler = new AuthHandler(loggerFactory.CreateLogger<Program>(), tokenProvider);

// create the HTTP client
var httpClient = new HttpClient(handler);
var fomaSdk = new FomaClient(httpClient, loggerFactory.CreateLogger<FomaClient>());
```

### Accessing notifications, and navigating details

The baseline for accessing FOMA are notifications. From a notifications, the links collection should be leveraged to navigate the structure.

```csharp
// enter your fulfiller Id
var fulfillerId = "<your fulfiller id>";

// get all open notifications
var notificationResult = await fomaSdk.GetNotifications(fulfillerId);

// loop through all notifications of type order request
foreach (var notification in notificationResult.Notifications.Where(n => n.Type == "OrderRequest"))
{
	foreach (var nItem in notification.Items)
	{
		var item = await fomaSdk.GetData<ItemDto>(nItem.Links[LinkRels.Self].Href);
        var manufacturingDetails = await fomaSdk.GetData<ManufacturingDetailDto>(item.Links[LinkRels.ManufacturingDetails].Href);
        var order = await fomaSdk.GetData<OrderDto>(item.Order.Links[LinkRels.Self].Href);
		// ... potentially follow more links, depending on your needs
		
		// --> validate order to your needs; if it's invalid, reject the notification
		// --> import the data into your system
    }

	// after successfully importing the data, accept the notification
	await fomaSdk.SendData<NotificationAcceptRejectDto>(notification.Links[LinkRels.Accept].Href);
}
```

See <a href="src/Example">the example project</a> on a fully setup example on how to use the FOMA SDK, and start importing orders into your system.

## Contribute

We value your contribution!

1. Fork it.
1. Create someting impressive.
1. Create a pull request.

If you need to update the models, the easiest is to leverage the online generator:

1. https://generator.swagger.io/
1. `POST /gen/clients/csharp-dotnet2` with body `{ "swaggerUrl": "https://fulfillment.at.cimpress.io/swagger/fulfillment-order-manager/swagger.json" }`
1. Download the result, and copy the `model` folder to this `model` folder.
1. Adjust all namespaces (several IDEs and tools allow to do this with a single button click).
