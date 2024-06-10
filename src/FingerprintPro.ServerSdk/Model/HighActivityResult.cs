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
    /// HighActivityResult
    /// </summary>
    [DataContract]
    public class HighActivityResult : IEquatable<HighActivityResult>
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="HighActivityResult" /> class.
        /// </summary>
        /// <param name="result">Flag indicating whether the request came from a high activity visitor. (required).</param>
        /// <param name="dailyRequests">Number of requests from the same visitor in the previous day..</param>
        public HighActivityResult(bool? result = default(bool?), decimal? dailyRequests = default(decimal?))
        {
            // to ensure "result" is required (not null)
            // swagger debug: HighActivityResult Result

            if (result == null)
            {
                throw new InvalidDataException("result is a required property for HighActivityResult and cannot be null");
            }
            else
            {
                this.Result = result;
            }
            this.DailyRequests = dailyRequests;
        }

        /// <summary>
        /// Flag indicating whether the request came from a high activity visitor.
        /// </summary>
        /// <value>Flag indicating whether the request came from a high activity visitor.</value>
        [DataMember(Name = "result", EmitDefaultValue = false)]
        [JsonPropertyName("result")]
        public bool? Result { get; set; }

        /// <summary>
        /// Number of requests from the same visitor in the previous day.
        /// </summary>
        /// <value>Number of requests from the same visitor in the previous day.</value>
        [DataMember(Name = "dailyRequests", EmitDefaultValue = false)]
        [JsonPropertyName("dailyRequests")]
        public decimal? DailyRequests { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HighActivityResult {\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
            sb.Append("  DailyRequests: ").Append(DailyRequests).Append("\n");
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
        /// Returns true if HighActivityResult instances are equal
        /// </summary>
        /// <param name="input">Instance of HighActivityResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HighActivityResult input)
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
                this.DailyRequests == input.DailyRequests ||
                (this.DailyRequests != null &&
                this.DailyRequests.Equals(input.DailyRequests))
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
                if (this.DailyRequests != null)
                    hashCode = hashCode * 59 + this.DailyRequests.GetHashCode();
                return hashCode;
            }
        }

    }
}
