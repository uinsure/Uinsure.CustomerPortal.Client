# Uinsure.CustomerPortal.Client.Model.Policyholder
DTO with details relating to a policy and policyholder.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Applicant1Title** | **string** | Applicant 1 title. | [optional] 
**Applicant1FirstName** | **string** | Applicant 1 first name. | [optional] 
**Applicant1LastName** | **string** | Applicant 1 last name. | [optional] 
**Applicant1DateOfBirth** | **DateTime?** | Applicant 1 date of birth. | [optional] 
**Applicant1Deceased** | **bool?** | Is applicant 1 deceased? | [optional] 
**Applicant2Title** | **string** | Applicant 2 title. | [optional] 
**Applicant2FirstName** | **string** | Applicant 2 first name. | [optional] 
**Applicant2LastName** | **string** | Applicant 2 last name, | [optional] 
**Applicant2DateOfBirth** | **DateTime?** | Applicant 2 date of birth. | [optional] 
**EmailAddress** | **string** | Customer email address. | [optional] 
**TelephoneNumber** | **string** | Customer telephone number. | [optional] 
**TelephoneNumberType** | **string** | Type of contact number. | [optional] 
**CorrespondenceAddressLine1** | **string** | Correspondence address line 1. | [optional] 
**CorrespondenceAddressLine2** | **string** | Correspondence address line 2. | [optional] 
**CorrespondenceAddressLine3** | **string** | Correspondence address line 3. | [optional] 
**CorrespondencePostcode** | **string** | Correspondence address postcode. | [optional] 
**DoNotAutoRenew** | **bool?** | Will the policy auto-renew? | [optional] 
**PolicyDocument** | **string** | Is this customer receiving policy documents by post or digitally? | [optional] 
**CorrespondenceRiskAddressMatch** | **bool?** | Is the correspondence address the same as the risk address? | [optional] 
**IsRiskAddressDifferent** | **bool** | Returns true if the values of Risk address differ from those in Correspondence address (sans address line 4). | [optional] [readonly] 
**CustomerVulnerabilities** | **List&lt;string&gt;** | Collection containing any customer vulnerabilities. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

