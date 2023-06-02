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
    /// EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsResponsesRole
    /// </summary>
    [DataContract(Name = "EdGraph.HttpAggregators.Management.Api.Controllers.v1.ViewModels.Responses.Role")]
    public partial class EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsResponsesRole : IEquatable<EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsResponsesRole>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsResponsesRole" /> class.
        /// </summary>
        /// <param name="roleName">roleName.</param>
        /// <param name="isDefault">isDefault.</param>
        public EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsResponsesRole(string roleName = default(string), bool isDefault = default(bool))
        {
            this.RoleName = roleName;
            this.IsDefault = isDefault;
        }

        /// <summary>
        /// Gets or Sets RoleName
        /// </summary>
        [DataMember(Name = "roleName", EmitDefaultValue = true)]
        public string RoleName { get; set; }

        /// <summary>
        /// Gets or Sets IsDefault
        /// </summary>
        [DataMember(Name = "isDefault", EmitDefaultValue = true)]
        public bool IsDefault { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsResponsesRole {\n");
            sb.Append("  RoleName: ").Append(RoleName).Append("\n");
            sb.Append("  IsDefault: ").Append(IsDefault).Append("\n");
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
            return this.Equals(input as EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsResponsesRole);
        }

        /// <summary>
        /// Returns true if EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsResponsesRole instances are equal
        /// </summary>
        /// <param name="input">Instance of EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsResponsesRole to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdGraphHttpAggregatorsManagementApiControllersV1ViewModelsResponsesRole input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.RoleName == input.RoleName ||
                    (this.RoleName != null &&
                    this.RoleName.Equals(input.RoleName))
                ) && 
                (
                    this.IsDefault == input.IsDefault ||
                    this.IsDefault.Equals(input.IsDefault)
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
                if (this.RoleName != null)
                {
                    hashCode = (hashCode * 59) + this.RoleName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsDefault.GetHashCode();
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
