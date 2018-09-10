// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="RecurringInfo.cs">
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
    /// Represents the details of a recurring task in a project.
    /// </summary>
    public class RecurringInfo
    { 
        /// <summary>
        /// Represents a recurrence pattern of the recurring task. Can be one of the values of  enum.
        /// </summary>  
        [JsonProperty("RecurrencePattern", NullValueHandling = NullValueHandling.Ignore)]
        public RecurrencePattern? RecurrencePattern { get; set; }


        /// <summary>
        /// Specifies the date for the occurrences to begin.
        /// </summary>  
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Specifies the date for the occurrences to end.
        /// </summary>  
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Specifies the duration for one occurrence of the recurring task. the instance of  class.
        /// </summary>  
        public TimeSpan Duration { get; set; }

        /// <summary>
        /// Specifies a number of occurrences of the recurring task.
        /// </summary>  
        public int? Occurrences { get; set; }

        /// <summary>
        /// Determines whether to use the end date or a number of occurrences for the recurring task.
        /// </summary>  
        public bool? UseEndDate { get; set; }

        /// <summary>
        /// Specifies an interval between repetitions for the daily recurrence pattern.
        /// </summary>  
        public int? DailyRepetitions { get; set; }

        /// <summary>
        /// Determines whether to use workdays for the daily recurrence pattern.
        /// </summary>  
        public bool? DailyUseWorkdays { get; set; }

        /// <summary>
        /// Specifies an interval between repetitions for the weekly recurrence pattern.
        /// </summary>  
        public int? WeeklyRepetitions { get; set; }

        /// <summary>
        /// Specifies a collection of days used in the weekly recurrence pattern.
        /// </summary>  
        [JsonProperty("WeeklyDays", NullValueHandling = NullValueHandling.Ignore)]
        public WeekDayType? WeeklyDays { get; set; }


        /// <summary>
        /// Determines whether to use ordinal day for the monthly recurrence pattern.
        /// </summary>  
        public bool? MonthlyUseOrdinalDay { get; set; }

        /// <summary>
        /// Specifies an ordinal number of the monthly recurrence pattern. Can be one of the values of  enum.
        /// </summary>  
        [JsonProperty("MonthlyOrdinalNumber", NullValueHandling = NullValueHandling.Ignore)]
        public OrdinalNumber? MonthlyOrdinalNumber { get; set; }


        /// <summary>
        /// Specifies a day of the monthly recurrence pattern when using ordinal day. Can be one of the values of  enum.
        /// </summary>  
        [JsonProperty("MonthlyOrdinalDay", NullValueHandling = NullValueHandling.Ignore)]
        public DayOfWeek? MonthlyOrdinalDay { get; set; }


        /// <summary>
        /// Specifies a number of repetitions for the monthly recurrence pattern when using ordinal day.
        /// </summary>  
        public int? MonthlyOrdinalRepetitions { get; set; }

        /// <summary>
        /// Specifies a number of day of the monthly recurrence pattern.
        /// </summary>  
        public int? MonthlyDay { get; set; }

        /// <summary>
        /// Specifies a number of repetitions for the monthly recurrence pattern.
        /// </summary>  
        public int? MonthlyRepetitions { get; set; }

        /// <summary>
        /// Determines whether to use ordinal day for the yearly recurrence pattern.
        /// </summary>  
        public bool? YearlyUseOrdinalDay { get; set; }

        /// <summary>
        /// Specifies a date for the yearly recurrence pattern.
        /// </summary>  
        public DateTime? YearlyDate { get; set; }

        /// <summary>
        /// Specifies an ordinal number of the yearly recurrence pattern. Can be one of the values of  enum.
        /// </summary>  
        [JsonProperty("YearlyOrdinalNumber", NullValueHandling = NullValueHandling.Ignore)]
        public OrdinalNumber? YearlyOrdinalNumber { get; set; }


        /// <summary>
        /// Specifies a weekday of the yearly recurrence pattern when using ordinal day. Can be one of the values of  enum.
        /// </summary>  
        [JsonProperty("YearlyOrdinalDay", NullValueHandling = NullValueHandling.Ignore)]
        public DayOfWeek? YearlyOrdinalDay { get; set; }


        /// <summary>
        /// Specifies a month of the yearly recurrence pattern when using ordinal day. Can be one of the values of  enum.
        /// </summary>  
        [JsonProperty("YearlyOrdinalMonth", NullValueHandling = NullValueHandling.Ignore)]
        public Month? YearlyOrdinalMonth { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
            var sb = new StringBuilder();
            sb.Append("class RecurringInfo {\n");
            sb.Append("  RecurrencePattern: ").Append(this.RecurrencePattern).Append("\n");
            sb.Append("  StartDate: ").Append(this.StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(this.EndDate).Append("\n");
            sb.Append("  Duration: ").Append(this.Duration).Append("\n");
            sb.Append("  Occurrences: ").Append(this.Occurrences).Append("\n");
            sb.Append("  UseEndDate: ").Append(this.UseEndDate).Append("\n");
            sb.Append("  DailyRepetitions: ").Append(this.DailyRepetitions).Append("\n");
            sb.Append("  DailyUseWorkdays: ").Append(this.DailyUseWorkdays).Append("\n");
            sb.Append("  WeeklyRepetitions: ").Append(this.WeeklyRepetitions).Append("\n");
            sb.Append("  WeeklyDays: ").Append(this.WeeklyDays).Append("\n");
            sb.Append("  MonthlyUseOrdinalDay: ").Append(this.MonthlyUseOrdinalDay).Append("\n");
            sb.Append("  MonthlyOrdinalNumber: ").Append(this.MonthlyOrdinalNumber).Append("\n");
            sb.Append("  MonthlyOrdinalDay: ").Append(this.MonthlyOrdinalDay).Append("\n");
            sb.Append("  MonthlyOrdinalRepetitions: ").Append(this.MonthlyOrdinalRepetitions).Append("\n");
            sb.Append("  MonthlyDay: ").Append(this.MonthlyDay).Append("\n");
            sb.Append("  MonthlyRepetitions: ").Append(this.MonthlyRepetitions).Append("\n");
            sb.Append("  YearlyUseOrdinalDay: ").Append(this.YearlyUseOrdinalDay).Append("\n");
            sb.Append("  YearlyDate: ").Append(this.YearlyDate).Append("\n");
            sb.Append("  YearlyOrdinalNumber: ").Append(this.YearlyOrdinalNumber).Append("\n");
            sb.Append("  YearlyOrdinalDay: ").Append(this.YearlyOrdinalDay).Append("\n");
            sb.Append("  YearlyOrdinalMonth: ").Append(this.YearlyOrdinalMonth).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}