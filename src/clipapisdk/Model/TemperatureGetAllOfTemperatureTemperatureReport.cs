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
    /// TemperatureGetAllOfTemperatureTemperatureReport
    /// </summary>
    [DataContract(Name = "TemperatureGet_allOf_temperature_temperature_report")]
    public partial class TemperatureGetAllOfTemperatureTemperatureReport : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TemperatureGetAllOfTemperatureTemperatureReport" /> class.
        /// </summary>
        /// <param name="changed">last time the value of this property is changed..</param>
        /// <param name="temperature">Temperature in 1.00 degrees Celsius.</param>
        public TemperatureGetAllOfTemperatureTemperatureReport(DateTime changed = default(DateTime), decimal temperature = default(decimal))
        {
            this.Changed = changed;
            this.Temperature = temperature;
        }

        /// <summary>
        /// last time the value of this property is changed.
        /// </summary>
        /// <value>last time the value of this property is changed.</value>
        [DataMember(Name = "changed", EmitDefaultValue = false)]
        public DateTime Changed { get; set; }

        /// <summary>
        /// Temperature in 1.00 degrees Celsius
        /// </summary>
        /// <value>Temperature in 1.00 degrees Celsius</value>
        /// <example>23</example>
        [DataMember(Name = "temperature", EmitDefaultValue = false)]
        public decimal Temperature { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TemperatureGetAllOfTemperatureTemperatureReport {\n");
            sb.Append("  Changed: ").Append(Changed).Append("\n");
            sb.Append("  Temperature: ").Append(Temperature).Append("\n");
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