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
using System.Text.Json.Serialization;
using FingerprintPro.ServerSdk.Json;

namespace FingerprintPro.ServerSdk.Model
{
    /// <summary>
    /// IPLocationCity
    /// </summary>
    [DataContract]
    public class IPLocationCity : IEquatable<IPLocationCity>
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="IPLocationCity" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        public IPLocationCity(string name = default(string))
        {
            this.Name = name;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IPLocationCity {\n");
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
            return JsonUtils.Serialize(this);
        }

        /// <summary>
        /// Returns true if IPLocationCity instances are equal
        /// </summary>
        /// <param name="input">Instance of IPLocationCity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IPLocationCity input)
        {
            if (input == null)
                return false;

            return
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                return hashCode;
            }
        }

    }
}
