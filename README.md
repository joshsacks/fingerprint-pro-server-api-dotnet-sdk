<p align="center">
    <a href="https://fingerprint.com">
        <picture>
            <source media="(prefers-color-scheme: dark)" srcset="https://raw.githubusercontent.com/fingerprintjs/home/main/resources/logo_light.svg" />
            <source media="(prefers-color-scheme: light)" srcset="https://raw.githubusercontent.com/fingerprintjs/home/main/resources/logo_dark.svg" />
            <img src="https://raw.githubusercontent.com/fingerprintjs/home/main/resources/logo_dark.svg" alt="Fingerprint logo" width="312px" />
        </picture>
    </a>
</p>
<p align="center">
    <a href="https://github.com/fingerprintjs/fingerprint-pro-server-api-dotnet-sdk/actions/workflows/release.yml">
        <img src="https://github.com/fingerprintjs/fingerprint-pro-server-api-dotnet-sdk/actions/workflows/release.yml/badge.svg" alt="CI badge" />
    </a>
    <a href="https://github.com/fingerprintjs/fingerprint-pro-server-api-dotnet-sdk/actions/workflows/tests.yml">
        <img src="https://github.com/fingerprintjs/fingerprint-pro-server-api-dotnet-sdk/actions/workflows/tests.yml/badge.svg" alt="CI badge" />
    </a>
    <a href="https://opensource.org/licenses/MIT">
        <img src="https://img.shields.io/:license-mit-blue.svg?style=flat"/>
    </a>
    <a href="https://discord.gg/39EpE2neBg">
        <img src="https://img.shields.io/discord/852099967190433792?style=logo&label=Discord&logo=Discord&logoColor=white" alt="Discord server">
    </a>
</p>

# Fingerprint Server API Dotnet SDK

