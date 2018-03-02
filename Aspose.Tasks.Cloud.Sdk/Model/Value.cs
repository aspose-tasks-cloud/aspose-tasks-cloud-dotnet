// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Value.cs">
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
    /// Represents a lookup value of an extended attribute.
    /// </summary>  
    public class Value
    {         /// <summary>
        /// The unique Id of a value across a project.
        /// </summary>  
        public int? Id { get; set; }

        /// <summary>
        /// The actual value.
        /// </summary>  
        public string Val { get; set; }

        /// <summary>
        /// The value in case of datetime type
        /// </summary>  
        public DateTime? DateTimeValue { get; set; }

        /// <summary>
        /// The value in case of duration type
        /// </summary>  
        public int? DurationValue { get; set; }

        /// <summary>
        /// The description of a value.
        /// </summary>  
        public string Description { get; set; }

        /// <summary>
        /// The phonetic information about custom field name.
        /// </summary>  
        public string Phonetic { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
            var sb = new StringBuilder();
            sb.Append("class Value {\n");
            sb.Append("  Id: ").Append(this.Id).Append("\n");
            sb.Append("  Val: ").Append(this.Val).Append("\n");
            sb.Append("  DateTimeValue: ").Append(this.DateTimeValue).Append("\n");
            sb.Append("  DurationValue: ").Append(this.DurationValue).Append("\n");
            sb.Append("  Description: ").Append(this.Description).Append("\n");
            sb.Append("  Phonetic: ").Append(this.Phonetic).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}