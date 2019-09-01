using System;
using Aspose.Tasks.Cloud.Sdk;
using Aspose.Tasks.Cloud.Sdk.Model;
using Aspose.Tasks.Cloud.Sdk.Model.Requests;
using Newtonsoft.Json.Linq;

namespace aspose.tasks.csharp
{
    class GetRiskAnalysisReportExample : BaseContext
    {
        public void run()
        {
            var configuration = new Configuration { AppKey = BaseContext.AppKey, AppSid = BaseContext.AppSid };
            TasksApi api = new TasksApi(configuration);
            var response = api.GetRiskAnalysisReport(new GetRiskAnalysisReportRequest()
            {
                DistributionType = ProbabilityDistributionType.Normal,
                ConfidenceLevel = ConfidenceLevel.CL85,
                Optimistic = 80,
                Pessimistic = 130,
                Iterations = 200,
                TaskUid = 1,
                Name = "Home move plan.mpp",
                Folder = ""
            });
            Console.WriteLine(response);
        }
    }
}