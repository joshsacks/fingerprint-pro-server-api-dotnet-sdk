/* 
 * Fingerprint Pro Server API
 *
 * Fingerprint Pro Server API allows you to get information about visitors and about individual events in a server environment. This API can be used for data exports, decision-making, and data analysis scenarios.
 *
 * OpenAPI spec version: 3
 * Contact: support@fingerprint.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace Fingerprint.Sdk.Model
{
    /// <summary>
    /// BrowserDetails
    /// </summary>
    [DataContract]
    public partial class BrowserDetails : IEquatable<BrowserDetails>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BrowserDetails" /> class.
        /// </summary>
        /// <param name="browserName">browserName (required).</param>
        /// <param name="browserMajorVersion">browserMajorVersion (required).</param>
        /// <param name="browserFullVersion">browserFullVersion (required).</param>
        /// <param name="os">os (required).</param>
        /// <param name="osVersion">osVersion (required).</param>
        /// <param name="device">device (required).</param>
        /// <param name="userAgent">userAgent (required).</param>
        /// <param name="botProbability">botProbability.</param>
        public BrowserDetails(string browserName = default(string), string browserMajorVersion = default(string), string browserFullVersion = default(string), string os = default(string), string osVersion = default(string), string device = default(string), string userAgent = default(string), int? botProbability = default(int?))
        {
            // to ensure "browserName" is required (not null)

            if (browserName == null)
            {
                throw new InvalidDataException("browserName is a required property for BrowserDetails and cannot be null");
            }
            else
            {
                this.BrowserName = browserName;
            }
            // to ensure "browserMajorVersion" is required (not null)

            if (browserMajorVersion == null)
            {
                throw new InvalidDataException("browserMajorVersion is a required property for BrowserDetails and cannot be null");
            }
            else
            {
                this.BrowserMajorVersion = browserMajorVersion;
            }
            // to ensure "browserFullVersion" is required (not null)

            if (browserFullVersion == null)
            {
                throw new InvalidDataException("browserFullVersion is a required property for BrowserDetails and cannot be null");
            }
            else
            {
                this.BrowserFullVersion = browserFullVersion;
            }
            // to ensure "os" is required (not null)

            if (os == null)
            {
                throw new InvalidDataException("os is a required property for BrowserDetails and cannot be null");
            }
            else
            {
                this.Os = os;
            }
            // to ensure "osVersion" is required (not null)

            if (osVersion == null)
            {
                throw new InvalidDataException("osVersion is a required property for BrowserDetails and cannot be null");
            }
            else
            {
                this.OsVersion = osVersion;
            }
            // to ensure "device" is required (not null)

            if (device == null)
            {
                throw new InvalidDataException("device is a required property for BrowserDetails and cannot be null");
            }
            else
            {
                this.Device = device;
            }
            // to ensure "userAgent" is required (not null)

            if (userAgent == null)
            {
                throw new InvalidDataException("userAgent is a required property for BrowserDetails and cannot be null");
            }
            else
            {
                this.UserAgent = userAgent;
            }
            this.BotProbability = botProbability;
        }

        /// <summary>
        /// Gets or Sets BrowserName
        /// </summary>
        [DataMember(Name = "browserName", EmitDefaultValue = false)]
        public string BrowserName { get; set; }

        /// <summary>
        /// Gets or Sets BrowserMajorVersion
        /// </summary>
        [DataMember(Name = "browserMajorVersion", EmitDefaultValue = false)]
        public string BrowserMajorVersion { get; set; }

        /// <summary>
        /// Gets or Sets BrowserFullVersion
        /// </summary>
        [DataMember(Name = "browserFullVersion", EmitDefaultValue = false)]
        public string BrowserFullVersion { get; set; }

        /// <summary>
        /// Gets or Sets Os
        /// </summary>
        [DataMember(Name = "os", EmitDefaultValue = false)]
        public string Os { get; set; }

        /// <summary>
        /// Gets or Sets OsVersion
        /// </summary>
        [DataMember(Name = "osVersion", EmitDefaultValue = false)]
        public string OsVersion { get; set; }

        /// <summary>
        /// Gets or Sets Device
        /// </summary>
        [DataMember(Name = "device", EmitDefaultValue = false)]
        public string Device { get; set; }

        /// <summary>
        /// Gets or Sets UserAgent
        /// </summary>
        [DataMember(Name = "userAgent", EmitDefaultValue = false)]
        public string UserAgent { get; set; }

        /// <summary>
        /// Gets or Sets BotProbability
        /// </summary>
        [DataMember(Name = "botProbability", EmitDefaultValue = false)]
        public int? BotProbability { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BrowserDetails {\n");
            sb.Append("  BrowserName: ").Append(BrowserName).Append("\n");
            sb.Append("  BrowserMajorVersion: ").Append(BrowserMajorVersion).Append("\n");
            sb.Append("  BrowserFullVersion: ").Append(BrowserFullVersion).Append("\n");
            sb.Append("  Os: ").Append(Os).Append("\n");
            sb.Append("  OsVersion: ").Append(OsVersion).Append("\n");
            sb.Append("  Device: ").Append(Device).Append("\n");
            sb.Append("  UserAgent: ").Append(UserAgent).Append("\n");
            sb.Append("  BotProbability: ").Append(BotProbability).Append("\n");
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
        /// Returns true if BrowserDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of BrowserDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BrowserDetails input)
        {
            if (input == null)
                return false;

            return
                (
                this.BrowserName == input.BrowserName ||
                (this.BrowserName != null &&
                this.BrowserName.Equals(input.BrowserName))
                ) &&
                (
                this.BrowserMajorVersion == input.BrowserMajorVersion ||
                (this.BrowserMajorVersion != null &&
                this.BrowserMajorVersion.Equals(input.BrowserMajorVersion))
                ) &&
                (
                this.BrowserFullVersion == input.BrowserFullVersion ||
                (this.BrowserFullVersion != null &&
                this.BrowserFullVersion.Equals(input.BrowserFullVersion))
                ) &&
                (
                this.Os == input.Os ||
                (this.Os != null &&
                this.Os.Equals(input.Os))
                ) &&
                (
                this.OsVersion == input.OsVersion ||
                (this.OsVersion != null &&
                this.OsVersion.Equals(input.OsVersion))
                ) &&
                (
                this.Device == input.Device ||
                (this.Device != null &&
                this.Device.Equals(input.Device))
                ) &&
                (
                this.UserAgent == input.UserAgent ||
                (this.UserAgent != null &&
                this.UserAgent.Equals(input.UserAgent))
                ) &&
                (
                this.BotProbability == input.BotProbability ||
                (this.BotProbability != null &&
                this.BotProbability.Equals(input.BotProbability))
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
                if (this.BrowserName != null)
                    hashCode = hashCode * 59 + this.BrowserName.GetHashCode();
                if (this.BrowserMajorVersion != null)
                    hashCode = hashCode * 59 + this.BrowserMajorVersion.GetHashCode();
                if (this.BrowserFullVersion != null)
                    hashCode = hashCode * 59 + this.BrowserFullVersion.GetHashCode();
                if (this.Os != null)
                    hashCode = hashCode * 59 + this.Os.GetHashCode();
                if (this.OsVersion != null)
                    hashCode = hashCode * 59 + this.OsVersion.GetHashCode();
                if (this.Device != null)
                    hashCode = hashCode * 59 + this.Device.GetHashCode();
                if (this.UserAgent != null)
                    hashCode = hashCode * 59 + this.UserAgent.GetHashCode();
                if (this.BotProbability != null)
                    hashCode = hashCode * 59 + this.BotProbability.GetHashCode();
                return hashCode;
            }
        }

    }
}