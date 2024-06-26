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
    /// MotionPutSensitivity
    /// </summary>
    [DataContract(Name = "MotionPut_sensitivity")]
    public partial class MotionPutSensitivity : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MotionPutSensitivity" /> class.
        /// </summary>
        /// <param name="sensitivity">Sensitivity of the sensor. Value in the range 0 to sensitivity_max..</param>
        public MotionPutSensitivity(int sensitivity = default(int))
        {
            this.Sensitivity = sensitivity;
        }

        /// <summary>
        /// Sensitivity of the sensor. Value in the range 0 to sensitivity_max.
        /// </summary>
        /// <value>Sensitivity of the sensor. Value in the range 0 to sensitivity_max.</value>
        [DataMember(Name = "sensitivity", EmitDefaultValue = false)]
        public int Sensitivity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MotionPutSensitivity {\n");
            sb.Append("  Sensitivity: ").Append(Sensitivity).Append("\n");
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
