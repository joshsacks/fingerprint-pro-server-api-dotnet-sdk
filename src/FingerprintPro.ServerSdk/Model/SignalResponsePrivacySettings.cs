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
    /// SignalResponsePrivacySettings
    /// </summary>
    [DataContract]
    public partial class SignalResponsePrivacySettings : IEquatable<SignalResponsePrivacySettings>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SignalResponsePrivacySettings" /> class.
        /// </summary>
        /// <param name="data">data.</param>
        /// <param name="error">error.</param>
        public SignalResponsePrivacySettings(SignalResponsePrivacySettingsData data = default(SignalResponsePrivacySettingsData), ProductError error = default(ProductError))
        {
            this.Data = data;
            this.Error = error;
        }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public SignalResponsePrivacySettingsData Data { get; set; }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name = "error", EmitDefaultValue = false)]
        public ProductError Error { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SignalResponsePrivacySettings {\n");
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
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if SignalResponsePrivacySettings instances are equal
        /// </summary>
        /// <param name="input">Instance of SignalResponsePrivacySettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SignalResponsePrivacySettings input)
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