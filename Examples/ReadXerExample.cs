using System;
using Aspose.Tasks.Cloud.Sdk;
using Aspose.Tasks.Cloud.Sdk.Model;
using Aspose.Tasks.Cloud.Sdk.Model.Requests;

namespace aspose.tasks.csharp
{
    class ReadXerExample : BaseContext
    {
        static void Main(string[] args)
        {
            var configuration = new Configuration { AppKey = BaseContext.AppKey, AppSid = BaseContext.AppSid };
            TasksApi api = new TasksApi(configuration);
            var response = api.GetTaskDocument(new GetTaskDocumentRequest
            {
                Name = "p6_multiproject.xml",
                Folder =""
            });
            Console.WriteLine(response);
        }
    }
}