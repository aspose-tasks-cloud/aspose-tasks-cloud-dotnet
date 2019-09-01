using System;
using Aspose.Tasks.Cloud.Sdk;
using Aspose.Tasks.Cloud.Sdk.Model;
using Aspose.Tasks.Cloud.Sdk.Model.Requests;

namespace aspose.tasks.csharp
{
    class DeleteExtendedAttributeExample : BaseContext
    {
         public void run()
        {
            var configuration = new Configuration { AppKey = BaseContext.AppKey, AppSid = BaseContext.AppSid };
            TasksApi api = new TasksApi(configuration);
            var deleteResponse = api.DeleteExtendedAttributeByIndex(new DeleteExtendedAttributeByIndexRequest
            {
                Index = 1,
                Name = "NewProductDev.mpp",
                Folder = ""
            });
            Console.WriteLine(deleteResponse.Code);
        }
    }
}