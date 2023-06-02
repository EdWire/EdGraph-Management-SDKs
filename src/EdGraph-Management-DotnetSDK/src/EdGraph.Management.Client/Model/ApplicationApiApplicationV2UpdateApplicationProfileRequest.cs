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
    /// ApplicationApiApplicationV2UpdateApplicationProfileRequest
    /// </summary>
    [DataContract(Name = "ApplicationApi.Application.V2.UpdateApplicationProfileRequest")]
    public partial class ApplicationApiApplicationV2UpdateApplicationProfileRequest : IEquatable<ApplicationApiApplicationV2UpdateApplicationProfileRequest>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets ApplicationType
        /// </summary>
        [DataMember(Name = "applicationType", EmitDefaultValue = false)]
        public ApplicationApiApplicationV2ApplicationType? ApplicationType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationApiApplicationV2UpdateApplicationProfileRequest" /> class.
        /// </summary>
        /// <param name="tenantId">tenantId.</param>
        /// <param name="applicationId">applicationId.</param>
        /// <param name="applicationType">applicationType.</param>
        /// <param name="applicationName">applicationName.</param>
        /// <param name="applicationUri">applicationUri.</param>
        /// <param name="version">version.</param>
        /// <param name="tooltipText">tooltipText.</param>
        /// <param name="applicationDescription">applicationDescription.</param>
        /// <param name="tags">tags.</param>
        /// <param name="groups">groups.</param>
        /// <param name="openInNewWindow">openInNewWindow.</param>
        public ApplicationApiApplicationV2UpdateApplicationProfileRequest(string tenantId = default(string), string applicationId = default(string), ApplicationApiApplicationV2ApplicationType? applicationType = default(ApplicationApiApplicationV2ApplicationType?), string applicationName = default(string), string applicationUri = default(string), string version = default(string), string tooltipText = default(string), string applicationDescription = default(string), string tags = default(string), string groups = default(string), bool openInNewWindow = default(bool))
        {
            this.TenantId = tenantId;
            this.ApplicationId = applicationId;
            this.ApplicationType = applicationType;
            this.ApplicationName = applicationName;
            this.ApplicationUri = applicationUri;
            this._Version = version;
            this.TooltipText = tooltipText;
            this.ApplicationDescription = applicationDescription;
            this.Tags = tags;
            this.Groups = groups;
            this.OpenInNewWindow = openInNewWindow;
        }

        /// <summary>
        /// Gets or Sets TenantId
        /// </summary>
        [DataMember(Name = "tenantId", EmitDefaultValue = true)]
        public string TenantId { get; set; }

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
        /// Gets or Sets ApplicationUri
        /// </summary>
        [DataMember(Name = "applicationUri", EmitDefaultValue = true)]
        public string ApplicationUri { get; set; }

        /// <summary>
        /// Gets or Sets _Version
        /// </summary>
        [DataMember(Name = "version", EmitDefaultValue = true)]
        public string _Version { get; set; }

        /// <summary>
        /// Gets or Sets TooltipText
        /// </summary>
        [DataMember(Name = "tooltipText", EmitDefaultValue = true)]
        public string TooltipText { get; set; }

        /// <summary>
        /// Gets or Sets ApplicationDescription
        /// </summary>
        [DataMember(Name = "applicationDescription", EmitDefaultValue = true)]
        public string ApplicationDescription { get; set; }

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
        /// Gets or Sets OpenInNewWindow
        /// </summary>
        [DataMember(Name = "openInNewWindow", EmitDefaultValue = true)]
        public bool OpenInNewWindow { get; set; }

        /// <summary>
        /// Gets or Sets Roles
        /// </summary>
        [DataMember(Name = "roles", EmitDefaultValue = true)]
        public List<ApplicationApiApplicationV2Role> Roles { get; private set; }

        /// <summary>
        /// Returns false as Roles should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeRoles()
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
            sb.Append("class ApplicationApiApplicationV2UpdateApplicationProfileRequest {\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  ApplicationId: ").Append(ApplicationId).Append("\n");
            sb.Append("  ApplicationType: ").Append(ApplicationType).Append("\n");
            sb.Append("  ApplicationName: ").Append(ApplicationName).Append("\n");
            sb.Append("  ApplicationUri: ").Append(ApplicationUri).Append("\n");
            sb.Append("  _Version: ").Append(_Version).Append("\n");
            sb.Append("  TooltipText: ").Append(TooltipText).Append("\n");
            sb.Append("  ApplicationDescription: ").Append(ApplicationDescription).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Groups: ").Append(Groups).Append("\n");
            sb.Append("  OpenInNewWindow: ").Append(OpenInNewWindow).Append("\n");
            sb.Append("  Roles: ").Append(Roles).Append("\n");
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
            return this.Equals(input as ApplicationApiApplicationV2UpdateApplicationProfileRequest);
        }

        /// <summary>
        /// Returns true if ApplicationApiApplicationV2UpdateApplicationProfileRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ApplicationApiApplicationV2UpdateApplicationProfileRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApplicationApiApplicationV2UpdateApplicationProfileRequest input)
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
                    this.ApplicationId == input.ApplicationId ||
                    (this.ApplicationId != null &&
                    this.ApplicationId.Equals(input.ApplicationId))
                ) && 
                (
                    this.ApplicationType == input.ApplicationType ||
                    this.ApplicationType.Equals(input.ApplicationType)
                ) && 
                (
                    this.ApplicationName == input.ApplicationName ||
                    (this.ApplicationName != null &&
                    this.ApplicationName.Equals(input.ApplicationName))
                ) && 
                (
                    this.ApplicationUri == input.ApplicationUri ||
                    (this.ApplicationUri != null &&
                    this.ApplicationUri.Equals(input.ApplicationUri))
                ) && 
                (
                    this._Version == input._Version ||
                    (this._Version != null &&
                    this._Version.Equals(input._Version))
                ) && 
                (
                    this.TooltipText == input.TooltipText ||
                    (this.TooltipText != null &&
                    this.TooltipText.Equals(input.TooltipText))
                ) && 
                (
                    this.ApplicationDescription == input.ApplicationDescription ||
                    (this.ApplicationDescription != null &&
                    this.ApplicationDescription.Equals(input.ApplicationDescription))
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
                    this.OpenInNewWindow == input.OpenInNewWindow ||
                    this.OpenInNewWindow.Equals(input.OpenInNewWindow)
                ) && 
                (
                    this.Roles == input.Roles ||
                    this.Roles != null &&
                    input.Roles != null &&
                    this.Roles.SequenceEqual(input.Roles)
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
                if (this.ApplicationId != null)
                {
                    hashCode = (hashCode * 59) + this.ApplicationId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ApplicationType.GetHashCode();
                if (this.ApplicationName != null)
                {
                    hashCode = (hashCode * 59) + this.ApplicationName.GetHashCode();
                }
                if (this.ApplicationUri != null)
                {
                    hashCode = (hashCode * 59) + this.ApplicationUri.GetHashCode();
                }
                if (this._Version != null)
                {
                    hashCode = (hashCode * 59) + this._Version.GetHashCode();
                }
                if (this.TooltipText != null)
                {
                    hashCode = (hashCode * 59) + this.TooltipText.GetHashCode();
                }
                if (this.ApplicationDescription != null)
                {
                    hashCode = (hashCode * 59) + this.ApplicationDescription.GetHashCode();
                }
                if (this.Tags != null)
                {
                    hashCode = (hashCode * 59) + this.Tags.GetHashCode();
                }
                if (this.Groups != null)
                {
                    hashCode = (hashCode * 59) + this.Groups.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.OpenInNewWindow.GetHashCode();
                if (this.Roles != null)
                {
                    hashCode = (hashCode * 59) + this.Roles.GetHashCode();
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
