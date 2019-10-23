namespace Aspose.Tasks.Cloud.Sdk.Model.Requests
{
    /// <summary>
    /// Request model for <see cref="Aspose.Words.Cloud.Sdk.Api.StorageApi.DownloadFile" /> operation.
    /// </summary>  
    public class DownloadFileRequest  
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DownloadFileRequest"/> class.
        /// </summary>        
        public DownloadFileRequest()
        {
        }
        
        /// <summary>
        /// Path of the file including the file name and extension e.g. /folder1/file.ext
        /// </summary>  
        public string Path { get; set; }

        /// <summary>
        /// Storage name
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// File version ID to download
        /// </summary>  
        public string VersionId { get; set; }
    }
}