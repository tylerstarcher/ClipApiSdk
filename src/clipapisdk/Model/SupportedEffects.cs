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
    /// Defines SupportedEffects
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SupportedEffects
    {
        /// <summary>
        /// Enum Prism for value: prism
        /// </summary>
        [EnumMember(Value = "prism")]
        Prism = 1,

        /// <summary>
        /// Enum Opal for value: opal
        /// </summary>
        [EnumMember(Value = "opal")]
        Opal = 2,

        /// <summary>
        /// Enum Glisten for value: glisten
        /// </summary>
        [EnumMember(Value = "glisten")]
        Glisten = 3,

        /// <summary>
        /// Enum Sparkle for value: sparkle
        /// </summary>
        [EnumMember(Value = "sparkle")]
        Sparkle = 4,

        /// <summary>
        /// Enum Fire for value: fire
        /// </summary>
        [EnumMember(Value = "fire")]
        Fire = 5,

        /// <summary>
        /// Enum Candle for value: candle
        /// </summary>
        [EnumMember(Value = "candle")]
        Candle = 6,

        /// <summary>
        /// Enum NoEffect for value: no_effect
        /// </summary>
        [EnumMember(Value = "no_effect")]
        NoEffect = 7
    }

}
