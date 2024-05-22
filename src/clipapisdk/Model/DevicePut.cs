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
    /// DevicePut
    /// </summary>
    [DataContract(Name = "DevicePut")]
    public partial class DevicePut : IValidatableObject
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Device for value: device
            /// </summary>
            [EnumMember(Value = "device")]
            Device = 1
        }


        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DevicePut" /> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="identify">identify.</param>
        /// <param name="usertest">usertest.</param>
        public DevicePut(TypeEnum? type = default(TypeEnum?), DeviceGetAllOfMetadata metadata = default(DeviceGetAllOfMetadata), DevicePutIdentify identify = default(DevicePutIdentify), DevicePutUsertest usertest = default(DevicePutUsertest))
        {
            this.Type = type;
            this.Metadata = metadata;
            this.Identify = identify;
            this.Usertest = usertest;
        }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public DeviceGetAllOfMetadata Metadata { get; set; }

        /// <summary>
        /// Gets or Sets Identify
        /// </summary>
        [DataMember(Name = "identify", EmitDefaultValue = false)]
        public DevicePutIdentify Identify { get; set; }

        /// <summary>
        /// Gets or Sets Usertest
        /// </summary>
        [DataMember(Name = "usertest", EmitDefaultValue = false)]
        public DevicePutUsertest Usertest { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DevicePut {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Identify: ").Append(Identify).Append("\n");
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