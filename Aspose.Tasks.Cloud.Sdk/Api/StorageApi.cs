using Aspose.Tasks.Cloud.Sdk.Model;
using Aspose.Tasks.Cloud.Sdk.Model.Requests;
using System.Collections.Generic;
using System.Net;
using System.Text.RegularExpressions;

namespace Aspose.Tasks.Cloud.Sdk
{
    public class StorageApi : ApiBase
    {
        public StorageApi(Configuration configuration) : base(configuration)
        {
        }

        public UploadResponse UploadFile(PostCreateRequest request)
        {

            var url = BuildUrl(request.Path, (object)request.VersionId, (object)request.Storage);
            var formParams = new Dictionary<string, object>();
            if (request.File != null)
                formParams.Add("file", (object)this.apiInvoker.ToFileInfo(request.File, "File"));
            try
            {
                string json = this.apiInvoker.InvokeApi(url, "POST", (string)null, (Dictionary<string, string>)null, formParams, "application/json");
                if (json != null)
                    return (UploadResponse)SerializationHelper.Deserialize(json, typeof(UploadResponse));
                return (UploadResponse)null;
            }
            catch (ApiException ex)
            {
                if (ex.HttpStatusCode == HttpStatusCode.NotFound)
                    return (UploadResponse)null;
                throw;
            }
        }

        public DeleteResponse DeleteFile(DeleteRequest request)
        {
            if (request.Path == null)
                throw new ApiException("Missing required parameter 'path' when calling DeleteFile", StatusCodes.ErrorInvalidInputData);

            var url = BuildUrl(request.Path, (object)request.VersionId, (object)request.Storage);
            var formParams = new Dictionary<string, object>();

            try
            {
                string json = this.apiInvoker.InvokeApi(url, "DELETE", (string)null, (Dictionary<string, string>)null, formParams, "application/json");

                if (string.IsNullOrEmpty(json))
                    return new DeleteResponse { Code = 200, Status = "OK" };

                return (DeleteResponse)SerializationHelper.Deserialize(json, typeof(DeleteResponse));
            }
            catch (ApiException ex)
            {
                if (ex.HttpStatusCode == HttpStatusCode.NotFound)
                    return (DeleteResponse)null;
                throw;
            }
        }

        private string BuildUrl(string path, object versionId, object storage)
        {
            string baseUrl = Regex
                .Replace(this.configuration.GetApiRootUrl() + "/tasks/storage/file", "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");

            var preparedPath = path
                .Replace(@"\", "/")
                .Replace(" ", "%20");

            baseUrl += string.Format("/{0}", preparedPath);

            return UrlHelper
                .AddQueryParameterToUrl(UrlHelper
                    .AddQueryParameterToUrl(baseUrl, "versionId", versionId), "storage", storage);
        }
    }
}