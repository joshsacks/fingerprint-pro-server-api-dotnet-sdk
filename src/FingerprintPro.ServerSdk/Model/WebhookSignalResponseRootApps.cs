/* 
 * Fingerprint Pro Server API
 *
 * Fingerprint Pro Server API allows you to get information about visitors and about individual events in a server environment. It can be used for data exports, decision-making, and data analysis scenarios. Server API is intended for server-side usage, it's not intended to be used from the client side, whether it's a browser or a mobile device. 
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
    /// WebhookSignalResponseRootApps
    /// </summary>
    [DataContract]
    public partial class WebhookSignalResponseRootApps : IEquatable<WebhookSignalResponseRootApps>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookSignalResponseRootApps" /> class.
        /// </summary>
        /// <param name="result">Android specific root management apps detection. There are 2 values: • &#x60;true&#x60; - Root Management Apps detected (e.g. Magisk) • &#x60;false&#x60; - No Root Management Apps detected Available only for events from Android client. The field will not be present for a browser or iOS event. .</param>
        public WebhookSignalResponseRootApps(bool? result = default(bool?))
        {
            this.Result = result;
        }

        /// <summary>
        /// Android specific root management apps detection. There are 2 values: • &#x60;true&#x60; - Root Management Apps detected (e.g. Magisk) • &#x60;false&#x60; - No Root Management Apps detected Available only for events from Android client. The field will not be present for a browser or iOS event. 
        /// </summary>
        /// <value>Android specific root management apps detection. There are 2 values: • &#x60;true&#x60; - Root Management Apps detected (e.g. Magisk) • &#x60;false&#x60; - No Root Management Apps detected Available only for events from Android client. The field will not be present for a browser or iOS event. </value>
        [DataMember(Name = "result", EmitDefaultValue = false)]
        public bool? Result { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebhookSignalResponseRootApps {\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
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
        /// Returns true if WebhookSignalResponseRootApps instances are equal
        /// </summary>
        /// <param name="input">Instance of WebhookSignalResponseRootApps to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhookSignalResponseRootApps input)
        {
            if (input == null)
                return false;

            return
                (
                this.Result == input.Result ||
                (this.Result != null &&
                this.Result.Equals(input.Result))
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
                if (this.Result != null)
                    hashCode = hashCode * 59 + this.Result.GetHashCode();
                return hashCode;
            }
        }

    }
}