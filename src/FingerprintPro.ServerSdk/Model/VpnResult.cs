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
using System.Text.Json;
using System.Text.Json.Serialization;

namespace FingerprintPro.ServerSdk.Model
{
    /// <summary>
    /// VpnResult
    /// </summary>
    [DataContract]
    public class VpnResult : IEquatable<VpnResult>
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="VpnResult" /> class.
        /// </summary>
        /// <param name="result">VPN or other anonymizing service has been used when sending the request. (required).</param>
        /// <param name="originTimezone">Local timezone which is used in timezoneMismatch method. (required).</param>
        /// <param name="originCountry">Country of the request (only for Android SDK version >= 2.4.0, ISO 3166 format or unknown)..</param>
        /// <param name="methods">methods (required).</param>
        public VpnResult(bool? result = default(bool?), string originTimezone = default(string), string originCountry = default(string), VpnResultMethods methods = default(VpnResultMethods))
        {
            // to ensure "result" is required (not null)
            // swagger debug: VpnResult Result

            if (result == null)
            {
                throw new InvalidDataException("result is a required property for VpnResult and cannot be null");
            }
            else
            {
                this.Result = result;
            }
            // to ensure "originTimezone" is required (not null)
            // swagger debug: VpnResult OriginTimezone

            if (originTimezone == null)
            {
                throw new InvalidDataException("originTimezone is a required property for VpnResult and cannot be null");
            }
            else
            {
                this.OriginTimezone = originTimezone;
            }
            // to ensure "methods" is required (not null)
            // swagger debug: VpnResult Methods

            if (methods == null)
            {
                throw new InvalidDataException("methods is a required property for VpnResult and cannot be null");
            }
            else
            {
                this.Methods = methods;
            }
            this.OriginCountry = originCountry;
        }

        /// <summary>
        /// VPN or other anonymizing service has been used when sending the request.
        /// </summary>
        /// <value>VPN or other anonymizing service has been used when sending the request.</value>
        [DataMember(Name = "result", EmitDefaultValue = false)]
        [JsonPropertyName("result")]
        public bool? Result { get; set; }

        /// <summary>
        /// Local timezone which is used in timezoneMismatch method.
        /// </summary>
        /// <value>Local timezone which is used in timezoneMismatch method.</value>
        [DataMember(Name = "originTimezone", EmitDefaultValue = false)]
        [JsonPropertyName("originTimezone")]
        public string OriginTimezone { get; set; }

        /// <summary>
        /// Country of the request (only for Android SDK version >= 2.4.0, ISO 3166 format or unknown).
        /// </summary>
        /// <value>Country of the request (only for Android SDK version >= 2.4.0, ISO 3166 format or unknown).</value>
        [DataMember(Name = "originCountry", EmitDefaultValue = false)]
        [JsonPropertyName("originCountry")]
        public string OriginCountry { get; set; }

        /// <summary>
        /// Gets or Sets Methods
        /// </summary>
        [DataMember(Name = "methods", EmitDefaultValue = false)]
        [JsonPropertyName("methods")]
        public VpnResultMethods Methods { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VpnResult {\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
            sb.Append("  OriginTimezone: ").Append(OriginTimezone).Append("\n");
            sb.Append("  OriginCountry: ").Append(OriginCountry).Append("\n");
            sb.Append("  Methods: ").Append(Methods).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            return JsonSerializer.Serialize(this, options);
        }

        /// <summary>
        /// Returns true if VpnResult instances are equal
        /// </summary>
        /// <param name="input">Instance of VpnResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VpnResult input)
        {
            if (input == null)
                return false;

            return
                (
                this.Result == input.Result ||
                (this.Result != null &&
                this.Result.Equals(input.Result))
                ) &&
                (
                this.OriginTimezone == input.OriginTimezone ||
                (this.OriginTimezone != null &&
                this.OriginTimezone.Equals(input.OriginTimezone))
                ) &&
                (
                this.OriginCountry == input.OriginCountry ||
                (this.OriginCountry != null &&
                this.OriginCountry.Equals(input.OriginCountry))
                ) &&
                (
                this.Methods == input.Methods ||
                (this.Methods != null &&
                this.Methods.Equals(input.Methods))
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
                if (this.OriginTimezone != null)
                    hashCode = hashCode * 59 + this.OriginTimezone.GetHashCode();
                if (this.OriginCountry != null)
                    hashCode = hashCode * 59 + this.OriginCountry.GetHashCode();
                if (this.Methods != null)
                    hashCode = hashCode * 59 + this.Methods.GetHashCode();
                return hashCode;
            }
        }

    }
}
