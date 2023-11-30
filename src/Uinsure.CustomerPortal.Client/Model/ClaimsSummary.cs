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
    /// DTO containing summary of all claims details for an account
    /// </summary>
    [DataContract(Name = "ClaimsSummary")]
    public partial class ClaimsSummary : IEquatable<ClaimsSummary>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClaimsSummary" /> class.
        /// </summary>
        /// <param name="insurerClaimsNumber">Contact number for the insurer.</param>
        /// <param name="lastBuildingsClaimDate">Date of latest Buildings related claim.</param>
        /// <param name="lastContentsClaimDate">Date of latest Contents related claim.</param>
        /// <param name="lastClaimDate">Date of latest claim.</param>
        /// <param name="openClaims">Number of open claims against this account reference.</param>
        /// <param name="claimsLast3Years">Number of claims made in the last three years.</param>
        /// <param name="claimCostLast3Years">Total cost of claims made in the last three years.</param>
        /// <param name="floodClaims">Number of claims made relating to Flooding.</param>
        /// <param name="subsidenceClaims">Number of claims made relating to Subsidence.</param>
        /// <param name="history">A collection of claims made against policies relating to this account.</param>
        public ClaimsSummary(string insurerClaimsNumber = default(string), DateTime? lastBuildingsClaimDate = default(DateTime?), DateTime? lastContentsClaimDate = default(DateTime?), DateTime? lastClaimDate = default(DateTime?), int? openClaims = default(int?), int? claimsLast3Years = default(int?), double? claimCostLast3Years = default(double?), int? floodClaims = default(int?), int? subsidenceClaims = default(int?), List<Claim> history = default(List<Claim>))
        {
            this._InsurerClaimsNumber = insurerClaimsNumber;
            if (this.InsurerClaimsNumber != null)
            {
                this._flagInsurerClaimsNumber = true;
            }
            this._LastBuildingsClaimDate = lastBuildingsClaimDate;
            if (this.LastBuildingsClaimDate != null)
            {
                this._flagLastBuildingsClaimDate = true;
            }
            this._LastContentsClaimDate = lastContentsClaimDate;
            if (this.LastContentsClaimDate != null)
            {
                this._flagLastContentsClaimDate = true;
            }
            this._LastClaimDate = lastClaimDate;
            if (this.LastClaimDate != null)
            {
                this._flagLastClaimDate = true;
            }
            this._OpenClaims = openClaims;
            if (this.OpenClaims != null)
            {
                this._flagOpenClaims = true;
            }
            this._ClaimsLast3Years = claimsLast3Years;
            if (this.ClaimsLast3Years != null)
            {
                this._flagClaimsLast3Years = true;
            }
            this._ClaimCostLast3Years = claimCostLast3Years;
            if (this.ClaimCostLast3Years != null)
            {
                this._flagClaimCostLast3Years = true;
            }
            this._FloodClaims = floodClaims;
            if (this.FloodClaims != null)
            {
                this._flagFloodClaims = true;
            }
            this._SubsidenceClaims = subsidenceClaims;
            if (this.SubsidenceClaims != null)
            {
                this._flagSubsidenceClaims = true;
            }
            this._History = history;
            if (this.History != null)
            {
                this._flagHistory = true;
            }
        }

        /// <summary>
        /// Contact number for the insurer
        /// </summary>
        /// <value>Contact number for the insurer</value>
        [DataMember(Name = "InsurerClaimsNumber", EmitDefaultValue = true)]
        public string InsurerClaimsNumber
        {
            get{ return _InsurerClaimsNumber;}
            set
            {
                _InsurerClaimsNumber = value;
                _flagInsurerClaimsNumber = true;
            }
        }
        private string _InsurerClaimsNumber;
        private bool _flagInsurerClaimsNumber;

        /// <summary>
        /// Returns false as InsurerClaimsNumber should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeInsurerClaimsNumber()
        {
            return _flagInsurerClaimsNumber;
        }
        /// <summary>
        /// Date of latest Buildings related claim
        /// </summary>
        /// <value>Date of latest Buildings related claim</value>
        [DataMember(Name = "LastBuildingsClaimDate", EmitDefaultValue = true)]
        public DateTime? LastBuildingsClaimDate
        {
            get{ return _LastBuildingsClaimDate;}
            set
            {
                _LastBuildingsClaimDate = value;
                _flagLastBuildingsClaimDate = true;
            }
        }
        private DateTime? _LastBuildingsClaimDate;
        private bool _flagLastBuildingsClaimDate;

        /// <summary>
        /// Returns false as LastBuildingsClaimDate should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLastBuildingsClaimDate()
        {
            return _flagLastBuildingsClaimDate;
        }
        /// <summary>
        /// Date of latest Contents related claim
        /// </summary>
        /// <value>Date of latest Contents related claim</value>
        [DataMember(Name = "LastContentsClaimDate", EmitDefaultValue = true)]
        public DateTime? LastContentsClaimDate
        {
            get{ return _LastContentsClaimDate;}
            set
            {
                _LastContentsClaimDate = value;
                _flagLastContentsClaimDate = true;
            }
        }
        private DateTime? _LastContentsClaimDate;
        private bool _flagLastContentsClaimDate;

        /// <summary>
        /// Returns false as LastContentsClaimDate should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLastContentsClaimDate()
        {
            return _flagLastContentsClaimDate;
        }
        /// <summary>
        /// Date of latest claim
        /// </summary>
        /// <value>Date of latest claim</value>
        [DataMember(Name = "LastClaimDate", EmitDefaultValue = true)]
        public DateTime? LastClaimDate
        {
            get{ return _LastClaimDate;}
            set
            {
                _LastClaimDate = value;
                _flagLastClaimDate = true;
            }
        }
        private DateTime? _LastClaimDate;
        private bool _flagLastClaimDate;

        /// <summary>
        /// Returns false as LastClaimDate should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLastClaimDate()
        {
            return _flagLastClaimDate;
        }
        /// <summary>
        /// Number of open claims against this account reference
        /// </summary>
        /// <value>Number of open claims against this account reference</value>
        [DataMember(Name = "OpenClaims", EmitDefaultValue = true)]
        public int? OpenClaims
        {
            get{ return _OpenClaims;}
            set
            {
                _OpenClaims = value;
                _flagOpenClaims = true;
            }
        }
        private int? _OpenClaims;
        private bool _flagOpenClaims;

        /// <summary>
        /// Returns false as OpenClaims should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeOpenClaims()
        {
            return _flagOpenClaims;
        }
        /// <summary>
        /// Number of claims made in the last three years
        /// </summary>
        /// <value>Number of claims made in the last three years</value>
        [DataMember(Name = "ClaimsLast3Years", EmitDefaultValue = true)]
        public int? ClaimsLast3Years
        {
            get{ return _ClaimsLast3Years;}
            set
            {
                _ClaimsLast3Years = value;
                _flagClaimsLast3Years = true;
            }
        }
        private int? _ClaimsLast3Years;
        private bool _flagClaimsLast3Years;

        /// <summary>
        /// Returns false as ClaimsLast3Years should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeClaimsLast3Years()
        {
            return _flagClaimsLast3Years;
        }
        /// <summary>
        /// Total cost of claims made in the last three years
        /// </summary>
        /// <value>Total cost of claims made in the last three years</value>
        [DataMember(Name = "ClaimCostLast3Years", EmitDefaultValue = true)]
        public double? ClaimCostLast3Years
        {
            get{ return _ClaimCostLast3Years;}
            set
            {
                _ClaimCostLast3Years = value;
                _flagClaimCostLast3Years = true;
            }
        }
        private double? _ClaimCostLast3Years;
        private bool _flagClaimCostLast3Years;

        /// <summary>
        /// Returns false as ClaimCostLast3Years should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeClaimCostLast3Years()
        {
            return _flagClaimCostLast3Years;
        }
        /// <summary>
        /// Number of claims made relating to Flooding
        /// </summary>
        /// <value>Number of claims made relating to Flooding</value>
        [DataMember(Name = "FloodClaims", EmitDefaultValue = true)]
        public int? FloodClaims
        {
            get{ return _FloodClaims;}
            set
            {
                _FloodClaims = value;
                _flagFloodClaims = true;
            }
        }
        private int? _FloodClaims;
        private bool _flagFloodClaims;

        /// <summary>
        /// Returns false as FloodClaims should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFloodClaims()
        {
            return _flagFloodClaims;
        }
        /// <summary>
        /// Number of claims made relating to Subsidence
        /// </summary>
        /// <value>Number of claims made relating to Subsidence</value>
        [DataMember(Name = "SubsidenceClaims", EmitDefaultValue = true)]
        public int? SubsidenceClaims
        {
            get{ return _SubsidenceClaims;}
            set
            {
                _SubsidenceClaims = value;
                _flagSubsidenceClaims = true;
            }
        }
        private int? _SubsidenceClaims;
        private bool _flagSubsidenceClaims;

        /// <summary>
        /// Returns false as SubsidenceClaims should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSubsidenceClaims()
        {
            return _flagSubsidenceClaims;
        }
        /// <summary>
        /// A collection of claims made against policies relating to this account
        /// </summary>
        /// <value>A collection of claims made against policies relating to this account</value>
        [DataMember(Name = "History", EmitDefaultValue = true)]
        public List<Claim> History
        {
            get{ return _History;}
            set
            {
                _History = value;
                _flagHistory = true;
            }
        }
        private List<Claim> _History;
        private bool _flagHistory;

        /// <summary>
        /// Returns false as History should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeHistory()
        {
            return _flagHistory;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ClaimsSummary {\n");
            sb.Append("  InsurerClaimsNumber: ").Append(InsurerClaimsNumber).Append("\n");
            sb.Append("  LastBuildingsClaimDate: ").Append(LastBuildingsClaimDate).Append("\n");
            sb.Append("  LastContentsClaimDate: ").Append(LastContentsClaimDate).Append("\n");
            sb.Append("  LastClaimDate: ").Append(LastClaimDate).Append("\n");
            sb.Append("  OpenClaims: ").Append(OpenClaims).Append("\n");
            sb.Append("  ClaimsLast3Years: ").Append(ClaimsLast3Years).Append("\n");
            sb.Append("  ClaimCostLast3Years: ").Append(ClaimCostLast3Years).Append("\n");
            sb.Append("  FloodClaims: ").Append(FloodClaims).Append("\n");
            sb.Append("  SubsidenceClaims: ").Append(SubsidenceClaims).Append("\n");
            sb.Append("  History: ").Append(History).Append("\n");
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
            return this.Equals(input as ClaimsSummary);
        }

        /// <summary>
        /// Returns true if ClaimsSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of ClaimsSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClaimsSummary input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.InsurerClaimsNumber == input.InsurerClaimsNumber ||
                    (this.InsurerClaimsNumber != null &&
                    this.InsurerClaimsNumber.Equals(input.InsurerClaimsNumber))
                ) && 
                (
                    this.LastBuildingsClaimDate == input.LastBuildingsClaimDate ||
                    (this.LastBuildingsClaimDate != null &&
                    this.LastBuildingsClaimDate.Equals(input.LastBuildingsClaimDate))
                ) && 
                (
                    this.LastContentsClaimDate == input.LastContentsClaimDate ||
                    (this.LastContentsClaimDate != null &&
                    this.LastContentsClaimDate.Equals(input.LastContentsClaimDate))
                ) && 
                (
                    this.LastClaimDate == input.LastClaimDate ||
                    (this.LastClaimDate != null &&
                    this.LastClaimDate.Equals(input.LastClaimDate))
                ) && 
                (
                    this.OpenClaims == input.OpenClaims ||
                    (this.OpenClaims != null &&
                    this.OpenClaims.Equals(input.OpenClaims))
                ) && 
                (
                    this.ClaimsLast3Years == input.ClaimsLast3Years ||
                    (this.ClaimsLast3Years != null &&
                    this.ClaimsLast3Years.Equals(input.ClaimsLast3Years))
                ) && 
                (
                    this.ClaimCostLast3Years == input.ClaimCostLast3Years ||
                    (this.ClaimCostLast3Years != null &&
                    this.ClaimCostLast3Years.Equals(input.ClaimCostLast3Years))
                ) && 
                (
                    this.FloodClaims == input.FloodClaims ||
                    (this.FloodClaims != null &&
                    this.FloodClaims.Equals(input.FloodClaims))
                ) && 
                (
                    this.SubsidenceClaims == input.SubsidenceClaims ||
                    (this.SubsidenceClaims != null &&
                    this.SubsidenceClaims.Equals(input.SubsidenceClaims))
                ) && 
                (
                    this.History == input.History ||
                    this.History != null &&
                    input.History != null &&
                    this.History.SequenceEqual(input.History)
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
                if (this.InsurerClaimsNumber != null)
                {
                    hashCode = (hashCode * 59) + this.InsurerClaimsNumber.GetHashCode();
                }
                if (this.LastBuildingsClaimDate != null)
                {
                    hashCode = (hashCode * 59) + this.LastBuildingsClaimDate.GetHashCode();
                }
                if (this.LastContentsClaimDate != null)
                {
                    hashCode = (hashCode * 59) + this.LastContentsClaimDate.GetHashCode();
                }
                if (this.LastClaimDate != null)
                {
                    hashCode = (hashCode * 59) + this.LastClaimDate.GetHashCode();
                }
                if (this.OpenClaims != null)
                {
                    hashCode = (hashCode * 59) + this.OpenClaims.GetHashCode();
                }
                if (this.ClaimsLast3Years != null)
                {
                    hashCode = (hashCode * 59) + this.ClaimsLast3Years.GetHashCode();
                }
                if (this.ClaimCostLast3Years != null)
                {
                    hashCode = (hashCode * 59) + this.ClaimCostLast3Years.GetHashCode();
                }
                if (this.FloodClaims != null)
                {
                    hashCode = (hashCode * 59) + this.FloodClaims.GetHashCode();
                }
                if (this.SubsidenceClaims != null)
                {
                    hashCode = (hashCode * 59) + this.SubsidenceClaims.GetHashCode();
                }
                if (this.History != null)
                {
                    hashCode = (hashCode * 59) + this.History.GetHashCode();
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