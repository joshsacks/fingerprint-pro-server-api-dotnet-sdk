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
    /// WebhookSignalResponseFactoryReset
    /// </summary>
    [DataContract]
    public partial class WebhookSignalResponseFactoryReset : IEquatable<WebhookSignalResponseFactoryReset>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookSignalResponseFactoryReset" /> class.
        /// </summary>
        /// <param name="time">Time in UTC for the Android client when recent factory reset was done.  If there is no sign of factory reset or the client isn't Android, the field will be epoch time. .</param>
        /// <param name="timestamp">Same value as it's in the `time` field but represented in timestamp format..</param>
        public WebhookSignalResponseFactoryReset(DateTime? time = default(DateTime?), long? timestamp = default(long?))
        {
            this.Time = time;
            this.Timestamp = timestamp;
        }

        /// <summary>
        /// Time in UTC for the Android client when recent factory reset was done.  If there is no sign of factory reset or the client isn't Android, the field will be epoch time. 
        /// </summary>
        /// <value>Time in UTC for the Android client when recent factory reset was done.  If there is no sign of factory reset or the client isn't Android, the field will be epoch time. </value>
        [DataMember(Name = "time", EmitDefaultValue = false)]
        public DateTime? Time { get; set; }

        /// <summary>
        /// Same value as it's in the `time` field but represented in timestamp format.
        /// </summary>
        /// <value>Same value as it's in the `time` field but represented in timestamp format.</value>
        [DataMember(Name = "timestamp", EmitDefaultValue = false)]
        public long? Timestamp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebhookSignalResponseFactoryReset {\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
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
        /// Returns true if WebhookSignalResponseFactoryReset instances are equal
        /// </summary>
        /// <param name="input">Instance of WebhookSignalResponseFactoryReset to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhookSignalResponseFactoryReset input)
        {
            if (input == null)
                return false;

            return
                (
                this.Time == input.Time ||
                (this.Time != null &&
                this.Time.Equals(input.Time))
                ) &&
                (
                this.Timestamp == input.Timestamp ||
                (this.Timestamp != null &&
                this.Timestamp.Equals(input.Timestamp))
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
                if (this.Time != null)
                    hashCode = hashCode * 59 + this.Time.GetHashCode();
                if (this.Timestamp != null)
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                return hashCode;
            }
        }

    }
}