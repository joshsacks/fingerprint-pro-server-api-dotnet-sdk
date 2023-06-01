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
    /// IpInfoResultV6
    /// </summary>
    [DataContract]
    public partial class IpInfoResultV6 : IEquatable<IpInfoResultV6>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IpInfoResultV6" /> class.
        /// </summary>
        /// <param name="address">address.</param>
        /// <param name="geolocation">geolocation.</param>
        public IpInfoResultV6(string address = default(string), IPLocation geolocation = default(IPLocation))
        {
            this.Address = address;
            this.Geolocation = geolocation;
        }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name = "address", EmitDefaultValue = false)]
        public string Address { get; set; }

        /// <summary>
        /// Gets or Sets Geolocation
        /// </summary>
        [DataMember(Name = "geolocation", EmitDefaultValue = false)]
        public IPLocation Geolocation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IpInfoResultV6 {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Geolocation: ").Append(Geolocation).Append("\n");
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
        /// Returns true if IpInfoResultV6 instances are equal
        /// </summary>
        /// <param name="input">Instance of IpInfoResultV6 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IpInfoResultV6 input)
        {
            if (input == null)
                return false;

            return
                (
                this.Address == input.Address ||
                (this.Address != null &&
                this.Address.Equals(input.Address))
                ) &&
                (
                this.Geolocation == input.Geolocation ||
                (this.Geolocation != null &&
                this.Geolocation.Equals(input.Geolocation))
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
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.Geolocation != null)
                    hashCode = hashCode * 59 + this.Geolocation.GetHashCode();
                return hashCode;
            }
        }

    }
}