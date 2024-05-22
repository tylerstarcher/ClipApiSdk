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
    /// DeviceGetAllOfUsertest
    /// </summary>
    [DataContract(Name = "DeviceGet_allOf_usertest")]
    public partial class DeviceGetAllOfUsertest : IValidatableObject
    {
        /// <summary>
        /// Defines Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Set for value: set
            /// </summary>
            [EnumMember(Value = "set")]
            Set = 1,

            /// <summary>
            /// Enum Changing for value: changing
            /// </summary>
            [EnumMember(Value = "changing")]
            Changing = 2
        }


        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceGetAllOfUsertest" /> class.
        /// </summary>
        /// <param name="status">status.</param>
        /// <param name="usertest">Activates or extends user usertest mode of device for 120 seconds. &#x60;false&#x60; deactivates usertest mode. In usertest mode, devices report changes in state faster and indicate state changes on device LED (if applicable) .</param>
        public DeviceGetAllOfUsertest(StatusEnum? status = default(StatusEnum?), bool usertest = default(bool))
        {
            this.Status = status;
            this.Usertest = usertest;
        }

        /// <summary>
        /// Activates or extends user usertest mode of device for 120 seconds. &#x60;false&#x60; deactivates usertest mode. In usertest mode, devices report changes in state faster and indicate state changes on device LED (if applicable) 
        /// </summary>
        /// <value>Activates or extends user usertest mode of device for 120 seconds. &#x60;false&#x60; deactivates usertest mode. In usertest mode, devices report changes in state faster and indicate state changes on device LED (if applicable) </value>
        [DataMember(Name = "usertest", EmitDefaultValue = true)]
        public bool Usertest { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DeviceGetAllOfUsertest {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Usertest: ").Append(Usertest).Append("\n");
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