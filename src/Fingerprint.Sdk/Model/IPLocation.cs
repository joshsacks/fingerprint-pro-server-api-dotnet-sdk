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
    /// IPLocation
    /// </summary>
    [DataContract]
    public partial class IPLocation : IEquatable<IPLocation>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IPLocation" /> class.
        /// </summary>
        /// <param name="accuracyRadius">accuracyRadius (required).</param>
        /// <param name="latitude">latitude (required).</param>
        /// <param name="longitude">longitude (required).</param>
        /// <param name="postalCode">postalCode.</param>
        /// <param name="timezone">timezone (required).</param>
        /// <param name="city">city.</param>
        /// <param name="country">country (required).</param>
        /// <param name="continent">continent (required).</param>
        /// <param name="subdivisions">subdivisions.</param>
        public IPLocation(int? accuracyRadius = default(int?), double? latitude = default(double?), double? longitude = default(double?), string postalCode = default(string), string timezone = default(string), IPLocationCity city = default(IPLocationCity), Location country = default(Location), Location continent = default(Location), List<Subdivision> subdivisions = default(List<Subdivision>))
        {
            // to ensure "accuracyRadius" is required (not null)

            if (accuracyRadius == null)
            {
                throw new InvalidDataException("accuracyRadius is a required property for IPLocation and cannot be null");
            }
            else
            {
                this.AccuracyRadius = accuracyRadius;
            }
            // to ensure "latitude" is required (not null)

            if (latitude == null)
            {
                throw new InvalidDataException("latitude is a required property for IPLocation and cannot be null");
            }
            else
            {
                this.Latitude = latitude;
            }
            // to ensure "longitude" is required (not null)

            if (longitude == null)
            {
                throw new InvalidDataException("longitude is a required property for IPLocation and cannot be null");
            }
            else
            {
                this.Longitude = longitude;
            }
            // to ensure "timezone" is required (not null)

            if (timezone == null)
            {
                throw new InvalidDataException("timezone is a required property for IPLocation and cannot be null");
            }
            else
            {
                this.Timezone = timezone;
            }
            // to ensure "country" is required (not null)

            if (country == null)
            {
                throw new InvalidDataException("country is a required property for IPLocation and cannot be null");
            }
            else
            {
                this.Country = country;
            }
            // to ensure "continent" is required (not null)

            if (continent == null)
            {
                throw new InvalidDataException("continent is a required property for IPLocation and cannot be null");
            }
            else
            {
                this.Continent = continent;
            }
            this.PostalCode = postalCode;
            this.City = city;
            this.Subdivisions = subdivisions;
        }

        /// <summary>
        /// Gets or Sets AccuracyRadius
        /// </summary>
        [DataMember(Name = "accuracyRadius", EmitDefaultValue = false)]
        public int? AccuracyRadius { get; set; }

        /// <summary>
        /// Gets or Sets Latitude
        /// </summary>
        [DataMember(Name = "latitude", EmitDefaultValue = false)]
        public double? Latitude { get; set; }

        /// <summary>
        /// Gets or Sets Longitude
        /// </summary>
        [DataMember(Name = "longitude", EmitDefaultValue = false)]
        public double? Longitude { get; set; }

        /// <summary>
        /// Gets or Sets PostalCode
        /// </summary>
        [DataMember(Name = "postalCode", EmitDefaultValue = false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Gets or Sets Timezone
        /// </summary>
        [DataMember(Name = "timezone", EmitDefaultValue = false)]
        public string Timezone { get; set; }

        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name = "city", EmitDefaultValue = false)]
        public IPLocationCity City { get; set; }

        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name = "country", EmitDefaultValue = false)]
        public Location Country { get; set; }

        /// <summary>
        /// Gets or Sets Continent
        /// </summary>
        [DataMember(Name = "continent", EmitDefaultValue = false)]
        public Location Continent { get; set; }

        /// <summary>
        /// Gets or Sets Subdivisions
        /// </summary>
        [DataMember(Name = "subdivisions", EmitDefaultValue = false)]
        public List<Subdivision> Subdivisions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IPLocation {\n");
            sb.Append("  AccuracyRadius: ").Append(AccuracyRadius).Append("\n");
            sb.Append("  Latitude: ").Append(Latitude).Append("\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  Timezone: ").Append(Timezone).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Continent: ").Append(Continent).Append("\n");
            sb.Append("  Subdivisions: ").Append(Subdivisions).Append("\n");
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
        /// Returns true if IPLocation instances are equal
        /// </summary>
        /// <param name="input">Instance of IPLocation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IPLocation input)
        {
            if (input == null)
                return false;

            return
                (
                this.AccuracyRadius == input.AccuracyRadius ||
                (this.AccuracyRadius != null &&
                this.AccuracyRadius.Equals(input.AccuracyRadius))
                ) &&
                (
                this.Latitude == input.Latitude ||
                (this.Latitude != null &&
                this.Latitude.Equals(input.Latitude))
                ) &&
                (
                this.Longitude == input.Longitude ||
                (this.Longitude != null &&
                this.Longitude.Equals(input.Longitude))
                ) &&
                (
                this.PostalCode == input.PostalCode ||
                (this.PostalCode != null &&
                this.PostalCode.Equals(input.PostalCode))
                ) &&
                (
                this.Timezone == input.Timezone ||
                (this.Timezone != null &&
                this.Timezone.Equals(input.Timezone))
                ) &&
                (
                this.City == input.City ||
                (this.City != null &&
                this.City.Equals(input.City))
                ) &&
                (
                this.Country == input.Country ||
                (this.Country != null &&
                this.Country.Equals(input.Country))
                ) &&
                (
                this.Continent == input.Continent ||
                (this.Continent != null &&
                this.Continent.Equals(input.Continent))
                ) &&
                (
                this.Subdivisions == input.Subdivisions ||
                this.Subdivisions != null &&
                input.Subdivisions != null &&
                this.Subdivisions.SequenceEqual(input.Subdivisions)
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
                if (this.AccuracyRadius != null)
                    hashCode = hashCode * 59 + this.AccuracyRadius.GetHashCode();
                if (this.Latitude != null)
                    hashCode = hashCode * 59 + this.Latitude.GetHashCode();
                if (this.Longitude != null)
                    hashCode = hashCode * 59 + this.Longitude.GetHashCode();
                if (this.PostalCode != null)
                    hashCode = hashCode * 59 + this.PostalCode.GetHashCode();
                if (this.Timezone != null)
                    hashCode = hashCode * 59 + this.Timezone.GetHashCode();
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.Continent != null)
                    hashCode = hashCode * 59 + this.Continent.GetHashCode();
                if (this.Subdivisions != null)
                    hashCode = hashCode * 59 + this.Subdivisions.GetHashCode();
                return hashCode;
            }
        }

    }
}