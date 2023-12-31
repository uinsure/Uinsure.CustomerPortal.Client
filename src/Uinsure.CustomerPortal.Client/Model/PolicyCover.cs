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
    /// DTO with details relating to the cover details of a policy.
    /// </summary>
    [DataContract(Name = "PolicyCover")]
    public partial class PolicyCover : IEquatable<PolicyCover>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyCover" /> class.
        /// </summary>
        /// <param name="isFirstTimeBuyer">Is this customer a first time buyer?.</param>
        /// <param name="buildingsCoverAmount">Buildings cover limit..</param>
        /// <param name="buildingsAccidentalCover">Is Accidental damage for Buildings cover included?.</param>
        /// <param name="buildingsExcess">Excess payable for Buildings cover..</param>
        /// <param name="buildingsNoClaimYears">No claims discount for Buildings cover..</param>
        /// <param name="contentsCoverAmount">Contents cover limit..</param>
        /// <param name="contentsAccidentalDamage">Is Accidental damage for Contents cover included?.</param>
        /// <param name="contentsExcess">Excess payable for Contents cover..</param>
        /// <param name="contentsNoClaimYears">No claims discount for Contents cover..</param>
        /// <param name="personalBelongingsCover">Total cover required for unspecified personal belongings.</param>
        /// <param name="buildingsNcdCurrentPolicy">No claims discount for Buildings cover..</param>
        /// <param name="buildingsNcdNextRenewal">No claims discount for Buildings cover upon next renewal..</param>
        /// <param name="buildingsUinsureCurrentClaimFreeTenure">No claims discount for Buildings cover..</param>
        /// <param name="contentsNcdCurrentPolicy">No claims discount for Contents cover..</param>
        /// <param name="contentsNcdNextRenewal">No claims discount for Contents cover upon next renewal..</param>
        /// <param name="contentsUinsureCurrentClaimFreeTenure">No claims discount for Contents cover..</param>
        /// <param name="eligibleForRebroke">Is this customer eligible for rebroke?.</param>
        /// <param name="originalInceptionDate">Original inception date of policy..</param>
        public PolicyCover(bool? isFirstTimeBuyer = default(bool?), double? buildingsCoverAmount = default(double?), bool? buildingsAccidentalCover = default(bool?), double? buildingsExcess = default(double?), int? buildingsNoClaimYears = default(int?), double? contentsCoverAmount = default(double?), bool? contentsAccidentalDamage = default(bool?), double? contentsExcess = default(double?), int? contentsNoClaimYears = default(int?), double? personalBelongingsCover = default(double?), int? buildingsNcdCurrentPolicy = default(int?), int? buildingsNcdNextRenewal = default(int?), int? buildingsUinsureCurrentClaimFreeTenure = default(int?), int? contentsNcdCurrentPolicy = default(int?), int? contentsNcdNextRenewal = default(int?), int? contentsUinsureCurrentClaimFreeTenure = default(int?), bool? eligibleForRebroke = default(bool?), DateTime? originalInceptionDate = default(DateTime?))
        {
            this._IsFirstTimeBuyer = isFirstTimeBuyer;
            if (this.IsFirstTimeBuyer != null)
            {
                this._flagIsFirstTimeBuyer = true;
            }
            this._BuildingsCoverAmount = buildingsCoverAmount;
            if (this.BuildingsCoverAmount != null)
            {
                this._flagBuildingsCoverAmount = true;
            }
            this._BuildingsAccidentalCover = buildingsAccidentalCover;
            if (this.BuildingsAccidentalCover != null)
            {
                this._flagBuildingsAccidentalCover = true;
            }
            this._BuildingsExcess = buildingsExcess;
            if (this.BuildingsExcess != null)
            {
                this._flagBuildingsExcess = true;
            }
            this._BuildingsNoClaimYears = buildingsNoClaimYears;
            if (this.BuildingsNoClaimYears != null)
            {
                this._flagBuildingsNoClaimYears = true;
            }
            this._ContentsCoverAmount = contentsCoverAmount;
            if (this.ContentsCoverAmount != null)
            {
                this._flagContentsCoverAmount = true;
            }
            this._ContentsAccidentalDamage = contentsAccidentalDamage;
            if (this.ContentsAccidentalDamage != null)
            {
                this._flagContentsAccidentalDamage = true;
            }
            this._ContentsExcess = contentsExcess;
            if (this.ContentsExcess != null)
            {
                this._flagContentsExcess = true;
            }
            this._ContentsNoClaimYears = contentsNoClaimYears;
            if (this.ContentsNoClaimYears != null)
            {
                this._flagContentsNoClaimYears = true;
            }
            this._PersonalBelongingsCover = personalBelongingsCover;
            if (this.PersonalBelongingsCover != null)
            {
                this._flagPersonalBelongingsCover = true;
            }
            this._BuildingsNcdCurrentPolicy = buildingsNcdCurrentPolicy;
            if (this.BuildingsNcdCurrentPolicy != null)
            {
                this._flagBuildingsNcdCurrentPolicy = true;
            }
            this._BuildingsNcdNextRenewal = buildingsNcdNextRenewal;
            if (this.BuildingsNcdNextRenewal != null)
            {
                this._flagBuildingsNcdNextRenewal = true;
            }
            this._BuildingsUinsureCurrentClaimFreeTenure = buildingsUinsureCurrentClaimFreeTenure;
            if (this.BuildingsUinsureCurrentClaimFreeTenure != null)
            {
                this._flagBuildingsUinsureCurrentClaimFreeTenure = true;
            }
            this._ContentsNcdCurrentPolicy = contentsNcdCurrentPolicy;
            if (this.ContentsNcdCurrentPolicy != null)
            {
                this._flagContentsNcdCurrentPolicy = true;
            }
            this._ContentsNcdNextRenewal = contentsNcdNextRenewal;
            if (this.ContentsNcdNextRenewal != null)
            {
                this._flagContentsNcdNextRenewal = true;
            }
            this._ContentsUinsureCurrentClaimFreeTenure = contentsUinsureCurrentClaimFreeTenure;
            if (this.ContentsUinsureCurrentClaimFreeTenure != null)
            {
                this._flagContentsUinsureCurrentClaimFreeTenure = true;
            }
            this._EligibleForRebroke = eligibleForRebroke;
            if (this.EligibleForRebroke != null)
            {
                this._flagEligibleForRebroke = true;
            }
            this._OriginalInceptionDate = originalInceptionDate;
            if (this.OriginalInceptionDate != null)
            {
                this._flagOriginalInceptionDate = true;
            }
        }

        /// <summary>
        /// Is this customer a first time buyer?
        /// </summary>
        /// <value>Is this customer a first time buyer?</value>
        [DataMember(Name = "IsFirstTimeBuyer", EmitDefaultValue = true)]
        public bool? IsFirstTimeBuyer
        {
            get{ return _IsFirstTimeBuyer;}
            set
            {
                _IsFirstTimeBuyer = value;
                _flagIsFirstTimeBuyer = true;
            }
        }
        private bool? _IsFirstTimeBuyer;
        private bool _flagIsFirstTimeBuyer;

        /// <summary>
        /// Returns false as IsFirstTimeBuyer should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeIsFirstTimeBuyer()
        {
            return _flagIsFirstTimeBuyer;
        }
        /// <summary>
        /// Buildings cover limit.
        /// </summary>
        /// <value>Buildings cover limit.</value>
        [DataMember(Name = "BuildingsCoverAmount", EmitDefaultValue = true)]
        public double? BuildingsCoverAmount
        {
            get{ return _BuildingsCoverAmount;}
            set
            {
                _BuildingsCoverAmount = value;
                _flagBuildingsCoverAmount = true;
            }
        }
        private double? _BuildingsCoverAmount;
        private bool _flagBuildingsCoverAmount;

        /// <summary>
        /// Returns false as BuildingsCoverAmount should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeBuildingsCoverAmount()
        {
            return _flagBuildingsCoverAmount;
        }
        /// <summary>
        /// Is Accidental damage for Buildings cover included?
        /// </summary>
        /// <value>Is Accidental damage for Buildings cover included?</value>
        [DataMember(Name = "BuildingsAccidentalCover", EmitDefaultValue = true)]
        public bool? BuildingsAccidentalCover
        {
            get{ return _BuildingsAccidentalCover;}
            set
            {
                _BuildingsAccidentalCover = value;
                _flagBuildingsAccidentalCover = true;
            }
        }
        private bool? _BuildingsAccidentalCover;
        private bool _flagBuildingsAccidentalCover;

        /// <summary>
        /// Returns false as BuildingsAccidentalCover should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeBuildingsAccidentalCover()
        {
            return _flagBuildingsAccidentalCover;
        }
        /// <summary>
        /// Excess payable for Buildings cover.
        /// </summary>
        /// <value>Excess payable for Buildings cover.</value>
        [DataMember(Name = "BuildingsExcess", EmitDefaultValue = true)]
        public double? BuildingsExcess
        {
            get{ return _BuildingsExcess;}
            set
            {
                _BuildingsExcess = value;
                _flagBuildingsExcess = true;
            }
        }
        private double? _BuildingsExcess;
        private bool _flagBuildingsExcess;

        /// <summary>
        /// Returns false as BuildingsExcess should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeBuildingsExcess()
        {
            return _flagBuildingsExcess;
        }
        /// <summary>
        /// No claims discount for Buildings cover.
        /// </summary>
        /// <value>No claims discount for Buildings cover.</value>
        [DataMember(Name = "BuildingsNoClaimYears", EmitDefaultValue = true)]
        public int? BuildingsNoClaimYears
        {
            get{ return _BuildingsNoClaimYears;}
            set
            {
                _BuildingsNoClaimYears = value;
                _flagBuildingsNoClaimYears = true;
            }
        }
        private int? _BuildingsNoClaimYears;
        private bool _flagBuildingsNoClaimYears;

        /// <summary>
        /// Returns false as BuildingsNoClaimYears should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeBuildingsNoClaimYears()
        {
            return _flagBuildingsNoClaimYears;
        }
        /// <summary>
        /// Contents cover limit.
        /// </summary>
        /// <value>Contents cover limit.</value>
        [DataMember(Name = "ContentsCoverAmount", EmitDefaultValue = true)]
        public double? ContentsCoverAmount
        {
            get{ return _ContentsCoverAmount;}
            set
            {
                _ContentsCoverAmount = value;
                _flagContentsCoverAmount = true;
            }
        }
        private double? _ContentsCoverAmount;
        private bool _flagContentsCoverAmount;

        /// <summary>
        /// Returns false as ContentsCoverAmount should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeContentsCoverAmount()
        {
            return _flagContentsCoverAmount;
        }
        /// <summary>
        /// Is Accidental damage for Contents cover included?
        /// </summary>
        /// <value>Is Accidental damage for Contents cover included?</value>
        [DataMember(Name = "ContentsAccidentalDamage", EmitDefaultValue = true)]
        public bool? ContentsAccidentalDamage
        {
            get{ return _ContentsAccidentalDamage;}
            set
            {
                _ContentsAccidentalDamage = value;
                _flagContentsAccidentalDamage = true;
            }
        }
        private bool? _ContentsAccidentalDamage;
        private bool _flagContentsAccidentalDamage;

        /// <summary>
        /// Returns false as ContentsAccidentalDamage should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeContentsAccidentalDamage()
        {
            return _flagContentsAccidentalDamage;
        }
        /// <summary>
        /// Excess payable for Contents cover.
        /// </summary>
        /// <value>Excess payable for Contents cover.</value>
        [DataMember(Name = "ContentsExcess", EmitDefaultValue = true)]
        public double? ContentsExcess
        {
            get{ return _ContentsExcess;}
            set
            {
                _ContentsExcess = value;
                _flagContentsExcess = true;
            }
        }
        private double? _ContentsExcess;
        private bool _flagContentsExcess;

        /// <summary>
        /// Returns false as ContentsExcess should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeContentsExcess()
        {
            return _flagContentsExcess;
        }
        /// <summary>
        /// No claims discount for Contents cover.
        /// </summary>
        /// <value>No claims discount for Contents cover.</value>
        [DataMember(Name = "ContentsNoClaimYears", EmitDefaultValue = true)]
        public int? ContentsNoClaimYears
        {
            get{ return _ContentsNoClaimYears;}
            set
            {
                _ContentsNoClaimYears = value;
                _flagContentsNoClaimYears = true;
            }
        }
        private int? _ContentsNoClaimYears;
        private bool _flagContentsNoClaimYears;

        /// <summary>
        /// Returns false as ContentsNoClaimYears should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeContentsNoClaimYears()
        {
            return _flagContentsNoClaimYears;
        }
        /// <summary>
        /// Total cover required for unspecified personal belongings
        /// </summary>
        /// <value>Total cover required for unspecified personal belongings</value>
        [DataMember(Name = "PersonalBelongingsCover", EmitDefaultValue = true)]
        public double? PersonalBelongingsCover
        {
            get{ return _PersonalBelongingsCover;}
            set
            {
                _PersonalBelongingsCover = value;
                _flagPersonalBelongingsCover = true;
            }
        }
        private double? _PersonalBelongingsCover;
        private bool _flagPersonalBelongingsCover;

        /// <summary>
        /// Returns false as PersonalBelongingsCover should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePersonalBelongingsCover()
        {
            return _flagPersonalBelongingsCover;
        }
        /// <summary>
        /// No claims discount for Buildings cover.
        /// </summary>
        /// <value>No claims discount for Buildings cover.</value>
        [DataMember(Name = "BuildingsNcdCurrentPolicy", EmitDefaultValue = true)]
        public int? BuildingsNcdCurrentPolicy
        {
            get{ return _BuildingsNcdCurrentPolicy;}
            set
            {
                _BuildingsNcdCurrentPolicy = value;
                _flagBuildingsNcdCurrentPolicy = true;
            }
        }
        private int? _BuildingsNcdCurrentPolicy;
        private bool _flagBuildingsNcdCurrentPolicy;

        /// <summary>
        /// Returns false as BuildingsNcdCurrentPolicy should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeBuildingsNcdCurrentPolicy()
        {
            return _flagBuildingsNcdCurrentPolicy;
        }
        /// <summary>
        /// No claims discount for Buildings cover upon next renewal.
        /// </summary>
        /// <value>No claims discount for Buildings cover upon next renewal.</value>
        [DataMember(Name = "BuildingsNcdNextRenewal", EmitDefaultValue = true)]
        public int? BuildingsNcdNextRenewal
        {
            get{ return _BuildingsNcdNextRenewal;}
            set
            {
                _BuildingsNcdNextRenewal = value;
                _flagBuildingsNcdNextRenewal = true;
            }
        }
        private int? _BuildingsNcdNextRenewal;
        private bool _flagBuildingsNcdNextRenewal;

        /// <summary>
        /// Returns false as BuildingsNcdNextRenewal should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeBuildingsNcdNextRenewal()
        {
            return _flagBuildingsNcdNextRenewal;
        }
        /// <summary>
        /// No claims discount for Buildings cover.
        /// </summary>
        /// <value>No claims discount for Buildings cover.</value>
        [DataMember(Name = "BuildingsUinsureCurrentClaimFreeTenure", EmitDefaultValue = true)]
        public int? BuildingsUinsureCurrentClaimFreeTenure
        {
            get{ return _BuildingsUinsureCurrentClaimFreeTenure;}
            set
            {
                _BuildingsUinsureCurrentClaimFreeTenure = value;
                _flagBuildingsUinsureCurrentClaimFreeTenure = true;
            }
        }
        private int? _BuildingsUinsureCurrentClaimFreeTenure;
        private bool _flagBuildingsUinsureCurrentClaimFreeTenure;

        /// <summary>
        /// Returns false as BuildingsUinsureCurrentClaimFreeTenure should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeBuildingsUinsureCurrentClaimFreeTenure()
        {
            return _flagBuildingsUinsureCurrentClaimFreeTenure;
        }
        /// <summary>
        /// No claims discount for Contents cover.
        /// </summary>
        /// <value>No claims discount for Contents cover.</value>
        [DataMember(Name = "ContentsNcdCurrentPolicy", EmitDefaultValue = true)]
        public int? ContentsNcdCurrentPolicy
        {
            get{ return _ContentsNcdCurrentPolicy;}
            set
            {
                _ContentsNcdCurrentPolicy = value;
                _flagContentsNcdCurrentPolicy = true;
            }
        }
        private int? _ContentsNcdCurrentPolicy;
        private bool _flagContentsNcdCurrentPolicy;

        /// <summary>
        /// Returns false as ContentsNcdCurrentPolicy should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeContentsNcdCurrentPolicy()
        {
            return _flagContentsNcdCurrentPolicy;
        }
        /// <summary>
        /// No claims discount for Contents cover upon next renewal.
        /// </summary>
        /// <value>No claims discount for Contents cover upon next renewal.</value>
        [DataMember(Name = "ContentsNcdNextRenewal", EmitDefaultValue = true)]
        public int? ContentsNcdNextRenewal
        {
            get{ return _ContentsNcdNextRenewal;}
            set
            {
                _ContentsNcdNextRenewal = value;
                _flagContentsNcdNextRenewal = true;
            }
        }
        private int? _ContentsNcdNextRenewal;
        private bool _flagContentsNcdNextRenewal;

        /// <summary>
        /// Returns false as ContentsNcdNextRenewal should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeContentsNcdNextRenewal()
        {
            return _flagContentsNcdNextRenewal;
        }
        /// <summary>
        /// No claims discount for Contents cover.
        /// </summary>
        /// <value>No claims discount for Contents cover.</value>
        [DataMember(Name = "ContentsUinsureCurrentClaimFreeTenure", EmitDefaultValue = true)]
        public int? ContentsUinsureCurrentClaimFreeTenure
        {
            get{ return _ContentsUinsureCurrentClaimFreeTenure;}
            set
            {
                _ContentsUinsureCurrentClaimFreeTenure = value;
                _flagContentsUinsureCurrentClaimFreeTenure = true;
            }
        }
        private int? _ContentsUinsureCurrentClaimFreeTenure;
        private bool _flagContentsUinsureCurrentClaimFreeTenure;

        /// <summary>
        /// Returns false as ContentsUinsureCurrentClaimFreeTenure should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeContentsUinsureCurrentClaimFreeTenure()
        {
            return _flagContentsUinsureCurrentClaimFreeTenure;
        }
        /// <summary>
        /// Is this customer eligible for rebroke?
        /// </summary>
        /// <value>Is this customer eligible for rebroke?</value>
        [DataMember(Name = "EligibleForRebroke", EmitDefaultValue = true)]
        public bool? EligibleForRebroke
        {
            get{ return _EligibleForRebroke;}
            set
            {
                _EligibleForRebroke = value;
                _flagEligibleForRebroke = true;
            }
        }
        private bool? _EligibleForRebroke;
        private bool _flagEligibleForRebroke;

        /// <summary>
        /// Returns false as EligibleForRebroke should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeEligibleForRebroke()
        {
            return _flagEligibleForRebroke;
        }
        /// <summary>
        /// Original inception date of policy.
        /// </summary>
        /// <value>Original inception date of policy.</value>
        [DataMember(Name = "OriginalInceptionDate", EmitDefaultValue = true)]
        public DateTime? OriginalInceptionDate
        {
            get{ return _OriginalInceptionDate;}
            set
            {
                _OriginalInceptionDate = value;
                _flagOriginalInceptionDate = true;
            }
        }
        private DateTime? _OriginalInceptionDate;
        private bool _flagOriginalInceptionDate;

        /// <summary>
        /// Returns false as OriginalInceptionDate should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeOriginalInceptionDate()
        {
            return _flagOriginalInceptionDate;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PolicyCover {\n");
            sb.Append("  IsFirstTimeBuyer: ").Append(IsFirstTimeBuyer).Append("\n");
            sb.Append("  BuildingsCoverAmount: ").Append(BuildingsCoverAmount).Append("\n");
            sb.Append("  BuildingsAccidentalCover: ").Append(BuildingsAccidentalCover).Append("\n");
            sb.Append("  BuildingsExcess: ").Append(BuildingsExcess).Append("\n");
            sb.Append("  BuildingsNoClaimYears: ").Append(BuildingsNoClaimYears).Append("\n");
            sb.Append("  ContentsCoverAmount: ").Append(ContentsCoverAmount).Append("\n");
            sb.Append("  ContentsAccidentalDamage: ").Append(ContentsAccidentalDamage).Append("\n");
            sb.Append("  ContentsExcess: ").Append(ContentsExcess).Append("\n");
            sb.Append("  ContentsNoClaimYears: ").Append(ContentsNoClaimYears).Append("\n");
            sb.Append("  PersonalBelongingsCover: ").Append(PersonalBelongingsCover).Append("\n");
            sb.Append("  BuildingsNcdCurrentPolicy: ").Append(BuildingsNcdCurrentPolicy).Append("\n");
            sb.Append("  BuildingsNcdNextRenewal: ").Append(BuildingsNcdNextRenewal).Append("\n");
            sb.Append("  BuildingsUinsureCurrentClaimFreeTenure: ").Append(BuildingsUinsureCurrentClaimFreeTenure).Append("\n");
            sb.Append("  ContentsNcdCurrentPolicy: ").Append(ContentsNcdCurrentPolicy).Append("\n");
            sb.Append("  ContentsNcdNextRenewal: ").Append(ContentsNcdNextRenewal).Append("\n");
            sb.Append("  ContentsUinsureCurrentClaimFreeTenure: ").Append(ContentsUinsureCurrentClaimFreeTenure).Append("\n");
            sb.Append("  EligibleForRebroke: ").Append(EligibleForRebroke).Append("\n");
            sb.Append("  OriginalInceptionDate: ").Append(OriginalInceptionDate).Append("\n");
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
            return this.Equals(input as PolicyCover);
        }

        /// <summary>
        /// Returns true if PolicyCover instances are equal
        /// </summary>
        /// <param name="input">Instance of PolicyCover to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PolicyCover input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.IsFirstTimeBuyer == input.IsFirstTimeBuyer ||
                    (this.IsFirstTimeBuyer != null &&
                    this.IsFirstTimeBuyer.Equals(input.IsFirstTimeBuyer))
                ) && 
                (
                    this.BuildingsCoverAmount == input.BuildingsCoverAmount ||
                    (this.BuildingsCoverAmount != null &&
                    this.BuildingsCoverAmount.Equals(input.BuildingsCoverAmount))
                ) && 
                (
                    this.BuildingsAccidentalCover == input.BuildingsAccidentalCover ||
                    (this.BuildingsAccidentalCover != null &&
                    this.BuildingsAccidentalCover.Equals(input.BuildingsAccidentalCover))
                ) && 
                (
                    this.BuildingsExcess == input.BuildingsExcess ||
                    (this.BuildingsExcess != null &&
                    this.BuildingsExcess.Equals(input.BuildingsExcess))
                ) && 
                (
                    this.BuildingsNoClaimYears == input.BuildingsNoClaimYears ||
                    (this.BuildingsNoClaimYears != null &&
                    this.BuildingsNoClaimYears.Equals(input.BuildingsNoClaimYears))
                ) && 
                (
                    this.ContentsCoverAmount == input.ContentsCoverAmount ||
                    (this.ContentsCoverAmount != null &&
                    this.ContentsCoverAmount.Equals(input.ContentsCoverAmount))
                ) && 
                (
                    this.ContentsAccidentalDamage == input.ContentsAccidentalDamage ||
                    (this.ContentsAccidentalDamage != null &&
                    this.ContentsAccidentalDamage.Equals(input.ContentsAccidentalDamage))
                ) && 
                (
                    this.ContentsExcess == input.ContentsExcess ||
                    (this.ContentsExcess != null &&
                    this.ContentsExcess.Equals(input.ContentsExcess))
                ) && 
                (
                    this.ContentsNoClaimYears == input.ContentsNoClaimYears ||
                    (this.ContentsNoClaimYears != null &&
                    this.ContentsNoClaimYears.Equals(input.ContentsNoClaimYears))
                ) && 
                (
                    this.PersonalBelongingsCover == input.PersonalBelongingsCover ||
                    (this.PersonalBelongingsCover != null &&
                    this.PersonalBelongingsCover.Equals(input.PersonalBelongingsCover))
                ) && 
                (
                    this.BuildingsNcdCurrentPolicy == input.BuildingsNcdCurrentPolicy ||
                    (this.BuildingsNcdCurrentPolicy != null &&
                    this.BuildingsNcdCurrentPolicy.Equals(input.BuildingsNcdCurrentPolicy))
                ) && 
                (
                    this.BuildingsNcdNextRenewal == input.BuildingsNcdNextRenewal ||
                    (this.BuildingsNcdNextRenewal != null &&
                    this.BuildingsNcdNextRenewal.Equals(input.BuildingsNcdNextRenewal))
                ) && 
                (
                    this.BuildingsUinsureCurrentClaimFreeTenure == input.BuildingsUinsureCurrentClaimFreeTenure ||
                    (this.BuildingsUinsureCurrentClaimFreeTenure != null &&
                    this.BuildingsUinsureCurrentClaimFreeTenure.Equals(input.BuildingsUinsureCurrentClaimFreeTenure))
                ) && 
                (
                    this.ContentsNcdCurrentPolicy == input.ContentsNcdCurrentPolicy ||
                    (this.ContentsNcdCurrentPolicy != null &&
                    this.ContentsNcdCurrentPolicy.Equals(input.ContentsNcdCurrentPolicy))
                ) && 
                (
                    this.ContentsNcdNextRenewal == input.ContentsNcdNextRenewal ||
                    (this.ContentsNcdNextRenewal != null &&
                    this.ContentsNcdNextRenewal.Equals(input.ContentsNcdNextRenewal))
                ) && 
                (
                    this.ContentsUinsureCurrentClaimFreeTenure == input.ContentsUinsureCurrentClaimFreeTenure ||
                    (this.ContentsUinsureCurrentClaimFreeTenure != null &&
                    this.ContentsUinsureCurrentClaimFreeTenure.Equals(input.ContentsUinsureCurrentClaimFreeTenure))
                ) && 
                (
                    this.EligibleForRebroke == input.EligibleForRebroke ||
                    (this.EligibleForRebroke != null &&
                    this.EligibleForRebroke.Equals(input.EligibleForRebroke))
                ) && 
                (
                    this.OriginalInceptionDate == input.OriginalInceptionDate ||
                    (this.OriginalInceptionDate != null &&
                    this.OriginalInceptionDate.Equals(input.OriginalInceptionDate))
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
                if (this.IsFirstTimeBuyer != null)
                {
                    hashCode = (hashCode * 59) + this.IsFirstTimeBuyer.GetHashCode();
                }
                if (this.BuildingsCoverAmount != null)
                {
                    hashCode = (hashCode * 59) + this.BuildingsCoverAmount.GetHashCode();
                }
                if (this.BuildingsAccidentalCover != null)
                {
                    hashCode = (hashCode * 59) + this.BuildingsAccidentalCover.GetHashCode();
                }
                if (this.BuildingsExcess != null)
                {
                    hashCode = (hashCode * 59) + this.BuildingsExcess.GetHashCode();
                }
                if (this.BuildingsNoClaimYears != null)
                {
                    hashCode = (hashCode * 59) + this.BuildingsNoClaimYears.GetHashCode();
                }
                if (this.ContentsCoverAmount != null)
                {
                    hashCode = (hashCode * 59) + this.ContentsCoverAmount.GetHashCode();
                }
                if (this.ContentsAccidentalDamage != null)
                {
                    hashCode = (hashCode * 59) + this.ContentsAccidentalDamage.GetHashCode();
                }
                if (this.ContentsExcess != null)
                {
                    hashCode = (hashCode * 59) + this.ContentsExcess.GetHashCode();
                }
                if (this.ContentsNoClaimYears != null)
                {
                    hashCode = (hashCode * 59) + this.ContentsNoClaimYears.GetHashCode();
                }
                if (this.PersonalBelongingsCover != null)
                {
                    hashCode = (hashCode * 59) + this.PersonalBelongingsCover.GetHashCode();
                }
                if (this.BuildingsNcdCurrentPolicy != null)
                {
                    hashCode = (hashCode * 59) + this.BuildingsNcdCurrentPolicy.GetHashCode();
                }
                if (this.BuildingsNcdNextRenewal != null)
                {
                    hashCode = (hashCode * 59) + this.BuildingsNcdNextRenewal.GetHashCode();
                }
                if (this.BuildingsUinsureCurrentClaimFreeTenure != null)
                {
                    hashCode = (hashCode * 59) + this.BuildingsUinsureCurrentClaimFreeTenure.GetHashCode();
                }
                if (this.ContentsNcdCurrentPolicy != null)
                {
                    hashCode = (hashCode * 59) + this.ContentsNcdCurrentPolicy.GetHashCode();
                }
                if (this.ContentsNcdNextRenewal != null)
                {
                    hashCode = (hashCode * 59) + this.ContentsNcdNextRenewal.GetHashCode();
                }
                if (this.ContentsUinsureCurrentClaimFreeTenure != null)
                {
                    hashCode = (hashCode * 59) + this.ContentsUinsureCurrentClaimFreeTenure.GetHashCode();
                }
                if (this.EligibleForRebroke != null)
                {
                    hashCode = (hashCode * 59) + this.EligibleForRebroke.GetHashCode();
                }
                if (this.OriginalInceptionDate != null)
                {
                    hashCode = (hashCode * 59) + this.OriginalInceptionDate.GetHashCode();
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
