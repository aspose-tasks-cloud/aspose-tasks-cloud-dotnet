// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TestImportProject.cs">
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

using Aspose.Tasks.Cloud.Sdk.Model;
using Aspose.Tasks.Cloud.Sdk.Model.Requests;
using Aspose.Tasks.Cloud.Sdk.Tests.Base;
using NUnit.Framework;
using System;
using System.IO;
using System.Net;
using Task = System.Threading.Tasks.Task;

namespace Aspose.Tasks.Cloud.Sdk.Tests.Project
{
    [TestFixture]
    internal sealed class TestImportProject : BaseTestContext
    {
        [Test]
        public async Task TestImportFromPrimaveraFile()
        {
            var remote = await UploadFileToStorageAsync("p6_multiproject.xml");

            var response = await TasksApi.PutImportProjectFromFileAsync(new PutImportProjectFromFileRequest
            {
                Name = remote,
                Folder = this.DataFolder,
                Filename = "imported_from_primavera.xml",
                ProjectUid = "111",
                FileType = ImportedProjectType.PrimaveraXml,
                OutputFileFormat = ProjectFileFormat.P6xml
            });

            Assert.AreEqual((int)HttpStatusCode.OK, response.Code);

            var getTasksResponse = await TasksApi.GetTasksAsync(new GetTasksRequest
            {
                Name = "imported_from_primavera.xml",
                Folder = this.DataFolder
            });

            Assert.AreEqual((int)HttpStatusCode.OK, getTasksResponse.Code);
            Assert.AreEqual(12, getTasksResponse.Tasks.TaskItem.Count);
        }

        [Test]
        [Ignore("SQL instance in required in order to run test")] 
        public async Task TestImportFromMsp()
        {
            var response = await TasksApi.PutImportProjectFromDbAsync(new PutImportProjectFromDbRequest
            {
                ConnectionString = "Data Source=db.contoso.com;Initial Catalog=ProjectServer;Persist Security Info=True;User ID=sa;Password=pwd;",
                DatabaseType = ProjectDatabaseType.Msp,
                Folder = this.DataFolder,
                Filename = "imported_from_db.xml",
                ProjectUid = "E6426C44-D6CB-4B9C-AF16-48910ACE0F54",
                DatabaseSchema = "dbo",
                Format = ProjectFileFormat.P6xml
            });

            Assert.AreEqual((int)HttpStatusCode.OK, response.Code);

            var getProjectIdsResponse = await TasksApi.GetProjectIdsAsync(new GetProjectIdsRequest
            {
                Name = "imported_from_mdp.xml",
                Folder = this.DataFolder
            });

            Assert.AreEqual((int)HttpStatusCode.OK, getProjectIdsResponse.Code);
            CollectionAssert.AreEquivalent(new string[] { "1" }, getProjectIdsResponse.ProjectIds);
        }
        

        [Test]
        [Ignore("Ignored because real credentials for project server online is required.")] 
        public async Task TestImportFromProjectOnline()
        {
            var fileName = "NewProductDev.mpp";
            var getFileRequest = new DownloadFileRequest
            {
                Path = fileName
            };
            var importFileRequest = new PutImportProjectFromProjectOnlineRequest
            {
                Name = fileName,
                Guid = Guid.Parse("E6426C44-D6CB-4B9C-AF16-48910ACE0F54"),
                Token = "SOMESECRETTOKEN",
                SiteUrl = "https://your_company_name.sharepoint.com",
                Format = ProjectFileFormat.Xml
            };
            Stream binaryResponse = null;

            var exception = Assert.ThrowsAsync<ApiException>(async () => binaryResponse = await TasksApi.DownloadFileAsync(getFileRequest));
            Assert.AreEqual(HttpStatusCode.NotFound, exception.HttpStatusCode); 
            
            var response = await TasksApi.PutImportProjectFromProjectOnlineAsync(importFileRequest);
            Assert.AreEqual(HttpStatusCode.OK.ToString(), (string)response.Status);

            Assert.DoesNotThrowAsync(async () => binaryResponse = await TasksApi.DownloadFileAsync(getFileRequest));
            Assert.That(binaryResponse, Is.Not.Null);
            
            binaryResponse.Dispose();
            await TasksApi.DeleteFileAsync((new DeleteRequest(fileName)));
        }
    }
}
