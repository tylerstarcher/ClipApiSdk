# clipapisdk.Api.BridgeHomeApi

All URIs are relative to *https://192.168.1.0*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetBridgeHome**](BridgeHomeApi.md#getbridgehome) | **GET** /clip/v2/resource/bridge_home/{bridgeHomeId} | Get bridge home. |
| [**GetBridgeHomes**](BridgeHomeApi.md#getbridgehomes) | **GET** /clip/v2/resource/bridge_home | List bridge homes. |

<a id="getbridgehome"></a>
# **GetBridgeHome**
> GetBridgeHomes200Response GetBridgeHome (string bridgeHomeId)

Get bridge home.

Get details of a single bridge home from its given `{bridgeHomeId}`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using clipapisdk.Api;
using clipapisdk.Client;
using clipapisdk.Model;

namespace Example
{
    public class GetBridgeHomeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.1.0";
            // Configure API key authorization: HueApplicationKey
            config.AddApiKey("hue-application-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("hue-application-key", "Bearer");

            var apiInstance = new BridgeHomeApi(config);
            var bridgeHomeId = "bridgeHomeId_example";  // string | ID of the bridge home.

            try
            {
                // Get bridge home.
                GetBridgeHomes200Response result = apiInstance.GetBridgeHome(bridgeHomeId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BridgeHomeApi.GetBridgeHome: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetBridgeHomeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get bridge home.
    ApiResponse<GetBridgeHomes200Response> response = apiInstance.GetBridgeHomeWithHttpInfo(bridgeHomeId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BridgeHomeApi.GetBridgeHomeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **bridgeHomeId** | **string** | ID of the bridge home. |  |

### Return type

[**GetBridgeHomes200Response**](GetBridgeHomes200Response.md)

### Authorization

[HueApplicationKey](../README.md#HueApplicationKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Bridge Home Success Response |  -  |
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

<a id="getbridgehomes"></a>
# **GetBridgeHomes**
> GetBridgeHomes200Response GetBridgeHomes ()

List bridge homes.

List all available bridge homes.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using clipapisdk.Api;
using clipapisdk.Client;
using clipapisdk.Model;

namespace Example
{
    public class GetBridgeHomesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.1.0";
            // Configure API key authorization: HueApplicationKey
            config.AddApiKey("hue-application-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("hue-application-key", "Bearer");

            var apiInstance = new BridgeHomeApi(config);

            try
            {
                // List bridge homes.
                GetBridgeHomes200Response result = apiInstance.GetBridgeHomes();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BridgeHomeApi.GetBridgeHomes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetBridgeHomesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List bridge homes.
    ApiResponse<GetBridgeHomes200Response> response = apiInstance.GetBridgeHomesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BridgeHomeApi.GetBridgeHomesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**GetBridgeHomes200Response**](GetBridgeHomes200Response.md)

### Authorization

[HueApplicationKey](../README.md#HueApplicationKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Bridge Home Success Response |  -  |
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

