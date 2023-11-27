# Uinsure.CustomerPortal.Client.Model.ClaimsSummary
DTO containing summary of all claims details for an account

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InsurerClaimsNumber** | **string** | Contact number for the insurer | [optional] 
**LastBuildingsClaimDate** | **DateTime?** | Date of latest Buildings related claim | [optional] 
**LastContentsClaimDate** | **DateTime?** | Date of latest Contents related claim | [optional] 
**LastClaimDate** | **DateTime?** | Date of latest claim | [optional] 
**OpenClaims** | **int?** | Number of open claims against this account reference | [optional] 
**ClaimsLast3Years** | **int?** | Number of claims made in the last three years | [optional] 
**ClaimCostLast3Years** | **double?** | Total cost of claims made in the last three years | [optional] 
**FloodClaims** | **int?** | Number of claims made relating to Flooding | [optional] 
**SubsidenceClaims** | **int?** | Number of claims made relating to Subsidence | [optional] 
**History** | [**List&lt;Claim&gt;**](Claim.md) | A collection of claims made against policies relating to this account | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

