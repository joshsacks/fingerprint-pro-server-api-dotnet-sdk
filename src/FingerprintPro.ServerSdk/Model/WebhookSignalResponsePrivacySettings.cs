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
    /// WebhookSignalResponsePrivacySettings
    /// </summary>
    [DataContract]
    public partial class WebhookSignalResponsePrivacySettings : IEquatable<WebhookSignalResponsePrivacySettings>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookSignalResponsePrivacySettings" /> class.
        /// </summary>
        /// <param name="result">`true` if the request is from a privacy aware browser (e.g. Tor) or from a browser in which fingerprinting is blocked. Otherwise `false`. .</param>
        public WebhookSignalResponsePrivacySettings(bool? result = default(bool?))
        {
            this.Result = result;
        }

        /// <summary>
        /// `true` if the request is from a privacy aware browser (e.g. Tor) or from a browser in which fingerprinting is blocked. Otherwise `false`. 
        /// </summary>
        /// <value>`true` if the request is from a privacy aware browser (e.g. Tor) or from a browser in which fingerprinting is blocked. Otherwise `false`. </value>
        [DataMember(Name = "result", EmitDefaultValue = false)]
        public bool? Result { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebhookSignalResponsePrivacySettings {\n");
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
        /// Returns true if WebhookSignalResponsePrivacySettings instances are equal
        /// </summary>
        /// <param name="input">Instance of WebhookSignalResponsePrivacySettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhookSignalResponsePrivacySettings input)
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