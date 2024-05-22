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
    /// ScenePaletteEffectsInner
    /// </summary>
    [DataContract(Name = "ScenePalette_effects_inner")]
    public partial class ScenePaletteEffectsInner : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Effect
        /// </summary>
        [DataMember(Name = "effect", EmitDefaultValue = false)]
        public SupportedEffects? Effect { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ScenePaletteEffectsInner" /> class.
        /// </summary>
        /// <param name="effect">effect.</param>
        public ScenePaletteEffectsInner(SupportedEffects? effect = default(SupportedEffects?))
        {
            this.Effect = effect;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ScenePaletteEffectsInner {\n");
            sb.Append("  Effect: ").Append(Effect).Append("\n");
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