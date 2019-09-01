using System;
using Aspose.Tasks.Cloud.Sdk;
using Aspose.Tasks.Cloud.Sdk.Model;
using Aspose.Tasks.Cloud.Sdk.Model.Requests;

namespace aspose.tasks.csharp
{
    class AddAssignment : BaseContext
    {
        public void run()
        {
            var configuration = new Configuration { AppKey = BaseContext.AppKey, AppSid = BaseContext.AppSid };
            TasksApi api = new TasksApi(configuration);


            var response = api.PostAssignment(new PostAssignmentRequest
            {
                ResourceUid = 2,
                Units = 0.5D,
                TaskUid = 1,
                Name = "Home move plan.mpp",
                Folder = ""
            });
            Console.WriteLine(response);
        }
    }
}