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
    /// Contains results from all activated products - Fingerprint Pro, Bot Detection, and others.
    /// </summary>
    [DataContract]
    public partial class EventResponse : IEquatable<EventResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EventResponse" /> class.
        /// </summary>
        /// <param name="products">products (required).</param>
        /// <param name="error">error.</param>
        public EventResponse(ProductsResponse products = default(ProductsResponse), ProductError error = default(ProductError))
        {
            // to ensure "products" is required (not null)

            if (products == null)
            {
                throw new InvalidDataException("products is a required property for EventResponse and cannot be null");
            }
            else
            {
                this.Products = products;
            }
            this.Error = error;
        }

        /// <summary>
        /// Gets or Sets Products
        /// </summary>
        [DataMember(Name = "products", EmitDefaultValue = false)]
        public ProductsResponse Products { get; set; }

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
            sb.Append("class EventResponse {\n");
            sb.Append("  Products: ").Append(Products).Append("\n");
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
        /// Returns true if EventResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of EventResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EventResponse input)
        {
            if (input == null)
                return false;

            return
                (
                this.Products == input.Products ||
                (this.Products != null &&
                this.Products.Equals(input.Products))
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
                if (this.Products != null)
                    hashCode = hashCode * 59 + this.Products.GetHashCode();
                if (this.Error != null)
                    hashCode = hashCode * 59 + this.Error.GetHashCode();
                return hashCode;
            }
        }

    }
}