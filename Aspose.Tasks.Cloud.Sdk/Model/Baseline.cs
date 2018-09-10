// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Baseline.cs">
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
    /// Represents baseline values of a resource or a task.
    /// </summary>
    public class Baseline
    { 
        /// <summary>
        /// The unique number of a baseline data record.
        /// </summary>  
        [JsonProperty("BaselineNumber", NullValueHandling = NullValueHandling.Ignore)]
        public BaselineType? BaselineNumber { get; set; }


        /// <summary>
        /// The work assigned to a resource when the baseline is saved.
        /// </summary>  
        public TimeSpan Work { get; set; }

        /// <summary>
        /// The projected cost of a resource when the baseline is saved.
        /// </summary>  
        public decimal? Cost { get; set; }

        /// <summary>
        /// The budget cost of a work scheduled for a resource.
        /// </summary>  
        public double? Bcws { get; set; }

        /// <summary>
        /// The budgeted cost of a work performed by a resource for a project to-date.
        /// </summary>  
        public double? Bcwp { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
            var sb = new StringBuilder();
            sb.Append("class Baseline {\n");
            sb.Append("  BaselineNumber: ").Append(this.BaselineNumber).Append("\n");
            sb.Append("  Work: ").Append(this.Work).Append("\n");
            sb.Append("  Cost: ").Append(this.Cost).Append("\n");
            sb.Append("  Bcws: ").Append(this.Bcws).Append("\n");
            sb.Append("  Bcwp: ").Append(this.Bcwp).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}