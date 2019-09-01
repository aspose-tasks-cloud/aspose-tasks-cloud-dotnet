using System;
using Aspose.Tasks.Cloud.Sdk;
using Aspose.Tasks.Cloud.Sdk.Model;
using Aspose.Tasks.Cloud.Sdk.Model.Requests;

namespace aspose.tasks.csharp
{
    class ImportFromPrimaveraFileExample : BaseContext
    {
        public void run()
        {
            var configuration = new Configuration { AppKey = BaseContext.AppKey, AppSid = BaseContext.AppSid };
            TasksApi api = new TasksApi(configuration);
              var response = api.PutImportProjectFromFile(new PutImportProjectFromFileRequest
            {
                Name = "p6_multiproject.xml",
                Folder ="",
                Filename = "imported_from_primavera.xml",
                ProjectUid = "111",
                FileType = ImportedProjectType.PrimaveraXml,
                OutputFileFormat = ProjectFileFormat.P6xml
            });
            Console.WriteLine(response.Code);
        }
    }
}