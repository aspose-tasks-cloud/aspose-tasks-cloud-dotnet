
![](https://img.shields.io/badge/api-v3.0-lightgrey) ![Nuget](https://img.shields.io/nuget/v/Aspose.tasks-Cloud) ![Nuget](https://img.shields.io/nuget/dt/Aspose.tasks-Cloud) [![GitHub license](https://img.shields.io/github/license/aspose-tasks-cloud/aspose-tasks-cloud-dotnet)](https://github.com/aspose-tasks-cloud/aspose-tasks-cloud-dotnet/blob/master/LICENSE) ![GitHub last commit](https://img.shields.io/github/last-commit/Aspose-tasks-Cloud/aspose-tasks-cloud-dotnet)

# Manipulate MS Project Files in .NET via Cloud REST API

Aspose.Tasks for Cloud offers the ability to manipulate and convert Microsoft Project MPT, MPP, MPX & Oracle Primavera XER, XML, and PrimaveraP6XML files in .NET. [Aspose.Tasks Cloud SDK for .NET](https://products.aspose.cloud/tasks/net) wraps the REST API to make it easier for the developers to integrate MS Project Task Management features in their own cloud-based .NET applications on Linux, MacOS, Windows or Android.

Feel free to explore the [Developer's Guide](https://docs.aspose.cloud/display/taskscloud/Developer+Guide) & [API Reference](https://apireference.aspose.cloud/tasks/) to know all about Aspose.Tasks Cloud API.

## MS Project in .NET Processing Features
- Add project assignments or delete project assignments along with their references.
- Get the project's outline codes by index & get links to all project tasks.
- Import projects from Primavera DB formats or from databases with the specified connection string.
- Get UIDs of all projects contained in the file & fetch the required assignment with the project based on UID.
- Manage project tasks, resource data, calendars & Work Breakdown Structure (WBS).
- Perform risk analysis using Monte Carlo simulation and create a report.
- Create and set project document properties & fetch all or specific existing properties.
- Get a project's extended attributes, time-scaled data, or recurring info of a specific task.
- Reschedule project tasks, dates, and other settings.
- Calculate slacks & recalculate project completion or incompletion work.
- Fetch a project document in the desired format.
- Delete project task with its related references & rebuild the task tree.
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


## Enhancements in Version 24.10
- Enhanced reading data from Primavera-specific task's properties.

## Enhancements in Version 24.4
- Added new ability to get views information
- Possibility to modify table text styles for Gantt Chart views.

## Enhancements in Version 22.12
- Added new ability to read Primavera-specific task's properties.
- Provided the ability to read more document properties.

## Enhancements in Version 20.11
- Support for the batch creation of tasks (i.e. the ability to create multiple tasks in a single *API* call).

## Enhancements in Version 20.8
- Ability to specify the non-default path for Project Server's *PWA* URL.
- Ability to modify *timephasedData* collection in assignments.

## Enhancements in Version 20.6
- Possibility to render comments when saving as image, HTML or PDF.
- Option to use username and password to connect Project Online (Server) instead of auth token, incase you don't have it.
- Ability to add assignments to your project file along with specifying its cost.
- Quickly adding new tasks to project, when calculation mode is set to automatic.
- Ability to add project in Microsoft Project Server.
- Added support of reading shared resource assignments.

## Get Started with Aspose.Tasks Cloud SDK for .NET

Register an account at [Aspose Cloud Dashboard](https://dashboard.aspose.cloud/#/apps) to get you application information. Next, execute `Install-Package Aspose.Tasks-Cloud` from the Package Manager Console in Visual Studio to fetch & reference Aspose.Tasks Cloud SDK .NET assembly in your project. If you already have Aspose.Tasks Cloud SDK for .NET, execute `Update-Package Aspose.Tasks-Cloud` to get the latest version. You may alternatively install the package from command line as `nuget install Aspose.Tasks-Cloud`.

## Convert MS Project MPP to PDF in .NET

```csharp
	// Get your ClientId and ClientSecret from https://dashboard.aspose.cloud (free registration required).
	var config = new Configuration
	{
		AppSid = "MY_CLIENT_ID",
		AppKey = "MY_CLIENT_SECRET"
	};

	var tasksApi = new TasksApi(config);
	using (var inputStream = new FileStream("some_project.mpp", FileMode.Open))
	{
		var uploadFileRequest = new PostCreateRequest("some_project.mpp", inputStream);
		tasksApi.UploadFile(uploadFileRequest);
	}

	var request = new GetReportPdfRequest();
	request.Name = "some_project.mpp";
	request.Type = ReportType.Milestones;
	Stream response = await tasksApi.GetReportPdfAsync(request);
```

## Aspose.Tasks Cloud SDKs in Popular Languages

| .NET | PHP | Python| Node.js | Go |
|---|---|---|---|---|
| [GitHub](https://github.com/aspose-tasks-cloud/aspose-tasks-cloud-dotnet) |[GitHub](https://github.com/aspose-tasks-cloud/aspose-tasks-cloud-php) | [GitHub](https://github.com/aspose-tasks-cloud/aspose-tasks-cloud-python) | [GitHub](https://github.com/aspose-tasks-cloud/aspose-tasks-cloud-node) |[GitHub](https://github.com/aspose-tasks-cloud/aspose-tasks-cloud-go)|
| [NuGet](https://www.nuget.org/packages/Aspose.tasks-Cloud/)| [Composer](https://packagist.org/packages/aspose/tasks-cloud-php) | [PIP](https://pypi.org/project/aspose-tasks-cloud/) | [NPM](https://www.npmjs.com/package/@asposecloud/aspose-tasks-cloud) | [Go.Dev](https://pkg.go.dev/github.com/aspose-tasks-cloud/aspose-tasks-cloud-go/) |

[Product Page](https://products.aspose.cloud/tasks/net) | [Documentation](https://docs.aspose.cloud/display/taskscloud/Home) | [API Reference](https://apireference.aspose.cloud/tasks/) | [Code Samples](https://github.com/aspose-tasks-cloud/aspose-tasks-cloud-dotnet) | [Blog](https://blog.aspose.cloud/category/tasks/) | [Free Support](https://forum.aspose.cloud/c/tasks) | [Free Trial](https://dashboard.aspose.cloud/#/apps)
