using System;
using Aspose.Tasks.Cloud.Sdk;
using Aspose.Tasks.Cloud.Sdk.Model;
using Aspose.Tasks.Cloud.Sdk.Model.Requests;
using Newtonsoft.Json.Linq;

namespace aspose.tasks.csharp
{
    class PutTaskLink : BaseContext
    {
        static void Main(string[] args)
        {
            var configuration = new Configuration { AppKey = BaseContext.AppKey, AppSid = BaseContext.AppSid };
            TasksApi api = new TasksApi(configuration);


          var linksResponse = api.GetTaskLinks(new GetTaskLinksRequest()
            {
                Name = "NewProductDev.mpp",
                Folder = "",
                Storage = "Tasks"
            });

            var taskLinkToEdit = linksResponse.TaskLinks[0];

            taskLinkToEdit.LinkType = TaskLinkType.StartToFinish;
            taskLinkToEdit.Lag = 9600;
            taskLinkToEdit.LagFormat = TimeUnitType.Day;

            var response = api.PutTaskLink(new PutTaskLinkRequest()
            {
                Index = 1,
                TaskLink = taskLinkToEdit,
                Name = "NewProductDev.mpp",
                Folder = "",
                Storage = "Tasks"
            });

            Console.WriteLine(response);
        }
    }
}