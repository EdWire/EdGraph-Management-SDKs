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
    /// ApplicationApiApplicationV2UpdateApplicationLauncherSettingsRequest
    /// </summary>
    [DataContract(Name = "ApplicationApi.Application.V2.UpdateApplicationLauncherSettingsRequest")]
    public partial class ApplicationApiApplicationV2UpdateApplicationLauncherSettingsRequest : IEquatable<ApplicationApiApplicationV2UpdateApplicationLauncherSettingsRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationApiApplicationV2UpdateApplicationLauncherSettingsRequest" /> class.
        /// </summary>
        /// <param name="tenantId">tenantId.</param>
        /// <param name="applicationId">applicationId.</param>
        /// <param name="lightIconUrl">lightIconUrl.</param>
        /// <param name="darkIconUrl">darkIconUrl.</param>
        /// <param name="lightBackgroundTileUrl">lightBackgroundTileUrl.</param>
        /// <param name="darkBackgroundTileUrl">darkBackgroundTileUrl.</param>
        /// <param name="lightOverlayTileUrl">lightOverlayTileUrl.</param>
        /// <param name="darkOverlayTileUrl">darkOverlayTileUrl.</param>
        /// <param name="showInAppLauncher">showInAppLauncher.</param>
        /// <param name="showInQuickLauncher">showInQuickLauncher.</param>
        public ApplicationApiApplicationV2UpdateApplicationLauncherSettingsRequest(string tenantId = default(string), string applicationId = default(string), string lightIconUrl = default(string), string darkIconUrl = default(string), string lightBackgroundTileUrl = default(string), string darkBackgroundTileUrl = default(string), string lightOverlayTileUrl = default(string), string darkOverlayTileUrl = default(string), bool showInAppLauncher = default(bool), bool showInQuickLauncher = default(bool))
        {
            this.TenantId = tenantId;
            this.ApplicationId = applicationId;
            this.LightIconUrl = lightIconUrl;
            this.DarkIconUrl = darkIconUrl;
            this.LightBackgroundTileUrl = lightBackgroundTileUrl;
            this.DarkBackgroundTileUrl = darkBackgroundTileUrl;
            this.LightOverlayTileUrl = lightOverlayTileUrl;
            this.DarkOverlayTileUrl = darkOverlayTileUrl;
            this.ShowInAppLauncher = showInAppLauncher;
            this.ShowInQuickLauncher = showInQuickLauncher;
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
        /// Gets or Sets LightIconUrl
        /// </summary>
        [DataMember(Name = "lightIconUrl", EmitDefaultValue = true)]
        public string LightIconUrl { get; set; }

        /// <summary>
        /// Gets or Sets DarkIconUrl
        /// </summary>
        [DataMember(Name = "darkIconUrl", EmitDefaultValue = true)]
        public string DarkIconUrl { get; set; }

        /// <summary>
        /// Gets or Sets LightBackgroundTileUrl
        /// </summary>
        [DataMember(Name = "lightBackgroundTileUrl", EmitDefaultValue = true)]
        public string LightBackgroundTileUrl { get; set; }

        /// <summary>
        /// Gets or Sets DarkBackgroundTileUrl
        /// </summary>
        [DataMember(Name = "darkBackgroundTileUrl", EmitDefaultValue = true)]
        public string DarkBackgroundTileUrl { get; set; }

        /// <summary>
        /// Gets or Sets LightOverlayTileUrl
        /// </summary>
        [DataMember(Name = "lightOverlayTileUrl", EmitDefaultValue = true)]
        public string LightOverlayTileUrl { get; set; }

        /// <summary>
        /// Gets or Sets DarkOverlayTileUrl
        /// </summary>
        [DataMember(Name = "darkOverlayTileUrl", EmitDefaultValue = true)]
        public string DarkOverlayTileUrl { get; set; }

        /// <summary>
        /// Gets or Sets ShowInAppLauncher
        /// </summary>
        [DataMember(Name = "showInAppLauncher", EmitDefaultValue = true)]
        public bool ShowInAppLauncher { get; set; }

        /// <summary>
        /// Gets or Sets ShowInQuickLauncher
        /// </summary>
        [DataMember(Name = "showInQuickLauncher", EmitDefaultValue = true)]
        public bool ShowInQuickLauncher { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ApplicationApiApplicationV2UpdateApplicationLauncherSettingsRequest {\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  ApplicationId: ").Append(ApplicationId).Append("\n");
            sb.Append("  LightIconUrl: ").Append(LightIconUrl).Append("\n");
            sb.Append("  DarkIconUrl: ").Append(DarkIconUrl).Append("\n");
            sb.Append("  LightBackgroundTileUrl: ").Append(LightBackgroundTileUrl).Append("\n");
            sb.Append("  DarkBackgroundTileUrl: ").Append(DarkBackgroundTileUrl).Append("\n");
            sb.Append("  LightOverlayTileUrl: ").Append(LightOverlayTileUrl).Append("\n");
            sb.Append("  DarkOverlayTileUrl: ").Append(DarkOverlayTileUrl).Append("\n");
            sb.Append("  ShowInAppLauncher: ").Append(ShowInAppLauncher).Append("\n");
            sb.Append("  ShowInQuickLauncher: ").Append(ShowInQuickLauncher).Append("\n");
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
            return this.Equals(input as ApplicationApiApplicationV2UpdateApplicationLauncherSettingsRequest);
        }

        /// <summary>
        /// Returns true if ApplicationApiApplicationV2UpdateApplicationLauncherSettingsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ApplicationApiApplicationV2UpdateApplicationLauncherSettingsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApplicationApiApplicationV2UpdateApplicationLauncherSettingsRequest input)
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
                    this.LightIconUrl == input.LightIconUrl ||
                    (this.LightIconUrl != null &&
                    this.LightIconUrl.Equals(input.LightIconUrl))
                ) && 
                (
                    this.DarkIconUrl == input.DarkIconUrl ||
                    (this.DarkIconUrl != null &&
                    this.DarkIconUrl.Equals(input.DarkIconUrl))
                ) && 
                (
                    this.LightBackgroundTileUrl == input.LightBackgroundTileUrl ||
                    (this.LightBackgroundTileUrl != null &&
                    this.LightBackgroundTileUrl.Equals(input.LightBackgroundTileUrl))
                ) && 
                (
                    this.DarkBackgroundTileUrl == input.DarkBackgroundTileUrl ||
                    (this.DarkBackgroundTileUrl != null &&
                    this.DarkBackgroundTileUrl.Equals(input.DarkBackgroundTileUrl))
                ) && 
                (
                    this.LightOverlayTileUrl == input.LightOverlayTileUrl ||
                    (this.LightOverlayTileUrl != null &&
                    this.LightOverlayTileUrl.Equals(input.LightOverlayTileUrl))
                ) && 
                (
                    this.DarkOverlayTileUrl == input.DarkOverlayTileUrl ||
                    (this.DarkOverlayTileUrl != null &&
                    this.DarkOverlayTileUrl.Equals(input.DarkOverlayTileUrl))
                ) && 
                (
                    this.ShowInAppLauncher == input.ShowInAppLauncher ||
                    this.ShowInAppLauncher.Equals(input.ShowInAppLauncher)
                ) && 
                (
                    this.ShowInQuickLauncher == input.ShowInQuickLauncher ||
                    this.ShowInQuickLauncher.Equals(input.ShowInQuickLauncher)
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
                if (this.LightIconUrl != null)
                {
                    hashCode = (hashCode * 59) + this.LightIconUrl.GetHashCode();
                }
                if (this.DarkIconUrl != null)
                {
                    hashCode = (hashCode * 59) + this.DarkIconUrl.GetHashCode();
                }
                if (this.LightBackgroundTileUrl != null)
                {
                    hashCode = (hashCode * 59) + this.LightBackgroundTileUrl.GetHashCode();
                }
                if (this.DarkBackgroundTileUrl != null)
                {
                    hashCode = (hashCode * 59) + this.DarkBackgroundTileUrl.GetHashCode();
                }
                if (this.LightOverlayTileUrl != null)
                {
                    hashCode = (hashCode * 59) + this.LightOverlayTileUrl.GetHashCode();
                }
                if (this.DarkOverlayTileUrl != null)
                {
                    hashCode = (hashCode * 59) + this.DarkOverlayTileUrl.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ShowInAppLauncher.GetHashCode();
                hashCode = (hashCode * 59) + this.ShowInQuickLauncher.GetHashCode();
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
