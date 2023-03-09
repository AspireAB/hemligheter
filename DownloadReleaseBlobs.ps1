[CmdletBinding()]
param(
	[Parameter(Mandatory=$True)]
	[string]$ReleaseFolder,
	[Parameter(Mandatory=$True)]
	[string]$StorageAccountName,
	[Parameter(Mandatory=$True)]
	[string]$StorageAccountKey,
	[Parameter(Mandatory=$True)]
	[string]$Container
	)

$storage_account = New-AzureStorageContext -StorageAccountName $StorageAccountName -StorageAccountKey $StorageAccountKey

Write-Host "Getting the release directory back from Azure blob storage"
$blobs = Get-AzureStorageBlob -Container $Container -Context $storage_account

New-Item -ItemType Directory -Force -Path $ReleaseFolder 
foreach ($blob in $blobs)
{
	Get-AzureStorageBlobContent `
        -Container $Container -Blob $blob.Name -Force -Destination $ReleaseFolder `
        -Context $storage_account
}