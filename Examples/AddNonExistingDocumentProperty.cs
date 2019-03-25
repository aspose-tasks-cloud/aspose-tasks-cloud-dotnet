using System;
using Aspose.Tasks.Cloud.Sdk;
using Aspose.Tasks.Cloud.Sdk.Model;
using Aspose.Tasks.Cloud.Sdk.Model.Requests;

namespace aspose.tasks.csharp
{
    class AddNonExistingDocumentProperty : BaseContext
    {
        static void Main(string[] args)
        {
            var configuration = new Configuration { AppKey = BaseContext.AppKey, AppSid = BaseContext.AppSid };
            TasksApi api = new TasksApi(configuration);
            var postResponse = api.PostDocumentProperty(new PostDocumentPropertyRequest
            {
                Name = "Home move plan.mpp",
                Folder = "",
                PropertyName = "new property",
                Property = new DocumentProperty
                {
                    Name = "new property",
                    Value = "New property value"
                }
            });
            Console.WriteLine(postResponse.Code);
        }
    }
}