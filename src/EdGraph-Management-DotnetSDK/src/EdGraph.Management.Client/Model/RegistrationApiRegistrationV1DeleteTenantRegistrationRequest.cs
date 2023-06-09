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
    /// RegistrationApiRegistrationV1DeleteTenantRegistrationRequest
    /// </summary>
    [DataContract(Name = "RegistrationApi.Registration.V1.DeleteTenantRegistrationRequest")]
    public partial class RegistrationApiRegistrationV1DeleteTenantRegistrationRequest : IEquatable<RegistrationApiRegistrationV1DeleteTenantRegistrationRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RegistrationApiRegistrationV1DeleteTenantRegistrationRequest" /> class.
        /// </summary>
        /// <param name="registrationId">registrationId.</param>
        /// <param name="reason">reason.</param>
        public RegistrationApiRegistrationV1DeleteTenantRegistrationRequest(string registrationId = default(string), string reason = default(string))
        {
            this.RegistrationId = registrationId;
            this.Reason = reason;
        }

        /// <summary>
        /// Gets or Sets RegistrationId
        /// </summary>
        [DataMember(Name = "registrationId", EmitDefaultValue = true)]
        public string RegistrationId { get; set; }

        /// <summary>
        /// Gets or Sets Reason
        /// </summary>
        [DataMember(Name = "reason", EmitDefaultValue = true)]
        public string Reason { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RegistrationApiRegistrationV1DeleteTenantRegistrationRequest {\n");
            sb.Append("  RegistrationId: ").Append(RegistrationId).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
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
            return this.Equals(input as RegistrationApiRegistrationV1DeleteTenantRegistrationRequest);
        }

        /// <summary>
        /// Returns true if RegistrationApiRegistrationV1DeleteTenantRegistrationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of RegistrationApiRegistrationV1DeleteTenantRegistrationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RegistrationApiRegistrationV1DeleteTenantRegistrationRequest input)
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
                    this.Reason == input.Reason ||
                    (this.Reason != null &&
                    this.Reason.Equals(input.Reason))
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
                if (this.Reason != null)
                {
                    hashCode = (hashCode * 59) + this.Reason.GetHashCode();
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
