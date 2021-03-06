// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PutTaskRequest.cs">
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
namespace Aspose.Tasks.Cloud.Sdk.Model.Requests 
{
    using System;
    using System.Collections.Generic;

    using Aspose.Tasks.Cloud.Sdk.Model; 

    /// <summary>
    /// Request model for <see cref="Aspose.Tasks.Cloud.Sdk.Api.TasksApi.PutTask" /> operation.
    /// </summary>  
    public class PutTaskRequest  
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PutTaskRequest"/> class.
        /// </summary>        
        public PutTaskRequest()
        {
        }


        /// <summary>
        /// The name of the file.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Task UID
        /// </summary>  
        public int? TaskUid { get; set; }

        /// <summary>
        /// TaskDTO
        /// </summary>  
        public Task Task { get; set; }

        /// <summary>
        /// CalculationModeDTO
        /// </summary>  
        public CalculationMode Mode { get; set; }

        /// <summary>
        /// boolean value 
        /// </summary>  
        public bool? Recalculate { get; set; }

        /// <summary>
        /// The document strorage
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// The document folder
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// The name of the file to save changes
        /// </summary>  
        public string FileName { get; set; }
    }
}
