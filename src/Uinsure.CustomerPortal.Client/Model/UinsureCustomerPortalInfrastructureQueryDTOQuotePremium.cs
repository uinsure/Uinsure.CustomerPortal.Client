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
    /// UinsureCustomerPortalInfrastructureQueryDTOQuotePremium
    /// </summary>
    [DataContract(Name = "Uinsure.CustomerPortal.Infrastructure.Query.DTO.QuotePremium")]
    public partial class UinsureCustomerPortalInfrastructureQueryDTOQuotePremium : IEquatable<UinsureCustomerPortalInfrastructureQueryDTOQuotePremium>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UinsureCustomerPortalInfrastructureQueryDTOQuotePremium" /> class.
        /// </summary>
        /// <param name="provider">provider.</param>
        /// <param name="creditCharge">creditCharge.</param>
        /// <param name="totalMonthlyPremium">totalMonthlyPremium.</param>
        /// <param name="totalAmountPayable">totalAmountPayable.</param>
        /// <param name="lastYearsPremium">lastYearsPremium.</param>
        /// <param name="lastYearsPremiumWithoutPremiumFunding">lastYearsPremiumWithoutPremiumFunding.</param>
        /// <param name="lastYearsMonthlyPremium">lastYearsMonthlyPremium.</param>
        /// <param name="isPayingMonthly">isPayingMonthly.</param>
        /// <param name="isPremiumFunded">isPremiumFunded.</param>
        public UinsureCustomerPortalInfrastructureQueryDTOQuotePremium(string provider = default(string), double creditCharge = default(double), double totalMonthlyPremium = default(double), double totalAmountPayable = default(double), double lastYearsPremium = default(double), double lastYearsPremiumWithoutPremiumFunding = default(double), double lastYearsMonthlyPremium = default(double), bool isPayingMonthly = default(bool), bool isPremiumFunded = default(bool))
        {
            this._Provider = provider;
            if (this.Provider != null)
            {
                this._flagProvider = true;
            }
            this._CreditCharge = creditCharge;
            if (this.CreditCharge != null)
            {
                this._flagCreditCharge = true;
            }
            this._TotalMonthlyPremium = totalMonthlyPremium;
            if (this.TotalMonthlyPremium != null)
            {
                this._flagTotalMonthlyPremium = true;
            }
            this._TotalAmountPayable = totalAmountPayable;
            if (this.TotalAmountPayable != null)
            {
                this._flagTotalAmountPayable = true;
            }
            this._LastYearsPremium = lastYearsPremium;
            if (this.LastYearsPremium != null)
            {
                this._flagLastYearsPremium = true;
            }
            this._LastYearsPremiumWithoutPremiumFunding = lastYearsPremiumWithoutPremiumFunding;
            if (this.LastYearsPremiumWithoutPremiumFunding != null)
            {
                this._flagLastYearsPremiumWithoutPremiumFunding = true;
            }
            this._LastYearsMonthlyPremium = lastYearsMonthlyPremium;
            if (this.LastYearsMonthlyPremium != null)
            {
                this._flagLastYearsMonthlyPremium = true;
            }
            this._IsPayingMonthly = isPayingMonthly;
            if (this.IsPayingMonthly != null)
            {
                this._flagIsPayingMonthly = true;
            }
            this._IsPremiumFunded = isPremiumFunded;
            if (this.IsPremiumFunded != null)
            {
                this._flagIsPremiumFunded = true;
            }
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
        /// Gets or Sets CreditCharge
        /// </summary>
        [DataMember(Name = "CreditCharge", EmitDefaultValue = false)]
        public double CreditCharge
        {
            get{ return _CreditCharge;}
            set
            {
                _CreditCharge = value;
                _flagCreditCharge = true;
            }
        }
        private double _CreditCharge;
        private bool _flagCreditCharge;

        /// <summary>
        /// Returns false as CreditCharge should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreditCharge()
        {
            return _flagCreditCharge;
        }
        /// <summary>
        /// Gets or Sets TotalMonthlyPremium
        /// </summary>
        [DataMember(Name = "TotalMonthlyPremium", EmitDefaultValue = false)]
        public double TotalMonthlyPremium
        {
            get{ return _TotalMonthlyPremium;}
            set
            {
                _TotalMonthlyPremium = value;
                _flagTotalMonthlyPremium = true;
            }
        }
        private double _TotalMonthlyPremium;
        private bool _flagTotalMonthlyPremium;

        /// <summary>
        /// Returns false as TotalMonthlyPremium should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTotalMonthlyPremium()
        {
            return _flagTotalMonthlyPremium;
        }
        /// <summary>
        /// Gets or Sets TotalAmountPayable
        /// </summary>
        [DataMember(Name = "TotalAmountPayable", EmitDefaultValue = false)]
        public double TotalAmountPayable
        {
            get{ return _TotalAmountPayable;}
            set
            {
                _TotalAmountPayable = value;
                _flagTotalAmountPayable = true;
            }
        }
        private double _TotalAmountPayable;
        private bool _flagTotalAmountPayable;

        /// <summary>
        /// Returns false as TotalAmountPayable should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTotalAmountPayable()
        {
            return _flagTotalAmountPayable;
        }
        /// <summary>
        /// Gets or Sets LastYearsPremium
        /// </summary>
        [DataMember(Name = "LastYearsPremium", EmitDefaultValue = false)]
        public double LastYearsPremium
        {
            get{ return _LastYearsPremium;}
            set
            {
                _LastYearsPremium = value;
                _flagLastYearsPremium = true;
            }
        }
        private double _LastYearsPremium;
        private bool _flagLastYearsPremium;

        /// <summary>
        /// Returns false as LastYearsPremium should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLastYearsPremium()
        {
            return _flagLastYearsPremium;
        }
        /// <summary>
        /// Gets or Sets LastYearsPremiumWithoutPremiumFunding
        /// </summary>
        [DataMember(Name = "LastYearsPremiumWithoutPremiumFunding", EmitDefaultValue = false)]
        public double LastYearsPremiumWithoutPremiumFunding
        {
            get{ return _LastYearsPremiumWithoutPremiumFunding;}
            set
            {
                _LastYearsPremiumWithoutPremiumFunding = value;
                _flagLastYearsPremiumWithoutPremiumFunding = true;
            }
        }
        private double _LastYearsPremiumWithoutPremiumFunding;
        private bool _flagLastYearsPremiumWithoutPremiumFunding;

        /// <summary>
        /// Returns false as LastYearsPremiumWithoutPremiumFunding should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLastYearsPremiumWithoutPremiumFunding()
        {
            return _flagLastYearsPremiumWithoutPremiumFunding;
        }
        /// <summary>
        /// Gets or Sets LastYearsMonthlyPremium
        /// </summary>
        [DataMember(Name = "LastYearsMonthlyPremium", EmitDefaultValue = false)]
        public double LastYearsMonthlyPremium
        {
            get{ return _LastYearsMonthlyPremium;}
            set
            {
                _LastYearsMonthlyPremium = value;
                _flagLastYearsMonthlyPremium = true;
            }
        }
        private double _LastYearsMonthlyPremium;
        private bool _flagLastYearsMonthlyPremium;

        /// <summary>
        /// Returns false as LastYearsMonthlyPremium should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLastYearsMonthlyPremium()
        {
            return _flagLastYearsMonthlyPremium;
        }
        /// <summary>
        /// Gets or Sets IsPayingMonthly
        /// </summary>
        [DataMember(Name = "IsPayingMonthly", EmitDefaultValue = true)]
        public bool IsPayingMonthly
        {
            get{ return _IsPayingMonthly;}
            set
            {
                _IsPayingMonthly = value;
                _flagIsPayingMonthly = true;
            }
        }
        private bool _IsPayingMonthly;
        private bool _flagIsPayingMonthly;

        /// <summary>
        /// Returns false as IsPayingMonthly should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeIsPayingMonthly()
        {
            return _flagIsPayingMonthly;
        }
        /// <summary>
        /// Gets or Sets IsPremiumFunded
        /// </summary>
        [DataMember(Name = "IsPremiumFunded", EmitDefaultValue = true)]
        public bool IsPremiumFunded
        {
            get{ return _IsPremiumFunded;}
            set
            {
                _IsPremiumFunded = value;
                _flagIsPremiumFunded = true;
            }
        }
        private bool _IsPremiumFunded;
        private bool _flagIsPremiumFunded;

        /// <summary>
        /// Returns false as IsPremiumFunded should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeIsPremiumFunded()
        {
            return _flagIsPremiumFunded;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UinsureCustomerPortalInfrastructureQueryDTOQuotePremium {\n");
            sb.Append("  Provider: ").Append(Provider).Append("\n");
            sb.Append("  CreditCharge: ").Append(CreditCharge).Append("\n");
            sb.Append("  TotalMonthlyPremium: ").Append(TotalMonthlyPremium).Append("\n");
            sb.Append("  TotalAmountPayable: ").Append(TotalAmountPayable).Append("\n");
            sb.Append("  LastYearsPremium: ").Append(LastYearsPremium).Append("\n");
            sb.Append("  LastYearsPremiumWithoutPremiumFunding: ").Append(LastYearsPremiumWithoutPremiumFunding).Append("\n");
            sb.Append("  LastYearsMonthlyPremium: ").Append(LastYearsMonthlyPremium).Append("\n");
            sb.Append("  IsPayingMonthly: ").Append(IsPayingMonthly).Append("\n");
            sb.Append("  IsPremiumFunded: ").Append(IsPremiumFunded).Append("\n");
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
            return this.Equals(input as UinsureCustomerPortalInfrastructureQueryDTOQuotePremium);
        }

        /// <summary>
        /// Returns true if UinsureCustomerPortalInfrastructureQueryDTOQuotePremium instances are equal
        /// </summary>
        /// <param name="input">Instance of UinsureCustomerPortalInfrastructureQueryDTOQuotePremium to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UinsureCustomerPortalInfrastructureQueryDTOQuotePremium input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Provider == input.Provider ||
                    (this.Provider != null &&
                    this.Provider.Equals(input.Provider))
                ) && 
                (
                    this.CreditCharge == input.CreditCharge ||
                    this.CreditCharge.Equals(input.CreditCharge)
                ) && 
                (
                    this.TotalMonthlyPremium == input.TotalMonthlyPremium ||
                    this.TotalMonthlyPremium.Equals(input.TotalMonthlyPremium)
                ) && 
                (
                    this.TotalAmountPayable == input.TotalAmountPayable ||
                    this.TotalAmountPayable.Equals(input.TotalAmountPayable)
                ) && 
                (
                    this.LastYearsPremium == input.LastYearsPremium ||
                    this.LastYearsPremium.Equals(input.LastYearsPremium)
                ) && 
                (
                    this.LastYearsPremiumWithoutPremiumFunding == input.LastYearsPremiumWithoutPremiumFunding ||
                    this.LastYearsPremiumWithoutPremiumFunding.Equals(input.LastYearsPremiumWithoutPremiumFunding)
                ) && 
                (
                    this.LastYearsMonthlyPremium == input.LastYearsMonthlyPremium ||
                    this.LastYearsMonthlyPremium.Equals(input.LastYearsMonthlyPremium)
                ) && 
                (
                    this.IsPayingMonthly == input.IsPayingMonthly ||
                    this.IsPayingMonthly.Equals(input.IsPayingMonthly)
                ) && 
                (
                    this.IsPremiumFunded == input.IsPremiumFunded ||
                    this.IsPremiumFunded.Equals(input.IsPremiumFunded)
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
                if (this.Provider != null)
                {
                    hashCode = (hashCode * 59) + this.Provider.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CreditCharge.GetHashCode();
                hashCode = (hashCode * 59) + this.TotalMonthlyPremium.GetHashCode();
                hashCode = (hashCode * 59) + this.TotalAmountPayable.GetHashCode();
                hashCode = (hashCode * 59) + this.LastYearsPremium.GetHashCode();
                hashCode = (hashCode * 59) + this.LastYearsPremiumWithoutPremiumFunding.GetHashCode();
                hashCode = (hashCode * 59) + this.LastYearsMonthlyPremium.GetHashCode();
                hashCode = (hashCode * 59) + this.IsPayingMonthly.GetHashCode();
                hashCode = (hashCode * 59) + this.IsPremiumFunded.GetHashCode();
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