# clipapisdk.Api.SceneApi

All URIs are relative to *https://192.168.1.0*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateScene**](SceneApi.md#createscene) | **POST** /clip/v2/resource/scene | Create a new scene |
| [**DeleteScene**](SceneApi.md#deletescene) | **DELETE** /clip/v2/resource/scene/{sceneId} | Delete a scene |
| [**GetScene**](SceneApi.md#getscene) | **GET** /clip/v2/resource/scene/{sceneId} | Get a scene |
| [**GetScenes**](SceneApi.md#getscenes) | **GET** /clip/v2/resource/scene | List scenes |
| [**UpdateScene**](SceneApi.md#updatescene) | **PUT** /clip/v2/resource/scene/{sceneId} | Update a scene |

<a id="createscene"></a>
# **CreateScene**
> UpdateDevice200Response CreateScene (ScenePost? scenePost = null)

Create a new scene

Creates a new scene

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using clipapisdk.Api;
using clipapisdk.Client;
using clipapisdk.Model;

namespace Example
{
    public class CreateSceneExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.1.0";
            // Configure API key authorization: HueApplicationKey
            config.AddApiKey("hue-application-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("hue-application-key", "Bearer");

            var apiInstance = new SceneApi(config);
            var scenePost = new ScenePost?(); // ScenePost? |  (optional) 

            try
            {
                // Create a new scene
                UpdateDevice200Response result = apiInstance.CreateScene(scenePost);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SceneApi.CreateScene: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateSceneWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new scene
    ApiResponse<UpdateDevice200Response> response = apiInstance.CreateSceneWithHttpInfo(scenePost);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SceneApi.CreateSceneWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scenePost** | [**ScenePost?**](ScenePost?.md) |  | [optional]  |

### Return type

[**UpdateDevice200Response**](UpdateDevice200Response.md)

### Authorization

[HueApplicationKey](../README.md#HueApplicationKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **405** | Method Not Allowed |  -  |
| **406** | Not Acceptable |  -  |
| **409** | Conflict |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Service Unavailable |  -  |
| **507** | Insufficient Storage |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletescene"></a>
# **DeleteScene**
> UpdateDevice200Response DeleteScene (string sceneId)

Delete a scene

Delete a single scene from its given `{sceneId}`

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using clipapisdk.Api;
using clipapisdk.Client;
using clipapisdk.Model;

namespace Example
{
    public class DeleteSceneExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.1.0";
            // Configure API key authorization: HueApplicationKey
            config.AddApiKey("hue-application-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("hue-application-key", "Bearer");

            var apiInstance = new SceneApi(config);
            var sceneId = "sceneId_example";  // string | ID of the scene.

            try
            {
                // Delete a scene
                UpdateDevice200Response result = apiInstance.DeleteScene(sceneId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SceneApi.DeleteScene: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteSceneWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a scene
    ApiResponse<UpdateDevice200Response> response = apiInstance.DeleteSceneWithHttpInfo(sceneId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SceneApi.DeleteSceneWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sceneId** | **string** | ID of the scene. |  |

### Return type

[**UpdateDevice200Response**](UpdateDevice200Response.md)

### Authorization

[HueApplicationKey](../README.md#HueApplicationKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **405** | Method Not Allowed |  -  |
| **406** | Not Acceptable |  -  |
| **409** | Conflict |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Service Unavailable |  -  |
| **507** | Insufficient Storage |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getscene"></a>
# **GetScene**
> GetScenes200Response GetScene (string sceneId)

Get a scene

Get details of a single scene from its given `{sceneId}`

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using clipapisdk.Api;
using clipapisdk.Client;
using clipapisdk.Model;

namespace Example
{
    public class GetSceneExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.1.0";
            // Configure API key authorization: HueApplicationKey
            config.AddApiKey("hue-application-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("hue-application-key", "Bearer");

            var apiInstance = new SceneApi(config);
            var sceneId = "sceneId_example";  // string | ID of the scene.

            try
            {
                // Get a scene
                GetScenes200Response result = apiInstance.GetScene(sceneId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SceneApi.GetScene: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSceneWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a scene
    ApiResponse<GetScenes200Response> response = apiInstance.GetSceneWithHttpInfo(sceneId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SceneApi.GetSceneWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sceneId** | **string** | ID of the scene. |  |

### Return type

[**GetScenes200Response**](GetScenes200Response.md)

### Authorization

[HueApplicationKey](../README.md#HueApplicationKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Scene Success Response |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **405** | Method Not Allowed |  -  |
| **406** | Not Acceptable |  -  |
| **409** | Conflict |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Service Unavailable |  -  |
| **507** | Insufficient Storage |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getscenes"></a>
# **GetScenes**
> GetScenes200Response GetScenes ()

List scenes

List all available scenes

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using clipapisdk.Api;
using clipapisdk.Client;
using clipapisdk.Model;

namespace Example
{
    public class GetScenesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.1.0";
            // Configure API key authorization: HueApplicationKey
            config.AddApiKey("hue-application-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("hue-application-key", "Bearer");

            var apiInstance = new SceneApi(config);

            try
            {
                // List scenes
                GetScenes200Response result = apiInstance.GetScenes();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SceneApi.GetScenes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetScenesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List scenes
    ApiResponse<GetScenes200Response> response = apiInstance.GetScenesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SceneApi.GetScenesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**GetScenes200Response**](GetScenes200Response.md)

### Authorization

[HueApplicationKey](../README.md#HueApplicationKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Scene Success Response |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **405** | Method Not Allowed |  -  |
| **406** | Not Acceptable |  -  |
| **409** | Conflict |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Service Unavailable |  -  |
| **507** | Insufficient Storage |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatescene"></a>
# **UpdateScene**
> UpdateDevice200Response UpdateScene (string sceneId, ScenePut? scenePut = null)

Update a scene

Update a single scene from its given `{sceneId}`

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using clipapisdk.Api;
using clipapisdk.Client;
using clipapisdk.Model;

namespace Example
{
    public class UpdateSceneExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.1.0";
            // Configure API key authorization: HueApplicationKey
            config.AddApiKey("hue-application-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("hue-application-key", "Bearer");

            var apiInstance = new SceneApi(config);
            var sceneId = "sceneId_example";  // string | ID of the scene.
            var scenePut = new ScenePut?(); // ScenePut? |  (optional) 

            try
            {
                // Update a scene
                UpdateDevice200Response result = apiInstance.UpdateScene(sceneId, scenePut);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SceneApi.UpdateScene: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateSceneWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a scene
    ApiResponse<UpdateDevice200Response> response = apiInstance.UpdateSceneWithHttpInfo(sceneId, scenePut);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SceneApi.UpdateSceneWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sceneId** | **string** | ID of the scene. |  |
| **scenePut** | [**ScenePut?**](ScenePut?.md) |  | [optional]  |

### Return type

[**UpdateDevice200Response**](UpdateDevice200Response.md)

### Authorization

[HueApplicationKey](../README.md#HueApplicationKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **405** | Method Not Allowed |  -  |
| **406** | Not Acceptable |  -  |
| **409** | Conflict |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Server Error |  -  |
| **503** | Service Unavailable |  -  |
| **507** | Insufficient Storage |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

