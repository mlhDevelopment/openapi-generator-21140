# MyNamespace.Api.DefaultApi

All URIs are relative to *https://example.com/api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetOptionalAge**](DefaultApi.md#getoptionalage) | **GET** /optional | Get an optional integer value |
| [**GetRequiredAge**](DefaultApi.md#getrequiredage) | **GET** /required | Get a required integer value |

<a id="getoptionalage"></a>
# **GetOptionalAge**
> OptionalPayload GetOptionalAge ()

Get an optional integer value

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyNamespace.Api;
using MyNamespace.Client;
using MyNamespace.MySubset;

namespace Example
{
    public class GetOptionalAgeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://example.com/api/v1";
            var apiInstance = new DefaultApi(config);

            try
            {
                // Get an optional integer value
                OptionalPayload result = apiInstance.GetOptionalAge();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetOptionalAge: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetOptionalAgeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get an optional integer value
    ApiResponse<OptionalPayload> response = apiInstance.GetOptionalAgeWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetOptionalAgeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**OptionalPayload**](OptionalPayload.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful optional integer value |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getrequiredage"></a>
# **GetRequiredAge**
> RequiredPayload GetRequiredAge ()

Get a required integer value

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MyNamespace.Api;
using MyNamespace.Client;
using MyNamespace.MySubset;

namespace Example
{
    public class GetRequiredAgeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://example.com/api/v1";
            var apiInstance = new DefaultApi(config);

            try
            {
                // Get a required integer value
                RequiredPayload result = apiInstance.GetRequiredAge();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetRequiredAge: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRequiredAgeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a required integer value
    ApiResponse<RequiredPayload> response = apiInstance.GetRequiredAgeWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetRequiredAgeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**RequiredPayload**](RequiredPayload.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful required integer value |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

