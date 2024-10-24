// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Calendar.cs">
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
    /// Represents a calendar used in a project.
    /// </summary>
    public class Calendar
    { 
        /// <summary>
        /// Gets calendar's Guid.
        /// </summary>
        public string Guid { get; set; }
        
        /// <summary>
        /// The name of the calendar.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// The unique identifier of the calendar.
        /// </summary>  
        public int? Uid { get; set; }

        /// <summary>
        /// The collection of weekdays that defines the calendar.
        /// </summary>  
        public List<WeekDay> Days { get; set; }

        /// <summary>
        /// Determines whether the calendar is a base calendar.
        /// </summary>  
        public bool? IsBaseCalendar { get; set; }

        /// <summary>
        /// The base calendar on which this calendar depends. Only applicable if the calendar is not a base calendar.
        /// </summary>  
        public Calendar BaseCalendar { get; set; }

        /// <summary>
        /// Specifies whether the calendar is a baseline calendar.
        /// </summary>  
        public bool? IsBaselineCalendar { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
            var sb = new StringBuilder();
            sb.Append("class Calendar {\n");
            sb.Append("  Name: ").Append(this.Name).Append("\n");
            sb.Append("  Uid: ").Append(this.Uid).Append("\n");
            sb.Append("  Days: ").Append(this.Days).Append("\n");
            sb.Append("  IsBaseCalendar: ").Append(this.IsBaseCalendar).Append("\n");
            sb.Append("  BaseCalendar: ").Append(this.BaseCalendar).Append("\n");
            sb.Append("  IsBaselineCalendar: ").Append(this.IsBaselineCalendar).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}