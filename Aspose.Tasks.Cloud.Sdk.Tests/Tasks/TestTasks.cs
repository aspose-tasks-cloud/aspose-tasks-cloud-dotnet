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

using Aspose.Tasks.Cloud.Sdk.Model;
using Aspose.Tasks.Cloud.Sdk.Model.Requests;
using Aspose.Tasks.Cloud.Sdk.Tests.Base;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Task = System.Threading.Tasks.Task;

namespace Aspose.Tasks.Cloud.Sdk.Tests.Tasks
{
    [TestFixture]
    public class TestTasks : BaseTestContext
    {
        [Test]
        public async Task TestGetTasks()
        {
            var remoteName = await UploadFileToStorageAsync("Project2016.mpp");

            var tasksResponse = await TasksApi.GetTasksAsync(new GetTasksRequest
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
        public async Task TestGetTaskByUid()
        {
            var remoteName = await UploadFileToStorageAsync("Project2016.mpp");

            var tasksResponse = await TasksApi.GetTaskAsync(new GetTaskRequest
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
        public async Task TestDeleteTask()
        {
            var remoteName = await UploadFileToStorageAsync("Project2016.mpp");

            var deleteResponse = await TasksApi.DeleteTaskAsync(new DeleteTaskRequest
            {
                TaskUid = 4,
                Name = remoteName,
                Folder = this.DataFolder,
                FileName = remoteName
            });

            Assert.AreEqual((int)HttpStatusCode.OK, deleteResponse.Code);

            var tasksResponse = await TasksApi.GetTasksAsync(new GetTasksRequest
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
        public async Task TestAddTask()
        {
            var remoteName = await UploadFileToStorageAsync("Project2016.mpp");

            var postResponse = await TasksApi.PostTaskAsync(new PostTaskRequest
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

            var tasksResponse = await TasksApi.GetTaskAsync(new GetTaskRequest
            {
                TaskUid = newTaskUid,
                Name = remoteName,
                Folder = this.DataFolder
            });

            Assert.AreEqual((int)HttpStatusCode.OK, tasksResponse.Code);
            Assert.IsNotNull(tasksResponse.Task);
        }

        [Test]
        public async Task TestAddTasks()
        {
            var remoteName = await UploadFileToStorageAsync("Home move plan.mpp");
            var firstTask = new TaskCreationRequest
            {
                TaskName = "SomeFirstTaskName"
            };
            var secondTask = new TaskCreationRequest
            {
                TaskName = "SomeSecondTaskNameWithParent",
                ParentTaskUid = 2
            };
            var request = new PostTasksRequest
            {
                Name = remoteName,
                Folder = this.DataFolder,
                Requests = new List<TaskCreationRequest> { firstTask, secondTask }
            };
            var postResponse = await TasksApi.PostTasksAsync(request);

            Assert.AreEqual((int)HttpStatusCode.Created, postResponse.Code);
            Assert.IsNotNull(postResponse.Tasks);
            Assert.AreEqual(request.Requests.Count, postResponse.Tasks.TaskItem.Count);

            var newSubtaskUid = postResponse.Tasks.TaskItem
                .Single(t => t.Name == secondTask.TaskName)
                .Uid;
            var parentTaskResponse = await TasksApi.GetTaskAsync(new GetTaskRequest
            {
                TaskUid = secondTask.ParentTaskUid,
                Name = remoteName,
                Folder = this.DataFolder
            });

            Assert.AreEqual((int)HttpStatusCode.OK, parentTaskResponse.Code);
            Assert.IsNotNull(parentTaskResponse.Task);
            Assert.Contains(newSubtaskUid, parentTaskResponse.Task.SubtasksUids);
        }

        [Test]
        public async Task TestEditTask()
        {
            var remoteName = await UploadFileToStorageAsync("Project2016.mpp");

            var getResponse = await TasksApi.GetTaskAsync(new GetTaskRequest
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

            var putResponse = await TasksApi.PutTaskAsync(new PutTaskRequest
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

            var tasksResponse = await TasksApi.GetTaskAsync(new GetTaskRequest
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
        public async Task TestGetTaskAssignments()
        {
            var remoteName = await UploadFileToStorageAsync("Home move plan.mpp");

            var response = await TasksApi.GetTaskAssignmentsAsync(new GetTaskAssignmentsRequest
            {
                Name = remoteName,
                Folder = this.DataFolder,
                TaskUid = 1
            });

            Assert.AreEqual((int)HttpStatusCode.OK, response.Code);
            Assert.IsNotNull(response.Assignments);
        }

        [Test]
        public async Task TestMoveTask()
        {
            var remoteName = await UploadFileToStorageAsync("sample.mpp");

            var getResponse = await TasksApi.GetTaskAsync(new GetTaskRequest
            {
                Name = remoteName,
                Folder = this.DataFolder,
                TaskUid = 6
            });

            Assert.AreEqual((int)HttpStatusCode.OK, getResponse.Code);
            CollectionAssert.DoesNotContain(getResponse.Task.SubtasksUids, 10);

            var response = await TasksApi.PutMoveTaskAsync(new PutMoveTaskRequest
            {
                Name = remoteName,
                Folder = this.DataFolder,
                ParentTaskUid = 6,
                TaskUid = 10
            });

            Assert.AreEqual((int)HttpStatusCode.OK, response.Code);

            getResponse = await TasksApi.GetTaskAsync(new GetTaskRequest
            {
                Name = remoteName,
                Folder = this.DataFolder,
                TaskUid = 6
            });

            Assert.AreEqual((int)HttpStatusCode.OK, getResponse.Code);
            CollectionAssert.Contains(getResponse.Task.SubtasksUids, 10);
        }

        [Test]
        public async Task TestMoveTaskToSibling()
        {
            var remoteName = await UploadFileToStorageAsync("NewProductDev.mpp");

            var response = await TasksApi.PutMoveTaskToSiblingAsync(new PutMoveTaskToSiblingRequest
            {
                Name = remoteName,
                Folder = this.DataFolder,
                TaskUid = 41,
                BeforeTaskUid = 40
            });

            Assert.AreEqual((int)HttpStatusCode.OK, response.Code);

            var getResponse = await TasksApi.GetTaskAsync(new GetTaskRequest
            {
                Name = remoteName,
                Folder = this.DataFolder,
                TaskUid = 38
            });

            Assert.AreEqual((int)HttpStatusCode.OK, getResponse.Code);
            CollectionAssert.AreEqual(new int[] { 39, 41, 40 }, getResponse.Task.SubtasksUids);
        }

        [Test]
        public async Task TestMoveTaskToSiblingNull()
        {
            var remoteName = await UploadFileToStorageAsync("NewProductDev.mpp");

            var response = await TasksApi.PutMoveTaskToSiblingAsync(new PutMoveTaskToSiblingRequest
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