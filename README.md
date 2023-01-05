# sdk - the C# library for the Fingerprint Pro Server API

Fingerprint Pro Server API allows you to get information about visitors and about individual events in a server environment. This API can be used for data exports, decision-making, and data analysis scenarios.

This C# SDK is automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project:

- API version: 3
- SDK version: 
- Build package: io.swagger.codegen.v3.generators.dotnet.CSharpClientCodegen

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

<a name="dependencies"></a>
## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using sdk.Api;
using sdk.Client;
using sdk.Model;
```
<a name="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out sdk.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using sdk.Api;
using sdk.Client;
using sdk.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyHeader
            Configuration.Default.ApiKey.Add("Auth-API-Key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Auth-API-Key", "Bearer");
            // Configure API key authorization: ApiKeyQuery
            Configuration.Default.ApiKey.Add("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("api_key", "Bearer");

            var apiInstance = new FingerprintApi();
            var requestId = requestId_example;  // string | requestId is the unique identifier of each request

            try
            {
                // Get event by requestId
                EventResponse result = apiInstance.GetEvent(requestId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FingerprintApi.GetEvent: " + e.Message );
            }
        }
    }
}
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
 - [Model.BotdResult](docs/BotdResult.md)
 - [Model.BrowserDetails](docs/BrowserDetails.md)
 - [Model.Confidence](docs/Confidence.md)
 - [Model.ErrorResponse](docs/ErrorResponse.md)
 - [Model.ErrorResponseError](docs/ErrorResponseError.md)
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
 - [Model.StSeenAt](docs/StSeenAt.md)
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

