using System.Net;
using Aspose.Tasks.Cloud.Sdk.Model.Requests;
using Aspose.Tasks.Cloud.Sdk.Tests.Base;
using NUnit.Framework;

namespace Aspose.Tasks.Cloud.Sdk.Tests.ProjectOnline
{
    [TestFixture]
    internal sealed class TestProjectList  : BaseTestContext
    {
        [Test]
        [Ignore("Ignored because real credentials for project server online is required.")]
        public void TestGetProjectList()
        {
            var response = TasksApi.GetProjectList(new GetProjectListRequest
            {
                Token = "SOMESECRETTOKEN",
                SiteUrl = "https://your_company_name.sharepoint.com"
            });

            Assert.AreEqual((int)HttpStatusCode.OK, response.Code);
            Assert.That(response.Projects, Is.Not.Empty);
        }
    }
}