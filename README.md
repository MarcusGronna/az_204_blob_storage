# azstor

A learning project for the **AZ-204: Developing Solutions for Microsoft Azure** certification.  
This console app demonstrates how to work with **Azure Blob Storage** using the Azure SDK for .NET.

## What It Covers

- Connecting to Azure Blob Storage using `BlobServiceClient`
- Authenticating with `DefaultAzureCredential` (no hardcoded secrets)
- Managing credentials securely with .NET User Secrets
- Creating blob containers
- Uploading files to Blob Storage
- Listing blobs in a container
- Downloading blobs to local files

## Tech Stack

| | |
|---|---|
| **Runtime** | .NET 10 |
| **Language** | C# |
| **Azure SDK** | Azure.Storage.Blobs 12.28.0 |
| **Auth** | Azure.Identity 1.21.0 |
| **Config** | Microsoft.Extensions.Configuration 10.0.8 |
| **Secrets** | Microsoft.Extensions.Configuration.UserSecrets 10.0.8 |

## Prerequisites

- [.NET 10 SDK](https://dotnet.microsoft.com/download)
- An **Azure Storage Account**
- [Azure CLI](https://learn.microsoft.com/en-us/cli/azure/install-azure-cli) logged in, **or** Visual Studio signed in with an Azure account

## Setup

### 1. Clone the repo

```
git clone https://github.com/MarcusGronna/az_204_blob_storage.git
cd az_204_blob_storage/azstor
```

### 2. Configure User Secrets

This project uses [.NET User Secrets](https://learn.microsoft.com/en-us/aspnet/core/security/app-secrets) to keep your storage account name out of source control.

```
dotnet user-secrets set "YOUR_ACCOUNT_NAME" "<your-storage-account-name>"
```

> ⚠️ Never hardcode your storage account name or keys in `Program.cs` or any tracked file.

### 3. Authenticate with Azure

Log in via the Azure CLI:

```
az login
```

Or ensure you are signed in to the same Azure account in Visual Studio.

### 4. Run the app

```
dotnet run
```

## Security Notes

- Authentication uses `DefaultAzureCredential` with `ExcludeEnvironmentCredential` and `ExcludeManagedIdentityCredential` set to `true` — optimized for local development.
- All sensitive values are stored in .NET User Secrets, which live outside the project folder and are never committed to Git.

## Related Resources

- [Azure Blob Storage documentation](https://learn.microsoft.com/en-us/azure/storage/blobs/)
- [Azure SDK for .NET](https://learn.microsoft.com/en-us/dotnet/azure/sdk/azure-sdk-for-dotnet)
- [AZ-204 Exam overview](https://learn.microsoft.com/en-us/credentials/certifications/exams/az-204/)
