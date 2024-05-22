# clipapisdk.Model.LightPutTimedEffects
Basic feature containing timed effect properties.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Effect** | **SupportedTimedEffects** |  | [optional] 
**Duration** | **int** | Duration is mandatory when timed effect is set except for no_effect. Resolution decreases for a larger duration. e.g Effects with duration smaller than a minute will be rounded to a resolution of 1s, while effects with duration larger than an hour will be arounded up to a resolution of 300s. Duration has a max of 21600000 ms. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

