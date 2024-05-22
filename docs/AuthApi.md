# clipapisdk.Api.AuthApi

All URIs are relative to *https://192.168.1.0*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**Authenticate**](AuthApi.md#authenticate) | **POST** /api | Authenticate |

<a id="authenticate"></a>
# **Authenticate**
> List&lt;ResponseInner&gt; Authenticate (AuthenticateRequest? authenticateRequest = null)

Authenticate

Authenticate to retrieve the HUE application key. Requires to go and press the button on the bridge

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using clipapisdk.Api;
using clipapisdk.Client;
using clipapisdk.Model;

namespace Example
{
    public class AuthenticateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://192.168.1.0";
            var apiInstance = new AuthApi(config);
            var authenticateRequest = new AuthenticateRequest?(); // AuthenticateRequest? |  (optional) 

            try
            {
                // Authenticate
                List<ResponseInner> result = apiInstance.Authenticate(authenticateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.Authenticate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AuthenticateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Authenticate
    ApiResponse<List<ResponseInner>> response = apiInstance.AuthenticateWithHttpInfo(authenticateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthApi.AuthenticateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **authenticateRequest** | [**AuthenticateRequest?**](AuthenticateRequest?.md) |  | [optional]  |

### Return type

[**List&lt;ResponseInner&gt;**](ResponseInner.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Authentication Success |  -  |
| **401** | Unauthorized |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

