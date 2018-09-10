// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="OutlineCode.cs">
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
    /// Represents a value of an outline code.
    /// </summary>
    public class OutlineCode
    { 
        /// <summary>
        /// The number value of the project Id (Pid) custom field.
        /// </summary>  
        public string FieldId { get; set; }

        /// <summary>
        /// The Id in the value list associated with the definition in the outline code collection.
        /// </summary>  
        public int? ValueId { get; set; }

        /// <summary>
        /// The Guid of the value in the value list. The ValueGuid matches the FieldGuid in the value list.
        /// </summary>  
        public string ValueGuid { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
            var sb = new StringBuilder();
            sb.Append("class OutlineCode {\n");
            sb.Append("  FieldId: ").Append(this.FieldId).Append("\n");
            sb.Append("  ValueId: ").Append(this.ValueId).Append("\n");
            sb.Append("  ValueGuid: ").Append(this.ValueGuid).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}