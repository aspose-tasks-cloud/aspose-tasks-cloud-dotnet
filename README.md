
![](https://img.shields.io/badge/api-v3.0-lightgrey) ![Nuget](https://img.shields.io/nuget/v/Aspose.tasks-Cloud) ![Nuget](https://img.shields.io/nuget/dt/Aspose.tasks-Cloud) [![GitHub license](https://img.shields.io/github/license/aspose-tasks-cloud/aspose-tasks-cloud-dotnet)](https://github.com/aspose-tasks-cloud/aspose-tasks-cloud-dotnet/blob/master/LICENSE) ![GitHub last commit](https://img.shields.io/github/last-commit/Aspose-tasks-Cloud/aspose-tasks-cloud-dotnet)

# .NET SDK to Manage Tasks in the Cloud

Aspose.Tasks for Cloud offers the ability to manipulate and convert Microsoft Project MPT, MPP, MPX & Oracle Primavera XER, XML, and PrimaveraP6XML files in the Cloud. [Aspose.Tasks Cloud SDK for .NET](https://products.aspose.cloud/tasks/net) wraps the REST API to make it easier for .NET developers to integrate Task Management features in their own cloud-based C#, ASP.NET or other .NET applications.

## REST API for Task Management

- [Convert project documents](https://docs.aspose.cloud/tasks/convert-project-document-to-the-specified-format/) to other formats.
- Manipulate task data.
- [Manage project's resources](https://docs.aspose.cloud/tasks/working-with-resources/).
- Handle task links & task assignments.
- Work with project's extended attributes.
- [Read Microsoft Project’s document properties](https://docs.aspose.cloud/tasks/working-with-calendars/) such as start and finish date, tasks scheduling types and so on.
- [Read Microsoft Project’s Calendars](https://docs.aspose.cloud/tasks/working-with-calendars/) and Calendar Exceptions information.

## Read & Write Project Data

**Microsoft Project** MPP, XML, MPT **Primavera** MPX

## Save Project Data As

XER, XLSX, HTML, XML, TXT, TIF, SVG, PNG, JPEG

## Get Started with Aspose.Tasks Cloud SDK for .NET

Register an account at [Aspose Cloud Dashboard](https://dashboard.aspose.cloud/#/apps) to get you application information. Next, execute `Install-Package Aspose.Tasks-Cloud` from the Package Manager Console in Visual Studio to fetch & reference Aspose.Tasks Cloud SDK assembly in your project. If you already have Aspose.Tasks Cloud SDK for .NET, execute `Update-Package Aspose.Tasks-Cloud` to get the latest version. You may alternatively install the package from command line as `nuget install Aspose.Tasks-Cloud`.

## Convert MPP to CSV in the Cloud

```csharp
// For complete examples and data files, please go to https://github.com/aspose-tasks-cloud/aspose-tasks-cloud-dotnet/
var remoteName = await UploadFileToStorageAsync("template.mpp");

// SaveOptions parameters is a json-serialized representation of 
// Aspose.Tasks's SaveOptions class or its format-specific inheritors (Like CsvOptions, etc):

var saveOptionsSerialized = "{ \"TextDelimiter\":\"Comma\", \"IncludeHeaders\":false,\"NonExistingTestProperty\":false," +
    "\"View\":{ \"Columns\":[{Type:\"GanttChartColumn\",\"Name\":\"TestColumn1\",\"Property\":\"Name\",\"Width\":120}," +
    "{Type:\"GanttChartColumn\",\"Name\":\"TestColumn2\",\"Property\":\"Duration\",\"Width\":120}]}}";

var saveOptions = JObject.Parse(saveOptionsSerialized);

var response = await TasksApi.PostTaskDocumentWithFormatAsync(new PostTaskDocumentWithFormatRequest
{
    Format = ProjectFileFormat.Csv,
    Name = remoteName,
    Folder = this.DataFolder,
    SaveOptions = saveOptions
});

Assert.IsNotNull(response);
Assert.IsTrue(response.Length > 0);
response.Seek(0, SeekOrigin.Begin);

using (var sr = new StreamReader(response))
{
    var line1 = sr.ReadLine();
    Assert.AreEqual("Five to Eight Weeks Before Moving,16 days", line1);
}
```
## Aspose.Tasks Cloud SDKs in Popular Languages

| .NET | PHP | Python | Node.js |
|---|---|---|---|
| [GitHub](https://github.com/aspose-tasks-cloud/aspose-tasks-cloud-dotnet) | [GitHub](https://github.com/aspose-tasks-cloud/aspose-tasks-cloud-php) | [GitHub](https://github.com/aspose-tasks-cloud/aspose-tasks-cloud-python) | [GitHub](https://github.com/aspose-tasks-cloud/aspose-tasks-cloud-node)  | 
| [NuGet](https://www.nuget.org/packages/Aspose.Tasks-Cloud/) | [Composer](https://packagist.org/packages/aspose/tasks-sdk-php) | [PIP](https://pypi.org/project/aspose-tasks-cloud/) | [NPM](https://www.npmjs.com/package/@asposecloud/aspose-tasks-cloud)  |

[Home](https://www.aspose.cloud) | [Product Page](https://products.aspose.cloud/tasks/net) | [Documentation](https://docs.aspose.cloud/tasks/) | [Live Demo](https://products.aspose.app/tasks/family) |  [API Reference](https://apireference.aspose.cloud/tasks/) | [Code Samples](https://github.com/aspose-tasks-cloud/aspose-tasks-cloud-dotnet/tree/master/Aspose.Tasks.Cloud.Sdk.Tests) | [Blog](https://blog.aspose.cloud/category/tasks/) | [Free Support](https://forum.aspose.cloud/c/tasks) | [Free Trial](https://dashboard.aspose.cloud/#/apps)
