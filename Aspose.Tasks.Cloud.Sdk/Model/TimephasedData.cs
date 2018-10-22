// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TimephasedData.cs">
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
    /// Represents a time phased data.
    /// </summary>
    public class TimephasedData
    { 
        /// <summary>
        /// The unique identifier of a timephased data
        /// </summary>  
        public int? Uid { get; set; }

        /// <summary>
        /// The start date of a timephased data period.
        /// </summary>  
        public DateTime? Start { get; set; }

        /// <summary>
        /// The finish date of a timephased data period.
        /// </summary>  
        public DateTime? Finish { get; set; }

        /// <summary>
        /// The time unit of a timephased data period.
        /// </summary>  
        [JsonProperty("Unit", NullValueHandling = NullValueHandling.Ignore)]
        public TimeUnitType Unit { get; set; }


        /// <summary>
        /// The value per unit of time for a timephased data period.
        /// </summary>  
        public string Value { get; set; }

        /// <summary>
        /// The type of a timephased data.
        /// </summary>  
        [JsonProperty("TimephasedDataType", NullValueHandling = NullValueHandling.Ignore)]
        public TimephasedDataType TimephasedDataType { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
            var sb = new StringBuilder();
            sb.Append("class TimephasedData {\n");
            sb.Append("  Uid: ").Append(this.Uid).Append("\n");
            sb.Append("  Start: ").Append(this.Start).Append("\n");
            sb.Append("  Finish: ").Append(this.Finish).Append("\n");
            sb.Append("  Unit: ").Append(this.Unit).Append("\n");
            sb.Append("  Value: ").Append(this.Value).Append("\n");
            sb.Append("  TimephasedDataType: ").Append(this.TimephasedDataType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}