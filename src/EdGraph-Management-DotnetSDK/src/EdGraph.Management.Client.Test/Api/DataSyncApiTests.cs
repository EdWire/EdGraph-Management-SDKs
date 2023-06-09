/*
 * Management Api
 *
 * Api to help platform wide items such as users, tenants, applications, subscriptions, etc.
 *
 * The version of the OpenAPI document: v1.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using EdGraph.Management.Client.Client;
using EdGraph.Management.Client.Api;
// uncomment below to import models
//using EdGraph.Management.Client.Model;

namespace EdGraph.Management.Client.Test.Api
{
    /// <summary>
    ///  Class for testing DataSyncApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class DataSyncApiTests : IDisposable
    {
        private DataSyncApi instance;

        public DataSyncApiTests()
        {
            instance = new DataSyncApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DataSyncApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' DataSyncApi
            //Assert.IsType<DataSyncApi>(instance);
        }

        /// <summary>
        /// Test CreateDataSyncConnectionTypeAsync
        /// </summary>
        [Fact]
        public void CreateDataSyncConnectionTypeAsyncTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string providerId = null;
            //string? apiVersion = null;
            //string? xVersion = null;
            //DataSyncApiProviderV1CreateConnectionTypeRequest? dataSyncApiProviderV1CreateConnectionTypeRequest = null;
            //var response = instance.CreateDataSyncConnectionTypeAsync(providerId, apiVersion, xVersion, dataSyncApiProviderV1CreateConnectionTypeRequest);
            //Assert.IsType<DataSyncApiProviderV1ConnectionTypeCreatedResponse>(response);
        }

        /// <summary>
        /// Test CreateDataSyncJobTypeAsync
        /// </summary>
        [Fact]
        public void CreateDataSyncJobTypeAsyncTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? apiVersion = null;
            //string? xVersion = null;
            //DataSyncApiJobTypeV1CreateJobTypeRequest? dataSyncApiJobTypeV1CreateJobTypeRequest = null;
            //var response = instance.CreateDataSyncJobTypeAsync(apiVersion, xVersion, dataSyncApiJobTypeV1CreateJobTypeRequest);
            //Assert.IsType<DataSyncApiJobTypeV1JobTypeCreatedResponse>(response);
        }

        /// <summary>
        /// Test CreateDataSyncProfileAsync
        /// </summary>
        [Fact]
        public void CreateDataSyncProfileAsyncTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string jobTypeId = null;
            //string? apiVersion = null;
            //string? xVersion = null;
            //DataSyncApiJobTypeV1CreateProfileRequest? dataSyncApiJobTypeV1CreateProfileRequest = null;
            //var response = instance.CreateDataSyncProfileAsync(jobTypeId, apiVersion, xVersion, dataSyncApiJobTypeV1CreateProfileRequest);
            //Assert.IsType<DataSyncApiJobTypeV1ProfileCreatedResponse>(response);
        }

        /// <summary>
        /// Test CreateDataSyncProviderAsync
        /// </summary>
        [Fact]
        public void CreateDataSyncProviderAsyncTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? apiVersion = null;
            //string? xVersion = null;
            //DataSyncApiProviderV1CreateProviderRequest? dataSyncApiProviderV1CreateProviderRequest = null;
            //var response = instance.CreateDataSyncProviderAsync(apiVersion, xVersion, dataSyncApiProviderV1CreateProviderRequest);
            //Assert.IsType<DataSyncApiProviderV1ProviderCreatedResponse>(response);
        }

        /// <summary>
        /// Test DeleteDataSyncConnectionTypeAsync
        /// </summary>
        [Fact]
        public void DeleteDataSyncConnectionTypeAsyncTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string providerId = null;
            //string connectionTypeId = null;
            //string? apiVersion = null;
            //string? xVersion = null;
            //DataSyncApiProviderV1DeleteConnectionTypeRequest? dataSyncApiProviderV1DeleteConnectionTypeRequest = null;
            //instance.DeleteDataSyncConnectionTypeAsync(providerId, connectionTypeId, apiVersion, xVersion, dataSyncApiProviderV1DeleteConnectionTypeRequest);
        }

        /// <summary>
        /// Test DeleteDataSyncJobTypeAsync
        /// </summary>
        [Fact]
        public void DeleteDataSyncJobTypeAsyncTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string jobTypeId = null;
            //string? apiVersion = null;
            //string? xVersion = null;
            //DataSyncApiJobTypeV1DeleteJobTypeRequest? dataSyncApiJobTypeV1DeleteJobTypeRequest = null;
            //instance.DeleteDataSyncJobTypeAsync(jobTypeId, apiVersion, xVersion, dataSyncApiJobTypeV1DeleteJobTypeRequest);
        }

        /// <summary>
        /// Test DeleteDataSyncProfileAsync
        /// </summary>
        [Fact]
        public void DeleteDataSyncProfileAsyncTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string jobTypeId = null;
            //string profileId = null;
            //string? apiVersion = null;
            //string? xVersion = null;
            //DataSyncApiJobTypeV1DeleteProfileRequest? dataSyncApiJobTypeV1DeleteProfileRequest = null;
            //instance.DeleteDataSyncProfileAsync(jobTypeId, profileId, apiVersion, xVersion, dataSyncApiJobTypeV1DeleteProfileRequest);
        }

        /// <summary>
        /// Test DeleteDataSyncProviderAsync
        /// </summary>
        [Fact]
        public void DeleteDataSyncProviderAsyncTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string providerId = null;
            //string? apiVersion = null;
            //string? xVersion = null;
            //DataSyncApiProviderV1DeleteProviderRequest? dataSyncApiProviderV1DeleteProviderRequest = null;
            //instance.DeleteDataSyncProviderAsync(providerId, apiVersion, xVersion, dataSyncApiProviderV1DeleteProviderRequest);
        }

        /// <summary>
        /// Test GetAllDataSyncJobTypesAsync
        /// </summary>
        [Fact]
        public void GetAllDataSyncJobTypesAsyncTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? pageSize = null;
            //int? pageIndex = null;
            //string? orderBy = null;
            //string? filter = null;
            //string? apiVersion = null;
            //string? xVersion = null;
            //var response = instance.GetAllDataSyncJobTypesAsync(pageSize, pageIndex, orderBy, filter, apiVersion, xVersion);
            //Assert.IsType<DataSyncApiJobTypeV1JobTypeListResponsePaginatedItemsViewModel>(response);
        }

        /// <summary>
        /// Test GetAllDataSyncProvidersAsync
        /// </summary>
        [Fact]
        public void GetAllDataSyncProvidersAsyncTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? pageSize = null;
            //int? pageIndex = null;
            //string? orderBy = null;
            //string? filter = null;
            //string? apiVersion = null;
            //string? xVersion = null;
            //var response = instance.GetAllDataSyncProvidersAsync(pageSize, pageIndex, orderBy, filter, apiVersion, xVersion);
            //Assert.IsType<DataSyncApiProviderV1ProviderListResponsePaginatedItemsViewModel>(response);
        }

        /// <summary>
        /// Test GetDataSyncJobTypeProfileByIdAsync
        /// </summary>
        [Fact]
        public void GetDataSyncJobTypeProfileByIdAsyncTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string jobTypeId = null;
            //string? apiVersion = null;
            //string? xVersion = null;
            //var response = instance.GetDataSyncJobTypeProfileByIdAsync(jobTypeId, apiVersion, xVersion);
            //Assert.IsType<DataSyncApiJobTypeV1JobTypeProfileResponse>(response);
        }

        /// <summary>
        /// Test GetDataSyncProviderProfileByIdAsync
        /// </summary>
        [Fact]
        public void GetDataSyncProviderProfileByIdAsyncTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string providerId = null;
            //string? apiVersion = null;
            //string? xVersion = null;
            //var response = instance.GetDataSyncProviderProfileByIdAsync(providerId, apiVersion, xVersion);
            //Assert.IsType<DataSyncApiProviderV1ProviderProfileResponse>(response);
        }

        /// <summary>
        /// Test UpdateDataSyncConnectionTypeAsync
        /// </summary>
        [Fact]
        public void UpdateDataSyncConnectionTypeAsyncTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string providerId = null;
            //string connectionTypeId = null;
            //string? apiVersion = null;
            //string? xVersion = null;
            //DataSyncApiProviderV1UpdateConnectionTypeRequest? dataSyncApiProviderV1UpdateConnectionTypeRequest = null;
            //var response = instance.UpdateDataSyncConnectionTypeAsync(providerId, connectionTypeId, apiVersion, xVersion, dataSyncApiProviderV1UpdateConnectionTypeRequest);
            //Assert.IsType<DataSyncApiProviderV1ConnectionTypeUpdatedResponse>(response);
        }

        /// <summary>
        /// Test UpdateDataSyncJobTypeAsync
        /// </summary>
        [Fact]
        public void UpdateDataSyncJobTypeAsyncTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string jobTypeId = null;
            //string? apiVersion = null;
            //string? xVersion = null;
            //DataSyncApiJobTypeV1UpdateJobTypeRequest? dataSyncApiJobTypeV1UpdateJobTypeRequest = null;
            //var response = instance.UpdateDataSyncJobTypeAsync(jobTypeId, apiVersion, xVersion, dataSyncApiJobTypeV1UpdateJobTypeRequest);
            //Assert.IsType<DataSyncApiJobTypeV1JobTypeUpdatedResponse>(response);
        }

        /// <summary>
        /// Test UpdateDataSyncProfileAsync
        /// </summary>
        [Fact]
        public void UpdateDataSyncProfileAsyncTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string jobTypeId = null;
            //string profileId = null;
            //string? apiVersion = null;
            //string? xVersion = null;
            //DataSyncApiJobTypeV1UpdateProfileRequest? dataSyncApiJobTypeV1UpdateProfileRequest = null;
            //var response = instance.UpdateDataSyncProfileAsync(jobTypeId, profileId, apiVersion, xVersion, dataSyncApiJobTypeV1UpdateProfileRequest);
            //Assert.IsType<DataSyncApiJobTypeV1ProfileUpdatedResponse>(response);
        }

        /// <summary>
        /// Test UpdateDataSyncProviderAsync
        /// </summary>
        [Fact]
        public void UpdateDataSyncProviderAsyncTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string providerId = null;
            //string? apiVersion = null;
            //string? xVersion = null;
            //DataSyncApiProviderV1UpdateProviderRequest? dataSyncApiProviderV1UpdateProviderRequest = null;
            //var response = instance.UpdateDataSyncProviderAsync(providerId, apiVersion, xVersion, dataSyncApiProviderV1UpdateProviderRequest);
            //Assert.IsType<DataSyncApiProviderV1ProviderUpdatedResponse>(response);
        }
    }
}
