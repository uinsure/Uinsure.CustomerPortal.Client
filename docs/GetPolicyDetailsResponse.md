# Uinsure.CustomerPortal.Client.Model.GetPolicyDetailsResponse
Contains details for a policy.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PolicyNumber** | **string** | Policy number. | [optional] 
**AccountReference** | **string** | Account reference for this policy. | [optional] 
**PolicyStartDate** | **DateTime?** | Policy start date. | [optional] 
**PolicyEndDate** | **DateTime?** | Policy end date. | [optional] 
**UnderwriterName** | **string** | Name of the underwriter for this policy. | [optional] 
**CoverTypeName** | **string** | Type of cover. | [optional] 
**ProductTypeName** | **string** | Product type. | [optional] 
**Provider** | **string** | Provider name. | [optional] 
**PossiblyRelatedPolicies** | **string** | The original pipe-delimited string of policy numbers possibly related by risk address. See Uinsure.CustomerPortal.API.Controllers.Admin.ResponseContracts.GetPolicyDetailsResponse.PolicyNumbersPossiblyRelatedByRiskAddress. | [optional] 
**PolicyNumbersPossiblyRelatedByRiskAddress** | **List&lt;string&gt;** | A collection of policy numbers that may be related to this policy. | [optional] 
**ConfirmedRelatedPolicies** | **string** | The original pipe-delimited string of policy numbers that is confirmed to be related by risk address. See Uinsure.CustomerPortal.API.Controllers.Admin.ResponseContracts.GetPolicyDetailsResponse.PolicyNumbersPossiblyRelatedByRiskAddress. | [optional] 
**PolicyNumbersConfirmedRelatedByRiskAddress** | **List&lt;string&gt;** | A collection of policy numbers that is confirmed to be related to this policy. | [optional] 
**PossiblyRelatedApplicant1** | **string** | The original pipe-delimited string of policy numbers possibly related by applicant 1. See Uinsure.CustomerPortal.API.Controllers.Admin.ResponseContracts.GetPolicyDetailsResponse.PolicyNumbersPossiblyRelatedByApplicant1. | [optional] 
**PolicyNumbersPossiblyRelatedByApplicant1** | **List&lt;string&gt;** | A collection of policy numbers where the policyholder may be related to this policy. | [optional] 
**ConfirmedRelatedApplicant1** | **string** | The original pipe-delimited string of policy numbers confirmed to be related by applicant 1. See Uinsure.CustomerPortal.API.Controllers.Admin.ResponseContracts.GetPolicyDetailsResponse.PolicyNumbersPossiblyRelatedByApplicant1. | [optional] 
**PolicyNumbersConfirmedRelatedByApplicant1** | **List&lt;string&gt;** | A collection of policy numbers where the policyholder is confirmed to be related to this policy. | [optional] 
**CompanyName** | **string** | BTL/Landlords - Company name of a Let property is insured in a company name. | [optional] 
**PolicyStatus** | **string** | Policy status. | [optional] 
**Policyholder** | [**Policyholder**](Policyholder.md) |  | [optional] 
**Policy** | [**PolicyCover**](PolicyCover.md) |  | [optional] 
**Property** | [**RiskProperty**](RiskProperty.md) |  | [optional] 
**Issues** | [**PolicyIssue**](PolicyIssue.md) |  | [optional] 
**Ancillaries** | [**Ancillaries**](Ancillaries.md) |  | [optional] 
**Broker** | [**BrokerDetails**](BrokerDetails.md) |  | [optional] 
**Renewal** | [**PolicyRenewalDetails**](PolicyRenewalDetails.md) |  | [optional] 
**Payments** | [**PaymentDetails**](PaymentDetails.md) |  | [optional] 
**SpecifiedItems** | [**List&lt;SpecifiedItem&gt;**](SpecifiedItem.md) | High-value specified items covered on this policy. | [optional] 
**Endorsements** | [**List&lt;Endorsement&gt;**](Endorsement.md) | Endorsements that apply to this policy. | [optional] 
**Claims** | [**ClaimsSummary**](ClaimsSummary.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

