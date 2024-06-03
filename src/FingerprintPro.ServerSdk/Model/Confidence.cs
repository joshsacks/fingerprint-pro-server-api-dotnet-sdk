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
    /// Confidence
    /// </summary>
    [DataContract]
    public class Confidence : IEquatable<Confidence>
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="Confidence" /> class.
        /// </summary>
        /// <param name="score">The confidence score is a floating-point number between 0 and 1 that represents the probability of accurate identification. (required).</param>
        public Confidence(float? score = default(float?))
        {
            // to ensure "score" is required (not null)
            // swagger debug: Confidence Score

            if (score == null)
            {
                throw new InvalidDataException("score is a required property for Confidence and cannot be null");
            }
            else
            {
                this.Score = score;
            }
        }

        /// <summary>
        /// The confidence score is a floating-point number between 0 and 1 that represents the probability of accurate identification.
        /// </summary>
        /// <value>The confidence score is a floating-point number between 0 and 1 that represents the probability of accurate identification.</value>
        [DataMember(Name = "score", EmitDefaultValue = false)]
        [JsonPropertyName("score")]
        public float? Score { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Confidence {\n");
            sb.Append("  Score: ").Append(Score).Append("\n");
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
        /// Returns true if Confidence instances are equal
        /// </summary>
        /// <param name="input">Instance of Confidence to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Confidence input)
        {
            if (input == null)
                return false;

            return
                (
                this.Score == input.Score ||
                (this.Score != null &&
                this.Score.Equals(input.Score))
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
                if (this.Score != null)
                    hashCode = hashCode * 59 + this.Score.GetHashCode();
                return hashCode;
            }
        }

    }
}
