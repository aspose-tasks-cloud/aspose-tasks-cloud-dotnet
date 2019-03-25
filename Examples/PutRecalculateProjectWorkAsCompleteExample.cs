using System;
using Aspose.Tasks.Cloud.Sdk;
using Aspose.Tasks.Cloud.Sdk.Model;
using Aspose.Tasks.Cloud.Sdk.Model.Requests;
using Newtonsoft.Json.Linq;

namespace aspose.tasks.csharp
{
    class PutRecalculateProjectWorkAsCompleteExample : BaseContext
    {
        static void Main(string[] args)
        {
            var configuration = new Configuration { AppKey = BaseContext.AppKey, AppSid = BaseContext.AppSid };
            TasksApi api = new TasksApi(configuration);

            var response = api.PutRecalculateProjectWorkAsComplete(new PutRecalculateProjectWorkAsCompleteRequest
            {
                Name = "Home move plan.mpp",
                Folder = "",
                CompleteThrough = new DateTime(2010, 10, 10)
            });
            Console.WriteLine(response);
        }
    }
}