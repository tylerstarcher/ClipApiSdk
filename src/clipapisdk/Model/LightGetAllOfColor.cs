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
    /// LightGetAllOfColor
    /// </summary>
    [DataContract(Name = "LightGet_allOf_color")]
    public partial class LightGetAllOfColor : IValidatableObject
    {
        /// <summary>
        /// The gammut types supported by hue – A Gamut of early Philips color-only products – B Limited gamut of first Hue color products – C Richer color gamut of Hue white and color ambiance products – other Color gamut of non-hue products with non-hue gamuts resp w/o gamut
        /// </summary>
        /// <value>The gammut types supported by hue – A Gamut of early Philips color-only products – B Limited gamut of first Hue color products – C Richer color gamut of Hue white and color ambiance products – other Color gamut of non-hue products with non-hue gamuts resp w/o gamut</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum GamutTypeEnum
        {
            /// <summary>
            /// Enum A for value: A
            /// </summary>
            [EnumMember(Value = "A")]
            A = 1,

            /// <summary>
            /// Enum B for value: B
            /// </summary>
            [EnumMember(Value = "B")]
            B = 2,

            /// <summary>
            /// Enum C for value: C
            /// </summary>
            [EnumMember(Value = "C")]
            C = 3,

            /// <summary>
            /// Enum Other for value: other
            /// </summary>
            [EnumMember(Value = "other")]
            Other = 4
        }


        /// <summary>
        /// The gammut types supported by hue – A Gamut of early Philips color-only products – B Limited gamut of first Hue color products – C Richer color gamut of Hue white and color ambiance products – other Color gamut of non-hue products with non-hue gamuts resp w/o gamut
        /// </summary>
        /// <value>The gammut types supported by hue – A Gamut of early Philips color-only products – B Limited gamut of first Hue color products – C Richer color gamut of Hue white and color ambiance products – other Color gamut of non-hue products with non-hue gamuts resp w/o gamut</value>
        [DataMember(Name = "gamut_type", EmitDefaultValue = false)]
        public GamutTypeEnum? GamutType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="LightGetAllOfColor" /> class.
        /// </summary>
        /// <param name="xy">xy.</param>
        /// <param name="gamut">gamut.</param>
        /// <param name="gamutType">The gammut types supported by hue – A Gamut of early Philips color-only products – B Limited gamut of first Hue color products – C Richer color gamut of Hue white and color ambiance products – other Color gamut of non-hue products with non-hue gamuts resp w/o gamut.</param>
        public LightGetAllOfColor(GamutPosition xy = default(GamutPosition), LightGetAllOfColorGamut gamut = default(LightGetAllOfColorGamut), GamutTypeEnum? gamutType = default(GamutTypeEnum?))
        {
            this.Xy = xy;
            this.Gamut = gamut;
            this.GamutType = gamutType;
        }

        /// <summary>
        /// Gets or Sets Xy
        /// </summary>
        [DataMember(Name = "xy", EmitDefaultValue = false)]
        public GamutPosition Xy { get; set; }

        /// <summary>
        /// Gets or Sets Gamut
        /// </summary>
        [DataMember(Name = "gamut", EmitDefaultValue = false)]
        public LightGetAllOfColorGamut Gamut { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LightGetAllOfColor {\n");
            sb.Append("  Xy: ").Append(Xy).Append("\n");
            sb.Append("  Gamut: ").Append(Gamut).Append("\n");
            sb.Append("  GamutType: ").Append(GamutType).Append("\n");
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