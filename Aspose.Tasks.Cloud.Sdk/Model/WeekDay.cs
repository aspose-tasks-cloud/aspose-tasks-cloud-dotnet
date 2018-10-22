// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="WeekDay.cs">
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
    /// 
    /// </summary>
    public class WeekDay
    { 
        /// <summary>
        /// Returns or sets the type of a day.
        /// </summary>  
        [JsonProperty("DayType", NullValueHandling = NullValueHandling.Ignore)]
        public DayType DayType { get; set; }


        /// <summary>
        /// Determines whether the specified date or day type is working.
        /// </summary>  
        public bool? DayWorking { get; set; }

        /// <summary>
        /// Returns or sets the beginning of an exception time.
        /// </summary>  
        public DateTime? FromDate { get; set; }

        /// <summary>
        /// Returns or sets the end of an exception time.
        /// </summary>  
        public DateTime? ToDate { get; set; }

        /// <summary>
        /// The collection of working times that define the time worked on the weekday.
        /// </summary>  
        public List<WorkingTime> WorkingTimes { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
            var sb = new StringBuilder();
            sb.Append("class WeekDay {\n");
            sb.Append("  DayType: ").Append(this.DayType).Append("\n");
            sb.Append("  DayWorking: ").Append(this.DayWorking).Append("\n");
            sb.Append("  FromDate: ").Append(this.FromDate).Append("\n");
            sb.Append("  ToDate: ").Append(this.ToDate).Append("\n");
            sb.Append("  WorkingTimes: ").Append(this.WorkingTimes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}