
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TestTasks.cs">
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
using System.Collections.Generic;
using System.Linq;
using System.Net;

using Aspose.Tasks.Cloud.Sdk.Tests.Base;
using Aspose.Tasks.Cloud.Sdk.Model.Requests;
using NUnit.Framework;
using Aspose.Tasks.Cloud.Sdk.Model;
using Aspose.Tasks.Cloud.Sdk.Internal;

namespace Aspose.Tasks.Cloud.Sdk.Tests.Tasks
{
    [TestFixture]
    public class TestTasks : BaseTestContext
    {
        [Test]
        public void TestGetTasks()
        {
            var remoteName = UploadFileToStorage("Project2016.mpp");

            var tasksResponse = TasksApi.GetTasks(new GetTasksRequest
            {
                Name = remoteName,
                Folder = this.DataFolder
            });

            Assert.AreEqual((int)HttpStatusCode.OK, tasksResponse.Code);
            Assert.IsNotNull(tasksResponse.Tasks);
            Assert.AreEqual(6, tasksResponse.Tasks.TaskItem.Count);

            var firstTask = tasksResponse.Tasks.TaskItem.FirstOrDefault(i => i.Uid == 5);
            Assert.IsNotNull(firstTask);
            Assert.AreEqual("Summary Task 1", firstTask.Name);
            Assert.AreEqual(new DateTime(2015, 8, 3, 8, 0, 0), firstTask.Start);
            Assert.AreEqual(new DateTime(2015, 8, 6, 17, 0, 0), firstTask.Finish);
            Assert.AreEqual("/5", firstTask.Link.Href);
        }

        [Test]
        public void TestGetTaskByUid()
        {
            var remoteName = UploadFileToStorage("Project2016.mpp");

            var tasksResponse = TasksApi.GetTask(new GetTaskRequest
            {
                TaskUid = 5,
                Name = remoteName,
                Folder = this.DataFolder
            });

            Assert.AreEqual((int)HttpStatusCode.OK, tasksResponse.Code);
            Assert.IsNotNull(tasksResponse.Task);
            Assert.AreEqual(5, tasksResponse.Task.Uid);
            CollectionAssert.AreEquivalent(new[] { 1, 2, 3, 4 }, tasksResponse.Task.SubtasksUids);
            Assert.AreEqual(new DateTime(2015, 8, 3, 8, 0, 0), tasksResponse.Task.Start);
            Assert.AreEqual(new DateTime(2015, 8, 6, 17, 0, 0), tasksResponse.Task.Finish);
            Assert.AreEqual(new TimeSpan(1, 8, 0, 0, 0), tasksResponse.Task.RemainingWork);
            Assert.AreEqual(1920, tasksResponse.Task.WorkVariance);
        }

        [Test]
        public void TestDeleteTask()
        {
            var remoteName = UploadFileToStorage("Project2016.mpp");

            var deleteResponse = TasksApi.DeleteTask(new DeleteTaskRequest
            {
                TaskUid = 4,
                Name = remoteName,
                Folder = this.DataFolder,
                FileName = remoteName
            });

            Assert.AreEqual((int)HttpStatusCode.OK, deleteResponse.Code);

            var tasksResponse = TasksApi.GetTasks(new GetTasksRequest
            {
                Name = remoteName,
                Folder = this.DataFolder
            });

            Assert.AreEqual((int)HttpStatusCode.OK, tasksResponse.Code);
            Assert.IsNotNull(tasksResponse.Tasks);
            Assert.AreEqual(5, tasksResponse.Tasks.TaskItem.Count);

            var firstTask = tasksResponse.Tasks.TaskItem.FirstOrDefault(i => i.Uid == 4);
            Assert.IsNull(firstTask);
        }

        [Test]
        public void TestAddTask()
        {
            var remoteName = UploadFileToStorage("Project2016.mpp");

            var postResponse = TasksApi.PostTask(new PostTaskRequest
            {
                BeforeTaskId = 4,
                TaskName = "New task name",
                Name = remoteName,
                Folder = this.DataFolder,
                FileName = remoteName
            });

            Assert.AreEqual((int)HttpStatusCode.Created, postResponse.Code);
            Assert.IsNotNull(postResponse.TaskItem);
            var newTaskUid = postResponse.TaskItem.Uid;

            var tasksResponse = TasksApi.GetTask(new GetTaskRequest
            {
                TaskUid = newTaskUid,
                Name = remoteName,
                Folder = this.DataFolder
            });

            Assert.AreEqual((int)HttpStatusCode.OK, tasksResponse.Code);
            Assert.IsNotNull(tasksResponse.Task);
        }

