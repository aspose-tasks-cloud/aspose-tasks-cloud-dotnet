using System;
using Aspose.Tasks.Cloud.Sdk;
using Aspose.Tasks.Cloud.Sdk.Model;
using Aspose.Tasks.Cloud.Sdk.Model.Requests;

namespace aspose.tasks.csharp
{
    class GetResourceAssignments : BaseContext
    {
        static void Main(string[] args)
        {
            var configuration = new Configuration { AppKey = BaseContext.AppKey, AppSid = BaseContext.AppSid };
            TasksApi api = new TasksApi(configuration);

            var response = api.GetResourceAssignments(new GetResourceAssignmentsRequest
            {
                ResourceUid = 1,
                Name = "NewProductDev.mpp",
                Folder = ""
            });

            Console.WriteLine(response.Code);
        }
    }
}
