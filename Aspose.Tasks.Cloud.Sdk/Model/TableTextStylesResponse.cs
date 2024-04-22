using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aspose.Tasks.Cloud.Sdk.Model
{
    /// <summary>
    /// TableTextStyles Response
    /// </summary>
    public class TableTextStylesResponse : AsposeResponse
    {
        /// <summary>
        /// Array of table text styles of specified view
        /// </summary>
        public TableTextStyle[] Items { get; set; }
    }
}
