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
    /// Base class for all objects requiring a valid names for all engines.
    /// </summary>
    [DataContract]
    public partial class Model :  IEquatable<Model>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Model" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Model() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Model" /> class.
        /// </summary>
        /// <param name="name">Name of the object used in all simulation engines. Must not contain spaces and use only letters, digits and underscores/dashes. It cannot be longer than 100 characters. (required).</param>
        /// <param name="buildings">A list of Buildings in the model. (required).</param>
        /// <param name="properties">Extension properties for particular simulation engines (Radiance, EnergyPlus). (required).</param>
        /// <param name="displayName">Display name of the object with no restrictions..</param>
        /// <param name="type">type (default to &quot;Model&quot;).</param>
        /// <param name="contextShades">A list of ContextShades in the model..</param>
        /// <param name="northAngle">The clockwise north direction in degrees. (default to 0).</param>
        public Model(string name, List<Building> buildings, ModelProperties properties, string displayName = default, string type = "Model", List<ContextShade> contextShades = default, double northAngle = 0)
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for Model and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            
            // to ensure "buildings" is required (not null)
            if (buildings == null)
            {
                throw new InvalidDataException("buildings is a required property for Model and cannot be null");
            }
            else
            {
                this.Buildings = buildings;
            }
            
            // to ensure "properties" is required (not null)
            if (properties == null)
            {
                throw new InvalidDataException("properties is a required property for Model and cannot be null");
            }
            else
            {
                this.Properties = properties;
            }
            
            this.DisplayName = displayName;
            // use default value if no "type" provided
            if (type == null)
            {
                this.Type = "Model";
            }
            else
            {
                this.Type = type;
            }
            this.ContextShades = contextShades;
            // use default value if no "northAngle" provided
            if (northAngle == null)
            {
                this.NorthAngle = 0;
            }
            else
            {
                this.NorthAngle = northAngle;
            }
        }
        
        /// <summary>
        /// Name of the object used in all simulation engines. Must not contain spaces and use only letters, digits and underscores/dashes. It cannot be longer than 100 characters.
        /// </summary>
        /// <value>Name of the object used in all simulation engines. Must not contain spaces and use only letters, digits and underscores/dashes. It cannot be longer than 100 characters.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// A list of Buildings in the model.
        /// </summary>
        /// <value>A list of Buildings in the model.</value>
        [DataMember(Name="buildings", EmitDefaultValue=false)]
        [JsonProperty("buildings")]
        public List<Building> Buildings { get; set; }

        /// <summary>
        /// Extension properties for particular simulation engines (Radiance, EnergyPlus).
        /// </summary>
        /// <value>Extension properties for particular simulation engines (Radiance, EnergyPlus).</value>
        [DataMember(Name="properties", EmitDefaultValue=false)]
        [JsonProperty("properties")]
        public ModelProperties Properties { get; set; }

        /// <summary>
        /// Display name of the object with no restrictions.
        /// </summary>
        /// <value>Display name of the object with no restrictions.</value>
        [DataMember(Name="display_name", EmitDefaultValue=false)]
        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// A list of ContextShades in the model.
        /// </summary>
        /// <value>A list of ContextShades in the model.</value>
        [DataMember(Name="context_shades", EmitDefaultValue=false)]
        [JsonProperty("context_shades")]
        public List<ContextShade> ContextShades { get; set; }

        /// <summary>
        /// The clockwise north direction in degrees.
        /// </summary>
        /// <value>The clockwise north direction in degrees.</value>
        [DataMember(Name="north_angle", EmitDefaultValue=false)]
        [JsonProperty("north_angle")]
        public double NorthAngle { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Model {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Buildings: ").Append(Buildings).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ContextShades: ").Append(ContextShades).Append("\n");
            sb.Append("  NorthAngle: ").Append(NorthAngle).Append("\n");
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
        /// <returns>Model object</returns>
        public static Model FromJson(string json)
        {
            return JsonConvert.DeserializeObject<Model>(json, new AnyOfJsonConverter());
        }


        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Model);
        }

        /// <summary>
        /// Returns true if Model instances are equal
        /// </summary>
        /// <param name="input">Instance of Model to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Model input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Buildings == input.Buildings ||
                    this.Buildings != null &&
                    input.Buildings != null &&
                    this.Buildings.SequenceEqual(input.Buildings)
                ) && 
                (
                    this.Properties == input.Properties ||
                    (this.Properties != null &&
                    this.Properties.Equals(input.Properties))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.ContextShades == input.ContextShades ||
                    this.ContextShades != null &&
                    input.ContextShades != null &&
                    this.ContextShades.SequenceEqual(input.ContextShades)
                ) && 
                (
                    this.NorthAngle == input.NorthAngle ||
                    (this.NorthAngle != null &&
                    this.NorthAngle.Equals(input.NorthAngle))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Buildings != null)
                    hashCode = hashCode * 59 + this.Buildings.GetHashCode();
                if (this.Properties != null)
                    hashCode = hashCode * 59 + this.Properties.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.ContextShades != null)
                    hashCode = hashCode * 59 + this.ContextShades.GetHashCode();
                if (this.NorthAngle != null)
                    hashCode = hashCode * 59 + this.NorthAngle.GetHashCode();
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
            // Name (string) maxLength
            if(this.Name != null && this.Name.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 100.", new [] { "Name" });
            }

            // Name (string) minLength
            if(this.Name != null && this.Name.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 1.", new [] { "Name" });
            }

            // Name (string) pattern
            Regex regexName = new Regex(@"[A-Za-z0-9_-]", RegexOptions.CultureInvariant);
            if (false == regexName.Match(this.Name).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, must match a pattern of " + regexName, new [] { "Name" });
            }

            // Type (string) pattern
            Regex regexType = new Regex(@"^Model$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            // NorthAngle (double) minimum
            if(this.NorthAngle < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for NorthAngle, must be a value greater than or equal to 0.", new [] { "NorthAngle" });
            }

            yield break;
        }
    }

}