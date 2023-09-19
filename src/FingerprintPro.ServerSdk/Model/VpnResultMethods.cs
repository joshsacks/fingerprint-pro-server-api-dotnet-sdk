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
    /// VpnResultMethods
    /// </summary>
    [DataContract]
    public partial class VpnResultMethods : IEquatable<VpnResultMethods>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VpnResultMethods" /> class.
        /// </summary>
        /// <param name="timezoneMismatch">User's browser timezone doesn't match the timezone from which the request was originally made..</param>
        /// <param name="publicVPN">Request IP address is owned and used by a public VPN service provider..</param>
        /// <param name="auxiliaryMobile">This method applies to mobile devices only. Indicates the result of additional methods used to detect a VPN in mobile devices..</param>
        public VpnResultMethods(bool? timezoneMismatch = default(bool?), bool? publicVPN = default(bool?), bool? auxiliaryMobile = default(bool?))
        {
            this.TimezoneMismatch = timezoneMismatch;
            this.PublicVPN = publicVPN;
            this.AuxiliaryMobile = auxiliaryMobile;
        }

        /// <summary>
        /// User's browser timezone doesn't match the timezone from which the request was originally made.
        /// </summary>
        /// <value>User's browser timezone doesn't match the timezone from which the request was originally made.</value>
        [DataMember(Name = "timezoneMismatch", EmitDefaultValue = false)]
        public bool? TimezoneMismatch { get; set; }

        /// <summary>
        /// Request IP address is owned and used by a public VPN service provider.
        /// </summary>
        /// <value>Request IP address is owned and used by a public VPN service provider.</value>
        [DataMember(Name = "publicVPN", EmitDefaultValue = false)]
        public bool? PublicVPN { get; set; }

        /// <summary>
        /// This method applies to mobile devices only. Indicates the result of additional methods used to detect a VPN in mobile devices.
        /// </summary>
        /// <value>This method applies to mobile devices only. Indicates the result of additional methods used to detect a VPN in mobile devices.</value>
        [DataMember(Name = "auxiliaryMobile", EmitDefaultValue = false)]
        public bool? AuxiliaryMobile { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VpnResultMethods {\n");
            sb.Append("  TimezoneMismatch: ").Append(TimezoneMismatch).Append("\n");
            sb.Append("  PublicVPN: ").Append(PublicVPN).Append("\n");
            sb.Append("  AuxiliaryMobile: ").Append(AuxiliaryMobile).Append("\n");
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
        /// Returns true if VpnResultMethods instances are equal
        /// </summary>
        /// <param name="input">Instance of VpnResultMethods to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VpnResultMethods input)
        {
            if (input == null)
                return false;

            return
                (
                this.TimezoneMismatch == input.TimezoneMismatch ||
                (this.TimezoneMismatch != null &&
                this.TimezoneMismatch.Equals(input.TimezoneMismatch))
                ) &&
                (
                this.PublicVPN == input.PublicVPN ||
                (this.PublicVPN != null &&
                this.PublicVPN.Equals(input.PublicVPN))
                ) &&
                (
                this.AuxiliaryMobile == input.AuxiliaryMobile ||
                (this.AuxiliaryMobile != null &&
                this.AuxiliaryMobile.Equals(input.AuxiliaryMobile))
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
                if (this.TimezoneMismatch != null)
                    hashCode = hashCode * 59 + this.TimezoneMismatch.GetHashCode();
                if (this.PublicVPN != null)
                    hashCode = hashCode * 59 + this.PublicVPN.GetHashCode();
                if (this.AuxiliaryMobile != null)
                    hashCode = hashCode * 59 + this.AuxiliaryMobile.GetHashCode();
                return hashCode;
            }
        }

    }
}