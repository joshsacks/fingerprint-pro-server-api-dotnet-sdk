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

namespace FingerprintPro.ServerSdk.Model
{
    /// <summary>
    /// LocationSpoofingResult
    /// </summary>
    [DataContract]
    public class LocationSpoofingResult : Model<LocationSpoofingResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LocationSpoofingResult" /> class.
        /// </summary>
        /// <param name="result">Flag indicating whether the request came from a mobile device with location spoofing enabled. (required).</param>
        public LocationSpoofingResult(bool? result = default(bool?))
        {
            // to ensure "result" is required (not null)

            if (result == null)
            {
                throw new InvalidDataException("result is a required property for LocationSpoofingResult and cannot be null");
            }
            else
            {
                this.Result = result;
            }
        }

        /// <summary>
        /// Flag indicating whether the request came from a mobile device with location spoofing enabled.
        /// </summary>
        /// <value>Flag indicating whether the request came from a mobile device with location spoofing enabled.</value>
        [DataMember(Name = "result", EmitDefaultValue = false)]
        public bool? Result { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LocationSpoofingResult {\n");
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
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            return JsonSerializer.Serialize(this, options);
        }

        /// <summary>
        /// Returns true if LocationSpoofingResult instances are equal
        /// </summary>
        /// <param name="input">Instance of LocationSpoofingResult to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(LocationSpoofingResult input)
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