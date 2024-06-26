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
    /// DevicePutIdentify
    /// </summary>
    [DataContract(Name = "DevicePut_identify")]
    public partial class DevicePutIdentify : IValidatableObject
    {
        /// <summary>
        /// Triggers a visual identification sequence, current implemented as (which can change in the future): Bridge performs Zigbee LED identification cycles for 5 seconds Lights perform one breathe cycle Sensors perform LED identification cycles for 15 seconds 
        /// </summary>
        /// <value>Triggers a visual identification sequence, current implemented as (which can change in the future): Bridge performs Zigbee LED identification cycles for 5 seconds Lights perform one breathe cycle Sensors perform LED identification cycles for 15 seconds </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ActionEnum
        {
            /// <summary>
            /// Enum Identify for value: identify
            /// </summary>
            [EnumMember(Value = "identify")]
            Identify = 1
        }


        /// <summary>
        /// Triggers a visual identification sequence, current implemented as (which can change in the future): Bridge performs Zigbee LED identification cycles for 5 seconds Lights perform one breathe cycle Sensors perform LED identification cycles for 15 seconds 
        /// </summary>
        /// <value>Triggers a visual identification sequence, current implemented as (which can change in the future): Bridge performs Zigbee LED identification cycles for 5 seconds Lights perform one breathe cycle Sensors perform LED identification cycles for 15 seconds </value>
        [DataMember(Name = "action", EmitDefaultValue = false)]
        public ActionEnum? Action { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DevicePutIdentify" /> class.
        /// </summary>
        /// <param name="action">Triggers a visual identification sequence, current implemented as (which can change in the future): Bridge performs Zigbee LED identification cycles for 5 seconds Lights perform one breathe cycle Sensors perform LED identification cycles for 15 seconds .</param>
        public DevicePutIdentify(ActionEnum? action = default(ActionEnum?))
        {
            this.Action = action;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DevicePutIdentify {\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
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
