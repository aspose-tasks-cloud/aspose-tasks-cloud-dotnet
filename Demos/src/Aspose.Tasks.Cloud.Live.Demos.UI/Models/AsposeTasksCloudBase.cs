using System;
using System.IO;
using System.Web.Http;
using System.Threading.Tasks;
using System.IO.Compression;
using System.Drawing;
using System.Drawing.Imaging;
using Aspose.Tasks.Cloud.Sdk;
using Aspose.Tasks.Cloud.Sdk.Model;
using Aspose.Tasks.Cloud.Sdk.Model.Requests;

namespace  Aspose.Tasks.Cloud.Live.Demos.UI.Models
{
	///<Summary>
	/// AsposeTasksCloudBase class to have base methods
	///</Summary>

	public abstract class AsposeTasksCloudBase : ApiController
    {
		protected TasksApi tasksApi = new TasksApi(Config.Configuration.AppKey, Config.Configuration.AppSID);
		///<Summary>
		/// Get File extension
		///</Summary>
		protected string GetoutFileExtension(string fileName, string folderName)
        {
			string sourceFolder = Config.Configuration.WorkingDirectory + folderName;
            fileName = sourceFolder + "\\" + fileName;
            return Path.GetExtension(fileName);
        }
		
       
		
    }
}
