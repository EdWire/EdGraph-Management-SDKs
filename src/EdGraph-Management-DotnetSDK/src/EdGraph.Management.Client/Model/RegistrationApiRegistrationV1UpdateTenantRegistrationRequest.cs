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
    /// RegistrationApiRegistrationV1UpdateTenantRegistrationRequest
    /// </summary>
    [DataContract(Name = "RegistrationApi.Registration.V1.UpdateTenantRegistrationRequest")]
    public partial class RegistrationApiRegistrationV1UpdateTenantRegistrationRequest : IEquatable<RegistrationApiRegistrationV1UpdateTenantRegistrationRequest>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets TenantType
        /// </summary>
        [DataMember(Name = "tenantType", EmitDefaultValue = false)]
        public RegistrationApiRegistrationV1TenantType? TenantType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RegistrationApiRegistrationV1UpdateTenantRegistrationRequest" /> class.
        /// </summary>
        /// <param name="registrationId">registrationId.</param>
        /// <param name="tenantType">tenantType.</param>
        /// <param name="firstName">firstName.</param>
        /// <param name="lastName">lastName.</param>
        /// <param name="email">email.</param>
        /// <param name="state">state.</param>
        /// <param name="organizationIdentifier">organizationIdentifier.</param>
        /// <param name="organizationName">organizationName.</param>
        public RegistrationApiRegistrationV1UpdateTenantRegistrationRequest(string registrationId = default(string), RegistrationApiRegistrationV1TenantType? tenantType = default(RegistrationApiRegistrationV1TenantType?), string firstName = default(string), string lastName = default(string), string email = default(string), string state = default(string), string organizationIdentifier = default(string), string organizationName = default(string))
        {
            this.RegistrationId = registrationId;
            this.TenantType = tenantType;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.State = state;
            this.OrganizationIdentifier = organizationIdentifier;
            this.OrganizationName = organizationName;
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
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = true)]
        public string State { get; set; }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RegistrationApiRegistrationV1UpdateTenantRegistrationRequest {\n");
            sb.Append("  RegistrationId: ").Append(RegistrationId).Append("\n");
            sb.Append("  TenantType: ").Append(TenantType).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  OrganizationIdentifier: ").Append(OrganizationIdentifier).Append("\n");
            sb.Append("  OrganizationName: ").Append(OrganizationName).Append("\n");
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
            return this.Equals(input as RegistrationApiRegistrationV1UpdateTenantRegistrationRequest);
        }

        /// <summary>
        /// Returns true if RegistrationApiRegistrationV1UpdateTenantRegistrationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of RegistrationApiRegistrationV1UpdateTenantRegistrationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RegistrationApiRegistrationV1UpdateTenantRegistrationRequest input)
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
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
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
                if (this.State != null)
                {
                    hashCode = (hashCode * 59) + this.State.GetHashCode();
                }
                if (this.OrganizationIdentifier != null)
                {
                    hashCode = (hashCode * 59) + this.OrganizationIdentifier.GetHashCode();
                }
                if (this.OrganizationName != null)
                {
                    hashCode = (hashCode * 59) + this.OrganizationName.GetHashCode();
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
