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
    /// Details about the request IP address. Has separate fields for v4 and v6 IP address versions.
    /// </summary>
    [DataContract]
    public partial class IpInfoResult : IEquatable<IpInfoResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IpInfoResult" /> class.
        /// </summary>
        /// <param name="v4">v4.</param>
        /// <param name="v6">v6.</param>
        public IpInfoResult(IpInfoResultV4 v4 = default(IpInfoResultV4), IpInfoResultV6 v6 = default(IpInfoResultV6))
        {
            this.V4 = v4;
            this.V6 = v6;
        }

        /// <summary>
        /// Gets or Sets V4
        /// </summary>
        [DataMember(Name = "v4", EmitDefaultValue = false)]
        public IpInfoResultV4 V4 { get; set; }

        /// <summary>
        /// Gets or Sets V6
        /// </summary>
        [DataMember(Name = "v6", EmitDefaultValue = false)]
        public IpInfoResultV6 V6 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IpInfoResult {\n");
            sb.Append("  V4: ").Append(V4).Append("\n");
            sb.Append("  V6: ").Append(V6).Append("\n");
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
        /// Returns true if IpInfoResult instances are equal
        /// </summary>
        /// <param name="input">Instance of IpInfoResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IpInfoResult input)
        {
            if (input == null)
                return false;

            return
                (
                this.V4 == input.V4 ||
                (this.V4 != null &&
                this.V4.Equals(input.V4))
                ) &&
                (
                this.V6 == input.V6 ||
                (this.V6 != null &&
                this.V6.Equals(input.V6))
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
                if (this.V4 != null)
                    hashCode = hashCode * 59 + this.V4.GetHashCode();
                if (this.V6 != null)
                    hashCode = hashCode * 59 + this.V6.GetHashCode();
                return hashCode;
            }
        }

    }
}