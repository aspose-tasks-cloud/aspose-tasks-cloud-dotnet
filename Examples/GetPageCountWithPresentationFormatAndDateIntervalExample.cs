using System;
using Aspose.Tasks.Cloud.Sdk;
using Aspose.Tasks.Cloud.Sdk.Model;
using Aspose.Tasks.Cloud.Sdk.Model.Requests;

namespace aspose.tasks.csharp
{
    class GetPageCountWithPresentationFormatAndDateIntervalExample : BaseContext
    {
        public void run()
        {
            var configuration = new Configuration { AppKey = BaseContext.AppKey, AppSid = BaseContext.AppSid };
            TasksApi api = new TasksApi(configuration);
            var response = api.GetPageCount(new GetPageCountRequest
            {
                PresentationFormat = PresentationFormat.TaskUsage,
                Timescale = Timescale.Months,
                Name = "NewProductDev.mpp",
                Folder = "",
                StartDate = new DateTime(2004, 1, 1),
                EndDate = new DateTime(2004, 2, 28)
            });
            Console.WriteLine(response.Code);
        }
    }
}