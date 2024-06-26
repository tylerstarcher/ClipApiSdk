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
    /// LightGetAllOfPowerupOn
    /// </summary>
    [DataContract(Name = "LightGet_allOf_powerup_on")]
    public partial class LightGetAllOfPowerupOn : IValidatableObject
    {
        /// <summary>
        /// State to activate after powerup. On will use the value specified in the “on” property. When setting mode “on”, the on property must be included. Toggle will alternate between on and off on each subsequent power toggle. Previous will return to the state it was in before powering off. 
        /// </summary>
        /// <value>State to activate after powerup. On will use the value specified in the “on” property. When setting mode “on”, the on property must be included. Toggle will alternate between on and off on each subsequent power toggle. Previous will return to the state it was in before powering off. </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ModeEnum
        {
            /// <summary>
            /// Enum On for value: on
            /// </summary>
            [EnumMember(Value = "on")]
            On = 1,

            /// <summary>
            /// Enum Toggle for value: toggle
            /// </summary>
            [EnumMember(Value = "toggle")]
            Toggle = 2,

            /// <summary>
            /// Enum Previous for value: previous
            /// </summary>
            [EnumMember(Value = "previous")]
            Previous = 3
        }


        /// <summary>
        /// State to activate after powerup. On will use the value specified in the “on” property. When setting mode “on”, the on property must be included. Toggle will alternate between on and off on each subsequent power toggle. Previous will return to the state it was in before powering off. 
        /// </summary>
        /// <value>State to activate after powerup. On will use the value specified in the “on” property. When setting mode “on”, the on property must be included. Toggle will alternate between on and off on each subsequent power toggle. Previous will return to the state it was in before powering off. </value>
        [DataMember(Name = "mode", EmitDefaultValue = false)]
        public ModeEnum? Mode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="LightGetAllOfPowerupOn" /> class.
        /// </summary>
        /// <param name="mode">State to activate after powerup. On will use the value specified in the “on” property. When setting mode “on”, the on property must be included. Toggle will alternate between on and off on each subsequent power toggle. Previous will return to the state it was in before powering off. .</param>
        /// <param name="on">on.</param>
        public LightGetAllOfPowerupOn(ModeEnum? mode = default(ModeEnum?), On on = default(On))
        {
            this.Mode = mode;
            this.On = on;
        }

        /// <summary>
        /// Gets or Sets On
        /// </summary>
        [DataMember(Name = "on", EmitDefaultValue = false)]
        public On On { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LightGetAllOfPowerupOn {\n");
            sb.Append("  Mode: ").Append(Mode).Append("\n");
            sb.Append("  On: ").Append(On).Append("\n");
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
