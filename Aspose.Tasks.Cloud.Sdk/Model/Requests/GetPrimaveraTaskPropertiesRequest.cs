namespace Aspose.Tasks.Cloud.Sdk.Model.Requests
{

    /// <summary>
    /// Request model for <see cref="Aspose.Tasks.Cloud.Sdk.Api.TasksApi.GetPrimaveraTaskProperties" /> operation.
    /// </summary>  
    public class GetPrimaveraTaskPropertiesRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetPrimaveraTaskPropertiesRequest"/> class.
        /// </summary>        
        public GetPrimaveraTaskPropertiesRequest()
        {
        }


        /// <summary>
        /// The name of the file.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Task Uid
        /// </summary>  
        public int? TaskUid { get; set; }

        /// <summary>
        /// The document folder.
        /// </summary>  
        public string Folder { get; set; }
        
    }
}