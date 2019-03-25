using System;
using Aspose.Tasks.Cloud.Sdk;
using Aspose.Tasks.Cloud.Sdk.Model;
using Aspose.Tasks.Cloud.Sdk.Model.Requests;
using Newtonsoft.Json.Linq;

namespace aspose.tasks.csharp
{
    class GetTaskRecurringInfoExample : BaseContext
    {
        static void Main(string[] args)
        {
            var configuration = new Configuration { AppKey = BaseContext.AppKey, AppSid = BaseContext.AppSid };
            TasksApi api = new TasksApi(configuration);
            var response = api.GetTaskRecurringInfo(new GetTaskRecurringInfoRequest
            {
                Name = "sample.mpp",
                Storage = "Tasks",
                Folder = "",
                TaskUid = 6
            });

            Console.WriteLine(response);
        }
    }
}