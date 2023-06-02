# EdGraph.Management.Client.Api.ApiResourcesApi

All URIs are relative to *https://api.edgraph.com/management*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateApiResourceAsync**](ApiResourcesApi.md#createapiresourceasync) | **POST** /apiresources | Creates a new OpenId Api Resource |
| [**CreateOrUpdateApiResourceAsync**](ApiResourcesApi.md#createorupdateapiresourceasync) | **PUT** /apiresources/{apiResourceId} | Adds or Updates an OpenId Api Resource |
| [**DeleteApiResourceAsync**](ApiResourcesApi.md#deleteapiresourceasync) | **DELETE** /apiresources/{apiResourceId} | Deletes an OpenId Api Resource |
| [**GetAllApiResourcesAsync**](ApiResourcesApi.md#getallapiresourcesasync) | **GET** /apiresources | Retrieves a list of OpenId Api Resources |
| [**GetApiResourceByIdAsync**](ApiResourcesApi.md#getapiresourcebyidasync) | **GET** /apiresources/{apiResourceId} | Retrieves a specific OpenId Api Resource |

<a id="createapiresourceasync"></a>
# **CreateApiResourceAsync**
> EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsResponsesApiResourceResponse CreateApiResourceAsync (string? apiVersion = null, string? xVersion = null, EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsRequestsCreateApiResourceRequest? edGraphHttpAggregatorsManagementApiControllersV1ViewModelsRequestsCreateApiResourceRequest = null)

Creates a new OpenId Api Resource

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Management.Client.Api;
using EdGraph.Management.Client.Client;
using EdGraph.Management.Client.Model;

namespace Example
{
    public class CreateApiResourceAsyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/management";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ApiResourcesApi(config);
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 
            var edGraphHttpAggregatorsManagementApiControllersV1ViewModelsRequestsCreateApiResourceRequest = new EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsRequestsCreateApiResourceRequest?(); // EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsRequestsCreateApiResourceRequest? |  (optional) 

            try
            {
                // Creates a new OpenId Api Resource
                EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsResponsesApiResourceResponse result = apiInstance.CreateApiResourceAsync(apiVersion, xVersion, edGraphHttpAggregatorsManagementApiControllersV1ViewModelsRequestsCreateApiResourceRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ApiResourcesApi.CreateApiResourceAsync: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateApiResourceAsyncWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a new OpenId Api Resource
    ApiResponse<EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsResponsesApiResourceResponse> response = apiInstance.CreateApiResourceAsyncWithHttpInfo(apiVersion, xVersion, edGraphHttpAggregatorsManagementApiControllersV1ViewModelsRequestsCreateApiResourceRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ApiResourcesApi.CreateApiResourceAsyncWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |
| **edGraphHttpAggregatorsManagementApiControllersV1ViewModelsRequestsCreateApiResourceRequest** | [**EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsRequestsCreateApiResourceRequest?**](EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsRequestsCreateApiResourceRequest?.md) |  | [optional]  |

### Return type

[**EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsResponsesApiResourceResponse**](EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsResponsesApiResourceResponse.md)

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

<a id="createorupdateapiresourceasync"></a>
# **CreateOrUpdateApiResourceAsync**
> EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsResponsesApiResourceResponse CreateOrUpdateApiResourceAsync (Guid apiResourceId, string? apiVersion = null, string? xVersion = null, EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsRequestsUpdateApiResourceRequest? edGraphHttpAggregatorsManagementApiControllersV1ViewModelsRequestsUpdateApiResourceRequest = null)

Adds or Updates an OpenId Api Resource

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Management.Client.Api;
using EdGraph.Management.Client.Client;
using EdGraph.Management.Client.Model;

namespace Example
{
    public class CreateOrUpdateApiResourceAsyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/management";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ApiResourcesApi(config);
            var apiResourceId = "apiResourceId_example";  // Guid | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 
            var edGraphHttpAggregatorsManagementApiControllersV1ViewModelsRequestsUpdateApiResourceRequest = new EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsRequestsUpdateApiResourceRequest?(); // EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsRequestsUpdateApiResourceRequest? |  (optional) 

            try
            {
                // Adds or Updates an OpenId Api Resource
                EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsResponsesApiResourceResponse result = apiInstance.CreateOrUpdateApiResourceAsync(apiResourceId, apiVersion, xVersion, edGraphHttpAggregatorsManagementApiControllersV1ViewModelsRequestsUpdateApiResourceRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ApiResourcesApi.CreateOrUpdateApiResourceAsync: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateOrUpdateApiResourceAsyncWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Adds or Updates an OpenId Api Resource
    ApiResponse<EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsResponsesApiResourceResponse> response = apiInstance.CreateOrUpdateApiResourceAsyncWithHttpInfo(apiResourceId, apiVersion, xVersion, edGraphHttpAggregatorsManagementApiControllersV1ViewModelsRequestsUpdateApiResourceRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ApiResourcesApi.CreateOrUpdateApiResourceAsyncWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apiResourceId** | **Guid** |  |  |
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |
| **edGraphHttpAggregatorsManagementApiControllersV1ViewModelsRequestsUpdateApiResourceRequest** | [**EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsRequestsUpdateApiResourceRequest?**](EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsRequestsUpdateApiResourceRequest?.md) |  | [optional]  |

### Return type

[**EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsResponsesApiResourceResponse**](EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsResponsesApiResourceResponse.md)

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

<a id="deleteapiresourceasync"></a>
# **DeleteApiResourceAsync**
> void DeleteApiResourceAsync (Guid apiResourceId, string? apiVersion = null, string? xVersion = null)

Deletes an OpenId Api Resource

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Management.Client.Api;
using EdGraph.Management.Client.Client;
using EdGraph.Management.Client.Model;

namespace Example
{
    public class DeleteApiResourceAsyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/management";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ApiResourcesApi(config);
            var apiResourceId = "apiResourceId_example";  // Guid | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 

            try
            {
                // Deletes an OpenId Api Resource
                apiInstance.DeleteApiResourceAsync(apiResourceId, apiVersion, xVersion);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ApiResourcesApi.DeleteApiResourceAsync: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteApiResourceAsyncWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes an OpenId Api Resource
    apiInstance.DeleteApiResourceAsyncWithHttpInfo(apiResourceId, apiVersion, xVersion);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ApiResourcesApi.DeleteApiResourceAsyncWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apiResourceId** | **Guid** |  |  |
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

<a id="getallapiresourcesasync"></a>
# **GetAllApiResourcesAsync**
> EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsResponsesApiResourceResponsePaginatedItemsViewModel GetAllApiResourcesAsync (int? pageSize = null, int? pageIndex = null, string? orderBy = null, string? filter = null, string? apiVersion = null, string? xVersion = null)

Retrieves a list of OpenId Api Resources

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Management.Client.Api;
using EdGraph.Management.Client.Client;
using EdGraph.Management.Client.Model;

namespace Example
{
    public class GetAllApiResourcesAsyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/management";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ApiResourcesApi(config);
            var pageSize = 10;  // int? |  (optional)  (default to 10)
            var pageIndex = 0;  // int? |  (optional)  (default to 0)
            var orderBy = "\"Name ASC\"";  // string? |  (optional)  (default to "Name ASC")
            var filter = "\"\"";  // string? |  (optional)  (default to "")
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 

            try
            {
                // Retrieves a list of OpenId Api Resources
                EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsResponsesApiResourceResponsePaginatedItemsViewModel result = apiInstance.GetAllApiResourcesAsync(pageSize, pageIndex, orderBy, filter, apiVersion, xVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ApiResourcesApi.GetAllApiResourcesAsync: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAllApiResourcesAsyncWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a list of OpenId Api Resources
    ApiResponse<EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsResponsesApiResourceResponsePaginatedItemsViewModel> response = apiInstance.GetAllApiResourcesAsyncWithHttpInfo(pageSize, pageIndex, orderBy, filter, apiVersion, xVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ApiResourcesApi.GetAllApiResourcesAsyncWithHttpInfo: " + e.Message);
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

[**EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsResponsesApiResourceResponsePaginatedItemsViewModel**](EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsResponsesApiResourceResponsePaginatedItemsViewModel.md)

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

<a id="getapiresourcebyidasync"></a>
# **GetApiResourceByIdAsync**
> EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsResponsesApiResourceResponse GetApiResourceByIdAsync (Guid apiResourceId, string? apiVersion = null, string? xVersion = null)

Retrieves a specific OpenId Api Resource

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Management.Client.Api;
using EdGraph.Management.Client.Client;
using EdGraph.Management.Client.Model;

namespace Example
{
    public class GetApiResourceByIdAsyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/management";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ApiResourcesApi(config);
            var apiResourceId = "apiResourceId_example";  // Guid | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 

            try
            {
                // Retrieves a specific OpenId Api Resource
                EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsResponsesApiResourceResponse result = apiInstance.GetApiResourceByIdAsync(apiResourceId, apiVersion, xVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ApiResourcesApi.GetApiResourceByIdAsync: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetApiResourceByIdAsyncWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a specific OpenId Api Resource
    ApiResponse<EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsResponsesApiResourceResponse> response = apiInstance.GetApiResourceByIdAsyncWithHttpInfo(apiResourceId, apiVersion, xVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ApiResourcesApi.GetApiResourceByIdAsyncWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apiResourceId** | **Guid** |  |  |
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |

### Return type

[**EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsResponsesApiResourceResponse**](EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsResponsesApiResourceResponse.md)

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

