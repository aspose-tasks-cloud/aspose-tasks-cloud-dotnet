using System;
using Aspose.Tasks.Cloud.Sdk;
using Aspose.Tasks.Cloud.Sdk.Model;
using Aspose.Tasks.Cloud.Sdk.Model.Requests;

namespace aspose.tasks.csharp
{
    class GetWbsDefinitionExample : BaseContext
    {
        static void Main(string[] args)
        {
            var configuration = new Configuration { AppKey = BaseContext.AppKey, AppSid = BaseContext.AppSid };
            TasksApi api = new TasksApi(configuration);

            var response = api.GetWbsDefinition(new GetWbsDefinitionRequest()
            {
                Name = "WBSDefinition.mpp",
                Folder = ""
            });

            Console.WriteLine(response);
        }
    }
}
