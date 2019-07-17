namespace Aspose.Tasks.Cloud.Sdk.Model.Requests
{
    public class DeleteRequest
    {
        public DeleteRequest(string path, string versionId = null, string storage = null)
        {
            this.Path = path;
            this.VersionId = versionId;
            this.Storage = storage;
        }

        public string Path { get; set; }

        public string VersionId { get; set; }

        public string Storage { get; set; }
    }
}
