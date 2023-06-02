# EdGraph.Management.Client.Api.TenantsApi

All URIs are relative to *https://api.edgraph.com/management*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ActivateTenantSubscriptionAsync**](TenantsApi.md#activatetenantsubscriptionasync) | **PUT** /tenants/{tenantId}/subscriptions/{subscriptionId}/activate | Activate a Tenant Subscription |
| [**CreateTenantApplicationAsync**](TenantsApi.md#createtenantapplicationasync) | **POST** /tenants/{tenantId}/applications | Create a tenant&#39;s application |
| [**CreateTenantAsync**](TenantsApi.md#createtenantasync) | **POST** /tenants | Creates a new tenant |
| [**CreateTenantSubscriptionAsync**](TenantsApi.md#createtenantsubscriptionasync) | **POST** /tenants/{tenantId}/subscriptions | Creates a new Tenant Subscription |
| [**DeactivateTenantSubscriptionAsyncAsync**](TenantsApi.md#deactivatetenantsubscriptionasyncasync) | **PUT** /tenants/{tenantId}/subscriptions/{subscriptionId}/deactivate | Deactivate a Tenant Subscription |
| [**DeleteApplicationAsync**](TenantsApi.md#deleteapplicationasync) | **DELETE** /tenants/{tenantId}/applications/{applicationId} | Delete a tenant&#39;s application |
| [**DeleteTenantAsync**](TenantsApi.md#deletetenantasync) | **DELETE** /tenants/{tenantId} | Deletes a tenant |
| [**DeleteTenantSubscriptionAsync**](TenantsApi.md#deletetenantsubscriptionasync) | **DELETE** /tenants/{tenantId}/subscriptions/{subscriptionId} | Deletes a Tenant Subscription |
| [**GetAllTenantSubscriptionsAsync**](TenantsApi.md#getalltenantsubscriptionsasync) | **GET** /tenants/{tenantId}/subscriptions | Retrieves a list of Tenant Subscriptions |
| [**GetAllTenantsAsync**](TenantsApi.md#getalltenantsasync) | **GET** /tenants | Retrieves a list of tenants |
| [**GetTenantApplicationLauncherSettingsByIdAsync**](TenantsApi.md#gettenantapplicationlaunchersettingsbyidasync) | **GET** /tenants/{tenantId}/applications/{applicationId}/launchersettings | Retrieves a specific application associated to a tenant |
| [**GetTenantApplicationProfileByIdAsync**](TenantsApi.md#gettenantapplicationprofilebyidasync) | **GET** /tenants/{tenantId}/applications/{applicationId} | Retrieves a specific application associated to a tenant |
| [**GetTenantApplicationsAsync**](TenantsApi.md#gettenantapplicationsasync) | **GET** /tenants/{tenantId}/applications | Retrieves a list of tenant applications |
| [**GetTenantByIdAsync**](TenantsApi.md#gettenantbyidasync) | **GET** /tenants/{tenantId} | Retrieves a specific tenant |
| [**GetTenantSubscriptionProfileByIdAsync**](TenantsApi.md#gettenantsubscriptionprofilebyidasync) | **GET** /tenants/{tenantId}/subscriptions/{subscriptionId} | Retrieves a specific Tenant Subscription |
| [**PublishTenantApplicationAsync**](TenantsApi.md#publishtenantapplicationasync) | **PUT** /tenants/{tenantId}/applications/{applicationId}/publish | Publish a tenant&#39;s application |
| [**RejectTenantSubscriptionAsync**](TenantsApi.md#rejecttenantsubscriptionasync) | **PUT** /tenants/{tenantId}/subscriptions/{subscriptionId}/reject | Reject a Tenant Subscription |
| [**UpdateTenantApplicationLauncherSettingsAsync**](TenantsApi.md#updatetenantapplicationlaunchersettingsasync) | **PUT** /tenants/{tenantId}/applications/{applicationId}/launchersettings | Update a tenant&#39;s application launcher settings |
| [**UpdateTenantApplicationProfileAsync**](TenantsApi.md#updatetenantapplicationprofileasync) | **PUT** /tenants/{tenantId}/applications/{applicationId} | Update a tenant&#39;s application profile |
| [**UpdateTenantAsync**](TenantsApi.md#updatetenantasync) | **PUT** /tenants/{tenantId} | Updates a tenant |
| [**UpdateTenantSubscriptionAsync**](TenantsApi.md#updatetenantsubscriptionasync) | **PUT** /tenants/{tenantId}/subscriptions/{subscriptionId} | Updates a Tenant Subscription |

<a id="activatetenantsubscriptionasync"></a>
# **ActivateTenantSubscriptionAsync**
> TenantApiTenantV1SubscriptionActivatedResponse ActivateTenantSubscriptionAsync (string tenantId, string subscriptionId, string? apiVersion = null, string? xVersion = null, TenantApiTenantV1ActivateSubscriptionRequest? tenantApiTenantV1ActivateSubscriptionRequest = null)

Activate a Tenant Subscription

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Management.Client.Api;
using EdGraph.Management.Client.Client;
using EdGraph.Management.Client.Model;

namespace Example
{
    public class ActivateTenantSubscriptionAsyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/management";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TenantsApi(config);
            var tenantId = "tenantId_example";  // string | 
            var subscriptionId = "subscriptionId_example";  // string | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 
            var tenantApiTenantV1ActivateSubscriptionRequest = new TenantApiTenantV1ActivateSubscriptionRequest?(); // TenantApiTenantV1ActivateSubscriptionRequest? |  (optional) 

            try
            {
                // Activate a Tenant Subscription
                TenantApiTenantV1SubscriptionActivatedResponse result = apiInstance.ActivateTenantSubscriptionAsync(tenantId, subscriptionId, apiVersion, xVersion, tenantApiTenantV1ActivateSubscriptionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TenantsApi.ActivateTenantSubscriptionAsync: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ActivateTenantSubscriptionAsyncWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Activate a Tenant Subscription
    ApiResponse<TenantApiTenantV1SubscriptionActivatedResponse> response = apiInstance.ActivateTenantSubscriptionAsyncWithHttpInfo(tenantId, subscriptionId, apiVersion, xVersion, tenantApiTenantV1ActivateSubscriptionRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TenantsApi.ActivateTenantSubscriptionAsyncWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **subscriptionId** | **string** |  |  |
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |
| **tenantApiTenantV1ActivateSubscriptionRequest** | [**TenantApiTenantV1ActivateSubscriptionRequest?**](TenantApiTenantV1ActivateSubscriptionRequest?.md) |  | [optional]  |

### Return type

[**TenantApiTenantV1SubscriptionActivatedResponse**](TenantApiTenantV1SubscriptionActivatedResponse.md)

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
| **200** | The requested resource was successfully retrieved. |  -  |
| **400** | Bad Request. The request was invalid and cannot be completed. See the response body for specific validation errors. This will typically be an issue with the query parameters or the request body values. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createtenantapplicationasync"></a>
# **CreateTenantApplicationAsync**
> ApplicationApiApplicationV2ApplicationCreatedResponse CreateTenantApplicationAsync (string tenantId, string? apiVersion = null, string? xVersion = null, ApplicationApiApplicationV2CreateApplicationRequest? applicationApiApplicationV2CreateApplicationRequest = null)

Create a tenant's application

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Management.Client.Api;
using EdGraph.Management.Client.Client;
using EdGraph.Management.Client.Model;

namespace Example
{
    public class CreateTenantApplicationAsyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/management";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TenantsApi(config);
            var tenantId = "tenantId_example";  // string | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 
            var applicationApiApplicationV2CreateApplicationRequest = new ApplicationApiApplicationV2CreateApplicationRequest?(); // ApplicationApiApplicationV2CreateApplicationRequest? |  (optional) 

            try
            {
                // Create a tenant's application
                ApplicationApiApplicationV2ApplicationCreatedResponse result = apiInstance.CreateTenantApplicationAsync(tenantId, apiVersion, xVersion, applicationApiApplicationV2CreateApplicationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TenantsApi.CreateTenantApplicationAsync: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateTenantApplicationAsyncWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a tenant's application
    ApiResponse<ApplicationApiApplicationV2ApplicationCreatedResponse> response = apiInstance.CreateTenantApplicationAsyncWithHttpInfo(tenantId, apiVersion, xVersion, applicationApiApplicationV2CreateApplicationRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TenantsApi.CreateTenantApplicationAsyncWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |
| **applicationApiApplicationV2CreateApplicationRequest** | [**ApplicationApiApplicationV2CreateApplicationRequest?**](ApplicationApiApplicationV2CreateApplicationRequest?.md) |  | [optional]  |

### Return type

[**ApplicationApiApplicationV2ApplicationCreatedResponse**](ApplicationApiApplicationV2ApplicationCreatedResponse.md)

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

<a id="createtenantasync"></a>
# **CreateTenantAsync**
> TenantApiTenantV1TenantCreatedResponse CreateTenantAsync (string? apiVersion = null, string? xVersion = null, TenantApiTenantV1CreateTenantRequest? tenantApiTenantV1CreateTenantRequest = null)

Creates a new tenant

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Management.Client.Api;
using EdGraph.Management.Client.Client;
using EdGraph.Management.Client.Model;

namespace Example
{
    public class CreateTenantAsyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/management";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TenantsApi(config);
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 
            var tenantApiTenantV1CreateTenantRequest = new TenantApiTenantV1CreateTenantRequest?(); // TenantApiTenantV1CreateTenantRequest? |  (optional) 

            try
            {
                // Creates a new tenant
                TenantApiTenantV1TenantCreatedResponse result = apiInstance.CreateTenantAsync(apiVersion, xVersion, tenantApiTenantV1CreateTenantRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TenantsApi.CreateTenantAsync: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateTenantAsyncWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a new tenant
    ApiResponse<TenantApiTenantV1TenantCreatedResponse> response = apiInstance.CreateTenantAsyncWithHttpInfo(apiVersion, xVersion, tenantApiTenantV1CreateTenantRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TenantsApi.CreateTenantAsyncWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |
| **tenantApiTenantV1CreateTenantRequest** | [**TenantApiTenantV1CreateTenantRequest?**](TenantApiTenantV1CreateTenantRequest?.md) |  | [optional]  |

### Return type

[**TenantApiTenantV1TenantCreatedResponse**](TenantApiTenantV1TenantCreatedResponse.md)

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

<a id="createtenantsubscriptionasync"></a>
# **CreateTenantSubscriptionAsync**
> TenantApiTenantV1SubscriptionCreatedResponse CreateTenantSubscriptionAsync (string tenantId, string? apiVersion = null, string? xVersion = null, TenantApiTenantV1CreateSubscriptionRequest? tenantApiTenantV1CreateSubscriptionRequest = null)

Creates a new Tenant Subscription

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Management.Client.Api;
using EdGraph.Management.Client.Client;
using EdGraph.Management.Client.Model;

namespace Example
{
    public class CreateTenantSubscriptionAsyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/management";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TenantsApi(config);
            var tenantId = "tenantId_example";  // string | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 
            var tenantApiTenantV1CreateSubscriptionRequest = new TenantApiTenantV1CreateSubscriptionRequest?(); // TenantApiTenantV1CreateSubscriptionRequest? |  (optional) 

            try
            {
                // Creates a new Tenant Subscription
                TenantApiTenantV1SubscriptionCreatedResponse result = apiInstance.CreateTenantSubscriptionAsync(tenantId, apiVersion, xVersion, tenantApiTenantV1CreateSubscriptionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TenantsApi.CreateTenantSubscriptionAsync: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateTenantSubscriptionAsyncWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a new Tenant Subscription
    ApiResponse<TenantApiTenantV1SubscriptionCreatedResponse> response = apiInstance.CreateTenantSubscriptionAsyncWithHttpInfo(tenantId, apiVersion, xVersion, tenantApiTenantV1CreateSubscriptionRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TenantsApi.CreateTenantSubscriptionAsyncWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |
| **tenantApiTenantV1CreateSubscriptionRequest** | [**TenantApiTenantV1CreateSubscriptionRequest?**](TenantApiTenantV1CreateSubscriptionRequest?.md) |  | [optional]  |

### Return type

[**TenantApiTenantV1SubscriptionCreatedResponse**](TenantApiTenantV1SubscriptionCreatedResponse.md)

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

<a id="deactivatetenantsubscriptionasyncasync"></a>
# **DeactivateTenantSubscriptionAsyncAsync**
> TenantApiTenantV1SubscriptionDeactivatedResponse DeactivateTenantSubscriptionAsyncAsync (string tenantId, string subscriptionId, string? apiVersion = null, string? xVersion = null, TenantApiTenantV1DeactivateSubscriptionRequest? tenantApiTenantV1DeactivateSubscriptionRequest = null)

Deactivate a Tenant Subscription

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Management.Client.Api;
using EdGraph.Management.Client.Client;
using EdGraph.Management.Client.Model;

namespace Example
{
    public class DeactivateTenantSubscriptionAsyncAsyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/management";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TenantsApi(config);
            var tenantId = "tenantId_example";  // string | 
            var subscriptionId = "subscriptionId_example";  // string | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 
            var tenantApiTenantV1DeactivateSubscriptionRequest = new TenantApiTenantV1DeactivateSubscriptionRequest?(); // TenantApiTenantV1DeactivateSubscriptionRequest? |  (optional) 

            try
            {
                // Deactivate a Tenant Subscription
                TenantApiTenantV1SubscriptionDeactivatedResponse result = apiInstance.DeactivateTenantSubscriptionAsyncAsync(tenantId, subscriptionId, apiVersion, xVersion, tenantApiTenantV1DeactivateSubscriptionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TenantsApi.DeactivateTenantSubscriptionAsyncAsync: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeactivateTenantSubscriptionAsyncAsyncWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deactivate a Tenant Subscription
    ApiResponse<TenantApiTenantV1SubscriptionDeactivatedResponse> response = apiInstance.DeactivateTenantSubscriptionAsyncAsyncWithHttpInfo(tenantId, subscriptionId, apiVersion, xVersion, tenantApiTenantV1DeactivateSubscriptionRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TenantsApi.DeactivateTenantSubscriptionAsyncAsyncWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **subscriptionId** | **string** |  |  |
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |
| **tenantApiTenantV1DeactivateSubscriptionRequest** | [**TenantApiTenantV1DeactivateSubscriptionRequest?**](TenantApiTenantV1DeactivateSubscriptionRequest?.md) |  | [optional]  |

### Return type

[**TenantApiTenantV1SubscriptionDeactivatedResponse**](TenantApiTenantV1SubscriptionDeactivatedResponse.md)

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
| **200** | The requested resource was successfully retrieved. |  -  |
| **400** | Bad Request. The request was invalid and cannot be completed. See the response body for specific validation errors. This will typically be an issue with the query parameters or the request body values. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteapplicationasync"></a>
# **DeleteApplicationAsync**
> void DeleteApplicationAsync (string tenantId, string applicationId, string? apiVersion = null, string? xVersion = null, ApplicationApiApplicationV2DeleteApplicationRequest? applicationApiApplicationV2DeleteApplicationRequest = null)

Delete a tenant's application

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Management.Client.Api;
using EdGraph.Management.Client.Client;
using EdGraph.Management.Client.Model;

namespace Example
{
    public class DeleteApplicationAsyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/management";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TenantsApi(config);
            var tenantId = "tenantId_example";  // string | 
            var applicationId = "applicationId_example";  // string | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 
            var applicationApiApplicationV2DeleteApplicationRequest = new ApplicationApiApplicationV2DeleteApplicationRequest?(); // ApplicationApiApplicationV2DeleteApplicationRequest? |  (optional) 

            try
            {
                // Delete a tenant's application
                apiInstance.DeleteApplicationAsync(tenantId, applicationId, apiVersion, xVersion, applicationApiApplicationV2DeleteApplicationRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TenantsApi.DeleteApplicationAsync: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteApplicationAsyncWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a tenant's application
    apiInstance.DeleteApplicationAsyncWithHttpInfo(tenantId, applicationId, apiVersion, xVersion, applicationApiApplicationV2DeleteApplicationRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TenantsApi.DeleteApplicationAsyncWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **applicationId** | **string** |  |  |
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |
| **applicationApiApplicationV2DeleteApplicationRequest** | [**ApplicationApiApplicationV2DeleteApplicationRequest?**](ApplicationApiApplicationV2DeleteApplicationRequest?.md) |  | [optional]  |

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

<a id="deletetenantasync"></a>
# **DeleteTenantAsync**
> void DeleteTenantAsync (string tenantId, string? apiVersion = null, string? xVersion = null, TenantApiTenantV1DeleteTenantRequest? tenantApiTenantV1DeleteTenantRequest = null)

Deletes a tenant

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Management.Client.Api;
using EdGraph.Management.Client.Client;
using EdGraph.Management.Client.Model;

namespace Example
{
    public class DeleteTenantAsyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/management";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TenantsApi(config);
            var tenantId = "tenantId_example";  // string | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 
            var tenantApiTenantV1DeleteTenantRequest = new TenantApiTenantV1DeleteTenantRequest?(); // TenantApiTenantV1DeleteTenantRequest? |  (optional) 

            try
            {
                // Deletes a tenant
                apiInstance.DeleteTenantAsync(tenantId, apiVersion, xVersion, tenantApiTenantV1DeleteTenantRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TenantsApi.DeleteTenantAsync: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteTenantAsyncWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes a tenant
    apiInstance.DeleteTenantAsyncWithHttpInfo(tenantId, apiVersion, xVersion, tenantApiTenantV1DeleteTenantRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TenantsApi.DeleteTenantAsyncWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |
| **tenantApiTenantV1DeleteTenantRequest** | [**TenantApiTenantV1DeleteTenantRequest?**](TenantApiTenantV1DeleteTenantRequest?.md) |  | [optional]  |

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

<a id="deletetenantsubscriptionasync"></a>
# **DeleteTenantSubscriptionAsync**
> void DeleteTenantSubscriptionAsync (string tenantId, string subscriptionId, string? apiVersion = null, string? xVersion = null, TenantApiTenantV1DeleteSubscriptionRequest? tenantApiTenantV1DeleteSubscriptionRequest = null)

Deletes a Tenant Subscription

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Management.Client.Api;
using EdGraph.Management.Client.Client;
using EdGraph.Management.Client.Model;

namespace Example
{
    public class DeleteTenantSubscriptionAsyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/management";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TenantsApi(config);
            var tenantId = "tenantId_example";  // string | 
            var subscriptionId = "subscriptionId_example";  // string | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 
            var tenantApiTenantV1DeleteSubscriptionRequest = new TenantApiTenantV1DeleteSubscriptionRequest?(); // TenantApiTenantV1DeleteSubscriptionRequest? |  (optional) 

            try
            {
                // Deletes a Tenant Subscription
                apiInstance.DeleteTenantSubscriptionAsync(tenantId, subscriptionId, apiVersion, xVersion, tenantApiTenantV1DeleteSubscriptionRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TenantsApi.DeleteTenantSubscriptionAsync: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteTenantSubscriptionAsyncWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes a Tenant Subscription
    apiInstance.DeleteTenantSubscriptionAsyncWithHttpInfo(tenantId, subscriptionId, apiVersion, xVersion, tenantApiTenantV1DeleteSubscriptionRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TenantsApi.DeleteTenantSubscriptionAsyncWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **subscriptionId** | **string** |  |  |
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |
| **tenantApiTenantV1DeleteSubscriptionRequest** | [**TenantApiTenantV1DeleteSubscriptionRequest?**](TenantApiTenantV1DeleteSubscriptionRequest?.md) |  | [optional]  |

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

<a id="getalltenantsubscriptionsasync"></a>
# **GetAllTenantSubscriptionsAsync**
> TenantApiTenantV1SubscriptionListResponsePaginatedItemsViewModel GetAllTenantSubscriptionsAsync (string tenantId, int? pageSize = null, int? pageIndex = null, string? orderBy = null, string? filter = null, string? apiVersion = null, string? xVersion = null)

Retrieves a list of Tenant Subscriptions

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Management.Client.Api;
using EdGraph.Management.Client.Client;
using EdGraph.Management.Client.Model;

namespace Example
{
    public class GetAllTenantSubscriptionsAsyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/management";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TenantsApi(config);
            var tenantId = "tenantId_example";  // string | 
            var pageSize = 10;  // int? |  (optional)  (default to 10)
            var pageIndex = 0;  // int? |  (optional)  (default to 0)
            var orderBy = "\"\"";  // string? |  (optional)  (default to "")
            var filter = "\"\"";  // string? |  (optional)  (default to "")
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 

            try
            {
                // Retrieves a list of Tenant Subscriptions
                TenantApiTenantV1SubscriptionListResponsePaginatedItemsViewModel result = apiInstance.GetAllTenantSubscriptionsAsync(tenantId, pageSize, pageIndex, orderBy, filter, apiVersion, xVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TenantsApi.GetAllTenantSubscriptionsAsync: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAllTenantSubscriptionsAsyncWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a list of Tenant Subscriptions
    ApiResponse<TenantApiTenantV1SubscriptionListResponsePaginatedItemsViewModel> response = apiInstance.GetAllTenantSubscriptionsAsyncWithHttpInfo(tenantId, pageSize, pageIndex, orderBy, filter, apiVersion, xVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TenantsApi.GetAllTenantSubscriptionsAsyncWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **pageSize** | **int?** |  | [optional] [default to 10] |
| **pageIndex** | **int?** |  | [optional] [default to 0] |
| **orderBy** | **string?** |  | [optional] [default to &quot;&quot;] |
| **filter** | **string?** |  | [optional] [default to &quot;&quot;] |
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |

### Return type

[**TenantApiTenantV1SubscriptionListResponsePaginatedItemsViewModel**](TenantApiTenantV1SubscriptionListResponsePaginatedItemsViewModel.md)

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

<a id="getalltenantsasync"></a>
# **GetAllTenantsAsync**
> TenantApiTenantV1TenantListResponsePaginatedItemsViewModel GetAllTenantsAsync (int? pageSize = null, int? pageIndex = null, string? orderBy = null, string? filter = null, string? apiVersion = null, string? xVersion = null)

Retrieves a list of tenants

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Management.Client.Api;
using EdGraph.Management.Client.Client;
using EdGraph.Management.Client.Model;

namespace Example
{
    public class GetAllTenantsAsyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/management";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TenantsApi(config);
            var pageSize = 10;  // int? |  (optional)  (default to 10)
            var pageIndex = 0;  // int? |  (optional)  (default to 0)
            var orderBy = "\"\"";  // string? |  (optional)  (default to "")
            var filter = "\"\"";  // string? |  (optional)  (default to "")
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 

            try
            {
                // Retrieves a list of tenants
                TenantApiTenantV1TenantListResponsePaginatedItemsViewModel result = apiInstance.GetAllTenantsAsync(pageSize, pageIndex, orderBy, filter, apiVersion, xVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TenantsApi.GetAllTenantsAsync: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAllTenantsAsyncWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a list of tenants
    ApiResponse<TenantApiTenantV1TenantListResponsePaginatedItemsViewModel> response = apiInstance.GetAllTenantsAsyncWithHttpInfo(pageSize, pageIndex, orderBy, filter, apiVersion, xVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TenantsApi.GetAllTenantsAsyncWithHttpInfo: " + e.Message);
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

[**TenantApiTenantV1TenantListResponsePaginatedItemsViewModel**](TenantApiTenantV1TenantListResponsePaginatedItemsViewModel.md)

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

<a id="gettenantapplicationlaunchersettingsbyidasync"></a>
# **GetTenantApplicationLauncherSettingsByIdAsync**
> ApplicationApiApplicationV2ApplicationLauncherSettingsResponse GetTenantApplicationLauncherSettingsByIdAsync (string tenantId, string applicationId, string? apiVersion = null, string? xVersion = null)

Retrieves a specific application associated to a tenant

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Management.Client.Api;
using EdGraph.Management.Client.Client;
using EdGraph.Management.Client.Model;

namespace Example
{
    public class GetTenantApplicationLauncherSettingsByIdAsyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/management";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TenantsApi(config);
            var tenantId = "tenantId_example";  // string | 
            var applicationId = "applicationId_example";  // string | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 

            try
            {
                // Retrieves a specific application associated to a tenant
                ApplicationApiApplicationV2ApplicationLauncherSettingsResponse result = apiInstance.GetTenantApplicationLauncherSettingsByIdAsync(tenantId, applicationId, apiVersion, xVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TenantsApi.GetTenantApplicationLauncherSettingsByIdAsync: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTenantApplicationLauncherSettingsByIdAsyncWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a specific application associated to a tenant
    ApiResponse<ApplicationApiApplicationV2ApplicationLauncherSettingsResponse> response = apiInstance.GetTenantApplicationLauncherSettingsByIdAsyncWithHttpInfo(tenantId, applicationId, apiVersion, xVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TenantsApi.GetTenantApplicationLauncherSettingsByIdAsyncWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **applicationId** | **string** |  |  |
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |

### Return type

[**ApplicationApiApplicationV2ApplicationLauncherSettingsResponse**](ApplicationApiApplicationV2ApplicationLauncherSettingsResponse.md)

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

<a id="gettenantapplicationprofilebyidasync"></a>
# **GetTenantApplicationProfileByIdAsync**
> ApplicationApiApplicationV2ApplicationProfileResponse GetTenantApplicationProfileByIdAsync (string tenantId, string applicationId, string? apiVersion = null, string? xVersion = null)

Retrieves a specific application associated to a tenant

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Management.Client.Api;
using EdGraph.Management.Client.Client;
using EdGraph.Management.Client.Model;

namespace Example
{
    public class GetTenantApplicationProfileByIdAsyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/management";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TenantsApi(config);
            var tenantId = "tenantId_example";  // string | 
            var applicationId = "applicationId_example";  // string | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 

            try
            {
                // Retrieves a specific application associated to a tenant
                ApplicationApiApplicationV2ApplicationProfileResponse result = apiInstance.GetTenantApplicationProfileByIdAsync(tenantId, applicationId, apiVersion, xVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TenantsApi.GetTenantApplicationProfileByIdAsync: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTenantApplicationProfileByIdAsyncWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a specific application associated to a tenant
    ApiResponse<ApplicationApiApplicationV2ApplicationProfileResponse> response = apiInstance.GetTenantApplicationProfileByIdAsyncWithHttpInfo(tenantId, applicationId, apiVersion, xVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TenantsApi.GetTenantApplicationProfileByIdAsyncWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **applicationId** | **string** |  |  |
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |

### Return type

[**ApplicationApiApplicationV2ApplicationProfileResponse**](ApplicationApiApplicationV2ApplicationProfileResponse.md)

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

<a id="gettenantapplicationsasync"></a>
# **GetTenantApplicationsAsync**
> EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsResponsesApplicationListResponseWithSubscriptionPaginatedItemsViewModel GetTenantApplicationsAsync (string tenantId, int? pageSize = null, int? pageIndex = null, string? orderBy = null, string? filter = null, string? apiVersion = null, string? xVersion = null)

Retrieves a list of tenant applications

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Management.Client.Api;
using EdGraph.Management.Client.Client;
using EdGraph.Management.Client.Model;

namespace Example
{
    public class GetTenantApplicationsAsyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/management";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TenantsApi(config);
            var tenantId = "tenantId_example";  // string | 
            var pageSize = 10;  // int? |  (optional)  (default to 10)
            var pageIndex = 0;  // int? |  (optional)  (default to 0)
            var orderBy = "\"\"";  // string? |  (optional)  (default to "")
            var filter = "\"\"";  // string? |  (optional)  (default to "")
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 

            try
            {
                // Retrieves a list of tenant applications
                EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsResponsesApplicationListResponseWithSubscriptionPaginatedItemsViewModel result = apiInstance.GetTenantApplicationsAsync(tenantId, pageSize, pageIndex, orderBy, filter, apiVersion, xVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TenantsApi.GetTenantApplicationsAsync: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTenantApplicationsAsyncWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a list of tenant applications
    ApiResponse<EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsResponsesApplicationListResponseWithSubscriptionPaginatedItemsViewModel> response = apiInstance.GetTenantApplicationsAsyncWithHttpInfo(tenantId, pageSize, pageIndex, orderBy, filter, apiVersion, xVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TenantsApi.GetTenantApplicationsAsyncWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **pageSize** | **int?** |  | [optional] [default to 10] |
| **pageIndex** | **int?** |  | [optional] [default to 0] |
| **orderBy** | **string?** |  | [optional] [default to &quot;&quot;] |
| **filter** | **string?** |  | [optional] [default to &quot;&quot;] |
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |

### Return type

[**EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsResponsesApplicationListResponseWithSubscriptionPaginatedItemsViewModel**](EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsResponsesApplicationListResponseWithSubscriptionPaginatedItemsViewModel.md)

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

<a id="gettenantbyidasync"></a>
# **GetTenantByIdAsync**
> TenantApiTenantV1TenantProfileResponse GetTenantByIdAsync (string tenantId, string? apiVersion = null, string? xVersion = null)

Retrieves a specific tenant

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Management.Client.Api;
using EdGraph.Management.Client.Client;
using EdGraph.Management.Client.Model;

namespace Example
{
    public class GetTenantByIdAsyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/management";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TenantsApi(config);
            var tenantId = "tenantId_example";  // string | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 

            try
            {
                // Retrieves a specific tenant
                TenantApiTenantV1TenantProfileResponse result = apiInstance.GetTenantByIdAsync(tenantId, apiVersion, xVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TenantsApi.GetTenantByIdAsync: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTenantByIdAsyncWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a specific tenant
    ApiResponse<TenantApiTenantV1TenantProfileResponse> response = apiInstance.GetTenantByIdAsyncWithHttpInfo(tenantId, apiVersion, xVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TenantsApi.GetTenantByIdAsyncWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |

### Return type

[**TenantApiTenantV1TenantProfileResponse**](TenantApiTenantV1TenantProfileResponse.md)

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

<a id="gettenantsubscriptionprofilebyidasync"></a>
# **GetTenantSubscriptionProfileByIdAsync**
> TenantApiTenantV1SubscriptionProfileResponse GetTenantSubscriptionProfileByIdAsync (string tenantId, string subscriptionId, string? apiVersion = null, string? xVersion = null)

Retrieves a specific Tenant Subscription

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Management.Client.Api;
using EdGraph.Management.Client.Client;
using EdGraph.Management.Client.Model;

namespace Example
{
    public class GetTenantSubscriptionProfileByIdAsyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/management";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TenantsApi(config);
            var tenantId = "tenantId_example";  // string | 
            var subscriptionId = "subscriptionId_example";  // string | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 

            try
            {
                // Retrieves a specific Tenant Subscription
                TenantApiTenantV1SubscriptionProfileResponse result = apiInstance.GetTenantSubscriptionProfileByIdAsync(tenantId, subscriptionId, apiVersion, xVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TenantsApi.GetTenantSubscriptionProfileByIdAsync: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTenantSubscriptionProfileByIdAsyncWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a specific Tenant Subscription
    ApiResponse<TenantApiTenantV1SubscriptionProfileResponse> response = apiInstance.GetTenantSubscriptionProfileByIdAsyncWithHttpInfo(tenantId, subscriptionId, apiVersion, xVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TenantsApi.GetTenantSubscriptionProfileByIdAsyncWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **subscriptionId** | **string** |  |  |
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |

### Return type

[**TenantApiTenantV1SubscriptionProfileResponse**](TenantApiTenantV1SubscriptionProfileResponse.md)

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
| **404** | The resource could not be found. |  -  |
| **400** | Bad Request. The request was invalid and cannot be completed. See the response body for specific validation errors. This will typically be an issue with the query parameters or the request body values. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="publishtenantapplicationasync"></a>
# **PublishTenantApplicationAsync**
> ApplicationApiApplicationV2ApplicationPublishedResponse PublishTenantApplicationAsync (string tenantId, string applicationId, string? apiVersion = null, string? xVersion = null)

Publish a tenant's application

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Management.Client.Api;
using EdGraph.Management.Client.Client;
using EdGraph.Management.Client.Model;

namespace Example
{
    public class PublishTenantApplicationAsyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/management";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TenantsApi(config);
            var tenantId = "tenantId_example";  // string | 
            var applicationId = "applicationId_example";  // string | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 

            try
            {
                // Publish a tenant's application
                ApplicationApiApplicationV2ApplicationPublishedResponse result = apiInstance.PublishTenantApplicationAsync(tenantId, applicationId, apiVersion, xVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TenantsApi.PublishTenantApplicationAsync: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PublishTenantApplicationAsyncWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Publish a tenant's application
    ApiResponse<ApplicationApiApplicationV2ApplicationPublishedResponse> response = apiInstance.PublishTenantApplicationAsyncWithHttpInfo(tenantId, applicationId, apiVersion, xVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TenantsApi.PublishTenantApplicationAsyncWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **applicationId** | **string** |  |  |
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |

### Return type

[**ApplicationApiApplicationV2ApplicationPublishedResponse**](ApplicationApiApplicationV2ApplicationPublishedResponse.md)

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

<a id="rejecttenantsubscriptionasync"></a>
# **RejectTenantSubscriptionAsync**
> TenantApiTenantV1SubscriptionRejectedResponse RejectTenantSubscriptionAsync (string tenantId, string subscriptionId, string? apiVersion = null, string? xVersion = null, TenantApiTenantV1RejectSubscriptionRequest? tenantApiTenantV1RejectSubscriptionRequest = null)

Reject a Tenant Subscription

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Management.Client.Api;
using EdGraph.Management.Client.Client;
using EdGraph.Management.Client.Model;

namespace Example
{
    public class RejectTenantSubscriptionAsyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/management";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TenantsApi(config);
            var tenantId = "tenantId_example";  // string | 
            var subscriptionId = "subscriptionId_example";  // string | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 
            var tenantApiTenantV1RejectSubscriptionRequest = new TenantApiTenantV1RejectSubscriptionRequest?(); // TenantApiTenantV1RejectSubscriptionRequest? |  (optional) 

            try
            {
                // Reject a Tenant Subscription
                TenantApiTenantV1SubscriptionRejectedResponse result = apiInstance.RejectTenantSubscriptionAsync(tenantId, subscriptionId, apiVersion, xVersion, tenantApiTenantV1RejectSubscriptionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TenantsApi.RejectTenantSubscriptionAsync: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RejectTenantSubscriptionAsyncWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reject a Tenant Subscription
    ApiResponse<TenantApiTenantV1SubscriptionRejectedResponse> response = apiInstance.RejectTenantSubscriptionAsyncWithHttpInfo(tenantId, subscriptionId, apiVersion, xVersion, tenantApiTenantV1RejectSubscriptionRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TenantsApi.RejectTenantSubscriptionAsyncWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **subscriptionId** | **string** |  |  |
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |
| **tenantApiTenantV1RejectSubscriptionRequest** | [**TenantApiTenantV1RejectSubscriptionRequest?**](TenantApiTenantV1RejectSubscriptionRequest?.md) |  | [optional]  |

### Return type

[**TenantApiTenantV1SubscriptionRejectedResponse**](TenantApiTenantV1SubscriptionRejectedResponse.md)

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
| **200** | The requested resource was successfully retrieved. |  -  |
| **400** | Bad Request. The request was invalid and cannot be completed. See the response body for specific validation errors. This will typically be an issue with the query parameters or the request body values. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatetenantapplicationlaunchersettingsasync"></a>
# **UpdateTenantApplicationLauncherSettingsAsync**
> ApplicationApiApplicationV2ApplicationUpdatedResponse UpdateTenantApplicationLauncherSettingsAsync (string tenantId, string applicationId, string? apiVersion = null, string? xVersion = null, ApplicationApiApplicationV2UpdateApplicationLauncherSettingsRequest? applicationApiApplicationV2UpdateApplicationLauncherSettingsRequest = null)

Update a tenant's application launcher settings

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Management.Client.Api;
using EdGraph.Management.Client.Client;
using EdGraph.Management.Client.Model;

namespace Example
{
    public class UpdateTenantApplicationLauncherSettingsAsyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/management";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TenantsApi(config);
            var tenantId = "tenantId_example";  // string | 
            var applicationId = "applicationId_example";  // string | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 
            var applicationApiApplicationV2UpdateApplicationLauncherSettingsRequest = new ApplicationApiApplicationV2UpdateApplicationLauncherSettingsRequest?(); // ApplicationApiApplicationV2UpdateApplicationLauncherSettingsRequest? |  (optional) 

            try
            {
                // Update a tenant's application launcher settings
                ApplicationApiApplicationV2ApplicationUpdatedResponse result = apiInstance.UpdateTenantApplicationLauncherSettingsAsync(tenantId, applicationId, apiVersion, xVersion, applicationApiApplicationV2UpdateApplicationLauncherSettingsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TenantsApi.UpdateTenantApplicationLauncherSettingsAsync: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateTenantApplicationLauncherSettingsAsyncWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a tenant's application launcher settings
    ApiResponse<ApplicationApiApplicationV2ApplicationUpdatedResponse> response = apiInstance.UpdateTenantApplicationLauncherSettingsAsyncWithHttpInfo(tenantId, applicationId, apiVersion, xVersion, applicationApiApplicationV2UpdateApplicationLauncherSettingsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TenantsApi.UpdateTenantApplicationLauncherSettingsAsyncWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **applicationId** | **string** |  |  |
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |
| **applicationApiApplicationV2UpdateApplicationLauncherSettingsRequest** | [**ApplicationApiApplicationV2UpdateApplicationLauncherSettingsRequest?**](ApplicationApiApplicationV2UpdateApplicationLauncherSettingsRequest?.md) |  | [optional]  |

### Return type

[**ApplicationApiApplicationV2ApplicationUpdatedResponse**](ApplicationApiApplicationV2ApplicationUpdatedResponse.md)

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
| **200** | The requested resource was successfully retrieved. |  -  |
| **400** | Bad Request. The request was invalid and cannot be completed. See the response body for specific validation errors. This will typically be an issue with the query parameters or the request body values. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatetenantapplicationprofileasync"></a>
# **UpdateTenantApplicationProfileAsync**
> ApplicationApiApplicationV2ApplicationUpdatedResponse UpdateTenantApplicationProfileAsync (string tenantId, string applicationId, string? apiVersion = null, string? xVersion = null, ApplicationApiApplicationV2UpdateApplicationProfileRequest? applicationApiApplicationV2UpdateApplicationProfileRequest = null)

Update a tenant's application profile

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Management.Client.Api;
using EdGraph.Management.Client.Client;
using EdGraph.Management.Client.Model;

namespace Example
{
    public class UpdateTenantApplicationProfileAsyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/management";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TenantsApi(config);
            var tenantId = "tenantId_example";  // string | 
            var applicationId = "applicationId_example";  // string | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 
            var applicationApiApplicationV2UpdateApplicationProfileRequest = new ApplicationApiApplicationV2UpdateApplicationProfileRequest?(); // ApplicationApiApplicationV2UpdateApplicationProfileRequest? |  (optional) 

            try
            {
                // Update a tenant's application profile
                ApplicationApiApplicationV2ApplicationUpdatedResponse result = apiInstance.UpdateTenantApplicationProfileAsync(tenantId, applicationId, apiVersion, xVersion, applicationApiApplicationV2UpdateApplicationProfileRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TenantsApi.UpdateTenantApplicationProfileAsync: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateTenantApplicationProfileAsyncWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a tenant's application profile
    ApiResponse<ApplicationApiApplicationV2ApplicationUpdatedResponse> response = apiInstance.UpdateTenantApplicationProfileAsyncWithHttpInfo(tenantId, applicationId, apiVersion, xVersion, applicationApiApplicationV2UpdateApplicationProfileRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TenantsApi.UpdateTenantApplicationProfileAsyncWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **applicationId** | **string** |  |  |
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |
| **applicationApiApplicationV2UpdateApplicationProfileRequest** | [**ApplicationApiApplicationV2UpdateApplicationProfileRequest?**](ApplicationApiApplicationV2UpdateApplicationProfileRequest?.md) |  | [optional]  |

### Return type

[**ApplicationApiApplicationV2ApplicationUpdatedResponse**](ApplicationApiApplicationV2ApplicationUpdatedResponse.md)

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
| **200** | The requested resource was successfully retrieved. |  -  |
| **400** | Bad Request. The request was invalid and cannot be completed. See the response body for specific validation errors. This will typically be an issue with the query parameters or the request body values. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatetenantasync"></a>
# **UpdateTenantAsync**
> TenantApiTenantV1TenantUpdatedResponse UpdateTenantAsync (string tenantId, string? apiVersion = null, string? xVersion = null, TenantApiTenantV1UpdateTenantRequest? tenantApiTenantV1UpdateTenantRequest = null)

Updates a tenant

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Management.Client.Api;
using EdGraph.Management.Client.Client;
using EdGraph.Management.Client.Model;

namespace Example
{
    public class UpdateTenantAsyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/management";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TenantsApi(config);
            var tenantId = "tenantId_example";  // string | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 
            var tenantApiTenantV1UpdateTenantRequest = new TenantApiTenantV1UpdateTenantRequest?(); // TenantApiTenantV1UpdateTenantRequest? |  (optional) 

            try
            {
                // Updates a tenant
                TenantApiTenantV1TenantUpdatedResponse result = apiInstance.UpdateTenantAsync(tenantId, apiVersion, xVersion, tenantApiTenantV1UpdateTenantRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TenantsApi.UpdateTenantAsync: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateTenantAsyncWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a tenant
    ApiResponse<TenantApiTenantV1TenantUpdatedResponse> response = apiInstance.UpdateTenantAsyncWithHttpInfo(tenantId, apiVersion, xVersion, tenantApiTenantV1UpdateTenantRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TenantsApi.UpdateTenantAsyncWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |
| **tenantApiTenantV1UpdateTenantRequest** | [**TenantApiTenantV1UpdateTenantRequest?**](TenantApiTenantV1UpdateTenantRequest?.md) |  | [optional]  |

### Return type

[**TenantApiTenantV1TenantUpdatedResponse**](TenantApiTenantV1TenantUpdatedResponse.md)

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
| **200** | The requested resource was successfully retrieved. |  -  |
| **400** | Bad Request. The request was invalid and cannot be completed. See the response body for specific validation errors. This will typically be an issue with the query parameters or the request body values. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatetenantsubscriptionasync"></a>
# **UpdateTenantSubscriptionAsync**
> TenantApiTenantV1SubscriptionUpdatedResponse UpdateTenantSubscriptionAsync (string tenantId, string subscriptionId, string? apiVersion = null, string? xVersion = null, TenantApiTenantV1UpdateSubscriptionRequest? tenantApiTenantV1UpdateSubscriptionRequest = null)

Updates a Tenant Subscription

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Management.Client.Api;
using EdGraph.Management.Client.Client;
using EdGraph.Management.Client.Model;

namespace Example
{
    public class UpdateTenantSubscriptionAsyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/management";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TenantsApi(config);
            var tenantId = "tenantId_example";  // string | 
            var subscriptionId = "subscriptionId_example";  // string | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 
            var tenantApiTenantV1UpdateSubscriptionRequest = new TenantApiTenantV1UpdateSubscriptionRequest?(); // TenantApiTenantV1UpdateSubscriptionRequest? |  (optional) 

            try
            {
                // Updates a Tenant Subscription
                TenantApiTenantV1SubscriptionUpdatedResponse result = apiInstance.UpdateTenantSubscriptionAsync(tenantId, subscriptionId, apiVersion, xVersion, tenantApiTenantV1UpdateSubscriptionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TenantsApi.UpdateTenantSubscriptionAsync: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateTenantSubscriptionAsyncWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a Tenant Subscription
    ApiResponse<TenantApiTenantV1SubscriptionUpdatedResponse> response = apiInstance.UpdateTenantSubscriptionAsyncWithHttpInfo(tenantId, subscriptionId, apiVersion, xVersion, tenantApiTenantV1UpdateSubscriptionRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TenantsApi.UpdateTenantSubscriptionAsyncWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tenantId** | **string** |  |  |
| **subscriptionId** | **string** |  |  |
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |
| **tenantApiTenantV1UpdateSubscriptionRequest** | [**TenantApiTenantV1UpdateSubscriptionRequest?**](TenantApiTenantV1UpdateSubscriptionRequest?.md) |  | [optional]  |

### Return type

[**TenantApiTenantV1SubscriptionUpdatedResponse**](TenantApiTenantV1SubscriptionUpdatedResponse.md)

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
| **200** | The requested resource was successfully retrieved. |  -  |
| **400** | Bad Request. The request was invalid and cannot be completed. See the response body for specific validation errors. This will typically be an issue with the query parameters or the request body values. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

