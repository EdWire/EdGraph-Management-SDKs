# EdGraph.Management.Client.Api.UsersApi

All URIs are relative to *https://api.edgraph.com/management*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateLocalUserAsync**](UsersApi.md#createlocaluserasync) | **POST** /users | Creates a new user |
| [**DeleteUserAsync**](UsersApi.md#deleteuserasync) | **DELETE** /users/{userId} | Deletes a user |
| [**DisableUserBrowserDebugAsync**](UsersApi.md#disableuserbrowserdebugasync) | **PUT** /users/{userId}/disableuserbrowserdebug | Disable browser debug for a user |
| [**EnableUserBrowserDebugAsync**](UsersApi.md#enableuserbrowserdebugasync) | **PUT** /users/{userId}/enableuserbrowserdebug | Enable browser debug for a user |
| [**GetAllUsersAsync**](UsersApi.md#getallusersasync) | **GET** /users | Retrieves a list of users |
| [**GetUserProfileByIdAsync**](UsersApi.md#getuserprofilebyidasync) | **GET** /users/{userId} | Retrieves a specific user |
| [**UpdateUserAsync**](UsersApi.md#updateuserasync) | **PUT** /users/{userId} | Creates or Updates a user |

<a id="createlocaluserasync"></a>
# **CreateLocalUserAsync**
> IdentityApiUserV1LocalUserCreatedResponse CreateLocalUserAsync (string? apiVersion = null, string? xVersion = null, IdentityApiUserV1CreateLocalUserRequest? identityApiUserV1CreateLocalUserRequest = null)

Creates a new user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Management.Client.Api;
using EdGraph.Management.Client.Client;
using EdGraph.Management.Client.Model;

namespace Example
{
    public class CreateLocalUserAsyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/management";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi(config);
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 
            var identityApiUserV1CreateLocalUserRequest = new IdentityApiUserV1CreateLocalUserRequest?(); // IdentityApiUserV1CreateLocalUserRequest? |  (optional) 

            try
            {
                // Creates a new user
                IdentityApiUserV1LocalUserCreatedResponse result = apiInstance.CreateLocalUserAsync(apiVersion, xVersion, identityApiUserV1CreateLocalUserRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.CreateLocalUserAsync: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateLocalUserAsyncWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a new user
    ApiResponse<IdentityApiUserV1LocalUserCreatedResponse> response = apiInstance.CreateLocalUserAsyncWithHttpInfo(apiVersion, xVersion, identityApiUserV1CreateLocalUserRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.CreateLocalUserAsyncWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |
| **identityApiUserV1CreateLocalUserRequest** | [**IdentityApiUserV1CreateLocalUserRequest?**](IdentityApiUserV1CreateLocalUserRequest?.md) |  | [optional]  |

### Return type

[**IdentityApiUserV1LocalUserCreatedResponse**](IdentityApiUserV1LocalUserCreatedResponse.md)

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

<a id="deleteuserasync"></a>
# **DeleteUserAsync**
> void DeleteUserAsync (string userId, string? apiVersion = null, string? xVersion = null)

Deletes a user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Management.Client.Api;
using EdGraph.Management.Client.Client;
using EdGraph.Management.Client.Model;

namespace Example
{
    public class DeleteUserAsyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/management";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi(config);
            var userId = "userId_example";  // string | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 

            try
            {
                // Deletes a user
                apiInstance.DeleteUserAsync(userId, apiVersion, xVersion);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.DeleteUserAsync: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteUserAsyncWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes a user
    apiInstance.DeleteUserAsyncWithHttpInfo(userId, apiVersion, xVersion);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.DeleteUserAsyncWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **string** |  |  |
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

<a id="disableuserbrowserdebugasync"></a>
# **DisableUserBrowserDebugAsync**
> IdentityApiUserV1UserBrowserDebugDisabledResponse DisableUserBrowserDebugAsync (string userId, string? apiVersion = null, string? xVersion = null, IdentityApiUserV1DisableUserBrowserDebugRequest? identityApiUserV1DisableUserBrowserDebugRequest = null)

Disable browser debug for a user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Management.Client.Api;
using EdGraph.Management.Client.Client;
using EdGraph.Management.Client.Model;

namespace Example
{
    public class DisableUserBrowserDebugAsyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/management";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi(config);
            var userId = "userId_example";  // string | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 
            var identityApiUserV1DisableUserBrowserDebugRequest = new IdentityApiUserV1DisableUserBrowserDebugRequest?(); // IdentityApiUserV1DisableUserBrowserDebugRequest? |  (optional) 

            try
            {
                // Disable browser debug for a user
                IdentityApiUserV1UserBrowserDebugDisabledResponse result = apiInstance.DisableUserBrowserDebugAsync(userId, apiVersion, xVersion, identityApiUserV1DisableUserBrowserDebugRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.DisableUserBrowserDebugAsync: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DisableUserBrowserDebugAsyncWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Disable browser debug for a user
    ApiResponse<IdentityApiUserV1UserBrowserDebugDisabledResponse> response = apiInstance.DisableUserBrowserDebugAsyncWithHttpInfo(userId, apiVersion, xVersion, identityApiUserV1DisableUserBrowserDebugRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.DisableUserBrowserDebugAsyncWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **string** |  |  |
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |
| **identityApiUserV1DisableUserBrowserDebugRequest** | [**IdentityApiUserV1DisableUserBrowserDebugRequest?**](IdentityApiUserV1DisableUserBrowserDebugRequest?.md) |  | [optional]  |

### Return type

[**IdentityApiUserV1UserBrowserDebugDisabledResponse**](IdentityApiUserV1UserBrowserDebugDisabledResponse.md)

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

<a id="enableuserbrowserdebugasync"></a>
# **EnableUserBrowserDebugAsync**
> IdentityApiUserV1UserBrowserDebugEnabledResponse EnableUserBrowserDebugAsync (string userId, string? apiVersion = null, string? xVersion = null, IdentityApiUserV1EnableUserBrowserDebugRequest? identityApiUserV1EnableUserBrowserDebugRequest = null)

Enable browser debug for a user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Management.Client.Api;
using EdGraph.Management.Client.Client;
using EdGraph.Management.Client.Model;

namespace Example
{
    public class EnableUserBrowserDebugAsyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/management";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi(config);
            var userId = "userId_example";  // string | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 
            var identityApiUserV1EnableUserBrowserDebugRequest = new IdentityApiUserV1EnableUserBrowserDebugRequest?(); // IdentityApiUserV1EnableUserBrowserDebugRequest? |  (optional) 

            try
            {
                // Enable browser debug for a user
                IdentityApiUserV1UserBrowserDebugEnabledResponse result = apiInstance.EnableUserBrowserDebugAsync(userId, apiVersion, xVersion, identityApiUserV1EnableUserBrowserDebugRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.EnableUserBrowserDebugAsync: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the EnableUserBrowserDebugAsyncWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Enable browser debug for a user
    ApiResponse<IdentityApiUserV1UserBrowserDebugEnabledResponse> response = apiInstance.EnableUserBrowserDebugAsyncWithHttpInfo(userId, apiVersion, xVersion, identityApiUserV1EnableUserBrowserDebugRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.EnableUserBrowserDebugAsyncWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **string** |  |  |
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |
| **identityApiUserV1EnableUserBrowserDebugRequest** | [**IdentityApiUserV1EnableUserBrowserDebugRequest?**](IdentityApiUserV1EnableUserBrowserDebugRequest?.md) |  | [optional]  |

### Return type

[**IdentityApiUserV1UserBrowserDebugEnabledResponse**](IdentityApiUserV1UserBrowserDebugEnabledResponse.md)

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

<a id="getallusersasync"></a>
# **GetAllUsersAsync**
> IdentityApiUserV1UserListResponsePaginatedItemsViewModel GetAllUsersAsync (int? pageSize = null, int? pageIndex = null, string? orderBy = null, string? filter = null, string? apiVersion = null, string? xVersion = null)

Retrieves a list of users

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Management.Client.Api;
using EdGraph.Management.Client.Client;
using EdGraph.Management.Client.Model;

namespace Example
{
    public class GetAllUsersAsyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/management";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi(config);
            var pageSize = 10;  // int? |  (optional)  (default to 10)
            var pageIndex = 0;  // int? |  (optional)  (default to 0)
            var orderBy = "\"\"";  // string? |  (optional)  (default to "")
            var filter = "\"\"";  // string? |  (optional)  (default to "")
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 

            try
            {
                // Retrieves a list of users
                IdentityApiUserV1UserListResponsePaginatedItemsViewModel result = apiInstance.GetAllUsersAsync(pageSize, pageIndex, orderBy, filter, apiVersion, xVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.GetAllUsersAsync: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAllUsersAsyncWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a list of users
    ApiResponse<IdentityApiUserV1UserListResponsePaginatedItemsViewModel> response = apiInstance.GetAllUsersAsyncWithHttpInfo(pageSize, pageIndex, orderBy, filter, apiVersion, xVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.GetAllUsersAsyncWithHttpInfo: " + e.Message);
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

[**IdentityApiUserV1UserListResponsePaginatedItemsViewModel**](IdentityApiUserV1UserListResponsePaginatedItemsViewModel.md)

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

<a id="getuserprofilebyidasync"></a>
# **GetUserProfileByIdAsync**
> IdentityApiUserV1UserProfileResponse GetUserProfileByIdAsync (string userId, string? apiVersion = null, string? xVersion = null)

Retrieves a specific user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Management.Client.Api;
using EdGraph.Management.Client.Client;
using EdGraph.Management.Client.Model;

namespace Example
{
    public class GetUserProfileByIdAsyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/management";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi(config);
            var userId = "userId_example";  // string | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 

            try
            {
                // Retrieves a specific user
                IdentityApiUserV1UserProfileResponse result = apiInstance.GetUserProfileByIdAsync(userId, apiVersion, xVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.GetUserProfileByIdAsync: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetUserProfileByIdAsyncWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves a specific user
    ApiResponse<IdentityApiUserV1UserProfileResponse> response = apiInstance.GetUserProfileByIdAsyncWithHttpInfo(userId, apiVersion, xVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.GetUserProfileByIdAsyncWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **string** |  |  |
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |

### Return type

[**IdentityApiUserV1UserProfileResponse**](IdentityApiUserV1UserProfileResponse.md)

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

<a id="updateuserasync"></a>
# **UpdateUserAsync**
> IdentityApiUserV1UserUpdatedResponse UpdateUserAsync (string userId, string? apiVersion = null, string? xVersion = null, IdentityApiUserV1UpdateUserRequest? identityApiUserV1UpdateUserRequest = null)

Creates or Updates a user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using EdGraph.Management.Client.Api;
using EdGraph.Management.Client.Client;
using EdGraph.Management.Client.Model;

namespace Example
{
    public class UpdateUserAsyncExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.edgraph.com/management";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersApi(config);
            var userId = "userId_example";  // string | 
            var apiVersion = "apiVersion_example";  // string? |  (optional) 
            var xVersion = "xVersion_example";  // string? |  (optional) 
            var identityApiUserV1UpdateUserRequest = new IdentityApiUserV1UpdateUserRequest?(); // IdentityApiUserV1UpdateUserRequest? |  (optional) 

            try
            {
                // Creates or Updates a user
                IdentityApiUserV1UserUpdatedResponse result = apiInstance.UpdateUserAsync(userId, apiVersion, xVersion, identityApiUserV1UpdateUserRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.UpdateUserAsync: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateUserAsyncWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates or Updates a user
    ApiResponse<IdentityApiUserV1UserUpdatedResponse> response = apiInstance.UpdateUserAsyncWithHttpInfo(userId, apiVersion, xVersion, identityApiUserV1UpdateUserRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.UpdateUserAsyncWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **string** |  |  |
| **apiVersion** | **string?** |  | [optional]  |
| **xVersion** | **string?** |  | [optional]  |
| **identityApiUserV1UpdateUserRequest** | [**IdentityApiUserV1UpdateUserRequest?**](IdentityApiUserV1UpdateUserRequest?.md) |  | [optional]  |

### Return type

[**IdentityApiUserV1UserUpdatedResponse**](IdentityApiUserV1UserUpdatedResponse.md)

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

