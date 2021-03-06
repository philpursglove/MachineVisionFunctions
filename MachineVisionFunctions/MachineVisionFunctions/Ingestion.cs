using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using System.IO;

namespace MachineVisionFunctions
{
    public static class Ingestion
    {
        [FunctionName("Ingestion")]
        public static void Run([BlobTrigger("images/{name}", Connection = "StorageAccountConnectionString")]Stream myBlob, 
            string name, ILogger log)
        {
            log.LogInformation($"C# Blob trigger function Processed blob\n Name:{name} \n Size: {myBlob.Length} Bytes");
        }
    }
}
