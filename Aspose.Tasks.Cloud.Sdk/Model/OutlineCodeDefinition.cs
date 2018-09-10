// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="OutlineCodeDefinition.cs">
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
    /// Represents an outline code definition.
    /// </summary>
    public class OutlineCodeDefinition
    { 
        /// <summary>
        /// The Guid of an outline code.
        /// </summary>  
        public string Guid { get; set; }

        /// <summary>
        /// Corresponds to the field number of an outline code.
        /// </summary>  
        public string FieldId { get; set; }

        /// <summary>
        /// The name of a custom outline code.
        /// </summary>  
        public string FieldName { get; set; }

        /// <summary>
        /// The alias of a custom outline code.
        /// </summary>  
        public string Alias { get; set; }

        /// <summary>
        /// The phonetic pronunciation of the alias of the custom outline code.
        /// </summary>  
        public string PhoneticAlias { get; set; }

        /// <summary>
        /// Returns List&lt;OutlineValue&gt; Values. The values of the table associated with this outline code.
        /// </summary>  
        public List<OutlineValue> Values { get; set; }

        /// <summary>
        /// Determines whether a custom outline code is an enterprise custom outline code.
        /// </summary>  
        public bool? Enterprise { get; set; }

        /// <summary>
        /// The reference to another custom field for which this outline code definition is an alias.
        /// </summary>  
        public int? EnterpriseOutlineCodeAlias { get; set; }

        /// <summary>
        /// Determines whether the custom outline code can be used by the Resource Substitution Wizard in Microsoft Project.
        /// </summary>  
        public bool? ResourceSubstitutionEnabled { get; set; }

        /// <summary>
        /// Determines whether the values specified in this outline code field must be leaf values.
        /// </summary>  
        public bool? LeafOnly { get; set; }

        /// <summary>
        /// Determines whether the new codes must have all levels. Not available for Enterprise Codes.
        /// </summary>  
        public bool? AllLevelsRequired { get; set; }

        /// <summary>
        /// Determines whether the values specified must come from values table.
        /// </summary>  
        public bool? OnlyTableValuesAllowed { get; set; }

        /// <summary>
        /// Returns List&lt;OutlineMask&gt; Masks. The table of entries that define the outline code mask.
        /// </summary>  
        public List<OutlineMask> Masks { get; set; }

        /// <summary>
        /// Determines whether the indents of this outline code must be shown.
        /// </summary>  
        public bool? ShowIndent { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
            var sb = new StringBuilder();
            sb.Append("class OutlineCodeDefinition {\n");
            sb.Append("  Guid: ").Append(this.Guid).Append("\n");
            sb.Append("  FieldId: ").Append(this.FieldId).Append("\n");
            sb.Append("  FieldName: ").Append(this.FieldName).Append("\n");
            sb.Append("  Alias: ").Append(this.Alias).Append("\n");
            sb.Append("  PhoneticAlias: ").Append(this.PhoneticAlias).Append("\n");
            sb.Append("  Values: ").Append(this.Values).Append("\n");
            sb.Append("  Enterprise: ").Append(this.Enterprise).Append("\n");
            sb.Append("  EnterpriseOutlineCodeAlias: ").Append(this.EnterpriseOutlineCodeAlias).Append("\n");
            sb.Append("  ResourceSubstitutionEnabled: ").Append(this.ResourceSubstitutionEnabled).Append("\n");
            sb.Append("  LeafOnly: ").Append(this.LeafOnly).Append("\n");
            sb.Append("  AllLevelsRequired: ").Append(this.AllLevelsRequired).Append("\n");
            sb.Append("  OnlyTableValuesAllowed: ").Append(this.OnlyTableValuesAllowed).Append("\n");
            sb.Append("  Masks: ").Append(this.Masks).Append("\n");
            sb.Append("  ShowIndent: ").Append(this.ShowIndent).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}