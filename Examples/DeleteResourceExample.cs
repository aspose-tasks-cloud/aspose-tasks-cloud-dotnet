using System;
using Aspose.Tasks.Cloud.Sdk;
using Aspose.Tasks.Cloud.Sdk.Model;
using Aspose.Tasks.Cloud.Sdk.Model.Requests;
using Newtonsoft.Json.Linq;

namespace aspose.tasks.csharp
{
    class DeleteResourceExample : BaseContext
    {
         public void run()
        {
            var configuration = new Configuration { AppKey = BaseContext.AppKey, AppSid = BaseContext.AppSid };
            TasksApi api = new TasksApi(configuration);


            var deleteResponse = api.DeleteResource(new DeleteResourceRequest
            {
                Name = "Home move plan.mpp",
                Storage = "Tasks",
                Folder = "",
                ResourceUid = 0
            });
            Console.WriteLine(deleteResponse);
        }
    }
}