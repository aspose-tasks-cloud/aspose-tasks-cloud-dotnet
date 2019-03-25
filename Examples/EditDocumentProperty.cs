using System;
using Aspose.Tasks.Cloud.Sdk;
using Aspose.Tasks.Cloud.Sdk.Model;
using Aspose.Tasks.Cloud.Sdk.Model.Requests;

namespace aspose.tasks.csharp
{
    class EditDocumentPropertyExample : BaseContext
    {
        static void Main(string[] args)
        {
            var configuration = new Configuration { AppKey = BaseContext.AppKey, AppSid = BaseContext.AppSid };
            TasksApi api = new TasksApi(configuration);
            var putResponse = api.PutDocumentProperty(new PutDocumentPropertyRequest
            {
                Name = "Home move plan.mpp",
                Folder = "",
                PropertyName = "Title",
                Property = new DocumentProperty
                {
                    Name = "Title",
                    Value = "New title value"
                }
            });

            Console.WriteLine(putResponse.Code);
        }
    }
}