<p align="center">
    <a href="https://fingerprint.com">
        <picture>
            <source media="(prefers-color-scheme: dark)" srcset="https://raw.githubusercontent.com/fingerprintjs/fingerprint-pro-server-api-dotnet-sdk/main/res/logo_light.svg" />
            <source media="(prefers-color-scheme: light)" srcset="https://raw.githubusercontent.com/fingerprintjs/fingerprint-pro-server-api-dotnet-sdk/main/res/logo_dark.svg" />
            <img src="https://raw.githubusercontent.com/fingerprintjs/fingerprint-pro-server-api-dotnet-sdk/main/res/logo_dark.svg" alt="Fingerprint logo" width="312px" />
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

# FingerprintPro.ServerSdk - the C# library for the Fingerprint Pro Server API

Fingerprint Pro Server API allows you to get information about visitors and about individual events in a server environment. This API can be used for data exports, decision-making, and data analysis scenarios.

This C# SDK is automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project:

- API version: 3
- SDK version: 1.0.0-test.8
- Build package: io.swagger.codegen.v3.generators.dotnet.CSharpClientCodegen

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 5.0 or later

<a name="dependencies"></a>
## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 108.0.3 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 13.0.2 or later

<a name="installation"></a>
## Installation

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

 - [Model.BotdDetectionResult](docs/BotdDetectionResult.md)
 - [Model.BotdError](docs/BotdError.md)
 - [Model.BotdResult](docs/BotdResult.md)
 - [Model.BrowserDetails](docs/BrowserDetails.md)
 - [Model.Confidence](docs/Confidence.md)
 - [Model.ErrorEvent403Response](docs/ErrorEvent403Response.md)
 - [Model.ErrorEvent403ResponseError](docs/ErrorEvent403ResponseError.md)
 - [Model.ErrorEvent404Response](docs/ErrorEvent404Response.md)
 - [Model.ErrorEvent404ResponseError](docs/ErrorEvent404ResponseError.md)
 - [Model.EventResponse](docs/EventResponse.md)
 - [Model.IPLocation](docs/IPLocation.md)
 - [Model.IPLocationCity](docs/IPLocationCity.md)
 - [Model.Location](docs/Location.md)
 - [Model.ManyRequestsResponse](docs/ManyRequestsResponse.md)
 - [Model.ProductsResponse](docs/ProductsResponse.md)
 - [Model.ProductsResponseBotd](docs/ProductsResponseBotd.md)
 - [Model.ProductsResponseIdentification](docs/ProductsResponseIdentification.md)
 - [Model.ProductsResponseIdentificationData](docs/ProductsResponseIdentificationData.md)
 - [Model.Response](docs/Response.md)
 - [Model.ResponseVisits](docs/ResponseVisits.md)
 - [Model.SeenAt](docs/SeenAt.md)
 - [Model.Subdivision](docs/Subdivision.md)
 - [Model.Visit](docs/Visit.md)
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
        

<a name="Author"></a>
## Author
<a href="mailto:support@fingerprint.com">support@fingerprint.com</a>