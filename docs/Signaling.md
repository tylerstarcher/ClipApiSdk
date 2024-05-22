# clipapisdk.Model.Signaling
Feature containing basic signaling properties.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Signal** | **string** | - &#x60;no_signal&#x60;: No signal is active. Write “no_signal” to stop active signal. - &#x60;on_off&#x60;: Toggles between max brightness and Off in fixed color. - &#x60;on_off_color&#x60;: Toggles between off and max brightness with color provided. - &#x60;alternating&#x60;: Alternates between 2 provided colors.  | [optional] 
**Duration** | **int** | Duration has a max of 65534000 ms and a stepsize of 1 second. Values inbetween steps will be rounded. Duration is ignored for &#x60;no_signal&#x60;.  | [optional] 
**Color** | [**List&lt;Color&gt;**](Color.md) | List of colors to apply to the signal (not supported by all signals) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

