// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ResourceAssignment.cs">
//   Copyright (c) 2018 Aspose.Tasks for Cloud
// </copyright>
// <summary>
//   Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
// 
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
// 
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//  SOFTWARE.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Aspose.Tasks.Cloud.Sdk.Model 
{
    using System;  
    using System.Collections;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Represents a resource assignment in a project.
    /// </summary>  
    public class ResourceAssignment
    {         /// <summary>
        /// Returns or sets a task unique id to which a resource is assigned.
        /// </summary>  
        public int? TaskUid { get; set; }

        /// <summary>
        /// Returns or sets a resource unique id assigned to a task.
        /// </summary>  
        public int? ResourceUid { get; set; }

        /// <summary>
        /// Returns or sets the unique identifier of an assignment.
        /// </summary>  
        public int? Uid { get; set; }

        /// <summary>
        /// Returns or sets the amount of a work completed on an assignment.
        /// </summary>  
        public int? PercentWorkComplete { get; set; }

        /// <summary>
        /// Returns or sets the actual cost incurred on an assignment.
        /// </summary>  
        public decimal? ActualCost { get; set; }

        /// <summary>
        /// Returns or sets the actual finish date of an assignment.
        /// </summary>  
        public DateTime? ActualFinish { get; set; }

        /// <summary>
        /// Returns or sets the actual overtime cost incurred on an assignment.
        /// </summary>  
        public decimal? ActualOvertimeCost { get; set; }

        /// <summary>
        /// Returns or sets the actual amount of an overtime work incurred on an assignment.
        /// </summary>  
        public TimeSpan ActualOvertimeWork { get; set; }

        /// <summary>
        /// Returns or sets the actual start date of an assignment.
        /// </summary>  
        public DateTime? ActualStart { get; set; }

        /// <summary>
        /// Returns or sets the actual amount of a work incurred on an assignment.
        /// </summary>  
        public TimeSpan ActualWork { get; set; }

        /// <summary>
        /// Returns or sets the actual cost of a work performed on an assignment to-date.
        /// </summary>  
        public double? Acwp { get; set; }

        /// <summary>
        /// Determines whether a resource has accepted all of its assignments.
        /// </summary>  
        public bool? Confirmed { get; set; }

        /// <summary>
        /// Returns or sets the projected or scheduled cost of an assignment.
        /// </summary>  
        public decimal? Cost { get; set; }

        /// <summary>
        /// Returns or sets the cost rate table used for this assignment.
        /// </summary>  
        [JsonProperty("CostRateTableType", NullValueHandling = NullValueHandling.Ignore)]
        public RateType? CostRateTableType { get; set; }


        /// <summary>
        /// Returns or sets the difference between the cost and baseline cost of a resource.
        /// </summary>  
        public double? CostVariance { get; set; }

        /// <summary>
        /// Returns or sets the earned value cost variance.
        /// </summary>  
        public double? Cv { get; set; }

        /// <summary>
        /// Returns or sets the delay of an assignment.
        /// </summary>  
        public int? Delay { get; set; }

        /// <summary>
        /// Returns or sets the scheduled finish date of an assignment.
        /// </summary>  
        public DateTime? Finish { get; set; }

        /// <summary>
        /// Returns or sets the variance of an assignment finish date from a baseline finish date.
        /// </summary>  
        public int? FinishVariance { get; set; }

        /// <summary>
        /// Returns or sets the title of the hyperlink associated with an assignment.
        /// </summary>  
        public string Hyperlink { get; set; }

        /// <summary>
        /// Returns or sets the hyperlink associated with an assignment.
        /// </summary>  
        public string HyperlinkAddress { get; set; }

        /// <summary>
        /// Returns or sets the document bookmark of the hyperlink associated with an assignment.
        /// </summary>  
        public string HyperlinkSubAddress { get; set; }

        /// <summary>
        /// Returns or sets the variance of an assignment work from the baseline work as minutes.
        /// </summary>  
        public double? WorkVariance { get; set; }

        /// <summary>
        /// Determines whether the Units have Fixed Rate.
        /// </summary>  
        public bool? HasFixedRateUnits { get; set; }

        /// <summary>
        /// Determines whether the consumption of an assigned material resource occurs in a single, fixed amount.
        /// </summary>  
        public bool? FixedMaterial { get; set; }

        /// <summary>
        /// Returns or sets the delay caused by leveling.
        /// </summary>  
        public int? LevelingDelay { get; set; }

        /// <summary>
        /// Returns or sets the duration format of a delay.
        /// </summary>  
        [JsonProperty("LevelingDelayFormat", NullValueHandling = NullValueHandling.Ignore)]
        public TimeUnitType? LevelingDelayFormat { get; set; }


        /// <summary>
        /// Determines whether the Project is linked to another OLE object.
        /// </summary>  
        public bool? LinkedFields { get; set; }

        /// <summary>
        /// Determines whether the assignment is a milestone.
        /// </summary>  
        public bool? Milestone { get; set; }

        /// <summary>
        /// Returns or sets the text notes associated with an assignment.
        /// </summary>  
        public string Notes { get; set; }

        /// <summary>
        /// Determines whether the assignment is overallocated.
        /// </summary>  
        public bool? Overallocated { get; set; }

        /// <summary>
        /// Returns or sets the sum of the actual and remaining overtime cost of an assignment.
        /// </summary>  
        public decimal? OvertimeCost { get; set; }

        /// <summary>
        /// Returns or sets the scheduled overtime work of an assignment.
        /// </summary>  
        public TimeSpan OvertimeWork { get; set; }

        /// <summary>
        /// Returns or sets the largest number of a resource's units assigned to a task.
        /// </summary>  
        public double? PeakUnits { get; set; }

        /// <summary>
        /// Returns or sets the amount of a non-overtime work scheduled for an assignment.
        /// </summary>  
        public TimeSpan RegularWork { get; set; }

        /// <summary>
        /// Returns or sets the remaining projected cost of completing an assignment.
        /// </summary>  
        public decimal? RemainingCost { get; set; }

        /// <summary>
        /// Returns or sets the remaining projected overtime cost of completing an assignment.
        /// </summary>  
        public decimal? RemainingOvertimeCost { get; set; }

        /// <summary>
        /// Returns or sets the remaining overtime work scheduled to complete an assignment.
        /// </summary>  
        public TimeSpan RemainingOvertimeWork { get; set; }

        /// <summary>
        /// Returns or sets the remaining work scheduled to complete an assignment.
        /// </summary>  
        public TimeSpan RemainingWork { get; set; }

        /// <summary>
        /// Determines whether the response has been received for a TeamAssign message.
        /// </summary>  
        public bool? ResponsePending { get; set; }

        /// <summary>
        /// Returns or sets the scheduled start date of an assignment.
        /// </summary>  
        public DateTime? Start { get; set; }

        /// <summary>
        /// Returns or sets the date when assignment is stopped.
        /// </summary>  
        public DateTime? Stop { get; set; }

        /// <summary>
        /// Returns or sets the date when assignment is resumed.
        /// </summary>  
        public DateTime? Resume { get; set; }

        /// <summary>
        /// Returns or sets the variance of an assignment start date from a baseline start date.
        /// </summary>  
        public int? StartVariance { get; set; }

        /// <summary>
        /// Determines whether the task is a summary task.
        /// </summary>  
        public bool? Summary { get; set; }

        /// <summary>
        /// Returns or sets the earned value schedule variance, through the project status date.
        /// </summary>  
        public double? Sv { get; set; }

        /// <summary>
        /// Returns or sets the number of units for an assignment.
        /// </summary>  
        public double? Units { get; set; }

        /// <summary>
        /// Determines whether the resource assigned to a task needs to be updated as to the status of the task.
        /// </summary>  
        public bool? UpdateNeeded { get; set; }

        /// <summary>
        /// Returns or sets the difference between basline cost and total cost. Read/write .
        /// </summary>  
        public double? Vac { get; set; }

        /// <summary>
        /// Returns or sets the amount of scheduled work for an assignment. Read/write .
        /// </summary>  
        public TimeSpan Work { get; set; }

        /// <summary>
        /// Returns or sets the work contour of an assignment.
        /// </summary>  
        [JsonProperty("WorkContour", NullValueHandling = NullValueHandling.Ignore)]
        public WorkContourType? WorkContour { get; set; }


        /// <summary>
        /// Returns or sets the budgeted cost of a work on assignment.
        /// </summary>  
        public double? Bcws { get; set; }

        /// <summary>
        /// Returns or sets the budgeted cost of a work performed on assignment to-date.
        /// </summary>  
        public double? Bcwp { get; set; }

        /// <summary>
        /// Returns or sets the booking type of an assignment.
        /// </summary>  
        [JsonProperty("BookingType", NullValueHandling = NullValueHandling.Ignore)]
        public BookingType? BookingType { get; set; }


        /// <summary>
        /// Returns or sets the duration through which actual work is protected.
        /// </summary>  
        public TimeSpan ActualWorkProtected { get; set; }

        /// <summary>
        /// Returns or sets the duration through which actual overtime work is protected.
        /// </summary>  
        public TimeSpan ActualOvertimeWorkProtected { get; set; }

        /// <summary>
        /// Returns or sets the date that the assignment was created.
        /// </summary>  
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// Returns or sets the name of an assignment owner.
        /// </summary>  
        public string AssnOwner { get; set; }

        /// <summary>
        /// Returns or sets the Guid of an assignment owner.
        /// </summary>  
        public string AssnOwnerGuid { get; set; }

        /// <summary>
        /// Returns or sets the budgeted cost of resources on an assignment.
        /// </summary>  
        public decimal? BudgetCost { get; set; }

        /// <summary>
        /// Returns or sets the budgeted work amount for a work or material resources on an assignment.
        /// </summary>  
        public TimeSpan BudgetWork { get; set; }

        /// <summary>
        /// Returns the time unit for the usage rate of the material resource assignment.
        /// </summary>  
        [JsonProperty("RateScale", NullValueHandling = NullValueHandling.Ignore)]
        public RateScaleType? RateScale { get; set; }


        /// <summary>
        /// List of ResourceAssignment's Baseline values.
        /// </summary>  
        public List<AssignmentBaseline> Baselines { get; set; }

        /// <summary>
        /// ResourceAssignment extended attributes.
        /// </summary>  
        public List<ExtendedAttribute> ExtendedAttributes { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
            var sb = new StringBuilder();
            sb.Append("class ResourceAssignment {\n");
            sb.Append("  TaskUid: ").Append(this.TaskUid).Append("\n");
            sb.Append("  ResourceUid: ").Append(this.ResourceUid).Append("\n");
            sb.Append("  Uid: ").Append(this.Uid).Append("\n");
            sb.Append("  PercentWorkComplete: ").Append(this.PercentWorkComplete).Append("\n");
            sb.Append("  ActualCost: ").Append(this.ActualCost).Append("\n");
            sb.Append("  ActualFinish: ").Append(this.ActualFinish).Append("\n");
            sb.Append("  ActualOvertimeCost: ").Append(this.ActualOvertimeCost).Append("\n");
            sb.Append("  ActualOvertimeWork: ").Append(this.ActualOvertimeWork).Append("\n");
            sb.Append("  ActualStart: ").Append(this.ActualStart).Append("\n");
            sb.Append("  ActualWork: ").Append(this.ActualWork).Append("\n");
            sb.Append("  Acwp: ").Append(this.Acwp).Append("\n");
            sb.Append("  Confirmed: ").Append(this.Confirmed).Append("\n");
            sb.Append("  Cost: ").Append(this.Cost).Append("\n");
            sb.Append("  CostRateTableType: ").Append(this.CostRateTableType).Append("\n");
            sb.Append("  CostVariance: ").Append(this.CostVariance).Append("\n");
            sb.Append("  Cv: ").Append(this.Cv).Append("\n");
            sb.Append("  Delay: ").Append(this.Delay).Append("\n");
            sb.Append("  Finish: ").Append(this.Finish).Append("\n");
            sb.Append("  FinishVariance: ").Append(this.FinishVariance).Append("\n");
            sb.Append("  Hyperlink: ").Append(this.Hyperlink).Append("\n");
            sb.Append("  HyperlinkAddress: ").Append(this.HyperlinkAddress).Append("\n");
            sb.Append("  HyperlinkSubAddress: ").Append(this.HyperlinkSubAddress).Append("\n");
            sb.Append("  WorkVariance: ").Append(this.WorkVariance).Append("\n");
            sb.Append("  HasFixedRateUnits: ").Append(this.HasFixedRateUnits).Append("\n");
            sb.Append("  FixedMaterial: ").Append(this.FixedMaterial).Append("\n");
            sb.Append("  LevelingDelay: ").Append(this.LevelingDelay).Append("\n");
            sb.Append("  LevelingDelayFormat: ").Append(this.LevelingDelayFormat).Append("\n");
            sb.Append("  LinkedFields: ").Append(this.LinkedFields).Append("\n");
            sb.Append("  Milestone: ").Append(this.Milestone).Append("\n");
            sb.Append("  Notes: ").Append(this.Notes).Append("\n");
            sb.Append("  Overallocated: ").Append(this.Overallocated).Append("\n");
            sb.Append("  OvertimeCost: ").Append(this.OvertimeCost).Append("\n");
            sb.Append("  OvertimeWork: ").Append(this.OvertimeWork).Append("\n");
            sb.Append("  PeakUnits: ").Append(this.PeakUnits).Append("\n");
            sb.Append("  RegularWork: ").Append(this.RegularWork).Append("\n");
            sb.Append("  RemainingCost: ").Append(this.RemainingCost).Append("\n");
            sb.Append("  RemainingOvertimeCost: ").Append(this.RemainingOvertimeCost).Append("\n");
            sb.Append("  RemainingOvertimeWork: ").Append(this.RemainingOvertimeWork).Append("\n");
            sb.Append("  RemainingWork: ").Append(this.RemainingWork).Append("\n");
            sb.Append("  ResponsePending: ").Append(this.ResponsePending).Append("\n");
            sb.Append("  Start: ").Append(this.Start).Append("\n");
            sb.Append("  Stop: ").Append(this.Stop).Append("\n");
            sb.Append("  Resume: ").Append(this.Resume).Append("\n");
            sb.Append("  StartVariance: ").Append(this.StartVariance).Append("\n");
            sb.Append("  Summary: ").Append(this.Summary).Append("\n");
            sb.Append("  Sv: ").Append(this.Sv).Append("\n");
            sb.Append("  Units: ").Append(this.Units).Append("\n");
            sb.Append("  UpdateNeeded: ").Append(this.UpdateNeeded).Append("\n");
            sb.Append("  Vac: ").Append(this.Vac).Append("\n");
            sb.Append("  Work: ").Append(this.Work).Append("\n");
            sb.Append("  WorkContour: ").Append(this.WorkContour).Append("\n");
            sb.Append("  Bcws: ").Append(this.Bcws).Append("\n");
            sb.Append("  Bcwp: ").Append(this.Bcwp).Append("\n");
            sb.Append("  BookingType: ").Append(this.BookingType).Append("\n");
            sb.Append("  ActualWorkProtected: ").Append(this.ActualWorkProtected).Append("\n");
            sb.Append("  ActualOvertimeWorkProtected: ").Append(this.ActualOvertimeWorkProtected).Append("\n");
            sb.Append("  CreationDate: ").Append(this.CreationDate).Append("\n");
            sb.Append("  AssnOwner: ").Append(this.AssnOwner).Append("\n");
            sb.Append("  AssnOwnerGuid: ").Append(this.AssnOwnerGuid).Append("\n");
            sb.Append("  BudgetCost: ").Append(this.BudgetCost).Append("\n");
            sb.Append("  BudgetWork: ").Append(this.BudgetWork).Append("\n");
            sb.Append("  RateScale: ").Append(this.RateScale).Append("\n");
            sb.Append("  Baselines: ").Append(this.Baselines).Append("\n");
            sb.Append("  ExtendedAttributes: ").Append(this.ExtendedAttributes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}