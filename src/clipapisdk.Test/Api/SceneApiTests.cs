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
    ///  Class for testing SceneApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class SceneApiTests : IDisposable
    {
        private SceneApi instance;

        public SceneApiTests()
        {
            instance = new SceneApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SceneApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' SceneApi
            //Assert.IsType<SceneApi>(instance);
        }

        /// <summary>
        /// Test CreateScene
        /// </summary>
        [Fact]
        public void CreateSceneTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ScenePost? scenePost = null;
            //var response = instance.CreateScene(scenePost);
            //Assert.IsType<UpdateDevice200Response>(response);
        }

        /// <summary>
        /// Test DeleteScene
        /// </summary>
        [Fact]
        public void DeleteSceneTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string sceneId = null;
            //var response = instance.DeleteScene(sceneId);
            //Assert.IsType<UpdateDevice200Response>(response);
        }

        /// <summary>
        /// Test GetScene
        /// </summary>
        [Fact]
        public void GetSceneTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string sceneId = null;
            //var response = instance.GetScene(sceneId);
            //Assert.IsType<GetScenes200Response>(response);
        }

        /// <summary>
        /// Test GetScenes
        /// </summary>
        [Fact]
        public void GetScenesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetScenes();
            //Assert.IsType<GetScenes200Response>(response);
        }

        /// <summary>
        /// Test UpdateScene
        /// </summary>
        [Fact]
        public void UpdateSceneTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string sceneId = null;
            //ScenePut? scenePut = null;
            //var response = instance.UpdateScene(sceneId, scenePut);
            //Assert.IsType<UpdateDevice200Response>(response);
        }
    }
}
