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
    /// WebhookSignalResponseProxy
    /// </summary>
    [DataContract]
    public partial class WebhookSignalResponseProxy : IEquatable<WebhookSignalResponseProxy>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookSignalResponseProxy" /> class.
        /// </summary>
        /// <param name="result">&#x60;true&#x60; if the request IP address is used by a public proxy provider, &#x60;false&#x60; otherwise. .</param>
        public WebhookSignalResponseProxy(bool? result = default(bool?))
        {
            this.Result = result;
        }

        /// <summary>
        /// &#x60;true&#x60; if the request IP address is used by a public proxy provider, &#x60;false&#x60; otherwise. 
        /// </summary>
        /// <value>&#x60;true&#x60; if the request IP address is used by a public proxy provider, &#x60;false&#x60; otherwise. </value>
        [DataMember(Name = "result", EmitDefaultValue = false)]
        public bool? Result { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebhookSignalResponseProxy {\n");
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
        /// Returns true if WebhookSignalResponseProxy instances are equal
        /// </summary>
        /// <param name="input">Instance of WebhookSignalResponseProxy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhookSignalResponseProxy input)
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