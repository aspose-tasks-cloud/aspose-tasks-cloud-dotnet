using Aspose.Tasks.Cloud.Sdk.Model.Requests;
using Aspose.Tasks.Cloud.Sdk.Tests.Base;
using NUnit.Framework;
using System.Net;
using System.Threading.Tasks;

namespace Aspose.Tasks.Cloud.Sdk.Tests.ProjectOnline
{
    [TestFixture]
    internal sealed class TestProjectList  : BaseTestContext
    {
        [Test]
        [Ignore("Ignored because real credentials for project server online is required.")]
        public async Task TestGetProjectListByTokenCredentials()
        {
            var response = await TasksApi.GetProjectListAsync(new GetProjectListRequest
            {
                Token = "SOMESECRETTOKEN",
                SiteUrl = "http://project_server_instance.local/sites/pwa"
            });

            Assert.AreEqual((int)HttpStatusCode.OK, response.Code);
            Assert.That(response.Projects, Is.Not.Empty);
        }
        
        [Test]
        [Ignore("Ignored because real credentials for project server online is required.")]
        public async Task TestGetProjectListByLoginAndPasswordCredentials()
        {
            var response = await TasksApi.GetProjectListAsync(new GetProjectListRequest
            {
                UserName = "SomeLogin",
                XSharepointPassword = "SomePassword",
                SiteUrl = "http://project_server_instance.local/sites/pwa"
            });

            Assert.AreEqual((int)HttpStatusCode.OK, response.Code);
            Assert.That(response.Projects, Is.Not.Empty);
        }
        
        [Test]
        [Ignore("Ignored because real credentials for project server online is required.")]
        public async Task TestCreateNewProjectByTokenCredentials()
        {
            var remoteName = await UploadFileToStorageAsync("NewProductDev.mpp");
            var response = await TasksApi.CreateNewProjectAsync(new CreateNewProjectRequest()
            {
                Name = remoteName,
                XProjectOnlineToken = "SOMESECRETTOKEN",
                SiteUrl = "http://project_server_instance.local/sites/pwa"
            });

            Assert.AreEqual((int)HttpStatusCode.OK, response.Code);
        }
        
        [Test]
        [Ignore("Ignored because real credentials for project server online is required.")]
        public async Task TestCreateNewProjectByLoginAndPasswordCredentials()
        {
            var remoteName = await UploadFileToStorageAsync("NewProductDev.mpp");
            var response = await TasksApi.CreateNewProjectAsync(new CreateNewProjectRequest()
            {
                Name = remoteName,
                UserName = "SomeLogin",
                XSharepointPassword = "SomePassword",
                SiteUrl = "http://project_server_instance.local/sites/pwa"
            });

            Assert.AreEqual((int)HttpStatusCode.OK, response.Code);
        }
        
        [Test]
        [Ignore("Ignored because real credentials for project server online is required.")]
        public async Task TestUpdateProjectByTokenCredentials()
        {
            var remoteName = await UploadFileToStorageAsync("NewProductDev.mpp");
            var response = await TasksApi.UpdateProjectAsync(new UpdateProjectRequest()
            {
                Name = remoteName,
                XProjectOnlineToken = "SOMESECRETTOKEN",
                SiteUrl = "http://project_server_instance.local/sites/pwa"
            });

            Assert.AreEqual((int)HttpStatusCode.OK, response.Code);
        }
        
        [Test]
        [Ignore("Ignored because real credentials for project server online is required.")]
        public async Task TestUpdateProjectByLoginAndPasswordCredentials()
        {
            var remoteName = await UploadFileToStorageAsync("NewProductDev.mpp");
            var response = await TasksApi.UpdateProjectAsync(new UpdateProjectRequest()
            {
                Name = remoteName,
                UserName = "SomeLogin",
                XSharepointPassword = "SomePassword",
                SiteUrl = "http://project_server_instance.local/sites/pwa"
            });

            Assert.AreEqual((int)HttpStatusCode.OK, response.Code);
        }
    }
}