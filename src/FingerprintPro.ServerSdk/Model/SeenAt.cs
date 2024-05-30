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
    /// SeenAt
    /// </summary>
    [DataContract]
    public class SeenAt : Model<SeenAt>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SeenAt" /> class.
        /// </summary>
        /// <param name="global">global (required).</param>
        /// <param name="subscription">subscription (required).</param>
        public SeenAt(DateTime? global = default(DateTime?), DateTime? subscription = default(DateTime?))
        {
            this.Global = global;
            this.Subscription = subscription;
        }

        /// <summary>
        /// Gets or Sets Global
        /// </summary>
        [DataMember(Name = "global", EmitDefaultValue = false)]
        public DateTime? Global { get; set; }

        /// <summary>
        /// Gets or Sets Subscription
        /// </summary>
        [DataMember(Name = "subscription", EmitDefaultValue = false)]
        public DateTime? Subscription { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SeenAt {\n");
            sb.Append("  Global: ").Append(Global).Append("\n");
            sb.Append("  Subscription: ").Append(Subscription).Append("\n");
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
        /// Returns true if SeenAt instances are equal
        /// </summary>
        /// <param name="input">Instance of SeenAt to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(SeenAt input)
        {
            if (input == null)
                return false;

            return
                (
                this.Global == input.Global ||
                (this.Global != null &&
                this.Global.Equals(input.Global))
                ) &&
                (
                this.Subscription == input.Subscription ||
                (this.Subscription != null &&
                this.Subscription.Equals(input.Subscription))
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
                if (this.Global != null)
                    hashCode = hashCode * 59 + this.Global.GetHashCode();
                if (this.Subscription != null)
                    hashCode = hashCode * 59 + this.Subscription.GetHashCode();
                return hashCode;
            }
        }

    }
}