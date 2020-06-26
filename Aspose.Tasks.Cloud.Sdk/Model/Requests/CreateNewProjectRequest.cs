// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="DeleteAssignmentRequest.cs">
//   Copyright (c) 2020 Aspose.Tasks for Cloud
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

    /// <summary>
    /// Request model for <see cref="Aspose.Tasks.Cloud.Sdk.Api.TasksApi.CreateNewProject" /> operation.
    /// </summary>
    public class CreateNewProjectRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateNewProjectRequest"/> class.
        /// </summary>   
        public CreateNewProjectRequest()
        {
        }

        /// <summary>
        /// The name of the file.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// The url of sharepoint site. For example, "https://your_company_name.sharepoint.com"
        /// </summary>  
        public string SiteUrl { get; set; }

        /// <summary>
        /// The user name for the sharepoint site.
        /// </summary>  
        public string UserName { get; set; }

        /// <summary>
        /// Dispensable save options for Project Server\Project Online.
        /// </summary>  
        public ProjectServerSaveOptionsDTO SaveOptions { get; set; }

        /// <summary>
        /// The document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// The document storage.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// Authorization token for the SharePoint. For example, in c# it can be retrieved using SharePointOnlineCredentials class 
        /// from Microsoft.SharePoint.Client.Runtime assembly.
        /// </summary>  
        public string XProjectOnlineToken { get; set; }

        /// <summary>
        /// The password for the SharePoint site.
        /// </summary>  
        public string XSharepointPassword { get; set; }
    }
}
