# clipapisdk.Api.MotionApi

All URIs are relative to *https://192.168.1.0*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetMotionSensor**](MotionApi.md#getmotionsensor) | **GET** /clip/v2/resource/motion/{motionId} | Get motion sensor. |
| [**GetMotionSensors**](MotionApi.md#getmotionsensors) | **GET** /clip/v2/resource/motion | List motion sensors. |
| [**UpdateMotionSensor**](MotionApi.md#updatemotionsensor) | **PUT** /clip/v2/resource/motion/{motionId} | Update Motion Sensor |

<a id="getmotionsensor"></a>
# **GetMotionSensor**
> GetMotionSensors200Response GetMotionSensor (string motionId)

Get motion sensor.

Get details of a single motion sensor from its given `{motionId}`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using clipapisdk.Api;
using clipapisdk.Client;
using clipapisdk.Model;

namespace Example
{
    public class GetMotionSensorExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.1.0";
            // Configure API key authorization: HueApplicationKey
            config.AddApiKey("hue-application-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("hue-application-key", "Bearer");

            var apiInstance = new MotionApi(config);
            var motionId = "motionId_example";  // string | ID of the motion sensor

            try
            {
                // Get motion sensor.
                GetMotionSensors200Response result = apiInstance.GetMotionSensor(motionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MotionApi.GetMotionSensor: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMotionSensorWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get motion sensor.
    ApiResponse<GetMotionSensors200Response> response = apiInstance.GetMotionSensorWithHttpInfo(motionId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MotionApi.GetMotionSensorWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **motionId** | **string** | ID of the motion sensor |  |

### Return type

[**GetMotionSensors200Response**](GetMotionSensors200Response.md)

### Authorization

[HueApplicationKey](../README.md#HueApplicationKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Motion Success Response |  -  |
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

<a id="getmotionsensors"></a>
# **GetMotionSensors**
> GetMotionSensors200Response GetMotionSensors ()

List motion sensors.

List all available motion sensors.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using clipapisdk.Api;
using clipapisdk.Client;
using clipapisdk.Model;

namespace Example
{
    public class GetMotionSensorsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.1.0";
            // Configure API key authorization: HueApplicationKey
            config.AddApiKey("hue-application-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("hue-application-key", "Bearer");

            var apiInstance = new MotionApi(config);

            try
            {
                // List motion sensors.
                GetMotionSensors200Response result = apiInstance.GetMotionSensors();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MotionApi.GetMotionSensors: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMotionSensorsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List motion sensors.
    ApiResponse<GetMotionSensors200Response> response = apiInstance.GetMotionSensorsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MotionApi.GetMotionSensorsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**GetMotionSensors200Response**](GetMotionSensors200Response.md)

### Authorization

[HueApplicationKey](../README.md#HueApplicationKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Motion Success Response |  -  |
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

<a id="updatemotionsensor"></a>
# **UpdateMotionSensor**
> UpdateDevice200Response UpdateMotionSensor (string motionId, MotionPut? motionPut = null)

Update Motion Sensor

Update a single motion sensor from its given `{motionId}`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using clipapisdk.Api;
using clipapisdk.Client;
using clipapisdk.Model;

namespace Example
{
    public class UpdateMotionSensorExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.1.0";
            // Configure API key authorization: HueApplicationKey
            config.AddApiKey("hue-application-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("hue-application-key", "Bearer");

            var apiInstance = new MotionApi(config);
            var motionId = "motionId_example";  // string | Id of the motion sensor
            var motionPut = new MotionPut?(); // MotionPut? |  (optional) 

            try
            {
                // Update Motion Sensor
                UpdateDevice200Response result = apiInstance.UpdateMotionSensor(motionId, motionPut);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MotionApi.UpdateMotionSensor: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateMotionSensorWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Motion Sensor
    ApiResponse<UpdateDevice200Response> response = apiInstance.UpdateMotionSensorWithHttpInfo(motionId, motionPut);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MotionApi.UpdateMotionSensorWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **motionId** | **string** | Id of the motion sensor |  |
| **motionPut** | [**MotionPut?**](MotionPut?.md) |  | [optional]  |

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

