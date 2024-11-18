using Pulumi;
// using Pulumi.AzureNative.Resources;
// using Pulumi.AzureNative.Storage;
// using Pulumi.AzureNative.Storage.Inputs;
using System.Collections.Generic;

return await Pulumi.Deployment.RunAsync(() =>
{
    // Create an Azure Resource Group
    var resourceGroup = new Pulumi.Azure.Core.ResourceGroup("az-native-rg");

    // Create an Azure resource (Storage Account)
    var storageAccount = new Pulumi.AzureNative.Storage.StorageAccount("sa", new Pulumi.AzureNative.Storage.StorageAccountArgs
    {
        ResourceGroupName = resourceGroup.Name,
        Sku = new Pulumi.AzureNative.Storage.Inputs.SkuArgs
        {
            Name = Pulumi.AzureNative.Storage.SkuName.Standard_LRS
        },
        Kind = Pulumi.AzureNative.Storage.Kind.StorageV2
    });

});