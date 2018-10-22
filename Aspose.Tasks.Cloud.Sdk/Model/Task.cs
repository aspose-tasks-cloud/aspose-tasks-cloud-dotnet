// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Task.cs">
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
    /// Represents project task.
    /// </summary>
    public class Task
    { 
        /// <summary>
        /// The unique id of a task.
        /// </summary>  
        public int? Uid { get; set; }

        /// <summary>
        /// The position of a task in collection.
        /// </summary>  
        public int? Id { get; set; }

        /// <summary>
        /// The name of a task.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// The duration of a task entered by the user as a text.
        /// </summary>  
        public string DurationText { get; set; }

        /// <summary>
        /// The duration of a task.
        /// </summary>  
        public TimeSpan Duration { get; set; }

        /// <summary>
        /// The start date of a task.
        /// </summary>  
        public DateTime? Start { get; set; }

        /// <summary>
        /// The finish date of a task.
        /// </summary>  
        public DateTime? Finish { get; set; }

        /// <summary>
        /// Returns the task's start text.
        /// </summary>  
        public string StartText { get; set; }

        /// <summary>
        /// Returns the task's finish text.
        /// </summary>  
        public string FinishText { get; set; }

        /// <summary>
        /// The percent complete of a task.
        /// </summary>  
        public int? PercentComplete { get; set; }

        /// <summary>
        /// The percent work complete of a task.
        /// </summary>  
        public int? PercentWorkComplete { get; set; }

        /// <summary>
        /// Determines if a task is active.
        /// </summary>  
        public bool? IsActive { get; set; }

        /// <summary>
        /// The actual cost of a task.
        /// </summary>  
        public decimal? ActualCost { get; set; }

        /// <summary>
        /// The actual duration of a task.
        /// </summary>  
        public TimeSpan ActualDuration { get; set; }

        /// <summary>
        /// The actual finish date of a task.
        /// </summary>  
        public DateTime? ActualFinish { get; set; }

        /// <summary>
        /// The actual overtime cost of a task.
        /// </summary>  
        public decimal? ActualOvertimeCost { get; set; }

        /// <summary>
        /// The actual overtime work of a task.
        /// </summary>  
        public TimeSpan ActualOvertimeWork { get; set; }

        /// <summary>
        /// The duration through which actual work is protected. Reading supported for XML format only.
        /// </summary>  
        public TimeSpan ActualWorkProtected { get; set; }

        /// <summary>
        /// The duration through which actual overtime work is protected. Reading supported for XML format only.
        /// </summary>  
        public TimeSpan ActualOvertimeWorkProtected { get; set; }

        /// <summary>
        /// The actual start date of a task.
        /// </summary>  
        public DateTime? ActualStart { get; set; }

        /// <summary>
        /// The amount of budgeted work for a project root task.
        /// </summary>  
        public TimeSpan BudgetWork { get; set; }

        /// <summary>
        /// The amount of budgeted cost for a project root task.
        /// </summary>  
        public decimal? BudgetCost { get; set; }

        /// <summary>
        /// Shows the specific date associated with certain constraint types,  such as Must Start On, Must Finish On, Start No Earlier Than, Start No Later Than, Finish No Earlier Than, and Finish No Later Than.
        /// </summary>  
        public DateTime? ConstraintDate { get; set; }

        /// <summary>
        /// Provides choices for the type of constraint that can be applied for scheduling a task.
        /// </summary>  
        [JsonProperty("ConstraintType", NullValueHandling = NullValueHandling.Ignore)]
        public ConstraintType ConstraintType { get; set; }


        /// <summary>
        /// The contact person for a task.
        /// </summary>  
        public string Contact { get; set; }

        /// <summary>
        /// The projected or scheduled cost of a task.
        /// </summary>  
        public decimal? Cost { get; set; }

        /// <summary>
        /// The difference between the baseline cost and total cost for a task.
        /// </summary>  
        public double? Cv { get; set; }

        /// <summary>
        /// The deadline for a task to be completed.
        /// </summary>  
        public DateTime? Deadline { get; set; }

        /// <summary>
        /// Contains the difference between the total duration of a task and the baseline duration of a task.
        /// </summary>  
        public TimeSpan DurationVariance { get; set; }

        /// <summary>
        /// The early finish date of a task.
        /// </summary>  
        public DateTime? EarlyFinish { get; set; }

        /// <summary>
        /// The early start date of a task.
        /// </summary>  
        public DateTime? EarlyStart { get; set; }

        /// <summary>
        /// Determines whether a task is effort-driven.
        /// </summary>  
        public bool? IsEffortDriven { get; set; }

        /// <summary>
        /// Determines whether a task is external.
        /// </summary>  
        public bool? IsExternalTask { get; set; }

        /// <summary>
        /// The source location and task identifier of an external task.
        /// </summary>  
        public string ExternalTaskProject { get; set; }

        /// <summary>
        /// If a task is an external task the property contains the task's external Id.  type.
        /// </summary>  
        public int? ExternalId { get; set; }

        /// <summary>
        /// Contains the duration between the Early Finish and Late Finish dates.
        /// </summary>  
        public int? FinishSlack { get; set; }

        /// <summary>
        /// The variance of the task finish date from the baseline finish date as minutes.
        /// </summary>  
        public int? FinishVariance { get; set; }

        /// <summary>
        /// The fixed cost of a task.
        /// </summary>  
        public double? FixedCost { get; set; }

        /// <summary>
        /// Determines how the fixed cost is accrued against a task.
        /// </summary>  
        [JsonProperty("FixedCostAccrual", NullValueHandling = NullValueHandling.Ignore)]
        public CostAccrualType FixedCostAccrual { get; set; }


        /// <summary>
        /// The amount of a free slack.
        /// </summary>  
        public int? FreeSlack { get; set; }

        /// <summary>
        /// Gets or sets GUID
        /// </summary>  
        public string GUID { get; set; }

        /// <summary>
        /// Determines whether the GANTT bar of a task is hidden when displayed in Microsoft Project.
        /// </summary>  
        public bool? HideBar { get; set; }

        /// <summary>
        /// Determines whether a task ignores the resource calendar.
        /// </summary>  
        public bool? IgnoreResourceCalendar { get; set; }

        /// <summary>
        /// The late finish date of a task.
        /// </summary>  
        public DateTime? LateFinish { get; set; }

        /// <summary>
        /// The late start date of a task.
        /// </summary>  
        public DateTime? LateStart { get; set; }

        /// <summary>
        /// Gets or sets IsLevelAssignments
        /// </summary>  
        public bool? IsLevelAssignments { get; set; }

        /// <summary>
        /// Gets or sets CanLevelingSplit
        /// </summary>  
        public bool? CanLevelingSplit { get; set; }

        /// <summary>
        /// The delay caused by leveling a task.
        /// </summary>  
        public int? LevelingDelay { get; set; }

        /// <summary>
        /// Shows whether a task is marked for further action or identification of some kind.             
        /// </summary>  
        public bool? IsMarked { get; set; }

        /// <summary>
        /// Determines whether a task is a milestone.
        /// </summary>  
        public bool? IsMilestone { get; set; }

        /// <summary>
        /// Determines whether a task is in the critical chain.
        /// </summary>  
        public bool? IsCritical { get; set; }

        /// <summary>
        /// Determines whether a task is an inserted project.
        /// </summary>  
        public bool? IsSubproject { get; set; }

        /// <summary>
        /// Determines whether a subproject is read-only.
        /// </summary>  
        public bool? IsSubprojectReadOnly { get; set; }

        /// <summary>
        /// The source location of a subproject. Read/write String.
        /// </summary>  
        public string SubprojectName { get; set; }

        /// <summary>
        /// Determines whether a task is a summary task.
        /// </summary>  
        public bool? IsSummary { get; set; }

        /// <summary>
        /// Unique ids of all subtasks.
        /// </summary>  
        public List<int?> SubtasksUids { get; set; }

        /// <summary>
        /// The outline level of a task.
        /// </summary>  
        public int? OutlineLevel { get; set; }

        /// <summary>
        /// Gets or sets IsOverAllocated
        /// </summary>  
        public bool? IsOverAllocated { get; set; }

        /// <summary>
        /// Determines whether a task is estimated.
        /// </summary>  
        public bool? IsEstimated { get; set; }

        /// <summary>
        /// The sum of an actual and remaining overtime cost of a task.
        /// </summary>  
        public decimal? OvertimeCost { get; set; }

        /// <summary>
        /// The amount of an overtime work scheduled for a task.
        /// </summary>  
        public TimeSpan OvertimeWork { get; set; }

        /// <summary>
        /// The percentage complete value entered by the Project Manager.
        /// </summary>  
        public int? PhysicalPercentComplete { get; set; }

        /// <summary>
        /// Gets or sets PreLeveledFinish
        /// </summary>  
        public DateTime? PreLeveledFinish { get; set; }

        /// <summary>
        /// Gets or sets PreLeveledStart
        /// </summary>  
        public DateTime? PreLeveledStart { get; set; }

        /// <summary>
        /// Determines whether a task is a recurring task.
        /// </summary>  
        public bool? IsRecurring { get; set; }

        /// <summary>
        /// The amount of non-overtime work scheduled for a task.
        /// </summary>  
        public TimeSpan RegularWork { get; set; }

        /// <summary>
        /// The remaining projected cost of completing a task.
        /// </summary>  
        public decimal? RemainingCost { get; set; }

        /// <summary>
        /// The amount of time required to complete the unfinished portion of a task.
        /// </summary>  
        public TimeSpan RemainingDuration { get; set; }

        /// <summary>
        /// The remaining overtime cost projected to finish a task.
        /// </summary>  
        public decimal? RemainingOvertimeCost { get; set; }

        /// <summary>
        /// The remaining overtime work scheduled to finish a task.
        /// </summary>  
        public TimeSpan RemainingOvertimeWork { get; set; }

        /// <summary>
        /// The remaining work scheduled to complete a task.
        /// </summary>  
        public TimeSpan RemainingWork { get; set; }

        /// <summary>
        /// The date when a task resumed.
        /// </summary>  
        public DateTime? Resume { get; set; }

        /// <summary>
        /// Determines whether a task can be resumed.
        /// </summary>  
        public bool? IsResumeValid { get; set; }

        /// <summary>
        /// The date that represents the end of the actual portion of a task.
        /// </summary>  
        public DateTime? Stop { get; set; }

        /// <summary>
        /// Determines whether a task is rolled up.
        /// </summary>  
        public bool? IsRollup { get; set; }

        /// <summary>
        /// Returns the task's start slack.
        /// </summary>  
        public int? StartSlack { get; set; }

        /// <summary>
        /// The variance of the task start date from the baseline start date as minutes. 
        /// </summary>  
        public int? StartVariance { get; set; }

        /// <summary>
        /// The unique id of task calendar.
        /// </summary>  
        public int? CalendarUid { get; set; }

        /// <summary>
        /// Determines whether a task is manually scheduled.
        /// </summary>  
        public bool? IsManual { get; set; }

        /// <summary>
        /// Defines manually scheduled start of a task.
        /// </summary>  
        public DateTime? ManualStart { get; set; }

        /// <summary>
        /// Defines manually scheduled finish of a task.
        /// </summary>  
        public DateTime? ManualFinish { get; set; }

        /// <summary>
        /// Defines manually scheduled duration of a task.
        /// </summary>  
        public TimeSpan ManualDuration { get; set; }

        /// <summary>
        /// The amount of a total slack.
        /// </summary>  
        public int? TotalSlack { get; set; }

        /// <summary>
        /// The type of a task.
        /// </summary>  
        [JsonProperty("Type", NullValueHandling = NullValueHandling.Ignore)]
        public TaskType Type { get; set; }


        /// <summary>
        /// The work breakdown structure code of a task.
        /// </summary>  
        public string Wbs { get; set; }

        /// <summary>
        /// The priority of a task from 0 to 1000.
        /// </summary>  
        public int? Priority { get; set; }

        /// <summary>
        /// The amount of the scheduled work for a task.
        /// </summary>  
        public TimeSpan Work { get; set; }

        /// <summary>
        /// The variance of the task work from the baseline task work as minutes.
        /// </summary>  
        public double? WorkVariance { get; set; }

        /// <summary>
        /// Notes' plain text extracted from RTF data.
        /// </summary>  
        public string NotesText { get; set; }

        /// <summary>
        /// The text notes in RTF format.
        /// </summary>  
        public string NotesRTF { get; set; }

        /// <summary>
        /// Gets or sets Acwp
        /// </summary>  
        public double? Acwp { get; set; }

        /// <summary>
        /// Gets or sets Bcws
        /// </summary>  
        public double? Bcws { get; set; }

        /// <summary>
        /// Gets or sets Bcwp
        /// </summary>  
        public double? Bcwp { get; set; }

        /// <summary>
        /// LevelingDelayFormat
        /// </summary>  
        [JsonProperty("LevelingDelayFormat", NullValueHandling = NullValueHandling.Ignore)]
        public TimeUnitType LevelingDelayFormat { get; set; }


        /// <summary>
        /// The task Uid numbers for the predecessor tasks on which the task depends before it can be started or finished.
        /// </summary>  
        public string Predecessors { get; set; }

        /// <summary>
        /// The task Uid numbers for the successor tasks to a task.
        /// </summary>  
        public string Successors { get; set; }

        /// <summary>
        /// Indicates whether to hide the schedule conflict warning indicator in Microsoft Project.             
        /// </summary>  
        public bool? IgnoreWarnings { get; set; }

        /// <summary>
        /// Determines whether a summary task is expanded or not in GanttChart view.
        /// </summary>  
        public bool? IsExpanded { get; set; }

        /// <summary>
        /// Specifies whether a task should be displayed on a timeline view.
        /// </summary>  
        public bool? DisplayOnTimeline { get; set; }

        /// <summary>
        /// Determines whether the task should be displayed as a summary task. Reading supported for XML format only.
        /// </summary>  
        public bool? DisplayAsSummary { get; set; }

        /// <summary>
        /// The title or explanatory text for a hyperlink associated with a task.
        /// </summary>  
        public string Hyperlink { get; set; }

        /// <summary>
        /// The address for a hyperlink associated with a task.
        /// </summary>  
        public string HyperlinkAddress { get; set; }

        /// <summary>
        /// The specific location in a document in a hyperlink associated with a task.  type.
        /// </summary>  
        public string HyperlinkSubAddress { get; set; }

        /// <summary>
        /// Determines whether the % Complete or Physical % Complete field should be used to calculate budgeted cost of work performed (BCWP).
        /// </summary>  
        [JsonProperty("EarnedValueMethod", NullValueHandling = NullValueHandling.Ignore)]
        public EarnedValueMethodType EarnedValueMethod { get; set; }


        /// <summary>
        /// Determines whether the current task should be published to Project Server with the rest of the project.
        /// </summary>  
        public bool? IsPublished { get; set; }

        /// <summary>
        /// The name of the enterprise resource who is to receive status updates for the current task from resources.
        /// </summary>  
        public string StatusManager { get; set; }

        /// <summary>
        /// The start date of a delivery. Reading supported for XML format only.
        /// </summary>  
        public DateTime? CommitmentStart { get; set; }

        /// <summary>
        /// The finish date of a delivery. Reading supported for XML format only.
        /// </summary>  
        public DateTime? CommitmentFinish { get; set; }

        /// <summary>
        /// Determines whether a task has an associated delivery or a dependency on an associated delivery. Reading supported for XML format only.
        /// </summary>  
        public int? CommitmentType { get; set; }

        /// <summary>
        /// Gets or sets the collection of baseline values of the task.
        /// </summary>  
        public List<TaskBaseline> Baselines { get; set; }

        /// <summary>
        /// Task extended attributes.
        /// </summary>  
        public List<ExtendedAttribute> ExtendedAttributes { get; set; }

        /// <summary>
        /// Task outline codes.
        /// </summary>  
        public List<OutlineCode> OutlineCodes { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
            var sb = new StringBuilder();
            sb.Append("class Task {\n");
            sb.Append("  Uid: ").Append(this.Uid).Append("\n");
            sb.Append("  Id: ").Append(this.Id).Append("\n");
            sb.Append("  Name: ").Append(this.Name).Append("\n");
            sb.Append("  DurationText: ").Append(this.DurationText).Append("\n");
            sb.Append("  Duration: ").Append(this.Duration).Append("\n");
            sb.Append("  Start: ").Append(this.Start).Append("\n");
            sb.Append("  Finish: ").Append(this.Finish).Append("\n");
            sb.Append("  StartText: ").Append(this.StartText).Append("\n");
            sb.Append("  FinishText: ").Append(this.FinishText).Append("\n");
            sb.Append("  PercentComplete: ").Append(this.PercentComplete).Append("\n");
            sb.Append("  PercentWorkComplete: ").Append(this.PercentWorkComplete).Append("\n");
            sb.Append("  IsActive: ").Append(this.IsActive).Append("\n");
            sb.Append("  ActualCost: ").Append(this.ActualCost).Append("\n");
            sb.Append("  ActualDuration: ").Append(this.ActualDuration).Append("\n");
            sb.Append("  ActualFinish: ").Append(this.ActualFinish).Append("\n");
            sb.Append("  ActualOvertimeCost: ").Append(this.ActualOvertimeCost).Append("\n");
            sb.Append("  ActualOvertimeWork: ").Append(this.ActualOvertimeWork).Append("\n");
            sb.Append("  ActualWorkProtected: ").Append(this.ActualWorkProtected).Append("\n");
            sb.Append("  ActualOvertimeWorkProtected: ").Append(this.ActualOvertimeWorkProtected).Append("\n");
            sb.Append("  ActualStart: ").Append(this.ActualStart).Append("\n");
            sb.Append("  BudgetWork: ").Append(this.BudgetWork).Append("\n");
            sb.Append("  BudgetCost: ").Append(this.BudgetCost).Append("\n");
            sb.Append("  ConstraintDate: ").Append(this.ConstraintDate).Append("\n");
            sb.Append("  ConstraintType: ").Append(this.ConstraintType).Append("\n");
            sb.Append("  Contact: ").Append(this.Contact).Append("\n");
            sb.Append("  Cost: ").Append(this.Cost).Append("\n");
            sb.Append("  Cv: ").Append(this.Cv).Append("\n");
            sb.Append("  Deadline: ").Append(this.Deadline).Append("\n");
            sb.Append("  DurationVariance: ").Append(this.DurationVariance).Append("\n");
            sb.Append("  EarlyFinish: ").Append(this.EarlyFinish).Append("\n");
            sb.Append("  EarlyStart: ").Append(this.EarlyStart).Append("\n");
            sb.Append("  IsEffortDriven: ").Append(this.IsEffortDriven).Append("\n");
            sb.Append("  IsExternalTask: ").Append(this.IsExternalTask).Append("\n");
            sb.Append("  ExternalTaskProject: ").Append(this.ExternalTaskProject).Append("\n");
            sb.Append("  ExternalId: ").Append(this.ExternalId).Append("\n");
            sb.Append("  FinishSlack: ").Append(this.FinishSlack).Append("\n");
            sb.Append("  FinishVariance: ").Append(this.FinishVariance).Append("\n");
            sb.Append("  FixedCost: ").Append(this.FixedCost).Append("\n");
            sb.Append("  FixedCostAccrual: ").Append(this.FixedCostAccrual).Append("\n");
            sb.Append("  FreeSlack: ").Append(this.FreeSlack).Append("\n");
            sb.Append("  GUID: ").Append(this.GUID).Append("\n");
            sb.Append("  HideBar: ").Append(this.HideBar).Append("\n");
            sb.Append("  IgnoreResourceCalendar: ").Append(this.IgnoreResourceCalendar).Append("\n");
            sb.Append("  LateFinish: ").Append(this.LateFinish).Append("\n");
            sb.Append("  LateStart: ").Append(this.LateStart).Append("\n");
            sb.Append("  IsLevelAssignments: ").Append(this.IsLevelAssignments).Append("\n");
            sb.Append("  CanLevelingSplit: ").Append(this.CanLevelingSplit).Append("\n");
            sb.Append("  LevelingDelay: ").Append(this.LevelingDelay).Append("\n");
            sb.Append("  IsMarked: ").Append(this.IsMarked).Append("\n");
            sb.Append("  IsMilestone: ").Append(this.IsMilestone).Append("\n");
            sb.Append("  IsCritical: ").Append(this.IsCritical).Append("\n");
            sb.Append("  IsSubproject: ").Append(this.IsSubproject).Append("\n");
            sb.Append("  IsSubprojectReadOnly: ").Append(this.IsSubprojectReadOnly).Append("\n");
            sb.Append("  SubprojectName: ").Append(this.SubprojectName).Append("\n");
            sb.Append("  IsSummary: ").Append(this.IsSummary).Append("\n");
            sb.Append("  SubtasksUids: ").Append(this.SubtasksUids).Append("\n");
            sb.Append("  OutlineLevel: ").Append(this.OutlineLevel).Append("\n");
            sb.Append("  IsOverAllocated: ").Append(this.IsOverAllocated).Append("\n");
            sb.Append("  IsEstimated: ").Append(this.IsEstimated).Append("\n");
            sb.Append("  OvertimeCost: ").Append(this.OvertimeCost).Append("\n");
            sb.Append("  OvertimeWork: ").Append(this.OvertimeWork).Append("\n");
            sb.Append("  PhysicalPercentComplete: ").Append(this.PhysicalPercentComplete).Append("\n");
            sb.Append("  PreLeveledFinish: ").Append(this.PreLeveledFinish).Append("\n");
            sb.Append("  PreLeveledStart: ").Append(this.PreLeveledStart).Append("\n");
            sb.Append("  IsRecurring: ").Append(this.IsRecurring).Append("\n");
            sb.Append("  RegularWork: ").Append(this.RegularWork).Append("\n");
            sb.Append("  RemainingCost: ").Append(this.RemainingCost).Append("\n");
            sb.Append("  RemainingDuration: ").Append(this.RemainingDuration).Append("\n");
            sb.Append("  RemainingOvertimeCost: ").Append(this.RemainingOvertimeCost).Append("\n");
            sb.Append("  RemainingOvertimeWork: ").Append(this.RemainingOvertimeWork).Append("\n");
            sb.Append("  RemainingWork: ").Append(this.RemainingWork).Append("\n");
            sb.Append("  Resume: ").Append(this.Resume).Append("\n");
            sb.Append("  IsResumeValid: ").Append(this.IsResumeValid).Append("\n");
            sb.Append("  Stop: ").Append(this.Stop).Append("\n");
            sb.Append("  IsRollup: ").Append(this.IsRollup).Append("\n");
            sb.Append("  StartSlack: ").Append(this.StartSlack).Append("\n");
            sb.Append("  StartVariance: ").Append(this.StartVariance).Append("\n");
            sb.Append("  CalendarUid: ").Append(this.CalendarUid).Append("\n");
            sb.Append("  IsManual: ").Append(this.IsManual).Append("\n");
            sb.Append("  ManualStart: ").Append(this.ManualStart).Append("\n");
            sb.Append("  ManualFinish: ").Append(this.ManualFinish).Append("\n");
            sb.Append("  ManualDuration: ").Append(this.ManualDuration).Append("\n");
            sb.Append("  TotalSlack: ").Append(this.TotalSlack).Append("\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  Wbs: ").Append(this.Wbs).Append("\n");
            sb.Append("  Priority: ").Append(this.Priority).Append("\n");
            sb.Append("  Work: ").Append(this.Work).Append("\n");
            sb.Append("  WorkVariance: ").Append(this.WorkVariance).Append("\n");
            sb.Append("  NotesText: ").Append(this.NotesText).Append("\n");
            sb.Append("  NotesRTF: ").Append(this.NotesRTF).Append("\n");
            sb.Append("  Acwp: ").Append(this.Acwp).Append("\n");
            sb.Append("  Bcws: ").Append(this.Bcws).Append("\n");
            sb.Append("  Bcwp: ").Append(this.Bcwp).Append("\n");
            sb.Append("  LevelingDelayFormat: ").Append(this.LevelingDelayFormat).Append("\n");
            sb.Append("  Predecessors: ").Append(this.Predecessors).Append("\n");
            sb.Append("  Successors: ").Append(this.Successors).Append("\n");
            sb.Append("  IgnoreWarnings: ").Append(this.IgnoreWarnings).Append("\n");
            sb.Append("  IsExpanded: ").Append(this.IsExpanded).Append("\n");
            sb.Append("  DisplayOnTimeline: ").Append(this.DisplayOnTimeline).Append("\n");
            sb.Append("  DisplayAsSummary: ").Append(this.DisplayAsSummary).Append("\n");
            sb.Append("  Hyperlink: ").Append(this.Hyperlink).Append("\n");
            sb.Append("  HyperlinkAddress: ").Append(this.HyperlinkAddress).Append("\n");
            sb.Append("  HyperlinkSubAddress: ").Append(this.HyperlinkSubAddress).Append("\n");
            sb.Append("  EarnedValueMethod: ").Append(this.EarnedValueMethod).Append("\n");
            sb.Append("  IsPublished: ").Append(this.IsPublished).Append("\n");
            sb.Append("  StatusManager: ").Append(this.StatusManager).Append("\n");
            sb.Append("  CommitmentStart: ").Append(this.CommitmentStart).Append("\n");
            sb.Append("  CommitmentFinish: ").Append(this.CommitmentFinish).Append("\n");
            sb.Append("  CommitmentType: ").Append(this.CommitmentType).Append("\n");
            sb.Append("  Baselines: ").Append(this.Baselines).Append("\n");
            sb.Append("  ExtendedAttributes: ").Append(this.ExtendedAttributes).Append("\n");
            sb.Append("  OutlineCodes: ").Append(this.OutlineCodes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}