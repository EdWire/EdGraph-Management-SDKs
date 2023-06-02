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
    /// TenantApiTenantV1UpdateSubscriptionRequest
    /// </summary>
    [DataContract(Name = "TenantApi.Tenant.V1.UpdateSubscriptionRequest")]
    public partial class TenantApiTenantV1UpdateSubscriptionRequest : IEquatable<TenantApiTenantV1UpdateSubscriptionRequest>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets LicenseType
        /// </summary>
        [DataMember(Name = "licenseType", EmitDefaultValue = false)]
        public TenantApiTenantV1LicenseType? LicenseType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TenantApiTenantV1UpdateSubscriptionRequest" /> class.
        /// </summary>
        /// <param name="tenantId">tenantId.</param>
        /// <param name="subscriptionId">subscriptionId.</param>
        /// <param name="startDateTime">startDateTime.</param>
        /// <param name="endDateTime">endDateTime.</param>
        /// <param name="gracePeriod">gracePeriod.</param>
        /// <param name="numberOfLicenses">numberOfLicenses.</param>
        /// <param name="assignedLicenses">assignedLicenses.</param>
        /// <param name="licenseType">licenseType.</param>
        /// <param name="autoAssign">SubscriptionStatus SubscriptionStatus &#x3D; 10;.</param>
        public TenantApiTenantV1UpdateSubscriptionRequest(string tenantId = default(string), string subscriptionId = default(string), string startDateTime = default(string), string endDateTime = default(string), int gracePeriod = default(int), int numberOfLicenses = default(int), int assignedLicenses = default(int), TenantApiTenantV1LicenseType? licenseType = default(TenantApiTenantV1LicenseType?), bool autoAssign = default(bool))
        {
            this.TenantId = tenantId;
            this.SubscriptionId = subscriptionId;
            this.StartDateTime = startDateTime;
            this.EndDateTime = endDateTime;
            this.GracePeriod = gracePeriod;
            this.NumberOfLicenses = numberOfLicenses;
            this.AssignedLicenses = assignedLicenses;
            this.LicenseType = licenseType;
            this.AutoAssign = autoAssign;
        }

        /// <summary>
        /// Gets or Sets TenantId
        /// </summary>
        [DataMember(Name = "tenantId", EmitDefaultValue = true)]
        public string TenantId { get; set; }

        /// <summary>
        /// Gets or Sets SubscriptionId
        /// </summary>
        [DataMember(Name = "subscriptionId", EmitDefaultValue = true)]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// Gets or Sets StartDateTime
        /// </summary>
        [DataMember(Name = "startDateTime", EmitDefaultValue = true)]
        public string StartDateTime { get; set; }

        /// <summary>
        /// Gets or Sets EndDateTime
        /// </summary>
        [DataMember(Name = "endDateTime", EmitDefaultValue = true)]
        public string EndDateTime { get; set; }

        /// <summary>
        /// Gets or Sets GracePeriod
        /// </summary>
        [DataMember(Name = "gracePeriod", EmitDefaultValue = false)]
        public int GracePeriod { get; set; }

        /// <summary>
        /// Gets or Sets NumberOfLicenses
        /// </summary>
        [DataMember(Name = "numberOfLicenses", EmitDefaultValue = false)]
        public int NumberOfLicenses { get; set; }

        /// <summary>
        /// Gets or Sets AssignedLicenses
        /// </summary>
        [DataMember(Name = "assignedLicenses", EmitDefaultValue = false)]
        public int AssignedLicenses { get; set; }

        /// <summary>
        /// SubscriptionStatus SubscriptionStatus &#x3D; 10;
        /// </summary>
        /// <value>SubscriptionStatus SubscriptionStatus &#x3D; 10;</value>
        [DataMember(Name = "autoAssign", EmitDefaultValue = true)]
        public bool AutoAssign { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TenantApiTenantV1UpdateSubscriptionRequest {\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  SubscriptionId: ").Append(SubscriptionId).Append("\n");
            sb.Append("  StartDateTime: ").Append(StartDateTime).Append("\n");
            sb.Append("  EndDateTime: ").Append(EndDateTime).Append("\n");
            sb.Append("  GracePeriod: ").Append(GracePeriod).Append("\n");
            sb.Append("  NumberOfLicenses: ").Append(NumberOfLicenses).Append("\n");
            sb.Append("  AssignedLicenses: ").Append(AssignedLicenses).Append("\n");
            sb.Append("  LicenseType: ").Append(LicenseType).Append("\n");
            sb.Append("  AutoAssign: ").Append(AutoAssign).Append("\n");
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
            return this.Equals(input as TenantApiTenantV1UpdateSubscriptionRequest);
        }

        /// <summary>
        /// Returns true if TenantApiTenantV1UpdateSubscriptionRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TenantApiTenantV1UpdateSubscriptionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TenantApiTenantV1UpdateSubscriptionRequest input)
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
                    this.SubscriptionId == input.SubscriptionId ||
                    (this.SubscriptionId != null &&
                    this.SubscriptionId.Equals(input.SubscriptionId))
                ) && 
                (
                    this.StartDateTime == input.StartDateTime ||
                    (this.StartDateTime != null &&
                    this.StartDateTime.Equals(input.StartDateTime))
                ) && 
                (
                    this.EndDateTime == input.EndDateTime ||
                    (this.EndDateTime != null &&
                    this.EndDateTime.Equals(input.EndDateTime))
                ) && 
                (
                    this.GracePeriod == input.GracePeriod ||
                    this.GracePeriod.Equals(input.GracePeriod)
                ) && 
                (
                    this.NumberOfLicenses == input.NumberOfLicenses ||
                    this.NumberOfLicenses.Equals(input.NumberOfLicenses)
                ) && 
                (
                    this.AssignedLicenses == input.AssignedLicenses ||
                    this.AssignedLicenses.Equals(input.AssignedLicenses)
                ) && 
                (
                    this.LicenseType == input.LicenseType ||
                    this.LicenseType.Equals(input.LicenseType)
                ) && 
                (
                    this.AutoAssign == input.AutoAssign ||
                    this.AutoAssign.Equals(input.AutoAssign)
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
                if (this.SubscriptionId != null)
                {
                    hashCode = (hashCode * 59) + this.SubscriptionId.GetHashCode();
                }
                if (this.StartDateTime != null)
                {
                    hashCode = (hashCode * 59) + this.StartDateTime.GetHashCode();
                }
                if (this.EndDateTime != null)
                {
                    hashCode = (hashCode * 59) + this.EndDateTime.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.GracePeriod.GetHashCode();
                hashCode = (hashCode * 59) + this.NumberOfLicenses.GetHashCode();
                hashCode = (hashCode * 59) + this.AssignedLicenses.GetHashCode();
                hashCode = (hashCode * 59) + this.LicenseType.GetHashCode();
                hashCode = (hashCode * 59) + this.AutoAssign.GetHashCode();
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
