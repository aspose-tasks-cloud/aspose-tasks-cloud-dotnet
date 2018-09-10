// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="VbaProject.cs">
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
    /// Represents VbaProject
    /// </summary>
    public class VbaProject
    { 
        /// <summary>
        /// Gets conditional Compilation Arguments
        /// </summary>  
        public string CompilationArguments { get; set; }

        /// <summary>
        /// Gets a project Description
        /// </summary>  
        public string Description { get; set; }

        /// <summary>
        /// Gets a project Help Context Id
        /// </summary>  
        public int? HelpContextId { get; set; }

        /// <summary>
        /// Gets a help file name
        /// </summary>  
        public string HelpFile { get; set; }

        /// <summary>
        /// Gets a collection of VbaModuleCollection
        /// </summary>  
        public List<VbaModule> Modules { get; set; }

        /// <summary>
        /// Gets project name
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Gets a collection of VbaReferenceCollection
        /// </summary>  
        public List<VbaReference> References { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
            var sb = new StringBuilder();
            sb.Append("class VbaProject {\n");
            sb.Append("  CompilationArguments: ").Append(this.CompilationArguments).Append("\n");
            sb.Append("  Description: ").Append(this.Description).Append("\n");
            sb.Append("  HelpContextId: ").Append(this.HelpContextId).Append("\n");
            sb.Append("  HelpFile: ").Append(this.HelpFile).Append("\n");
            sb.Append("  Modules: ").Append(this.Modules).Append("\n");
            sb.Append("  Name: ").Append(this.Name).Append("\n");
            sb.Append("  References: ").Append(this.References).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}