using System;
using Aspose.Tasks.Cloud.Sdk;
using Aspose.Tasks.Cloud.Sdk.Model;
using Aspose.Tasks.Cloud.Sdk.Model.Requests;

namespace aspose.tasks.csharp
{
    class EditAssignment : BaseContext
    {
        static void Main(string[] args)
        {
            var configuration = new Configuration { AppKey = BaseContext.AppKey, AppSid = BaseContext.AppSid };
            TasksApi api = new TasksApi(configuration);

            var response = api.GetAssignment(new GetAssignmentRequest
            {
                AssignmentUid = 63,
                Name = "NewProductDev.mpp",
                Folder = ""
            });

            var putResponse = api.PutAssignment(new PutAssignmentRequest
            {
                Mode = CalculationMode.Automatic,
                Recalculate = true,
                AssignmentUid = 63,
                Assignment = response.Assignment,
                Name = "NewProductDev.mpp",
                Folder = ""
            });


            Console.WriteLine(response.Code);
        }
    }
}