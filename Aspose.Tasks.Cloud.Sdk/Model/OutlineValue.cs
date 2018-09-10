// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="OutlineValue.cs">
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
    /// Represents an outline value.
    /// </summary>
    public class OutlineValue
    { 
        /// <summary>
        /// The unique Id of an outline code value within a project.
        /// </summary>  
        public int? ValueId { get; set; }

        /// <summary>
        /// The Guid of an outline code value.
        /// </summary>  
        public string FieldGuid { get; set; }

        /// <summary>
        /// The outline code type.
        /// </summary>  
        [JsonProperty("Type", NullValueHandling = NullValueHandling.Ignore)]
        public OutlineValueType? Type { get; set; }


        /// <summary>
        /// The Id of a parent node of an outline code.
        /// </summary>  
        public int? ParentValueId { get; set; }

        /// <summary>
        /// The actual value.
        /// </summary>  
        public string Value { get; set; }

        /// <summary>
        /// The description of an outline value.
        /// </summary>  
        public string Description { get; set; }

        /// <summary>
        /// Determines whether outline value is collapsed or not.
        /// </summary>  
        public bool? IsCollapsed { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
            var sb = new StringBuilder();
            sb.Append("class OutlineValue {\n");
            sb.Append("  ValueId: ").Append(this.ValueId).Append("\n");
            sb.Append("  FieldGuid: ").Append(this.FieldGuid).Append("\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  ParentValueId: ").Append(this.ParentValueId).Append("\n");
            sb.Append("  Value: ").Append(this.Value).Append("\n");
            sb.Append("  Description: ").Append(this.Description).Append("\n");
            sb.Append("  IsCollapsed: ").Append(this.IsCollapsed).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}