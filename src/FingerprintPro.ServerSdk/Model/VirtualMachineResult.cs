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
    /// VirtualMachineResult
    /// </summary>
    [DataContract]
    public class VirtualMachineResult : IEquatable<VirtualMachineResult>
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="VirtualMachineResult" /> class.
        /// </summary>
        /// <param name="result">`true` if the request came from a browser running inside a virtual machine (e.g. VMWare), `false` otherwise.  (required).</param>
        public VirtualMachineResult(bool? result = default(bool?))
        {
            // to ensure "result" is required (not null)
            // swagger debug: VirtualMachineResult Result

            if (result == null)
            {
                throw new InvalidDataException("result is a required property for VirtualMachineResult and cannot be null");
            }
            else
            {
                this.Result = result;
            }
        }

        /// <summary>
        /// `true` if the request came from a browser running inside a virtual machine (e.g. VMWare), `false` otherwise. 
        /// </summary>
        /// <value>`true` if the request came from a browser running inside a virtual machine (e.g. VMWare), `false` otherwise. </value>
        [DataMember(Name = "result", EmitDefaultValue = false)]
        [JsonPropertyName("result")]
        public bool? Result { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VirtualMachineResult {\n");
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
            return JsonUtils.Serialize(this);
        }

        /// <summary>
        /// Returns true if VirtualMachineResult instances are equal
        /// </summary>
        /// <param name="input">Instance of VirtualMachineResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VirtualMachineResult input)
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
