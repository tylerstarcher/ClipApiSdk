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
    /// Color gamut of color bulb. Some bulbs do not properly return the Gamut information. In this case this is not present.
    /// </summary>
    [DataContract(Name = "LightGet_allOf_color_gamut")]
    public partial class LightGetAllOfColorGamut : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LightGetAllOfColorGamut" /> class.
        /// </summary>
        /// <param name="red">red.</param>
        /// <param name="green">green.</param>
        /// <param name="blue">blue.</param>
        public LightGetAllOfColorGamut(GamutPosition red = default(GamutPosition), GamutPosition green = default(GamutPosition), GamutPosition blue = default(GamutPosition))
        {
            this.Red = red;
            this.Green = green;
            this.Blue = blue;
        }

        /// <summary>
        /// Gets or Sets Red
        /// </summary>
        [DataMember(Name = "red", EmitDefaultValue = false)]
        public GamutPosition Red { get; set; }

        /// <summary>
        /// Gets or Sets Green
        /// </summary>
        [DataMember(Name = "green", EmitDefaultValue = false)]
        public GamutPosition Green { get; set; }

        /// <summary>
        /// Gets or Sets Blue
        /// </summary>
        [DataMember(Name = "blue", EmitDefaultValue = false)]
        public GamutPosition Blue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LightGetAllOfColorGamut {\n");
            sb.Append("  Red: ").Append(Red).Append("\n");
            sb.Append("  Green: ").Append(Green).Append("\n");
            sb.Append("  Blue: ").Append(Blue).Append("\n");
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