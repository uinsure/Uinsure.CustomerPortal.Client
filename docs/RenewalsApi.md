# Uinsure.CustomerPortal.Client.Api.RenewalsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiRenewalsEmailUpdatePost**](RenewalsApi.md#apirenewalsemailupdatepost) | **POST** /api/Renewals/email/update | Updates the email address for the policy renewal. |
| [**ApiRenewalsOptInPost**](RenewalsApi.md#apirenewalsoptinpost) | **POST** /api/Renewals/opt-in | Updates the opt in choice for the policy renewal. |

<a id="apirenewalsemailupdatepost"></a>
# **ApiRenewalsEmailUpdatePost**
> void ApiRenewalsEmailUpdatePost (UpdateEmailAddress? updateEmailAddress = null)

Updates the email address for the policy renewal.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Uinsure.CustomerPortal.Client.Api;
using Uinsure.CustomerPortal.Client.Client;
using Uinsure.CustomerPortal.Client.Model;

namespace Example
{
    public class ApiRenewalsEmailUpdatePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RenewalsApi(config);
            var updateEmailAddress = new UpdateEmailAddress?(); // UpdateEmailAddress? |  (optional) 

            try
            {
                // Updates the email address for the policy renewal.
                apiInstance.ApiRenewalsEmailUpdatePost(updateEmailAddress);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RenewalsApi.ApiRenewalsEmailUpdatePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiRenewalsEmailUpdatePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates the email address for the policy renewal.
    apiInstance.ApiRenewalsEmailUpdatePostWithHttpInfo(updateEmailAddress);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RenewalsApi.ApiRenewalsEmailUpdatePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **updateEmailAddress** | [**UpdateEmailAddress?**](UpdateEmailAddress?.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apirenewalsoptinpost"></a>
# **ApiRenewalsOptInPost**
> void ApiRenewalsOptInPost (OptInRequest? optInRequest = null)

Updates the opt in choice for the policy renewal.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Uinsure.CustomerPortal.Client.Api;
using Uinsure.CustomerPortal.Client.Client;
using Uinsure.CustomerPortal.Client.Model;

namespace Example
{
    public class ApiRenewalsOptInPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RenewalsApi(config);
            var optInRequest = new OptInRequest?(); // OptInRequest? |  (optional) 

            try
            {
                // Updates the opt in choice for the policy renewal.
                apiInstance.ApiRenewalsOptInPost(optInRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RenewalsApi.ApiRenewalsOptInPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiRenewalsOptInPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates the opt in choice for the policy renewal.
    apiInstance.ApiRenewalsOptInPostWithHttpInfo(optInRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RenewalsApi.ApiRenewalsOptInPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **optInRequest** | [**OptInRequest?**](OptInRequest?.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

