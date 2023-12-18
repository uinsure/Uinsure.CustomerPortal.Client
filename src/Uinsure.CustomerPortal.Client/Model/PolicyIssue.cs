/*
 * Uinsure.CustomerPortal.API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v1
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
using OpenAPIDateConverter = Uinsure.CustomerPortal.Client.Client.OpenAPIDateConverter;

namespace Uinsure.CustomerPortal.Client.Model
{
    /// <summary>
    /// Issue information relating to a policy
    /// </summary>
    [DataContract(Name = "PolicyIssue")]
    public partial class PolicyIssue : IEquatable<PolicyIssue>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyIssue" /> class.
        /// </summary>
        /// <param name="dataQualityIssueFlag">Is there a data quality issue impacting all policies?.</param>
        /// <param name="policyIssueFlag">Is there a data issue with this specific policy?.</param>
        public PolicyIssue(bool? dataQualityIssueFlag = default(bool?), bool? policyIssueFlag = default(bool?))
        {
            this._DataQualityIssueFlag = dataQualityIssueFlag;
            if (this.DataQualityIssueFlag != null)
            {
                this._flagDataQualityIssueFlag = true;
            }
            this._PolicyIssueFlag = policyIssueFlag;
            if (this.PolicyIssueFlag != null)
            {
                this._flagPolicyIssueFlag = true;
            }
        }

        /// <summary>
        /// Is there a data quality issue impacting all policies?
        /// </summary>
        /// <value>Is there a data quality issue impacting all policies?</value>
        [DataMember(Name = "DataQualityIssueFlag", EmitDefaultValue = true)]
        public bool? DataQualityIssueFlag
        {
            get{ return _DataQualityIssueFlag;}
            set
            {
                _DataQualityIssueFlag = value;
                _flagDataQualityIssueFlag = true;
            }
        }
        private bool? _DataQualityIssueFlag;
        private bool _flagDataQualityIssueFlag;

        /// <summary>
        /// Returns false as DataQualityIssueFlag should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDataQualityIssueFlag()
        {
            return _flagDataQualityIssueFlag;
        }
        /// <summary>
        /// Is there a data issue with this specific policy?
        /// </summary>
        /// <value>Is there a data issue with this specific policy?</value>
        [DataMember(Name = "PolicyIssueFlag", EmitDefaultValue = true)]
        public bool? PolicyIssueFlag
        {
            get{ return _PolicyIssueFlag;}
            set
            {
                _PolicyIssueFlag = value;
                _flagPolicyIssueFlag = true;
            }
        }
        private bool? _PolicyIssueFlag;
        private bool _flagPolicyIssueFlag;

        /// <summary>
        /// Returns false as PolicyIssueFlag should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePolicyIssueFlag()
        {
            return _flagPolicyIssueFlag;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PolicyIssue {\n");
            sb.Append("  DataQualityIssueFlag: ").Append(DataQualityIssueFlag).Append("\n");
            sb.Append("  PolicyIssueFlag: ").Append(PolicyIssueFlag).Append("\n");
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
            return this.Equals(input as PolicyIssue);
        }

        /// <summary>
        /// Returns true if PolicyIssue instances are equal
        /// </summary>
        /// <param name="input">Instance of PolicyIssue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PolicyIssue input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DataQualityIssueFlag == input.DataQualityIssueFlag ||
                    (this.DataQualityIssueFlag != null &&
                    this.DataQualityIssueFlag.Equals(input.DataQualityIssueFlag))
                ) && 
                (
                    this.PolicyIssueFlag == input.PolicyIssueFlag ||
                    (this.PolicyIssueFlag != null &&
                    this.PolicyIssueFlag.Equals(input.PolicyIssueFlag))
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
                if (this.DataQualityIssueFlag != null)
                {
                    hashCode = (hashCode * 59) + this.DataQualityIssueFlag.GetHashCode();
                }
                if (this.PolicyIssueFlag != null)
                {
                    hashCode = (hashCode * 59) + this.PolicyIssueFlag.GetHashCode();
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
