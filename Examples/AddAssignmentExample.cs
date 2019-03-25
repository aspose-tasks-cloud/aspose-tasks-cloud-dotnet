using System;
using Aspose.Tasks.Cloud.Sdk;
using Aspose.Tasks.Cloud.Sdk.Model;
using Aspose.Tasks.Cloud.Sdk.Model.Requests;

namespace aspose.tasks.csharp
{
    class AddAssignment : BaseContext
    {
        static void Main(string[] args)
        {
            var configuration = new Configuration { AppKey = BaseContext.AppKey, AppSid = BaseContext.AppSid };
            TasksApi api = new TasksApi(configuration);


            var response = api.PostAssignment(new PostAssignmentRequest
            {
                ResourceUid = 1,
                Units = 0.5D,
                TaskUid = 0,
                Name = "NewProductDev.mpp",
                Folder = ""
            });

            Console.WriteLine(response.Code);
        }
    }
}
