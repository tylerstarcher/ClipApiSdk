/*
 * Hue CLIP API
 *
 * See [openhue/openhue-api](https://github.com/openhue/openhue-api)
 *
 * The version of the OpenAPI document: v2
 * Contact: contact@openhue.io
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = clipapisdk.Client.OpenAPIDateConverter;

namespace clipapisdk.Model
{
    /// <summary>
    /// LightGetAllOfPowerupDimming
    /// </summary>
    [DataContract(Name = "LightGet_allOf_powerup_dimming")]
    public partial class LightGetAllOfPowerupDimming : IValidatableObject
    {
        /// <summary>
        /// Dimming will set the brightness to the specified value after power up. When setting mode “dimming”, the dimming property must be included. Previous will set brightness to the state it was in before powering off. 
        /// </summary>
        /// <value>Dimming will set the brightness to the specified value after power up. When setting mode “dimming”, the dimming property must be included. Previous will set brightness to the state it was in before powering off. </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ModeEnum
        {
            /// <summary>
            /// Enum Dimming for value: dimming
            /// </summary>
            [EnumMember(Value = "dimming")]
            Dimming = 1,

            /// <summary>
            /// Enum Previous for value: previous
            /// </summary>
            [EnumMember(Value = "previous")]
            Previous = 2
        }


        /// <summary>
        /// Dimming will set the brightness to the specified value after power up. When setting mode “dimming”, the dimming property must be included. Previous will set brightness to the state it was in before powering off. 
        /// </summary>
        /// <value>Dimming will set the brightness to the specified value after power up. When setting mode “dimming”, the dimming property must be included. Previous will set brightness to the state it was in before powering off. </value>
        [DataMember(Name = "mode", EmitDefaultValue = false)]
        public ModeEnum? Mode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="LightGetAllOfPowerupDimming" /> class.
        /// </summary>
        /// <param name="mode">Dimming will set the brightness to the specified value after power up. When setting mode “dimming”, the dimming property must be included. Previous will set brightness to the state it was in before powering off. .</param>
        /// <param name="dimming">dimming.</param>
        /// <param name="color">color.</param>
        public LightGetAllOfPowerupDimming(ModeEnum? mode = default(ModeEnum?), Dimming dimming = default(Dimming), LightGetAllOfPowerupDimmingColor color = default(LightGetAllOfPowerupDimmingColor))
        {
            this.Mode = mode;
            this.Dimming = dimming;
            this.Color = color;
        }

        /// <summary>
        /// Gets or Sets Dimming
        /// </summary>
        [DataMember(Name = "dimming", EmitDefaultValue = false)]
        public Dimming Dimming { get; set; }

        /// <summary>
        /// Gets or Sets Color
        /// </summary>
        [DataMember(Name = "color", EmitDefaultValue = false)]
        public LightGetAllOfPowerupDimmingColor Color { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LightGetAllOfPowerupDimming {\n");
            sb.Append("  Mode: ").Append(Mode).Append("\n");
            sb.Append("  Dimming: ").Append(Dimming).Append("\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
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