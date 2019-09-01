using System;
using Aspose.Tasks.Cloud.Sdk;
using Aspose.Tasks.Cloud.Sdk.Model;
using Aspose.Tasks.Cloud.Sdk.Model.Requests;

namespace aspose.tasks.csharp
{
    class PutTaskRecurringInfoExample : BaseContext
    {
        public void run()
        {
            var configuration = new Configuration { AppKey = BaseContext.AppKey, AppSid = BaseContext.AppSid };
            TasksApi api = new TasksApi(configuration);

            var response = api.GetTaskRecurringInfo(new GetTaskRecurringInfoRequest
            {
                Name = "sample.mpp",
                Storage = "Tasks",
                Folder = "",
                TaskUid = 6
            });
            var recurringInfo = response.RecurringInfo;
            recurringInfo.Occurrences = 10;

            var putResponse = api.PutTaskRecurringInfo(new PutTaskRecurringInfoRequest
            {
                Name = "sample.mpp",
                Storage = "Tasks",
                Folder = "",
                TaskUid = 6,
                RecurringInfo = recurringInfo
            });
            Console.WriteLine(response.Code);
        }
    }
}
