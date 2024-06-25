<p align="center">
    <a href="https://fingerprint.com">
        <picture>
            <source media="(prefers-color-scheme: dark)" srcset="https://fingerprintjs.github.io/home/resources/logo_light.svg" />
            <source media="(prefers-color-scheme: light)" srcset="https://fingerprintjs.github.io/home/resources/logo_dark.svg" />
            <img src="https://fingerprintjs.github.io/home/resources/logo_dark.svg" alt="Fingerprint logo" width="312px" />
        </picture>
    </a>
</p>
<p align="center">
    <a href="https://github.com/fingerprintjs/fingerprint-pro-server-api-dotnet-sdk/actions/workflows/release.yml"><img src="https://github.com/fingerprintjs/fingerprint-pro-server-api-dotnet-sdk/actions/workflows/release.yml/badge.svg" alt="CI badge" /></a>
    <a href="https://github.com/fingerprintjs/fingerprint-pro-server-api-dotnet-sdk/actions/workflows/tests.yml"><img src="https://github.com/fingerprintjs/fingerprint-pro-server-api-dotnet-sdk/actions/workflows/tests.yml/badge.svg" alt="CI badge" /></a>
    <a href="https://opensource.org/licenses/MIT"><img src="https://img.shields.io/:license-mit-blue.svg?style=flat"/></a>
    <a href="https://discord.gg/39EpE2neBg"><img src="https://img.shields.io/discord/852099967190433792?style=logo&label=Discord&logo=Discord&logoColor=white" alt="Discord server"></a>
</p>

# Fingerprint Server API Dotnet SDK

