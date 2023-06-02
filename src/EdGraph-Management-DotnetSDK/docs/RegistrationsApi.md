# EdGraph.Management.Client.Api.RegistrationsApi

All URIs are relative to *https://api.edgraph.com/management*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApproveTenantRegistrationAsync**](RegistrationsApi.md#approvetenantregistrationasync) | **PUT** /registrations/{registrationId}/approve | Approve a tenant&#39;s registration request |
| [**CreateTenantRegistrationAsync**](RegistrationsApi.md#createtenantregistrationasync) | **POST** /registrations | Create a registration on behalf of a user/tenant |
| [**DeleteTenantRegistrationAsync**](RegistrationsApi.md#deletetenantregistrationasync) | **DELETE** /registrations/{registrationId} | Delete a tenant&#39;s registration request |
| [**DenyTenantRegistrationAsync**](RegistrationsApi.md#denytenantregistrationasync) | **PUT** /registrations/{registrationId}/deny | Deny a tenant&#39;s registration request |
| [**GetAllTenantRegistrationsAsync**](RegistrationsApi.md#getalltenantregistrationsasync) | **GET** /registrations | Retrieves a list of registrations |
| [**GetAzureSubscriptionAsync**](RegistrationsApi.md#getazuresubscriptionasync) | **GET** /registrations/azure/subscriptions | Gets an Azure Subscription |
| [**GetOnboardingApplicationsAsync**](RegistrationsApi.md#getonboardingapplicationsasync) | **GET** /registrations/applications | Gets a list of applications available for registration/onboarding |
| [**GetTenantRegistrationByIdAsync**](RegistrationsApi.md#gettenantregistrationbyidasync) | **GET** /registrations/{registrationId} | Retrieves a specific tenant registration using its primary key |
| [**UpdateTenantRegistrationAsync**](RegistrationsApi.md#updatetenantregistrationasync) | **PUT** /registrations/{registrationId} | Update a tenant&#39;s registration request |

<a id="approvetenantregistrationasync"></a>
# **ApproveTenantRegistrationAsync**
> void ApproveTenantRegistrationAsync (string registrationId, string? apiVersion = null, string? xVersion = null)

Approve a tenant's registration request

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Management.Client.Api;
using EdGraph.Management.Client.Client;
using EdGraph.Management.Client.Model;

namespace Example
{
    public class ApproveTenantRegistrationAsyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/management";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RegistrationsApi(config);
            var registrationId = "registrationId_example";  // string | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 

            try
            {
                // Approve a tenant's registration request
                apiInstance.ApproveTenantRegistrationAsync(registrationId, apiVersion, xVersion);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RegistrationsApi.ApproveTenantRegistrationAsync: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApproveTenantRegistrationAsyncWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Approve a tenant's registration request
    apiInstance.ApproveTenantRegistrationAsyncWithHttpInfo(registrationId, apiVersion, xVersion);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RegistrationsApi.ApproveTenantRegistrationAsyncWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **registrationId** | **string** |  |  |
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **401** | Unauthorized. The request requires authentication. The OAuth bearer token was either not provided or is invalid. The operation may succeed once authentication has been successfully completed. |  -  |
| **403** | Forbidden. The request cannot be completed in the current authorization context. Contact your administrator if you believe this operation should be allowed. |  -  |
| **500** | An unhandled error occurred on the server.See the response body for details. |  -  |
| **200** | Success |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createtenantregistrationasync"></a>
# **CreateTenantRegistrationAsync**
> RegistrationApiRegistrationV1TenantRegistrationCreatedResponse CreateTenantRegistrationAsync (string? apiVersion = null, string? xVersion = null, RegistrationApiRegistrationV1CreateTenantRegistrationRequest? registrationApiRegistrationV1CreateTenantRegistrationRequest = null)

Create a registration on behalf of a user/tenant

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Management.Client.Api;
using EdGraph.Management.Client.Client;
using EdGraph.Management.Client.Model;

namespace Example
{
    public class CreateTenantRegistrationAsyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/management";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RegistrationsApi(config);
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 
            var registrationApiRegistrationV1CreateTenantRegistrationRequest = new RegistrationApiRegistrationV1CreateTenantRegistrationRequest?(); // RegistrationApiRegistrationV1CreateTenantRegistrationRequest? |  (optional) 

            try
            {
                // Create a registration on behalf of a user/tenant
                RegistrationApiRegistrationV1TenantRegistrationCreatedResponse result = apiInstance.CreateTenantRegistrationAsync(apiVersion, xVersion, registrationApiRegistrationV1CreateTenantRegistrationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RegistrationsApi.CreateTenantRegistrationAsync: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateTenantRegistrationAsyncWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a registration on behalf of a user/tenant
    ApiResponse<RegistrationApiRegistrationV1TenantRegistrationCreatedResponse> response = apiInstance.CreateTenantRegistrationAsyncWithHttpInfo(apiVersion, xVersion, registrationApiRegistrationV1CreateTenantRegistrationRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RegistrationsApi.CreateTenantRegistrationAsyncWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |
| **registrationApiRegistrationV1CreateTenantRegistrationRequest** | [**RegistrationApiRegistrationV1CreateTenantRegistrationRequest?**](RegistrationApiRegistrationV1CreateTenantRegistrationRequest?.md) |  | [optional]  |

### Return type

[**RegistrationApiRegistrationV1TenantRegistrationCreatedResponse**](RegistrationApiRegistrationV1TenantRegistrationCreatedResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **401** | Unauthorized. The request requires authentication. The OAuth bearer token was either not provided or is invalid. The operation may succeed once authentication has been successfully completed. |  -  |
| **403** | Forbidden. The request cannot be completed in the current authorization context. Contact your administrator if you believe this operation should be allowed. |  -  |
| **500** | An unhandled error occurred on the server.See the response body for details. |  -  |
| **201** | The resource was created. The location of the resource is available in the Location header of the response. |  -  |
| **400** | Bad Request. The request was invalid and cannot be completed. See the response body for specific validation errors. This will typically be an issue with the query parameters or the request body values. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletetenantregistrationasync"></a>
# **DeleteTenantRegistrationAsync**
> void DeleteTenantRegistrationAsync (string registrationId, string? apiVersion = null, string? xVersion = null, RegistrationApiRegistrationV1DeleteTenantRegistrationRequest? registrationApiRegistrationV1DeleteTenantRegistrationRequest = null)

Delete a tenant's registration request

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Management.Client.Api;
using EdGraph.Management.Client.Client;
using EdGraph.Management.Client.Model;

namespace Example
{
    public class DeleteTenantRegistrationAsyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/management";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RegistrationsApi(config);
            var registrationId = "registrationId_example";  // string | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 
            var registrationApiRegistrationV1DeleteTenantRegistrationRequest = new RegistrationApiRegistrationV1DeleteTenantRegistrationRequest?(); // RegistrationApiRegistrationV1DeleteTenantRegistrationRequest? |  (optional) 

            try
            {
                // Delete a tenant's registration request
                apiInstance.DeleteTenantRegistrationAsync(registrationId, apiVersion, xVersion, registrationApiRegistrationV1DeleteTenantRegistrationRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RegistrationsApi.DeleteTenantRegistrationAsync: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteTenantRegistrationAsyncWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a tenant's registration request
    apiInstance.DeleteTenantRegistrationAsyncWithHttpInfo(registrationId, apiVersion, xVersion, registrationApiRegistrationV1DeleteTenantRegistrationRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RegistrationsApi.DeleteTenantRegistrationAsyncWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **registrationId** | **string** |  |  |
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |
| **registrationApiRegistrationV1DeleteTenantRegistrationRequest** | [**RegistrationApiRegistrationV1DeleteTenantRegistrationRequest?**](RegistrationApiRegistrationV1DeleteTenantRegistrationRequest?.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **401** | Unauthorized. The request requires authentication. The OAuth bearer token was either not provided or is invalid. The operation may succeed once authentication has been successfully completed. |  -  |
| **403** | Forbidden. The request cannot be completed in the current authorization context. Contact your administrator if you believe this operation should be allowed. |  -  |
| **500** | An unhandled error occurred on the server.See the response body for details. |  -  |
| **204** | The resource was successfully deleted. |  -  |
| **400** | Bad Request. The request was invalid and cannot be completed. See the response body for specific validation errors. This will typically be an issue with the query parameters or the request body values. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="denytenantregistrationasync"></a>
# **DenyTenantRegistrationAsync**
> void DenyTenantRegistrationAsync (string registrationId, string? apiVersion = null, string? xVersion = null, RegistrationApiRegistrationV1DenyTenantRegistrationRequest? registrationApiRegistrationV1DenyTenantRegistrationRequest = null)

Deny a tenant's registration request

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Management.Client.Api;
using EdGraph.Management.Client.Client;
using EdGraph.Management.Client.Model;

namespace Example
{
    public class DenyTenantRegistrationAsyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/management";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RegistrationsApi(config);
            var registrationId = "registrationId_example";  // string | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 
            var registrationApiRegistrationV1DenyTenantRegistrationRequest = new RegistrationApiRegistrationV1DenyTenantRegistrationRequest?(); // RegistrationApiRegistrationV1DenyTenantRegistrationRequest? |  (optional) 

            try
            {
                // Deny a tenant's registration request
                apiInstance.DenyTenantRegistrationAsync(registrationId, apiVersion, xVersion, registrationApiRegistrationV1DenyTenantRegistrationRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RegistrationsApi.DenyTenantRegistrationAsync: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DenyTenantRegistrationAsyncWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deny a tenant's registration request
    apiInstance.DenyTenantRegistrationAsyncWithHttpInfo(registrationId, apiVersion, xVersion, registrationApiRegistrationV1DenyTenantRegistrationRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RegistrationsApi.DenyTenantRegistrationAsyncWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **registrationId** | **string** |  |  |
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |
| **registrationApiRegistrationV1DenyTenantRegistrationRequest** | [**RegistrationApiRegistrationV1DenyTenantRegistrationRequest?**](RegistrationApiRegistrationV1DenyTenantRegistrationRequest?.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **401** | Unauthorized. The request requires authentication. The OAuth bearer token was either not provided or is invalid. The operation may succeed once authentication has been successfully completed. |  -  |
| **403** | Forbidden. The request cannot be completed in the current authorization context. Contact your administrator if you believe this operation should be allowed. |  -  |
| **500** | An unhandled error occurred on the server.See the response body for details. |  -  |
| **200** | Success |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getalltenantregistrationsasync"></a>
# **GetAllTenantRegistrationsAsync**
> RegistrationApiRegistrationV1RegistrationListResponsePaginatedItemsViewModel GetAllTenantRegistrationsAsync (int? pageSize = null, int? pageIndex = null, string? orderBy = null, string? filter = null, string? apiVersion = null, string? xVersion = null)

Retrieves a list of registrations

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Management.Client.Api;
using EdGraph.Management.Client.Client;
using EdGraph.Management.Client.Model;

namespace Example
{
    public class GetAllTenantRegistrationsAsyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/management";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RegistrationsApi(config);
            var pageSize = 10;  // int? |  (optional)  (default to 10)
            var pageIndex = 0;  // int? |  (optional)  (default to 0)
            var orderBy = "\"\"";  // string? |  (optional)  (default to "")
            var filter = "\"\"";  // string? |  (optional)  (default to "")
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 

            try
            {
                // Retrieves a list of registrations
                RegistrationApiRegistrationV1RegistrationListResponsePaginatedItemsViewModel result = apiInstance.GetAllTenantRegistrationsAsync(pageSize, pageIndex, orderBy, filter, apiVersion, xVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RegistrationsApi.GetAllTenantRegistrationsAsync: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAllTenantRegistrationsAsyncWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a list of registrations
    ApiResponse<RegistrationApiRegistrationV1RegistrationListResponsePaginatedItemsViewModel> response = apiInstance.GetAllTenantRegistrationsAsyncWithHttpInfo(pageSize, pageIndex, orderBy, filter, apiVersion, xVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RegistrationsApi.GetAllTenantRegistrationsAsyncWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pageSize** | **int?** |  | [optional] [default to 10] |
| **pageIndex** | **int?** |  | [optional] [default to 0] |
| **orderBy** | **string?** |  | [optional] [default to &quot;&quot;] |
| **filter** | **string?** |  | [optional] [default to &quot;&quot;] |
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |

### Return type

[**RegistrationApiRegistrationV1RegistrationListResponsePaginatedItemsViewModel**](RegistrationApiRegistrationV1RegistrationListResponsePaginatedItemsViewModel.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **401** | Unauthorized. The request requires authentication. The OAuth bearer token was either not provided or is invalid. The operation may succeed once authentication has been successfully completed. |  -  |
| **403** | Forbidden. The request cannot be completed in the current authorization context. Contact your administrator if you believe this operation should be allowed. |  -  |
| **500** | An unhandled error occurred on the server.See the response body for details. |  -  |
| **200** | The requested resource was successfully retrieved. |  -  |
| **400** | Bad Request. The request was invalid and cannot be completed. See the response body for specific validation errors. This will typically be an issue with the query parameters or the request body values. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getazuresubscriptionasync"></a>
# **GetAzureSubscriptionAsync**
> RegistrationApiRegistrationV1AzureSubscription GetAzureSubscriptionAsync (string? subscriptionStoragePath = null, string? apiVersion = null, string? xVersion = null)

Gets an Azure Subscription

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Management.Client.Api;
using EdGraph.Management.Client.Client;
using EdGraph.Management.Client.Model;

namespace Example
{
    public class GetAzureSubscriptionAsyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/management";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RegistrationsApi(config);
            var subscriptionStoragePath = "subscriptionStoragePath_example";  // string? |  (optional) 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 

            try
            {
                // Gets an Azure Subscription
                RegistrationApiRegistrationV1AzureSubscription result = apiInstance.GetAzureSubscriptionAsync(subscriptionStoragePath, apiVersion, xVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RegistrationsApi.GetAzureSubscriptionAsync: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAzureSubscriptionAsyncWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets an Azure Subscription
    ApiResponse<RegistrationApiRegistrationV1AzureSubscription> response = apiInstance.GetAzureSubscriptionAsyncWithHttpInfo(subscriptionStoragePath, apiVersion, xVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RegistrationsApi.GetAzureSubscriptionAsyncWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriptionStoragePath** | **string?** |  | [optional]  |
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |

### Return type

[**RegistrationApiRegistrationV1AzureSubscription**](RegistrationApiRegistrationV1AzureSubscription.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **401** | Unauthorized. The request requires authentication. The OAuth bearer token was either not provided or is invalid. The operation may succeed once authentication has been successfully completed. |  -  |
| **403** | Forbidden. The request cannot be completed in the current authorization context. Contact your administrator if you believe this operation should be allowed. |  -  |
| **500** | An unhandled error occurred on the server.See the response body for details. |  -  |
| **200** | The requested resource was successfully retrieved. |  -  |
| **400** | Bad Request. The request was invalid and cannot be completed. See the response body for specific validation errors. This will typically be an issue with the query parameters or the request body values. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getonboardingapplicationsasync"></a>
# **GetOnboardingApplicationsAsync**
> ApplicationApiApplicationV1PaginatedItemsResponse GetOnboardingApplicationsAsync (int? pageSize = null, int? pageIndex = null, string? orderBy = null, string? apiVersion = null, string? xVersion = null)

Gets a list of applications available for registration/onboarding

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Management.Client.Api;
using EdGraph.Management.Client.Client;
using EdGraph.Management.Client.Model;

namespace Example
{
    public class GetOnboardingApplicationsAsyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/management";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RegistrationsApi(config);
            var pageSize = 10;  // int? |  (optional)  (default to 10)
            var pageIndex = 0;  // int? |  (optional)  (default to 0)
            var orderBy = "\"\"";  // string? |  (optional)  (default to "")
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 

            try
            {
                // Gets a list of applications available for registration/onboarding
                ApplicationApiApplicationV1PaginatedItemsResponse result = apiInstance.GetOnboardingApplicationsAsync(pageSize, pageIndex, orderBy, apiVersion, xVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RegistrationsApi.GetOnboardingApplicationsAsync: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetOnboardingApplicationsAsyncWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets a list of applications available for registration/onboarding
    ApiResponse<ApplicationApiApplicationV1PaginatedItemsResponse> response = apiInstance.GetOnboardingApplicationsAsyncWithHttpInfo(pageSize, pageIndex, orderBy, apiVersion, xVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RegistrationsApi.GetOnboardingApplicationsAsyncWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pageSize** | **int?** |  | [optional] [default to 10] |
| **pageIndex** | **int?** |  | [optional] [default to 0] |
| **orderBy** | **string?** |  | [optional] [default to &quot;&quot;] |
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |

### Return type

[**ApplicationApiApplicationV1PaginatedItemsResponse**](ApplicationApiApplicationV1PaginatedItemsResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **401** | Unauthorized. The request requires authentication. The OAuth bearer token was either not provided or is invalid. The operation may succeed once authentication has been successfully completed. |  -  |
| **403** | Forbidden. The request cannot be completed in the current authorization context. Contact your administrator if you believe this operation should be allowed. |  -  |
| **500** | An unhandled error occurred on the server.See the response body for details. |  -  |
| **200** | The requested resource was successfully retrieved. |  -  |
| **400** | Bad Request. The request was invalid and cannot be completed. See the response body for specific validation errors. This will typically be an issue with the query parameters or the request body values. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gettenantregistrationbyidasync"></a>
# **GetTenantRegistrationByIdAsync**
> RegistrationApiRegistrationV1RegistrationProfileResponse GetTenantRegistrationByIdAsync (string registrationId, string? apiVersion = null, string? xVersion = null)

Retrieves a specific tenant registration using its primary key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Management.Client.Api;
using EdGraph.Management.Client.Client;
using EdGraph.Management.Client.Model;

namespace Example
{
    public class GetTenantRegistrationByIdAsyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/management";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RegistrationsApi(config);
            var registrationId = "registrationId_example";  // string | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 

            try
            {
                // Retrieves a specific tenant registration using its primary key
                RegistrationApiRegistrationV1RegistrationProfileResponse result = apiInstance.GetTenantRegistrationByIdAsync(registrationId, apiVersion, xVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RegistrationsApi.GetTenantRegistrationByIdAsync: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTenantRegistrationByIdAsyncWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a specific tenant registration using its primary key
    ApiResponse<RegistrationApiRegistrationV1RegistrationProfileResponse> response = apiInstance.GetTenantRegistrationByIdAsyncWithHttpInfo(registrationId, apiVersion, xVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RegistrationsApi.GetTenantRegistrationByIdAsyncWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **registrationId** | **string** |  |  |
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |

### Return type

[**RegistrationApiRegistrationV1RegistrationProfileResponse**](RegistrationApiRegistrationV1RegistrationProfileResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **401** | Unauthorized. The request requires authentication. The OAuth bearer token was either not provided or is invalid. The operation may succeed once authentication has been successfully completed. |  -  |
| **403** | Forbidden. The request cannot be completed in the current authorization context. Contact your administrator if you believe this operation should be allowed. |  -  |
| **500** | An unhandled error occurred on the server.See the response body for details. |  -  |
| **200** | The requested resource was successfully retrieved. |  -  |
| **400** | Bad Request. The request was invalid and cannot be completed. See the response body for specific validation errors. This will typically be an issue with the query parameters or the request body values. |  -  |
| **404** | The resource could not be found. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatetenantregistrationasync"></a>
# **UpdateTenantRegistrationAsync**
> RegistrationApiRegistrationV1TenantRegistrationUpdatedResponse UpdateTenantRegistrationAsync (string registrationId, string? apiVersion = null, string? xVersion = null, RegistrationApiRegistrationV1UpdateTenantRegistrationRequest? registrationApiRegistrationV1UpdateTenantRegistrationRequest = null)

Update a tenant's registration request

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Management.Client.Api;
using EdGraph.Management.Client.Client;
using EdGraph.Management.Client.Model;

namespace Example
{
    public class UpdateTenantRegistrationAsyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/management";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RegistrationsApi(config);
            var registrationId = "registrationId_example";  // string | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 
            var registrationApiRegistrationV1UpdateTenantRegistrationRequest = new RegistrationApiRegistrationV1UpdateTenantRegistrationRequest?(); // RegistrationApiRegistrationV1UpdateTenantRegistrationRequest? |  (optional) 

            try
            {
                // Update a tenant's registration request
                RegistrationApiRegistrationV1TenantRegistrationUpdatedResponse result = apiInstance.UpdateTenantRegistrationAsync(registrationId, apiVersion, xVersion, registrationApiRegistrationV1UpdateTenantRegistrationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RegistrationsApi.UpdateTenantRegistrationAsync: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateTenantRegistrationAsyncWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a tenant's registration request
    ApiResponse<RegistrationApiRegistrationV1TenantRegistrationUpdatedResponse> response = apiInstance.UpdateTenantRegistrationAsyncWithHttpInfo(registrationId, apiVersion, xVersion, registrationApiRegistrationV1UpdateTenantRegistrationRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RegistrationsApi.UpdateTenantRegistrationAsyncWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **registrationId** | **string** |  |  |
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |
| **registrationApiRegistrationV1UpdateTenantRegistrationRequest** | [**RegistrationApiRegistrationV1UpdateTenantRegistrationRequest?**](RegistrationApiRegistrationV1UpdateTenantRegistrationRequest?.md) |  | [optional]  |

### Return type

[**RegistrationApiRegistrationV1TenantRegistrationUpdatedResponse**](RegistrationApiRegistrationV1TenantRegistrationUpdatedResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **401** | Unauthorized. The request requires authentication. The OAuth bearer token was either not provided or is invalid. The operation may succeed once authentication has been successfully completed. |  -  |
| **403** | Forbidden. The request cannot be completed in the current authorization context. Contact your administrator if you believe this operation should be allowed. |  -  |
| **500** | An unhandled error occurred on the server.See the response body for details. |  -  |
| **200** | Success |  -  |
| **400** | Bad Request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

