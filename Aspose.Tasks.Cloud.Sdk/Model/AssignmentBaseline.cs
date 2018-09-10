// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="AssignmentBaseline.cs">
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
    /// Represents baseline values of a resource assignment.
    /// </summary>
    public class AssignmentBaseline : Baseline
    { 
        /// <summary>
        /// Gets or sets the scheduled start date of the resource assignment when the baseline was saved. The start date of the resource assignment when this baseline was saved.
        /// </summary>  
        public DateTime? Start { get; set; }

        /// <summary>
        /// Gets or sets the scheduled finish date of the resource assignment when the baseline was saved. The finish date of the resource assignment when this baseline was saved.
        /// </summary>  
        public DateTime? Finish { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
            var sb = new StringBuilder();
            sb.Append("class AssignmentBaseline {\n");
            sb.Append("  Start: ").Append(this.Start).Append("\n");
            sb.Append("  Finish: ").Append(this.Finish).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}