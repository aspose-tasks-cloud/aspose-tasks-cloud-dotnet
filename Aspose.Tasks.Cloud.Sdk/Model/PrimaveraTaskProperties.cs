using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System;
using System.ComponentModel;

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

        /// <summary>
        /// Gets the value of duration percent complete.
        /// </summary>
        public double DurationPercentComplete { get; set; }

        /// <summary>
        /// Gets the value of Physical Percent Complete.
        /// </summary>
        /// <remarks>
        /// Applicable only to activities (non-summary tasks).
        /// </remarks>
        public double PhysicalPercentComplete { get; set; }

        /// <summary>
        /// Gets the value of actual non labor units.
        /// </summary>
        public double ActualNonLaborUnits { get; set; }

        /// <summary>
        /// Gets the value of actual labor units.
        /// </summary>
        public double ActualLaborUnits { get; set; }

        /// <summary>
        /// Gets the value of units percent complete.
        /// </summary>
        public double UnitsPercentComplete { get; set; }

        /// <summary>
        /// Gets the value of remaining labor units.
        /// </summary>
        public double RemainingLaborUnits { get; set; }

        /// <summary>
        /// Gets the value of remaining non labor units.
        /// </summary>
        public double RemainingNonLaborUnits { get; set; }

        /// <summary>
        /// Gets the value of 'Duration Type' field of the activity.
        /// </summary>
        /// <remarks>
        /// Applicable only to activities (non-summary tasks).
        /// </remarks>
        [JsonProperty("DurationType", NullValueHandling = NullValueHandling.Ignore)]
        public PrimaveraDurationType DurationType { get; set; }

        /// <summary>
        /// Gets the value of 'Activity Type' field.
        /// </summary>
        /// <remarks>
        /// Applicable only to activities (non-summary tasks).
        /// </remarks>
        [JsonProperty("ActivityType", NullValueHandling = NullValueHandling.Ignore)]
        public PrimaveraActivityType ActivityType { get; set; }

        /// <summary>
        /// Gets the value of '% Complete Type' field of the activity.
        /// </summary>
        /// <remarks>
        /// Applicable only to activities (non-summary tasks).
        /// </remarks>
        [JsonProperty("PercentCompleteType", NullValueHandling = NullValueHandling.Ignore)]
        public PrimaveraPercentCompleteType PercentCompleteType { get; set; }

        /// <summary>
        /// Gets the value of actual labor cost.
        /// </summary>
        public decimal ActualLaborCost { get; set; }

        /// <summary>
        /// Gets the value of actual non labor cost.
        /// </summary>
        public decimal ActualNonlaborCost { get; set; }

        /// <summary>
        ///  Gets the value of actual material cost.
        /// </summary>
        public decimal ActualMaterialCost { get; set; }

        /// <summary>
        /// Gets the value of actual expense cost.
        /// </summary>
        public decimal ActualExpenseCost { get; set; }

        /// <summary>
        /// Gets the value of remaining expense cost.
        /// </summary>
        public decimal RemainingExpenseCost { get; set; }

        /// <summary>
        /// Gets the total value of actual costs.
        /// </summary>
        public decimal ActualTotalCost { get; set; }

        /// <summary>
        /// Gets the total value of budgeted (or planned) costs.
        /// </summary>
        public decimal BudgetedTotalCost { get; set; }

        /// <summary>
        /// Gets the value of budgeted (or planned) labor cost.
        /// </summary>
        public decimal BudgetedLaborCost { get; set; }

        /// <summary>
        /// Gets the value of budgeted (or planned) non labor cost.
        /// </summary>
        public decimal BudgetedNonlaborCost { get; set; }

        /// <summary>
        /// Gets the value of of budgeted (or planned) material cost.
        /// </summary>
        public decimal BudgetedMaterialCost { get; set; }

        /// <summary>
        /// Gets the value of budgeted (or planned) expense cost.
        /// </summary>
        public decimal BudgetedExpenseCost { get; set; }
    }
}