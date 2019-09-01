using System;
using Aspose.Tasks.Cloud.Sdk;
using Aspose.Tasks.Cloud.Sdk.Model;
using Aspose.Tasks.Cloud.Sdk.Model.Requests;
using Newtonsoft.Json.Linq;

namespace aspose.tasks.csharp
{
    class PostTaskLinkExample : BaseContext
    {
        public void run()
        {
            var configuration = new Configuration { AppKey = BaseContext.AppKey, AppSid = BaseContext.AppSid };
            TasksApi api = new TasksApi(configuration);


           var response = api.PostTaskLink(new PostTaskLinkRequest()
            {
                TaskLink = new TaskLink
                {
                    PredecessorUid = 28,
                    SuccessorUid = 30,
                    LinkType = TaskLinkType.StartToStart,
                    Lag = 9600,
                    LagFormat = TimeUnitType.Day
                },
                Name = "NewProductDev.mpp",
                Folder = "",
                Storage = "Tasks"
            });

            Console.WriteLine(response);
        }
    }
}