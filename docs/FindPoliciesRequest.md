# Uinsure.CustomerPortal.Client.Model.FindPoliciesRequest
Represents a request from for a search query for using to find policies

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AgreementNumber** | **string** | A full or partial agreement number or policy number. | [optional] 
**Surname** | **string** | A full or partial Surname corresponding to either applicant on a policy | [optional] 
**DateOfBirth** | **DateTime?** | A valid date in the ISO 8601 format corresponding to either applicant on a policy and must be in the past | [optional] 
**RiskAddressPostcode** | **string** | A full or partial postcode corresponding to the risk address on a policy | [optional] 
**PhoneNumber** | **string** | A full or partial phone number associated to a policy | [optional] 
**PolicyStatus** | **string** | A full match on the Policy status | [optional] 
**ShowPoliciesWithIssues** | **bool?** | Default returns policies with no issues but setting this flag to true will allow the result set to contain policies with issues as well | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

