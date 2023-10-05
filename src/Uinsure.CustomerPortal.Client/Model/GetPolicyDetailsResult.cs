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
    /// GetPolicyDetailsResult
    /// </summary>
    [DataContract(Name = "GetPolicyDetailsResult")]
    public partial class GetPolicyDetailsResult : IEquatable<GetPolicyDetailsResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetPolicyDetailsResult" /> class.
        /// </summary>
        /// <param name="policyNumber">policyNumber.</param>
        /// <param name="accountReference">accountReference.</param>
        /// <param name="upcomingRenewalPolicyNumber">upcomingRenewalPolicyNumber.</param>
        /// <param name="upcomingRenewalInceptionDate">upcomingRenewalInceptionDate.</param>
        /// <param name="policyStartDate">policyStartDate.</param>
        /// <param name="policyEndDate">policyEndDate.</param>
        /// <param name="underwriterName">underwriterName.</param>
        /// <param name="coverTypeName">coverTypeName.</param>
        /// <param name="productTypeName">productTypeName.</param>
        /// <param name="provider">provider.</param>
        /// <param name="possiblyRelatedPolicies">possiblyRelatedPolicies.</param>
        /// <param name="possiblyRelatedApplicant1">possiblyRelatedApplicant1.</param>
        /// <param name="companyName">companyName.</param>
        /// <param name="policyStatus">policyStatus.</param>
        /// <param name="policyholder">policyholder.</param>
        /// <param name="policy">policy.</param>
        /// <param name="property">property.</param>
        /// <param name="issues">issues.</param>
        public GetPolicyDetailsResult(string policyNumber = default(string), string accountReference = default(string), string upcomingRenewalPolicyNumber = default(string), DateTime? upcomingRenewalInceptionDate = default(DateTime?), DateTime? policyStartDate = default(DateTime?), DateTime? policyEndDate = default(DateTime?), string underwriterName = default(string), string coverTypeName = default(string), string productTypeName = default(string), string provider = default(string), string possiblyRelatedPolicies = default(string), string possiblyRelatedApplicant1 = default(string), string companyName = default(string), string policyStatus = default(string), Policyholder policyholder = default(Policyholder), PolicyCover policy = default(PolicyCover), RiskProperty property = default(RiskProperty), PolicyIssue issues = default(PolicyIssue))
        {
            this._PolicyNumber = policyNumber;
            if (this.PolicyNumber != null)
            {
                this._flagPolicyNumber = true;
            }
            this._AccountReference = accountReference;
            if (this.AccountReference != null)
            {
                this._flagAccountReference = true;
            }
            this._UpcomingRenewalPolicyNumber = upcomingRenewalPolicyNumber;
            if (this.UpcomingRenewalPolicyNumber != null)
            {
                this._flagUpcomingRenewalPolicyNumber = true;
            }
            this._UpcomingRenewalInceptionDate = upcomingRenewalInceptionDate;
            if (this.UpcomingRenewalInceptionDate != null)
            {
                this._flagUpcomingRenewalInceptionDate = true;
            }
            this._PolicyStartDate = policyStartDate;
            if (this.PolicyStartDate != null)
            {
                this._flagPolicyStartDate = true;
            }
            this._PolicyEndDate = policyEndDate;
            if (this.PolicyEndDate != null)
            {
                this._flagPolicyEndDate = true;
            }
            this._UnderwriterName = underwriterName;
            if (this.UnderwriterName != null)
            {
                this._flagUnderwriterName = true;
            }
            this._CoverTypeName = coverTypeName;
            if (this.CoverTypeName != null)
            {
                this._flagCoverTypeName = true;
            }
            this._ProductTypeName = productTypeName;
            if (this.ProductTypeName != null)
            {
                this._flagProductTypeName = true;
            }
            this._Provider = provider;
            if (this.Provider != null)
            {
                this._flagProvider = true;
            }
            this._PossiblyRelatedPolicies = possiblyRelatedPolicies;
            if (this.PossiblyRelatedPolicies != null)
            {
                this._flagPossiblyRelatedPolicies = true;
            }
            this._PossiblyRelatedApplicant1 = possiblyRelatedApplicant1;
            if (this.PossiblyRelatedApplicant1 != null)
            {
                this._flagPossiblyRelatedApplicant1 = true;
            }
            this._CompanyName = companyName;
            if (this.CompanyName != null)
            {
                this._flagCompanyName = true;
            }
            this._PolicyStatus = policyStatus;
            if (this.PolicyStatus != null)
            {
                this._flagPolicyStatus = true;
            }
            this._Policyholder = policyholder;
            if (this.Policyholder != null)
            {
                this._flagPolicyholder = true;
            }
            this._Policy = policy;
            if (this.Policy != null)
            {
                this._flagPolicy = true;
            }
            this._Property = property;
            if (this.Property != null)
            {
                this._flagProperty = true;
            }
            this._Issues = issues;
            if (this.Issues != null)
            {
                this._flagIssues = true;
            }
        }

        /// <summary>
        /// Gets or Sets PolicyNumber
        /// </summary>
        [DataMember(Name = "PolicyNumber", EmitDefaultValue = true)]
        public string PolicyNumber
        {
            get{ return _PolicyNumber;}
            set
            {
                _PolicyNumber = value;
                _flagPolicyNumber = true;
            }
        }
        private string _PolicyNumber;
        private bool _flagPolicyNumber;

        /// <summary>
        /// Returns false as PolicyNumber should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePolicyNumber()
        {
            return _flagPolicyNumber;
        }
        /// <summary>
        /// Gets or Sets AccountReference
        /// </summary>
        [DataMember(Name = "AccountReference", EmitDefaultValue = true)]
        public string AccountReference
        {
            get{ return _AccountReference;}
            set
            {
                _AccountReference = value;
                _flagAccountReference = true;
            }
        }
        private string _AccountReference;
        private bool _flagAccountReference;

        /// <summary>
        /// Returns false as AccountReference should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAccountReference()
        {
            return _flagAccountReference;
        }
        /// <summary>
        /// Gets or Sets UpcomingRenewalPolicyNumber
        /// </summary>
        [DataMember(Name = "UpcomingRenewalPolicyNumber", EmitDefaultValue = true)]
        public string UpcomingRenewalPolicyNumber
        {
            get{ return _UpcomingRenewalPolicyNumber;}
            set
            {
                _UpcomingRenewalPolicyNumber = value;
                _flagUpcomingRenewalPolicyNumber = true;
            }
        }
        private string _UpcomingRenewalPolicyNumber;
        private bool _flagUpcomingRenewalPolicyNumber;

        /// <summary>
        /// Returns false as UpcomingRenewalPolicyNumber should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUpcomingRenewalPolicyNumber()
        {
            return _flagUpcomingRenewalPolicyNumber;
        }
        /// <summary>
        /// Gets or Sets UpcomingRenewalInceptionDate
        /// </summary>
        [DataMember(Name = "UpcomingRenewalInceptionDate", EmitDefaultValue = true)]
        public DateTime? UpcomingRenewalInceptionDate
        {
            get{ return _UpcomingRenewalInceptionDate;}
            set
            {
                _UpcomingRenewalInceptionDate = value;
                _flagUpcomingRenewalInceptionDate = true;
            }
        }
        private DateTime? _UpcomingRenewalInceptionDate;
        private bool _flagUpcomingRenewalInceptionDate;

        /// <summary>
        /// Returns false as UpcomingRenewalInceptionDate should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUpcomingRenewalInceptionDate()
        {
            return _flagUpcomingRenewalInceptionDate;
        }
        /// <summary>
        /// Gets or Sets PolicyStartDate
        /// </summary>
        [DataMember(Name = "PolicyStartDate", EmitDefaultValue = true)]
        public DateTime? PolicyStartDate
        {
            get{ return _PolicyStartDate;}
            set
            {
                _PolicyStartDate = value;
                _flagPolicyStartDate = true;
            }
        }
        private DateTime? _PolicyStartDate;
        private bool _flagPolicyStartDate;

        /// <summary>
        /// Returns false as PolicyStartDate should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePolicyStartDate()
        {
            return _flagPolicyStartDate;
        }
        /// <summary>
        /// Gets or Sets PolicyEndDate
        /// </summary>
        [DataMember(Name = "PolicyEndDate", EmitDefaultValue = true)]
        public DateTime? PolicyEndDate
        {
            get{ return _PolicyEndDate;}
            set
            {
                _PolicyEndDate = value;
                _flagPolicyEndDate = true;
            }
        }
        private DateTime? _PolicyEndDate;
        private bool _flagPolicyEndDate;

        /// <summary>
        /// Returns false as PolicyEndDate should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePolicyEndDate()
        {
            return _flagPolicyEndDate;
        }
        /// <summary>
        /// Gets or Sets UnderwriterName
        /// </summary>
        [DataMember(Name = "UnderwriterName", EmitDefaultValue = true)]
        public string UnderwriterName
        {
            get{ return _UnderwriterName;}
            set
            {
                _UnderwriterName = value;
                _flagUnderwriterName = true;
            }
        }
        private string _UnderwriterName;
        private bool _flagUnderwriterName;

        /// <summary>
        /// Returns false as UnderwriterName should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUnderwriterName()
        {
            return _flagUnderwriterName;
        }
        /// <summary>
        /// Gets or Sets CoverTypeName
        /// </summary>
        [DataMember(Name = "CoverTypeName", EmitDefaultValue = true)]
        public string CoverTypeName
        {
            get{ return _CoverTypeName;}
            set
            {
                _CoverTypeName = value;
                _flagCoverTypeName = true;
            }
        }
        private string _CoverTypeName;
        private bool _flagCoverTypeName;

        /// <summary>
        /// Returns false as CoverTypeName should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCoverTypeName()
        {
            return _flagCoverTypeName;
        }
        /// <summary>
        /// Gets or Sets ProductTypeName
        /// </summary>
        [DataMember(Name = "ProductTypeName", EmitDefaultValue = true)]
        public string ProductTypeName
        {
            get{ return _ProductTypeName;}
            set
            {
                _ProductTypeName = value;
                _flagProductTypeName = true;
            }
        }
        private string _ProductTypeName;
        private bool _flagProductTypeName;

        /// <summary>
        /// Returns false as ProductTypeName should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeProductTypeName()
        {
            return _flagProductTypeName;
        }
        /// <summary>
        /// Gets or Sets Provider
        /// </summary>
        [DataMember(Name = "Provider", EmitDefaultValue = true)]
        public string Provider
        {
            get{ return _Provider;}
            set
            {
                _Provider = value;
                _flagProvider = true;
            }
        }
        private string _Provider;
        private bool _flagProvider;

        /// <summary>
        /// Returns false as Provider should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeProvider()
        {
            return _flagProvider;
        }
        /// <summary>
        /// Gets or Sets PossiblyRelatedPolicies
        /// </summary>
        [DataMember(Name = "PossiblyRelatedPolicies", EmitDefaultValue = true)]
        public string PossiblyRelatedPolicies
        {
            get{ return _PossiblyRelatedPolicies;}
            set
            {
                _PossiblyRelatedPolicies = value;
                _flagPossiblyRelatedPolicies = true;
            }
        }
        private string _PossiblyRelatedPolicies;
        private bool _flagPossiblyRelatedPolicies;

        /// <summary>
        /// Returns false as PossiblyRelatedPolicies should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePossiblyRelatedPolicies()
        {
            return _flagPossiblyRelatedPolicies;
        }
        /// <summary>
        /// Gets or Sets PossiblyRelatedApplicant1
        /// </summary>
        [DataMember(Name = "PossiblyRelatedApplicant1", EmitDefaultValue = true)]
        public string PossiblyRelatedApplicant1
        {
            get{ return _PossiblyRelatedApplicant1;}
            set
            {
                _PossiblyRelatedApplicant1 = value;
                _flagPossiblyRelatedApplicant1 = true;
            }
        }
        private string _PossiblyRelatedApplicant1;
        private bool _flagPossiblyRelatedApplicant1;

        /// <summary>
        /// Returns false as PossiblyRelatedApplicant1 should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePossiblyRelatedApplicant1()
        {
            return _flagPossiblyRelatedApplicant1;
        }
        /// <summary>
        /// Gets or Sets CompanyName
        /// </summary>
        [DataMember(Name = "CompanyName", EmitDefaultValue = true)]
        public string CompanyName
        {
            get{ return _CompanyName;}
            set
            {
                _CompanyName = value;
                _flagCompanyName = true;
            }
        }
        private string _CompanyName;
        private bool _flagCompanyName;

        /// <summary>
        /// Returns false as CompanyName should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCompanyName()
        {
            return _flagCompanyName;
        }
        /// <summary>
        /// Gets or Sets PolicyStatus
        /// </summary>
        [DataMember(Name = "PolicyStatus", EmitDefaultValue = true)]
        public string PolicyStatus
        {
            get{ return _PolicyStatus;}
            set
            {
                _PolicyStatus = value;
                _flagPolicyStatus = true;
            }
        }
        private string _PolicyStatus;
        private bool _flagPolicyStatus;

        /// <summary>
        /// Returns false as PolicyStatus should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePolicyStatus()
        {
            return _flagPolicyStatus;
        }
        /// <summary>
        /// Gets or Sets Policyholder
        /// </summary>
        [DataMember(Name = "Policyholder", EmitDefaultValue = false)]
        public Policyholder Policyholder
        {
            get{ return _Policyholder;}
            set
            {
                _Policyholder = value;
                _flagPolicyholder = true;
            }
        }
        private Policyholder _Policyholder;
        private bool _flagPolicyholder;

        /// <summary>
        /// Returns false as Policyholder should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePolicyholder()
        {
            return _flagPolicyholder;
        }
        /// <summary>
        /// Gets or Sets Policy
        /// </summary>
        [DataMember(Name = "Policy", EmitDefaultValue = false)]
        public PolicyCover Policy
        {
            get{ return _Policy;}
            set
            {
                _Policy = value;
                _flagPolicy = true;
            }
        }
        private PolicyCover _Policy;
        private bool _flagPolicy;

        /// <summary>
        /// Returns false as Policy should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePolicy()
        {
            return _flagPolicy;
        }
        /// <summary>
        /// Gets or Sets Property
        /// </summary>
        [DataMember(Name = "Property", EmitDefaultValue = false)]
        public RiskProperty Property
        {
            get{ return _Property;}
            set
            {
                _Property = value;
                _flagProperty = true;
            }
        }
        private RiskProperty _Property;
        private bool _flagProperty;

        /// <summary>
        /// Returns false as Property should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeProperty()
        {
            return _flagProperty;
        }
        /// <summary>
        /// Gets or Sets Issues
        /// </summary>
        [DataMember(Name = "Issues", EmitDefaultValue = false)]
        public PolicyIssue Issues
        {
            get{ return _Issues;}
            set
            {
                _Issues = value;
                _flagIssues = true;
            }
        }
        private PolicyIssue _Issues;
        private bool _flagIssues;

        /// <summary>
        /// Returns false as Issues should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeIssues()
        {
            return _flagIssues;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetPolicyDetailsResult {\n");
            sb.Append("  PolicyNumber: ").Append(PolicyNumber).Append("\n");
            sb.Append("  AccountReference: ").Append(AccountReference).Append("\n");
            sb.Append("  UpcomingRenewalPolicyNumber: ").Append(UpcomingRenewalPolicyNumber).Append("\n");
            sb.Append("  UpcomingRenewalInceptionDate: ").Append(UpcomingRenewalInceptionDate).Append("\n");
            sb.Append("  PolicyStartDate: ").Append(PolicyStartDate).Append("\n");
            sb.Append("  PolicyEndDate: ").Append(PolicyEndDate).Append("\n");
            sb.Append("  UnderwriterName: ").Append(UnderwriterName).Append("\n");
            sb.Append("  CoverTypeName: ").Append(CoverTypeName).Append("\n");
            sb.Append("  ProductTypeName: ").Append(ProductTypeName).Append("\n");
            sb.Append("  Provider: ").Append(Provider).Append("\n");
            sb.Append("  PossiblyRelatedPolicies: ").Append(PossiblyRelatedPolicies).Append("\n");
            sb.Append("  PossiblyRelatedApplicant1: ").Append(PossiblyRelatedApplicant1).Append("\n");
            sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
            sb.Append("  PolicyStatus: ").Append(PolicyStatus).Append("\n");
            sb.Append("  Policyholder: ").Append(Policyholder).Append("\n");
            sb.Append("  Policy: ").Append(Policy).Append("\n");
            sb.Append("  Property: ").Append(Property).Append("\n");
            sb.Append("  Issues: ").Append(Issues).Append("\n");
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
            return this.Equals(input as GetPolicyDetailsResult);
        }

        /// <summary>
        /// Returns true if GetPolicyDetailsResult instances are equal
        /// </summary>
        /// <param name="input">Instance of GetPolicyDetailsResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetPolicyDetailsResult input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PolicyNumber == input.PolicyNumber ||
                    (this.PolicyNumber != null &&
                    this.PolicyNumber.Equals(input.PolicyNumber))
                ) && 
                (
                    this.AccountReference == input.AccountReference ||
                    (this.AccountReference != null &&
                    this.AccountReference.Equals(input.AccountReference))
                ) && 
                (
                    this.UpcomingRenewalPolicyNumber == input.UpcomingRenewalPolicyNumber ||
                    (this.UpcomingRenewalPolicyNumber != null &&
                    this.UpcomingRenewalPolicyNumber.Equals(input.UpcomingRenewalPolicyNumber))
                ) && 
                (
                    this.UpcomingRenewalInceptionDate == input.UpcomingRenewalInceptionDate ||
                    (this.UpcomingRenewalInceptionDate != null &&
                    this.UpcomingRenewalInceptionDate.Equals(input.UpcomingRenewalInceptionDate))
                ) && 
                (
                    this.PolicyStartDate == input.PolicyStartDate ||
                    (this.PolicyStartDate != null &&
                    this.PolicyStartDate.Equals(input.PolicyStartDate))
                ) && 
                (
                    this.PolicyEndDate == input.PolicyEndDate ||
                    (this.PolicyEndDate != null &&
                    this.PolicyEndDate.Equals(input.PolicyEndDate))
                ) && 
                (
                    this.UnderwriterName == input.UnderwriterName ||
                    (this.UnderwriterName != null &&
                    this.UnderwriterName.Equals(input.UnderwriterName))
                ) && 
                (
                    this.CoverTypeName == input.CoverTypeName ||
                    (this.CoverTypeName != null &&
                    this.CoverTypeName.Equals(input.CoverTypeName))
                ) && 
                (
                    this.ProductTypeName == input.ProductTypeName ||
                    (this.ProductTypeName != null &&
                    this.ProductTypeName.Equals(input.ProductTypeName))
                ) && 
                (
                    this.Provider == input.Provider ||
                    (this.Provider != null &&
                    this.Provider.Equals(input.Provider))
                ) && 
                (
                    this.PossiblyRelatedPolicies == input.PossiblyRelatedPolicies ||
                    (this.PossiblyRelatedPolicies != null &&
                    this.PossiblyRelatedPolicies.Equals(input.PossiblyRelatedPolicies))
                ) && 
                (
                    this.PossiblyRelatedApplicant1 == input.PossiblyRelatedApplicant1 ||
                    (this.PossiblyRelatedApplicant1 != null &&
                    this.PossiblyRelatedApplicant1.Equals(input.PossiblyRelatedApplicant1))
                ) && 
                (
                    this.CompanyName == input.CompanyName ||
                    (this.CompanyName != null &&
                    this.CompanyName.Equals(input.CompanyName))
                ) && 
                (
                    this.PolicyStatus == input.PolicyStatus ||
                    (this.PolicyStatus != null &&
                    this.PolicyStatus.Equals(input.PolicyStatus))
                ) && 
                (
                    this.Policyholder == input.Policyholder ||
                    (this.Policyholder != null &&
                    this.Policyholder.Equals(input.Policyholder))
                ) && 
                (
                    this.Policy == input.Policy ||
                    (this.Policy != null &&
                    this.Policy.Equals(input.Policy))
                ) && 
                (
                    this.Property == input.Property ||
                    (this.Property != null &&
                    this.Property.Equals(input.Property))
                ) && 
                (
                    this.Issues == input.Issues ||
                    (this.Issues != null &&
                    this.Issues.Equals(input.Issues))
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
                if (this.PolicyNumber != null)
                {
                    hashCode = (hashCode * 59) + this.PolicyNumber.GetHashCode();
                }
                if (this.AccountReference != null)
                {
                    hashCode = (hashCode * 59) + this.AccountReference.GetHashCode();
                }
                if (this.UpcomingRenewalPolicyNumber != null)
                {
                    hashCode = (hashCode * 59) + this.UpcomingRenewalPolicyNumber.GetHashCode();
                }
                if (this.UpcomingRenewalInceptionDate != null)
                {
                    hashCode = (hashCode * 59) + this.UpcomingRenewalInceptionDate.GetHashCode();
                }
                if (this.PolicyStartDate != null)
                {
                    hashCode = (hashCode * 59) + this.PolicyStartDate.GetHashCode();
                }
                if (this.PolicyEndDate != null)
                {
                    hashCode = (hashCode * 59) + this.PolicyEndDate.GetHashCode();
                }
                if (this.UnderwriterName != null)
                {
                    hashCode = (hashCode * 59) + this.UnderwriterName.GetHashCode();
                }
                if (this.CoverTypeName != null)
                {
                    hashCode = (hashCode * 59) + this.CoverTypeName.GetHashCode();
                }
                if (this.ProductTypeName != null)
                {
                    hashCode = (hashCode * 59) + this.ProductTypeName.GetHashCode();
                }
                if (this.Provider != null)
                {
                    hashCode = (hashCode * 59) + this.Provider.GetHashCode();
                }
                if (this.PossiblyRelatedPolicies != null)
                {
                    hashCode = (hashCode * 59) + this.PossiblyRelatedPolicies.GetHashCode();
                }
                if (this.PossiblyRelatedApplicant1 != null)
                {
                    hashCode = (hashCode * 59) + this.PossiblyRelatedApplicant1.GetHashCode();
                }
                if (this.CompanyName != null)
                {
                    hashCode = (hashCode * 59) + this.CompanyName.GetHashCode();
                }
                if (this.PolicyStatus != null)
                {
                    hashCode = (hashCode * 59) + this.PolicyStatus.GetHashCode();
                }
                if (this.Policyholder != null)
                {
                    hashCode = (hashCode * 59) + this.Policyholder.GetHashCode();
                }
                if (this.Policy != null)
                {
                    hashCode = (hashCode * 59) + this.Policy.GetHashCode();
                }
                if (this.Property != null)
                {
                    hashCode = (hashCode * 59) + this.Property.GetHashCode();
                }
                if (this.Issues != null)
                {
                    hashCode = (hashCode * 59) + this.Issues.GetHashCode();
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
