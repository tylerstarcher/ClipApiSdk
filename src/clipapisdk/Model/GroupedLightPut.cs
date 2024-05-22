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
    /// GroupedLightPut
    /// </summary>
    [DataContract(Name = "GroupedLightPut")]
    public partial class GroupedLightPut : IValidatableObject
    {
        /// <summary>
        /// Type of the supported resources (always &#x60;grouped_light&#x60; here)
        /// </summary>
        /// <value>Type of the supported resources (always &#x60;grouped_light&#x60; here)</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum GroupedLight for value: grouped_light
            /// </summary>
            [EnumMember(Value = "grouped_light")]
            GroupedLight = 1
        }


        /// <summary>
        /// Type of the supported resources (always &#x60;grouped_light&#x60; here)
        /// </summary>
        /// <value>Type of the supported resources (always &#x60;grouped_light&#x60; here)</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupedLightPut" /> class.
        /// </summary>
        /// <param name="type">Type of the supported resources (always &#x60;grouped_light&#x60; here).</param>
        /// <param name="on">on.</param>
        /// <param name="dimming">dimming.</param>
        /// <param name="dimmingDelta">dimmingDelta.</param>
        /// <param name="colorTemperature">colorTemperature.</param>
        /// <param name="colorTemperatureDelta">colorTemperatureDelta.</param>
        /// <param name="color">color.</param>
        /// <param name="alert">alert.</param>
        /// <param name="signaling">signaling.</param>
        /// <param name="dynamics">dynamics.</param>
        public GroupedLightPut(TypeEnum? type = default(TypeEnum?), On on = default(On), Dimming dimming = default(Dimming), DimmingDelta dimmingDelta = default(DimmingDelta), ColorTemperature colorTemperature = default(ColorTemperature), ColorTemperatureDelta colorTemperatureDelta = default(ColorTemperatureDelta), Color color = default(Color), Alert alert = default(Alert), Signaling signaling = default(Signaling), Dynamics2 dynamics = default(Dynamics2))
        {
            this.Type = type;
            this.On = on;
            this.Dimming = dimming;
            this.DimmingDelta = dimmingDelta;
            this.ColorTemperature = colorTemperature;
            this.ColorTemperatureDelta = colorTemperatureDelta;
            this.Color = color;
            this.Alert = alert;
            this.Signaling = signaling;
            this.Dynamics = dynamics;
        }

        /// <summary>
        /// Gets or Sets On
        /// </summary>
        [DataMember(Name = "on", EmitDefaultValue = false)]
        public On On { get; set; }

        /// <summary>
        /// Gets or Sets Dimming
        /// </summary>
        [DataMember(Name = "dimming", EmitDefaultValue = false)]
        public Dimming Dimming { get; set; }

        /// <summary>
        /// Gets or Sets DimmingDelta
        /// </summary>
        [DataMember(Name = "dimming_delta", EmitDefaultValue = false)]
        public DimmingDelta DimmingDelta { get; set; }

        /// <summary>
        /// Gets or Sets ColorTemperature
        /// </summary>
        [DataMember(Name = "color_temperature", EmitDefaultValue = false)]
        public ColorTemperature ColorTemperature { get; set; }

        /// <summary>
        /// Gets or Sets ColorTemperatureDelta
        /// </summary>
        [DataMember(Name = "color_temperature_delta", EmitDefaultValue = false)]
        public ColorTemperatureDelta ColorTemperatureDelta { get; set; }

        /// <summary>
        /// Gets or Sets Color
        /// </summary>
        [DataMember(Name = "color", EmitDefaultValue = false)]
        public Color Color { get; set; }

        /// <summary>
        /// Gets or Sets Alert
        /// </summary>
        [DataMember(Name = "alert", EmitDefaultValue = false)]
        public Alert Alert { get; set; }

        /// <summary>
        /// Gets or Sets Signaling
        /// </summary>
        [DataMember(Name = "signaling", EmitDefaultValue = false)]
        public Signaling Signaling { get; set; }

        /// <summary>
        /// Gets or Sets Dynamics
        /// </summary>
        [DataMember(Name = "dynamics", EmitDefaultValue = false)]
        public Dynamics2 Dynamics { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GroupedLightPut {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  On: ").Append(On).Append("\n");
            sb.Append("  Dimming: ").Append(Dimming).Append("\n");
            sb.Append("  DimmingDelta: ").Append(DimmingDelta).Append("\n");
            sb.Append("  ColorTemperature: ").Append(ColorTemperature).Append("\n");
            sb.Append("  ColorTemperatureDelta: ").Append(ColorTemperatureDelta).Append("\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
            sb.Append("  Alert: ").Append(Alert).Append("\n");
            sb.Append("  Signaling: ").Append(Signaling).Append("\n");
            sb.Append("  Dynamics: ").Append(Dynamics).Append("\n");
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
