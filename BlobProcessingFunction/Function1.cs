using System;
using System.IO;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace BlobProcessingFunction
{
    public class Function1
    {
        [FunctionName("Function1")]
        public void Run([BlobTrigger("anishstorage78692/{name}", Connection = "connectionString")]Stream myBlob, string name, ILogger log)
        {
            StreamReader streamReader = new StreamReader(myBlob);
            string blob = streamReader.ReadToEnd();
            log.LogInformation(blob);
        }
    }
}
