using System;
using Aspose.Tasks.Cloud.Sdk;
using Aspose.Tasks.Cloud.Sdk.Model;
using Aspose.Tasks.Cloud.Sdk.Model.Requests;

namespace aspose.tasks.csharp
{
    class GetExtendedAttributes : BaseContext
    {
        static void Main(string[] args)
        {
            var configuration = new Configuration { AppKey = BaseContext.AppKey, AppSid = BaseContext.AppSid };
            TasksApi api = new TasksApi(configuration);
            var response = api.GetExtendedAttributes(new GetExtendedAttributesRequest
            {
                Name = "NewProductDev.mpp",
                Folder = ""
            });
            Console.WriteLine(response.Code);
        }
    }
}