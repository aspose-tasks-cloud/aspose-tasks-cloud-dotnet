// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ExtendedAttribute.cs">
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
    /// Represents extended attribute.
    /// </summary>
    public class ExtendedAttribute
    { 
        /// <summary>
        /// Gets or sets the id of a field.
        /// </summary>  
        public string FieldId { get; set; }

        /// <summary>
        /// Gets the type of a custom field.
        /// </summary>  
        [JsonProperty("AttributeType", NullValueHandling = NullValueHandling.Ignore)]
        public CustomFieldType AttributeType { get; set; }


        /// <summary>
        /// Gets or sets the guid of a value.
        /// </summary>  
        public string ValueGuid { get; set; }

        /// <summary>
        /// Gets or sets Id of the lookup value (if value is lookup value)
        /// </summary>  
        public int? LookupValueId { get; set; }

        /// <summary>
        /// Gets or sets value for attributes with 'Duration' type.
        /// </summary>  
        public Duration DurationValue { get; set; }

        /// <summary>
        /// Gets or sets a value for attributes with numeric types (Cost, Number).
        /// </summary>  
        public decimal? NumericValue { get; set; }

        /// <summary>
        /// Gets or sets a value for attributes with date types (Date, Start, Finish).
        /// </summary>  
        public DateTime? DateValue { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether a flag is set for an attribute with 'Flag' type.
        /// </summary>  
        public bool? FlagValue { get; set; }

        /// <summary>
        /// Gets or sets a value for attributes with 'Text' type.
        /// </summary>  
        public string TextValue { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
            var sb = new StringBuilder();
            sb.Append("class ExtendedAttribute {\n");
            sb.Append("  FieldId: ").Append(this.FieldId).Append("\n");
            sb.Append("  AttributeType: ").Append(this.AttributeType).Append("\n");
            sb.Append("  ValueGuid: ").Append(this.ValueGuid).Append("\n");
            sb.Append("  LookupValueId: ").Append(this.LookupValueId).Append("\n");
            sb.Append("  DurationValue: ").Append(this.DurationValue).Append("\n");
            sb.Append("  NumericValue: ").Append(this.NumericValue).Append("\n");
            sb.Append("  DateValue: ").Append(this.DateValue).Append("\n");
            sb.Append("  FlagValue: ").Append(this.FlagValue).Append("\n");
            sb.Append("  TextValue: ").Append(this.TextValue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}