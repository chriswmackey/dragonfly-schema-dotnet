/* 
 * Dragonfly Model Schema
 *
 * Documentation for Dragonfly model schema
 *
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
using HoneybeeSchema;
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;


namespace DragonflySchema
{
    /// <summary>
    /// A single window defined by an area ratio with the base surface.
    /// </summary>
    [DataContract(Name = "SimpleWindowRatio")]
    [JsonConverter(typeof(JsonSubtypes), "Type")]
    public partial class SimpleWindowRatio : OpenAPIGenBaseModel, IEquatable<SimpleWindowRatio>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleWindowRatio" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SimpleWindowRatio() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "SimpleWindowRatio";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleWindowRatio" /> class.
        /// </summary>
        /// <param name="windowRatio">A number between 0 and 1 for the ratio between the window area and the parent wall surface area. (required).</param>
        public SimpleWindowRatio
        (
             double windowRatio// Required parameters
             // Optional parameters
        ) : base()// BaseClass
        {
            this.WindowRatio = windowRatio;

            // Set non-required readonly properties with defaultValue
            this.Type = "SimpleWindowRatio";
        }

        /// <summary>
        /// A number between 0 and 1 for the ratio between the window area and the parent wall surface area.
        /// </summary>
        /// <value>A number between 0 and 1 for the ratio between the window area and the parent wall surface area.</value>
        [DataMember(Name = "window_ratio", IsRequired = true, EmitDefaultValue = false)]
        
        public double WindowRatio { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "SimpleWindowRatio";
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
            sb.Append("SimpleWindowRatio:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  WindowRatio: ").Append(WindowRatio).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>SimpleWindowRatio object</returns>
        public static SimpleWindowRatio FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<SimpleWindowRatio>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>SimpleWindowRatio object</returns>
        public virtual SimpleWindowRatio DuplicateSimpleWindowRatio()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateSimpleWindowRatio();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateSimpleWindowRatio();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as SimpleWindowRatio);
        }

        /// <summary>
        /// Returns true if SimpleWindowRatio instances are equal
        /// </summary>
        /// <param name="input">Instance of SimpleWindowRatio to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SimpleWindowRatio input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                (
                    this.WindowRatio == input.WindowRatio ||
                    (this.WindowRatio != null &&
                    this.WindowRatio.Equals(input.WindowRatio))
                ) && base.Equals(input) && 
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
                int hashCode = base.GetHashCode();
                if (this.WindowRatio != null)
                    hashCode = hashCode * 59 + this.WindowRatio.GetHashCode();
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
            foreach(var x in base.BaseValidate(validationContext)) yield return x;

            
            // Type (string) pattern
            Regex regexType = new Regex(@"^SimpleWindowRatio$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
