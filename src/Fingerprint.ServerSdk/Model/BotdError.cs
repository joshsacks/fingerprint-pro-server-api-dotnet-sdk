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

namespace Fingerprint.ServerSdk.Model
{
    /// <summary>
    /// BotdError
    /// </summary>
    [DataContract]
    public partial class BotdError : IEquatable<BotdError>
    {
        /// <summary>
        /// Error code:  * &#x60;TooManyRequests&#x60; - the limit on secret API key requests per second has been exceeded  * &#x60;Failed&#x60; - internal server error 
        /// </summary>
        /// <value>Error code:  * &#x60;TooManyRequests&#x60; - the limit on secret API key requests per second has been exceeded  * &#x60;Failed&#x60; - internal server error </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CodeEnum
        {
            /// <summary>
            /// Enum TooManyRequests for value: TooManyRequests
            /// </summary>
            [EnumMember(Value = "TooManyRequests")]
            TooManyRequests = 1,
            /// <summary>
            /// Enum Failed for value: Failed
            /// </summary>
            [EnumMember(Value = "Failed")]
            Failed = 2
        }
        /// <summary>
        /// Error code:  * &#x60;TooManyRequests&#x60; - the limit on secret API key requests per second has been exceeded  * &#x60;Failed&#x60; - internal server error 
        /// </summary>
        /// <value>Error code:  * &#x60;TooManyRequests&#x60; - the limit on secret API key requests per second has been exceeded  * &#x60;Failed&#x60; - internal server error </value>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public CodeEnum Code { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BotdError" /> class.
        /// </summary>
        /// <param name="code">Error code:  * &#x60;TooManyRequests&#x60; - the limit on secret API key requests per second has been exceeded  * &#x60;Failed&#x60; - internal server error  (required).</param>
        /// <param name="message">message (required).</param>
        public BotdError(CodeEnum code = default(CodeEnum), string message = default(string))
        {
            // to ensure "code" is required (not null)

            if (code == null)
            {
                throw new InvalidDataException("code is a required property for BotdError and cannot be null");
            }
            else
            {
                this.Code = code;
            }
            // to ensure "message" is required (not null)

            if (message == null)
            {
                throw new InvalidDataException("message is a required property for BotdError and cannot be null");
            }
            else
            {
                this.Message = message;
            }
        }


        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BotdError {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
        /// Returns true if BotdError instances are equal
        /// </summary>
        /// <param name="input">Instance of BotdError to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BotdError input)
        {
            if (input == null)
                return false;

            return
                (
                this.Code == input.Code ||
                (this.Code != null &&
                this.Code.Equals(input.Code))
                ) &&
                (
                this.Message == input.Message ||
                (this.Message != null &&
                this.Message.Equals(input.Message))
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
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                return hashCode;
            }
        }

    }
}