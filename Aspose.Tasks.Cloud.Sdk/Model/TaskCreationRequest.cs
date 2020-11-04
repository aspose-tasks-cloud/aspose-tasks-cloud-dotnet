// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TaskCreationRequest.cs">
//   Copyright (c) 2020 Aspose.Tasks Cloud
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

using System.Text;

namespace Aspose.Tasks.Cloud.Sdk.Model
{
    public class TaskCreationRequest
    {

        /// <summary>
        /// The name for the new task.
        /// </summary>  
        public string TaskName { get; set; }

        /// <summary>
        /// Uid for parent task.
        /// </summary>  
        public int? ParentTaskUid { get; set; }

        /// <summary>
        /// Id of task before which new task will be inserted..
        /// </summary>  
        public int? BeforeTaskId { get; set; }
        

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
            var sb = new StringBuilder();
            sb.Append("class TaskCreationRequest {\n");
            sb.Append("  TaskName: ").Append(this.TaskName).Append("\n");
            sb.Append("  ParentTaskUid: ").Append(this.ParentTaskUid).Append("\n");
            sb.Append("  BeforeTaskId: ").Append(this.BeforeTaskId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}