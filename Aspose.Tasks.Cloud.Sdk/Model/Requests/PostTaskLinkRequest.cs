// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PostTaskLinkRequest.cs">
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
    /// Request model for <see cref="Aspose.Tasks.Cloud.Sdk.Api.TasksApi.PostTaskLink" /> operation.
    /// </summary>  
    public class PostTaskLinkRequest  
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostTaskLinkRequest"/> class.
        /// </summary>        
        public PostTaskLinkRequest()
        {
        }


        /// <summary>
        /// The name of the file.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// The TaskLink object representation that should be added.
        /// </summary>  
        public TaskLink TaskLink { get; set; }

        /// <summary>
        /// The document storage.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// The document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// The name of the project document to save changes to.  If this parameter is omitted then the changes will be saved to the source project document.
        /// </summary>  
        public string FileName { get; set; }
    }
}