[Fingerprint](https://fingerprint.com) is a device intelligence platform offering 99.5% accurate visitor identification.
Fingerprint Pro Server API allows you to get information about visitors and about individual events in a server environment. It can be used for data exports, decision-making, and data analysis scenarios. Server API is intended for server-side usage, it's not intended to be used from the client side, whether it's a browser or a mobile device. 

This C# SDK is automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project:

- API version: 3
- SDK version: 6.0.0-test.2
- Build package: io.swagger.codegen.v3.generators.dotnet.CSharpClientCodegen

<a name="requirements"></a>
## Requirements
- .NET 6.0 or later (we keep the [Microsoft support policy](https://dotnet.microsoft.com/en-us/platform/support/policy/dotnet-core))

<a name="how-to-install"></a>
## How to install

We recommend installing the package from [NuGet](https://docs.nuget.org/consume/installing-nuget):
```shell
dotnet add package FingerprintPro.ServerSdk
```

<a name="getting-started"></a>
## Getting Started

```csharp
// See https://aka.ms/new-console-template for more information
// Example usage of our SDK

// Import namespaces
using FingerprintPro.ServerSdk.Api;
using FingerprintPro.ServerSdk.Client;

// Initialize configuration and add your api key
var configuration = new Configuration(Environment.GetEnvironmentVariable("API_KEY")!);

var api = new FingerprintApi(
    configuration
);

var requestId = Environment.GetEnvironmentVariable("REQUEST_ID")!;
var visitorId = Environment.GetEnvironmentVariable("VISITOR_ID")!;

var visits = api.GetVisits(visitorId);
var events = api.GetEvent(requestId);

Console.WriteLine(visits);
Console.WriteLine(events);
```

You can also access the raw HTTP response by using the `WithHttpInfo` methods:

```csharp
// See https://aka.ms/new-console-template for more information
// Example usage of our SDK

// Import namespaces
using FingerprintPro.ServerSdk.Api;
using FingerprintPro.ServerSdk.Client;

// Initialize configuration and add your api key
var configuration = new Configuration(Environment.GetEnvironmentVariable("API_KEY")!);

var api = new FingerprintApi(
    configuration
);

var requestId = Environment.GetEnvironmentVariable("REQUEST_ID")!;
var visitorId = Environment.GetEnvironmentVariable("VISITOR_ID")!;

var visits = api.GetVisitsWithHttpInfo(visitorId);

// HttpResponseMessage
Console.WriteLine(visits.Response);

// Response data
Console.WriteLine(visits.Data);
```

### Region

If your subscription is in region other than US, you need to change the region in the configuration:

```csharp
using FingerprintPro.ServerSdk.Client;

var configuration = new Configuration(Environment.GetEnvironmentVariable("API_KEY")!)
{
    Region = Region.Eu // or Region.Asia
};
```

## Sealed results

This SDK provides utility methods for decoding [sealed results](https://dev.fingerprint.com/docs/sealed-client-results).
```csharp
using FingerprintPro.ServerSdk;

var sealedResult = Environment.GetEnvironmentVariable("BASE64_SEALED_RESULT")!;
var sealedKey = Environment.GetEnvironmentVariable("BASE64_KEY")!;

var events = Sealed.UnsealEventResponse(Convert.FromBase64String(sealedResult), new[]
{
    new Sealed.DecryptionKey(Convert.FromBase64String(sealedKey), Sealed.DecryptionAlgorithm.Aes256Gcm)
});

Console.WriteLine(events.ToJson());
```
To learn more, refer to example located in [src/FingerprintPro.ServerSdk.SealedResultExampleNet7/Program.cs](src/FingerprintPro.ServerSdk.SealedResultExampleNet7/Program.cs).

## Webhook signature validation

This SDK provides utility method for verifying the HMAC signature of the incoming webhook request.
```csharp
namespace FingerprintAspNetCore.Areas.Identity.Pages;

using FingerprintPro.ServerSdk;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Threading.Tasks;

[Route("api/[controller]")]
[ApiController]
public class WebhookController : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Post()
    {
        try
        {
            var secret = Environment.GetEnvironmentVariable("WEBHOOK_SIGNATURE_SECRET");
            if (string.IsNullOrEmpty(secret))
            {
                return BadRequest(new { message = "Secret key is not configured." });
            }

            var header = Request.Headers["fpjs-event-signature"].ToString();
            if (string.IsNullOrEmpty(header))
            {
                return BadRequest(new { message = "Missing fpjs-event-signature header." });
            }

            using var memoryStream = new MemoryStream();
            await Request.Body.CopyToAsync(memoryStream);
            var data = memoryStream.ToArray();

            // Validate webhook signature
            var isValid = Webhook.IsValidWebhookSignature(
                header,
                data,
                secret);

            if (!isValid)
            {
                return Forbid(new { message = "Webhook signature is invalid." });
            }

            // Process the webhook data here
            return Ok(new { message = "Webhook received." });
        }
        catch (Exception e)
        {
            return StatusCode(500, new { error = e.Message });
        }
    }
}

```
To learn more, refer to example located in [src/FingerprintPro.ServerSdk.WebhookExampleNet8/Program.cs](src/FingerprintPro.ServerSdk.WebhookExampleNet8/Program.cs).

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api.fpjs.io*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*FingerprintApi* | [**DeleteVisitorData**](docs/FingerprintApi.md#deletevisitordata) | **DELETE** /visitors/{visitor_id} | Delete data by visitor ID
*FingerprintApi* | [**GetEvent**](docs/FingerprintApi.md#getevent) | **GET** /events/{request_id} | Get event by request ID
*FingerprintApi* | [**GetVisits**](docs/FingerprintApi.md#getvisits) | **GET** /visitors/{visitor_id} | Get visits by visitor ID

<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.ASN](docs/ASN.md)
 - [Model.BotdDetectionResult](docs/BotdDetectionResult.md)
 - [Model.BotdResult](docs/BotdResult.md)
 - [Model.BrowserDetails](docs/BrowserDetails.md)
 - [Model.ClonedAppResult](docs/ClonedAppResult.md)
 - [Model.Common403ErrorResponse](docs/Common403ErrorResponse.md)
 - [Model.Confidence](docs/Confidence.md)
 - [Model.DataCenter](docs/DataCenter.md)
 - [Model.DeprecatedIPLocation](docs/DeprecatedIPLocation.md)
 - [Model.DeprecatedIPLocationCity](docs/DeprecatedIPLocationCity.md)
 - [Model.EmulatorResult](docs/EmulatorResult.md)
 - [Model.ErrorCommon403Response](docs/ErrorCommon403Response.md)
 - [Model.ErrorCommon429Response](docs/ErrorCommon429Response.md)
 - [Model.ErrorCommon429ResponseError](docs/ErrorCommon429ResponseError.md)
 - [Model.ErrorEvent404Response](docs/ErrorEvent404Response.md)
 - [Model.ErrorEvent404ResponseError](docs/ErrorEvent404ResponseError.md)
 - [Model.ErrorVisits403](docs/ErrorVisits403.md)
 - [Model.ErrorVisitsDelete400Response](docs/ErrorVisitsDelete400Response.md)
 - [Model.ErrorVisitsDelete400ResponseError](docs/ErrorVisitsDelete400ResponseError.md)
 - [Model.ErrorVisitsDelete404Response](docs/ErrorVisitsDelete404Response.md)
 - [Model.ErrorVisitsDelete404ResponseError](docs/ErrorVisitsDelete404ResponseError.md)
 - [Model.EventResponse](docs/EventResponse.md)
 - [Model.FactoryResetResult](docs/FactoryResetResult.md)
 - [Model.FridaResult](docs/FridaResult.md)
 - [Model.HighActivityResult](docs/HighActivityResult.md)
 - [Model.IPLocation](docs/IPLocation.md)
 - [Model.IPLocationCity](docs/IPLocationCity.md)
 - [Model.IdentificationError](docs/IdentificationError.md)
 - [Model.IncognitoResult](docs/IncognitoResult.md)
 - [Model.IpBlockListResult](docs/IpBlockListResult.md)
 - [Model.IpBlockListResultDetails](docs/IpBlockListResultDetails.md)
 - [Model.IpInfoResult](docs/IpInfoResult.md)
 - [Model.IpInfoResultV4](docs/IpInfoResultV4.md)
 - [Model.IpInfoResultV6](docs/IpInfoResultV6.md)
 - [Model.JailbrokenResult](docs/JailbrokenResult.md)
 - [Model.Location](docs/Location.md)
 - [Model.LocationSpoofingResult](docs/LocationSpoofingResult.md)
 - [Model.PrivacySettingsResult](docs/PrivacySettingsResult.md)
 - [Model.ProductError](docs/ProductError.md)
 - [Model.ProductsResponse](docs/ProductsResponse.md)
 - [Model.ProductsResponseBotd](docs/ProductsResponseBotd.md)
 - [Model.ProductsResponseIdentification](docs/ProductsResponseIdentification.md)
 - [Model.ProductsResponseIdentificationData](docs/ProductsResponseIdentificationData.md)
 - [Model.ProxyResult](docs/ProxyResult.md)
 - [Model.RawDeviceAttributesResult](docs/RawDeviceAttributesResult.md)
 - [Model.Response](docs/Response.md)
 - [Model.ResponseVisits](docs/ResponseVisits.md)
 - [Model.RootAppsResult](docs/RootAppsResult.md)
 - [Model.SeenAt](docs/SeenAt.md)
 - [Model.SignalResponseClonedApp](docs/SignalResponseClonedApp.md)
 - [Model.SignalResponseEmulator](docs/SignalResponseEmulator.md)
 - [Model.SignalResponseFactoryReset](docs/SignalResponseFactoryReset.md)
 - [Model.SignalResponseFrida](docs/SignalResponseFrida.md)
 - [Model.SignalResponseHighActivity](docs/SignalResponseHighActivity.md)
 - [Model.SignalResponseIncognito](docs/SignalResponseIncognito.md)
 - [Model.SignalResponseIpBlocklist](docs/SignalResponseIpBlocklist.md)
 - [Model.SignalResponseIpInfo](docs/SignalResponseIpInfo.md)
 - [Model.SignalResponseJailbroken](docs/SignalResponseJailbroken.md)
 - [Model.SignalResponseLocationSpoofing](docs/SignalResponseLocationSpoofing.md)
 - [Model.SignalResponsePrivacySettings](docs/SignalResponsePrivacySettings.md)
 - [Model.SignalResponseProxy](docs/SignalResponseProxy.md)
 - [Model.SignalResponseRawDeviceAttributes](docs/SignalResponseRawDeviceAttributes.md)
 - [Model.SignalResponseRootApps](docs/SignalResponseRootApps.md)
 - [Model.SignalResponseSuspectScore](docs/SignalResponseSuspectScore.md)
 - [Model.SignalResponseTampering](docs/SignalResponseTampering.md)
 - [Model.SignalResponseTor](docs/SignalResponseTor.md)
 - [Model.SignalResponseVirtualMachine](docs/SignalResponseVirtualMachine.md)
 - [Model.SignalResponseVpn](docs/SignalResponseVpn.md)
 - [Model.Subdivision](docs/Subdivision.md)
 - [Model.SuspectScoreResult](docs/SuspectScoreResult.md)
 - [Model.TamperingResult](docs/TamperingResult.md)
 - [Model.TooManyRequestsResponse](docs/TooManyRequestsResponse.md)
 - [Model.TorResult](docs/TorResult.md)
 - [Model.VirtualMachineResult](docs/VirtualMachineResult.md)
 - [Model.Visit](docs/Visit.md)
 - [Model.VpnResult](docs/VpnResult.md)
 - [Model.VpnResultMethods](docs/VpnResultMethods.md)
 - [Model.WebhookVisit](docs/WebhookVisit.md)

<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="ApiKeyHeader"></a>
### ApiKeyHeader

- **Type**: API key
- **API key parameter name**: Auth-API-Key
- **Location**: HTTP header
        
<a name="ApiKeyQuery"></a>
### ApiKeyQuery

- **Type**: API key
- **API key parameter name**: api_key
- **Location**: URL query string
        

## Documentation for sealed results

- [Sealed](docs/Sealed.md)
- [DecryptionKey](docs/DecryptionKey.md)

## Support and feedback

To report problems, ask questions or provide feedback, please use [Issues](https://github.com/fingerprintjs/fingerprintjs-pro-server-api-node-sdk/issues). If you need private support, you can email us at [oss-support@fingerprint.com](mailto:oss-support@fingerprint.com).

<a name="license"></a>
## License
This project is licensed under the [MIT license](https://github.com/fingerprintjs/fingerprint-pro-server-api-dotnet-sdk/blob/main/LICENSE).
