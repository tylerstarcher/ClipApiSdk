# clipapisdk.Model.RoomGet

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Type of the supported resources | [optional] 
**Id** | **string** | Unique identifier representing a specific resource instance | [optional] 
**IdV1** | **string** | Clip v1 resource identifier | [optional] 
**Children** | [**List&lt;ResourceIdentifier&gt;**](ResourceIdentifier.md) | Child devices/services to group by the derived group | [optional] 
**Services** | [**List&lt;ResourceIdentifier&gt;**](ResourceIdentifier.md) | References all services aggregating control and state of children in the group. This includes all services grouped in the group hierarchy given by child relation. This includes all services of a device grouped in the group hierarchy given by child relation. Aggregation is per service type, ie every service type which can be grouped has a corresponding definition of grouped type. Supported types: – grouped_light  | [optional] 
**Metadata** | [**RoomGetAllOfMetadata**](RoomGetAllOfMetadata.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