        [Test]
        public void TestEditTask()
        {
            var remoteName = UploadFileToStorage("Project2016.mpp");

            var getResponse = TasksApi.GetTask(new GetTaskRequest
            {
                TaskUid = 4,
                Name = remoteName,
                Folder = this.DataFolder,
            });

            var task = getResponse.Task;
            task.Name = "Modified task name";
            task.IsManual = true;
            task.ManualStart = new DateTime(2015, 10, 1, 9, 15, 0);
            task.ManualFinish = new DateTime(2015, 10, 1, 17, 15, 0);

            var putResponse = TasksApi.PutTask(new PutTaskRequest
            {
                TaskUid = 4,
                Task = task,
                FileName = remoteName,
                Name = remoteName,
                Folder = this.DataFolder,
                Mode = CalculationMode.None,
                Recalculate = false
            });

            Assert.AreEqual((int)HttpStatusCode.OK, putResponse.Code);

            var tasksResponse = TasksApi.GetTask(new GetTaskRequest
            {
                TaskUid = 4,
                Name = remoteName,
                Folder = this.DataFolder
            });

            Assert.AreEqual((int)HttpStatusCode.OK, tasksResponse.Code);
            Assert.IsNotNull(tasksResponse.Task);
            Assert.AreEqual("Modified task name", tasksResponse.Task.Name);

            Assert.IsTrue(tasksResponse.Task.IsManual);
            Assert.AreEqual(new DateTime(2015, 10, 1, 9, 15, 0), tasksResponse.Task.ManualStart);
            Assert.AreEqual(new DateTime(2015, 10, 1, 17, 15, 0), tasksResponse.Task.ManualFinish);
        }

        [Test]
        public void TestGetTaskAssignments()
        {
            var remoteName = UploadFileToStorage("Home move plan.mpp");

            var response = TasksApi.GetTaskAssignments(new GetTaskAssignmentsRequest
            {
                Name = remoteName,
                Folder = this.DataFolder,
                TaskUid = 1
            });

            Assert.AreEqual((int)HttpStatusCode.OK, response.Code);
            Assert.IsNotNull(response.Assignments);
        }

        [Test]
        public void TestMoveTask()
        {
            var remoteName = UploadFileToStorage("sample.mpp");

            var getResponse = TasksApi.GetTask(new GetTaskRequest
            {
                Name = remoteName,
                Folder = this.DataFolder,
                TaskUid = 6
            });

            Assert.AreEqual((int)HttpStatusCode.OK, getResponse.Code);
            CollectionAssert.DoesNotContain(getResponse.Task.SubtasksUids, 10);

            var response = TasksApi.PutMoveTask(new PutMoveTaskRequest
            {
                Name = remoteName,
                Folder = this.DataFolder,
                ParentTaskUid = 6,
                TaskUid = 10
            });

            Assert.AreEqual((int)HttpStatusCode.OK, response.Code);

            getResponse = TasksApi.GetTask(new GetTaskRequest
            {
                Name = remoteName,
                Folder = this.DataFolder,
                TaskUid = 6
            });

            Assert.AreEqual((int)HttpStatusCode.OK, getResponse.Code);
            CollectionAssert.Contains(getResponse.Task.SubtasksUids, 10);
        }

        [Test]
        public void TestMoveTaskToSibling()
        {
            var remoteName = UploadFileToStorage("NewProductDev.mpp");

            var response = TasksApi.PutMoveTaskToSibling(new PutMoveTaskToSiblingRequest
            {
                Name = remoteName,
                Folder = this.DataFolder,
                TaskUid = 41,
                BeforeTaskUid = 40
            });

            Assert.AreEqual((int)HttpStatusCode.OK, response.Code);

            var getResponse = TasksApi.GetTask(new GetTaskRequest
            {
                Name = remoteName,
                Folder = this.DataFolder,
                TaskUid = 38
            });

            Assert.AreEqual((int)HttpStatusCode.OK, getResponse.Code);
            CollectionAssert.AreEqual(new int[] { 39, 41, 40 }, getResponse.Task.SubtasksUids);
        }

        [Test]
        public void TestMoveTaskToSiblingNull()
        {
            var remoteName = UploadFileToStorage("NewProductDev.mpp");

            var response = TasksApi.PutMoveTaskToSibling(new PutMoveTaskToSiblingRequest
               {
                   Name = remoteName,
                   Folder = this.DataFolder,
                   TaskUid = 99999,
                   BeforeTaskUid = -1
               });

            Assert.IsNull(response);
        }
    }
}
