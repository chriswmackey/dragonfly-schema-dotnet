/* 
 * Dragonfly Model Schema
 *
 * This is the documentation for Dragonfly model schema.
 *
 * The version of the OpenAPI document: 1.3.0
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


namespace DragonflyDotNet
{
    /// <summary>
    /// Extruded borders over all windows in the wall.
    /// </summary>
    [DataContract]
    public partial class ExtrudedBorder :  IEquatable<ExtrudedBorder>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExtrudedBorder" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ExtrudedBorder() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExtrudedBorder" /> class.
        /// </summary>
        /// <param name="depth">A number for the depth of the border. (required).</param>
        /// <param name="type">type (default to &quot;ExtrudedBorder&quot;).</param>
        public ExtrudedBorder(double depth, string type = "ExtrudedBorder")
        {
            // to ensure "depth" is required (not null)
            if (depth == null)
            {
                throw new InvalidDataException("depth is a required property for ExtrudedBorder and cannot be null");
            }
            else
            {
                this.Depth = depth;
            }
            
            // use default value if no "type" provided
            if (type == null)
            {
                this.Type = "ExtrudedBorder";
            }
            else
            {
                this.Type = type;
            }
        }
        
        /// <summary>
        /// A number for the depth of the border.
        /// </summary>
        /// <value>A number for the depth of the border.</value>
        [DataMember(Name="depth", EmitDefaultValue=false)]
        [JsonProperty("depth")]
        public double Depth { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExtrudedBorder {\n");
            sb.Append("  Depth: ").Append(Depth).Append("\n");
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
            return JsonConvert.SerializeObject(this, Formatting.Indented, new AnyOfJsonConverter());
        }

        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>ExtrudedBorder object</returns>
        public static ExtrudedBorder FromJson(string json)
        {
            return JsonConvert.DeserializeObject<ExtrudedBorder>(json, new AnyOfJsonConverter());
        }


        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExtrudedBorder);
        }

        /// <summary>
        /// Returns true if ExtrudedBorder instances are equal
        /// </summary>
        /// <param name="input">Instance of ExtrudedBorder to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExtrudedBorder input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Depth == input.Depth ||
                    (this.Depth != null &&
                    this.Depth.Equals(input.Depth))
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
                if (this.Depth != null)
                    hashCode = hashCode * 59 + this.Depth.GetHashCode();
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
            Regex regexType = new Regex(@"^ExtrudedBorder$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }

}