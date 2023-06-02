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
    /// RegistrationApiRegistrationV1RegistrationListResponse
    /// </summary>
    [DataContract(Name = "RegistrationApi.Registration.V1.RegistrationListResponse")]
    public partial class RegistrationApiRegistrationV1RegistrationListResponse : IEquatable<RegistrationApiRegistrationV1RegistrationListResponse>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets TenantType
        /// </summary>
        [DataMember(Name = "tenantType", EmitDefaultValue = false)]
        public RegistrationApiRegistrationV1TenantType? TenantType { get; set; }

        /// <summary>
        /// Gets or Sets ApprovalStatus
        /// </summary>
        [DataMember(Name = "approvalStatus", EmitDefaultValue = false)]
        public RegistrationApiRegistrationV1ApprovalStatus? ApprovalStatus { get; set; }

        /// <summary>
        /// Gets or Sets SubmittedBy
        /// </summary>
        [DataMember(Name = "submittedBy", EmitDefaultValue = false)]
        public RegistrationApiRegistrationV1SubmittedBy? SubmittedBy { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RegistrationApiRegistrationV1RegistrationListResponse" /> class.
        /// </summary>
        /// <param name="registrationId">registrationId.</param>
        /// <param name="tenantType">tenantType.</param>
        /// <param name="firstName">firstName.</param>
        /// <param name="lastName">lastName.</param>
        /// <param name="email">email.</param>
        /// <param name="organizationName">organizationName.</param>
        /// <param name="state">state.</param>
        /// <param name="approvalStatus">approvalStatus.</param>
        /// <param name="submittedBy">submittedBy.</param>
        /// <param name="createdBy">createdBy.</param>
        /// <param name="createdDateTime">createdDateTime.</param>
        /// <param name="lastModifiedBy">lastModifiedBy.</param>
        /// <param name="lastModifiedDateTime">lastModifiedDateTime.</param>
        /// <param name="azureSubscriptionId">azureSubscriptionId.</param>
        /// <param name="azureSubscriptionStoragePath">azureSubscriptionStoragePath.</param>
        /// <param name="registrationSource">registrationSource.</param>
        public RegistrationApiRegistrationV1RegistrationListResponse(string registrationId = default(string), RegistrationApiRegistrationV1TenantType? tenantType = default(RegistrationApiRegistrationV1TenantType?), string firstName = default(string), string lastName = default(string), string email = default(string), string organizationName = default(string), string state = default(string), RegistrationApiRegistrationV1ApprovalStatus? approvalStatus = default(RegistrationApiRegistrationV1ApprovalStatus?), RegistrationApiRegistrationV1SubmittedBy? submittedBy = default(RegistrationApiRegistrationV1SubmittedBy?), string createdBy = default(string), string createdDateTime = default(string), string lastModifiedBy = default(string), string lastModifiedDateTime = default(string), string azureSubscriptionId = default(string), string azureSubscriptionStoragePath = default(string), string registrationSource = default(string))
        {
            this.RegistrationId = registrationId;
            this.TenantType = tenantType;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.OrganizationName = organizationName;
            this.State = state;
            this.ApprovalStatus = approvalStatus;
            this.SubmittedBy = submittedBy;
            this.CreatedBy = createdBy;
            this.CreatedDateTime = createdDateTime;
            this.LastModifiedBy = lastModifiedBy;
            this.LastModifiedDateTime = lastModifiedDateTime;
            this.AzureSubscriptionId = azureSubscriptionId;
            this.AzureSubscriptionStoragePath = azureSubscriptionStoragePath;
            this.RegistrationSource = registrationSource;
        }

        /// <summary>
        /// Gets or Sets RegistrationId
        /// </summary>
        [DataMember(Name = "registrationId", EmitDefaultValue = true)]
        public string RegistrationId { get; set; }

        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [DataMember(Name = "firstName", EmitDefaultValue = true)]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        [DataMember(Name = "lastName", EmitDefaultValue = true)]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name = "email", EmitDefaultValue = true)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets OrganizationName
        /// </summary>
        [DataMember(Name = "organizationName", EmitDefaultValue = true)]
        public string OrganizationName { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = true)]
        public string State { get; set; }

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
        /// Gets or Sets ApplicationIds
        /// </summary>
        [DataMember(Name = "applicationIds", EmitDefaultValue = true)]
        public List<string> ApplicationIds { get; private set; }

        /// <summary>
        /// Returns false as ApplicationIds should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeApplicationIds()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets AzureSubscriptionId
        /// </summary>
        [DataMember(Name = "azureSubscriptionId", EmitDefaultValue = true)]
        public string AzureSubscriptionId { get; set; }

        /// <summary>
        /// Gets or Sets AzureSubscriptionStoragePath
        /// </summary>
        [DataMember(Name = "azureSubscriptionStoragePath", EmitDefaultValue = true)]
        public string AzureSubscriptionStoragePath { get; set; }

        /// <summary>
        /// Gets or Sets RegistrationSource
        /// </summary>
        [DataMember(Name = "registrationSource", EmitDefaultValue = true)]
        public string RegistrationSource { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RegistrationApiRegistrationV1RegistrationListResponse {\n");
            sb.Append("  RegistrationId: ").Append(RegistrationId).Append("\n");
            sb.Append("  TenantType: ").Append(TenantType).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  OrganizationName: ").Append(OrganizationName).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  ApprovalStatus: ").Append(ApprovalStatus).Append("\n");
            sb.Append("  SubmittedBy: ").Append(SubmittedBy).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  CreatedDateTime: ").Append(CreatedDateTime).Append("\n");
            sb.Append("  LastModifiedBy: ").Append(LastModifiedBy).Append("\n");
            sb.Append("  LastModifiedDateTime: ").Append(LastModifiedDateTime).Append("\n");
            sb.Append("  ApplicationIds: ").Append(ApplicationIds).Append("\n");
            sb.Append("  AzureSubscriptionId: ").Append(AzureSubscriptionId).Append("\n");
            sb.Append("  AzureSubscriptionStoragePath: ").Append(AzureSubscriptionStoragePath).Append("\n");
            sb.Append("  RegistrationSource: ").Append(RegistrationSource).Append("\n");
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
            return this.Equals(input as RegistrationApiRegistrationV1RegistrationListResponse);
        }

        /// <summary>
        /// Returns true if RegistrationApiRegistrationV1RegistrationListResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of RegistrationApiRegistrationV1RegistrationListResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RegistrationApiRegistrationV1RegistrationListResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.RegistrationId == input.RegistrationId ||
                    (this.RegistrationId != null &&
                    this.RegistrationId.Equals(input.RegistrationId))
                ) && 
                (
                    this.TenantType == input.TenantType ||
                    this.TenantType.Equals(input.TenantType)
                ) && 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.OrganizationName == input.OrganizationName ||
                    (this.OrganizationName != null &&
                    this.OrganizationName.Equals(input.OrganizationName))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.ApprovalStatus == input.ApprovalStatus ||
                    this.ApprovalStatus.Equals(input.ApprovalStatus)
                ) && 
                (
                    this.SubmittedBy == input.SubmittedBy ||
                    this.SubmittedBy.Equals(input.SubmittedBy)
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
                ) && 
                (
                    this.ApplicationIds == input.ApplicationIds ||
                    this.ApplicationIds != null &&
                    input.ApplicationIds != null &&
                    this.ApplicationIds.SequenceEqual(input.ApplicationIds)
                ) && 
                (
                    this.AzureSubscriptionId == input.AzureSubscriptionId ||
                    (this.AzureSubscriptionId != null &&
                    this.AzureSubscriptionId.Equals(input.AzureSubscriptionId))
                ) && 
                (
                    this.AzureSubscriptionStoragePath == input.AzureSubscriptionStoragePath ||
                    (this.AzureSubscriptionStoragePath != null &&
                    this.AzureSubscriptionStoragePath.Equals(input.AzureSubscriptionStoragePath))
                ) && 
                (
                    this.RegistrationSource == input.RegistrationSource ||
                    (this.RegistrationSource != null &&
                    this.RegistrationSource.Equals(input.RegistrationSource))
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
                if (this.RegistrationId != null)
                {
                    hashCode = (hashCode * 59) + this.RegistrationId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TenantType.GetHashCode();
                if (this.FirstName != null)
                {
                    hashCode = (hashCode * 59) + this.FirstName.GetHashCode();
                }
                if (this.LastName != null)
                {
                    hashCode = (hashCode * 59) + this.LastName.GetHashCode();
                }
                if (this.Email != null)
                {
                    hashCode = (hashCode * 59) + this.Email.GetHashCode();
                }
                if (this.OrganizationName != null)
                {
                    hashCode = (hashCode * 59) + this.OrganizationName.GetHashCode();
                }
                if (this.State != null)
                {
                    hashCode = (hashCode * 59) + this.State.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ApprovalStatus.GetHashCode();
                hashCode = (hashCode * 59) + this.SubmittedBy.GetHashCode();
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
                if (this.ApplicationIds != null)
                {
                    hashCode = (hashCode * 59) + this.ApplicationIds.GetHashCode();
                }
                if (this.AzureSubscriptionId != null)
                {
                    hashCode = (hashCode * 59) + this.AzureSubscriptionId.GetHashCode();
                }
                if (this.AzureSubscriptionStoragePath != null)
                {
                    hashCode = (hashCode * 59) + this.AzureSubscriptionStoragePath.GetHashCode();
                }
                if (this.RegistrationSource != null)
                {
                    hashCode = (hashCode * 59) + this.RegistrationSource.GetHashCode();
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