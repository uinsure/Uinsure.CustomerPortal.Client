# Uinsure.CustomerPortal.Client.Api.PoliciesQueryApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApiAdminPoliciesFindPost**](PoliciesQueryApi.md#apiadminpoliciesfindpost) | **POST** /api/admin/policies/find | Finds policies matching any or all from agreement number, surname, date of birth, risk address postcode, telephone number or policy status. |
| [**ApiAdminPoliciesPolicyNumberGet**](PoliciesQueryApi.md#apiadminpoliciespolicynumberget) | **GET** /api/admin/policies/{policyNumber} | Returns the policy details for a specified policy number |

<a id="apiadminpoliciesfindpost"></a>
# **ApiAdminPoliciesFindPost**
> List&lt;UinsureCustomerPortalInfrastructureQueryDTOFindPoliciesResult&gt; ApiAdminPoliciesFindPost (FindPoliciesRequest? findPoliciesRequest = null)

Finds policies matching any or all from agreement number, surname, date of birth, risk address postcode, telephone number or policy status.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Uinsure.CustomerPortal.Client.Api;
using Uinsure.CustomerPortal.Client.Client;
using Uinsure.CustomerPortal.Client.Model;

namespace Example
{
    public class ApiAdminPoliciesFindPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PoliciesQueryApi(config);
            var findPoliciesRequest = new FindPoliciesRequest?(); // FindPoliciesRequest? | The search request (optional) 

            try
            {
                // Finds policies matching any or all from agreement number, surname, date of birth, risk address postcode, telephone number or policy status.
                List<UinsureCustomerPortalInfrastructureQueryDTOFindPoliciesResult> result = apiInstance.ApiAdminPoliciesFindPost(findPoliciesRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PoliciesQueryApi.ApiAdminPoliciesFindPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiAdminPoliciesFindPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Finds policies matching any or all from agreement number, surname, date of birth, risk address postcode, telephone number or policy status.
    ApiResponse<List<UinsureCustomerPortalInfrastructureQueryDTOFindPoliciesResult>> response = apiInstance.ApiAdminPoliciesFindPostWithHttpInfo(findPoliciesRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PoliciesQueryApi.ApiAdminPoliciesFindPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **findPoliciesRequest** | [**FindPoliciesRequest?**](FindPoliciesRequest?.md) | The search request | [optional]  |

### Return type

[**List&lt;UinsureCustomerPortalInfrastructureQueryDTOFindPoliciesResult&gt;**](UinsureCustomerPortalInfrastructureQueryDTOFindPoliciesResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns a collection of policies which satisfy the provided filter. |  -  |
| **400** | If the request body is empty, or any provided filters are invalid. |  -  |
| **401** | If the request does not contain valid authorisation. |  -  |
| **500** | If the server fails to process the request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="apiadminpoliciespolicynumberget"></a>
# **ApiAdminPoliciesPolicyNumberGet**
> GetPolicyDetailsResponse ApiAdminPoliciesPolicyNumberGet (string policyNumber, bool? useAccountReference = null, string? policyStatus = null)

Returns the policy details for a specified policy number

If the specified policy number is a renewal (policy number contains a '/') then it must be URL encoded.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Uinsure.CustomerPortal.Client.Api;
using Uinsure.CustomerPortal.Client.Client;
using Uinsure.CustomerPortal.Client.Model;

namespace Example
{
    public class ApiAdminPoliciesPolicyNumberGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PoliciesQueryApi(config);
            var policyNumber = "policyNumber_example";  // string | Sanitised URL-safe policy number
            var useAccountReference = true;  // bool? | An optional flag to determine whether or not to search for details using the Policy Number or the Account Reference  The policy number can contain version information (e.g. UINH0123456/7) whereas an Account Reference should never contain  it (e.g. UINH0123456) (optional) 
            var policyStatus = "policyStatus_example";  // string? | An optional filter parameter which will look for any details matching a valid policy status. (optional) 

            try
            {
                // Returns the policy details for a specified policy number
                GetPolicyDetailsResponse result = apiInstance.ApiAdminPoliciesPolicyNumberGet(policyNumber, useAccountReference, policyStatus);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PoliciesQueryApi.ApiAdminPoliciesPolicyNumberGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApiAdminPoliciesPolicyNumberGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns the policy details for a specified policy number
    ApiResponse<GetPolicyDetailsResponse> response = apiInstance.ApiAdminPoliciesPolicyNumberGetWithHttpInfo(policyNumber, useAccountReference, policyStatus);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PoliciesQueryApi.ApiAdminPoliciesPolicyNumberGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **policyNumber** | **string** | Sanitised URL-safe policy number |  |
| **useAccountReference** | **bool?** | An optional flag to determine whether or not to search for details using the Policy Number or the Account Reference  The policy number can contain version information (e.g. UINH0123456/7) whereas an Account Reference should never contain  it (e.g. UINH0123456) | [optional]  |
| **policyStatus** | **string?** | An optional filter parameter which will look for any details matching a valid policy status. | [optional]  |

### Return type

[**GetPolicyDetailsResponse**](GetPolicyDetailsResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the policy details for a specified policy number. |  -  |
| **400** | If provided policy number is not of a valid format. |  -  |
| **401** | If the request does not contain valid authorisation. |  -  |
| **500** | If the server fails to process the request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