[Fingerprint](https://fingerprint.com) is a device intelligence platform offering 99.5% accurate visitor identification.
Fingerprint Pro Server API allows you to get information about visitors and about individual events in a server environment. It can be used for data exports, decision-making, and data analysis scenarios. Server API is intended for server-side usage, it's not intended to be used from the client side, whether it's a browser or a mobile device. 

This C# SDK is automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project:

- API version: 3
- SDK version: 2.4.0
- Build package: io.swagger.codegen.v3.generators.dotnet.CSharpClientCodegen

<a name="requirements"></a>
## Requirements
- .NET 5.0 or later (we keep the Microsoft support policy and we support [2 latest major versions](https://dotnet.microsoft.com/en-us/platform/support/policy/dotnet-core))

<a name="dependencies"></a>
## Dependencies (installed automatically when adding the package)
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 108.0.3 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 13.0.2 or later

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

### Region

If your subscription is in region other than US, you need to change the region in the configuration:

```csharp
using FingerprintPro.ServerSdk.Client;

var configuration = new Configuration(Environment.GetEnvironmentVariable("API_KEY")!)
{
    Region = Region.Eu // or Region.Asia
};
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api.fpjs.io*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*FingerprintApi* | [**GetEvent**](docs/FingerprintApi.md#getevent) | **GET** /events/{request_id} | Get event by requestId
*FingerprintApi* | [**GetVisits**](docs/FingerprintApi.md#getvisits) | **GET** /visitors/{visitor_id} | Get visits by visitorId

<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.ASN](docs/ASN.md)
 - [Model.BotdDetectionResult](docs/BotdDetectionResult.md)
 - [Model.BotdResult](docs/BotdResult.md)
 - [Model.BrowserDetails](docs/BrowserDetails.md)
 - [Model.Confidence](docs/Confidence.md)
 - [Model.DataCenter](docs/DataCenter.md)
 - [Model.ErrorEvent403Response](docs/ErrorEvent403Response.md)
 - [Model.ErrorEvent403ResponseError](docs/ErrorEvent403ResponseError.md)
 - [Model.ErrorEvent404Response](docs/ErrorEvent404Response.md)
 - [Model.ErrorEvent404ResponseError](docs/ErrorEvent404ResponseError.md)
 - [Model.ErrorVisits403](docs/ErrorVisits403.md)
 - [Model.EventResponse](docs/EventResponse.md)
 - [Model.HighActivityResult](docs/HighActivityResult.md)
 - [Model.IPLocation](docs/IPLocation.md)
 - [Model.IPLocationCity](docs/IPLocationCity.md)
 - [Model.IdentificationError](docs/IdentificationError.md)
 - [Model.IpBlockListResult](docs/IpBlockListResult.md)
 - [Model.IpBlockListResultDetails](docs/IpBlockListResultDetails.md)
 - [Model.IpInfoResult](docs/IpInfoResult.md)
 - [Model.IpInfoResultV4](docs/IpInfoResultV4.md)
 - [Model.IpInfoResultV6](docs/IpInfoResultV6.md)
 - [Model.Location](docs/Location.md)
 - [Model.LocationSpoofingResult](docs/LocationSpoofingResult.md)
 - [Model.ManyRequestsResponse](docs/ManyRequestsResponse.md)
 - [Model.ProductError](docs/ProductError.md)
 - [Model.ProductsResponse](docs/ProductsResponse.md)
 - [Model.ProductsResponseBotd](docs/ProductsResponseBotd.md)
 - [Model.ProductsResponseIdentification](docs/ProductsResponseIdentification.md)
 - [Model.ProductsResponseIdentificationData](docs/ProductsResponseIdentificationData.md)
 - [Model.RawDeviceAttributesResult](docs/RawDeviceAttributesResult.md)
 - [Model.Response](docs/Response.md)
 - [Model.ResponseVisits](docs/ResponseVisits.md)
 - [Model.SeenAt](docs/SeenAt.md)
 - [Model.SignalResponseClonedApp](docs/SignalResponseClonedApp.md)
 - [Model.SignalResponseClonedAppData](docs/SignalResponseClonedAppData.md)
 - [Model.SignalResponseEmulator](docs/SignalResponseEmulator.md)
 - [Model.SignalResponseEmulatorData](docs/SignalResponseEmulatorData.md)
 - [Model.SignalResponseFactoryReset](docs/SignalResponseFactoryReset.md)
 - [Model.SignalResponseFactoryResetData](docs/SignalResponseFactoryResetData.md)
 - [Model.SignalResponseFrida](docs/SignalResponseFrida.md)
 - [Model.SignalResponseFridaData](docs/SignalResponseFridaData.md)
 - [Model.SignalResponseHighActivity](docs/SignalResponseHighActivity.md)
 - [Model.SignalResponseIncognito](docs/SignalResponseIncognito.md)
 - [Model.SignalResponseIncognitoData](docs/SignalResponseIncognitoData.md)
 - [Model.SignalResponseIpBlocklist](docs/SignalResponseIpBlocklist.md)
 - [Model.SignalResponseIpInfo](docs/SignalResponseIpInfo.md)
 - [Model.SignalResponseJailbroken](docs/SignalResponseJailbroken.md)
 - [Model.SignalResponseJailbrokenData](docs/SignalResponseJailbrokenData.md)
 - [Model.SignalResponseLocationSpoofing](docs/SignalResponseLocationSpoofing.md)
 - [Model.SignalResponsePrivacySettings](docs/SignalResponsePrivacySettings.md)
 - [Model.SignalResponsePrivacySettingsData](docs/SignalResponsePrivacySettingsData.md)
 - [Model.SignalResponseProxy](docs/SignalResponseProxy.md)
 - [Model.SignalResponseProxyData](docs/SignalResponseProxyData.md)
 - [Model.SignalResponseRawDeviceAttributes](docs/SignalResponseRawDeviceAttributes.md)
 - [Model.SignalResponseRootApps](docs/SignalResponseRootApps.md)
 - [Model.SignalResponseRootAppsData](docs/SignalResponseRootAppsData.md)
 - [Model.SignalResponseTampering](docs/SignalResponseTampering.md)
 - [Model.SignalResponseTor](docs/SignalResponseTor.md)
 - [Model.SignalResponseTorData](docs/SignalResponseTorData.md)
 - [Model.SignalResponseVirtualMachine](docs/SignalResponseVirtualMachine.md)
 - [Model.SignalResponseVirtualMachineData](docs/SignalResponseVirtualMachineData.md)
 - [Model.SignalResponseVpn](docs/SignalResponseVpn.md)
 - [Model.Subdivision](docs/Subdivision.md)
 - [Model.TamperingResult](docs/TamperingResult.md)
 - [Model.Visit](docs/Visit.md)
 - [Model.VpnResult](docs/VpnResult.md)
 - [Model.VpnResultMethods](docs/VpnResultMethods.md)
 - [Model.WebhookSignalResponseClonedApp](docs/WebhookSignalResponseClonedApp.md)
 - [Model.WebhookSignalResponseEmulator](docs/WebhookSignalResponseEmulator.md)
 - [Model.WebhookSignalResponseFactoryReset](docs/WebhookSignalResponseFactoryReset.md)
 - [Model.WebhookSignalResponseFrida](docs/WebhookSignalResponseFrida.md)
 - [Model.WebhookSignalResponseJailbroken](docs/WebhookSignalResponseJailbroken.md)
 - [Model.WebhookSignalResponsePrivacySettings](docs/WebhookSignalResponsePrivacySettings.md)
 - [Model.WebhookSignalResponseProxy](docs/WebhookSignalResponseProxy.md)
 - [Model.WebhookSignalResponseRootApps](docs/WebhookSignalResponseRootApps.md)
 - [Model.WebhookSignalResponseTor](docs/WebhookSignalResponseTor.md)
 - [Model.WebhookSignalResponseVirtualMachine](docs/WebhookSignalResponseVirtualMachine.md)
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
        

## Support and feedback

To report problems, ask questions or provide feedback, please use [Issues](https://github.com/fingerprintjs/fingerprintjs-pro-server-api-node-sdk/issues). If you need private support, you can email us at [oss-support@fingerprint.com](mailto:oss-support@fingerprint.com).

<a name="license"></a>
## License
This project is licensed under the [MIT license](https://github.com/fingerprintjs/fingerprint-pro-server-api-dotnet-sdk/blob/main/LICENSE).
