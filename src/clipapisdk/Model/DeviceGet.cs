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
    /// Definition of a device resource
    /// </summary>
    [DataContract(Name = "DeviceGet")]
    public partial class DeviceGet : IValidatableObject
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
        /// Initializes a new instance of the <see cref="DeviceGet" /> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="id">Unique identifier representing a specific resource instance.</param>
        /// <param name="idV1">Clip v1 resource identifier.</param>
        /// <param name="owner">owner.</param>
        /// <param name="productData">productData.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="usertest">usertest.</param>
        /// <param name="services">References all services providing control and state of the device..</param>
        public DeviceGet(TypeEnum? type = default(TypeEnum?), string id = default(string), string idV1 = default(string), ResourceIdentifier owner = default(ResourceIdentifier), ProductData productData = default(ProductData), DeviceGetAllOfMetadata metadata = default(DeviceGetAllOfMetadata), DeviceGetAllOfUsertest usertest = default(DeviceGetAllOfUsertest), List<ResourceIdentifier> services = default(List<ResourceIdentifier>))
        {
            this.Type = type;
            this.Id = id;
            this.IdV1 = idV1;
            this.Owner = owner;
            this.ProductData = productData;
            this.Metadata = metadata;
            this.Usertest = usertest;
            this.Services = services;
        }

        /// <summary>
        /// Unique identifier representing a specific resource instance
        /// </summary>
        /// <value>Unique identifier representing a specific resource instance</value>
        /// <example>3883f8bf-30a3-445b-ac06-b047d50599df</example>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Clip v1 resource identifier
        /// </summary>
        /// <value>Clip v1 resource identifier</value>
        /// <example>/lights/8</example>
        [DataMember(Name = "id_v1", EmitDefaultValue = false)]
        public string IdV1 { get; set; }

        /// <summary>
        /// Gets or Sets Owner
        /// </summary>
        [DataMember(Name = "owner", EmitDefaultValue = false)]
        public ResourceIdentifier Owner { get; set; }

        /// <summary>
        /// Gets or Sets ProductData
        /// </summary>
        [DataMember(Name = "product_data", EmitDefaultValue = false)]
        public ProductData ProductData { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public DeviceGetAllOfMetadata Metadata { get; set; }

        /// <summary>
        /// Gets or Sets Usertest
        /// </summary>
        [DataMember(Name = "usertest", EmitDefaultValue = false)]
        public DeviceGetAllOfUsertest Usertest { get; set; }

        /// <summary>
        /// References all services providing control and state of the device.
        /// </summary>
        /// <value>References all services providing control and state of the device.</value>
        [DataMember(Name = "services", EmitDefaultValue = false)]
        public List<ResourceIdentifier> Services { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DeviceGet {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdV1: ").Append(IdV1).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  ProductData: ").Append(ProductData).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Usertest: ").Append(Usertest).Append("\n");
            sb.Append("  Services: ").Append(Services).Append("\n");
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
            if (this.Id != null) {
                // Id (string) pattern
                Regex regexId = new Regex(@"^[0-9a-f]{8}-([0-9a-f]{4}-){3}[0-9a-f]{12}$", RegexOptions.CultureInvariant);
                if (!regexId.Match(this.Id).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Id, must match a pattern of " + regexId, new [] { "Id" });
                }
            }

            if (this.IdV1 != null) {
                // IdV1 (string) pattern
                Regex regexIdV1 = new Regex(@"^(\/[a-z]{4,32}\/[0-9a-zA-Z-]{1,32})?$", RegexOptions.CultureInvariant);
                if (!regexIdV1.Match(this.IdV1).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IdV1, must match a pattern of " + regexIdV1, new [] { "IdV1" });
                }
            }

            yield break;
        }
    }

}
