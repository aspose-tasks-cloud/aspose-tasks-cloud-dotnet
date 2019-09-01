using System;
using Aspose.Tasks.Cloud.Sdk;
using Aspose.Tasks.Cloud.Sdk.Model;
using Aspose.Tasks.Cloud.Sdk.Model.Requests;

namespace aspose.tasks.csharp
{
    class GetVbaProjectExample : BaseContext
    {
        public void run()
        {
            var configuration = new Configuration { AppKey = BaseContext.AppKey, AppSid = BaseContext.AppSid };
            TasksApi api = new TasksApi(configuration);

            var vbaResponse = api.GetVbaProject(new GetVbaProjectRequest()
            {
                Name = "VbaProject3.mpp",
                Folder = ""
            });


            Console.WriteLine(vbaResponse.Code);
        }
    }
}
