/* 
 * Fingerprint Pro Server API
 *
 * Fingerprint Pro Server API allows you to get information about visitors and about individual events in a server environment. This API can be used for data exports, decision-making, and data analysis scenarios.
 *
 * OpenAPI spec version: 3
 * Contact: support@fingerprint.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace FingerprintPro.ServerSdk.Model
{
    /// <summary>
    /// WebhookVisit
    /// </summary>
    [DataContract]
    public partial class WebhookVisit : IEquatable<WebhookVisit>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookVisit" /> class.
        /// </summary>
        /// <param name="visitorId">visitorId (required).</param>
        /// <param name="clientReferrer">clientReferrer.</param>
        /// <param name="requestId">Unique identifier of the user&#x27;s identification request. (required).</param>
        /// <param name="browserDetails">browserDetails (required).</param>
        /// <param name="incognito">Flag if user used incognito session. (required).</param>
        /// <param name="ip">ip (required).</param>
        /// <param name="ipLocation">ipLocation (required).</param>
        /// <param name="timestamp">Timestamp of the event with millisecond precision in Unix time. (required).</param>
        /// <param name="time">Time expressed according to ISO 8601 in UTC format. (required).</param>
        /// <param name="url">Page URL from which identification request was sent. (required).</param>
        /// <param name="tag">A customer-provided value or an object that was sent with identification request..</param>
        /// <param name="linkedId">A customer-provided id that was sent with identification request..</param>
        /// <param name="confidence">confidence (required).</param>
        /// <param name="visitorFound">Attribute represents if a visitor had been identified before. (required).</param>
        /// <param name="firstSeenAt">firstSeenAt (required).</param>
        /// <param name="lastSeenAt">lastSeenAt (required).</param>
        public WebhookVisit(string visitorId = default(string), string clientReferrer = default(string), string requestId = default(string), BrowserDetails browserDetails = default(BrowserDetails), bool? incognito = default(bool?), string ip = default(string), IPLocation ipLocation = default(IPLocation), long? timestamp = default(long?), DateTime? time = default(DateTime?), string url = default(string), Dictionary<string, Object> tag = default(Dictionary<string, Object>), string linkedId = default(string), Confidence confidence = default(Confidence), bool? visitorFound = default(bool?), SeenAt firstSeenAt = default(SeenAt), SeenAt lastSeenAt = default(SeenAt))
        {
            // to ensure "visitorId" is required (not null)

            if (visitorId == null)
            {
                throw new InvalidDataException("visitorId is a required property for WebhookVisit and cannot be null");
            }
            else
            {
                this.VisitorId = visitorId;
            }
            // to ensure "requestId" is required (not null)

            if (requestId == null)
            {
                throw new InvalidDataException("requestId is a required property for WebhookVisit and cannot be null");
            }
            else
            {
                this.RequestId = requestId;
            }
            // to ensure "browserDetails" is required (not null)

            if (browserDetails == null)
            {
                throw new InvalidDataException("browserDetails is a required property for WebhookVisit and cannot be null");
            }
            else
            {
                this.BrowserDetails = browserDetails;
            }
            // to ensure "incognito" is required (not null)

            if (incognito == null)
            {
                throw new InvalidDataException("incognito is a required property for WebhookVisit and cannot be null");
            }
            else
            {
                this.Incognito = incognito;
            }
            // to ensure "ip" is required (not null)

            if (ip == null)
            {
                throw new InvalidDataException("ip is a required property for WebhookVisit and cannot be null");
            }
            else
            {
                this.Ip = ip;
            }
            // to ensure "ipLocation" is required (not null)

            if (ipLocation == null)
            {
                throw new InvalidDataException("ipLocation is a required property for WebhookVisit and cannot be null");
            }
            else
            {
                this.IpLocation = ipLocation;
            }
            // to ensure "timestamp" is required (not null)

            if (timestamp == null)
            {
                throw new InvalidDataException("timestamp is a required property for WebhookVisit and cannot be null");
            }
            else
            {
                this.Timestamp = timestamp;
            }
            // to ensure "time" is required (not null)

            if (time == null)
            {
                throw new InvalidDataException("time is a required property for WebhookVisit and cannot be null");
            }
            else
            {
                this.Time = time;
            }
            // to ensure "url" is required (not null)

            if (url == null)
            {
                throw new InvalidDataException("url is a required property for WebhookVisit and cannot be null");
            }
            else
            {
                this.Url = url;
            }
            // to ensure "confidence" is required (not null)

            if (confidence == null)
            {
                throw new InvalidDataException("confidence is a required property for WebhookVisit and cannot be null");
            }
            else
            {
                this.Confidence = confidence;
            }
            // to ensure "visitorFound" is required (not null)

            if (visitorFound == null)
            {
                throw new InvalidDataException("visitorFound is a required property for WebhookVisit and cannot be null");
            }
            else
            {
                this.VisitorFound = visitorFound;
            }
            // to ensure "firstSeenAt" is required (not null)

            if (firstSeenAt == null)
            {
                throw new InvalidDataException("firstSeenAt is a required property for WebhookVisit and cannot be null");
            }
            else
            {
                this.FirstSeenAt = firstSeenAt;
            }
            // to ensure "lastSeenAt" is required (not null)

            if (lastSeenAt == null)
            {
                throw new InvalidDataException("lastSeenAt is a required property for WebhookVisit and cannot be null");
            }
            else
            {
                this.LastSeenAt = lastSeenAt;
            }
            this.ClientReferrer = clientReferrer;
            this.Tag = tag;
            this.LinkedId = linkedId;
        }

        /// <summary>
        /// Gets or Sets VisitorId
        /// </summary>
        [DataMember(Name = "visitorId", EmitDefaultValue = false)]
        public string VisitorId { get; set; }

        /// <summary>
        /// Gets or Sets ClientReferrer
        /// </summary>
        [DataMember(Name = "clientReferrer", EmitDefaultValue = false)]
        public string ClientReferrer { get; set; }

        /// <summary>
        /// Unique identifier of the user&#x27;s identification request.
        /// </summary>
        /// <value>Unique identifier of the user&#x27;s identification request.</value>
        [DataMember(Name = "requestId", EmitDefaultValue = false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Gets or Sets BrowserDetails
        /// </summary>
        [DataMember(Name = "browserDetails", EmitDefaultValue = false)]
        public BrowserDetails BrowserDetails { get; set; }

        /// <summary>
        /// Flag if user used incognito session.
        /// </summary>
        /// <value>Flag if user used incognito session.</value>
        [DataMember(Name = "incognito", EmitDefaultValue = false)]
        public bool? Incognito { get; set; }

        /// <summary>
        /// Gets or Sets Ip
        /// </summary>
        [DataMember(Name = "ip", EmitDefaultValue = false)]
        public string Ip { get; set; }

        /// <summary>
        /// Gets or Sets IpLocation
        /// </summary>
        [DataMember(Name = "ipLocation", EmitDefaultValue = false)]
        public IPLocation IpLocation { get; set; }

        /// <summary>
        /// Timestamp of the event with millisecond precision in Unix time.
        /// </summary>
        /// <value>Timestamp of the event with millisecond precision in Unix time.</value>
        [DataMember(Name = "timestamp", EmitDefaultValue = false)]
        public long? Timestamp { get; set; }

        /// <summary>
        /// Time expressed according to ISO 8601 in UTC format.
        /// </summary>
        /// <value>Time expressed according to ISO 8601 in UTC format.</value>
        [DataMember(Name = "time", EmitDefaultValue = false)]
        public DateTime? Time { get; set; }

        /// <summary>
        /// Page URL from which identification request was sent.
        /// </summary>
        /// <value>Page URL from which identification request was sent.</value>
        [DataMember(Name = "url", EmitDefaultValue = false)]
        public string Url { get; set; }

        /// <summary>
        /// A customer-provided value or an object that was sent with identification request.
        /// </summary>
        /// <value>A customer-provided value or an object that was sent with identification request.</value>
        [DataMember(Name = "tag", EmitDefaultValue = false)]
        public Dictionary<string, Object> Tag { get; set; }

        /// <summary>
        /// A customer-provided id that was sent with identification request.
        /// </summary>
        /// <value>A customer-provided id that was sent with identification request.</value>
        [DataMember(Name = "linkedId", EmitDefaultValue = false)]
        public string LinkedId { get; set; }

        /// <summary>
        /// Gets or Sets Confidence
        /// </summary>
        [DataMember(Name = "confidence", EmitDefaultValue = false)]
        public Confidence Confidence { get; set; }

        /// <summary>
        /// Attribute represents if a visitor had been identified before.
        /// </summary>
        /// <value>Attribute represents if a visitor had been identified before.</value>
        [DataMember(Name = "visitorFound", EmitDefaultValue = false)]
        public bool? VisitorFound { get; set; }

        /// <summary>
        /// Gets or Sets FirstSeenAt
        /// </summary>
        [DataMember(Name = "firstSeenAt", EmitDefaultValue = false)]
        public SeenAt FirstSeenAt { get; set; }

        /// <summary>
        /// Gets or Sets LastSeenAt
        /// </summary>
        [DataMember(Name = "lastSeenAt", EmitDefaultValue = false)]
        public SeenAt LastSeenAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebhookVisit {\n");
            sb.Append("  VisitorId: ").Append(VisitorId).Append("\n");
            sb.Append("  ClientReferrer: ").Append(ClientReferrer).Append("\n");
            sb.Append("  RequestId: ").Append(RequestId).Append("\n");
            sb.Append("  BrowserDetails: ").Append(BrowserDetails).Append("\n");
            sb.Append("  Incognito: ").Append(Incognito).Append("\n");
            sb.Append("  Ip: ").Append(Ip).Append("\n");
            sb.Append("  IpLocation: ").Append(IpLocation).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Tag: ").Append(Tag).Append("\n");
            sb.Append("  LinkedId: ").Append(LinkedId).Append("\n");
            sb.Append("  Confidence: ").Append(Confidence).Append("\n");
            sb.Append("  VisitorFound: ").Append(VisitorFound).Append("\n");
            sb.Append("  FirstSeenAt: ").Append(FirstSeenAt).Append("\n");
            sb.Append("  LastSeenAt: ").Append(LastSeenAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if WebhookVisit instances are equal
        /// </summary>
        /// <param name="input">Instance of WebhookVisit to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhookVisit input)
        {
            if (input == null)
                return false;

            return
                (
                this.VisitorId == input.VisitorId ||
                (this.VisitorId != null &&
                this.VisitorId.Equals(input.VisitorId))
                ) &&
                (
                this.ClientReferrer == input.ClientReferrer ||
                (this.ClientReferrer != null &&
                this.ClientReferrer.Equals(input.ClientReferrer))
                ) &&
                (
                this.RequestId == input.RequestId ||
                (this.RequestId != null &&
                this.RequestId.Equals(input.RequestId))
                ) &&
                (
                this.BrowserDetails == input.BrowserDetails ||
                (this.BrowserDetails != null &&
                this.BrowserDetails.Equals(input.BrowserDetails))
                ) &&
                (
                this.Incognito == input.Incognito ||
                (this.Incognito != null &&
                this.Incognito.Equals(input.Incognito))
                ) &&
                (
                this.Ip == input.Ip ||
                (this.Ip != null &&
                this.Ip.Equals(input.Ip))
                ) &&
                (
                this.IpLocation == input.IpLocation ||
                (this.IpLocation != null &&
                this.IpLocation.Equals(input.IpLocation))
                ) &&
                (
                this.Timestamp == input.Timestamp ||
                (this.Timestamp != null &&
                this.Timestamp.Equals(input.Timestamp))
                ) &&
                (
                this.Time == input.Time ||
                (this.Time != null &&
                this.Time.Equals(input.Time))
                ) &&
                (
                this.Url == input.Url ||
                (this.Url != null &&
                this.Url.Equals(input.Url))
                ) &&
                (
                this.Tag == input.Tag ||
                this.Tag != null &&
                input.Tag != null &&
                this.Tag.SequenceEqual(input.Tag)
                ) &&
                (
                this.LinkedId == input.LinkedId ||
                (this.LinkedId != null &&
                this.LinkedId.Equals(input.LinkedId))
                ) &&
                (
                this.Confidence == input.Confidence ||
                (this.Confidence != null &&
                this.Confidence.Equals(input.Confidence))
                ) &&
                (
                this.VisitorFound == input.VisitorFound ||
                (this.VisitorFound != null &&
                this.VisitorFound.Equals(input.VisitorFound))
                ) &&
                (
                this.FirstSeenAt == input.FirstSeenAt ||
                (this.FirstSeenAt != null &&
                this.FirstSeenAt.Equals(input.FirstSeenAt))
                ) &&
                (
                this.LastSeenAt == input.LastSeenAt ||
                (this.LastSeenAt != null &&
                this.LastSeenAt.Equals(input.LastSeenAt))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.VisitorId != null)
                    hashCode = hashCode * 59 + this.VisitorId.GetHashCode();
                if (this.ClientReferrer != null)
                    hashCode = hashCode * 59 + this.ClientReferrer.GetHashCode();
                if (this.RequestId != null)
                    hashCode = hashCode * 59 + this.RequestId.GetHashCode();
                if (this.BrowserDetails != null)
                    hashCode = hashCode * 59 + this.BrowserDetails.GetHashCode();
                if (this.Incognito != null)
                    hashCode = hashCode * 59 + this.Incognito.GetHashCode();
                if (this.Ip != null)
                    hashCode = hashCode * 59 + this.Ip.GetHashCode();
                if (this.IpLocation != null)
                    hashCode = hashCode * 59 + this.IpLocation.GetHashCode();
                if (this.Timestamp != null)
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                if (this.Time != null)
                    hashCode = hashCode * 59 + this.Time.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.Tag != null)
                    hashCode = hashCode * 59 + this.Tag.GetHashCode();
                if (this.LinkedId != null)
                    hashCode = hashCode * 59 + this.LinkedId.GetHashCode();
                if (this.Confidence != null)
                    hashCode = hashCode * 59 + this.Confidence.GetHashCode();
                if (this.VisitorFound != null)
                    hashCode = hashCode * 59 + this.VisitorFound.GetHashCode();
                if (this.FirstSeenAt != null)
                    hashCode = hashCode * 59 + this.FirstSeenAt.GetHashCode();
                if (this.LastSeenAt != null)
                    hashCode = hashCode * 59 + this.LastSeenAt.GetHashCode();
                return hashCode;
            }
        }

    }
}