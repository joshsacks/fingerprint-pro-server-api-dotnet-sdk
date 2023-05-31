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
    /// ErrorEvent403ResponseError
    /// </summary>
    [DataContract]
    public partial class ErrorEvent403ResponseError : IEquatable<ErrorEvent403ResponseError>
    {
        /// <summary>
        /// Error code:  * &#x60;TokenRequired&#x60; - &#x60;Auth-API-Key&#x60; header is missing or empty  * &#x60;TokenNotFound&#x60; - subscription not found for specified secret key  * &#x60;SubscriptionNotActive&#x60; - subscription is not active  * &#x60;WrongRegion&#x60; - server and subscription region differ 
        /// </summary>
        /// <value>Error code:  * &#x60;TokenRequired&#x60; - &#x60;Auth-API-Key&#x60; header is missing or empty  * &#x60;TokenNotFound&#x60; - subscription not found for specified secret key  * &#x60;SubscriptionNotActive&#x60; - subscription is not active  * &#x60;WrongRegion&#x60; - server and subscription region differ </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CodeEnum
        {
            /// <summary>
            /// Enum TokenRequired for value: TokenRequired
            /// </summary>
            [EnumMember(Value = "TokenRequired")]
            TokenRequired = 1,
            /// <summary>
            /// Enum TokenNotFound for value: TokenNotFound
            /// </summary>
            [EnumMember(Value = "TokenNotFound")]
            TokenNotFound = 2,
            /// <summary>
            /// Enum SubscriptionNotActive for value: SubscriptionNotActive
            /// </summary>
            [EnumMember(Value = "SubscriptionNotActive")]
            SubscriptionNotActive = 3,
            /// <summary>
            /// Enum WrongRegion for value: WrongRegion
            /// </summary>
            [EnumMember(Value = "WrongRegion")]
            WrongRegion = 4
        }
        /// <summary>
        /// Error code:  * &#x60;TokenRequired&#x60; - &#x60;Auth-API-Key&#x60; header is missing or empty  * &#x60;TokenNotFound&#x60; - subscription not found for specified secret key  * &#x60;SubscriptionNotActive&#x60; - subscription is not active  * &#x60;WrongRegion&#x60; - server and subscription region differ 
        /// </summary>
        /// <value>Error code:  * &#x60;TokenRequired&#x60; - &#x60;Auth-API-Key&#x60; header is missing or empty  * &#x60;TokenNotFound&#x60; - subscription not found for specified secret key  * &#x60;SubscriptionNotActive&#x60; - subscription is not active  * &#x60;WrongRegion&#x60; - server and subscription region differ </value>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public CodeEnum Code { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorEvent403ResponseError" /> class.
        /// </summary>
        /// <param name="code">Error code:  * &#x60;TokenRequired&#x60; - &#x60;Auth-API-Key&#x60; header is missing or empty  * &#x60;TokenNotFound&#x60; - subscription not found for specified secret key  * &#x60;SubscriptionNotActive&#x60; - subscription is not active  * &#x60;WrongRegion&#x60; - server and subscription region differ  (required).</param>
        /// <param name="message">message (required).</param>
        public ErrorEvent403ResponseError(CodeEnum code = default(CodeEnum), string message = default(string))
        {
            // to ensure "code" is required (not null)

            if (code == null)
            {
                throw new InvalidDataException("code is a required property for ErrorEvent403ResponseError and cannot be null");
            }
            else
            {
                this.Code = code;
            }
            // to ensure "message" is required (not null)

            if (message == null)
            {
                throw new InvalidDataException("message is a required property for ErrorEvent403ResponseError and cannot be null");
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
            sb.Append("class ErrorEvent403ResponseError {\n");
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
        /// Returns true if ErrorEvent403ResponseError instances are equal
        /// </summary>
        /// <param name="input">Instance of ErrorEvent403ResponseError to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ErrorEvent403ResponseError input)
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