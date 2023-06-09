/*
 * Management Api
 *
 * Api to help platform wide items such as users, tenants, applications, subscriptions, etc.
 *
 * The version of the OpenAPI document: v1.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using EdGraph.Management.Client.Client;
using EdGraph.Management.Client.Client.Auth;
using EdGraph.Management.Client.Model;

namespace EdGraph.Management.Client.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMigrationsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Applies a migration, upgrading the data.
        /// </summary>
        /// <exception cref="EdGraph.Management.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiVersion"> (optional)</param>
        /// <param name="xVersion"> (optional)</param>
        /// <param name="applicationApiApplicationV2MigrateUpRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>EdfiAdminApiEdfiAdminV1MigrationResult</returns>
        EdfiAdminApiEdfiAdminV1MigrationResult ApplicationsMigrateUpAsync(string? apiVersion = default(string?), string? xVersion = default(string?), ApplicationApiApplicationV2MigrateUpRequest? applicationApiApplicationV2MigrateUpRequest = default(ApplicationApiApplicationV2MigrateUpRequest?), int operationIndex = 0);

        /// <summary>
        /// Applies a migration, upgrading the data.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="EdGraph.Management.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiVersion"> (optional)</param>
        /// <param name="xVersion"> (optional)</param>
        /// <param name="applicationApiApplicationV2MigrateUpRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of EdfiAdminApiEdfiAdminV1MigrationResult</returns>
        ApiResponse<EdfiAdminApiEdfiAdminV1MigrationResult> ApplicationsMigrateUpAsyncWithHttpInfo(string? apiVersion = default(string?), string? xVersion = default(string?), ApplicationApiApplicationV2MigrateUpRequest? applicationApiApplicationV2MigrateUpRequest = default(ApplicationApiApplicationV2MigrateUpRequest?), int operationIndex = 0);
        /// <summary>
        /// Applies a migration, upgrading the data.
        /// </summary>
        /// <exception cref="EdGraph.Management.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiVersion"> (optional)</param>
        /// <param name="xVersion"> (optional)</param>
        /// <param name="edfiAdminApiEdfiAdminV1MigrateUpRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>EdfiAdminApiEdfiAdminV1MigrationResult</returns>
        EdfiAdminApiEdfiAdminV1MigrationResult EdFiAdminMigrateUpAsync(string? apiVersion = default(string?), string? xVersion = default(string?), EdfiAdminApiEdfiAdminV1MigrateUpRequest? edfiAdminApiEdfiAdminV1MigrateUpRequest = default(EdfiAdminApiEdfiAdminV1MigrateUpRequest?), int operationIndex = 0);

        /// <summary>
        /// Applies a migration, upgrading the data.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="EdGraph.Management.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiVersion"> (optional)</param>
        /// <param name="xVersion"> (optional)</param>
        /// <param name="edfiAdminApiEdfiAdminV1MigrateUpRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of EdfiAdminApiEdfiAdminV1MigrationResult</returns>
        ApiResponse<EdfiAdminApiEdfiAdminV1MigrationResult> EdFiAdminMigrateUpAsyncWithHttpInfo(string? apiVersion = default(string?), string? xVersion = default(string?), EdfiAdminApiEdfiAdminV1MigrateUpRequest? edfiAdminApiEdfiAdminV1MigrateUpRequest = default(EdfiAdminApiEdfiAdminV1MigrateUpRequest?), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMigrationsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Applies a migration, upgrading the data.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="EdGraph.Management.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiVersion"> (optional)</param>
        /// <param name="xVersion"> (optional)</param>
        /// <param name="applicationApiApplicationV2MigrateUpRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of EdfiAdminApiEdfiAdminV1MigrationResult</returns>
        System.Threading.Tasks.Task<EdfiAdminApiEdfiAdminV1MigrationResult> ApplicationsMigrateUpAsyncAsync(string? apiVersion = default(string?), string? xVersion = default(string?), ApplicationApiApplicationV2MigrateUpRequest? applicationApiApplicationV2MigrateUpRequest = default(ApplicationApiApplicationV2MigrateUpRequest?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Applies a migration, upgrading the data.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="EdGraph.Management.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiVersion"> (optional)</param>
        /// <param name="xVersion"> (optional)</param>
        /// <param name="applicationApiApplicationV2MigrateUpRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (EdfiAdminApiEdfiAdminV1MigrationResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<EdfiAdminApiEdfiAdminV1MigrationResult>> ApplicationsMigrateUpAsyncWithHttpInfoAsync(string? apiVersion = default(string?), string? xVersion = default(string?), ApplicationApiApplicationV2MigrateUpRequest? applicationApiApplicationV2MigrateUpRequest = default(ApplicationApiApplicationV2MigrateUpRequest?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Applies a migration, upgrading the data.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="EdGraph.Management.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiVersion"> (optional)</param>
        /// <param name="xVersion"> (optional)</param>
        /// <param name="edfiAdminApiEdfiAdminV1MigrateUpRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of EdfiAdminApiEdfiAdminV1MigrationResult</returns>
        System.Threading.Tasks.Task<EdfiAdminApiEdfiAdminV1MigrationResult> EdFiAdminMigrateUpAsyncAsync(string? apiVersion = default(string?), string? xVersion = default(string?), EdfiAdminApiEdfiAdminV1MigrateUpRequest? edfiAdminApiEdfiAdminV1MigrateUpRequest = default(EdfiAdminApiEdfiAdminV1MigrateUpRequest?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Applies a migration, upgrading the data.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="EdGraph.Management.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiVersion"> (optional)</param>
        /// <param name="xVersion"> (optional)</param>
        /// <param name="edfiAdminApiEdfiAdminV1MigrateUpRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (EdfiAdminApiEdfiAdminV1MigrationResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<EdfiAdminApiEdfiAdminV1MigrationResult>> EdFiAdminMigrateUpAsyncWithHttpInfoAsync(string? apiVersion = default(string?), string? xVersion = default(string?), EdfiAdminApiEdfiAdminV1MigrateUpRequest? edfiAdminApiEdfiAdminV1MigrateUpRequest = default(EdfiAdminApiEdfiAdminV1MigrateUpRequest?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMigrationsApi : IMigrationsApiSync, IMigrationsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class MigrationsApi : IMigrationsApi
    {
        private EdGraph.Management.Client.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="MigrationsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MigrationsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MigrationsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MigrationsApi(string basePath)
        {
            this.Configuration = EdGraph.Management.Client.Client.Configuration.MergeConfigurations(
                EdGraph.Management.Client.Client.GlobalConfiguration.Instance,
                new EdGraph.Management.Client.Client.Configuration { BasePath = basePath }
            );
            this.Client = new EdGraph.Management.Client.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new EdGraph.Management.Client.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = EdGraph.Management.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MigrationsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public MigrationsApi(EdGraph.Management.Client.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = EdGraph.Management.Client.Client.Configuration.MergeConfigurations(
                EdGraph.Management.Client.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new EdGraph.Management.Client.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new EdGraph.Management.Client.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = EdGraph.Management.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MigrationsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public MigrationsApi(EdGraph.Management.Client.Client.ISynchronousClient client, EdGraph.Management.Client.Client.IAsynchronousClient asyncClient, EdGraph.Management.Client.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = EdGraph.Management.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public EdGraph.Management.Client.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public EdGraph.Management.Client.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public EdGraph.Management.Client.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public EdGraph.Management.Client.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Applies a migration, upgrading the data. 
        /// </summary>
        /// <exception cref="EdGraph.Management.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiVersion"> (optional)</param>
        /// <param name="xVersion"> (optional)</param>
        /// <param name="applicationApiApplicationV2MigrateUpRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>EdfiAdminApiEdfiAdminV1MigrationResult</returns>
        public EdfiAdminApiEdfiAdminV1MigrationResult ApplicationsMigrateUpAsync(string? apiVersion = default(string?), string? xVersion = default(string?), ApplicationApiApplicationV2MigrateUpRequest? applicationApiApplicationV2MigrateUpRequest = default(ApplicationApiApplicationV2MigrateUpRequest?), int operationIndex = 0)
        {
            EdGraph.Management.Client.Client.ApiResponse<EdfiAdminApiEdfiAdminV1MigrationResult> localVarResponse = ApplicationsMigrateUpAsyncWithHttpInfo(apiVersion, xVersion, applicationApiApplicationV2MigrateUpRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Applies a migration, upgrading the data. 
        /// </summary>
        /// <exception cref="EdGraph.Management.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiVersion"> (optional)</param>
        /// <param name="xVersion"> (optional)</param>
        /// <param name="applicationApiApplicationV2MigrateUpRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of EdfiAdminApiEdfiAdminV1MigrationResult</returns>
        public EdGraph.Management.Client.Client.ApiResponse<EdfiAdminApiEdfiAdminV1MigrationResult> ApplicationsMigrateUpAsyncWithHttpInfo(string? apiVersion = default(string?), string? xVersion = default(string?), ApplicationApiApplicationV2MigrateUpRequest? applicationApiApplicationV2MigrateUpRequest = default(ApplicationApiApplicationV2MigrateUpRequest?), int operationIndex = 0)
        {
            EdGraph.Management.Client.Client.RequestOptions localVarRequestOptions = new EdGraph.Management.Client.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json-patch+json",
                "application/json",
                "text/json",
                "application/*+json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = EdGraph.Management.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = EdGraph.Management.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (apiVersion != null)
            {
                localVarRequestOptions.QueryParameters.Add(EdGraph.Management.Client.Client.ClientUtils.ParameterToMultiMap("", "api-version", apiVersion));
            }
            if (xVersion != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-version", EdGraph.Management.Client.Client.ClientUtils.ParameterToString(xVersion)); // header parameter
            }
            localVarRequestOptions.Data = applicationApiApplicationV2MigrateUpRequest;

            localVarRequestOptions.Operation = "MigrationsApi.ApplicationsMigrateUpAsync";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (oauth2) required
            // oauth required
            if (!localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                if (!string.IsNullOrEmpty(this.Configuration.AccessToken))
                {
                    localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
                }
                else if (!string.IsNullOrEmpty(this.Configuration.OAuthTokenUrl) &&
                         !string.IsNullOrEmpty(this.Configuration.OAuthClientId) &&
                         !string.IsNullOrEmpty(this.Configuration.OAuthClientSecret) &&
                         this.Configuration.OAuthFlow != null)
                {
                    localVarRequestOptions.OAuth = true;
                }
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<EdfiAdminApiEdfiAdminV1MigrationResult>("/migrations/applications/up", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApplicationsMigrateUpAsync", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Applies a migration, upgrading the data. 
        /// </summary>
        /// <exception cref="EdGraph.Management.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiVersion"> (optional)</param>
        /// <param name="xVersion"> (optional)</param>
        /// <param name="applicationApiApplicationV2MigrateUpRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of EdfiAdminApiEdfiAdminV1MigrationResult</returns>
        public async System.Threading.Tasks.Task<EdfiAdminApiEdfiAdminV1MigrationResult> ApplicationsMigrateUpAsyncAsync(string? apiVersion = default(string?), string? xVersion = default(string?), ApplicationApiApplicationV2MigrateUpRequest? applicationApiApplicationV2MigrateUpRequest = default(ApplicationApiApplicationV2MigrateUpRequest?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            EdGraph.Management.Client.Client.ApiResponse<EdfiAdminApiEdfiAdminV1MigrationResult> localVarResponse = await ApplicationsMigrateUpAsyncWithHttpInfoAsync(apiVersion, xVersion, applicationApiApplicationV2MigrateUpRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Applies a migration, upgrading the data. 
        /// </summary>
        /// <exception cref="EdGraph.Management.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiVersion"> (optional)</param>
        /// <param name="xVersion"> (optional)</param>
        /// <param name="applicationApiApplicationV2MigrateUpRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (EdfiAdminApiEdfiAdminV1MigrationResult)</returns>
        public async System.Threading.Tasks.Task<EdGraph.Management.Client.Client.ApiResponse<EdfiAdminApiEdfiAdminV1MigrationResult>> ApplicationsMigrateUpAsyncWithHttpInfoAsync(string? apiVersion = default(string?), string? xVersion = default(string?), ApplicationApiApplicationV2MigrateUpRequest? applicationApiApplicationV2MigrateUpRequest = default(ApplicationApiApplicationV2MigrateUpRequest?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            EdGraph.Management.Client.Client.RequestOptions localVarRequestOptions = new EdGraph.Management.Client.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/*+json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = EdGraph.Management.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = EdGraph.Management.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (apiVersion != null)
            {
                localVarRequestOptions.QueryParameters.Add(EdGraph.Management.Client.Client.ClientUtils.ParameterToMultiMap("", "api-version", apiVersion));
            }
            if (xVersion != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-version", EdGraph.Management.Client.Client.ClientUtils.ParameterToString(xVersion)); // header parameter
            }
            localVarRequestOptions.Data = applicationApiApplicationV2MigrateUpRequest;

            localVarRequestOptions.Operation = "MigrationsApi.ApplicationsMigrateUpAsync";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (oauth2) required
            // oauth required
            if (!localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                if (!string.IsNullOrEmpty(this.Configuration.AccessToken))
                {
                    localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
                }
                else if (!string.IsNullOrEmpty(this.Configuration.OAuthTokenUrl) &&
                         !string.IsNullOrEmpty(this.Configuration.OAuthClientId) &&
                         !string.IsNullOrEmpty(this.Configuration.OAuthClientSecret) &&
                         this.Configuration.OAuthFlow != null)
                {
                    localVarRequestOptions.OAuth = true;
                }
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<EdfiAdminApiEdfiAdminV1MigrationResult>("/migrations/applications/up", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApplicationsMigrateUpAsync", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Applies a migration, upgrading the data. 
        /// </summary>
        /// <exception cref="EdGraph.Management.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiVersion"> (optional)</param>
        /// <param name="xVersion"> (optional)</param>
        /// <param name="edfiAdminApiEdfiAdminV1MigrateUpRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>EdfiAdminApiEdfiAdminV1MigrationResult</returns>
        public EdfiAdminApiEdfiAdminV1MigrationResult EdFiAdminMigrateUpAsync(string? apiVersion = default(string?), string? xVersion = default(string?), EdfiAdminApiEdfiAdminV1MigrateUpRequest? edfiAdminApiEdfiAdminV1MigrateUpRequest = default(EdfiAdminApiEdfiAdminV1MigrateUpRequest?), int operationIndex = 0)
        {
            EdGraph.Management.Client.Client.ApiResponse<EdfiAdminApiEdfiAdminV1MigrationResult> localVarResponse = EdFiAdminMigrateUpAsyncWithHttpInfo(apiVersion, xVersion, edfiAdminApiEdfiAdminV1MigrateUpRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Applies a migration, upgrading the data. 
        /// </summary>
        /// <exception cref="EdGraph.Management.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiVersion"> (optional)</param>
        /// <param name="xVersion"> (optional)</param>
        /// <param name="edfiAdminApiEdfiAdminV1MigrateUpRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of EdfiAdminApiEdfiAdminV1MigrationResult</returns>
        public EdGraph.Management.Client.Client.ApiResponse<EdfiAdminApiEdfiAdminV1MigrationResult> EdFiAdminMigrateUpAsyncWithHttpInfo(string? apiVersion = default(string?), string? xVersion = default(string?), EdfiAdminApiEdfiAdminV1MigrateUpRequest? edfiAdminApiEdfiAdminV1MigrateUpRequest = default(EdfiAdminApiEdfiAdminV1MigrateUpRequest?), int operationIndex = 0)
        {
            EdGraph.Management.Client.Client.RequestOptions localVarRequestOptions = new EdGraph.Management.Client.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json-patch+json",
                "application/json",
                "text/json",
                "application/*+json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = EdGraph.Management.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = EdGraph.Management.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (apiVersion != null)
            {
                localVarRequestOptions.QueryParameters.Add(EdGraph.Management.Client.Client.ClientUtils.ParameterToMultiMap("", "api-version", apiVersion));
            }
            if (xVersion != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-version", EdGraph.Management.Client.Client.ClientUtils.ParameterToString(xVersion)); // header parameter
            }
            localVarRequestOptions.Data = edfiAdminApiEdfiAdminV1MigrateUpRequest;

            localVarRequestOptions.Operation = "MigrationsApi.EdFiAdminMigrateUpAsync";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (oauth2) required
            // oauth required
            if (!localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                if (!string.IsNullOrEmpty(this.Configuration.AccessToken))
                {
                    localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
                }
                else if (!string.IsNullOrEmpty(this.Configuration.OAuthTokenUrl) &&
                         !string.IsNullOrEmpty(this.Configuration.OAuthClientId) &&
                         !string.IsNullOrEmpty(this.Configuration.OAuthClientSecret) &&
                         this.Configuration.OAuthFlow != null)
                {
                    localVarRequestOptions.OAuth = true;
                }
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<EdfiAdminApiEdfiAdminV1MigrationResult>("/migrations/edfiadmin/up", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("EdFiAdminMigrateUpAsync", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Applies a migration, upgrading the data. 
        /// </summary>
        /// <exception cref="EdGraph.Management.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiVersion"> (optional)</param>
        /// <param name="xVersion"> (optional)</param>
        /// <param name="edfiAdminApiEdfiAdminV1MigrateUpRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of EdfiAdminApiEdfiAdminV1MigrationResult</returns>
        public async System.Threading.Tasks.Task<EdfiAdminApiEdfiAdminV1MigrationResult> EdFiAdminMigrateUpAsyncAsync(string? apiVersion = default(string?), string? xVersion = default(string?), EdfiAdminApiEdfiAdminV1MigrateUpRequest? edfiAdminApiEdfiAdminV1MigrateUpRequest = default(EdfiAdminApiEdfiAdminV1MigrateUpRequest?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            EdGraph.Management.Client.Client.ApiResponse<EdfiAdminApiEdfiAdminV1MigrationResult> localVarResponse = await EdFiAdminMigrateUpAsyncWithHttpInfoAsync(apiVersion, xVersion, edfiAdminApiEdfiAdminV1MigrateUpRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Applies a migration, upgrading the data. 
        /// </summary>
        /// <exception cref="EdGraph.Management.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiVersion"> (optional)</param>
        /// <param name="xVersion"> (optional)</param>
        /// <param name="edfiAdminApiEdfiAdminV1MigrateUpRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (EdfiAdminApiEdfiAdminV1MigrationResult)</returns>
        public async System.Threading.Tasks.Task<EdGraph.Management.Client.Client.ApiResponse<EdfiAdminApiEdfiAdminV1MigrationResult>> EdFiAdminMigrateUpAsyncWithHttpInfoAsync(string? apiVersion = default(string?), string? xVersion = default(string?), EdfiAdminApiEdfiAdminV1MigrateUpRequest? edfiAdminApiEdfiAdminV1MigrateUpRequest = default(EdfiAdminApiEdfiAdminV1MigrateUpRequest?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            EdGraph.Management.Client.Client.RequestOptions localVarRequestOptions = new EdGraph.Management.Client.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/*+json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = EdGraph.Management.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = EdGraph.Management.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (apiVersion != null)
            {
                localVarRequestOptions.QueryParameters.Add(EdGraph.Management.Client.Client.ClientUtils.ParameterToMultiMap("", "api-version", apiVersion));
            }
            if (xVersion != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-version", EdGraph.Management.Client.Client.ClientUtils.ParameterToString(xVersion)); // header parameter
            }
            localVarRequestOptions.Data = edfiAdminApiEdfiAdminV1MigrateUpRequest;

            localVarRequestOptions.Operation = "MigrationsApi.EdFiAdminMigrateUpAsync";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (oauth2) required
            // oauth required
            if (!localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                if (!string.IsNullOrEmpty(this.Configuration.AccessToken))
                {
                    localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
                }
                else if (!string.IsNullOrEmpty(this.Configuration.OAuthTokenUrl) &&
                         !string.IsNullOrEmpty(this.Configuration.OAuthClientId) &&
                         !string.IsNullOrEmpty(this.Configuration.OAuthClientSecret) &&
                         this.Configuration.OAuthFlow != null)
                {
                    localVarRequestOptions.OAuth = true;
                }
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<EdfiAdminApiEdfiAdminV1MigrationResult>("/migrations/edfiadmin/up", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("EdFiAdminMigrateUpAsync", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
