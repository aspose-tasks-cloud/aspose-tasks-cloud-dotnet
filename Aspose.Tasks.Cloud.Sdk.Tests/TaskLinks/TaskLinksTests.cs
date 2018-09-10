
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TaskLinksTests.cs">
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

using Aspose.Tasks.Cloud.Sdk.Tests.Base;
using Aspose.Tasks.Cloud.Sdk.Model.Requests;
using NUnit.Framework;
using Aspose.Tasks.Cloud.Sdk.Model;
using System.Net;

namespace Aspose.Tasks.Cloud.Sdk.Tests.TaskLinks
{
    [TestFixture]
    internal sealed class TaskLinksTests : BaseTestContext
    {
        [Test]
        public void TestGetTaskLinks()
        {
            var remoteName = UploadFileToStorage("NewProductDev.mpp");
            var response = TasksApi.GetTaskLinks(new GetTaskLinksRequest()
            {
                Name = remoteName,
                Folder = this.DataFolder,
                Storage = "Tasks"
            });

            Assert.AreEqual((int)HttpStatusCode.OK, response.Code);
            Assert.IsNotNull(response.TaskLinks);
            Assert.AreEqual(24, response.TaskLinks.Count);
        }

        [Test]
        public void TestAddTaskLink()
        {
            var remoteName = UploadFileToStorage("NewProductDev.mpp");
            var response = TasksApi.PostTaskLink(new PostTaskLinkRequest()
            {
                TaskLink = new TaskLink
                {
                    PredecessorUid = 28,
                    SuccessorUid = 30,
                    LinkType = TaskLinkType.StartToStart,
                    Lag = 9600,
                    LagFormat = TimeUnitType.Day
                },
                Name = remoteName,
                Folder = this.DataFolder,
                Storage = "Tasks"
            });

            Assert.AreEqual((int)HttpStatusCode.OK, response.Code);
        }

        [Test]
        public void TestEditTaskLink()
        {
            var remoteName = UploadFileToStorage("NewProductDev.mpp");

            var linksResponse = TasksApi.GetTaskLinks(new GetTaskLinksRequest()
            {
                Name = remoteName,
                Folder = this.DataFolder,
                Storage = "Tasks"
            });

            var taskLinkToEdit = linksResponse.TaskLinks[0];

            // Modification of PredecessorUid and SuccessorUid fields is not supported.
            taskLinkToEdit.LinkType = TaskLinkType.StartToFinish;
            taskLinkToEdit.Lag = 9600;
            taskLinkToEdit.LagFormat = TimeUnitType.Day;

            var response = TasksApi.PutTaskLink(new PutTaskLinkRequest()
            {
                Index = 1,
                TaskLink = taskLinkToEdit,
                Name = remoteName,
                Folder = this.DataFolder,
                Storage = "Tasks"
            });

            Assert.AreEqual((int)HttpStatusCode.OK, response.Code);

            linksResponse = TasksApi.GetTaskLinks(new GetTaskLinksRequest()
            {
                Name = remoteName,
                Folder = this.DataFolder,
                Storage = "Tasks"
            });

            Assert.AreEqual((int)HttpStatusCode.OK, response.Code);

            Assert.AreEqual(TaskLinkType.StartToFinish, linksResponse.TaskLinks[0].LinkType);
            Assert.AreEqual(9600, linksResponse.TaskLinks[0].Lag);
            Assert.AreEqual(TimeUnitType.Day, linksResponse.TaskLinks[0].LagFormat);
        }

        [Test]
        public void TestDeleteTaskLink()
        {
            var remoteName = UploadFileToStorage("NewProductDev.mpp");

            var deleteResponse = TasksApi.DeleteTaskLink(new DeleteTaskLinkRequest()
            {
                Index = 1,
                Name = remoteName,
                Folder = this.DataFolder,
                Storage = "Tasks"
            });

            Assert.AreEqual((int)HttpStatusCode.OK, deleteResponse.Code);

            var linksResponse = TasksApi.GetTaskLinks(new GetTaskLinksRequest()
            {
                Name = remoteName,
                Folder = this.DataFolder,
                Storage = "Tasks"
            });

            Assert.AreEqual((int)HttpStatusCode.OK, linksResponse.Code);
            Assert.IsNotNull(linksResponse.TaskLinks);
            Assert.AreEqual(23, linksResponse.TaskLinks.Count);
        }
    }
}
