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
    /// ASN
    /// </summary>
    [DataContract]
    public partial class ASN : IEquatable<ASN>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ASN" /> class.
        /// </summary>
        /// <param name="asn">asn (required).</param>
        /// <param name="network">network (required).</param>
        /// <param name="name">name.</param>
        public ASN(string asn = default(string), string network = default(string), string name = default(string))
        {
            // to ensure "asn" is required (not null)

            if (asn == null)
            {
                throw new InvalidDataException("asn is a required property for ASN and cannot be null");
            }
            else
            {
                this._Asn = asn;
            }
            // to ensure "network" is required (not null)

            if (network == null)
            {
                throw new InvalidDataException("network is a required property for ASN and cannot be null");
            }
            else
            {
                this.Network = network;
            }
            this.Name = name;
        }

        /// <summary>
        /// Gets or Sets _Asn
        /// </summary>
        [DataMember(Name = "asn", EmitDefaultValue = false)]
        public string _Asn { get; set; }

        /// <summary>
        /// Gets or Sets Network
        /// </summary>
        [DataMember(Name = "network", EmitDefaultValue = false)]
        public string Network { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ASN {\n");
            sb.Append("  _Asn: ").Append(_Asn).Append("\n");
            sb.Append("  Network: ").Append(Network).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
        /// Returns true if ASN instances are equal
        /// </summary>
        /// <param name="input">Instance of ASN to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ASN input)
        {
            if (input == null)
                return false;

            return
                (
                this._Asn == input._Asn ||
                (this._Asn != null &&
                this._Asn.Equals(input._Asn))
                ) &&
                (
                this.Network == input.Network ||
                (this.Network != null &&
                this.Network.Equals(input.Network))
                ) &&
                (
                this.Name == input.Name ||
                (this.Name != null &&
                this.Name.Equals(input.Name))
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
                if (this._Asn != null)
                    hashCode = hashCode * 59 + this._Asn.GetHashCode();
                if (this.Network != null)
                    hashCode = hashCode * 59 + this.Network.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                return hashCode;
            }
        }

    }
}