// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="OutlineMask.cs">
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
    /// Represents four elements of a mask which defines an outline code format.
    /// </summary>
    public class OutlineMask
    { 
        /// <summary>
        /// The level of a mask.
        /// </summary>  
        public int? Level { get; set; }

        /// <summary>
        /// The type of a mask.
        /// </summary>  
        [JsonProperty("Type", NullValueHandling = NullValueHandling.Ignore)]
        public MaskType? Type { get; set; }


        /// <summary>
        /// The maximum length (in characters) of the outline code values. 0 if length is not defined.
        /// </summary>  
        public int? Length { get; set; }

        /// <summary>
        /// The separator of code values.
        /// </summary>  
        public string Separator { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
            var sb = new StringBuilder();
            sb.Append("class OutlineMask {\n");
            sb.Append("  Level: ").Append(this.Level).Append("\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  Length: ").Append(this.Length).Append("\n");
            sb.Append("  Separator: ").Append(this.Separator).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}