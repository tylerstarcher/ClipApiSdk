# clipapisdk.Model.DeviceGet
Definition of a device resource

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** |  | [optional] 
**Id** | **string** | Unique identifier representing a specific resource instance | [optional] 
**IdV1** | **string** | Clip v1 resource identifier | [optional] 
**Owner** | [**ResourceIdentifier**](ResourceIdentifier.md) |  | [optional] 
**ProductData** | [**ProductData**](ProductData.md) |  | [optional] 
**Metadata** | [**DeviceGetAllOfMetadata**](DeviceGetAllOfMetadata.md) |  | [optional] 
**Usertest** | [**DeviceGetAllOfUsertest**](DeviceGetAllOfUsertest.md) |  | [optional] 
**Services** | [**List&lt;ResourceIdentifier&gt;**](ResourceIdentifier.md) | References all services providing control and state of the device. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

