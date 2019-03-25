using System;
using Aspose.Tasks.Cloud.Sdk;
using Aspose.Tasks.Cloud.Sdk.Model;
using Aspose.Tasks.Cloud.Sdk.Model.Requests;

namespace aspose.tasks.csharp
{
    class GetResourceTimephasedDataExample : BaseContext
    {
        static void Main(string[] args)
        {
            var configuration = new Configuration { AppKey = BaseContext.AppKey, AppSid = BaseContext.AppSid };
            TasksApi api = new TasksApi(configuration);

            var response = api.GetResourceTimephasedData(new GetResourceTimephasedDataRequest()
            {
                ResourceUid = 1,
                Name = "NewProductDev.mpp",
                Folder = "",
                Type = TimephasedDataType.ResourceWork,
            });

            Console.WriteLine(response.Code);
        }
    }
}
