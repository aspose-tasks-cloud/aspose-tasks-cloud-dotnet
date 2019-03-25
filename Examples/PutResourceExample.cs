using System;
using Aspose.Tasks.Cloud.Sdk;
using Aspose.Tasks.Cloud.Sdk.Model;
using Aspose.Tasks.Cloud.Sdk.Model.Requests;
using Newtonsoft.Json.Linq;

namespace aspose.tasks.csharp
{
    class PutResourceExample : BaseContext
    {
        static void Main(string[] args)
        {
            var configuration = new Configuration { AppKey = BaseContext.AppKey, AppSid = BaseContext.AppSid };
            TasksApi api = new TasksApi(configuration);


            var resourceResponse = api.GetResource(new GetResourceRequest
            {
                Name = "sample.mpp",
                Storage = "Tasks",
                Folder = "",
                ResourceUid = 1
            });
            var resource = resourceResponse.Resource;
            resource.Name = "Modified Resource1";
            resource.Cost = 200;
            resource.Start = new DateTime(2000, 10, 10);
            resource.Work = new TimeSpan(100, 10, 0);
            resource.Finish = new DateTime(2000, 10, 10);
            resource.OvertimeWork = new TimeSpan(100, 0, 0);
            resource.StandardRate = 101;
            resource.Baselines.Add(new Baseline
            {
                BaselineNumber = BaselineType.Baseline1,
                Cost = 44,
            });

            var putResponse = api.PutResource(new PutResourceRequest
            {
                Name = "sample.mpp",
                Folder = "",
                ResourceUid = 1,
                Resource = resource,
                Recalculate = false,
                Mode = CalculationMode.None
            });

            Console.WriteLine(putResponse);
        }
    }
}