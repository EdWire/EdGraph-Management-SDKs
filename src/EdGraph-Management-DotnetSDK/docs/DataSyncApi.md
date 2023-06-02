# EdGraph.Management.Client.Api.DataSyncApi

All URIs are relative to *https://api.edgraph.com/management*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateDataSyncConnectionTypeAsync**](DataSyncApi.md#createdatasyncconnectiontypeasync) | **POST** /datasync/providers/{providerId}/connectiontypes | Creates a new connection type assigned to the DataSync provider |
| [**CreateDataSyncJobTypeAsync**](DataSyncApi.md#createdatasyncjobtypeasync) | **POST** /datasync/jobtypes | Creates a new DataSync job type |
| [**CreateDataSyncProfileAsync**](DataSyncApi.md#createdatasyncprofileasync) | **POST** /datasync/jobtypes/{jobTypeId}/profiles | Creates a new profile assigned to the DataSync job type |
| [**CreateDataSyncProviderAsync**](DataSyncApi.md#createdatasyncproviderasync) | **POST** /datasync/providers | Creates a new DataSync provider |
| [**DeleteDataSyncConnectionTypeAsync**](DataSyncApi.md#deletedatasyncconnectiontypeasync) | **DELETE** /datasync/providers/{providerId}/connectiontypes/{connectionTypeId} | Delete a connection type assigned to the DataSync provider |
| [**DeleteDataSyncJobTypeAsync**](DataSyncApi.md#deletedatasyncjobtypeasync) | **DELETE** /datasync/jobtypes/{jobTypeId} | Delete a DataSync job type |
| [**DeleteDataSyncProfileAsync**](DataSyncApi.md#deletedatasyncprofileasync) | **DELETE** /datasync/jobtypes/{jobTypeId}/profiles/{profileId} | Delete a profile assigned to the DataSync job type |
| [**DeleteDataSyncProviderAsync**](DataSyncApi.md#deletedatasyncproviderasync) | **DELETE** /datasync/providers/{providerId} | Delete a DataSync provider |
| [**GetAllDataSyncJobTypesAsync**](DataSyncApi.md#getalldatasyncjobtypesasync) | **GET** /datasync/jobtypes | Retrieves a list of DataSync job types |
| [**GetAllDataSyncProvidersAsync**](DataSyncApi.md#getalldatasyncprovidersasync) | **GET** /datasync/providers | Retrieves a list of DataSync providers |
| [**GetDataSyncJobTypeProfileByIdAsync**](DataSyncApi.md#getdatasyncjobtypeprofilebyidasync) | **GET** /datasync/jobtypes/{jobTypeId} | Retrieves a specific DataSync job type |
| [**GetDataSyncProviderProfileByIdAsync**](DataSyncApi.md#getdatasyncproviderprofilebyidasync) | **GET** /datasync/providers/{providerId} | Retrieves a specific DataSync provider |
| [**UpdateDataSyncConnectionTypeAsync**](DataSyncApi.md#updatedatasyncconnectiontypeasync) | **PUT** /datasync/providers/{providerId}/connectiontypes/{connectionTypeId} | Updates a connection type assigned to the DataSync provider |
| [**UpdateDataSyncJobTypeAsync**](DataSyncApi.md#updatedatasyncjobtypeasync) | **PUT** /datasync/jobtypes/{jobTypeId} | Updates a DataSync job type |
| [**UpdateDataSyncProfileAsync**](DataSyncApi.md#updatedatasyncprofileasync) | **PUT** /datasync/jobtypes/{jobTypeId}/profiles/{profileId} | Updates a profile assigned to the DataSync job type |
| [**UpdateDataSyncProviderAsync**](DataSyncApi.md#updatedatasyncproviderasync) | **PUT** /datasync/providers/{providerId} | Updates a DataSync provider |

<a id="createdatasyncconnectiontypeasync"></a>
# **CreateDataSyncConnectionTypeAsync**
> DataSyncApiProviderV1ConnectionTypeCreatedResponse CreateDataSyncConnectionTypeAsync (string providerId, string? apiVersion = null, string? xVersion = null, DataSyncApiProviderV1CreateConnectionTypeRequest? dataSyncApiProviderV1CreateConnectionTypeRequest = null)

Creates a new connection type assigned to the DataSync provider

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Management.Client.Api;
using EdGraph.Management.Client.Client;
using EdGraph.Management.Client.Model;

namespace Example
{
    public class CreateDataSyncConnectionTypeAsyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/management";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DataSyncApi(config);
            var providerId = "providerId_example";  // string | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 
            var dataSyncApiProviderV1CreateConnectionTypeRequest = new DataSyncApiProviderV1CreateConnectionTypeRequest?(); // DataSyncApiProviderV1CreateConnectionTypeRequest? |  (optional) 

            try
            {
                // Creates a new connection type assigned to the DataSync provider
                DataSyncApiProviderV1ConnectionTypeCreatedResponse result = apiInstance.CreateDataSyncConnectionTypeAsync(providerId, apiVersion, xVersion, dataSyncApiProviderV1CreateConnectionTypeRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataSyncApi.CreateDataSyncConnectionTypeAsync: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateDataSyncConnectionTypeAsyncWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a new connection type assigned to the DataSync provider
    ApiResponse<DataSyncApiProviderV1ConnectionTypeCreatedResponse> response = apiInstance.CreateDataSyncConnectionTypeAsyncWithHttpInfo(providerId, apiVersion, xVersion, dataSyncApiProviderV1CreateConnectionTypeRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataSyncApi.CreateDataSyncConnectionTypeAsyncWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **providerId** | **string** |  |  |
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |
| **dataSyncApiProviderV1CreateConnectionTypeRequest** | [**DataSyncApiProviderV1CreateConnectionTypeRequest?**](DataSyncApiProviderV1CreateConnectionTypeRequest?.md) |  | [optional]  |

### Return type

[**DataSyncApiProviderV1ConnectionTypeCreatedResponse**](DataSyncApiProviderV1ConnectionTypeCreatedResponse.md)

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

<a id="createdatasyncjobtypeasync"></a>
# **CreateDataSyncJobTypeAsync**
> DataSyncApiJobTypeV1JobTypeCreatedResponse CreateDataSyncJobTypeAsync (string? apiVersion = null, string? xVersion = null, DataSyncApiJobTypeV1CreateJobTypeRequest? dataSyncApiJobTypeV1CreateJobTypeRequest = null)

Creates a new DataSync job type

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Management.Client.Api;
using EdGraph.Management.Client.Client;
using EdGraph.Management.Client.Model;

namespace Example
{
    public class CreateDataSyncJobTypeAsyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/management";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DataSyncApi(config);
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 
            var dataSyncApiJobTypeV1CreateJobTypeRequest = new DataSyncApiJobTypeV1CreateJobTypeRequest?(); // DataSyncApiJobTypeV1CreateJobTypeRequest? |  (optional) 

            try
            {
                // Creates a new DataSync job type
                DataSyncApiJobTypeV1JobTypeCreatedResponse result = apiInstance.CreateDataSyncJobTypeAsync(apiVersion, xVersion, dataSyncApiJobTypeV1CreateJobTypeRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataSyncApi.CreateDataSyncJobTypeAsync: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateDataSyncJobTypeAsyncWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a new DataSync job type
    ApiResponse<DataSyncApiJobTypeV1JobTypeCreatedResponse> response = apiInstance.CreateDataSyncJobTypeAsyncWithHttpInfo(apiVersion, xVersion, dataSyncApiJobTypeV1CreateJobTypeRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataSyncApi.CreateDataSyncJobTypeAsyncWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |
| **dataSyncApiJobTypeV1CreateJobTypeRequest** | [**DataSyncApiJobTypeV1CreateJobTypeRequest?**](DataSyncApiJobTypeV1CreateJobTypeRequest?.md) |  | [optional]  |

### Return type

[**DataSyncApiJobTypeV1JobTypeCreatedResponse**](DataSyncApiJobTypeV1JobTypeCreatedResponse.md)

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

<a id="createdatasyncprofileasync"></a>
# **CreateDataSyncProfileAsync**
> DataSyncApiJobTypeV1ProfileCreatedResponse CreateDataSyncProfileAsync (string jobTypeId, string? apiVersion = null, string? xVersion = null, DataSyncApiJobTypeV1CreateProfileRequest? dataSyncApiJobTypeV1CreateProfileRequest = null)

Creates a new profile assigned to the DataSync job type

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Management.Client.Api;
using EdGraph.Management.Client.Client;
using EdGraph.Management.Client.Model;

namespace Example
{
    public class CreateDataSyncProfileAsyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/management";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DataSyncApi(config);
            var jobTypeId = "jobTypeId_example";  // string | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 
            var dataSyncApiJobTypeV1CreateProfileRequest = new DataSyncApiJobTypeV1CreateProfileRequest?(); // DataSyncApiJobTypeV1CreateProfileRequest? |  (optional) 

            try
            {
                // Creates a new profile assigned to the DataSync job type
                DataSyncApiJobTypeV1ProfileCreatedResponse result = apiInstance.CreateDataSyncProfileAsync(jobTypeId, apiVersion, xVersion, dataSyncApiJobTypeV1CreateProfileRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataSyncApi.CreateDataSyncProfileAsync: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateDataSyncProfileAsyncWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a new profile assigned to the DataSync job type
    ApiResponse<DataSyncApiJobTypeV1ProfileCreatedResponse> response = apiInstance.CreateDataSyncProfileAsyncWithHttpInfo(jobTypeId, apiVersion, xVersion, dataSyncApiJobTypeV1CreateProfileRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataSyncApi.CreateDataSyncProfileAsyncWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **jobTypeId** | **string** |  |  |
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |
| **dataSyncApiJobTypeV1CreateProfileRequest** | [**DataSyncApiJobTypeV1CreateProfileRequest?**](DataSyncApiJobTypeV1CreateProfileRequest?.md) |  | [optional]  |

### Return type

[**DataSyncApiJobTypeV1ProfileCreatedResponse**](DataSyncApiJobTypeV1ProfileCreatedResponse.md)

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

<a id="createdatasyncproviderasync"></a>
# **CreateDataSyncProviderAsync**
> DataSyncApiProviderV1ProviderCreatedResponse CreateDataSyncProviderAsync (string? apiVersion = null, string? xVersion = null, DataSyncApiProviderV1CreateProviderRequest? dataSyncApiProviderV1CreateProviderRequest = null)

Creates a new DataSync provider

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Management.Client.Api;
using EdGraph.Management.Client.Client;
using EdGraph.Management.Client.Model;

namespace Example
{
    public class CreateDataSyncProviderAsyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/management";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DataSyncApi(config);
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 
            var dataSyncApiProviderV1CreateProviderRequest = new DataSyncApiProviderV1CreateProviderRequest?(); // DataSyncApiProviderV1CreateProviderRequest? |  (optional) 

            try
            {
                // Creates a new DataSync provider
                DataSyncApiProviderV1ProviderCreatedResponse result = apiInstance.CreateDataSyncProviderAsync(apiVersion, xVersion, dataSyncApiProviderV1CreateProviderRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataSyncApi.CreateDataSyncProviderAsync: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateDataSyncProviderAsyncWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a new DataSync provider
    ApiResponse<DataSyncApiProviderV1ProviderCreatedResponse> response = apiInstance.CreateDataSyncProviderAsyncWithHttpInfo(apiVersion, xVersion, dataSyncApiProviderV1CreateProviderRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataSyncApi.CreateDataSyncProviderAsyncWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |
| **dataSyncApiProviderV1CreateProviderRequest** | [**DataSyncApiProviderV1CreateProviderRequest?**](DataSyncApiProviderV1CreateProviderRequest?.md) |  | [optional]  |

### Return type

[**DataSyncApiProviderV1ProviderCreatedResponse**](DataSyncApiProviderV1ProviderCreatedResponse.md)

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

<a id="deletedatasyncconnectiontypeasync"></a>
# **DeleteDataSyncConnectionTypeAsync**
> void DeleteDataSyncConnectionTypeAsync (string providerId, string connectionTypeId, string? apiVersion = null, string? xVersion = null, DataSyncApiProviderV1DeleteConnectionTypeRequest? dataSyncApiProviderV1DeleteConnectionTypeRequest = null)

Delete a connection type assigned to the DataSync provider

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Management.Client.Api;
using EdGraph.Management.Client.Client;
using EdGraph.Management.Client.Model;

namespace Example
{
    public class DeleteDataSyncConnectionTypeAsyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/management";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DataSyncApi(config);
            var providerId = "providerId_example";  // string | 
            var connectionTypeId = "connectionTypeId_example";  // string | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 
            var dataSyncApiProviderV1DeleteConnectionTypeRequest = new DataSyncApiProviderV1DeleteConnectionTypeRequest?(); // DataSyncApiProviderV1DeleteConnectionTypeRequest? |  (optional) 

            try
            {
                // Delete a connection type assigned to the DataSync provider
                apiInstance.DeleteDataSyncConnectionTypeAsync(providerId, connectionTypeId, apiVersion, xVersion, dataSyncApiProviderV1DeleteConnectionTypeRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataSyncApi.DeleteDataSyncConnectionTypeAsync: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteDataSyncConnectionTypeAsyncWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a connection type assigned to the DataSync provider
    apiInstance.DeleteDataSyncConnectionTypeAsyncWithHttpInfo(providerId, connectionTypeId, apiVersion, xVersion, dataSyncApiProviderV1DeleteConnectionTypeRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataSyncApi.DeleteDataSyncConnectionTypeAsyncWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **providerId** | **string** |  |  |
| **connectionTypeId** | **string** |  |  |
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |
| **dataSyncApiProviderV1DeleteConnectionTypeRequest** | [**DataSyncApiProviderV1DeleteConnectionTypeRequest?**](DataSyncApiProviderV1DeleteConnectionTypeRequest?.md) |  | [optional]  |

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

<a id="deletedatasyncjobtypeasync"></a>
# **DeleteDataSyncJobTypeAsync**
> void DeleteDataSyncJobTypeAsync (string jobTypeId, string? apiVersion = null, string? xVersion = null, DataSyncApiJobTypeV1DeleteJobTypeRequest? dataSyncApiJobTypeV1DeleteJobTypeRequest = null)

Delete a DataSync job type

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Management.Client.Api;
using EdGraph.Management.Client.Client;
using EdGraph.Management.Client.Model;

namespace Example
{
    public class DeleteDataSyncJobTypeAsyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/management";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DataSyncApi(config);
            var jobTypeId = "jobTypeId_example";  // string | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 
            var dataSyncApiJobTypeV1DeleteJobTypeRequest = new DataSyncApiJobTypeV1DeleteJobTypeRequest?(); // DataSyncApiJobTypeV1DeleteJobTypeRequest? |  (optional) 

            try
            {
                // Delete a DataSync job type
                apiInstance.DeleteDataSyncJobTypeAsync(jobTypeId, apiVersion, xVersion, dataSyncApiJobTypeV1DeleteJobTypeRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataSyncApi.DeleteDataSyncJobTypeAsync: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteDataSyncJobTypeAsyncWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a DataSync job type
    apiInstance.DeleteDataSyncJobTypeAsyncWithHttpInfo(jobTypeId, apiVersion, xVersion, dataSyncApiJobTypeV1DeleteJobTypeRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataSyncApi.DeleteDataSyncJobTypeAsyncWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **jobTypeId** | **string** |  |  |
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |
| **dataSyncApiJobTypeV1DeleteJobTypeRequest** | [**DataSyncApiJobTypeV1DeleteJobTypeRequest?**](DataSyncApiJobTypeV1DeleteJobTypeRequest?.md) |  | [optional]  |

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

<a id="deletedatasyncprofileasync"></a>
# **DeleteDataSyncProfileAsync**
> void DeleteDataSyncProfileAsync (string jobTypeId, string profileId, string? apiVersion = null, string? xVersion = null, DataSyncApiJobTypeV1DeleteProfileRequest? dataSyncApiJobTypeV1DeleteProfileRequest = null)

Delete a profile assigned to the DataSync job type

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Management.Client.Api;
using EdGraph.Management.Client.Client;
using EdGraph.Management.Client.Model;

namespace Example
{
    public class DeleteDataSyncProfileAsyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/management";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DataSyncApi(config);
            var jobTypeId = "jobTypeId_example";  // string | 
            var profileId = "profileId_example";  // string | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 
            var dataSyncApiJobTypeV1DeleteProfileRequest = new DataSyncApiJobTypeV1DeleteProfileRequest?(); // DataSyncApiJobTypeV1DeleteProfileRequest? |  (optional) 

            try
            {
                // Delete a profile assigned to the DataSync job type
                apiInstance.DeleteDataSyncProfileAsync(jobTypeId, profileId, apiVersion, xVersion, dataSyncApiJobTypeV1DeleteProfileRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataSyncApi.DeleteDataSyncProfileAsync: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteDataSyncProfileAsyncWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a profile assigned to the DataSync job type
    apiInstance.DeleteDataSyncProfileAsyncWithHttpInfo(jobTypeId, profileId, apiVersion, xVersion, dataSyncApiJobTypeV1DeleteProfileRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataSyncApi.DeleteDataSyncProfileAsyncWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **jobTypeId** | **string** |  |  |
| **profileId** | **string** |  |  |
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |
| **dataSyncApiJobTypeV1DeleteProfileRequest** | [**DataSyncApiJobTypeV1DeleteProfileRequest?**](DataSyncApiJobTypeV1DeleteProfileRequest?.md) |  | [optional]  |

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

<a id="deletedatasyncproviderasync"></a>
# **DeleteDataSyncProviderAsync**
> void DeleteDataSyncProviderAsync (string providerId, string? apiVersion = null, string? xVersion = null, DataSyncApiProviderV1DeleteProviderRequest? dataSyncApiProviderV1DeleteProviderRequest = null)

Delete a DataSync provider

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Management.Client.Api;
using EdGraph.Management.Client.Client;
using EdGraph.Management.Client.Model;

namespace Example
{
    public class DeleteDataSyncProviderAsyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/management";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DataSyncApi(config);
            var providerId = "providerId_example";  // string | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 
            var dataSyncApiProviderV1DeleteProviderRequest = new DataSyncApiProviderV1DeleteProviderRequest?(); // DataSyncApiProviderV1DeleteProviderRequest? |  (optional) 

            try
            {
                // Delete a DataSync provider
                apiInstance.DeleteDataSyncProviderAsync(providerId, apiVersion, xVersion, dataSyncApiProviderV1DeleteProviderRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataSyncApi.DeleteDataSyncProviderAsync: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteDataSyncProviderAsyncWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a DataSync provider
    apiInstance.DeleteDataSyncProviderAsyncWithHttpInfo(providerId, apiVersion, xVersion, dataSyncApiProviderV1DeleteProviderRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataSyncApi.DeleteDataSyncProviderAsyncWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **providerId** | **string** |  |  |
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |
| **dataSyncApiProviderV1DeleteProviderRequest** | [**DataSyncApiProviderV1DeleteProviderRequest?**](DataSyncApiProviderV1DeleteProviderRequest?.md) |  | [optional]  |

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

<a id="getalldatasyncjobtypesasync"></a>
# **GetAllDataSyncJobTypesAsync**
> DataSyncApiJobTypeV1JobTypeListResponsePaginatedItemsViewModel GetAllDataSyncJobTypesAsync (int? pageSize = null, int? pageIndex = null, string? orderBy = null, string? filter = null, string? apiVersion = null, string? xVersion = null)

Retrieves a list of DataSync job types

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Management.Client.Api;
using EdGraph.Management.Client.Client;
using EdGraph.Management.Client.Model;

namespace Example
{
    public class GetAllDataSyncJobTypesAsyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/management";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DataSyncApi(config);
            var pageSize = 10;  // int? |  (optional)  (default to 10)
            var pageIndex = 0;  // int? |  (optional)  (default to 0)
            var orderBy = "\"\"";  // string? |  (optional)  (default to "")
            var filter = "\"\"";  // string? |  (optional)  (default to "")
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 

            try
            {
                // Retrieves a list of DataSync job types
                DataSyncApiJobTypeV1JobTypeListResponsePaginatedItemsViewModel result = apiInstance.GetAllDataSyncJobTypesAsync(pageSize, pageIndex, orderBy, filter, apiVersion, xVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataSyncApi.GetAllDataSyncJobTypesAsync: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAllDataSyncJobTypesAsyncWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a list of DataSync job types
    ApiResponse<DataSyncApiJobTypeV1JobTypeListResponsePaginatedItemsViewModel> response = apiInstance.GetAllDataSyncJobTypesAsyncWithHttpInfo(pageSize, pageIndex, orderBy, filter, apiVersion, xVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataSyncApi.GetAllDataSyncJobTypesAsyncWithHttpInfo: " + e.Message);
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

[**DataSyncApiJobTypeV1JobTypeListResponsePaginatedItemsViewModel**](DataSyncApiJobTypeV1JobTypeListResponsePaginatedItemsViewModel.md)

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

<a id="getalldatasyncprovidersasync"></a>
# **GetAllDataSyncProvidersAsync**
> DataSyncApiProviderV1ProviderListResponsePaginatedItemsViewModel GetAllDataSyncProvidersAsync (int? pageSize = null, int? pageIndex = null, string? orderBy = null, string? filter = null, string? apiVersion = null, string? xVersion = null)

Retrieves a list of DataSync providers

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Management.Client.Api;
using EdGraph.Management.Client.Client;
using EdGraph.Management.Client.Model;

namespace Example
{
    public class GetAllDataSyncProvidersAsyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/management";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DataSyncApi(config);
            var pageSize = 10;  // int? |  (optional)  (default to 10)
            var pageIndex = 0;  // int? |  (optional)  (default to 0)
            var orderBy = "\"\"";  // string? |  (optional)  (default to "")
            var filter = "\"\"";  // string? |  (optional)  (default to "")
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 

            try
            {
                // Retrieves a list of DataSync providers
                DataSyncApiProviderV1ProviderListResponsePaginatedItemsViewModel result = apiInstance.GetAllDataSyncProvidersAsync(pageSize, pageIndex, orderBy, filter, apiVersion, xVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataSyncApi.GetAllDataSyncProvidersAsync: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAllDataSyncProvidersAsyncWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a list of DataSync providers
    ApiResponse<DataSyncApiProviderV1ProviderListResponsePaginatedItemsViewModel> response = apiInstance.GetAllDataSyncProvidersAsyncWithHttpInfo(pageSize, pageIndex, orderBy, filter, apiVersion, xVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataSyncApi.GetAllDataSyncProvidersAsyncWithHttpInfo: " + e.Message);
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

[**DataSyncApiProviderV1ProviderListResponsePaginatedItemsViewModel**](DataSyncApiProviderV1ProviderListResponsePaginatedItemsViewModel.md)

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

<a id="getdatasyncjobtypeprofilebyidasync"></a>
# **GetDataSyncJobTypeProfileByIdAsync**
> DataSyncApiJobTypeV1JobTypeProfileResponse GetDataSyncJobTypeProfileByIdAsync (string jobTypeId, string? apiVersion = null, string? xVersion = null)

Retrieves a specific DataSync job type

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Management.Client.Api;
using EdGraph.Management.Client.Client;
using EdGraph.Management.Client.Model;

namespace Example
{
    public class GetDataSyncJobTypeProfileByIdAsyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/management";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DataSyncApi(config);
            var jobTypeId = "jobTypeId_example";  // string | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 

            try
            {
                // Retrieves a specific DataSync job type
                DataSyncApiJobTypeV1JobTypeProfileResponse result = apiInstance.GetDataSyncJobTypeProfileByIdAsync(jobTypeId, apiVersion, xVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataSyncApi.GetDataSyncJobTypeProfileByIdAsync: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDataSyncJobTypeProfileByIdAsyncWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a specific DataSync job type
    ApiResponse<DataSyncApiJobTypeV1JobTypeProfileResponse> response = apiInstance.GetDataSyncJobTypeProfileByIdAsyncWithHttpInfo(jobTypeId, apiVersion, xVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataSyncApi.GetDataSyncJobTypeProfileByIdAsyncWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **jobTypeId** | **string** |  |  |
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |

### Return type

[**DataSyncApiJobTypeV1JobTypeProfileResponse**](DataSyncApiJobTypeV1JobTypeProfileResponse.md)

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

<a id="getdatasyncproviderprofilebyidasync"></a>
# **GetDataSyncProviderProfileByIdAsync**
> DataSyncApiProviderV1ProviderProfileResponse GetDataSyncProviderProfileByIdAsync (string providerId, string? apiVersion = null, string? xVersion = null)

Retrieves a specific DataSync provider

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Management.Client.Api;
using EdGraph.Management.Client.Client;
using EdGraph.Management.Client.Model;

namespace Example
{
    public class GetDataSyncProviderProfileByIdAsyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/management";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DataSyncApi(config);
            var providerId = "providerId_example";  // string | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 

            try
            {
                // Retrieves a specific DataSync provider
                DataSyncApiProviderV1ProviderProfileResponse result = apiInstance.GetDataSyncProviderProfileByIdAsync(providerId, apiVersion, xVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataSyncApi.GetDataSyncProviderProfileByIdAsync: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDataSyncProviderProfileByIdAsyncWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a specific DataSync provider
    ApiResponse<DataSyncApiProviderV1ProviderProfileResponse> response = apiInstance.GetDataSyncProviderProfileByIdAsyncWithHttpInfo(providerId, apiVersion, xVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataSyncApi.GetDataSyncProviderProfileByIdAsyncWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **providerId** | **string** |  |  |
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |

### Return type

[**DataSyncApiProviderV1ProviderProfileResponse**](DataSyncApiProviderV1ProviderProfileResponse.md)

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

<a id="updatedatasyncconnectiontypeasync"></a>
# **UpdateDataSyncConnectionTypeAsync**
> DataSyncApiProviderV1ConnectionTypeUpdatedResponse UpdateDataSyncConnectionTypeAsync (string providerId, string connectionTypeId, string? apiVersion = null, string? xVersion = null, DataSyncApiProviderV1UpdateConnectionTypeRequest? dataSyncApiProviderV1UpdateConnectionTypeRequest = null)

Updates a connection type assigned to the DataSync provider

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Management.Client.Api;
using EdGraph.Management.Client.Client;
using EdGraph.Management.Client.Model;

namespace Example
{
    public class UpdateDataSyncConnectionTypeAsyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/management";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DataSyncApi(config);
            var providerId = "providerId_example";  // string | 
            var connectionTypeId = "connectionTypeId_example";  // string | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 
            var dataSyncApiProviderV1UpdateConnectionTypeRequest = new DataSyncApiProviderV1UpdateConnectionTypeRequest?(); // DataSyncApiProviderV1UpdateConnectionTypeRequest? |  (optional) 

            try
            {
                // Updates a connection type assigned to the DataSync provider
                DataSyncApiProviderV1ConnectionTypeUpdatedResponse result = apiInstance.UpdateDataSyncConnectionTypeAsync(providerId, connectionTypeId, apiVersion, xVersion, dataSyncApiProviderV1UpdateConnectionTypeRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataSyncApi.UpdateDataSyncConnectionTypeAsync: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateDataSyncConnectionTypeAsyncWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a connection type assigned to the DataSync provider
    ApiResponse<DataSyncApiProviderV1ConnectionTypeUpdatedResponse> response = apiInstance.UpdateDataSyncConnectionTypeAsyncWithHttpInfo(providerId, connectionTypeId, apiVersion, xVersion, dataSyncApiProviderV1UpdateConnectionTypeRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataSyncApi.UpdateDataSyncConnectionTypeAsyncWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **providerId** | **string** |  |  |
| **connectionTypeId** | **string** |  |  |
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |
| **dataSyncApiProviderV1UpdateConnectionTypeRequest** | [**DataSyncApiProviderV1UpdateConnectionTypeRequest?**](DataSyncApiProviderV1UpdateConnectionTypeRequest?.md) |  | [optional]  |

### Return type

[**DataSyncApiProviderV1ConnectionTypeUpdatedResponse**](DataSyncApiProviderV1ConnectionTypeUpdatedResponse.md)

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

<a id="updatedatasyncjobtypeasync"></a>
# **UpdateDataSyncJobTypeAsync**
> DataSyncApiJobTypeV1JobTypeUpdatedResponse UpdateDataSyncJobTypeAsync (string jobTypeId, string? apiVersion = null, string? xVersion = null, DataSyncApiJobTypeV1UpdateJobTypeRequest? dataSyncApiJobTypeV1UpdateJobTypeRequest = null)

Updates a DataSync job type

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Management.Client.Api;
using EdGraph.Management.Client.Client;
using EdGraph.Management.Client.Model;

namespace Example
{
    public class UpdateDataSyncJobTypeAsyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/management";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DataSyncApi(config);
            var jobTypeId = "jobTypeId_example";  // string | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 
            var dataSyncApiJobTypeV1UpdateJobTypeRequest = new DataSyncApiJobTypeV1UpdateJobTypeRequest?(); // DataSyncApiJobTypeV1UpdateJobTypeRequest? |  (optional) 

            try
            {
                // Updates a DataSync job type
                DataSyncApiJobTypeV1JobTypeUpdatedResponse result = apiInstance.UpdateDataSyncJobTypeAsync(jobTypeId, apiVersion, xVersion, dataSyncApiJobTypeV1UpdateJobTypeRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataSyncApi.UpdateDataSyncJobTypeAsync: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateDataSyncJobTypeAsyncWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a DataSync job type
    ApiResponse<DataSyncApiJobTypeV1JobTypeUpdatedResponse> response = apiInstance.UpdateDataSyncJobTypeAsyncWithHttpInfo(jobTypeId, apiVersion, xVersion, dataSyncApiJobTypeV1UpdateJobTypeRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataSyncApi.UpdateDataSyncJobTypeAsyncWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **jobTypeId** | **string** |  |  |
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |
| **dataSyncApiJobTypeV1UpdateJobTypeRequest** | [**DataSyncApiJobTypeV1UpdateJobTypeRequest?**](DataSyncApiJobTypeV1UpdateJobTypeRequest?.md) |  | [optional]  |

### Return type

[**DataSyncApiJobTypeV1JobTypeUpdatedResponse**](DataSyncApiJobTypeV1JobTypeUpdatedResponse.md)

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

<a id="updatedatasyncprofileasync"></a>
# **UpdateDataSyncProfileAsync**
> DataSyncApiJobTypeV1ProfileUpdatedResponse UpdateDataSyncProfileAsync (string jobTypeId, string profileId, string? apiVersion = null, string? xVersion = null, DataSyncApiJobTypeV1UpdateProfileRequest? dataSyncApiJobTypeV1UpdateProfileRequest = null)

Updates a profile assigned to the DataSync job type

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Management.Client.Api;
using EdGraph.Management.Client.Client;
using EdGraph.Management.Client.Model;

namespace Example
{
    public class UpdateDataSyncProfileAsyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/management";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DataSyncApi(config);
            var jobTypeId = "jobTypeId_example";  // string | 
            var profileId = "profileId_example";  // string | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 
            var dataSyncApiJobTypeV1UpdateProfileRequest = new DataSyncApiJobTypeV1UpdateProfileRequest?(); // DataSyncApiJobTypeV1UpdateProfileRequest? |  (optional) 

            try
            {
                // Updates a profile assigned to the DataSync job type
                DataSyncApiJobTypeV1ProfileUpdatedResponse result = apiInstance.UpdateDataSyncProfileAsync(jobTypeId, profileId, apiVersion, xVersion, dataSyncApiJobTypeV1UpdateProfileRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataSyncApi.UpdateDataSyncProfileAsync: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateDataSyncProfileAsyncWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a profile assigned to the DataSync job type
    ApiResponse<DataSyncApiJobTypeV1ProfileUpdatedResponse> response = apiInstance.UpdateDataSyncProfileAsyncWithHttpInfo(jobTypeId, profileId, apiVersion, xVersion, dataSyncApiJobTypeV1UpdateProfileRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataSyncApi.UpdateDataSyncProfileAsyncWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **jobTypeId** | **string** |  |  |
| **profileId** | **string** |  |  |
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |
| **dataSyncApiJobTypeV1UpdateProfileRequest** | [**DataSyncApiJobTypeV1UpdateProfileRequest?**](DataSyncApiJobTypeV1UpdateProfileRequest?.md) |  | [optional]  |

### Return type

[**DataSyncApiJobTypeV1ProfileUpdatedResponse**](DataSyncApiJobTypeV1ProfileUpdatedResponse.md)

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

<a id="updatedatasyncproviderasync"></a>
# **UpdateDataSyncProviderAsync**
> DataSyncApiProviderV1ProviderUpdatedResponse UpdateDataSyncProviderAsync (string providerId, string? apiVersion = null, string? xVersion = null, DataSyncApiProviderV1UpdateProviderRequest? dataSyncApiProviderV1UpdateProviderRequest = null)

Updates a DataSync provider

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Management.Client.Api;
using EdGraph.Management.Client.Client;
using EdGraph.Management.Client.Model;

namespace Example
{
    public class UpdateDataSyncProviderAsyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/management";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DataSyncApi(config);
            var providerId = "providerId_example";  // string | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 
            var dataSyncApiProviderV1UpdateProviderRequest = new DataSyncApiProviderV1UpdateProviderRequest?(); // DataSyncApiProviderV1UpdateProviderRequest? |  (optional) 

            try
            {
                // Updates a DataSync provider
                DataSyncApiProviderV1ProviderUpdatedResponse result = apiInstance.UpdateDataSyncProviderAsync(providerId, apiVersion, xVersion, dataSyncApiProviderV1UpdateProviderRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataSyncApi.UpdateDataSyncProviderAsync: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateDataSyncProviderAsyncWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates a DataSync provider
    ApiResponse<DataSyncApiProviderV1ProviderUpdatedResponse> response = apiInstance.UpdateDataSyncProviderAsyncWithHttpInfo(providerId, apiVersion, xVersion, dataSyncApiProviderV1UpdateProviderRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DataSyncApi.UpdateDataSyncProviderAsyncWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **providerId** | **string** |  |  |
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |
| **dataSyncApiProviderV1UpdateProviderRequest** | [**DataSyncApiProviderV1UpdateProviderRequest?**](DataSyncApiProviderV1UpdateProviderRequest?.md) |  | [optional]  |

### Return type

[**DataSyncApiProviderV1ProviderUpdatedResponse**](DataSyncApiProviderV1ProviderUpdatedResponse.md)

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

