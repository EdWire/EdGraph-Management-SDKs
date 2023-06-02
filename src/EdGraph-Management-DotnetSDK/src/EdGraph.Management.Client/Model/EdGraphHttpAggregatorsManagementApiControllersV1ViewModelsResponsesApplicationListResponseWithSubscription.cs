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
    /// EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsResponsesApplicationListResponseWithSubscription
    /// </summary>
    [DataContract(Name = "EdGraph.HttpAggregators.Management.Api.Controllers.v1.ViewModels.Responses.ApplicationListResponseWithSubscription")]
    public partial class EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsResponsesApplicationListResponseWithSubscription : IEquatable<EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsResponsesApplicationListResponseWithSubscription>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets ApplicationStatus
        /// </summary>
        [DataMember(Name = "applicationStatus", EmitDefaultValue = false)]
        public EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsResponsesApplicationStatus? ApplicationStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsResponsesApplicationListResponseWithSubscription" /> class.
        /// </summary>
        /// <param name="tenantId">tenantId.</param>
        /// <param name="applicationTenantId">applicationTenantId.</param>
        /// <param name="applicationId">applicationId.</param>
        /// <param name="applicationName">applicationName.</param>
        /// <param name="version">version.</param>
        /// <param name="tags">tags.</param>
        /// <param name="groups">groups.</param>
        /// <param name="applicationStatus">applicationStatus.</param>
        /// <param name="isInternal">isInternal.</param>
        /// <param name="roles">roles.</param>
        /// <param name="isTenantSubscribed">isTenantSubscribed.</param>
        /// <param name="isDefault">isDefault.</param>
        /// <param name="createdBy">createdBy.</param>
        /// <param name="createdDateTime">createdDateTime.</param>
        /// <param name="lastModifiedBy">lastModifiedBy.</param>
        /// <param name="lastModifiedDateTime">lastModifiedDateTime.</param>
        public EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsResponsesApplicationListResponseWithSubscription(string tenantId = default(string), string applicationTenantId = default(string), string applicationId = default(string), string applicationName = default(string), string version = default(string), string tags = default(string), string groups = default(string), EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsResponsesApplicationStatus? applicationStatus = default(EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsResponsesApplicationStatus?), bool isInternal = default(bool), List<EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsResponsesRole> roles = default(List<EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsResponsesRole>), bool isTenantSubscribed = default(bool), bool isDefault = default(bool), string createdBy = default(string), string createdDateTime = default(string), string lastModifiedBy = default(string), string lastModifiedDateTime = default(string))
        {
            this.TenantId = tenantId;
            this.ApplicationTenantId = applicationTenantId;
            this.ApplicationId = applicationId;
            this.ApplicationName = applicationName;
            this._Version = version;
            this.Tags = tags;
            this.Groups = groups;
            this.ApplicationStatus = applicationStatus;
            this.IsInternal = isInternal;
            this.Roles = roles;
            this.IsTenantSubscribed = isTenantSubscribed;
            this.IsDefault = isDefault;
            this.CreatedBy = createdBy;
            this.CreatedDateTime = createdDateTime;
            this.LastModifiedBy = lastModifiedBy;
            this.LastModifiedDateTime = lastModifiedDateTime;
        }

        /// <summary>
        /// Gets or Sets TenantId
        /// </summary>
        [DataMember(Name = "tenantId", EmitDefaultValue = true)]
        public string TenantId { get; set; }

        /// <summary>
        /// Gets or Sets ApplicationTenantId
        /// </summary>
        [DataMember(Name = "applicationTenantId", EmitDefaultValue = true)]
        public string ApplicationTenantId { get; set; }

        /// <summary>
        /// Gets or Sets ApplicationId
        /// </summary>
        [DataMember(Name = "applicationId", EmitDefaultValue = true)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Gets or Sets ApplicationName
        /// </summary>
        [DataMember(Name = "applicationName", EmitDefaultValue = true)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// Gets or Sets _Version
        /// </summary>
        [DataMember(Name = "version", EmitDefaultValue = true)]
        public string _Version { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name = "tags", EmitDefaultValue = true)]
        public string Tags { get; set; }

        /// <summary>
        /// Gets or Sets Groups
        /// </summary>
        [DataMember(Name = "groups", EmitDefaultValue = true)]
        public string Groups { get; set; }

        /// <summary>
        /// Gets or Sets IsInternal
        /// </summary>
        [DataMember(Name = "isInternal", EmitDefaultValue = true)]
        public bool IsInternal { get; set; }

        /// <summary>
        /// Gets or Sets Roles
        /// </summary>
        [DataMember(Name = "roles", EmitDefaultValue = true)]
        public List<EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsResponsesRole> Roles { get; set; }

        /// <summary>
        /// Gets or Sets IsTenantSubscribed
        /// </summary>
        [DataMember(Name = "isTenantSubscribed", EmitDefaultValue = true)]
        public bool IsTenantSubscribed { get; set; }

        /// <summary>
        /// Gets or Sets IsDefault
        /// </summary>
        [DataMember(Name = "isDefault", EmitDefaultValue = true)]
        public bool IsDefault { get; set; }

        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name = "createdBy", EmitDefaultValue = true)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Gets or Sets CreatedDateTime
        /// </summary>
        [DataMember(Name = "createdDateTime", EmitDefaultValue = true)]
        public string CreatedDateTime { get; set; }

        /// <summary>
        /// Gets or Sets LastModifiedBy
        /// </summary>
        [DataMember(Name = "lastModifiedBy", EmitDefaultValue = true)]
        public string LastModifiedBy { get; set; }

        /// <summary>
        /// Gets or Sets LastModifiedDateTime
        /// </summary>
        [DataMember(Name = "lastModifiedDateTime", EmitDefaultValue = true)]
        public string LastModifiedDateTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsResponsesApplicationListResponseWithSubscription {\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  ApplicationTenantId: ").Append(ApplicationTenantId).Append("\n");
            sb.Append("  ApplicationId: ").Append(ApplicationId).Append("\n");
            sb.Append("  ApplicationName: ").Append(ApplicationName).Append("\n");
            sb.Append("  _Version: ").Append(_Version).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Groups: ").Append(Groups).Append("\n");
            sb.Append("  ApplicationStatus: ").Append(ApplicationStatus).Append("\n");
            sb.Append("  IsInternal: ").Append(IsInternal).Append("\n");
            sb.Append("  Roles: ").Append(Roles).Append("\n");
            sb.Append("  IsTenantSubscribed: ").Append(IsTenantSubscribed).Append("\n");
            sb.Append("  IsDefault: ").Append(IsDefault).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  CreatedDateTime: ").Append(CreatedDateTime).Append("\n");
            sb.Append("  LastModifiedBy: ").Append(LastModifiedBy).Append("\n");
            sb.Append("  LastModifiedDateTime: ").Append(LastModifiedDateTime).Append("\n");
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
            return this.Equals(input as EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsResponsesApplicationListResponseWithSubscription);
        }

        /// <summary>
        /// Returns true if EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsResponsesApplicationListResponseWithSubscription instances are equal
        /// </summary>
        /// <param name="input">Instance of EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsResponsesApplicationListResponseWithSubscription to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsResponsesApplicationListResponseWithSubscription input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
                ) && 
                (
                    this.ApplicationTenantId == input.ApplicationTenantId ||
                    (this.ApplicationTenantId != null &&
                    this.ApplicationTenantId.Equals(input.ApplicationTenantId))
                ) && 
                (
                    this.ApplicationId == input.ApplicationId ||
                    (this.ApplicationId != null &&
                    this.ApplicationId.Equals(input.ApplicationId))
                ) && 
                (
                    this.ApplicationName == input.ApplicationName ||
                    (this.ApplicationName != null &&
                    this.ApplicationName.Equals(input.ApplicationName))
                ) && 
                (
                    this._Version == input._Version ||
                    (this._Version != null &&
                    this._Version.Equals(input._Version))
                ) && 
                (
                    this.Tags == input.Tags ||
                    (this.Tags != null &&
                    this.Tags.Equals(input.Tags))
                ) && 
                (
                    this.Groups == input.Groups ||
                    (this.Groups != null &&
                    this.Groups.Equals(input.Groups))
                ) && 
                (
                    this.ApplicationStatus == input.ApplicationStatus ||
                    this.ApplicationStatus.Equals(input.ApplicationStatus)
                ) && 
                (
                    this.IsInternal == input.IsInternal ||
                    this.IsInternal.Equals(input.IsInternal)
                ) && 
                (
                    this.Roles == input.Roles ||
                    this.Roles != null &&
                    input.Roles != null &&
                    this.Roles.SequenceEqual(input.Roles)
                ) && 
                (
                    this.IsTenantSubscribed == input.IsTenantSubscribed ||
                    this.IsTenantSubscribed.Equals(input.IsTenantSubscribed)
                ) && 
                (
                    this.IsDefault == input.IsDefault ||
                    this.IsDefault.Equals(input.IsDefault)
                ) && 
                (
                    this.CreatedBy == input.CreatedBy ||
                    (this.CreatedBy != null &&
                    this.CreatedBy.Equals(input.CreatedBy))
                ) && 
                (
                    this.CreatedDateTime == input.CreatedDateTime ||
                    (this.CreatedDateTime != null &&
                    this.CreatedDateTime.Equals(input.CreatedDateTime))
                ) && 
                (
                    this.LastModifiedBy == input.LastModifiedBy ||
                    (this.LastModifiedBy != null &&
                    this.LastModifiedBy.Equals(input.LastModifiedBy))
                ) && 
                (
                    this.LastModifiedDateTime == input.LastModifiedDateTime ||
                    (this.LastModifiedDateTime != null &&
                    this.LastModifiedDateTime.Equals(input.LastModifiedDateTime))
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
                if (this.TenantId != null)
                {
                    hashCode = (hashCode * 59) + this.TenantId.GetHashCode();
                }
                if (this.ApplicationTenantId != null)
                {
                    hashCode = (hashCode * 59) + this.ApplicationTenantId.GetHashCode();
                }
                if (this.ApplicationId != null)
                {
                    hashCode = (hashCode * 59) + this.ApplicationId.GetHashCode();
                }
                if (this.ApplicationName != null)
                {
                    hashCode = (hashCode * 59) + this.ApplicationName.GetHashCode();
                }
                if (this._Version != null)
                {
                    hashCode = (hashCode * 59) + this._Version.GetHashCode();
                }
                if (this.Tags != null)
                {
                    hashCode = (hashCode * 59) + this.Tags.GetHashCode();
                }
                if (this.Groups != null)
                {
                    hashCode = (hashCode * 59) + this.Groups.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ApplicationStatus.GetHashCode();
                hashCode = (hashCode * 59) + this.IsInternal.GetHashCode();
                if (this.Roles != null)
                {
                    hashCode = (hashCode * 59) + this.Roles.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsTenantSubscribed.GetHashCode();
                hashCode = (hashCode * 59) + this.IsDefault.GetHashCode();
                if (this.CreatedBy != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedBy.GetHashCode();
                }
                if (this.CreatedDateTime != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedDateTime.GetHashCode();
                }
                if (this.LastModifiedBy != null)
                {
                    hashCode = (hashCode * 59) + this.LastModifiedBy.GetHashCode();
                }
                if (this.LastModifiedDateTime != null)
                {
                    hashCode = (hashCode * 59) + this.LastModifiedDateTime.GetHashCode();
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
