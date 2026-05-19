using Azure.Identity;

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



    // CREATE A CONTAINER



    // CREATE A LOCAL FILE FOR UPLOAD TO BLOB STORAGE



    // UPLOAD THE FILE TO BLOB STORAGE



    // LIST BLOBS IN THE CONTAINER



    // DOWNLOAD THE BLOB TO A LOCAL FILE
}
