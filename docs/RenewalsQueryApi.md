# Uinsure.CustomerPortal.Client.Api.RenewalsQueryApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiRenewalsDetailsGet**](RenewalsQueryApi.md#apirenewalsdetailsget) | **GET** /api/Renewals/details | Gets the renewal details for a customer&#39;s policy |
| [**ApiRenewalsDownloadGet**](RenewalsQueryApi.md#apirenewalsdownloadget) | **GET** /api/Renewals/download | Download a renewal document for a given policy number |
| [**ApiRenewalsOptInGet**](RenewalsQueryApi.md#apirenewalsoptinget) | **GET** /api/Renewals/opt-in | Gets the opted in choice for the policy. |

<a id="apirenewalsdetailsget"></a>
# **ApiRenewalsDetailsGet**
> RenewalDetails ApiRenewalsDetailsGet ()

Gets the renewal details for a customer's policy

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Uinsure.CustomerPortal.Client.Api;
using Uinsure.CustomerPortal.Client.Client;
using Uinsure.CustomerPortal.Client.Model;

namespace Example
{
    public class ApiRenewalsDetailsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RenewalsQueryApi(config);

            try
            {
                // Gets the renewal details for a customer's policy
                RenewalDetails result = apiInstance.ApiRenewalsDetailsGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RenewalsQueryApi.ApiRenewalsDetailsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiRenewalsDetailsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets the renewal details for a customer's policy
    ApiResponse<RenewalDetails> response = apiInstance.ApiRenewalsDetailsGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RenewalsQueryApi.ApiRenewalsDetailsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**RenewalDetails**](RenewalDetails.md)

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

<a id="apirenewalsdownloadget"></a>
# **ApiRenewalsDownloadGet**
> System.IO.Stream ApiRenewalsDownloadGet ()

Download a renewal document for a given policy number

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Uinsure.CustomerPortal.Client.Api;
using Uinsure.CustomerPortal.Client.Client;
using Uinsure.CustomerPortal.Client.Model;

namespace Example
{
    public class ApiRenewalsDownloadGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RenewalsQueryApi(config);

            try
            {
                // Download a renewal document for a given policy number
                System.IO.Stream result = apiInstance.ApiRenewalsDownloadGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RenewalsQueryApi.ApiRenewalsDownloadGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiRenewalsDownloadGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Download a renewal document for a given policy number
    ApiResponse<System.IO.Stream> response = apiInstance.ApiRenewalsDownloadGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RenewalsQueryApi.ApiRenewalsDownloadGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

**System.IO.Stream**

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

<a id="apirenewalsoptinget"></a>
# **ApiRenewalsOptInGet**
> bool ApiRenewalsOptInGet ()

Gets the opted in choice for the policy.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Uinsure.CustomerPortal.Client.Api;
using Uinsure.CustomerPortal.Client.Client;
using Uinsure.CustomerPortal.Client.Model;

namespace Example
{
    public class ApiRenewalsOptInGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RenewalsQueryApi(config);

            try
            {
                // Gets the opted in choice for the policy.
                bool result = apiInstance.ApiRenewalsOptInGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RenewalsQueryApi.ApiRenewalsOptInGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiRenewalsOptInGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets the opted in choice for the policy.
    ApiResponse<bool> response = apiInstance.ApiRenewalsOptInGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RenewalsQueryApi.ApiRenewalsOptInGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

**bool**

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

