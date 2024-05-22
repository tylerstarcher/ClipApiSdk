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
    /// SceneMetadata
    /// </summary>
    [DataContract(Name = "SceneMetadata")]
    public partial class SceneMetadata : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SceneMetadata" /> class.
        /// </summary>
        /// <param name="name">Human readable name of a resource.</param>
        /// <param name="image">image.</param>
        /// <param name="appdata">Application specific data. Free format string..</param>
        public SceneMetadata(string name = default(string), ResourceIdentifier image = default(ResourceIdentifier), string appdata = default(string))
        {
            this.Name = name;
            this.Image = image;
            this.Appdata = appdata;
        }

        /// <summary>
        /// Human readable name of a resource
        /// </summary>
        /// <value>Human readable name of a resource</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Image
        /// </summary>
        [DataMember(Name = "image", EmitDefaultValue = false)]
        public ResourceIdentifier Image { get; set; }

        /// <summary>
        /// Application specific data. Free format string.
        /// </summary>
        /// <value>Application specific data. Free format string.</value>
        [DataMember(Name = "appdata", EmitDefaultValue = false)]
        public string Appdata { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SceneMetadata {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
            sb.Append("  Appdata: ").Append(Appdata).Append("\n");
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
            // Name (string) maxLength
            if (this.Name != null && this.Name.Length > 32)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 32.", new [] { "Name" });
            }

            // Name (string) minLength
            if (this.Name != null && this.Name.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 1.", new [] { "Name" });
            }

            // Appdata (string) maxLength
            if (this.Appdata != null && this.Appdata.Length > 16)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Appdata, length must be less than 16.", new [] { "Appdata" });
            }

            // Appdata (string) minLength
            if (this.Appdata != null && this.Appdata.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Appdata, length must be greater than 1.", new [] { "Appdata" });
            }

            yield break;
        }
    }

}