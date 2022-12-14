using System;

namespace Aspose.Tasks.Cloud.Sdk.Model
{
    /// <summary>
    /// Represents Primavera-specific properties for a task read from Primavera format (XER of P6XML).
    /// </summary>
    public class PrimaveraTaskProperties
    {
        /// <summary>
        /// The sequence number of the WBS item (summary tasks). It is used to sort summary tasks in Primavera.
        /// </summary>
        /// <remarks>
        /// Applicable to WBS items (summary tasks).
        /// </remarks>
        public int SequenceNumber { get; set; }

        /// <summary>
        /// Activity id field - a task's unique identifier used by Primavera.
        /// </summary>
        /// <remarks>
        /// Applicable only to activities (non-summary tasks).
        /// </remarks>
        public string ActivityId { get; set; }  

        /// <summary>
        /// Remaining early finish date - the date when the remaining work for the activity is scheduled to be finished.
        /// </summary>
        public DateTime RemainingEarlyFinish { get; set; }

        /// <summary>
        /// Remaining early start date - the date when the remaining work for the activity is scheduled to begin.
        /// </summary>
        public DateTime RemainingEarlyStart { get; set; }

        /// <summary>
        /// Remaining late start date.
        /// </summary>
        public DateTime RemainingLateStart { get; set; }   

        /// <summary>
        /// Remaining late finish date.
        /// </summary>
        public DateTime RemainingLateFinish { get; set; }

        /// <summary>
        /// Raw text representation (as in source file) of 'Duration Type' field of the activity.
        /// </summary>
        /// <remarks>
        /// Applicable only to activities (non-summary tasks).
        /// </remarks>
        public string RawDurationType { get; set; }

        /// <summary>
        /// Raw text representation (as in source file) of 'Activity Type' field of the activity.
        /// </summary>
        /// <remarks>
        /// Applicable only to activities (non-summary tasks).
        /// </remarks>
        public string RawActivityType { get; set; }

        /// <summary>
        /// Raw text representation (as in source file) of '% Complete Type' field of the activity.
        /// </summary>
        /// <remarks>
        /// Applicable only to activities (non-summary tasks).
        /// </remarks>
        public string RawCompletePercentType { get; set; }

        /// <summary>
        /// Raw text representation (as in source file) of 'Status' field of the activity.
        /// </summary>
        /// <remarks>
        /// Applicable only to activities (non-summary tasks).
        /// </remarks>
        public string RawStatus { get; set; }
    }
}