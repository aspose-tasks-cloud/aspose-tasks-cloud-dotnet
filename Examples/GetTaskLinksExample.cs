using System;
using Aspose.Tasks.Cloud.Sdk;
using Aspose.Tasks.Cloud.Sdk.Model;
using Aspose.Tasks.Cloud.Sdk.Model.Requests;
using Newtonsoft.Json.Linq;

namespace aspose.tasks.csharp
{
    class GetTaskLinksExample : BaseContext
    {
        static void Main(string[] args)
        {
            var configuration = new Configuration { AppKey = BaseContext.AppKey, AppSid = BaseContext.AppSid };
            TasksApi api = new TasksApi(configuration);


           var response = api.GetTaskLinks(new GetTaskLinksRequest()
            {
                Name = "NewProductDev.mpp",
                Folder = "",
                Storage = "Tasks"
            });
            Console.WriteLine(response);
        }
    }
}