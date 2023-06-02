# EdGraph.Management.Client.Api.MigrationsApi

All URIs are relative to *https://api.edgraph.com/management*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApplicationsMigrateUpAsync**](MigrationsApi.md#applicationsmigrateupasync) | **POST** /migrations/applications/up | Applies a migration, upgrading the data. |
| [**EdFiAdminMigrateUpAsync**](MigrationsApi.md#edfiadminmigrateupasync) | **POST** /migrations/edfiadmin/up | Applies a migration, upgrading the data. |

<a id="applicationsmigrateupasync"></a>
# **ApplicationsMigrateUpAsync**
> EdfiAdminApiEdfiAdminV1MigrationResult ApplicationsMigrateUpAsync (string? apiVersion = null, string? xVersion = null, ApplicationApiApplicationV2MigrateUpRequest? applicationApiApplicationV2MigrateUpRequest = null)

Applies a migration, upgrading the data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Management.Client.Api;
using EdGraph.Management.Client.Client;
using EdGraph.Management.Client.Model;

namespace Example
{
    public class ApplicationsMigrateUpAsyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/management";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MigrationsApi(config);
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 
            var applicationApiApplicationV2MigrateUpRequest = new ApplicationApiApplicationV2MigrateUpRequest?(); // ApplicationApiApplicationV2MigrateUpRequest? |  (optional) 

            try
            {
                // Applies a migration, upgrading the data.
                EdfiAdminApiEdfiAdminV1MigrationResult result = apiInstance.ApplicationsMigrateUpAsync(apiVersion, xVersion, applicationApiApplicationV2MigrateUpRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MigrationsApi.ApplicationsMigrateUpAsync: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApplicationsMigrateUpAsyncWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Applies a migration, upgrading the data.
    ApiResponse<EdfiAdminApiEdfiAdminV1MigrationResult> response = apiInstance.ApplicationsMigrateUpAsyncWithHttpInfo(apiVersion, xVersion, applicationApiApplicationV2MigrateUpRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MigrationsApi.ApplicationsMigrateUpAsyncWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |
| **applicationApiApplicationV2MigrateUpRequest** | [**ApplicationApiApplicationV2MigrateUpRequest?**](ApplicationApiApplicationV2MigrateUpRequest?.md) |  | [optional]  |

### Return type

[**EdfiAdminApiEdfiAdminV1MigrationResult**](EdfiAdminApiEdfiAdminV1MigrationResult.md)

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

<a id="edfiadminmigrateupasync"></a>
# **EdFiAdminMigrateUpAsync**
> EdfiAdminApiEdfiAdminV1MigrationResult EdFiAdminMigrateUpAsync (string? apiVersion = null, string? xVersion = null, EdfiAdminApiEdfiAdminV1MigrateUpRequest? edfiAdminApiEdfiAdminV1MigrateUpRequest = null)

Applies a migration, upgrading the data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Management.Client.Api;
using EdGraph.Management.Client.Client;
using EdGraph.Management.Client.Model;

namespace Example
{
    public class EdFiAdminMigrateUpAsyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/management";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MigrationsApi(config);
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 
            var edfiAdminApiEdfiAdminV1MigrateUpRequest = new EdfiAdminApiEdfiAdminV1MigrateUpRequest?(); // EdfiAdminApiEdfiAdminV1MigrateUpRequest? |  (optional) 

            try
            {
                // Applies a migration, upgrading the data.
                EdfiAdminApiEdfiAdminV1MigrationResult result = apiInstance.EdFiAdminMigrateUpAsync(apiVersion, xVersion, edfiAdminApiEdfiAdminV1MigrateUpRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MigrationsApi.EdFiAdminMigrateUpAsync: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EdFiAdminMigrateUpAsyncWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Applies a migration, upgrading the data.
    ApiResponse<EdfiAdminApiEdfiAdminV1MigrationResult> response = apiInstance.EdFiAdminMigrateUpAsyncWithHttpInfo(apiVersion, xVersion, edfiAdminApiEdfiAdminV1MigrateUpRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MigrationsApi.EdFiAdminMigrateUpAsyncWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |
| **edfiAdminApiEdfiAdminV1MigrateUpRequest** | [**EdfiAdminApiEdfiAdminV1MigrateUpRequest?**](EdfiAdminApiEdfiAdminV1MigrateUpRequest?.md) |  | [optional]  |

### Return type

[**EdfiAdminApiEdfiAdminV1MigrationResult**](EdfiAdminApiEdfiAdminV1MigrationResult.md)

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

