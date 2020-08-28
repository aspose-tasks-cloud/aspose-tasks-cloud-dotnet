using System.Threading.Tasks;
using System.IO;
using System.Web.Http;
using Aspose.Tasks.Cloud.Live.Demos.UI.Models;
using System.Diagnostics;
using Aspose.Tasks.Cloud.Sdk;
using Aspose.Tasks.Cloud.Sdk.Model;
using Aspose.Tasks.Cloud.Sdk.Model.Requests;
using Newtonsoft.Json.Linq;

namespace Aspose.Tasks.Cloud.Live.Demos.UI.Models
{
	///<Summary>
	/// Aspose.Tasks Cloud API convert method to convert word document file to other format
	///</Summary>
	
	public class AsposeTasksConversion : AsposeTasksCloudBase
    {        
        
		///<Summary>
		/// Convert method to convert file to other format
		///</Summary>
		public Response Convert(string fileName, string folderName,   string outputType)
        {
			string fileNamewithOutExtension = Path.GetFileNameWithoutExtension(fileName);
			string outputFileName = fileNamewithOutExtension + "." + outputType;
			ProjectFileFormat projectFileFormat = new ProjectFileFormat();
			bool foundSaveOption = true;
			

			switch (outputType)
			{
				case "pdf":
					projectFileFormat = ProjectFileFormat.Pdf;
					break;
				case "xlsx":
					projectFileFormat = ProjectFileFormat.Xlsx;
					break;
				case "mpp":
					projectFileFormat = ProjectFileFormat.Mpp;
					break;
				case "xml":
					projectFileFormat = ProjectFileFormat.Xml;
					break;
				case "mpx":
					projectFileFormat = ProjectFileFormat.Mpx;
					break;
				case "html":
					projectFileFormat = ProjectFileFormat.Html;
					break;
				case "txt":
					projectFileFormat = ProjectFileFormat.Txt;
					break;
				case "tif":
					projectFileFormat = ProjectFileFormat.Tiff;
					break;
				case "svg":
					projectFileFormat = ProjectFileFormat.Svg;
					break;
				case "png":
					projectFileFormat = ProjectFileFormat.Png;
					break;
				case "jpeg":
					projectFileFormat = ProjectFileFormat.Jpeg;
					break;
				case "xer":
					projectFileFormat = ProjectFileFormat.Xer;
					break;
				
				default:
					foundSaveOption = false;
					break;
			}

			if (tasksApi != null)
			{
				if (foundSaveOption)
				{
					

					var response = tasksApi.GetTaskDocumentWithFormat(new GetTaskDocumentWithFormatRequest
					{
						Format = projectFileFormat,
						Name = fileName,
						Folder = null,
						Storage = null

				});

					if (response != null)
					{
						using (var fileStream = new FileStream(Path.Combine(Config.Configuration.OutputDirectory, outputFileName), FileMode.Create, FileAccess.Write))
						{
							response.CopyTo(fileStream);
						}
					}
				}

				return new Response
				{
					FileName = outputFileName,
					Status = "OK",
					StatusCode = 200,
				};
			}
			return new Response
			{
				FileName = null,
				Status = "Output type not found",
				StatusCode = 500
			};

		}
		
    }
}
