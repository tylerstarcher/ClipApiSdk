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
    ///  Class for testing AuthApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AuthApiTests : IDisposable
    {
        private AuthApi instance;

        public AuthApiTests()
        {
            instance = new AuthApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AuthApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' AuthApi
            //Assert.IsType<AuthApi>(instance);
        }

        /// <summary>
        /// Test Authenticate
        /// </summary>
        [Fact]
        public void AuthenticateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AuthenticateRequest? authenticateRequest = null;
            //var response = instance.Authenticate(authenticateRequest);
            //Assert.IsType<List<ResponseInner>>(response);
        }
    }
}
