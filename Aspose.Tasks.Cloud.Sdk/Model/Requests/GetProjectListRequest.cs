namespace Aspose.Tasks.Cloud.Sdk.Model.Requests
{
    
    /// <summary>
    /// Request model for <see cref="Aspose.Tasks.Cloud.Sdk.Api.TasksApi.GetProjectList" /> operation.
    /// </summary>
    public class GetProjectListRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectListRequest"/> class.
        /// </summary>        
        public GetProjectListRequest()
        {
        }
        
        /// <summary>
        /// The url of sharepoint site. For example, "https://your_company_name.sharepoint.com".
        /// </summary>  
        public string SiteUrl { get; set; }

        /// <summary>
        /// The user name for the sharepoint site.
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// The password for the SharePoint site.
        /// </summary>
        public string XSharepointPassword { get; set; }

        /// <summary>
        /// Authorization token for the SharePoint. For example, in C# it can be retrieved using
        /// SharePointOnlineCredentials class from Microsoft.SharePoint.Client.Runtime assembly
        /// </summary>
        public string Token { get; set; }

    }
}