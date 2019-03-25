using System;
using Aspose.Tasks.Cloud.Sdk;
using Aspose.Tasks.Cloud.Sdk.Model;
using Aspose.Tasks.Cloud.Sdk.Model.Requests;
using Newtonsoft.Json.Linq;

namespace aspose.tasks.csharp
{
    class PutRecalculateProjectResourceFieldsExample : BaseContext
    {
        static void Main(string[] args)
        {
            var configuration = new Configuration { AppKey = BaseContext.AppKey, AppSid = BaseContext.AppSid };
            TasksApi api = new TasksApi(configuration);

            var response = api.PutRecalculateProjectResourceFields(new PutRecalculateProjectResourceFieldsRequest
            {
                Name = "Home move plan.mpp",
                Folder = "",
            });
            Console.WriteLine(response);
        }
    }
}