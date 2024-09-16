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
    /// Sums key data points for a specific `visitorId` at three distinct time intervals: 5 minutes, 1 hour, and 24 hours as follows:  - Number of identification events attributed to the visitor ID - Number of distinct IP addresses associated to the visitor ID. - Number of distinct countries associated with the visitor ID. - Number of distinct `linkedId`s associated with the visitor ID. The `24h` interval of `distinctIp`, `distinctLinkedId`, and `distinctCountry` will be omitted if the number of `events` for the visitor ID in the last 24 hours (`events.intervals.['24h']`) is higher than 20.000. 
    /// </summary>
    [DataContract]
    public class VelocityResult : IEquatable<VelocityResult>
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="VelocityResult" /> class.
        /// </summary>
        /// <param name="distinctIp">distinctIp (required).</param>
        /// <param name="distinctLinkedId">distinctLinkedId (required).</param>
        /// <param name="distinctCountry">distinctCountry (required).</param>
        /// <param name="events">events (required).</param>
        public VelocityResult(VelocityIntervals distinctIp = default(VelocityIntervals), VelocityIntervals distinctLinkedId = default(VelocityIntervals), VelocityIntervals distinctCountry = default(VelocityIntervals), VelocityIntervals events = default(VelocityIntervals))
        {
            // to ensure "distinctIp" is required (not null)
            // swagger debug: VelocityResult DistinctIp

            if (distinctIp == null)
            {
                throw new InvalidDataException("distinctIp is a required property for VelocityResult and cannot be null");
            }
            else
            {
                this.DistinctIp = distinctIp;
            }
            // to ensure "distinctLinkedId" is required (not null)
            // swagger debug: VelocityResult DistinctLinkedId

            if (distinctLinkedId == null)
            {
                throw new InvalidDataException("distinctLinkedId is a required property for VelocityResult and cannot be null");
            }
            else
            {
                this.DistinctLinkedId = distinctLinkedId;
            }
            // to ensure "distinctCountry" is required (not null)
            // swagger debug: VelocityResult DistinctCountry

            if (distinctCountry == null)
            {
                throw new InvalidDataException("distinctCountry is a required property for VelocityResult and cannot be null");
            }
            else
            {
                this.DistinctCountry = distinctCountry;
            }
            // to ensure "events" is required (not null)
            // swagger debug: VelocityResult Events

            if (events == null)
            {
                throw new InvalidDataException("events is a required property for VelocityResult and cannot be null");
            }
            else
            {
                this.Events = events;
            }
        }

        /// <summary>
        /// Gets or Sets DistinctIp
        /// </summary>
        [DataMember(Name = "distinctIp", EmitDefaultValue = false)]
        [JsonPropertyName("distinctIp")]
        public VelocityIntervals DistinctIp { get; set; }

        /// <summary>
        /// Gets or Sets DistinctLinkedId
        /// </summary>
        [DataMember(Name = "distinctLinkedId", EmitDefaultValue = false)]
        [JsonPropertyName("distinctLinkedId")]
        public VelocityIntervals DistinctLinkedId { get; set; }

        /// <summary>
        /// Gets or Sets DistinctCountry
        /// </summary>
        [DataMember(Name = "distinctCountry", EmitDefaultValue = false)]
        [JsonPropertyName("distinctCountry")]
        public VelocityIntervals DistinctCountry { get; set; }

        /// <summary>
        /// Gets or Sets Events
        /// </summary>
        [DataMember(Name = "events", EmitDefaultValue = false)]
        [JsonPropertyName("events")]
        public VelocityIntervals Events { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VelocityResult {\n");
            sb.Append("  DistinctIp: ").Append(DistinctIp).Append("\n");
            sb.Append("  DistinctLinkedId: ").Append(DistinctLinkedId).Append("\n");
            sb.Append("  DistinctCountry: ").Append(DistinctCountry).Append("\n");
            sb.Append("  Events: ").Append(Events).Append("\n");
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
        /// Returns true if VelocityResult instances are equal
        /// </summary>
        /// <param name="input">Instance of VelocityResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VelocityResult input)
        {
            if (input == null)
                return false;

            return
                (
                this.DistinctIp == input.DistinctIp ||
                (this.DistinctIp != null &&
                this.DistinctIp.Equals(input.DistinctIp))
                ) &&
                (
                this.DistinctLinkedId == input.DistinctLinkedId ||
                (this.DistinctLinkedId != null &&
                this.DistinctLinkedId.Equals(input.DistinctLinkedId))
                ) &&
                (
                this.DistinctCountry == input.DistinctCountry ||
                (this.DistinctCountry != null &&
                this.DistinctCountry.Equals(input.DistinctCountry))
                ) &&
                (
                this.Events == input.Events ||
                (this.Events != null &&
                this.Events.Equals(input.Events))
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
                if (this.DistinctIp != null)
                    hashCode = hashCode * 59 + this.DistinctIp.GetHashCode();
                if (this.DistinctLinkedId != null)
                    hashCode = hashCode * 59 + this.DistinctLinkedId.GetHashCode();
                if (this.DistinctCountry != null)
                    hashCode = hashCode * 59 + this.DistinctCountry.GetHashCode();
                if (this.Events != null)
                    hashCode = hashCode * 59 + this.Events.GetHashCode();
                return hashCode;
            }
        }

    }
}