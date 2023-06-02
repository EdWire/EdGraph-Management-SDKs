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
    /// TenantApiTenantV1TenantProfileResponse
    /// </summary>
    [DataContract(Name = "TenantApi.Tenant.V1.TenantProfileResponse")]
    public partial class TenantApiTenantV1TenantProfileResponse : IEquatable<TenantApiTenantV1TenantProfileResponse>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets TenantType
        /// </summary>
        [DataMember(Name = "tenantType", EmitDefaultValue = false)]
        public TenantApiTenantV1TenantType? TenantType { get; set; }

        /// <summary>
        /// Gets or Sets TenantStatus
        /// </summary>
        [DataMember(Name = "tenantStatus", EmitDefaultValue = false)]
        public TenantApiTenantV1TenantStatus? TenantStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TenantApiTenantV1TenantProfileResponse" /> class.
        /// </summary>
        /// <param name="tenantId">tenantId.</param>
        /// <param name="tenantType">tenantType.</param>
        /// <param name="organizationIdentifier">organizationIdentifier.</param>
        /// <param name="organizationName">organizationName.</param>
        /// <param name="state">state.</param>
        /// <param name="tenantStatus">tenantStatus.</param>
        /// <param name="isDemo">isDemo.</param>
        /// <param name="enforceMfa">enforceMfa.</param>
        /// <param name="subscriptionsMigrated">subscriptionsMigrated.</param>
        /// <param name="createdBy">createdBy.</param>
        /// <param name="createdDateTime">createdDateTime.</param>
        /// <param name="lastModifiedBy">lastModifiedBy.</param>
        /// <param name="lastModifiedDateTime">lastModifiedDateTime.</param>
        public TenantApiTenantV1TenantProfileResponse(string tenantId = default(string), TenantApiTenantV1TenantType? tenantType = default(TenantApiTenantV1TenantType?), string organizationIdentifier = default(string), string organizationName = default(string), string state = default(string), TenantApiTenantV1TenantStatus? tenantStatus = default(TenantApiTenantV1TenantStatus?), bool isDemo = default(bool), bool enforceMfa = default(bool), bool subscriptionsMigrated = default(bool), string createdBy = default(string), string createdDateTime = default(string), string lastModifiedBy = default(string), string lastModifiedDateTime = default(string))
        {
            this.TenantId = tenantId;
            this.TenantType = tenantType;
            this.OrganizationIdentifier = organizationIdentifier;
            this.OrganizationName = organizationName;
            this.State = state;
            this.TenantStatus = tenantStatus;
            this.IsDemo = isDemo;
            this.EnforceMfa = enforceMfa;
            this.SubscriptionsMigrated = subscriptionsMigrated;
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
        /// Gets or Sets OrganizationIdentifier
        /// </summary>
        [DataMember(Name = "organizationIdentifier", EmitDefaultValue = true)]
        public string OrganizationIdentifier { get; set; }

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
        /// Gets or Sets IsDemo
        /// </summary>
        [DataMember(Name = "isDemo", EmitDefaultValue = true)]
        public bool IsDemo { get; set; }

        /// <summary>
        /// Gets or Sets EnforceMfa
        /// </summary>
        [DataMember(Name = "enforceMfa", EmitDefaultValue = true)]
        public bool EnforceMfa { get; set; }

        /// <summary>
        /// Gets or Sets SubscriptionsMigrated
        /// </summary>
        [DataMember(Name = "subscriptionsMigrated", EmitDefaultValue = true)]
        public bool SubscriptionsMigrated { get; set; }

        /// <summary>
        /// Gets or Sets Subscriptions
        /// </summary>
        [DataMember(Name = "subscriptions", EmitDefaultValue = true)]
        public List<TenantApiTenantV1SubscriptionProfileResponse> Subscriptions { get; private set; }

        /// <summary>
        /// Returns false as Subscriptions should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSubscriptions()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Domains
        /// </summary>
        [DataMember(Name = "domains", EmitDefaultValue = true)]
        public List<string> Domains { get; private set; }

        /// <summary>
        /// Returns false as Domains should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDomains()
        {
            return false;
        }
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
        /// Gets or Sets IdentityProviders
        /// </summary>
        [DataMember(Name = "identityProviders", EmitDefaultValue = true)]
        public List<TenantApiTenantV1TenantIdentityProviders> IdentityProviders { get; private set; }

        /// <summary>
        /// Returns false as IdentityProviders should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeIdentityProviders()
        {
            return false;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TenantApiTenantV1TenantProfileResponse {\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  TenantType: ").Append(TenantType).Append("\n");
            sb.Append("  OrganizationIdentifier: ").Append(OrganizationIdentifier).Append("\n");
            sb.Append("  OrganizationName: ").Append(OrganizationName).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  TenantStatus: ").Append(TenantStatus).Append("\n");
            sb.Append("  IsDemo: ").Append(IsDemo).Append("\n");
            sb.Append("  EnforceMfa: ").Append(EnforceMfa).Append("\n");
            sb.Append("  SubscriptionsMigrated: ").Append(SubscriptionsMigrated).Append("\n");
            sb.Append("  Subscriptions: ").Append(Subscriptions).Append("\n");
            sb.Append("  Domains: ").Append(Domains).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  CreatedDateTime: ").Append(CreatedDateTime).Append("\n");
            sb.Append("  LastModifiedBy: ").Append(LastModifiedBy).Append("\n");
            sb.Append("  LastModifiedDateTime: ").Append(LastModifiedDateTime).Append("\n");
            sb.Append("  IdentityProviders: ").Append(IdentityProviders).Append("\n");
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
            return this.Equals(input as TenantApiTenantV1TenantProfileResponse);
        }

        /// <summary>
        /// Returns true if TenantApiTenantV1TenantProfileResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of TenantApiTenantV1TenantProfileResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TenantApiTenantV1TenantProfileResponse input)
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
                    this.TenantType == input.TenantType ||
                    this.TenantType.Equals(input.TenantType)
                ) && 
                (
                    this.OrganizationIdentifier == input.OrganizationIdentifier ||
                    (this.OrganizationIdentifier != null &&
                    this.OrganizationIdentifier.Equals(input.OrganizationIdentifier))
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
                    this.TenantStatus == input.TenantStatus ||
                    this.TenantStatus.Equals(input.TenantStatus)
                ) && 
                (
                    this.IsDemo == input.IsDemo ||
                    this.IsDemo.Equals(input.IsDemo)
                ) && 
                (
                    this.EnforceMfa == input.EnforceMfa ||
                    this.EnforceMfa.Equals(input.EnforceMfa)
                ) && 
                (
                    this.SubscriptionsMigrated == input.SubscriptionsMigrated ||
                    this.SubscriptionsMigrated.Equals(input.SubscriptionsMigrated)
                ) && 
                (
                    this.Subscriptions == input.Subscriptions ||
                    this.Subscriptions != null &&
                    input.Subscriptions != null &&
                    this.Subscriptions.SequenceEqual(input.Subscriptions)
                ) && 
                (
                    this.Domains == input.Domains ||
                    this.Domains != null &&
                    input.Domains != null &&
                    this.Domains.SequenceEqual(input.Domains)
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
                    this.IdentityProviders == input.IdentityProviders ||
                    this.IdentityProviders != null &&
                    input.IdentityProviders != null &&
                    this.IdentityProviders.SequenceEqual(input.IdentityProviders)
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
                hashCode = (hashCode * 59) + this.TenantType.GetHashCode();
                if (this.OrganizationIdentifier != null)
                {
                    hashCode = (hashCode * 59) + this.OrganizationIdentifier.GetHashCode();
                }
                if (this.OrganizationName != null)
                {
                    hashCode = (hashCode * 59) + this.OrganizationName.GetHashCode();
                }
                if (this.State != null)
                {
                    hashCode = (hashCode * 59) + this.State.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TenantStatus.GetHashCode();
                hashCode = (hashCode * 59) + this.IsDemo.GetHashCode();
                hashCode = (hashCode * 59) + this.EnforceMfa.GetHashCode();
                hashCode = (hashCode * 59) + this.SubscriptionsMigrated.GetHashCode();
                if (this.Subscriptions != null)
                {
                    hashCode = (hashCode * 59) + this.Subscriptions.GetHashCode();
                }
                if (this.Domains != null)
                {
                    hashCode = (hashCode * 59) + this.Domains.GetHashCode();
                }
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
                if (this.IdentityProviders != null)
                {
                    hashCode = (hashCode * 59) + this.IdentityProviders.GetHashCode();
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
