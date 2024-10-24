using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aspose.Tasks.Cloud.Sdk.Model
{

    /// <summary>
    /// Specifies value of '% Complete Type' field for Primavera activities.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PrimaveraPercentCompleteType
    {

        /// <summary>
        /// Not specified or not applicable.
        /// </summary>
        None = 0,

        /// <summary>
        /// Duration % Complete type.
        /// </summary>
        Duration = 1,

        /// <summary>
        /// Physical % Complete type.
        /// </summary>
        Physical = 2,

        /// <summary>
        /// Units % Complete type.
        /// </summary>
        Units = 3
    }
}
