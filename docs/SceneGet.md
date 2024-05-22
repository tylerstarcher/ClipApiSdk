# clipapisdk.Model.SceneGet

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** |  | [optional] 
**Id** | **string** | Unique identifier representing a specific resource instance | [optional] 
**IdV1** | **string** | Clip v1 resource identifier | [optional] 
**Owner** | [**ResourceIdentifier**](ResourceIdentifier.md) |  | [optional] 
**Actions** | [**List&lt;ActionGet&gt;**](ActionGet.md) | List of actions to be executed synchronously on recall | [optional] 
**Metadata** | [**SceneMetadata**](SceneMetadata.md) |  | [optional] 
**Group** | [**ResourceIdentifier**](ResourceIdentifier.md) |  | [optional] 
**Palette** | [**ScenePalette**](ScenePalette.md) |  | [optional] 
**Speed** | **decimal** | Speed of dynamic palette for this scene | [optional] 
**AutoDynamic** | **bool** | Indicates whether to automatically start the scene dynamically on active recall | [optional] 
**Status** | [**SceneGetAllOfStatus**](SceneGetAllOfStatus.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

