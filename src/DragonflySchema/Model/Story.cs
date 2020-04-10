/* 
 * Dragonfly Model Schema
 *
 * This is the documentation for Dragonfly model schema.
 *
 * The version of the OpenAPI document: 1.0.0
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


namespace DragonflySchema
{
    /// <summary>
    /// Base class for all objects requiring a identifiers acceptable for all engines.
    /// </summary>
    [DataContract]
    public partial class Story :  IEquatable<Story>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Story" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Story() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Story" /> class.
        /// </summary>
        /// <param name="identifier">Text string for a unique object ID. This identifier remains constant as the object is mutated, copied, and serialized to different formats (eg. dict, idf, rad). This identifier is also used to reference the object across a Model. It must be &lt; 100 characters and not contain any spaces or special characters. (required).</param>
        /// <param name="room2ds">An array of dragonfly Room2D objects that together form an entire story of a building. (required).</param>
        /// <param name="properties">Extension properties for particular simulation engines (Radiance, EnergyPlus). (required).</param>
        /// <param name="displayName">Display name of the object with no character restrictions..</param>
        /// <param name="userData">Optional dictionary of user data associated with the object.All keys and values of this dictionary should be of a standard data type to ensure correct serialization of the object (eg. str, float, int, list)..</param>
        /// <param name="type">type (default to &quot;Story&quot;).</param>
        /// <param name="floorToFloorHeight">A number for the distance from the floor plate of this story to the floor of the story above this one (if it exists). If None, this value will be the maximum floor_to_ceiling_height of the input room_2ds..</param>
        /// <param name="multiplier">An integer that denotes the number of times that this Story is repeated over the height of the building. (default to 1).</param>
        public Story(string identifier, List<Room2D> room2ds, StoryPropertiesAbridged properties, string displayName = default, Object userData = default, string type = "Story", double floorToFloorHeight = default, int multiplier = 1)
        {
            // to ensure "identifier" is required (not null)
            if (identifier == null)
            {
                throw new InvalidDataException("identifier is a required property for Story and cannot be null");
            }
            else
            {
                this.Identifier = identifier;
            }
            
            // to ensure "room2ds" is required (not null)
            if (room2ds == null)
            {
                throw new InvalidDataException("room2ds is a required property for Story and cannot be null");
            }
            else
            {
                this.Room2ds = room2ds;
            }
            
            // to ensure "properties" is required (not null)
            if (properties == null)
            {
                throw new InvalidDataException("properties is a required property for Story and cannot be null");
            }
            else
            {
                this.Properties = properties;
            }
            
            this.DisplayName = displayName;
            this.UserData = userData;
            // use default value if no "type" provided
            if (type == null)
            {
                this.Type = "Story";
            }
            else
            {
                this.Type = type;
            }
            this.FloorToFloorHeight = floorToFloorHeight;
            // use default value if no "multiplier" provided
            if (multiplier == null)
            {
                this.Multiplier = 1;
            }
            else
            {
                this.Multiplier = multiplier;
            }
        }
        
        /// <summary>
        /// Text string for a unique object ID. This identifier remains constant as the object is mutated, copied, and serialized to different formats (eg. dict, idf, rad). This identifier is also used to reference the object across a Model. It must be &lt; 100 characters and not contain any spaces or special characters.
        /// </summary>
        /// <value>Text string for a unique object ID. This identifier remains constant as the object is mutated, copied, and serialized to different formats (eg. dict, idf, rad). This identifier is also used to reference the object across a Model. It must be &lt; 100 characters and not contain any spaces or special characters.</value>
        [DataMember(Name="identifier", EmitDefaultValue=false)]
        [JsonProperty("identifier")]
        public string Identifier { get; set; }

        /// <summary>
        /// An array of dragonfly Room2D objects that together form an entire story of a building.
        /// </summary>
        /// <value>An array of dragonfly Room2D objects that together form an entire story of a building.</value>
        [DataMember(Name="room_2ds", EmitDefaultValue=false)]
        [JsonProperty("room_2ds")]
        public List<Room2D> Room2ds { get; set; }

        /// <summary>
        /// Extension properties for particular simulation engines (Radiance, EnergyPlus).
        /// </summary>
        /// <value>Extension properties for particular simulation engines (Radiance, EnergyPlus).</value>
        [DataMember(Name="properties", EmitDefaultValue=false)]
        [JsonProperty("properties")]
        public StoryPropertiesAbridged Properties { get; set; }

        /// <summary>
        /// Display name of the object with no character restrictions.
        /// </summary>
        /// <value>Display name of the object with no character restrictions.</value>
        [DataMember(Name="display_name", EmitDefaultValue=false)]
        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Optional dictionary of user data associated with the object.All keys and values of this dictionary should be of a standard data type to ensure correct serialization of the object (eg. str, float, int, list).
        /// </summary>
        /// <value>Optional dictionary of user data associated with the object.All keys and values of this dictionary should be of a standard data type to ensure correct serialization of the object (eg. str, float, int, list).</value>
        [DataMember(Name="user_data", EmitDefaultValue=false)]
        [JsonProperty("user_data")]
        public Object UserData { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// A number for the distance from the floor plate of this story to the floor of the story above this one (if it exists). If None, this value will be the maximum floor_to_ceiling_height of the input room_2ds.
        /// </summary>
        /// <value>A number for the distance from the floor plate of this story to the floor of the story above this one (if it exists). If None, this value will be the maximum floor_to_ceiling_height of the input room_2ds.</value>
        [DataMember(Name="floor_to_floor_height", EmitDefaultValue=false)]
        [JsonProperty("floor_to_floor_height")]
        public double FloorToFloorHeight { get; set; }

        /// <summary>
        /// An integer that denotes the number of times that this Story is repeated over the height of the building.
        /// </summary>
        /// <value>An integer that denotes the number of times that this Story is repeated over the height of the building.</value>
        [DataMember(Name="multiplier", EmitDefaultValue=false)]
        [JsonProperty("multiplier")]
        public int Multiplier { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Story {\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  Room2ds: ").Append(Room2ds).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  UserData: ").Append(UserData).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  FloorToFloorHeight: ").Append(FloorToFloorHeight).Append("\n");
            sb.Append("  Multiplier: ").Append(Multiplier).Append("\n");
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
        /// <returns>Story object</returns>
        public static Story FromJson(string json)
        {
            return JsonConvert.DeserializeObject<Story>(json, new AnyOfJsonConverter());
        }


        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Story);
        }

        /// <summary>
        /// Returns true if Story instances are equal
        /// </summary>
        /// <param name="input">Instance of Story to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Story input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Identifier == input.Identifier ||
                    (this.Identifier != null &&
                    this.Identifier.Equals(input.Identifier))
                ) && 
                (
                    this.Room2ds == input.Room2ds ||
                    this.Room2ds != null &&
                    input.Room2ds != null &&
                    this.Room2ds.SequenceEqual(input.Room2ds)
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
                    this.UserData == input.UserData ||
                    (this.UserData != null &&
                    this.UserData.Equals(input.UserData))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.FloorToFloorHeight == input.FloorToFloorHeight ||
                    (this.FloorToFloorHeight != null &&
                    this.FloorToFloorHeight.Equals(input.FloorToFloorHeight))
                ) && 
                (
                    this.Multiplier == input.Multiplier ||
                    (this.Multiplier != null &&
                    this.Multiplier.Equals(input.Multiplier))
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
                if (this.Identifier != null)
                    hashCode = hashCode * 59 + this.Identifier.GetHashCode();
                if (this.Room2ds != null)
                    hashCode = hashCode * 59 + this.Room2ds.GetHashCode();
                if (this.Properties != null)
                    hashCode = hashCode * 59 + this.Properties.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.UserData != null)
                    hashCode = hashCode * 59 + this.UserData.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.FloorToFloorHeight != null)
                    hashCode = hashCode * 59 + this.FloorToFloorHeight.GetHashCode();
                if (this.Multiplier != null)
                    hashCode = hashCode * 59 + this.Multiplier.GetHashCode();
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
            // Identifier (string) maxLength
            if(this.Identifier != null && this.Identifier.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Identifier, length must be less than 100.", new [] { "Identifier" });
            }

            // Identifier (string) minLength
            if(this.Identifier != null && this.Identifier.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Identifier, length must be greater than 1.", new [] { "Identifier" });
            }

            // Identifier (string) pattern
            Regex regexIdentifier = new Regex(@"[A-Za-z0-9_-]", RegexOptions.CultureInvariant);
            if (false == regexIdentifier.Match(this.Identifier).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Identifier, must match a pattern of " + regexIdentifier, new [] { "Identifier" });
            }

            // Type (string) pattern
            Regex regexType = new Regex(@"^Story$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            // Multiplier (int) minimum
            if(this.Multiplier < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Multiplier, must be a value greater than or equal to 1.", new [] { "Multiplier" });
            }

            yield break;
        }
    }

}
