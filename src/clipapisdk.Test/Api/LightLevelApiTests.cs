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
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using clipapisdk.Client;
using clipapisdk.Api;
// uncomment below to import models
//using clipapisdk.Model;

namespace clipapisdk.Test.Api
{
    /// <summary>
    ///  Class for testing LightLevelApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class LightLevelApiTests : IDisposable
    {
        private LightLevelApi instance;

        public LightLevelApiTests()
        {
            instance = new LightLevelApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of LightLevelApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' LightLevelApi
            //Assert.IsType<LightLevelApi>(instance);
        }

        /// <summary>
        /// Test GetLightLevel
        /// </summary>
        [Fact]
        public void GetLightLevelTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string lightId = null;
            //var response = instance.GetLightLevel(lightId);
            //Assert.IsType<GetLightLevels200Response>(response);
        }

        /// <summary>
        /// Test GetLightLevels
        /// </summary>
        [Fact]
        public void GetLightLevelsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetLightLevels();
            //Assert.IsType<GetLightLevels200Response>(response);
        }

        /// <summary>
        /// Test UpdateLightLevel
        /// </summary>
        [Fact]
        public void UpdateLightLevelTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string lightId = null;
            //LightLevelPut? lightLevelPut = null;
            //var response = instance.UpdateLightLevel(lightId, lightLevelPut);
            //Assert.IsType<UpdateDevice200Response>(response);
        }
    }
}
