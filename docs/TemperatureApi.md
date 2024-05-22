# clipapisdk.Api.TemperatureApi

All URIs are relative to *https://192.168.1.0*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetTemperature**](TemperatureApi.md#gettemperature) | **GET** /clip/v2/resource/temperature/{temperatureId} | Get temperature sensor information |
| [**GetTemperatures**](TemperatureApi.md#gettemperatures) | **GET** /clip/v2/resource/temperature | List temperatures |
| [**UpdateTemperature**](TemperatureApi.md#updatetemperature) | **PUT** /clip/v2/resource/temperature/{temperatureId} | Update temperature sensor |

<a id="gettemperature"></a>
# **GetTemperature**
> GetTemperatures200Response GetTemperature (string temperatureId)

Get temperature sensor information

Get details of a single temperature sensor from its given `{temperatureId}`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using clipapisdk.Api;
using clipapisdk.Client;
using clipapisdk.Model;

namespace Example
{
    public class GetTemperatureExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.1.0";
            // Configure API key authorization: HueApplicationKey
            config.AddApiKey("hue-application-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("hue-application-key", "Bearer");

            var apiInstance = new TemperatureApi(config);
            var temperatureId = "temperatureId_example";  // string | ID of the temperature sensor

            try
            {
                // Get temperature sensor information
                GetTemperatures200Response result = apiInstance.GetTemperature(temperatureId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TemperatureApi.GetTemperature: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTemperatureWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get temperature sensor information
    ApiResponse<GetTemperatures200Response> response = apiInstance.GetTemperatureWithHttpInfo(temperatureId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TemperatureApi.GetTemperatureWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **temperatureId** | **string** | ID of the temperature sensor |  |

### Return type

[**GetTemperatures200Response**](GetTemperatures200Response.md)

### Authorization

[HueApplicationKey](../README.md#HueApplicationKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Temperature Success Response |  -  |
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

<a id="gettemperatures"></a>
# **GetTemperatures**
> GetTemperatures200Response GetTemperatures ()

List temperatures

List all temperatures

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using clipapisdk.Api;
using clipapisdk.Client;
using clipapisdk.Model;

namespace Example
{
    public class GetTemperaturesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.1.0";
            // Configure API key authorization: HueApplicationKey
            config.AddApiKey("hue-application-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("hue-application-key", "Bearer");

            var apiInstance = new TemperatureApi(config);

            try
            {
                // List temperatures
                GetTemperatures200Response result = apiInstance.GetTemperatures();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TemperatureApi.GetTemperatures: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTemperaturesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List temperatures
    ApiResponse<GetTemperatures200Response> response = apiInstance.GetTemperaturesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TemperatureApi.GetTemperaturesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**GetTemperatures200Response**](GetTemperatures200Response.md)

### Authorization

[HueApplicationKey](../README.md#HueApplicationKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Temperature Success Response |  -  |
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

<a id="updatetemperature"></a>
# **UpdateTemperature**
> UpdateDevice200Response UpdateTemperature (string temperatureId, TemperaturePut? temperaturePut = null)

Update temperature sensor

Update a temperature sensor from its given `{temperatureId}`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using clipapisdk.Api;
using clipapisdk.Client;
using clipapisdk.Model;

namespace Example
{
    public class UpdateTemperatureExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.1.0";
            // Configure API key authorization: HueApplicationKey
            config.AddApiKey("hue-application-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("hue-application-key", "Bearer");

            var apiInstance = new TemperatureApi(config);
            var temperatureId = "temperatureId_example";  // string | ID of the temperature sensor
            var temperaturePut = new TemperaturePut?(); // TemperaturePut? |  (optional) 

            try
            {
                // Update temperature sensor
                UpdateDevice200Response result = apiInstance.UpdateTemperature(temperatureId, temperaturePut);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TemperatureApi.UpdateTemperature: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateTemperatureWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update temperature sensor
    ApiResponse<UpdateDevice200Response> response = apiInstance.UpdateTemperatureWithHttpInfo(temperatureId, temperaturePut);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TemperatureApi.UpdateTemperatureWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **temperatureId** | **string** | ID of the temperature sensor |  |
| **temperaturePut** | [**TemperaturePut?**](TemperaturePut?.md) |  | [optional]  |

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

