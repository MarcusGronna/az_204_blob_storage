using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.UserSecrets;
using Azure.Identity;
using Azure.Storage.Blobs;

var config = new ConfigurationBuilder()
    .AddUserSecrets<Program>()
    .Build();

Console.WriteLine("Azure Blob Storage exercise\n");

// Create a DefaultAzureCredentialOptions object to configure the DefaultAzureCredentials
DefaultAzureCredentialOptions options = new()
{
    ExcludeEnvironmentCredential = true,
    ExcludeManagedIdentityCredential = true
};

// Run the wzamples azynchronosly, wait for the results before proceeding
await ProcessAsync();

Console.WriteLine("\nPress enter to exit the sample application.");
Console.ReadLine();

async Task ProcessAsync()
{
    // CREATE A BLOB STORAGE CLIENT

        // Create a credential using DefaultAzureCredential with configured options
    string accountName = config["YOUR_ACCOUNT_NAME"]!;

        // Use the DefaultAzureCredential with the options configured at the top of the program
    DefaultAzureCredential credential = new DefaultAzureCredential(options);

        // Create the BlobSerciveClient using the endpoint and DefaultAzureCredential
    string blobServiceEndpoint = $"https://{accountName}.blob.core.windows.net";
    BlobServiceClient blobServiceClient = new BlobServiceClient(new Uri(blobServiceEndpoint), credential);


    // CREATE A CONTAINER



    // CREATE A LOCAL FILE FOR UPLOAD TO BLOB STORAGE



    // UPLOAD THE FILE TO BLOB STORAGE



    // LIST BLOBS IN THE CONTAINER



    // DOWNLOAD THE BLOB TO A LOCAL FILE
}
