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
    /// ColorPaletteGet
    /// </summary>
    [DataContract(Name = "ColorPaletteGet")]
    public partial class ColorPaletteGet : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ColorPaletteGet" /> class.
        /// </summary>
        /// <param name="color">color.</param>
        /// <param name="dimming">dimming.</param>
        public ColorPaletteGet(Color color = default(Color), Dimming dimming = default(Dimming))
        {
            this.Color = color;
            this.Dimming = dimming;
        }

        /// <summary>
        /// Gets or Sets Color
        /// </summary>
        [DataMember(Name = "color", EmitDefaultValue = false)]
        public Color Color { get; set; }

        /// <summary>
        /// Gets or Sets Dimming
        /// </summary>
        [DataMember(Name = "dimming", EmitDefaultValue = false)]
        public Dimming Dimming { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ColorPaletteGet {\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
            sb.Append("  Dimming: ").Append(Dimming).Append("\n");
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
