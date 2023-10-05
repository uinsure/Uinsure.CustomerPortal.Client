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
    /// Represents a request from for a search query for using to find policies
    /// </summary>
    [DataContract(Name = "FindPoliciesRequest")]
    public partial class FindPoliciesRequest : IEquatable<FindPoliciesRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FindPoliciesRequest" /> class.
        /// </summary>
        /// <param name="agreementNumber">A full or partial agreement number or policy number..</param>
        /// <param name="surname">A full or partial Surname corresponding to either applicant on a policy.</param>
        /// <param name="dateOfBirth">A valid date in the ISO 8601 format corresponding to either applicant on a policy and must be in the past.</param>
        /// <param name="riskAddressPostcode">A full or partial postcode corresponding to the risk address on a policy.</param>
        /// <param name="phoneNumber">A full or partial phone number associated to a policy.</param>
        /// <param name="policyStatus">A full match on the Policy status.</param>
        public FindPoliciesRequest(string agreementNumber = default(string), string surname = default(string), DateTime? dateOfBirth = default(DateTime?), string riskAddressPostcode = default(string), string phoneNumber = default(string), string policyStatus = default(string))
        {
            this._AgreementNumber = agreementNumber;
            if (this.AgreementNumber != null)
            {
                this._flagAgreementNumber = true;
            }
            this._Surname = surname;
            if (this.Surname != null)
            {
                this._flagSurname = true;
            }
            this._DateOfBirth = dateOfBirth;
            if (this.DateOfBirth != null)
            {
                this._flagDateOfBirth = true;
            }
            this._RiskAddressPostcode = riskAddressPostcode;
            if (this.RiskAddressPostcode != null)
            {
                this._flagRiskAddressPostcode = true;
            }
            this._PhoneNumber = phoneNumber;
            if (this.PhoneNumber != null)
            {
                this._flagPhoneNumber = true;
            }
            this._PolicyStatus = policyStatus;
            if (this.PolicyStatus != null)
            {
                this._flagPolicyStatus = true;
            }
        }

        /// <summary>
        /// A full or partial agreement number or policy number.
        /// </summary>
        /// <value>A full or partial agreement number or policy number.</value>
        [DataMember(Name = "AgreementNumber", EmitDefaultValue = true)]
        public string AgreementNumber
        {
            get{ return _AgreementNumber;}
            set
            {
                _AgreementNumber = value;
                _flagAgreementNumber = true;
            }
        }
        private string _AgreementNumber;
        private bool _flagAgreementNumber;

        /// <summary>
        /// Returns false as AgreementNumber should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAgreementNumber()
        {
            return _flagAgreementNumber;
        }
        /// <summary>
        /// A full or partial Surname corresponding to either applicant on a policy
        /// </summary>
        /// <value>A full or partial Surname corresponding to either applicant on a policy</value>
        [DataMember(Name = "Surname", EmitDefaultValue = true)]
        public string Surname
        {
            get{ return _Surname;}
            set
            {
                _Surname = value;
                _flagSurname = true;
            }
        }
        private string _Surname;
        private bool _flagSurname;

        /// <summary>
        /// Returns false as Surname should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSurname()
        {
            return _flagSurname;
        }
        /// <summary>
        /// A valid date in the ISO 8601 format corresponding to either applicant on a policy and must be in the past
        /// </summary>
        /// <value>A valid date in the ISO 8601 format corresponding to either applicant on a policy and must be in the past</value>
        [DataMember(Name = "DateOfBirth", EmitDefaultValue = true)]
        public DateTime? DateOfBirth
        {
            get{ return _DateOfBirth;}
            set
            {
                _DateOfBirth = value;
                _flagDateOfBirth = true;
            }
        }
        private DateTime? _DateOfBirth;
        private bool _flagDateOfBirth;

        /// <summary>
        /// Returns false as DateOfBirth should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDateOfBirth()
        {
            return _flagDateOfBirth;
        }
        /// <summary>
        /// A full or partial postcode corresponding to the risk address on a policy
        /// </summary>
        /// <value>A full or partial postcode corresponding to the risk address on a policy</value>
        [DataMember(Name = "RiskAddressPostcode", EmitDefaultValue = true)]
        public string RiskAddressPostcode
        {
            get{ return _RiskAddressPostcode;}
            set
            {
                _RiskAddressPostcode = value;
                _flagRiskAddressPostcode = true;
            }
        }
        private string _RiskAddressPostcode;
        private bool _flagRiskAddressPostcode;

        /// <summary>
        /// Returns false as RiskAddressPostcode should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeRiskAddressPostcode()
        {
            return _flagRiskAddressPostcode;
        }
        /// <summary>
        /// A full or partial phone number associated to a policy
        /// </summary>
        /// <value>A full or partial phone number associated to a policy</value>
        [DataMember(Name = "PhoneNumber", EmitDefaultValue = true)]
        public string PhoneNumber
        {
            get{ return _PhoneNumber;}
            set
            {
                _PhoneNumber = value;
                _flagPhoneNumber = true;
            }
        }
        private string _PhoneNumber;
        private bool _flagPhoneNumber;

        /// <summary>
        /// Returns false as PhoneNumber should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePhoneNumber()
        {
            return _flagPhoneNumber;
        }
        /// <summary>
        /// A full match on the Policy status
        /// </summary>
        /// <value>A full match on the Policy status</value>
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FindPoliciesRequest {\n");
            sb.Append("  AgreementNumber: ").Append(AgreementNumber).Append("\n");
            sb.Append("  Surname: ").Append(Surname).Append("\n");
            sb.Append("  DateOfBirth: ").Append(DateOfBirth).Append("\n");
            sb.Append("  RiskAddressPostcode: ").Append(RiskAddressPostcode).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  PolicyStatus: ").Append(PolicyStatus).Append("\n");
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
            return this.Equals(input as FindPoliciesRequest);
        }

        /// <summary>
        /// Returns true if FindPoliciesRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of FindPoliciesRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FindPoliciesRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AgreementNumber == input.AgreementNumber ||
                    (this.AgreementNumber != null &&
                    this.AgreementNumber.Equals(input.AgreementNumber))
                ) && 
                (
                    this.Surname == input.Surname ||
                    (this.Surname != null &&
                    this.Surname.Equals(input.Surname))
                ) && 
                (
                    this.DateOfBirth == input.DateOfBirth ||
                    (this.DateOfBirth != null &&
                    this.DateOfBirth.Equals(input.DateOfBirth))
                ) && 
                (
                    this.RiskAddressPostcode == input.RiskAddressPostcode ||
                    (this.RiskAddressPostcode != null &&
                    this.RiskAddressPostcode.Equals(input.RiskAddressPostcode))
                ) && 
                (
                    this.PhoneNumber == input.PhoneNumber ||
                    (this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(input.PhoneNumber))
                ) && 
                (
                    this.PolicyStatus == input.PolicyStatus ||
                    (this.PolicyStatus != null &&
                    this.PolicyStatus.Equals(input.PolicyStatus))
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
                if (this.AgreementNumber != null)
                {
                    hashCode = (hashCode * 59) + this.AgreementNumber.GetHashCode();
                }
                if (this.Surname != null)
                {
                    hashCode = (hashCode * 59) + this.Surname.GetHashCode();
                }
                if (this.DateOfBirth != null)
                {
                    hashCode = (hashCode * 59) + this.DateOfBirth.GetHashCode();
                }
                if (this.RiskAddressPostcode != null)
                {
                    hashCode = (hashCode * 59) + this.RiskAddressPostcode.GetHashCode();
                }
                if (this.PhoneNumber != null)
                {
                    hashCode = (hashCode * 59) + this.PhoneNumber.GetHashCode();
                }
                if (this.PolicyStatus != null)
                {
                    hashCode = (hashCode * 59) + this.PolicyStatus.GetHashCode();
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
            if (this.AgreementNumber != null) {
                // AgreementNumber (string) pattern
                Regex regexAgreementNumber = new Regex(@"[A-z]*\d+(\/\d)?", RegexOptions.CultureInvariant);
                if (!regexAgreementNumber.Match(this.AgreementNumber).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AgreementNumber, must match a pattern of " + regexAgreementNumber, new [] { "AgreementNumber" });
                }
            }

            // Surname (string) maxLength
            if (this.Surname != null && this.Surname.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Surname, length must be less than 100.", new [] { "Surname" });
            }

            // Surname (string) minLength
            if (this.Surname != null && this.Surname.Length < 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Surname, length must be greater than 2.", new [] { "Surname" });
            }

            if (this.Surname != null) {
                // Surname (string) pattern
                Regex regexSurname = new Regex(@"(?i)^(?:(?![×Þß÷þø])[-'A-zÀ-ÿ\s])*$", RegexOptions.CultureInvariant);
                if (!regexSurname.Match(this.Surname).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Surname, must match a pattern of " + regexSurname, new [] { "Surname" });
                }
            }

            if (this.RiskAddressPostcode != null) {
                // RiskAddressPostcode (string) pattern
                Regex regexRiskAddressPostcode = new Regex(@"^[a-zA-Z]{1,2}\d{1,2}[a-zA-Z]?(\s?\d[a-zA-Z]{2})?$", RegexOptions.CultureInvariant);
                if (!regexRiskAddressPostcode.Match(this.RiskAddressPostcode).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RiskAddressPostcode, must match a pattern of " + regexRiskAddressPostcode, new [] { "RiskAddressPostcode" });
                }
            }

            if (this.PhoneNumber != null) {
                // PhoneNumber (string) pattern
                Regex regexPhoneNumber = new Regex(@"^(\+\d{2}|0)7?\d{9,10}$", RegexOptions.CultureInvariant);
                if (!regexPhoneNumber.Match(this.PhoneNumber).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PhoneNumber, must match a pattern of " + regexPhoneNumber, new [] { "PhoneNumber" });
                }
            }

            if (this.PolicyStatus != null) {
                // PolicyStatus (string) pattern
                Regex regexPolicyStatus = new Regex(@"^(Live|Expired|Renewal|Future|Cancelled)$", RegexOptions.CultureInvariant);
                if (!regexPolicyStatus.Match(this.PolicyStatus).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PolicyStatus, must match a pattern of " + regexPolicyStatus, new [] { "PolicyStatus" });
                }
            }

            yield break;
        }
    }

}