using System;
using Aspose.Tasks.Cloud.Sdk;
using Aspose.Tasks.Cloud.Sdk.Model;
using Aspose.Tasks.Cloud.Sdk.Model.Requests;

namespace aspose.tasks.csharp
{
    class GetPageCountExample : BaseContext
    {
        public void run()
        {
            var configuration = new Configuration { AppKey = BaseContext.AppKey, AppSid = BaseContext.AppSid };
            TasksApi api = new TasksApi(configuration);
            var response = api.GetPageCount(new GetPageCountRequest
            {
                PresentationFormat = PresentationFormat.TaskUsage,
                Timescale = Timescale.Months,
                Name = "Home move plan.mpp",
                Folder = "",
            });
            Console.WriteLine(response.Code);
        }
    }
}