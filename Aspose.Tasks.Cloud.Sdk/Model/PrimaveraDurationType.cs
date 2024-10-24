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
    /// Specifies duration type of Primavera activity.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PrimaveraDurationType
    {

        /// <summary>
        /// Not specified or not applicable.
        /// </summary>
        None = 0,

        /// <summary>
        /// 'Fixed Duration And Units' duration type
        /// </summary>
        FixedDurationUnits = 1,

        /// <summary>
        /// 'Fixed Duration And Units/Time' duration type
        /// </summary>
        FixedDurationUnitsTime = 2,

        /// <summary>
        /// 'Fixed Units' duration type
        /// </summary>
        FixedUnits = 3,

        /// <summary>
        /// 'Fixed Units/Time' duration type
        /// </summary>
        FixedUnitsTime = 4
    }
}
