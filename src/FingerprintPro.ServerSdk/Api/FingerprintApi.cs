/* 
 * Fingerprint Pro Server API
 *
 * Fingerprint Pro Server API allows you to get information about visitors and about individual events in a server environment. It can be used for data exports, decision-making, and data analysis scenarios. Server API is intended for server-side usage, it's not intended to be used from the client side, whether it's a browser or a mobile device. 
 *
 * OpenAPI spec version: 3
 * Contact: support@fingerprint.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using FingerprintPro.ServerSdk.Client;
using FingerprintPro.ServerSdk.Model;

namespace FingerprintPro.ServerSdk.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IFingerprintApi
    {

        #region Synchronous Operations
        /// <summary>
        /// Delete data by visitor ID
        /// </summary>
        /// <remarks>
        /// Request deleting all data associated with the specified visitor ID. This API is useful for compliance with privacy regulations. All delete requests are queued:   * Recent data (10 days or newer) belonging to the specified visitor will be deleted within 24 hours. * Data from older (11 days or more) identification events  will be deleted after 90 days.  If you are interested in using this API, please [contact our support team](https://fingerprint.com/support/) to activate it for you. Otherwise, you will receive a 403. 
        /// </remarks>
        /// <exception cref="FingerprintPro.ServerSdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="visitorId">The [visitor ID](https://dev.fingerprint.com/docs/js-agent#visitorid) you want to delete.</param>
        /// <returns></returns>
        void DeleteVisitorData(string visitorId);

        /// <summary>
        /// Delete data by visitor ID
        /// </summary>
        /// <remarks>
        /// Request deleting all data associated with the specified visitor ID. This API is useful for compliance with privacy regulations. All delete requests are queued:   * Recent data (10 days or newer) belonging to the specified visitor will be deleted within 24 hours. * Data from older (11 days or more) identification events  will be deleted after 90 days.  If you are interested in using this API, please [contact our support team](https://fingerprint.com/support/) to activate it for you. Otherwise, you will receive a 403. 
        /// </remarks>
        /// <exception cref="FingerprintPro.ServerSdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="visitorId">The [visitor ID](https://dev.fingerprint.com/docs/js-agent#visitorid) you want to delete.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteVisitorDataWithHttpInfo(string visitorId);
        /// <summary>
        /// Get event by request ID
        /// </summary>
        /// <remarks>
        /// Get a detailed analysis of an individual identification event, including Smart Signals.  **Only for Enterprise customers:** Please note that the response includes mobile signals (e.g. `rootApps`) even if the request originated from a non-mobile platform. It is highly recommended that you **ignore** the mobile signals for such requests.   Use `requestId` as the URL path parameter. This API method is scoped to a request, i.e. all returned information is by `requestId`. 
        /// </remarks>
        /// <exception cref="FingerprintPro.ServerSdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestId">The unique [identifier](https://dev.fingerprint.com/docs/js-agent#requestid) of each identification request.</param>
        /// <returns>EventResponse</returns>
        EventResponse GetEvent(string requestId);

        /// <summary>
        /// Get event by request ID
        /// </summary>
        /// <remarks>
        /// Get a detailed analysis of an individual identification event, including Smart Signals.  **Only for Enterprise customers:** Please note that the response includes mobile signals (e.g. `rootApps`) even if the request originated from a non-mobile platform. It is highly recommended that you **ignore** the mobile signals for such requests.   Use `requestId` as the URL path parameter. This API method is scoped to a request, i.e. all returned information is by `requestId`. 
        /// </remarks>
        /// <exception cref="FingerprintPro.ServerSdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestId">The unique [identifier](https://dev.fingerprint.com/docs/js-agent#requestid) of each identification request.</param>
        /// <returns>ApiResponse of EventResponse</returns>
        ApiResponse<EventResponse> GetEventWithHttpInfo(string requestId);
        /// <summary>
        /// Get visits by visitor ID
        /// </summary>
        /// <remarks>
        /// Get a history of visits (identification events) for a specific `visitorId`. Use the `visitorId` as a URL path parameter. Only information from the _Identification_ product is returned.  #### Headers  * `Retry-After` — Present in case of `429 Too many requests`. Indicates how long you should wait before making a follow-up request. The value is non-negative decimal integer indicating the seconds to delay after the response is received. 
        /// </remarks>
        /// <exception cref="FingerprintPro.ServerSdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="visitorId">Unique [visitor identifier](https://dev.fingerprint.com/docs/js-agent#visitorid) issued by Fingerprint Pro.</param>
        /// <param name="requestId">Filter visits by `requestId`.   Every identification request has a unique identifier associated with it called `requestId`. This identifier is returned to the client in the identification [result](https://dev.fingerprint.com/docs/js-agent#requestid). When you filter visits by `requestId`, only one visit will be returned.  (optional)</param>
        /// <param name="linkedId">Filter visits by your custom identifier.   You can use [`linkedId`](https://dev.fingerprint.com/docs/js-agent#linkedid) to associate identification requests with your own identifier, for example: session ID, purchase ID, or transaction ID. You can then use this `linked_id` parameter to retrieve all events associated with your custom identifier.  (optional)</param>
        /// <param name="limit">Limit scanned results.   For performance reasons, the API first scans some number of events before filtering them. Use `limit` to specify how many events are scanned before they are filtered by `requestId` or `linkedId`. Results are always returned sorted by the timestamp (most recent first). By default, the most recent 100 visits are scanned, the maximum is 500.  (optional)</param>
        /// <param name="paginationKey">Use `paginationKey` to get the next page of results.   When more results are available (e.g., you requested 200 results using `limit` parameter, but a total of 600 results are available), the `paginationKey` top-level attribute is added to the response. The key corresponds to the `requestId` of the last returned event. In the following request, use that value in the `paginationKey` parameter to get the next page of results:  1. First request, returning most recent 200 events: `GET api-base-url/visitors/:visitorId?limit=200` 2. Use `response.paginationKey` to get the next page of results: `GET api-base-url/visitors/:visitorId?limit=200&paginationKey=1683900801733.Ogvu1j`  Pagination happens during scanning and before filtering, so you can get less visits than the `limit` you specified with more available on the next page. When there are no more results available for scanning, the `paginationKey` attribute is not returned.  (optional)</param>
        /// <param name="before">⚠️ Deprecated pagination method, please use `paginationKey` instead. Timestamp (in milliseconds since epoch) used to paginate results.  (optional)</param>
        /// <returns>Response</returns>
        Response GetVisits(string visitorId, string requestId = null!, string linkedId = null!, int? limit = null!, string paginationKey = null!, long? before = null!);

        /// <summary>
        /// Get visits by visitor ID
        /// </summary>
        /// <remarks>
        /// Get a history of visits (identification events) for a specific `visitorId`. Use the `visitorId` as a URL path parameter. Only information from the _Identification_ product is returned.  #### Headers  * `Retry-After` — Present in case of `429 Too many requests`. Indicates how long you should wait before making a follow-up request. The value is non-negative decimal integer indicating the seconds to delay after the response is received. 
        /// </remarks>
        /// <exception cref="FingerprintPro.ServerSdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="visitorId">Unique [visitor identifier](https://dev.fingerprint.com/docs/js-agent#visitorid) issued by Fingerprint Pro.</param>
        /// <param name="requestId">Filter visits by `requestId`.   Every identification request has a unique identifier associated with it called `requestId`. This identifier is returned to the client in the identification [result](https://dev.fingerprint.com/docs/js-agent#requestid). When you filter visits by `requestId`, only one visit will be returned.  (optional)</param>
        /// <param name="linkedId">Filter visits by your custom identifier.   You can use [`linkedId`](https://dev.fingerprint.com/docs/js-agent#linkedid) to associate identification requests with your own identifier, for example: session ID, purchase ID, or transaction ID. You can then use this `linked_id` parameter to retrieve all events associated with your custom identifier.  (optional)</param>
        /// <param name="limit">Limit scanned results.   For performance reasons, the API first scans some number of events before filtering them. Use `limit` to specify how many events are scanned before they are filtered by `requestId` or `linkedId`. Results are always returned sorted by the timestamp (most recent first). By default, the most recent 100 visits are scanned, the maximum is 500.  (optional)</param>
        /// <param name="paginationKey">Use `paginationKey` to get the next page of results.   When more results are available (e.g., you requested 200 results using `limit` parameter, but a total of 600 results are available), the `paginationKey` top-level attribute is added to the response. The key corresponds to the `requestId` of the last returned event. In the following request, use that value in the `paginationKey` parameter to get the next page of results:  1. First request, returning most recent 200 events: `GET api-base-url/visitors/:visitorId?limit=200` 2. Use `response.paginationKey` to get the next page of results: `GET api-base-url/visitors/:visitorId?limit=200&paginationKey=1683900801733.Ogvu1j`  Pagination happens during scanning and before filtering, so you can get less visits than the `limit` you specified with more available on the next page. When there are no more results available for scanning, the `paginationKey` attribute is not returned.  (optional)</param>
        /// <param name="before">⚠️ Deprecated pagination method, please use `paginationKey` instead. Timestamp (in milliseconds since epoch) used to paginate results.  (optional)</param>
        /// <returns>ApiResponse of Response</returns>
        ApiResponse<Response> GetVisitsWithHttpInfo(string visitorId, string requestId = null!, string linkedId = null!, int? limit = null!, string paginationKey = null!, long? before = null!);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Delete data by visitor ID
        /// </summary>
        /// <remarks>
        /// Request deleting all data associated with the specified visitor ID. This API is useful for compliance with privacy regulations. All delete requests are queued:   * Recent data (10 days or newer) belonging to the specified visitor will be deleted within 24 hours. * Data from older (11 days or more) identification events  will be deleted after 90 days.  If you are interested in using this API, please [contact our support team](https://fingerprint.com/support/) to activate it for you. Otherwise, you will receive a 403. 
        /// </remarks>
        /// <exception cref="FingerprintPro.ServerSdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="visitorId">The [visitor ID](https://dev.fingerprint.com/docs/js-agent#visitorid) you want to delete.</param>
        /// <returns>Task of void</returns>
        Task DeleteVisitorDataAsync(string visitorId);

        /// <summary>
        /// Delete data by visitor IDe
        /// </summary>
        /// <remarks>
        /// Request deleting all data associated with the specified visitor ID. This API is useful for compliance with privacy regulations. All delete requests are queued:   * Recent data (10 days or newer) belonging to the specified visitor will be deleted within 24 hours. * Data from older (11 days or more) identification events  will be deleted after 90 days.  If you are interested in using this API, please [contact our support team](https://fingerprint.com/support/) to activate it for you. Otherwise, you will receive a 403. 
        /// </remarks>
        /// <exception cref="FingerprintPro.ServerSdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="visitorId">The [visitor ID](https://dev.fingerprint.com/docs/js-agent#visitorid) you want to delete.</param>
        /// <returns>Task of ApiResponse</returns>
        Task<ApiResponse<Object>> DeleteVisitorDataAsyncWithHttpInfo(string visitorId);
        /// <summary>
        /// Get event by request ID
        /// </summary>
        /// <remarks>
        /// Get a detailed analysis of an individual identification event, including Smart Signals.  **Only for Enterprise customers:** Please note that the response includes mobile signals (e.g. `rootApps`) even if the request originated from a non-mobile platform. It is highly recommended that you **ignore** the mobile signals for such requests.   Use `requestId` as the URL path parameter. This API method is scoped to a request, i.e. all returned information is by `requestId`. 
        /// </remarks>
        /// <exception cref="FingerprintPro.ServerSdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestId">The unique [identifier](https://dev.fingerprint.com/docs/js-agent#requestid) of each identification request.</param>
        /// <returns>Task of EventResponse</returns>
        Task<EventResponse> GetEventAsync(string requestId);

        /// <summary>
        /// Get event by request IDe
        /// </summary>
        /// <remarks>
        /// Get a detailed analysis of an individual identification event, including Smart Signals.  **Only for Enterprise customers:** Please note that the response includes mobile signals (e.g. `rootApps`) even if the request originated from a non-mobile platform. It is highly recommended that you **ignore** the mobile signals for such requests.   Use `requestId` as the URL path parameter. This API method is scoped to a request, i.e. all returned information is by `requestId`. 
        /// </remarks>
        /// <exception cref="FingerprintPro.ServerSdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestId">The unique [identifier](https://dev.fingerprint.com/docs/js-agent#requestid) of each identification request.</param>
        /// <returns>Task of ApiResponse (EventResponse)</returns>
        Task<ApiResponse<EventResponse>> GetEventAsyncWithHttpInfo(string requestId);
        /// <summary>
        /// Get visits by visitor ID
        /// </summary>
        /// <remarks>
        /// Get a history of visits (identification events) for a specific `visitorId`. Use the `visitorId` as a URL path parameter. Only information from the _Identification_ product is returned.  #### Headers  * `Retry-After` — Present in case of `429 Too many requests`. Indicates how long you should wait before making a follow-up request. The value is non-negative decimal integer indicating the seconds to delay after the response is received. 
        /// </remarks>
        /// <exception cref="FingerprintPro.ServerSdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="visitorId">Unique [visitor identifier](https://dev.fingerprint.com/docs/js-agent#visitorid) issued by Fingerprint Pro.</param>
        /// <param name="requestId">Filter visits by `requestId`.   Every identification request has a unique identifier associated with it called `requestId`. This identifier is returned to the client in the identification [result](https://dev.fingerprint.com/docs/js-agent#requestid). When you filter visits by `requestId`, only one visit will be returned.  (optional)</param>
        /// <param name="linkedId">Filter visits by your custom identifier.   You can use [`linkedId`](https://dev.fingerprint.com/docs/js-agent#linkedid) to associate identification requests with your own identifier, for example: session ID, purchase ID, or transaction ID. You can then use this `linked_id` parameter to retrieve all events associated with your custom identifier.  (optional)</param>
        /// <param name="limit">Limit scanned results.   For performance reasons, the API first scans some number of events before filtering them. Use `limit` to specify how many events are scanned before they are filtered by `requestId` or `linkedId`. Results are always returned sorted by the timestamp (most recent first). By default, the most recent 100 visits are scanned, the maximum is 500.  (optional)</param>
        /// <param name="paginationKey">Use `paginationKey` to get the next page of results.   When more results are available (e.g., you requested 200 results using `limit` parameter, but a total of 600 results are available), the `paginationKey` top-level attribute is added to the response. The key corresponds to the `requestId` of the last returned event. In the following request, use that value in the `paginationKey` parameter to get the next page of results:  1. First request, returning most recent 200 events: `GET api-base-url/visitors/:visitorId?limit=200` 2. Use `response.paginationKey` to get the next page of results: `GET api-base-url/visitors/:visitorId?limit=200&paginationKey=1683900801733.Ogvu1j`  Pagination happens during scanning and before filtering, so you can get less visits than the `limit` you specified with more available on the next page. When there are no more results available for scanning, the `paginationKey` attribute is not returned.  (optional)</param>
        /// <param name="before">⚠️ Deprecated pagination method, please use `paginationKey` instead. Timestamp (in milliseconds since epoch) used to paginate results.  (optional)</param>
        /// <returns>Task of Response</returns>
        Task<Response> GetVisitsAsync(string visitorId, string requestId = null!, string linkedId = null!, int? limit = null!, string paginationKey = null!, long? before = null!);

        /// <summary>
        /// Get visits by visitor IDe
        /// </summary>
        /// <remarks>
        /// Get a history of visits (identification events) for a specific `visitorId`. Use the `visitorId` as a URL path parameter. Only information from the _Identification_ product is returned.  #### Headers  * `Retry-After` — Present in case of `429 Too many requests`. Indicates how long you should wait before making a follow-up request. The value is non-negative decimal integer indicating the seconds to delay after the response is received. 
        /// </remarks>
        /// <exception cref="FingerprintPro.ServerSdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="visitorId">Unique [visitor identifier](https://dev.fingerprint.com/docs/js-agent#visitorid) issued by Fingerprint Pro.</param>
        /// <param name="requestId">Filter visits by `requestId`.   Every identification request has a unique identifier associated with it called `requestId`. This identifier is returned to the client in the identification [result](https://dev.fingerprint.com/docs/js-agent#requestid). When you filter visits by `requestId`, only one visit will be returned.  (optional)</param>
        /// <param name="linkedId">Filter visits by your custom identifier.   You can use [`linkedId`](https://dev.fingerprint.com/docs/js-agent#linkedid) to associate identification requests with your own identifier, for example: session ID, purchase ID, or transaction ID. You can then use this `linked_id` parameter to retrieve all events associated with your custom identifier.  (optional)</param>
        /// <param name="limit">Limit scanned results.   For performance reasons, the API first scans some number of events before filtering them. Use `limit` to specify how many events are scanned before they are filtered by `requestId` or `linkedId`. Results are always returned sorted by the timestamp (most recent first). By default, the most recent 100 visits are scanned, the maximum is 500.  (optional)</param>
        /// <param name="paginationKey">Use `paginationKey` to get the next page of results.   When more results are available (e.g., you requested 200 results using `limit` parameter, but a total of 600 results are available), the `paginationKey` top-level attribute is added to the response. The key corresponds to the `requestId` of the last returned event. In the following request, use that value in the `paginationKey` parameter to get the next page of results:  1. First request, returning most recent 200 events: `GET api-base-url/visitors/:visitorId?limit=200` 2. Use `response.paginationKey` to get the next page of results: `GET api-base-url/visitors/:visitorId?limit=200&paginationKey=1683900801733.Ogvu1j`  Pagination happens during scanning and before filtering, so you can get less visits than the `limit` you specified with more available on the next page. When there are no more results available for scanning, the `paginationKey` attribute is not returned.  (optional)</param>
        /// <param name="before">⚠️ Deprecated pagination method, please use `paginationKey` instead. Timestamp (in milliseconds since epoch) used to paginate results.  (optional)</param>
        /// <returns>Task of ApiResponse (Response)</returns>
        Task<ApiResponse<Response>> GetVisitsAsyncWithHttpInfo(string visitorId, string requestId = null!, string linkedId = null!, int? limit = null!, string paginationKey = null!, long? before = null!);
        #endregion Asynchronous Operations
    }


    internal class DeleteVisitorDataDefinition : OperationDefinition
    {
        public override string Path => "/visitors/{visitor_id}";

        public override string OperationName => "DeleteVisitorData";

        public override string[] PathParams => new[] { "visitor_id", };

        public override Dictionary<int, Type> ResponseStatusCodeMap => new()
            {
                {
                    403, typeof(ErrorCommon403Response)
                },
                {
                    404, typeof(ErrorVisitsDelete404Response)
                },
            };
    }
    internal class GetEventDefinition : OperationDefinition
    {
        public override string Path => "/events/{request_id}";

        public override string OperationName => "GetEvent";

        public override string[] PathParams => new[] { "request_id", };

        public override Dictionary<int, Type> ResponseStatusCodeMap => new()
            {
                {
                    200, typeof(EventResponse)
                },
                {
                    403, typeof(ErrorCommon403Response)
                },
                {
                    404, typeof(ErrorEvent404Response)
                },
            };
    }
    internal class GetVisitsDefinition : OperationDefinition
    {
        public override string Path => "/visitors/{visitor_id}";

        public override string OperationName => "GetVisits";

        public override string[] PathParams => new[] { "visitor_id", };

        public override Dictionary<int, Type> ResponseStatusCodeMap => new()
            {
                {
                    200, typeof(Response)
                },
                {
                    403, typeof(ErrorVisits403)
                },
                {
                    429, typeof(ManyRequestsResponse)
                },
            };
    }

}
