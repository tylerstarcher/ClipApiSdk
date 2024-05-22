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
    /// LightGetAllOfDimming
    /// </summary>
    [DataContract(Name = "LightGet_allOf_dimming")]
    public partial class LightGetAllOfDimming : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LightGetAllOfDimming" /> class.
        /// </summary>
        /// <param name="brightness">Brightness percentage. value cannot be 0, writing 0 changes it to lowest possible brightness.</param>
        /// <param name="minDimLevel">Percentage of the maximum lumen the device outputs on minimum brightness.</param>
        public LightGetAllOfDimming(decimal brightness = default(decimal), decimal minDimLevel = default(decimal))
        {
            this.Brightness = brightness;
            this.MinDimLevel = minDimLevel;
        }

        /// <summary>
        /// Brightness percentage. value cannot be 0, writing 0 changes it to lowest possible brightness
        /// </summary>
        /// <value>Brightness percentage. value cannot be 0, writing 0 changes it to lowest possible brightness</value>
        [DataMember(Name = "brightness", EmitDefaultValue = false)]
        public decimal Brightness { get; set; }

        /// <summary>
        /// Percentage of the maximum lumen the device outputs on minimum brightness
        /// </summary>
        /// <value>Percentage of the maximum lumen the device outputs on minimum brightness</value>
        [DataMember(Name = "min_dim_level", EmitDefaultValue = false)]
        public decimal MinDimLevel { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LightGetAllOfDimming {\n");
            sb.Append("  Brightness: ").Append(Brightness).Append("\n");
            sb.Append("  MinDimLevel: ").Append(MinDimLevel).Append("\n");
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
            // Brightness (decimal) maximum
            if (this.Brightness > (decimal)100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Brightness, must be a value less than or equal to 100.", new [] { "Brightness" });
            }

            // Brightness (decimal) minimum
            if (this.Brightness < (decimal)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Brightness, must be a value greater than or equal to 0.", new [] { "Brightness" });
            }

            // MinDimLevel (decimal) maximum
            if (this.MinDimLevel > (decimal)100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MinDimLevel, must be a value less than or equal to 100.", new [] { "MinDimLevel" });
            }

            // MinDimLevel (decimal) minimum
            if (this.MinDimLevel < (decimal)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MinDimLevel, must be a value greater than or equal to 0.", new [] { "MinDimLevel" });
            }

            yield break;
        }
    }

}
