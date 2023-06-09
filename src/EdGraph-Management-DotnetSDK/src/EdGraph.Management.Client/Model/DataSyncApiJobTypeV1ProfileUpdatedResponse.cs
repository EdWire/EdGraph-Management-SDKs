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
    /// DataSyncApiJobTypeV1ProfileUpdatedResponse
    /// </summary>
    [DataContract(Name = "DataSyncApi.JobType.V1.ProfileUpdatedResponse")]
    public partial class DataSyncApiJobTypeV1ProfileUpdatedResponse : IEquatable<DataSyncApiJobTypeV1ProfileUpdatedResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataSyncApiJobTypeV1ProfileUpdatedResponse" /> class.
        /// </summary>
        /// <param name="jobTypeId">jobTypeId.</param>
        /// <param name="profileId">profileId.</param>
        public DataSyncApiJobTypeV1ProfileUpdatedResponse(string jobTypeId = default(string), string profileId = default(string))
        {
            this.JobTypeId = jobTypeId;
            this.ProfileId = profileId;
        }

        /// <summary>
        /// Gets or Sets JobTypeId
        /// </summary>
        [DataMember(Name = "jobTypeId", EmitDefaultValue = true)]
        public string JobTypeId { get; set; }

        /// <summary>
        /// Gets or Sets ProfileId
        /// </summary>
        [DataMember(Name = "profileId", EmitDefaultValue = true)]
        public string ProfileId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DataSyncApiJobTypeV1ProfileUpdatedResponse {\n");
            sb.Append("  JobTypeId: ").Append(JobTypeId).Append("\n");
            sb.Append("  ProfileId: ").Append(ProfileId).Append("\n");
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
            return this.Equals(input as DataSyncApiJobTypeV1ProfileUpdatedResponse);
        }

        /// <summary>
        /// Returns true if DataSyncApiJobTypeV1ProfileUpdatedResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of DataSyncApiJobTypeV1ProfileUpdatedResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DataSyncApiJobTypeV1ProfileUpdatedResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.JobTypeId == input.JobTypeId ||
                    (this.JobTypeId != null &&
                    this.JobTypeId.Equals(input.JobTypeId))
                ) && 
                (
                    this.ProfileId == input.ProfileId ||
                    (this.ProfileId != null &&
                    this.ProfileId.Equals(input.ProfileId))
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
                if (this.JobTypeId != null)
                {
                    hashCode = (hashCode * 59) + this.JobTypeId.GetHashCode();
                }
                if (this.ProfileId != null)
                {
                    hashCode = (hashCode * 59) + this.ProfileId.GetHashCode();
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
