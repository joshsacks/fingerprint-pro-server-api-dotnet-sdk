/* 
 * Fingerprint Pro Server API
 *
 * Fingerprint Pro Server API allows you to get information about visitors and about individual events in a server environment. This API can be used for data exports, decision-making, and data analysis scenarios.
 *
 * OpenAPI spec version: 3
 * Contact: support@fingerprint.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System.Collections.ObjectModel;
using RestSharp;
using FingerprintPro.ServerSdk.Client;
using FingerprintPro.ServerSdk.Model;

namespace FingerprintPro.ServerSdk.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IFingerprintApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get event by requestId
        /// </summary>
        /// <remarks>
        /// This endpoint allows you to get events with all the information from each activated product (Fingerprint Pro or Bot Detection). Use the requestId as a URL path :request_id parameter. This API method is scoped to a request, i.e. all returned information is by requestId.
        /// </remarks>
        /// <exception cref="FingerprintPro.ServerSdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestId">requestId is the unique identifier of each request</param>
        /// <returns>EventResponse</returns>
        EventResponse GetEvent(string requestId);

        /// <summary>
        /// Get event by requestId
        /// </summary>
        /// <remarks>
        /// This endpoint allows you to get events with all the information from each activated product (Fingerprint Pro or Bot Detection). Use the requestId as a URL path :request_id parameter. This API method is scoped to a request, i.e. all returned information is by requestId.
        /// </remarks>
        /// <exception cref="FingerprintPro.ServerSdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestId">requestId is the unique identifier of each request</param>
        /// <returns>ApiResponse of EventResponse</returns>
        ApiResponse<EventResponse> GetEventWithHttpInfo(string requestId);
        /// <summary>
        /// Get visits by visitorId
        /// </summary>
        /// <remarks>
        /// This endpoint allows you to get a history of visits with all available information. Use the visitorId as a URL path parameter. This API method is scoped to a visitor, i.e. all returned information is by visitorId.
        /// </remarks>
        /// <exception cref="FingerprintPro.ServerSdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="visitorId"></param>
        /// <param name="requestId">Filter visits by requestId (optional)</param>
        /// <param name="linkedId">Filter visits by custom identifier (optional)</param>
        /// <param name="limit">Limit scanned results (optional)</param>
        /// <param name="before">Used to paginate results (optional)</param>
        /// <returns>Response</returns>
        Response GetVisits(string visitorId, string requestId = null, string linkedId = null, int? limit = null, int? before = null);

        /// <summary>
        /// Get visits by visitorId
        /// </summary>
        /// <remarks>
        /// This endpoint allows you to get a history of visits with all available information. Use the visitorId as a URL path parameter. This API method is scoped to a visitor, i.e. all returned information is by visitorId.
        /// </remarks>
        /// <exception cref="FingerprintPro.ServerSdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="visitorId"></param>
        /// <param name="requestId">Filter visits by requestId (optional)</param>
        /// <param name="linkedId">Filter visits by custom identifier (optional)</param>
        /// <param name="limit">Limit scanned results (optional)</param>
        /// <param name="before">Used to paginate results (optional)</param>
        /// <returns>ApiResponse of Response</returns>
        ApiResponse<Response> GetVisitsWithHttpInfo(string visitorId, string requestId = null, string linkedId = null, int? limit = null, int? before = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get event by requestId
        /// </summary>
        /// <remarks>
        /// This endpoint allows you to get events with all the information from each activated product (Fingerprint Pro or Bot Detection). Use the requestId as a URL path :request_id parameter. This API method is scoped to a request, i.e. all returned information is by requestId.
        /// </remarks>
        /// <exception cref="FingerprintPro.ServerSdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestId">requestId is the unique identifier of each request</param>
        /// <returns>Task of EventResponse</returns>
        System.Threading.Tasks.Task<EventResponse> GetEventAsync(string requestId);

        /// <summary>
        /// Get event by requestId
        /// </summary>
        /// <remarks>
        /// This endpoint allows you to get events with all the information from each activated product (Fingerprint Pro or Bot Detection). Use the requestId as a URL path :request_id parameter. This API method is scoped to a request, i.e. all returned information is by requestId.
        /// </remarks>
        /// <exception cref="FingerprintPro.ServerSdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestId">requestId is the unique identifier of each request</param>
        /// <returns>Task of ApiResponse (EventResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<EventResponse>> GetEventAsyncWithHttpInfo(string requestId);
        /// <summary>
        /// Get visits by visitorId
        /// </summary>
        /// <remarks>
        /// This endpoint allows you to get a history of visits with all available information. Use the visitorId as a URL path parameter. This API method is scoped to a visitor, i.e. all returned information is by visitorId.
        /// </remarks>
        /// <exception cref="FingerprintPro.ServerSdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="visitorId"></param>
        /// <param name="requestId">Filter visits by requestId (optional)</param>
        /// <param name="linkedId">Filter visits by custom identifier (optional)</param>
        /// <param name="limit">Limit scanned results (optional)</param>
        /// <param name="before">Used to paginate results (optional)</param>
        /// <returns>Task of Response</returns>
        System.Threading.Tasks.Task<Response> GetVisitsAsync(string visitorId, string requestId = null, string linkedId = null, int? limit = null, int? before = null);

        /// <summary>
        /// Get visits by visitorId
        /// </summary>
        /// <remarks>
        /// This endpoint allows you to get a history of visits with all available information. Use the visitorId as a URL path parameter. This API method is scoped to a visitor, i.e. all returned information is by visitorId.
        /// </remarks>
        /// <exception cref="FingerprintPro.ServerSdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="visitorId"></param>
        /// <param name="requestId">Filter visits by requestId (optional)</param>
        /// <param name="linkedId">Filter visits by custom identifier (optional)</param>
        /// <param name="limit">Limit scanned results (optional)</param>
        /// <param name="before">Used to paginate results (optional)</param>
        /// <returns>Task of ApiResponse (Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<Response>> GetVisitsAsyncWithHttpInfo(string visitorId, string requestId = null, string linkedId = null, int? limit = null, int? before = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class FingerprintApi : IFingerprintApi
    {
        public const string Version = "1.0.0-test.9";

        private readonly ApiClient _apiClient;

        private FingerprintPro.ServerSdk.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="FingerprintApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public FingerprintApi(FingerprintPro.ServerSdk.Client.Configuration configuration)
        {
            Configuration = configuration;
            _apiClient = new ApiClient(configuration);

            ExceptionFactory = FingerprintPro.ServerSdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this._apiClient.RestClient.Options.BaseUrl!.ToString();
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public FingerprintPro.ServerSdk.Client.Configuration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public FingerprintPro.ServerSdk.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Get event by requestId This endpoint allows you to get events with all the information from each activated product (Fingerprint Pro or Bot Detection). Use the requestId as a URL path :request_id parameter. This API method is scoped to a request, i.e. all returned information is by requestId.
        /// </summary>
        /// <exception cref="FingerprintPro.ServerSdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestId">requestId is the unique identifier of each request</param>
        /// <returns>EventResponse</returns>
        public EventResponse GetEvent(string requestId)
        {
            ApiResponse<EventResponse> localVarResponse = GetEventWithHttpInfo(requestId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get event by requestId This endpoint allows you to get events with all the information from each activated product (Fingerprint Pro or Bot Detection). Use the requestId as a URL path :request_id parameter. This API method is scoped to a request, i.e. all returned information is by requestId.
        /// </summary>
        /// <exception cref="FingerprintPro.ServerSdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestId">requestId is the unique identifier of each request</param>
        /// <returns>ApiResponse of EventResponse</returns>
        public ApiResponse<EventResponse> GetEventWithHttpInfo(string requestId)
        {
            // verify the required parameter 'requestId' is set
            if (requestId == null)
                throw new ApiException(400, "Missing required parameter 'requestId' when calling FingerprintApi->GetEvent");

            var localVarPath = "/events/{request_id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            localVarQueryParams.Add(new KeyValuePair<string, string>("ii", "fingerprint-pro-server-api-dotnet-sdk/1.0.0-test.9"));

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                };
            String localVarHttpContentType = this._apiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                    "application/json"
                };
            String localVarHttpHeaderAccept = this._apiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (requestId != null) localVarPathParams.Add("request_id", this._apiClient.ParameterToString(requestId)); // path parameter
                                                                                                                       // authentication (ApiKeyHeader) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Auth-API-Key")))
            {
                localVarHeaderParams["Auth-API-Key"] = this.Configuration.GetApiKeyWithPrefix("Auth-API-Key");
            }
            // authentication (ApiKeyQuery) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(this._apiClient.ParameterToKeyValuePairs("", "api_key", this.Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            RestResponse localVarResponse = this._apiClient.CallApi(localVarPath,
            Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetEvent", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<EventResponse>(localVarStatusCode,
            localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
            (EventResponse)this._apiClient.Deserialize(localVarResponse, typeof(EventResponse)));
        }

        /// <summary>
        /// Get event by requestId This endpoint allows you to get events with all the information from each activated product (Fingerprint Pro or Bot Detection). Use the requestId as a URL path :request_id parameter. This API method is scoped to a request, i.e. all returned information is by requestId.
        /// </summary>
        /// <exception cref="FingerprintPro.ServerSdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestId">requestId is the unique identifier of each request</param>
        /// <returns>Task of EventResponse</returns>
        public async System.Threading.Tasks.Task<EventResponse> GetEventAsync(string requestId)
        {
            ApiResponse<EventResponse> localVarResponse = await GetEventAsyncWithHttpInfo(requestId);
            return localVarResponse.Data;

        }

        /// <summary>
        /// Get event by requestId This endpoint allows you to get events with all the information from each activated product (Fingerprint Pro or Bot Detection). Use the requestId as a URL path :request_id parameter. This API method is scoped to a request, i.e. all returned information is by requestId.
        /// </summary>
        /// <exception cref="FingerprintPro.ServerSdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestId">requestId is the unique identifier of each request</param>
        /// <returns>Task of ApiResponse (EventResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EventResponse>> GetEventAsyncWithHttpInfo(string requestId)
        {
            // verify the required parameter 'requestId' is set
            if (requestId == null)
                throw new ApiException(400, "Missing required parameter 'requestId' when calling FingerprintApi->GetEvent");

            var localVarPath = "/events/{request_id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            localVarQueryParams.Add(new KeyValuePair<string, string>("ii", "fingerprint-pro-server-api-dotnet-sdk/1.0.0-test.9"));

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                    };
            String localVarHttpContentType = this._apiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                        "application/json"
                    };
            String localVarHttpHeaderAccept = this._apiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (requestId != null) localVarPathParams.Add("request_id", this._apiClient.ParameterToString(requestId)); // path parameter
                                                                                                                       // authentication (ApiKeyHeader) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Auth-API-Key")))
            {
                localVarHeaderParams["Auth-API-Key"] = this.Configuration.GetApiKeyWithPrefix("Auth-API-Key");
            }
            // authentication (ApiKeyQuery) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(this._apiClient.ParameterToKeyValuePairs("", "api_key", this.Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            RestResponse localVarResponse = await this._apiClient.CallApiAsync(localVarPath,
            Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetEvent", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<EventResponse>(localVarStatusCode,
            localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
            (EventResponse)this._apiClient.Deserialize(localVarResponse, typeof(EventResponse)));
        }

        /// <summary>
        /// Get visits by visitorId This endpoint allows you to get a history of visits with all available information. Use the visitorId as a URL path parameter. This API method is scoped to a visitor, i.e. all returned information is by visitorId.
        /// </summary>
        /// <exception cref="FingerprintPro.ServerSdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="visitorId"></param>
        /// <param name="requestId">Filter visits by requestId (optional)</param>
        /// <param name="linkedId">Filter visits by custom identifier (optional)</param>
        /// <param name="limit">Limit scanned results (optional)</param>
        /// <param name="before">Used to paginate results (optional)</param>
        /// <returns>Response</returns>
        public Response GetVisits(string visitorId, string requestId = null, string linkedId = null, int? limit = null, int? before = null)
        {
            ApiResponse<Response> localVarResponse = GetVisitsWithHttpInfo(visitorId, requestId, linkedId, limit, before);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get visits by visitorId This endpoint allows you to get a history of visits with all available information. Use the visitorId as a URL path parameter. This API method is scoped to a visitor, i.e. all returned information is by visitorId.
        /// </summary>
        /// <exception cref="FingerprintPro.ServerSdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="visitorId"></param>
        /// <param name="requestId">Filter visits by requestId (optional)</param>
        /// <param name="linkedId">Filter visits by custom identifier (optional)</param>
        /// <param name="limit">Limit scanned results (optional)</param>
        /// <param name="before">Used to paginate results (optional)</param>
        /// <returns>ApiResponse of Response</returns>
        public ApiResponse<Response> GetVisitsWithHttpInfo(string visitorId, string requestId = null, string linkedId = null, int? limit = null, int? before = null)
        {
            // verify the required parameter 'visitorId' is set
            if (visitorId == null)
                throw new ApiException(400, "Missing required parameter 'visitorId' when calling FingerprintApi->GetVisits");

            var localVarPath = "/visitors/{visitor_id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            localVarQueryParams.Add(new KeyValuePair<string, string>("ii", "fingerprint-pro-server-api-dotnet-sdk/1.0.0-test.9"));

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                };
            String localVarHttpContentType = this._apiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                    "application/json"
                };
            String localVarHttpHeaderAccept = this._apiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (visitorId != null) localVarPathParams.Add("visitor_id", this._apiClient.ParameterToString(visitorId)); // path parameter
            if (requestId != null) localVarQueryParams.AddRange(this._apiClient.ParameterToKeyValuePairs("", "request_id", requestId)); // query parameter
            if (linkedId != null) localVarQueryParams.AddRange(this._apiClient.ParameterToKeyValuePairs("", "linked_id", linkedId)); // query parameter
            if (limit != null) localVarQueryParams.AddRange(this._apiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter
            if (before != null) localVarQueryParams.AddRange(this._apiClient.ParameterToKeyValuePairs("", "before", before)); // query parameter
                                                                                                                              // authentication (ApiKeyHeader) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Auth-API-Key")))
            {
                localVarHeaderParams["Auth-API-Key"] = this.Configuration.GetApiKeyWithPrefix("Auth-API-Key");
            }
            // authentication (ApiKeyQuery) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(this._apiClient.ParameterToKeyValuePairs("", "api_key", this.Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            RestResponse localVarResponse = this._apiClient.CallApi(localVarPath,
            Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetVisits", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Response>(localVarStatusCode,
            localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
            (Response)this._apiClient.Deserialize(localVarResponse, typeof(Response)));
        }

        /// <summary>
        /// Get visits by visitorId This endpoint allows you to get a history of visits with all available information. Use the visitorId as a URL path parameter. This API method is scoped to a visitor, i.e. all returned information is by visitorId.
        /// </summary>
        /// <exception cref="FingerprintPro.ServerSdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="visitorId"></param>
        /// <param name="requestId">Filter visits by requestId (optional)</param>
        /// <param name="linkedId">Filter visits by custom identifier (optional)</param>
        /// <param name="limit">Limit scanned results (optional)</param>
        /// <param name="before">Used to paginate results (optional)</param>
        /// <returns>Task of Response</returns>
        public async System.Threading.Tasks.Task<Response> GetVisitsAsync(string visitorId, string requestId = null, string linkedId = null, int? limit = null, int? before = null)
        {
            ApiResponse<Response> localVarResponse = await GetVisitsAsyncWithHttpInfo(visitorId, requestId, linkedId, limit, before);
            return localVarResponse.Data;

        }

        /// <summary>
        /// Get visits by visitorId This endpoint allows you to get a history of visits with all available information. Use the visitorId as a URL path parameter. This API method is scoped to a visitor, i.e. all returned information is by visitorId.
        /// </summary>
        /// <exception cref="FingerprintPro.ServerSdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="visitorId"></param>
        /// <param name="requestId">Filter visits by requestId (optional)</param>
        /// <param name="linkedId">Filter visits by custom identifier (optional)</param>
        /// <param name="limit">Limit scanned results (optional)</param>
        /// <param name="before">Used to paginate results (optional)</param>
        /// <returns>Task of ApiResponse (Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Response>> GetVisitsAsyncWithHttpInfo(string visitorId, string requestId = null, string linkedId = null, int? limit = null, int? before = null)
        {
            // verify the required parameter 'visitorId' is set
            if (visitorId == null)
                throw new ApiException(400, "Missing required parameter 'visitorId' when calling FingerprintApi->GetVisits");

            var localVarPath = "/visitors/{visitor_id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            localVarQueryParams.Add(new KeyValuePair<string, string>("ii", "fingerprint-pro-server-api-dotnet-sdk/1.0.0-test.9"));

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                    };
            String localVarHttpContentType = this._apiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                        "application/json"
                    };
            String localVarHttpHeaderAccept = this._apiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (visitorId != null) localVarPathParams.Add("visitor_id", this._apiClient.ParameterToString(visitorId)); // path parameter
            if (requestId != null) localVarQueryParams.AddRange(this._apiClient.ParameterToKeyValuePairs("", "request_id", requestId)); // query parameter
            if (linkedId != null) localVarQueryParams.AddRange(this._apiClient.ParameterToKeyValuePairs("", "linked_id", linkedId)); // query parameter
            if (limit != null) localVarQueryParams.AddRange(this._apiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter
            if (before != null) localVarQueryParams.AddRange(this._apiClient.ParameterToKeyValuePairs("", "before", before)); // query parameter
                                                                                                                              // authentication (ApiKeyHeader) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Auth-API-Key")))
            {
                localVarHeaderParams["Auth-API-Key"] = this.Configuration.GetApiKeyWithPrefix("Auth-API-Key");
            }
            // authentication (ApiKeyQuery) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("api_key")))
            {
                localVarQueryParams.AddRange(this._apiClient.ParameterToKeyValuePairs("", "api_key", this.Configuration.GetApiKeyWithPrefix("api_key")));
            }

            // make the HTTP request
            RestResponse localVarResponse = await this._apiClient.CallApiAsync(localVarPath,
            Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetVisits", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Response>(localVarStatusCode,
            localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
            (Response)this._apiClient.Deserialize(localVarResponse, typeof(Response)));
        }

    }
}