using System;
using Aspose.Tasks.Cloud.Sdk;
using Aspose.Tasks.Cloud.Sdk.Model;
using Aspose.Tasks.Cloud.Sdk.Model.Requests;
using Newtonsoft.Json.Linq;

namespace aspose.tasks.csharp
{
    class PostTaskDocumentWithFormatExample : BaseContext
    {
        static void Main(string[] args)
        {
            var configuration = new Configuration { AppKey = BaseContext.AppKey, AppSid = BaseContext.AppSid };
            TasksApi api = new TasksApi(configuration);
            var saveOptionsSerialized = "{ \"TextDelimiter\":\"Comma\", \"IncludeHeaders\":false,\"NonExistingTestProperty\":false," +
                "\"View\":{ \"Columns\":[{Type:\"GanttChartColumn\",\"Name\":\"TestColumn1\",\"Property\":\"Name\",\"Width\":120}," +
                "{Type:\"GanttChartColumn\",\"Name\":\"TestColumn2\",\"Property\":\"Duration\",\"Width\":120}]}}";

            var saveOptions = JObject.Parse(saveOptionsSerialized);
            var response = api.PostTaskDocumentWithFormat(new PostTaskDocumentWithFormatRequest
            {
                Format = ProjectFileFormat.Csv,
                Name = "Home move plan.mpp",
                Folder = "",
                SaveOptions = saveOptions
            });
            Console.WriteLine(response);
        }
    }
}