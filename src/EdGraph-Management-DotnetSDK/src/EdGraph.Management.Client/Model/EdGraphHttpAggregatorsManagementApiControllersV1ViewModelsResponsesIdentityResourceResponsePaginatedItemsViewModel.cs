/*
 * Management Api
 *
 * Api to help platform wide items such as users, tenants, applications, subscriptions, etc.
 *
 * The version of the OpenAPI document: v1.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = EdGraph.Management.Client.Client.OpenAPIDateConverter;

namespace EdGraph.Management.Client.Model
{
    /// <summary>
    /// EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsResponsesIdentityResourceResponsePaginatedItemsViewModel
    /// </summary>
    [DataContract(Name = "EdGraph.HttpAggregators.Management.Api.Controllers.v1.ViewModels.Responses.IdentityResourceResponsePaginatedItemsViewModel")]
    public partial class EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsResponsesIdentityResourceResponsePaginatedItemsViewModel : IEquatable<EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsResponsesIdentityResourceResponsePaginatedItemsViewModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsResponsesIdentityResourceResponsePaginatedItemsViewModel" /> class.
        /// </summary>
        /// <param name="pageIndex">pageIndex.</param>
        /// <param name="pageSize">pageSize.</param>
        /// <param name="count">count.</param>
        /// <param name="data">data.</param>
        public EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsResponsesIdentityResourceResponsePaginatedItemsViewModel(int pageIndex = default(int), int pageSize = default(int), long count = default(long), List<EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsResponsesIdentityResourceResponse> data = default(List<EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsResponsesIdentityResourceResponse>))
        {
            this.PageIndex = pageIndex;
            this.PageSize = pageSize;
            this.Count = count;
            this.Data = data;
        }

        /// <summary>
        /// Gets or Sets PageIndex
        /// </summary>
        [DataMember(Name = "pageIndex", EmitDefaultValue = false)]
        public int PageIndex { get; set; }

        /// <summary>
        /// Gets or Sets PageSize
        /// </summary>
        [DataMember(Name = "pageSize", EmitDefaultValue = false)]
        public int PageSize { get; set; }

        /// <summary>
        /// Gets or Sets Count
        /// </summary>
        [DataMember(Name = "count", EmitDefaultValue = false)]
        public long Count { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = true)]
        public List<EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsResponsesIdentityResourceResponse> Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsResponsesIdentityResourceResponsePaginatedItemsViewModel {\n");
            sb.Append("  PageIndex: ").Append(PageIndex).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsResponsesIdentityResourceResponsePaginatedItemsViewModel);
        }

        /// <summary>
        /// Returns true if EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsResponsesIdentityResourceResponsePaginatedItemsViewModel instances are equal
        /// </summary>
        /// <param name="input">Instance of EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsResponsesIdentityResourceResponsePaginatedItemsViewModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsResponsesIdentityResourceResponsePaginatedItemsViewModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PageIndex == input.PageIndex ||
                    this.PageIndex.Equals(input.PageIndex)
                ) && 
                (
                    this.PageSize == input.PageSize ||
                    this.PageSize.Equals(input.PageSize)
                ) && 
                (
                    this.Count == input.Count ||
                    this.Count.Equals(input.Count)
                ) && 
                (
                    this.Data == input.Data ||
                    this.Data != null &&
                    input.Data != null &&
                    this.Data.SequenceEqual(input.Data)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                hashCode = (hashCode * 59) + this.PageIndex.GetHashCode();
                hashCode = (hashCode * 59) + this.PageSize.GetHashCode();
                hashCode = (hashCode * 59) + this.Count.GetHashCode();
                if (this.Data != null)
                {
                    hashCode = (hashCode * 59) + this.Data.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}