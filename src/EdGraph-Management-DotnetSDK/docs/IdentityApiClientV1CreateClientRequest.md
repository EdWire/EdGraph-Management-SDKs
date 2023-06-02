# EdGraph.Management.Client.Model.IdentityApiClientV1CreateClientRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TenantId** | **string** |  | [optional] 
**ApplicationId** | **string** |  | [optional] 
**ClientId** | **string** |  | [optional] 
**ClientName** | **string** |  | [optional] 
**Description** | **string** |  | [optional] 
**ClientUri** | **string** |  | [optional] 
**LogoUri** | **string** |  | [optional] 
**Enabled** | **bool** |  | [optional] 
**AccessTokenType** | **IdentityApiClientV1AccessTokenType** |  | [optional] 
**TokenUsage** | **IdentityApiClientV1TokenUsage** |  | [optional] 
**RefreshTokenExpiration** | **IdentityApiClientV1TokenExpiration** |  | [optional] 
**EnableLocalLogin** | **bool** |  | [optional] 
**AllowOfflineAccess** | **bool** |  | [optional] 
**AllowAccessTokensViaBrowser** | **bool** |  | [optional] 
**UpdateAccessTokenClaimsOnRefresh** | **bool** |  | [optional] 
**AlwaysIncludeUserClaimsInIdToken** | **bool** |  | [optional] 
**IdentityTokenLifetime** | **int** |  | [optional] 
**AccessTokenLifetime** | **int** |  | [optional] 
**AuthorizationCodeLifetime** | **int** |  | [optional] 
**AbsoluteRefreshTokenLifetime** | **int** |  | [optional] 
**SlidingRefreshTokenLifetime** | **int** |  | [optional] 
**RequireClientSecret** | **bool** |  | [optional] 
**RequireConsent** | **bool** |  | [optional] 
**AllowedScopes** | **List&lt;string&gt;** |  | [optional] [readonly] 
**AllowedCorsOrigins** | **List&lt;string&gt;** |  | [optional] [readonly] 
**AllowedGrantTypes** | **List&lt;string&gt;** |  | [optional] [readonly] 
**IdentityProviderRestrictions** | **List&lt;string&gt;** |  | [optional] [readonly] 
**RedirectUris** | **List&lt;string&gt;** |  | [optional] [readonly] 
**PostLogoutRedirectUris** | **List&lt;string&gt;** |  | [optional] [readonly] 
**Secret** | **string** |  | [optional] 
**Claims** | [**List&lt;IdentityApiClientV1Claim&gt;**](IdentityApiClientV1Claim.md) |  | [optional] [readonly] 
**RequirePkce** | **bool** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

