using System.IO;

namespace Aspose.Tasks.Cloud.Sdk.Model.Requests
{
    public class PostCreateRequest
    {
        public PostCreateRequest()
        {
        }

        public PostCreateRequest(string path, Stream file, string versionId = null, string storage = null)
        {
            this.Path = path;
            this.File = file;
            this.VersionId = versionId;
            this.Storage = storage;
        }

        public string Path { get; set; }

        public Stream File { get; set; }

        public string VersionId { get; set; }

        public string Storage { get; set; }
    }
}