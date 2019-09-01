using System;
using Aspose.Tasks.Cloud.Sdk;
using Aspose.Tasks.Cloud.Sdk.Model;
using Aspose.Tasks.Cloud.Sdk.Model.Requests;

namespace aspose.tasks.csharp
{
    class GetTaskTimephasedData : BaseContext
    {
        public void run()
        {
            var configuration = new Configuration { AppKey = BaseContext.AppKey, AppSid = BaseContext.AppSid };
            TasksApi api = new TasksApi(configuration);

            var response = api.GetTaskTimephasedData(new GetTaskTimephasedDataRequest()
            {
                TaskUid = 27,
                Name = "NewProductDev.mpp",
                Folder = "",
                Type = TimephasedDataType.TaskWork
            });
            Console.WriteLine(response.Code);
        }
    }
}
