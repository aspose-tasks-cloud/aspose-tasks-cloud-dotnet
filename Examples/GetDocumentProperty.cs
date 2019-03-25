using System;
using Aspose.Tasks.Cloud.Sdk;
using Aspose.Tasks.Cloud.Sdk.Model;
using Aspose.Tasks.Cloud.Sdk.Model.Requests;

namespace aspose.tasks.csharp
{
    class GetDocumentProperty : BaseContext
    {
        static void Main(string[] args)
        {
            var configuration = new Configuration { AppKey = BaseContext.AppKey, AppSid = BaseContext.AppSid };
            TasksApi api = new TasksApi(configuration);

            var response = api.GetDocumentProperty(new GetDocumentPropertyRequest
            {
                Name = "Home move plan.mpp",
                Folder = "",
                PropertyName = "Title"
            });
            Console.WriteLine(response.Code);
        }
    }
}
