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
    /// Light archetype
    /// </summary>
    /// <value>Light archetype</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LightArchetype
    {
        /// <summary>
        /// Enum UnknownArchetype for value: unknown_archetype
        /// </summary>
        [EnumMember(Value = "unknown_archetype")]
        UnknownArchetype = 1,

        /// <summary>
        /// Enum ClassicBulb for value: classic_bulb
        /// </summary>
        [EnumMember(Value = "classic_bulb")]
        ClassicBulb = 2,

        /// <summary>
        /// Enum SultanBulb for value: sultan_bulb
        /// </summary>
        [EnumMember(Value = "sultan_bulb")]
        SultanBulb = 3,

        /// <summary>
        /// Enum FloodBulb for value: flood_bulb
        /// </summary>
        [EnumMember(Value = "flood_bulb")]
        FloodBulb = 4,

        /// <summary>
        /// Enum SpotBulb for value: spot_bulb
        /// </summary>
        [EnumMember(Value = "spot_bulb")]
        SpotBulb = 5,

        /// <summary>
        /// Enum CandleBulb for value: candle_bulb
        /// </summary>
        [EnumMember(Value = "candle_bulb")]
        CandleBulb = 6,

        /// <summary>
        /// Enum LusterBulb for value: luster_bulb
        /// </summary>
        [EnumMember(Value = "luster_bulb")]
        LusterBulb = 7,

        /// <summary>
        /// Enum PendantRound for value: pendant_round
        /// </summary>
        [EnumMember(Value = "pendant_round")]
        PendantRound = 8,

        /// <summary>
        /// Enum PendantLong for value: pendant_long
        /// </summary>
        [EnumMember(Value = "pendant_long")]
        PendantLong = 9,

        /// <summary>
        /// Enum CeilingRound for value: ceiling_round
        /// </summary>
        [EnumMember(Value = "ceiling_round")]
        CeilingRound = 10,

        /// <summary>
        /// Enum CeilingSquare for value: ceiling_square
        /// </summary>
        [EnumMember(Value = "ceiling_square")]
        CeilingSquare = 11,

        /// <summary>
        /// Enum FloorShade for value: floor_shade
        /// </summary>
        [EnumMember(Value = "floor_shade")]
        FloorShade = 12,

        /// <summary>
        /// Enum FloorLantern for value: floor_lantern
        /// </summary>
        [EnumMember(Value = "floor_lantern")]
        FloorLantern = 13,

        /// <summary>
        /// Enum TableShade for value: table_shade
        /// </summary>
        [EnumMember(Value = "table_shade")]
        TableShade = 14,

        /// <summary>
        /// Enum RecessedCeiling for value: recessed_ceiling
        /// </summary>
        [EnumMember(Value = "recessed_ceiling")]
        RecessedCeiling = 15,

        /// <summary>
        /// Enum RecessedFloor for value: recessed_floor
        /// </summary>
        [EnumMember(Value = "recessed_floor")]
        RecessedFloor = 16,

        /// <summary>
        /// Enum SingleSpot for value: single_spot
        /// </summary>
        [EnumMember(Value = "single_spot")]
        SingleSpot = 17,

        /// <summary>
        /// Enum DoubleSpot for value: double_spot
        /// </summary>
        [EnumMember(Value = "double_spot")]
        DoubleSpot = 18,

        /// <summary>
        /// Enum TableWash for value: table_wash
        /// </summary>
        [EnumMember(Value = "table_wash")]
        TableWash = 19,

        /// <summary>
        /// Enum WallLantern for value: wall_lantern
        /// </summary>
        [EnumMember(Value = "wall_lantern")]
        WallLantern = 20,

        /// <summary>
        /// Enum WallShade for value: wall_shade
        /// </summary>
        [EnumMember(Value = "wall_shade")]
        WallShade = 21,

        /// <summary>
        /// Enum FlexibleLamp for value: flexible_lamp
        /// </summary>
        [EnumMember(Value = "flexible_lamp")]
        FlexibleLamp = 22,

        /// <summary>
        /// Enum GroundSpot for value: ground_spot
        /// </summary>
        [EnumMember(Value = "ground_spot")]
        GroundSpot = 23,

        /// <summary>
        /// Enum WallSpot for value: wall_spot
        /// </summary>
        [EnumMember(Value = "wall_spot")]
        WallSpot = 24,

        /// <summary>
        /// Enum Plug for value: plug
        /// </summary>
        [EnumMember(Value = "plug")]
        Plug = 25,

        /// <summary>
        /// Enum HueGo for value: hue_go
        /// </summary>
        [EnumMember(Value = "hue_go")]
        HueGo = 26,

        /// <summary>
        /// Enum HueLightstrip for value: hue_lightstrip
        /// </summary>
        [EnumMember(Value = "hue_lightstrip")]
        HueLightstrip = 27,

        /// <summary>
        /// Enum HueIris for value: hue_iris
        /// </summary>
        [EnumMember(Value = "hue_iris")]
        HueIris = 28,

        /// <summary>
        /// Enum HueBloom for value: hue_bloom
        /// </summary>
        [EnumMember(Value = "hue_bloom")]
        HueBloom = 29,

        /// <summary>
        /// Enum Bollard for value: bollard
        /// </summary>
        [EnumMember(Value = "bollard")]
        Bollard = 30,

        /// <summary>
        /// Enum WallWasher for value: wall_washer
        /// </summary>
        [EnumMember(Value = "wall_washer")]
        WallWasher = 31,

        /// <summary>
        /// Enum HuePlay for value: hue_play
        /// </summary>
        [EnumMember(Value = "hue_play")]
        HuePlay = 32,

        /// <summary>
        /// Enum VintageBulb for value: vintage_bulb
        /// </summary>
        [EnumMember(Value = "vintage_bulb")]
        VintageBulb = 33,

        /// <summary>
        /// Enum VintageCandleBulb for value: vintage_candle_bulb
        /// </summary>
        [EnumMember(Value = "vintage_candle_bulb")]
        VintageCandleBulb = 34,

        /// <summary>
        /// Enum EllipseBulb for value: ellipse_bulb
        /// </summary>
        [EnumMember(Value = "ellipse_bulb")]
        EllipseBulb = 35,

        /// <summary>
        /// Enum TriangleBulb for value: triangle_bulb
        /// </summary>
        [EnumMember(Value = "triangle_bulb")]
        TriangleBulb = 36,

        /// <summary>
        /// Enum SmallGlobeBulb for value: small_globe_bulb
        /// </summary>
        [EnumMember(Value = "small_globe_bulb")]
        SmallGlobeBulb = 37,

        /// <summary>
        /// Enum LargeGlobeBulb for value: large_globe_bulb
        /// </summary>
        [EnumMember(Value = "large_globe_bulb")]
        LargeGlobeBulb = 38,

        /// <summary>
        /// Enum EdisonBulb for value: edison_bulb
        /// </summary>
        [EnumMember(Value = "edison_bulb")]
        EdisonBulb = 39,

        /// <summary>
        /// Enum ChristmasTree for value: christmas_tree
        /// </summary>
        [EnumMember(Value = "christmas_tree")]
        ChristmasTree = 40,

        /// <summary>
        /// Enum StringLight for value: string_light
        /// </summary>
        [EnumMember(Value = "string_light")]
        StringLight = 41,

        /// <summary>
        /// Enum HueCentris for value: hue_centris
        /// </summary>
        [EnumMember(Value = "hue_centris")]
        HueCentris = 42,

        /// <summary>
        /// Enum HueLightstripTv for value: hue_lightstrip_tv
        /// </summary>
        [EnumMember(Value = "hue_lightstrip_tv")]
        HueLightstripTv = 43,

        /// <summary>
        /// Enum HueLightstripPc for value: hue_lightstrip_pc
        /// </summary>
        [EnumMember(Value = "hue_lightstrip_pc")]
        HueLightstripPc = 44,

        /// <summary>
        /// Enum HueTube for value: hue_tube
        /// </summary>
        [EnumMember(Value = "hue_tube")]
        HueTube = 45,

        /// <summary>
        /// Enum HueSigne for value: hue_signe
        /// </summary>
        [EnumMember(Value = "hue_signe")]
        HueSigne = 46,

        /// <summary>
        /// Enum PendantSpot for value: pendant_spot
        /// </summary>
        [EnumMember(Value = "pendant_spot")]
        PendantSpot = 47,

        /// <summary>
        /// Enum CeilingHorizontal for value: ceiling_horizontal
        /// </summary>
        [EnumMember(Value = "ceiling_horizontal")]
        CeilingHorizontal = 48,

        /// <summary>
        /// Enum CeilingTube for value: ceiling_tube
        /// </summary>
        [EnumMember(Value = "ceiling_tube")]
        CeilingTube = 49
    }

}
