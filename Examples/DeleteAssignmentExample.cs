using System;
using Aspose.Tasks.Cloud.Sdk;
using Aspose.Tasks.Cloud.Sdk.Model;
using Aspose.Tasks.Cloud.Sdk.Model.Requests;

namespace aspose.tasks.csharp
{
    class DeleteAssignmentExample : BaseContext
    {
        public void run()
        {
            var configuration = new Configuration { AppKey = BaseContext.AppKey, AppSid = BaseContext.AppSid };
            TasksApi api = new TasksApi(configuration);

            var response = api.DeleteAssignment(new DeleteAssignmentRequest
            {
                AssignmentUid = 63,
                Name = "Home move plan.mpp",
                Folder = ""
            });
            Console.WriteLine(response.Code);
        }
    }
}
