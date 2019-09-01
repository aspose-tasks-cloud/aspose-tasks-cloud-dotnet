using System;
using Aspose.Tasks.Cloud.Sdk;
using Aspose.Tasks.Cloud.Sdk.Model;
using Aspose.Tasks.Cloud.Sdk.Model.Requests;
using Newtonsoft.Json.Linq;

namespace aspose.tasks.csharp
{
    class GetResourcesExample : BaseContext
    {
        public void run()
        {
            var configuration = new Configuration { AppKey = BaseContext.AppKey, AppSid = BaseContext.AppSid };
            TasksApi api = new TasksApi(configuration);
            var resourceResponse = api.GetResources(new GetResourcesRequest
            {
                Name = "Home move plan.mpp",
                Storage = "Tasks",
                Folder = ""
            });
            Console.WriteLine(resourceResponse);
        }
    }
}