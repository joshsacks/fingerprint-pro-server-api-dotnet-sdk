/* 
 * Fingerprint Pro Server API
 *
 * Fingerprint Pro Server API allows you to get information about visitors and about individual events in a server environment. This API can be used for data exports, decision-making, and data analysis scenarios.
 *
 * OpenAPI spec version: 3
 * Contact: support@fingerprint.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = sdk.Client.SwaggerDateConverter;

namespace sdk.Model
{
    /// <summary>
    /// Contains all the information from Bot Detection product
    /// </summary>
    [DataContract]
        public partial class BotdResult :  IEquatable<BotdResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BotdResult" /> class.
        /// </summary>
        /// <param name="ip">IP address of the requesting browser or bot. (required).</param>
        /// <param name="time">Time in UTC when the request from the JS agent was made. We recommend to treat requests that are older than 2 minutes as malicious. Otherwise, request replay attacks are possible (required).</param>
        /// <param name="url">Page URL from which identification request was sent. (required).</param>
        /// <param name="bot">bot (required).</param>
        public BotdResult(string ip = default(string), DateTime? time = default(DateTime?), string url = default(string), BotdDetectionResult bot = default(BotdDetectionResult))
        {
            // to ensure "ip" is required (not null)
            if (ip == null)
            {
                throw new InvalidDataException("ip is a required property for BotdResult and cannot be null");
            }
            else
            {
                this.Ip = ip;
            }
            // to ensure "time" is required (not null)
            if (time == null)
            {
                throw new InvalidDataException("time is a required property for BotdResult and cannot be null");
            }
            else
            {
                this.Time = time;
            }
            // to ensure "url" is required (not null)
            if (url == null)
            {
                throw new InvalidDataException("url is a required property for BotdResult and cannot be null");
            }
            else
            {
                this.Url = url;
            }
            // to ensure "bot" is required (not null)
            if (bot == null)
            {
                throw new InvalidDataException("bot is a required property for BotdResult and cannot be null");
            }
            else
            {
                this.Bot = bot;
            }
        }
        
        /// <summary>
        /// IP address of the requesting browser or bot.
        /// </summary>
        /// <value>IP address of the requesting browser or bot.</value>
        [DataMember(Name="ip", EmitDefaultValue=false)]
        public string Ip { get; set; }

        /// <summary>
        /// Time in UTC when the request from the JS agent was made. We recommend to treat requests that are older than 2 minutes as malicious. Otherwise, request replay attacks are possible
        /// </summary>
        /// <value>Time in UTC when the request from the JS agent was made. We recommend to treat requests that are older than 2 minutes as malicious. Otherwise, request replay attacks are possible</value>
        [DataMember(Name="time", EmitDefaultValue=false)]
        public DateTime? Time { get; set; }

        /// <summary>
        /// Page URL from which identification request was sent.
        /// </summary>
        /// <value>Page URL from which identification request was sent.</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }

        /// <summary>
        /// Gets or Sets Bot
        /// </summary>
        [DataMember(Name="bot", EmitDefaultValue=false)]
        public BotdDetectionResult Bot { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BotdResult {\n");
            sb.Append("  Ip: ").Append(Ip).Append("\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Bot: ").Append(Bot).Append("\n");
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
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as BotdResult);
        }

        /// <summary>
        /// Returns true if BotdResult instances are equal
        /// </summary>
        /// <param name="input">Instance of BotdResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BotdResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Ip == input.Ip ||
                    (this.Ip != null &&
                    this.Ip.Equals(input.Ip))
                ) && 
                (
                    this.Time == input.Time ||
                    (this.Time != null &&
                    this.Time.Equals(input.Time))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.Bot == input.Bot ||
                    (this.Bot != null &&
                    this.Bot.Equals(input.Bot))
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
                if (this.Ip != null)
                    hashCode = hashCode * 59 + this.Ip.GetHashCode();
                if (this.Time != null)
                    hashCode = hashCode * 59 + this.Time.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.Bot != null)
                    hashCode = hashCode * 59 + this.Bot.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
