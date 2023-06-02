# EdGraph.Management.Client.Api.IdentityResourcesApi

All URIs are relative to *https://api.edgraph.com/management*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateIdentityResourceAsync**](IdentityResourcesApi.md#createidentityresourceasync) | **POST** /identityresources | Creates a new OpenId Identity Resource |
| [**CreateOrUpdateIdentityResourceAsync**](IdentityResourcesApi.md#createorupdateidentityresourceasync) | **PUT** /identityresources/{identityResourceId} | Adds or Updates an OpenId Identity Resource |
| [**DeleteIdentityResourceAsync**](IdentityResourcesApi.md#deleteidentityresourceasync) | **DELETE** /identityresources/{identityResourceId} | Deletes an OpenId Identity Resource |
| [**GetAllIdentityResourcesAsync**](IdentityResourcesApi.md#getallidentityresourcesasync) | **GET** /identityresources | Retrieves a list of OpenId Identity Resources |
| [**GetIdentityResourceByIdAsync**](IdentityResourcesApi.md#getidentityresourcebyidasync) | **GET** /identityresources/{identityResourceId} | Retrieves a specific OpenId Identity Resource |

<a id="createidentityresourceasync"></a>
# **CreateIdentityResourceAsync**
> EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsResponsesIdentityResourceResponse CreateIdentityResourceAsync (string? apiVersion = null, string? xVersion = null, EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsRequestsCreateIdentityResourceRequest? edGraphHttpAggregatorsManagementApiControllersV1ViewModelsRequestsCreateIdentityResourceRequest = null)

Creates a new OpenId Identity Resource

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Management.Client.Api;
using EdGraph.Management.Client.Client;
using EdGraph.Management.Client.Model;

namespace Example
{
    public class CreateIdentityResourceAsyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/management";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IdentityResourcesApi(config);
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 
            var edGraphHttpAggregatorsManagementApiControllersV1ViewModelsRequestsCreateIdentityResourceRequest = new EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsRequestsCreateIdentityResourceRequest?(); // EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsRequestsCreateIdentityResourceRequest? |  (optional) 

            try
            {
                // Creates a new OpenId Identity Resource
                EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsResponsesIdentityResourceResponse result = apiInstance.CreateIdentityResourceAsync(apiVersion, xVersion, edGraphHttpAggregatorsManagementApiControllersV1ViewModelsRequestsCreateIdentityResourceRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IdentityResourcesApi.CreateIdentityResourceAsync: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateIdentityResourceAsyncWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a new OpenId Identity Resource
    ApiResponse<EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsResponsesIdentityResourceResponse> response = apiInstance.CreateIdentityResourceAsyncWithHttpInfo(apiVersion, xVersion, edGraphHttpAggregatorsManagementApiControllersV1ViewModelsRequestsCreateIdentityResourceRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IdentityResourcesApi.CreateIdentityResourceAsyncWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |
| **edGraphHttpAggregatorsManagementApiControllersV1ViewModelsRequestsCreateIdentityResourceRequest** | [**EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsRequestsCreateIdentityResourceRequest?**](EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsRequestsCreateIdentityResourceRequest?.md) |  | [optional]  |

### Return type

[**EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsResponsesIdentityResourceResponse**](EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsResponsesIdentityResourceResponse.md)

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

<a id="createorupdateidentityresourceasync"></a>
# **CreateOrUpdateIdentityResourceAsync**
> EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsResponsesIdentityResourceResponse CreateOrUpdateIdentityResourceAsync (Guid identityResourceId, string? apiVersion = null, string? xVersion = null, EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsRequestsUpdateIdentityResourceRequest? edGraphHttpAggregatorsManagementApiControllersV1ViewModelsRequestsUpdateIdentityResourceRequest = null)

Adds or Updates an OpenId Identity Resource

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Management.Client.Api;
using EdGraph.Management.Client.Client;
using EdGraph.Management.Client.Model;

namespace Example
{
    public class CreateOrUpdateIdentityResourceAsyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/management";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IdentityResourcesApi(config);
            var identityResourceId = "identityResourceId_example";  // Guid | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 
            var edGraphHttpAggregatorsManagementApiControllersV1ViewModelsRequestsUpdateIdentityResourceRequest = new EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsRequestsUpdateIdentityResourceRequest?(); // EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsRequestsUpdateIdentityResourceRequest? |  (optional) 

            try
            {
                // Adds or Updates an OpenId Identity Resource
                EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsResponsesIdentityResourceResponse result = apiInstance.CreateOrUpdateIdentityResourceAsync(identityResourceId, apiVersion, xVersion, edGraphHttpAggregatorsManagementApiControllersV1ViewModelsRequestsUpdateIdentityResourceRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IdentityResourcesApi.CreateOrUpdateIdentityResourceAsync: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateOrUpdateIdentityResourceAsyncWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Adds or Updates an OpenId Identity Resource
    ApiResponse<EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsResponsesIdentityResourceResponse> response = apiInstance.CreateOrUpdateIdentityResourceAsyncWithHttpInfo(identityResourceId, apiVersion, xVersion, edGraphHttpAggregatorsManagementApiControllersV1ViewModelsRequestsUpdateIdentityResourceRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IdentityResourcesApi.CreateOrUpdateIdentityResourceAsyncWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **identityResourceId** | **Guid** |  |  |
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |
| **edGraphHttpAggregatorsManagementApiControllersV1ViewModelsRequestsUpdateIdentityResourceRequest** | [**EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsRequestsUpdateIdentityResourceRequest?**](EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsRequestsUpdateIdentityResourceRequest?.md) |  | [optional]  |

### Return type

[**EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsResponsesIdentityResourceResponse**](EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsResponsesIdentityResourceResponse.md)

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

<a id="deleteidentityresourceasync"></a>
# **DeleteIdentityResourceAsync**
> void DeleteIdentityResourceAsync (Guid identityResourceId, string? apiVersion = null, string? xVersion = null)

Deletes an OpenId Identity Resource

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Management.Client.Api;
using EdGraph.Management.Client.Client;
using EdGraph.Management.Client.Model;

namespace Example
{
    public class DeleteIdentityResourceAsyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/management";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IdentityResourcesApi(config);
            var identityResourceId = "identityResourceId_example";  // Guid | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 

            try
            {
                // Deletes an OpenId Identity Resource
                apiInstance.DeleteIdentityResourceAsync(identityResourceId, apiVersion, xVersion);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IdentityResourcesApi.DeleteIdentityResourceAsync: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteIdentityResourceAsyncWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes an OpenId Identity Resource
    apiInstance.DeleteIdentityResourceAsyncWithHttpInfo(identityResourceId, apiVersion, xVersion);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IdentityResourcesApi.DeleteIdentityResourceAsyncWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **identityResourceId** | **Guid** |  |  |
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
| **204** | The resource was successfully deleted. |  -  |
| **400** | Bad Request. The request was invalid and cannot be completed. See the response body for specific validation errors. This will typically be an issue with the query parameters or the request body values. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getallidentityresourcesasync"></a>
# **GetAllIdentityResourcesAsync**
> EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsResponsesIdentityResourceResponsePaginatedItemsViewModel GetAllIdentityResourcesAsync (int? pageSize = null, int? pageIndex = null, string? orderBy = null, string? filter = null, string? apiVersion = null, string? xVersion = null)

Retrieves a list of OpenId Identity Resources

Referenced from IdentityServer4

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Management.Client.Api;
using EdGraph.Management.Client.Client;
using EdGraph.Management.Client.Model;

namespace Example
{
    public class GetAllIdentityResourcesAsyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/management";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IdentityResourcesApi(config);
            var pageSize = 10;  // int? |  (optional)  (default to 10)
            var pageIndex = 0;  // int? |  (optional)  (default to 0)
            var orderBy = "\"Name ASC\"";  // string? |  (optional)  (default to "Name ASC")
            var filter = "\"\"";  // string? |  (optional)  (default to "")
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 

            try
            {
                // Retrieves a list of OpenId Identity Resources
                EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsResponsesIdentityResourceResponsePaginatedItemsViewModel result = apiInstance.GetAllIdentityResourcesAsync(pageSize, pageIndex, orderBy, filter, apiVersion, xVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IdentityResourcesApi.GetAllIdentityResourcesAsync: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAllIdentityResourcesAsyncWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a list of OpenId Identity Resources
    ApiResponse<EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsResponsesIdentityResourceResponsePaginatedItemsViewModel> response = apiInstance.GetAllIdentityResourcesAsyncWithHttpInfo(pageSize, pageIndex, orderBy, filter, apiVersion, xVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IdentityResourcesApi.GetAllIdentityResourcesAsyncWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pageSize** | **int?** |  | [optional] [default to 10] |
| **pageIndex** | **int?** |  | [optional] [default to 0] |
| **orderBy** | **string?** |  | [optional] [default to &quot;Name ASC&quot;] |
| **filter** | **string?** |  | [optional] [default to &quot;&quot;] |
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |

### Return type

[**EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsResponsesIdentityResourceResponsePaginatedItemsViewModel**](EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsResponsesIdentityResourceResponsePaginatedItemsViewModel.md)

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

<a id="getidentityresourcebyidasync"></a>
# **GetIdentityResourceByIdAsync**
> EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsResponsesIdentityResourceResponse GetIdentityResourceByIdAsync (Guid identityResourceId, string? apiVersion = null, string? xVersion = null)

Retrieves a specific OpenId Identity Resource

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Management.Client.Api;
using EdGraph.Management.Client.Client;
using EdGraph.Management.Client.Model;

namespace Example
{
    public class GetIdentityResourceByIdAsyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/management";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IdentityResourcesApi(config);
            var identityResourceId = "identityResourceId_example";  // Guid | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 

            try
            {
                // Retrieves a specific OpenId Identity Resource
                EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsResponsesIdentityResourceResponse result = apiInstance.GetIdentityResourceByIdAsync(identityResourceId, apiVersion, xVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IdentityResourcesApi.GetIdentityResourceByIdAsync: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetIdentityResourceByIdAsyncWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a specific OpenId Identity Resource
    ApiResponse<EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsResponsesIdentityResourceResponse> response = apiInstance.GetIdentityResourceByIdAsyncWithHttpInfo(identityResourceId, apiVersion, xVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IdentityResourcesApi.GetIdentityResourceByIdAsyncWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **identityResourceId** | **Guid** |  |  |
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |

### Return type

[**EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsResponsesIdentityResourceResponse**](EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsResponsesIdentityResourceResponse.md)

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

