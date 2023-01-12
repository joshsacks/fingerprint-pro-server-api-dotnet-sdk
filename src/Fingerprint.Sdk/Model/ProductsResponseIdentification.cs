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
    /// ProductsResponseIdentification
    /// </summary>
    [DataContract]
    public partial class ProductsResponseIdentification : IEquatable<ProductsResponseIdentification>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductsResponseIdentification" /> class.
        /// </summary>
        /// <param name="data">data.</param>
        public ProductsResponseIdentification(ProductsResponseIdentificationData data = default(ProductsResponseIdentificationData))
        {
            this.Data = data;
        }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public ProductsResponseIdentificationData Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductsResponseIdentification {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
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
        /// Returns true if ProductsResponseIdentification instances are equal
        /// </summary>
        /// <param name="input">Instance of ProductsResponseIdentification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductsResponseIdentification input)
        {
            if (input == null)
                return false;

            return
                (
                this.Data == input.Data ||
                (this.Data != null &&
                this.Data.Equals(input.Data))
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
                return hashCode;
            }
        }

    }
}