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
    /// Specifies type of Primavera activity.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PrimaveraActivityType
    {

        /// <summary>
        /// Not specified or not applicable.
        /// </summary>
        None = 0,

        /// <summary>
        /// 'Start Milestone' activity type
        /// </summary>
        StartMilestone = 1,

        /// <summary>
        /// 'Finish Milestone' activity type
        /// </summary>
        FinishMilestone = 2,

        /// <summary>
        /// 'Task Dependent' activity type
        /// </summary>
        TaskDependent = 3,

        /// <summary>
        /// 'Resource Dependent' activity type
        /// </summary>
        ResourceDependent = 4,

        /// <summary>
        /// 'Level Of Effort' activity type
        /// </summary>
        LevelOfEffort = 5,

        /// <summary>
        /// 'WBS Summary' activity type
        /// </summary>
        WbsSummary = 6
    }
}
