# azure-csharp-provider-update
A repo to investigate updating provider versions in csharp

## Test sequence
* `azure-test.csproj` should have the `PackageReference` set up as follows:
  * `<PackageReference Include="Pulumi.AzureNative" Version="1.66.0" />`
  * `<PackageReference Include="Pulumi.Azure" Version="4.41.1" />`
* `pulumi up -y`
  * packages will be installed if needed and stack will be deployed.
* Stack is deployed and `pulumi stack` shows the providers are using the versions given above.
* Modify `azure-test.csproj` to use the following packages:
  * `<PackageReference Include="Pulumi.AzureNative" Version="2.38.0" />`
  * `<PackageReference Include="Pulumi.Azure" Version="5.73.0" />` 
* `pulumi up -y`
  * If needed packages and plugins for the new versions of the provider are installed
  * The update will indicate `unchanged` but the providers are being updated to the latest version.
* `pulumi stack` shows providers are now using the new versions.
