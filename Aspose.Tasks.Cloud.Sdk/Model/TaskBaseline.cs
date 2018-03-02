// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TaskBaseline.cs">
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
    /// Represents baseline values of a task.
    /// </summary>  
    public class TaskBaseline : Baseline
    {         /// <summary>
        /// The scheduled start date of the task when the baseline was saved.
        /// </summary>  
        public DateTime? Start { get; set; }

        /// <summary>
        /// The scheduled finish date of the task when the baseline was saved.
        /// </summary>  
        public DateTime? Finish { get; set; }

        /// <summary>
        /// The scheduled duration of the task when the baseline was saved.
        /// </summary>  
        public string Duration { get; set; }

        /// <summary>
        /// The fixed cost of the task when the baseline was saved.
        /// </summary>  
        public double? FixedCost { get; set; }

        /// <summary>
        /// The format for expressing the duration of the task baseline.
        /// </summary>  
        public TimeUnitType DurationFormat { get; set; }

        /// <summary>
        /// Indicates whether the baseline duration of the task was estimated.
        /// </summary>  
        public bool? EstimatedDuration { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
            var sb = new StringBuilder();
            sb.Append("class TaskBaseline {\n");
            sb.Append("  Start: ").Append(this.Start).Append("\n");
            sb.Append("  Finish: ").Append(this.Finish).Append("\n");
            sb.Append("  Duration: ").Append(this.Duration).Append("\n");
            sb.Append("  FixedCost: ").Append(this.FixedCost).Append("\n");
            sb.Append("  DurationFormat: ").Append(this.DurationFormat).Append("\n");
            sb.Append("  EstimatedDuration: ").Append(this.EstimatedDuration).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}