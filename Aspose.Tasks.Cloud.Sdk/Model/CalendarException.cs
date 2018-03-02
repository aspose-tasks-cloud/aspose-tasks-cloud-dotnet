// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="CalendarException.cs">
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
    /// Represent exceptional time periods in a calendar.
    /// </summary>  
    public class CalendarException
    {         /// <summary>
        /// Index of the current item in the collection of calendar's exceptions.
        /// </summary>  
        public int? Index { get; set; }

        /// <summary>
        /// Determines whether the range of recurrence is defined by entering a number of occurrences. False specifies that the range of recurrence is defined by entering a finish date.
        /// </summary>  
        public bool? EnteredByOccurrences { get; set; }

        /// <summary>
        /// The beginning of the exception time.
        /// </summary>  
        public DateTime? FromDate { get; set; }

        /// <summary>
        /// The end of the exception time.
        /// </summary>  
        public DateTime? ToDate { get; set; }

        /// <summary>
        /// The number of occurrences for which the calendar exception is valid.
        /// </summary>  
        public int? Occurrences { get; set; }

        /// <summary>
        /// The name of the exception.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// The exception type.
        /// </summary>  
        [JsonProperty("Type", NullValueHandling = NullValueHandling.Ignore)]
        public CalendarExceptionType? Type { get; set; }


        /// <summary>
        /// The period of recurrence for the exception.
        /// </summary>  
        public int? Period { get; set; }

        /// <summary>
        /// The days of the week on which the exception is valid.
        /// </summary>  
        public List<DayType> DaysOfWeek { get; set; }

        /// <summary>
        /// The month item for which an exception recurrence is scheduled.
        /// </summary>  
        [JsonProperty("MonthItem", NullValueHandling = NullValueHandling.Ignore)]
        public MonthItemType? MonthItem { get; set; }


        /// <summary>
        /// The position of a month item within a month.
        /// </summary>  
        [JsonProperty("MonthPosition", NullValueHandling = NullValueHandling.Ignore)]
        public MonthPosition? MonthPosition { get; set; }


        /// <summary>
        /// The month for which an exception recurrence is scheduled.
        /// </summary>  
        [JsonProperty("Month", NullValueHandling = NullValueHandling.Ignore)]
        public Month? Month { get; set; }


        /// <summary>
        /// The day of a month on which an exception recurrence is scheduled.
        /// </summary>  
        public int? MonthDay { get; set; }

        /// <summary>
        /// Determines whether the specified date or day type is working.
        /// </summary>  
        public bool? DayWorking { get; set; }

        /// <summary>
        /// The collection of working times that defines the time worked on the weekday.  At least one working time must present, and there can't be more than five.
        /// </summary>  
        public List<WorkingTime> WorkingTimes { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
            var sb = new StringBuilder();
            sb.Append("class CalendarException {\n");
            sb.Append("  Index: ").Append(this.Index).Append("\n");
            sb.Append("  EnteredByOccurrences: ").Append(this.EnteredByOccurrences).Append("\n");
            sb.Append("  FromDate: ").Append(this.FromDate).Append("\n");
            sb.Append("  ToDate: ").Append(this.ToDate).Append("\n");
            sb.Append("  Occurrences: ").Append(this.Occurrences).Append("\n");
            sb.Append("  Name: ").Append(this.Name).Append("\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  Period: ").Append(this.Period).Append("\n");
            sb.Append("  DaysOfWeek: ").Append(this.DaysOfWeek).Append("\n");
            sb.Append("  MonthItem: ").Append(this.MonthItem).Append("\n");
            sb.Append("  MonthPosition: ").Append(this.MonthPosition).Append("\n");
            sb.Append("  Month: ").Append(this.Month).Append("\n");
            sb.Append("  MonthDay: ").Append(this.MonthDay).Append("\n");
            sb.Append("  DayWorking: ").Append(this.DayWorking).Append("\n");
            sb.Append("  WorkingTimes: ").Append(this.WorkingTimes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}