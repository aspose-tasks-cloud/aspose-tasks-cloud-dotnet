using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aspose.Tasks.Cloud.Sdk.Model.Requests
{
    /// <summary>
    /// Request model for <see cref="Sdk.Api.TasksApi.GetViews" /> operation.
    /// </summary>  
    public class GetViewsRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetViewsRequest"/> class.
        /// </summary>        
        public GetViewsRequest()
        {
        }


        /// <summary>
        /// The name of the file.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// The document storage.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// The document folder.
        /// </summary>  
        public string Folder { get; set; }
    }
}
