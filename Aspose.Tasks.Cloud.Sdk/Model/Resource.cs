// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Resource.cs">
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
    /// Represents a project resource.
    /// </summary>
    public class Resource
    { 
        /// <summary>
        /// The name of a resource.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// The unique identifier of a resource.
        /// </summary>  
        public int? Uid { get; set; }

        /// <summary>
        /// The position identifier of a resource within the list of resources.
        /// </summary>  
        public int? Id { get; set; }

        /// <summary>
        /// Contains the generated unique identification code for the resource.             
        /// </summary>  
        public string Guid { get; set; }

        /// <summary>
        /// The type of a resource.
        /// </summary>  
        [JsonProperty("Type", NullValueHandling = NullValueHandling.Ignore)]
        public ResourceType Type { get; set; }

        /// <summary>
        ///  Gets the flag indicating whether resource is a root resource. Root resource is
        ///  a special resource which is intended to support internals of MS Project's formats
        ///  and is not intended to be used directly from the user's code. 
        /// </summary>  
        public bool? IsRoot { get; set; }

        /// <summary>
        /// Determines whether a resource is null.
        /// </summary>  
        public bool? IsNull { get; set; }

        /// <summary>
        /// The initials of a resource.
        /// </summary>  
        public string Initials { get; set; }

        /// <summary>
        /// The phonetic spelling of the resource name. For use with Japanese only.
        /// </summary>  
        public string Phonetics { get; set; }

        /// <summary>
        /// The NT account associated with a resource.
        /// </summary>  
        public string NtAccount { get; set; }

        /// <summary>
        /// The NT account associated with a resource.
        /// </summary>  
        public string WindowsUserAccount { get; set; }

        /// <summary>
        /// The type of a workgroup to which a resource belongs.  type.
        /// </summary>  
        [JsonProperty("Workgroup", NullValueHandling = NullValueHandling.Ignore)]
        public WorkGroupType Workgroup { get; set; }


        /// <summary>
        /// The unit of measure for the material resource. Read/write String.
        /// </summary>  
        public string MaterialLabel { get; set; }

        /// <summary>
        /// The code or other information about a resource.
        /// </summary>  
        public string Code { get; set; }

        /// <summary>
        /// The group to which a resource belongs.
        /// </summary>  
        public string Group { get; set; }

        /// <summary>
        /// Gets or sets EmailAddress
        /// </summary>  
        public string EmailAddress { get; set; }

        /// <summary>
        /// The title of a hyperlink associated with a resource.
        /// </summary>  
        public string Hyperlink { get; set; }

        /// <summary>
        /// The hyperlink associated with a resource.
        /// </summary>  
        public string HyperlinkAddress { get; set; }

        /// <summary>
        /// The document bookmark of a hyperlink associated with a resource. Read/write String.
        /// </summary>  
        public string HyperlinkSubAddress { get; set; }

        /// <summary>
        /// The maximum number of units of a resource is available.
        /// </summary>  
        public double? MaxUnits { get; set; }

        /// <summary>
        /// The largest number of units assigned to a resource at any time.
        /// </summary>  
        public double? PeakUnits { get; set; }

        /// <summary>
        /// Gets or sets OverAllocated
        /// </summary>  
        public bool? OverAllocated { get; set; }

        /// <summary>
        /// The first date when a resource is available.
        /// </summary>  
        public DateTime? AvailableFrom { get; set; }

        /// <summary>
        /// The last date when a resource is available.
        /// </summary>  
        public DateTime? AvailableTo { get; set; }

        /// <summary>
        /// The scheduled start date of a resource.
        /// </summary>  
        public DateTime? Start { get; set; }

        /// <summary>
        /// The scheduled finish date of a resource.
        /// </summary>  
        public DateTime? Finish { get; set; }

        /// <summary>
        /// Determines whether a resource can be leveled.
        /// </summary>  
        public bool? CanLevel { get; set; }

        /// <summary>
        /// Determines how cost is accrued against the resource.
        /// </summary>  
        [JsonProperty("AccrueAt", NullValueHandling = NullValueHandling.Ignore)]
        public CostAccrualType AccrueAt { get; set; }


        /// <summary>
        /// The total work assigned to a resource across all assigned tasks.
        /// </summary>  
        public TimeSpan Work { get; set; }

        /// <summary>
        /// The amount of non-overtime work assigned to a resource.
        /// </summary>  
        public TimeSpan RegularWork { get; set; }

        /// <summary>
        /// The amount of overtime work assigned to a resource.
        /// </summary>  
        public TimeSpan OvertimeWork { get; set; }

        /// <summary>
        /// The amount of actual work performed by a resource.
        /// </summary>  
        public TimeSpan ActualWork { get; set; }

        /// <summary>
        /// The amount of remaining work required to complete all assigned tasks.
        /// </summary>  
        public TimeSpan RemainingWork { get; set; }

        /// <summary>
        /// The amount of actual overtime work performed by a resource.
        /// </summary>  
        public TimeSpan ActualOvertimeWork { get; set; }

        /// <summary>
        /// The amount of remaining overtime work required to complete all tasks.
        /// </summary>  
        public TimeSpan RemainingOvertimeWork { get; set; }

        /// <summary>
        /// The percentage of work completed across all tasks.
        /// </summary>  
        public int? PercentWorkComplete { get; set; }

        /// <summary>
        /// The standard rate of a resource. This value retrieved from the current date if a rate table exists for a resource.
        /// </summary>  
        public decimal? StandardRate { get; set; }

        /// <summary>
        /// The units used by Microsoft Project to display the standard rate.
        /// </summary>  
        [JsonProperty("StandardRateFormat", NullValueHandling = NullValueHandling.Ignore)]
        public RateFormatType StandardRateFormat { get; set; }


        /// <summary>
        /// The total project cost for a resource across all assigned tasks.
        /// </summary>  
        public decimal? Cost { get; set; }

        /// <summary>
        /// The units used by Microsoft Project to display the overtime rate.
        /// </summary>  
        [JsonProperty("OvertimeRateFormat", NullValueHandling = NullValueHandling.Ignore)]
        public RateFormatType OvertimeRateFormat { get; set; }


        /// <summary>
        /// The total overtime cost of a resource including actual and remaining overtime costs.
        /// </summary>  
        public decimal? OvertimeCost { get; set; }

        /// <summary>
        /// The cost per use of a resource. This value retrieved from the current date if a rate table exists for the resource.
        /// </summary>  
        public decimal? CostPerUse { get; set; }

        /// <summary>
        /// The actual cost incurred by the resource across all assigned tasks.
        /// </summary>  
        public decimal? ActualCost { get; set; }

        /// <summary>
        /// The actual overtime cost incurred by the resource across all assigned tasks.
        /// </summary>  
        public decimal? ActualOvertimeCost { get; set; }

        /// <summary>
        /// The remaining projected cost of a resource to complete all assigned tasks.
        /// </summary>  
        public decimal? RemainingCost { get; set; }

        /// <summary>
        /// The remaining projected overtime cost of a resource to complete all assigned tasks.
        /// </summary>  
        public decimal? RemainingOvertimeCost { get; set; }

        /// <summary>
        /// The difference between a baseline work and a work
        /// </summary>  
        public double? WorkVariance { get; set; }

        /// <summary>
        /// The difference between a baseline cost and a cost.
        /// </summary>  
        public double? CostVariance { get; set; }

        /// <summary>
        /// The earned value schedule variance, through the project status date.
        /// </summary>  
        public double? Sv { get; set; }

        /// <summary>
        /// The earned value cost variance, through the project status date.
        /// </summary>  
        public double? Cv { get; set; }

        /// <summary>
        /// The actual cost of a work performed by a resource for the project to-date.
        /// </summary>  
        public double? Acwp { get; set; }

        /// <summary>
        /// The calendar of a resource.
        /// </summary>  
        public int? CalendarUid { get; set; }

        /// <summary>
        /// Notes' plain text extracted from RTF data.
        /// </summary>  
        public string NotesText { get; set; }

        /// <summary>
        /// The text notes associated with a resource.
        /// </summary>  
        public string Notes { get; set; }

        /// <summary>
        /// The text notes in RTF format. Supported for MPP formats only.
        /// </summary>  
        public string NotesRTF { get; set; }

        /// <summary>
        /// The budget cost of a work scheduled for a resource.
        /// </summary>  
        public double? Bcws { get; set; }

        /// <summary>
        /// The budgeted cost of a work performed by a resource for the project to-date.
        /// </summary>  
        public double? Bcwp { get; set; }

        /// <summary>
        /// Determines whether a resource is generic.
        /// </summary>  
        public bool? IsGeneric { get; set; }

        /// <summary>
        /// Determines whether a resource is inactive.
        /// </summary>  
        public bool? IsInactive { get; set; }

        /// <summary>
        /// Determines whether a resource is an Enterprise resource.
        /// </summary>  
        public bool? IsEnterprise { get; set; }

        /// <summary>
        /// The booking type of a resource.
        /// </summary>  
        [JsonProperty("BookingType", NullValueHandling = NullValueHandling.Ignore)]
        public BookingType BookingType { get; set; }


        /// <summary>
        /// The duration through which actual work is protected.
        /// </summary>  
        public TimeSpan ActualWorkProtected { get; set; }

        /// <summary>
        /// The duration through which actual overtime work is protected.
        /// </summary>  
        public TimeSpan ActualOvertimeWorkProtected { get; set; }

        /// <summary>
        /// The Active Directory Guid for a resource.
        /// </summary>  
        public string ActiveDirectoryGuid { get; set; }

        /// <summary>
        /// The date when a resource was created.
        /// </summary>  
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// Indicates which cost center the costs accrued by the resource should be charged to.
        /// </summary>  
        public string CostCenter { get; set; }

        /// <summary>
        /// Determines whether a resource is a cost resource.
        /// </summary>  
        public bool? IsCostResource { get; set; }

        /// <summary>
        /// Determines whether the current resource is a team resource.             
        /// </summary>  
        public bool? TeamAssignmentPool { get; set; }

        /// <summary>
        /// The name of an assignment owner.
        /// </summary>  
        public string AssignmentOwner { get; set; }

        /// <summary>
        /// The GUID of an assignment owner.
        /// </summary>  
        public string AssignmentOwnerGuid { get; set; }

        /// <summary>
        /// Determines whether a resource is a budget resource.
        /// </summary>  
        public bool? IsBudget { get; set; }

        /// <summary>
        /// The budget work for a budget work or material resource.
        /// </summary>  
        public TimeSpan BudgetWork { get; set; }

        /// <summary>
        /// The budget cost for a budget cost resource.
        /// </summary>  
        public decimal? BudgetCost { get; set; }

        /// <summary>
        /// The overtime rate of a resource. This value retrieved from the current date if a rate table exists for a resource.
        /// </summary>  
        public decimal? OvertimeRate { get; set; }

        /// <summary>
        /// Gets or sets the collection of baseline values of the resource.
        /// </summary>  
        public List<Baseline> Baselines { get; set; }

        /// <summary>
        /// Resource extended attributes.
        /// </summary>  
        public List<ExtendedAttribute> ExtendedAttributes { get; set; }

        /// <summary>
        /// Resource outline codes.
        /// </summary>  
        public List<OutlineCode> OutlineCodes { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
            var sb = new StringBuilder();
            sb.Append("class Resource {\n");
            sb.Append("  Name: ").Append(this.Name).Append("\n");
            sb.Append("  Uid: ").Append(this.Uid).Append("\n");
            sb.Append("  Id: ").Append(this.Id).Append("\n");
            sb.Append("  Guid: ").Append(this.Guid).Append("\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  IsRoot: ").Append(this.IsRoot).Append("\n");
            sb.Append("  IsNull: ").Append(this.IsNull).Append("\n");
            sb.Append("  Initials: ").Append(this.Initials).Append("\n");
            sb.Append("  Phonetics: ").Append(this.Phonetics).Append("\n");
            sb.Append("  NtAccount: ").Append(this.NtAccount).Append("\n");
            sb.Append("  WindowsUserAccount: ").Append(this.WindowsUserAccount).Append("\n");
            sb.Append("  Workgroup: ").Append(this.Workgroup).Append("\n");
            sb.Append("  MaterialLabel: ").Append(this.MaterialLabel).Append("\n");
            sb.Append("  Code: ").Append(this.Code).Append("\n");
            sb.Append("  Group: ").Append(this.Group).Append("\n");
            sb.Append("  EmailAddress: ").Append(this.EmailAddress).Append("\n");
            sb.Append("  Hyperlink: ").Append(this.Hyperlink).Append("\n");
            sb.Append("  HyperlinkAddress: ").Append(this.HyperlinkAddress).Append("\n");
            sb.Append("  HyperlinkSubAddress: ").Append(this.HyperlinkSubAddress).Append("\n");
            sb.Append("  MaxUnits: ").Append(this.MaxUnits).Append("\n");
            sb.Append("  PeakUnits: ").Append(this.PeakUnits).Append("\n");
            sb.Append("  OverAllocated: ").Append(this.OverAllocated).Append("\n");
            sb.Append("  AvailableFrom: ").Append(this.AvailableFrom).Append("\n");
            sb.Append("  AvailableTo: ").Append(this.AvailableTo).Append("\n");
            sb.Append("  Start: ").Append(this.Start).Append("\n");
            sb.Append("  Finish: ").Append(this.Finish).Append("\n");
            sb.Append("  CanLevel: ").Append(this.CanLevel).Append("\n");
            sb.Append("  AccrueAt: ").Append(this.AccrueAt).Append("\n");
            sb.Append("  Work: ").Append(this.Work).Append("\n");
            sb.Append("  RegularWork: ").Append(this.RegularWork).Append("\n");
            sb.Append("  OvertimeWork: ").Append(this.OvertimeWork).Append("\n");
            sb.Append("  ActualWork: ").Append(this.ActualWork).Append("\n");
            sb.Append("  RemainingWork: ").Append(this.RemainingWork).Append("\n");
            sb.Append("  ActualOvertimeWork: ").Append(this.ActualOvertimeWork).Append("\n");
            sb.Append("  RemainingOvertimeWork: ").Append(this.RemainingOvertimeWork).Append("\n");
            sb.Append("  PercentWorkComplete: ").Append(this.PercentWorkComplete).Append("\n");
            sb.Append("  StandardRate: ").Append(this.StandardRate).Append("\n");
            sb.Append("  StandardRateFormat: ").Append(this.StandardRateFormat).Append("\n");
            sb.Append("  Cost: ").Append(this.Cost).Append("\n");
            sb.Append("  OvertimeRateFormat: ").Append(this.OvertimeRateFormat).Append("\n");
            sb.Append("  OvertimeCost: ").Append(this.OvertimeCost).Append("\n");
            sb.Append("  CostPerUse: ").Append(this.CostPerUse).Append("\n");
            sb.Append("  ActualCost: ").Append(this.ActualCost).Append("\n");
            sb.Append("  ActualOvertimeCost: ").Append(this.ActualOvertimeCost).Append("\n");
            sb.Append("  RemainingCost: ").Append(this.RemainingCost).Append("\n");
            sb.Append("  RemainingOvertimeCost: ").Append(this.RemainingOvertimeCost).Append("\n");
            sb.Append("  WorkVariance: ").Append(this.WorkVariance).Append("\n");
            sb.Append("  CostVariance: ").Append(this.CostVariance).Append("\n");
            sb.Append("  Sv: ").Append(this.Sv).Append("\n");
            sb.Append("  Cv: ").Append(this.Cv).Append("\n");
            sb.Append("  Acwp: ").Append(this.Acwp).Append("\n");
            sb.Append("  CalendarUid: ").Append(this.CalendarUid).Append("\n");
            sb.Append("  NotesText: ").Append(this.NotesText).Append("\n");
            sb.Append("  Notes: ").Append(this.Notes).Append("\n");
            sb.Append("  NotesRTF: ").Append(this.NotesRTF).Append("\n");
            sb.Append("  Bcws: ").Append(this.Bcws).Append("\n");
            sb.Append("  Bcwp: ").Append(this.Bcwp).Append("\n");
            sb.Append("  IsGeneric: ").Append(this.IsGeneric).Append("\n");
            sb.Append("  IsInactive: ").Append(this.IsInactive).Append("\n");
            sb.Append("  IsEnterprise: ").Append(this.IsEnterprise).Append("\n");
            sb.Append("  BookingType: ").Append(this.BookingType).Append("\n");
            sb.Append("  ActualWorkProtected: ").Append(this.ActualWorkProtected).Append("\n");
            sb.Append("  ActualOvertimeWorkProtected: ").Append(this.ActualOvertimeWorkProtected).Append("\n");
            sb.Append("  ActiveDirectoryGuid: ").Append(this.ActiveDirectoryGuid).Append("\n");
            sb.Append("  CreationDate: ").Append(this.CreationDate).Append("\n");
            sb.Append("  CostCenter: ").Append(this.CostCenter).Append("\n");
            sb.Append("  IsCostResource: ").Append(this.IsCostResource).Append("\n");
            sb.Append("  TeamAssignmentPool: ").Append(this.TeamAssignmentPool).Append("\n");
            sb.Append("  AssignmentOwner: ").Append(this.AssignmentOwner).Append("\n");
            sb.Append("  AssignmentOwnerGuid: ").Append(this.AssignmentOwnerGuid).Append("\n");
            sb.Append("  IsBudget: ").Append(this.IsBudget).Append("\n");
            sb.Append("  BudgetWork: ").Append(this.BudgetWork).Append("\n");
            sb.Append("  BudgetCost: ").Append(this.BudgetCost).Append("\n");
            sb.Append("  OvertimeRate: ").Append(this.OvertimeRate).Append("\n");
            sb.Append("  Baselines: ").Append(this.Baselines).Append("\n");
            sb.Append("  ExtendedAttributes: ").Append(this.ExtendedAttributes).Append("\n");
            sb.Append("  OutlineCodes: ").Append(this.OutlineCodes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}