/* 
 * Dragonfly Model Schema
 *
 * This is the documentation for Dragonfly model schema.
 *
 * The version of the OpenAPI document: 1.5.21
 * Contact: info@ladybug.tools
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
using HoneybeeSchema;


namespace DragonflySchema
{
    /// <summary>
    /// Several rectangular windows, defined by origin, width and height.
    /// </summary>
    [DataContract]
    public partial class RectangularWindows : HoneybeeObject, IEquatable<RectangularWindows>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="RectangularWindows" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RectangularWindows() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RectangularWindows" /> class.
        /// </summary>
        /// <param name="origins">An array of 2D points within the plane of the wall for the origin of each window. Each point should be a list of 2 (x, y) values. The wall plane is assumed to have an origin at the first point of the wall segment and an X-axis extending along the length of the segment. The wall plane Y-axis always points upwards. Therefore, both X and Y values of each origin point should be positive. (required).</param>
        /// <param name="widths">An array of positive numbers for the window widths. The length of this list must match the length of the origins. (required).</param>
        /// <param name="heights">An array of positive numbers for the window heights. The length of this list must match the length of the origins. (required).</param>
        public RectangularWindows
        (
             List<List<double>> origins, List<double> widths, List<double> heights// Required parameters
             // Optional parameters
        )// BaseClass
        {
            // to ensure "origins" is required (not null)
            if (origins == null)
            {
                throw new InvalidDataException("origins is a required property for RectangularWindows and cannot be null");
            }
            else
            {
                this.Origins = origins;
            }
            
            // to ensure "widths" is required (not null)
            if (widths == null)
            {
                throw new InvalidDataException("widths is a required property for RectangularWindows and cannot be null");
            }
            else
            {
                this.Widths = widths;
            }
            
            // to ensure "heights" is required (not null)
            if (heights == null)
            {
                throw new InvalidDataException("heights is a required property for RectangularWindows and cannot be null");
            }
            else
            {
                this.Heights = heights;
            }
            

            // Set non-required readonly properties with defaultValue
            this.Type = "RectangularWindows";
        }
        
        /// <summary>
        /// An array of 2D points within the plane of the wall for the origin of each window. Each point should be a list of 2 (x, y) values. The wall plane is assumed to have an origin at the first point of the wall segment and an X-axis extending along the length of the segment. The wall plane Y-axis always points upwards. Therefore, both X and Y values of each origin point should be positive.
        /// </summary>
        /// <value>An array of 2D points within the plane of the wall for the origin of each window. Each point should be a list of 2 (x, y) values. The wall plane is assumed to have an origin at the first point of the wall segment and an X-axis extending along the length of the segment. The wall plane Y-axis always points upwards. Therefore, both X and Y values of each origin point should be positive.</value>
        [DataMember(Name="origins", EmitDefaultValue=false)]
        [JsonProperty("origins")]
        public List<List<double>> Origins { get; set; } 
        /// <summary>
        /// An array of positive numbers for the window widths. The length of this list must match the length of the origins.
        /// </summary>
        /// <value>An array of positive numbers for the window widths. The length of this list must match the length of the origins.</value>
        [DataMember(Name="widths", EmitDefaultValue=false)]
        [JsonProperty("widths")]
        public List<double> Widths { get; set; } 
        /// <summary>
        /// An array of positive numbers for the window heights. The length of this list must match the length of the origins.
        /// </summary>
        /// <value>An array of positive numbers for the window heights. The length of this list must match the length of the origins.</value>
        [DataMember(Name="heights", EmitDefaultValue=false)]
        [JsonProperty("heights")]
        public List<double> Heights { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            if (this is IIDdBase iDd)
                return $"RectangularWindows {iDd.Identifier}";
       
            return "RectangularWindows";
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString(bool detailed)
        {
            if (!detailed)
                return this.ToString();
            
            var sb = new StringBuilder();
            sb.Append("RectangularWindows:\n");
            sb.Append("  Origins: ").Append(Origins).Append("\n");
            sb.Append("  Widths: ").Append(Widths).Append("\n");
            sb.Append("  Heights: ").Append(Heights).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented, JsonSetting.AnyOfConvertSetting);
        }

        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>RectangularWindows object</returns>
        public static RectangularWindows FromJson(string json)
        {
            return JsonConvert.DeserializeObject<RectangularWindows>(json, JsonSetting.AnyOfConvertSetting);
        }
     

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as RectangularWindows);
        }

        /// <summary>
        /// Returns true if RectangularWindows instances are equal
        /// </summary>
        /// <param name="input">Instance of RectangularWindows to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RectangularWindows input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Origins == input.Origins ||
                    this.Origins != null &&
                    input.Origins != null &&
                    this.Origins.SequenceEqual(input.Origins)
                ) && 
                (
                    this.Widths == input.Widths ||
                    this.Widths != null &&
                    input.Widths != null &&
                    this.Widths.SequenceEqual(input.Widths)
                ) && 
                (
                    this.Heights == input.Heights ||
                    this.Heights != null &&
                    input.Heights != null &&
                    this.Heights.SequenceEqual(input.Heights)
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
                if (this.Origins != null)
                    hashCode = hashCode * 59 + this.Origins.GetHashCode();
                if (this.Widths != null)
                    hashCode = hashCode * 59 + this.Widths.GetHashCode();
                if (this.Heights != null)
                    hashCode = hashCode * 59 + this.Heights.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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
            // Type (string) pattern
            Regex regexType = new Regex(@"^RectangularWindows$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }

}
