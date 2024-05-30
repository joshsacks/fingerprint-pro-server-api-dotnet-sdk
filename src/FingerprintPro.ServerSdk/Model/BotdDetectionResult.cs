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
    /// Stores bot detection result
    /// </summary>
    [DataContract]
    public class BotdDetectionResult : Model<BotdDetectionResult>
    {
        /// <summary>
        /// Bot detection result:  * `notDetected` - the visitor is not a bot  * `good` - good bot detected, such as Google bot, Baidu Spider, AlexaBot and so on  * `bad` - bad bot detected, such as Selenium, Puppeteer, Playwright, headless browsers, and so on 
        /// </summary>
        /// <value>Bot detection result:  * `notDetected` - the visitor is not a bot  * `good` - good bot detected, such as Google bot, Baidu Spider, AlexaBot and so on  * `bad` - bad bot detected, such as Selenium, Puppeteer, Playwright, headless browsers, and so on </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ResultEnum
        {
            /// <summary>
            /// Enum NotDetected for value: notDetected
            /// </summary>
            [EnumMember(Value = "notDetected")]
            NotDetected = 1,
            /// <summary>
            /// Enum Good for value: good
            /// </summary>
            [EnumMember(Value = "good")]
            Good = 2,
            /// <summary>
            /// Enum Bad for value: bad
            /// </summary>
            [EnumMember(Value = "bad")]
            Bad = 3
        }
        /// <summary>
        /// Bot detection result:  * `notDetected` - the visitor is not a bot  * `good` - good bot detected, such as Google bot, Baidu Spider, AlexaBot and so on  * `bad` - bad bot detected, such as Selenium, Puppeteer, Playwright, headless browsers, and so on 
        /// </summary>
        /// <value>Bot detection result:  * `notDetected` - the visitor is not a bot  * `good` - good bot detected, such as Google bot, Baidu Spider, AlexaBot and so on  * `bad` - bad bot detected, such as Selenium, Puppeteer, Playwright, headless browsers, and so on </value>
        [DataMember(Name = "result", EmitDefaultValue = false)]
        public ResultEnum Result { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BotdDetectionResult" /> class.
        /// </summary>
        /// <param name="result">Bot detection result:  * `notDetected` - the visitor is not a bot  * `good` - good bot detected, such as Google bot, Baidu Spider, AlexaBot and so on  * `bad` - bad bot detected, such as Selenium, Puppeteer, Playwright, headless browsers, and so on  (required).</param>
        /// <param name="type">type.</param>
        public BotdDetectionResult(ResultEnum result = default(ResultEnum), string type = default(string))
        {
            // to ensure "result" is required (not null)

            if (result == null)
            {
                throw new InvalidDataException("result is a required property for BotdDetectionResult and cannot be null");
            }
            else
            {
                this.Result = result;
            }
            this.Type = type;
        }


        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BotdDetectionResult {\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
        /// Returns true if BotdDetectionResult instances are equal
        /// </summary>
        /// <param name="input">Instance of BotdDetectionResult to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(BotdDetectionResult input)
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
                this.Type == input.Type ||
                (this.Type != null &&
                this.Type.Equals(input.Type))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }

    }
}