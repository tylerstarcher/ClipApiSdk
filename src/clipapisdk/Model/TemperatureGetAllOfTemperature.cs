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
    /// TemperatureGetAllOfTemperature
    /// </summary>
    [DataContract(Name = "TemperatureGet_allOf_temperature")]
    public partial class TemperatureGetAllOfTemperature : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TemperatureGetAllOfTemperature" /> class.
        /// </summary>
        /// <param name="temperature">Deprecated. Moved to Temperature_report/temperature.</param>
        /// <param name="temperatureValid">Deprecated. Indication whether the value presented in temperature is valid.</param>
        /// <param name="temperatureReport">temperatureReport.</param>
        public TemperatureGetAllOfTemperature(decimal temperature = default(decimal), bool temperatureValid = default(bool), TemperatureGetAllOfTemperatureTemperatureReport temperatureReport = default(TemperatureGetAllOfTemperatureTemperatureReport))
        {
            this.Temperature = temperature;
            this.TemperatureValid = temperatureValid;
            this.TemperatureReport = temperatureReport;
        }

        /// <summary>
        /// Deprecated. Moved to Temperature_report/temperature
        /// </summary>
        /// <value>Deprecated. Moved to Temperature_report/temperature</value>
        /// <example>23</example>
        [DataMember(Name = "temperature", EmitDefaultValue = false)]
        public decimal Temperature { get; set; }

        /// <summary>
        /// Deprecated. Indication whether the value presented in temperature is valid
        /// </summary>
        /// <value>Deprecated. Indication whether the value presented in temperature is valid</value>
        [DataMember(Name = "temperature_valid", EmitDefaultValue = true)]
        public bool TemperatureValid { get; set; }

        /// <summary>
        /// Gets or Sets TemperatureReport
        /// </summary>
        [DataMember(Name = "temperature_report", EmitDefaultValue = false)]
        public TemperatureGetAllOfTemperatureTemperatureReport TemperatureReport { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TemperatureGetAllOfTemperature {\n");
            sb.Append("  Temperature: ").Append(Temperature).Append("\n");
            sb.Append("  TemperatureValid: ").Append(TemperatureValid).Append("\n");
            sb.Append("  TemperatureReport: ").Append(TemperatureReport).Append("\n");
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
