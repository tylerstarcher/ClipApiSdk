# clipapisdk.Api.LightLevelApi

All URIs are relative to *https://192.168.1.0*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetLightLevel**](LightLevelApi.md#getlightlevel) | **GET** /clip/v2/resource/light_level/{lightId} | Get light |
| [**GetLightLevels**](LightLevelApi.md#getlightlevels) | **GET** /clip/v2/resource/light_level | List light levels. |
| [**UpdateLightLevel**](LightLevelApi.md#updatelightlevel) | **PUT** /clip/v2/resource/light_level/{lightId} | Update light |

<a id="getlightlevel"></a>
# **GetLightLevel**
> GetLightLevels200Response GetLightLevel (string lightId)

Get light

Get details of a single light from its given `{lightId}`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using clipapisdk.Api;
using clipapisdk.Client;
using clipapisdk.Model;

namespace Example
{
    public class GetLightLevelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.1.0";
            // Configure API key authorization: HueApplicationKey
            config.AddApiKey("hue-application-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("hue-application-key", "Bearer");

            var apiInstance = new LightLevelApi(config);
            var lightId = "lightId_example";  // string | ID of the light

            try
            {
                // Get light
                GetLightLevels200Response result = apiInstance.GetLightLevel(lightId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LightLevelApi.GetLightLevel: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetLightLevelWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get light
    ApiResponse<GetLightLevels200Response> response = apiInstance.GetLightLevelWithHttpInfo(lightId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LightLevelApi.GetLightLevelWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **lightId** | **string** | ID of the light |  |

### Return type

[**GetLightLevels200Response**](GetLightLevels200Response.md)

### Authorization

[HueApplicationKey](../README.md#HueApplicationKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Light Level Success Response |  -  |
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

<a id="getlightlevels"></a>
# **GetLightLevels**
> GetLightLevels200Response GetLightLevels ()

List light levels.

List all available light levels.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using clipapisdk.Api;
using clipapisdk.Client;
using clipapisdk.Model;

namespace Example
{
    public class GetLightLevelsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.1.0";
            // Configure API key authorization: HueApplicationKey
            config.AddApiKey("hue-application-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("hue-application-key", "Bearer");

            var apiInstance = new LightLevelApi(config);

            try
            {
                // List light levels.
                GetLightLevels200Response result = apiInstance.GetLightLevels();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LightLevelApi.GetLightLevels: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetLightLevelsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List light levels.
    ApiResponse<GetLightLevels200Response> response = apiInstance.GetLightLevelsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LightLevelApi.GetLightLevelsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**GetLightLevels200Response**](GetLightLevels200Response.md)

### Authorization

[HueApplicationKey](../README.md#HueApplicationKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Light Level Success Response |  -  |
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

<a id="updatelightlevel"></a>
# **UpdateLightLevel**
> UpdateDevice200Response UpdateLightLevel (string lightId, LightLevelPut? lightLevelPut = null)

Update light

Update a single light from its given `{lightId}`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using clipapisdk.Api;
using clipapisdk.Client;
using clipapisdk.Model;

namespace Example
{
    public class UpdateLightLevelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.1.0";
            // Configure API key authorization: HueApplicationKey
            config.AddApiKey("hue-application-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("hue-application-key", "Bearer");

            var apiInstance = new LightLevelApi(config);
            var lightId = "lightId_example";  // string | ID of the light
            var lightLevelPut = new LightLevelPut?(); // LightLevelPut? |  (optional) 

            try
            {
                // Update light
                UpdateDevice200Response result = apiInstance.UpdateLightLevel(lightId, lightLevelPut);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LightLevelApi.UpdateLightLevel: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateLightLevelWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update light
    ApiResponse<UpdateDevice200Response> response = apiInstance.UpdateLightLevelWithHttpInfo(lightId, lightLevelPut);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LightLevelApi.UpdateLightLevelWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **lightId** | **string** | ID of the light |  |
| **lightLevelPut** | [**LightLevelPut?**](LightLevelPut?.md) |  | [optional]  |

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

