// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ExtendedAttributeDefinition.cs">
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
    /// Extended attribute definition&#39;s brief into.
    /// </summary>
    public class ExtendedAttributeDefinition
    { 
        /// <summary>
        /// Corresponds to the Pid of a custom field.
        /// </summary>  
        public string FieldId { get; set; }

        /// <summary>
        /// The name of a custom field.
        /// </summary>  
        public string FieldName { get; set; }

        /// <summary>
        /// The type of a custom field.
        /// </summary>  
        [JsonProperty("CfType", NullValueHandling = NullValueHandling.Ignore)]
        public CustomFieldType? CfType { get; set; }


        /// <summary>
        /// The Guid of a custom field.
        /// </summary>  
        public string Guid { get; set; }

        /// <summary>
        /// Determines whether the extended attribute is associated with a task or a resource
        /// </summary>  
        [JsonProperty("ElementType", NullValueHandling = NullValueHandling.Ignore)]
        public ElementType? ElementType { get; set; }


        /// <summary>
        /// The maximum number of values you can set in a picklist.
        /// </summary>  
        public int? MaxMultiValues { get; set; }

        /// <summary>
        /// Determines whether a custom field is user defined.
        /// </summary>  
        public bool? UserDef { get; set; }

        /// <summary>
        /// The alias of a custom field.
        /// </summary>  
        public string Alias { get; set; }

        /// <summary>
        /// The secondary Pid of a custom field.
        /// </summary>  
        public string SecondaryPid { get; set; }

        /// <summary>
        /// Determines whether an automatic rolldown to assignments is enabled.
        /// </summary>  
        public bool? AutoRollDown { get; set; }

        /// <summary>
        /// The Guid of the default lookup table entry.
        /// </summary>  
        public string DefaultGuid { get; set; }

        /// <summary>
        /// The Guid of the lookup table associated with a custom field.
        /// </summary>  
        public string LookupUid { get; set; }

        /// <summary>
        /// The phonetic pronunciation of the alias of a custom field.
        /// </summary>  
        public string PhoneticsAlias { get; set; }

        /// <summary>
        /// The way rollups are calculated.
        /// </summary>  
        [JsonProperty("RollupType", NullValueHandling = NullValueHandling.Ignore)]
        public RollupType? RollupType { get; set; }


        /// <summary>
        /// Determines whether rollups are calculated for a task and group summary rows.
        /// </summary>  
        [JsonProperty("CalculationType", NullValueHandling = NullValueHandling.Ignore)]
        public CalculationType? CalculationType { get; set; }


        /// <summary>
        /// The formula that Microsoft Project uses to populate a custom task field.
        /// </summary>  
        public string Formula { get; set; }

        /// <summary>
        /// Determines whether only values in the list are allowed in a file.
        /// </summary>  
        public bool? RestrictValues { get; set; }

        /// <summary>
        /// The way value lists are sorted. Values are: 0=Descending, 1=Ascending.
        /// </summary>  
        public int? ValuelistSortOrder { get; set; }

        /// <summary>
        /// Determines whether new values added to a project are automatically added to the list.
        /// </summary>  
        public bool? AppendNewValues { get; set; }

        /// <summary>
        /// The default value in the list.
        /// </summary>  
        public string _Default { get; set; }

        /// <summary>
        /// Returns list of Extended Attribute Values.
        /// </summary>  
        public List<Value> ValueList { get; set; }

        /// <summary>
        /// Secondary guid of extended attribute.
        /// </summary>  
        public string SecondaryGuid { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
            var sb = new StringBuilder();
            sb.Append("class ExtendedAttributeDefinition {\n");
            sb.Append("  FieldId: ").Append(this.FieldId).Append("\n");
            sb.Append("  FieldName: ").Append(this.FieldName).Append("\n");
            sb.Append("  CfType: ").Append(this.CfType).Append("\n");
            sb.Append("  Guid: ").Append(this.Guid).Append("\n");
            sb.Append("  ElementType: ").Append(this.ElementType).Append("\n");
            sb.Append("  MaxMultiValues: ").Append(this.MaxMultiValues).Append("\n");
            sb.Append("  UserDef: ").Append(this.UserDef).Append("\n");
            sb.Append("  Alias: ").Append(this.Alias).Append("\n");
            sb.Append("  SecondaryPid: ").Append(this.SecondaryPid).Append("\n");
            sb.Append("  AutoRollDown: ").Append(this.AutoRollDown).Append("\n");
            sb.Append("  DefaultGuid: ").Append(this.DefaultGuid).Append("\n");
            sb.Append("  LookupUid: ").Append(this.LookupUid).Append("\n");
            sb.Append("  PhoneticsAlias: ").Append(this.PhoneticsAlias).Append("\n");
            sb.Append("  RollupType: ").Append(this.RollupType).Append("\n");
            sb.Append("  CalculationType: ").Append(this.CalculationType).Append("\n");
            sb.Append("  Formula: ").Append(this.Formula).Append("\n");
            sb.Append("  RestrictValues: ").Append(this.RestrictValues).Append("\n");
            sb.Append("  ValuelistSortOrder: ").Append(this.ValuelistSortOrder).Append("\n");
            sb.Append("  AppendNewValues: ").Append(this.AppendNewValues).Append("\n");
            sb.Append("  _Default: ").Append(this._Default).Append("\n");
            sb.Append("  ValueList: ").Append(this.ValueList).Append("\n");
            sb.Append("  SecondaryGuid: ").Append(this.SecondaryGuid).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}