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
    /// EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsResponsesIdentityResourceResponse
    /// </summary>
    [DataContract(Name = "EdGraph.HttpAggregators.Management.Api.Controllers.v1.ViewModels.Responses.IdentityResourceResponse")]
    public partial class EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsResponsesIdentityResourceResponse : IEquatable<EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsResponsesIdentityResourceResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsResponsesIdentityResourceResponse" /> class.
        /// </summary>
        /// <param name="id">The primary key of the resource..</param>
        /// <param name="name">The unique name of the resource..</param>
        /// <param name="displayName">Display name of the resource..</param>
        /// <param name="description">Description of the resource..</param>
        /// <param name="showInDiscoveryDocument">Specifies whether this scope is shown in the discovery document. Defaults to true..</param>
        /// <param name="enabled">Indicates if this resource is enabled. Defaults to true..</param>
        public EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsResponsesIdentityResourceResponse(Guid id = default(Guid), string name = default(string), string displayName = default(string), string description = default(string), bool showInDiscoveryDocument = default(bool), bool enabled = default(bool))
        {
            this.Id = id;
            this.Name = name;
            this.DisplayName = displayName;
            this.Description = description;
            this.ShowInDiscoveryDocument = showInDiscoveryDocument;
            this.Enabled = enabled;
        }

        /// <summary>
        /// The primary key of the resource.
        /// </summary>
        /// <value>The primary key of the resource.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// The unique name of the resource.
        /// </summary>
        /// <value>The unique name of the resource.</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Display name of the resource.
        /// </summary>
        /// <value>Display name of the resource.</value>
        [DataMember(Name = "displayName", EmitDefaultValue = true)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Description of the resource.
        /// </summary>
        /// <value>Description of the resource.</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Specifies whether this scope is shown in the discovery document. Defaults to true.
        /// </summary>
        /// <value>Specifies whether this scope is shown in the discovery document. Defaults to true.</value>
        [DataMember(Name = "showInDiscoveryDocument", EmitDefaultValue = true)]
        public bool ShowInDiscoveryDocument { get; set; }

        /// <summary>
        /// Indicates if this resource is enabled. Defaults to true.
        /// </summary>
        /// <value>Indicates if this resource is enabled. Defaults to true.</value>
        [DataMember(Name = "enabled", EmitDefaultValue = true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsResponsesIdentityResourceResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ShowInDiscoveryDocument: ").Append(ShowInDiscoveryDocument).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
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
            return this.Equals(input as EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsResponsesIdentityResourceResponse);
        }

        /// <summary>
        /// Returns true if EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsResponsesIdentityResourceResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsResponsesIdentityResourceResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsResponsesIdentityResourceResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.ShowInDiscoveryDocument == input.ShowInDiscoveryDocument ||
                    this.ShowInDiscoveryDocument.Equals(input.ShowInDiscoveryDocument)
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    this.Enabled.Equals(input.Enabled)
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.DisplayName != null)
                {
                    hashCode = (hashCode * 59) + this.DisplayName.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ShowInDiscoveryDocument.GetHashCode();
                hashCode = (hashCode * 59) + this.Enabled.GetHashCode();
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
