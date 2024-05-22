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
    ///  Class for testing BridgeHomeApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class BridgeHomeApiTests : IDisposable
    {
        private BridgeHomeApi instance;

        public BridgeHomeApiTests()
        {
            instance = new BridgeHomeApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of BridgeHomeApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' BridgeHomeApi
            //Assert.IsType<BridgeHomeApi>(instance);
        }

        /// <summary>
        /// Test GetBridgeHome
        /// </summary>
        [Fact]
        public void GetBridgeHomeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string bridgeHomeId = null;
            //var response = instance.GetBridgeHome(bridgeHomeId);
            //Assert.IsType<GetBridgeHomes200Response>(response);
        }

        /// <summary>
        /// Test GetBridgeHomes
        /// </summary>
        [Fact]
        public void GetBridgeHomesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetBridgeHomes();
            //Assert.IsType<GetBridgeHomes200Response>(response);
        }
    }
}