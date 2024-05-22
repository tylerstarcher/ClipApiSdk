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
    /// LightLevelGetAllOfLight
    /// </summary>
    [DataContract(Name = "LightLevelGet_allOf_light")]
    public partial class LightLevelGetAllOfLight : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LightLevelGetAllOfLight" /> class.
        /// </summary>
        /// <param name="lightLevel">Deprecated. Moved to light_level_report/light_level.</param>
        /// <param name="lightLevelValid">Deprecated. Indication whether the value presented in light_level is valid.</param>
        /// <param name="lightLevelReport">lightLevelReport.</param>
        public LightLevelGetAllOfLight(int lightLevel = default(int), bool lightLevelValid = default(bool), LightLevelGetAllOfLightLightLevelReport lightLevelReport = default(LightLevelGetAllOfLightLightLevelReport))
        {
            this.LightLevel = lightLevel;
            this.LightLevelValid = lightLevelValid;
            this.LightLevelReport = lightLevelReport;
        }

        /// <summary>
        /// Deprecated. Moved to light_level_report/light_level
        /// </summary>
        /// <value>Deprecated. Moved to light_level_report/light_level</value>
        [DataMember(Name = "light_level", EmitDefaultValue = false)]
        public int LightLevel { get; set; }

        /// <summary>
        /// Deprecated. Indication whether the value presented in light_level is valid
        /// </summary>
        /// <value>Deprecated. Indication whether the value presented in light_level is valid</value>
        [DataMember(Name = "light_level_valid", EmitDefaultValue = true)]
        public bool LightLevelValid { get; set; }

        /// <summary>
        /// Gets or Sets LightLevelReport
        /// </summary>
        [DataMember(Name = "light_level_report", EmitDefaultValue = false)]
        public LightLevelGetAllOfLightLightLevelReport LightLevelReport { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LightLevelGetAllOfLight {\n");
            sb.Append("  LightLevel: ").Append(LightLevel).Append("\n");
            sb.Append("  LightLevelValid: ").Append(LightLevelValid).Append("\n");
            sb.Append("  LightLevelReport: ").Append(LightLevelReport).Append("\n");
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
