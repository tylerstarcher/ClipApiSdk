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
    ///  Class for testing BridgeApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class BridgeApiTests : IDisposable
    {
        private BridgeApi instance;

        public BridgeApiTests()
        {
            instance = new BridgeApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of BridgeApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' BridgeApi
            //Assert.IsType<BridgeApi>(instance);
        }

        /// <summary>
        /// Test GetBridge
        /// </summary>
        [Fact]
        public void GetBridgeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string bridgeId = null;
            //var response = instance.GetBridge(bridgeId);
            //Assert.IsType<GetBridges200Response>(response);
        }

        /// <summary>
        /// Test GetBridges
        /// </summary>
        [Fact]
        public void GetBridgesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetBridges();
            //Assert.IsType<GetBridges200Response>(response);
        }

        /// <summary>
        /// Test UpdateBridge
        /// </summary>
        [Fact]
        public void UpdateBridgeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string bridgeId = null;
            //BridgePut? bridgePut = null;
            //var response = instance.UpdateBridge(bridgeId, bridgePut);
            //Assert.IsType<UpdateDevice200Response>(response);
        }
    }
}