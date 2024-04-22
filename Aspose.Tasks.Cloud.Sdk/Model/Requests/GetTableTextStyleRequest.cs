using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aspose.Tasks.Cloud.Sdk.Model.Requests
{
    /// <summary>
    /// Request model for <see cref="Sdk.Api.TasksApi.GetTableTextStyle" /> operation.
    /// </summary>  
    public class GetTableTextStyleRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTableTextStyleRequest"/> class.
        /// </summary>        
        public GetTableTextStyleRequest()
        {
        }

        /// <summary>
        /// The name of the file.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Uid of the view.
        /// </summary>  
        public int ViewUid { get; set; }

        /// <summary>
        /// Uid of the row.
        /// </summary>  
        public int RowUid { get; set; }

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
