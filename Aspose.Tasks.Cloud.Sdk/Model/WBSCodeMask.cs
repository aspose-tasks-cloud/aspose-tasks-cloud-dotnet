// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="WBSCodeMask.cs">
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
    /// 
    /// </summary>
    public class WBSCodeMask
    { 
        /// <summary>
        /// Mask level.
        /// </summary>  
        public int? Level { get; set; }

        /// <summary>
        /// The number of characters of the code string.
        /// </summary>  
        public int? Length { get; set; }

        /// <summary>
        /// Specifies  the type of character of the code string.
        /// </summary>  
        [JsonProperty("Sequence", NullValueHandling = NullValueHandling.Ignore)]
        public WBSSequence Sequence { get; set; }


        /// <summary>
        /// Specifies the separator of the code string. Default value is Period.
        /// </summary>  
        public string Separator { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
            var sb = new StringBuilder();
            sb.Append("class WBSCodeMask {\n");
            sb.Append("  Level: ").Append(this.Level).Append("\n");
            sb.Append("  Length: ").Append(this.Length).Append("\n");
            sb.Append("  Sequence: ").Append(this.Sequence).Append("\n");
            sb.Append("  Separator: ").Append(this.Separator).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}