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
    /// Group of colors that describe the palette of colors to be used when playing dynamics
    /// </summary>
    [DataContract(Name = "ScenePalette")]
    public partial class ScenePalette : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScenePalette" /> class.
        /// </summary>
        /// <param name="color">color.</param>
        /// <param name="dimming">dimming.</param>
        /// <param name="colorTemperature">colorTemperature.</param>
        /// <param name="effects">effects.</param>
        public ScenePalette(List<ColorPaletteGet> color = default(List<ColorPaletteGet>), List<Dimming> dimming = default(List<Dimming>), List<ColorTemperaturePalettePost> colorTemperature = default(List<ColorTemperaturePalettePost>), List<ScenePaletteEffectsInner> effects = default(List<ScenePaletteEffectsInner>))
        {
            this.Color = color;
            this.Dimming = dimming;
            this.ColorTemperature = colorTemperature;
            this.Effects = effects;
        }

        /// <summary>
        /// Gets or Sets Color
        /// </summary>
        [DataMember(Name = "color", EmitDefaultValue = false)]
        public List<ColorPaletteGet> Color { get; set; }

        /// <summary>
        /// Gets or Sets Dimming
        /// </summary>
        [DataMember(Name = "dimming", EmitDefaultValue = false)]
        public List<Dimming> Dimming { get; set; }

        /// <summary>
        /// Gets or Sets ColorTemperature
        /// </summary>
        [DataMember(Name = "color_temperature", EmitDefaultValue = false)]
        public List<ColorTemperaturePalettePost> ColorTemperature { get; set; }

        /// <summary>
        /// Gets or Sets Effects
        /// </summary>
        [DataMember(Name = "effects", EmitDefaultValue = false)]
        public List<ScenePaletteEffectsInner> Effects { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ScenePalette {\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
            sb.Append("  Dimming: ").Append(Dimming).Append("\n");
            sb.Append("  ColorTemperature: ").Append(ColorTemperature).Append("\n");
            sb.Append("  Effects: ").Append(Effects).Append("\n");
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