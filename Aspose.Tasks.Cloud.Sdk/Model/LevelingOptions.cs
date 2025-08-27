using System;

namespace Aspose.Tasks.Cloud.Sdk.Model
{
    /// <summary>
    /// Options which specifies how to level resources. 
    /// If not specified, default leveling options will be used.
    /// </summary>
    public class LevelingOptions
    {
        /// <summary>
        /// Leveling period start date. The default value is the project`s start date.
        /// </summary>
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Leveling period end date. The default value is the project`s finish date.
        /// </summary>
        public DateTime? FinishDate { get; set; }

        /// <summary>
        /// The list of the resource uids which will be leveled. If null is set, 
        /// all project resources will be leveled.
        /// </summary>
        public int[] ResourceUids { get; set; }

        /// <summary>
        /// The order in which the leveling algorithm delays tasks that have overallocations.
        /// After determination of tasks causing the overallocation and which tasks can be
        /// delayed, the specified order is used which task should be delayed first.
        /// </summary>
        public LevelingOrder LevelingOrder { get; set; }
    }
}
