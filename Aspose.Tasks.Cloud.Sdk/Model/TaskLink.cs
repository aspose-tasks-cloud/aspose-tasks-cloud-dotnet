// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TaskLink.cs">
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
    using System.Security;
    using System.Text;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// 
    /// </summary>
    public class TaskLink
    { 
        /// <summary>
        /// Gets or sets Link
        /// </summary>  
        public Link Link { get; set; }

        /// <summary>
        /// Gets or sets Index
        /// </summary>  
        public int? Index { get; set; }

        /// <summary>
        /// Gets or sets PredecessorUid
        /// </summary>  
        public int? PredecessorUid { get; set; }

        /// <summary>
        /// Gets or sets SuccessorUid
        /// </summary>  
        public int? SuccessorUid { get; set; }

        /// <summary>
        /// Gets or sets LinkType
        /// </summary>  
        [JsonProperty("LinkType", NullValueHandling = NullValueHandling.Ignore)]
        public TaskLinkType LinkType { get; set; }


        /// <summary>
        /// Gets or sets Lag
        /// </summary>  
        public int? Lag { get; set; }

        /// <summary>
        /// Gets or sets LagFormat
        /// </summary>  
        [JsonProperty("LagFormat", NullValueHandling = NullValueHandling.Ignore)]
        public TimeUnitType LagFormat { get; set; }

        /// <summary>
        /// Gets or sets lag duration, depending on LagFormat.
        /// </summary>  
        public string LinkLagTimeSpan { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
            var sb = new StringBuilder();
            sb.Append("class TaskLink {\n");
            sb.Append("  Link: ").Append(this.Link).Append("\n");
            sb.Append("  Index: ").Append(this.Index).Append("\n");
            sb.Append("  PredecessorUid: ").Append(this.PredecessorUid).Append("\n");
            sb.Append("  SuccessorUid: ").Append(this.SuccessorUid).Append("\n");
            sb.Append("  LinkType: ").Append(this.LinkType).Append("\n");
            sb.Append("  Lag: ").Append(this.Lag).Append("\n");
            sb.Append("  LagFormat: ").Append(this.LagFormat).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}