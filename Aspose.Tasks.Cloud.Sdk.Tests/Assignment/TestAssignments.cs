
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TestAssignments.cs">
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
using System.Linq;

using Aspose.Tasks.Cloud.Sdk.Tests.Base;
using Aspose.Tasks.Cloud.Sdk.Model.Requests;
using NUnit.Framework;
using Aspose.Tasks.Cloud.Sdk.Model;

namespace Aspose.Tasks.Cloud.Sdk.Tests.Tasks
{
    [TestFixture]
    public class TestAssignments : BaseTestContext
    {
        [Test]
        public void TestGetAssignments()
        {
            var remoteName = UploadFileToStorage("NewProductDev.mpp");

            var response = TasksApi.GetAssignments(new GetAssignmentsRequest
            {
                Name = remoteName,
                Folder = this.DataFolder
            });

            Assert.AreEqual(HttpStatusCode.OK.ToString(), response.Status);
            Assert.IsNotNull(response.Assignments);
            Assert.AreEqual(6, response.Assignments.AssignmentItem.Count);
            Assert.AreEqual(34, response.Assignments.AssignmentItem[0].TaskUid);
            Assert.AreEqual(63, response.Assignments.AssignmentItem[0].Uid);
            Assert.AreEqual("/63", response.Assignments.AssignmentItem[0].Link.Href);
        }

        [Test]
        public void TestGetAssignment()
        {
            var remoteName = UploadFileToStorage("NewProductDev.mpp");

            var response = TasksApi.GetAssignment(new GetAssignmentRequest
            {
                AssignmentUid = 63,
                Name = remoteName,
                Folder = this.DataFolder
            });

            Assert.AreEqual(HttpStatusCode.OK.ToString(), response.Status);
            Assert.IsNotNull(response.Assignment);
            Assert.AreEqual(TimeSpan.FromHours(8), response.Assignment.RegularWork);
            Assert.AreEqual(TimeSpan.FromHours(8), response.Assignment.RemainingWork);
            Assert.AreEqual(new DateTime(2012, 7, 9, 8, 0, 0), response.Assignment.Start.Value);
        }

        [Test]
        public void TestGetResourceAssignments()
        {
            var remoteName = UploadFileToStorage("NewProductDev.mpp");

            var response = TasksApi.GetResourceAssignments(new GetResourceAssignmentsRequest
            {
                ResourceUid = 1,
                Name = remoteName,
                Folder = this.DataFolder
            });

            Assert.AreEqual(HttpStatusCode.OK.ToString(), response.Status);
            Assert.IsNotNull(response.Assignments);
            Assert.AreEqual(6, response.Assignments.List.Count);
            Assert.IsTrue(response.Assignments.List.All(a => a.ResourceUid == 1));
        }

        [Test]
        public void TestAddAssignment()
        {
            var remoteName = UploadFileToStorage("NewProductDev.mpp");

            var response = TasksApi.PostAssignment(new PostAssignmentRequest
            {
                ResourceUid = 1,
                Units = 0.5D,
                TaskUid = 0,
                Name = remoteName,
                Folder = this.DataFolder
            });

            Assert.AreEqual(HttpStatusCode.OK.ToString(), response.Status);
            Assert.IsNotNull(response.AssignmentItem);
            var assignmentUid = response.AssignmentItem.Uid;

            var getResponse = TasksApi.GetAssignment(new GetAssignmentRequest
            {
                AssignmentUid = assignmentUid,
                Name = remoteName,
                Folder = this.DataFolder
            });

            var getTaskResponse = TasksApi.GetTask(new GetTaskRequest
            {
                TaskUid = 0,
                Name = remoteName,
                Folder = this.DataFolder
            });

            Assert.AreEqual(HttpStatusCode.OK.ToString(), getResponse.Status);
            Assert.IsNotNull(getResponse.Assignment);
            Assert.AreEqual(0, getResponse.Assignment.TaskUid);
            Assert.AreEqual(1, getResponse.Assignment.ResourceUid);

            Assert.AreEqual(getTaskResponse.Task.Start, getResponse.Assignment.Start);
            Assert.AreEqual(getTaskResponse.Task.Finish, getResponse.Assignment.Finish);
            Assert.AreEqual(getTaskResponse.Task.Work, getResponse.Assignment.Work);
            Assert.AreEqual(getTaskResponse.Task.Cost, getResponse.Assignment.Cost);
        }

        [Test]
        public void TestEditAssignment()
        {
            var remoteName = UploadFileToStorage("NewProductDev.mpp");

            var response = TasksApi.GetAssignment(new GetAssignmentRequest
            {
                AssignmentUid = 63,
                Name = remoteName,
                Folder = this.DataFolder
            });

            Assert.AreEqual(HttpStatusCode.OK.ToString(), response.Status);
            Assert.IsNotNull(response.Assignment);

            response.Assignment.TaskUid = 0;

            var putResponse = TasksApi.PutAssignment(new PutAssignmentRequest
            {
                Mode = CalculationMode.Automatic,
                Recalculate = true,
                AssignmentUid = 63,
                Assignment = response.Assignment,
                Name = remoteName,
                Folder = this.DataFolder
            });

            Assert.AreEqual(HttpStatusCode.OK.ToString(), putResponse.Status);

            var getResponse = TasksApi.GetAssignments(new GetAssignmentsRequest
            {
                Name = remoteName,
                Folder = this.DataFolder
            });

            Assert.AreEqual(HttpStatusCode.OK.ToString(), getResponse.Status);
            Assert.IsFalse(getResponse.Assignments.AssignmentItem.Any(a => a.TaskUid == 34 && a.ResourceUid == 1));
            Assert.IsTrue(getResponse.Assignments.AssignmentItem.Any(a => a.TaskUid == 0 && a.ResourceUid == 1 && a.Uid == 63));
        }

        [Test]
        public void TestDeleteAssignment()
        {
            var remoteName = UploadFileToStorage("NewProductDev.mpp");

            var response = TasksApi.DeleteAssignment(new DeleteAssignmentRequest
            {
                AssignmentUid = 63,
                Name = remoteName,
                Folder = this.DataFolder
            });

            Assert.AreEqual(HttpStatusCode.OK.ToString(), response.Status);

            var getResponse = TasksApi.GetAssignments(new GetAssignmentsRequest
            {
                Name = remoteName,
                Folder = this.DataFolder
            });

            Assert.AreEqual(HttpStatusCode.OK.ToString(), getResponse.Status);
            Assert.IsNull(getResponse.Assignments.AssignmentItem.FirstOrDefault(a => a.TaskUid == 34 && a.ResourceUid == 1));
            Assert.IsNull(getResponse.Assignments.AssignmentItem.FirstOrDefault(a => a.Uid == 63));
        }
    }
}
