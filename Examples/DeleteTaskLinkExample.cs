using System;
using Aspose.Tasks.Cloud.Sdk;
using Aspose.Tasks.Cloud.Sdk.Model;
using Aspose.Tasks.Cloud.Sdk.Model.Requests;
using Newtonsoft.Json.Linq;

namespace aspose.tasks.csharp
{
    class DeleteTaskLinkExample : BaseContext
    {
        public void run()
        {
            var configuration = new Configuration { AppKey = BaseContext.AppKey, AppSid = BaseContext.AppSid };
            TasksApi api = new TasksApi(configuration);


            var deleteResponse = api.DeleteTaskLink(new DeleteTaskLinkRequest()
            {
                Index = 1,
                Name = "NewProductDev.mpp",
                Folder = "",
                Storage = "Tasks"
            });

            Console.WriteLine(deleteResponse);
        }
    }
}