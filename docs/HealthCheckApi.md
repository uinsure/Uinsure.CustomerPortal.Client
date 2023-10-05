# Uinsure.CustomerPortal.Client.Api.HealthCheckApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiHealthCheckAuthGet**](HealthCheckApi.md#apihealthcheckauthget) | **GET** /api/HealthCheck/auth | An additional healthcheck endpoint that validates an authorized request with api-read permission.    This healthcheck endpoint will return \&quot;ok\&quot; when everything is assumed to be working , and otherwise return \&quot;not OK\&quot; when it&#39;s not. |
| [**ApiHealthCheckAuthPost**](HealthCheckApi.md#apihealthcheckauthpost) | **POST** /api/HealthCheck/auth | An additional healthcheck endpoint that validates an authorized request with api-write permission.    This healthcheck endpoint will return \&quot;ok\&quot; when everything is assumed to be working ,   and otherwise return \&quot;not OK\&quot; when it&#39;s not. |
| [**ApiHealthCheckGet**](HealthCheckApi.md#apihealthcheckget) | **GET** /api/HealthCheck | The default endpoint.    This is the default health check endpoint that can be used to assure that the system is correctly configured  and recieving HTTP requests.    This healthcheck endpoint will return \&quot;ok\&quot; when everything is assumed to be working, and otherwise return \&quot;not OK\&quot;  if something is misconfigured but it can still handle the request |

<a id="apihealthcheckauthget"></a>
# **ApiHealthCheckAuthGet**
> string ApiHealthCheckAuthGet ()

An additional healthcheck endpoint that validates an authorized request with api-read permission.    This healthcheck endpoint will return \"ok\" when everything is assumed to be working , and otherwise return \"not OK\" when it's not.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Uinsure.CustomerPortal.Client.Api;
using Uinsure.CustomerPortal.Client.Client;
using Uinsure.CustomerPortal.Client.Model;

namespace Example
{
    public class ApiHealthCheckAuthGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new HealthCheckApi(config);

            try
            {
                // An additional healthcheck endpoint that validates an authorized request with api-read permission.    This healthcheck endpoint will return \"ok\" when everything is assumed to be working , and otherwise return \"not OK\" when it's not.
                string result = apiInstance.ApiHealthCheckAuthGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HealthCheckApi.ApiHealthCheckAuthGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiHealthCheckAuthGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // An additional healthcheck endpoint that validates an authorized request with api-read permission.    This healthcheck endpoint will return \"ok\" when everything is assumed to be working , and otherwise return \"not OK\" when it's not.
    ApiResponse<string> response = apiInstance.ApiHealthCheckAuthGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HealthCheckApi.ApiHealthCheckAuthGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

**string**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apihealthcheckauthpost"></a>
# **ApiHealthCheckAuthPost**
> string ApiHealthCheckAuthPost ()

An additional healthcheck endpoint that validates an authorized request with api-write permission.    This healthcheck endpoint will return \"ok\" when everything is assumed to be working ,   and otherwise return \"not OK\" when it's not.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Uinsure.CustomerPortal.Client.Api;
using Uinsure.CustomerPortal.Client.Client;
using Uinsure.CustomerPortal.Client.Model;

namespace Example
{
    public class ApiHealthCheckAuthPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new HealthCheckApi(config);

            try
            {
                // An additional healthcheck endpoint that validates an authorized request with api-write permission.    This healthcheck endpoint will return \"ok\" when everything is assumed to be working ,   and otherwise return \"not OK\" when it's not.
                string result = apiInstance.ApiHealthCheckAuthPost();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HealthCheckApi.ApiHealthCheckAuthPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiHealthCheckAuthPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // An additional healthcheck endpoint that validates an authorized request with api-write permission.    This healthcheck endpoint will return \"ok\" when everything is assumed to be working ,   and otherwise return \"not OK\" when it's not.
    ApiResponse<string> response = apiInstance.ApiHealthCheckAuthPostWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HealthCheckApi.ApiHealthCheckAuthPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

**string**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apihealthcheckget"></a>
# **ApiHealthCheckGet**
> string ApiHealthCheckGet ()

The default endpoint.    This is the default health check endpoint that can be used to assure that the system is correctly configured  and recieving HTTP requests.    This healthcheck endpoint will return \"ok\" when everything is assumed to be working, and otherwise return \"not OK\"  if something is misconfigured but it can still handle the request

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Uinsure.CustomerPortal.Client.Api;
using Uinsure.CustomerPortal.Client.Client;
using Uinsure.CustomerPortal.Client.Model;

namespace Example
{
    public class ApiHealthCheckGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new HealthCheckApi(config);

            try
            {
                // The default endpoint.    This is the default health check endpoint that can be used to assure that the system is correctly configured  and recieving HTTP requests.    This healthcheck endpoint will return \"ok\" when everything is assumed to be working, and otherwise return \"not OK\"  if something is misconfigured but it can still handle the request
                string result = apiInstance.ApiHealthCheckGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HealthCheckApi.ApiHealthCheckGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiHealthCheckGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // The default endpoint.    This is the default health check endpoint that can be used to assure that the system is correctly configured  and recieving HTTP requests.    This healthcheck endpoint will return \"ok\" when everything is assumed to be working, and otherwise return \"not OK\"  if something is misconfigured but it can still handle the request
    ApiResponse<string> response = apiInstance.ApiHealthCheckGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HealthCheckApi.ApiHealthCheckGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

**string**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

