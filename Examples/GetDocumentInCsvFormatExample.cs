using System;
using Aspose.Tasks.Cloud.Sdk;
using Aspose.Tasks.Cloud.Sdk.Model;
using Aspose.Tasks.Cloud.Sdk.Model.Requests;

namespace aspose.tasks.csharp
{
    class GetTaskDocumentWithFormatExample : BaseContext
    {
        public void run()
        {
            var configuration = new Configuration { AppKey = BaseContext.AppKey, AppSid = BaseContext.AppSid };
            TasksApi api = new TasksApi(configuration);
            var response = api.GetTaskDocumentWithFormat(new GetTaskDocumentWithFormatRequest
            {
                Format = ProjectFileFormat.Csv,
                Name = "Home move plan.mpp",
                Folder = "",
            });
            Console.WriteLine(response);
        }
    }
}