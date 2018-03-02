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

using System;

using Aspose.Tasks.Cloud.Sdk.Tests.Base;
using Aspose.Tasks.Cloud.Sdk.Model.Requests;
using NUnit.Framework;
using Aspose.Tasks.Cloud.Sdk.Model;

namespace Aspose.Tasks.Cloud.Sdk.Tests.Project
{
    [TestFixture]
    internal sealed class TestImportProject : BaseTestContext
    {
        [Test]
        public void TestImportFromPrimaveraFile()
        {
            var remote = UploadFileToStorage("p6_multiproject.xml");

            var response = TasksApi.PutImportProjectFromFile(new PutImportProjectFromFileRequest
            {
                Name = remote,
                Folder = this.DataFolder,
                Filename = "imported_from_primavera.xml",
                ProjectUid = "111",
                FileType = ImportedProjectType.PrimaveraXml,
                OutputFileFormat = ProjectFileFormat.P6xml
            });

            Assert.AreEqual(HttpStatusCode.OK.ToString(), response.Status);

            var getTasksResponse = TasksApi.GetTasks(new GetTasksRequest
            {
                Name = "imported_from_primavera.xml",
                Folder = this.DataFolder
            });

            Assert.AreEqual(HttpStatusCode.OK.ToString(), getTasksResponse.Status);
            Assert.AreEqual(12, getTasksResponse.Tasks.TaskItem.Count);
        }

        [Test]
        [Ignore("SQL instance in required in order to run test")]
        public void TestImportFromMsp()
        {
            var response = TasksApi.PutImportProjectFromDb(new PutImportProjectFromDbRequest
            {
                ConnectionString = "Data Source=db.contoso.com;Initial Catalog=ProjectServer;Persist Security Info=True;User ID=sa;Password=pwd;",
                DatabaseType = ProjectDatabaseType.Msp,
                Folder = this.DataFolder,
                Filename = "imported_from_db.xml",
                ProjectUid = "E6426C44-D6CB-4B9C-AF16-48910ACE0F54",
                DatabaseSchema = "dbo",
                Format = ProjectFileFormat.P6xml
            });

            Assert.AreEqual(HttpStatusCode.OK.ToString(), response.Status);

            var getProjectIdsResponse = TasksApi.GetProjectIds(new GetProjectIdsRequest
            {
                Name = "imported_from_mdp.xml",
                Folder = this.DataFolder
            });

            Assert.AreEqual(HttpStatusCode.OK.ToString(), getProjectIdsResponse.Status);
            CollectionAssert.AreEquivalent(new string[] { "1" }, getProjectIdsResponse.ProjectIds);
        }
    }
}
