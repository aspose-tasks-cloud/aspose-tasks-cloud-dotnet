using System;
using Aspose.Tasks.Cloud.Sdk;
using Aspose.Tasks.Cloud.Sdk.Model;
using Aspose.Tasks.Cloud.Sdk.Model.Requests;
using System.Collections.Generic;

namespace aspose.tasks.csharp
{
    class PutRenumberWbsCodeExample : BaseContext
    {
        static void Main(string[] args)
        {
            var configuration = new Configuration { AppKey = BaseContext.AppKey, AppSid = BaseContext.AppSid };
            TasksApi api = new TasksApi(configuration);

            var response = api.PutRenumberWbsCode(new PutRenumberWbsCodeRequest()
            {
                Name = "WBSDefinition.mpp",
                Folder = "",
                TaskUids = new List<int?>()
            });


            Console.WriteLine(response);
        }
    }
}
