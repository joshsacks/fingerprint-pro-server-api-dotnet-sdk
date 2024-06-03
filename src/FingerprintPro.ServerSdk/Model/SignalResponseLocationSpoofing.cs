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
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel;

namespace FingerprintPro.ServerSdk.Model
{
    /// <summary>
    /// SignalResponseLocationSpoofing
    /// </summary>
    [DataContract]
    public class SignalResponseLocationSpoofing : IEquatable<SignalResponseLocationSpoofing>
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="SignalResponseLocationSpoofing" /> class.
        /// </summary>
        /// <param name="data">data.</param>
        /// <param name="error">error.</param>
        public SignalResponseLocationSpoofing(LocationSpoofingResult data = default(LocationSpoofingResult), ProductError error = default(ProductError))
        {
            this.Data = data;
            this.Error = error;
        }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        [JsonPropertyName("data")]
        public LocationSpoofingResult Data { get; set; }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name = "error", EmitDefaultValue = false)]
        [JsonPropertyName("error")]
        public ProductError Error { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SignalResponseLocationSpoofing {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
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
        /// Returns true if SignalResponseLocationSpoofing instances are equal
        /// </summary>
        /// <param name="input">Instance of SignalResponseLocationSpoofing to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SignalResponseLocationSpoofing input)
        {
            if (input == null)
                return false;

            return
                (
                this.Data == input.Data ||
                (this.Data != null &&
                this.Data.Equals(input.Data))
                ) &&
                (
                this.Error == input.Error ||
                (this.Error != null &&
                this.Error.Equals(input.Error))
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
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
                if (this.Error != null)
                    hashCode = hashCode * 59 + this.Error.GetHashCode();
                return hashCode;
            }
        }

    }
}
