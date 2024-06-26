// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TaskItem.cs">
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
    /// A task&#39;s brief info 
    /// </summary>
    public class TaskItem
    { 
        /// <summary>
        /// Gets or sets Link
        /// </summary>  
        public Link Link { get; set; }

        /// <summary>
        /// Gets or sets Uid
        /// </summary>  
        public int? Uid { get; set; }

        /// <summary>
        /// Gets or sets Id
        /// </summary>  
        public int? Id { get; set; }

        /// <summary>
        /// Gets or sets Name
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Start
        /// </summary>  
        public DateTime? Start { get; set; }

        /// <summary>
        /// Gets or sets Finish
        /// </summary>  
        public DateTime? Finish { get; set; }

        /// <summary>
        /// The duration of a task.
        /// </summary>  
        public TimeSpan Duration { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
            var sb = new StringBuilder();
            sb.Append("class TaskItem {\n");
            sb.Append("  Link: ").Append(this.Link).Append("\n");
            sb.Append("  Uid: ").Append(this.Uid).Append("\n");
            sb.Append("  Id: ").Append(this.Id).Append("\n");
            sb.Append("  Name: ").Append(this.Name).Append("\n");
            sb.Append("  Start: ").Append(this.Start).Append("\n");
            sb.Append("  Finish: ").Append(this.Finish).Append("\n");
            sb.Append("  Duration: ").Append(this.Duration).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}