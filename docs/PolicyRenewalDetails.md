# Uinsure.CustomerPortal.Client.Model.PolicyRenewalDetails
DTO with details relating to this policy's renewal.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FirstBounceDateTime** | **DateTime?** | Timestamp if the renewal pack email bounced. | [optional] 
**LastYearsMonthlyPremium** | **double?** | Monthly premium of last year&#39;s renewal. | [optional] 
**LastYearsPremium** | **double?** | Total amount payable of last year&#39;s premium. | [optional] 
**LastYearsPremiumWithoutPf** | **double?** | Total amount payable of last year&#39;s premium with premium finance. | [optional] 
**PackNotSentDateTime** | **DateTime?** | Timestamp for when a renewal pack failed to be delivered by email. | [optional] 
**PackSentDateTime** | **DateTime?** | Timestamp for when a renewal pack email delivery was attempted. | [optional] 
**PackSentEmailAddress** | **string** | Email address that a renewal pack delivery attempt was sent to. | [optional] 
**RenewalInceptionDate** | **DateTime?** | Renewal inception date. | [optional] 
**UpcomingRenewalInceptionDate** | **DateTime?** | Upcoming renewal inception date. | [optional] 
**UpcomingRenewalPolicyNumber** | **string** | Policy number for the upcoming renewal. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

