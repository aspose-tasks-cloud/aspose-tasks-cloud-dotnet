
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TestRecalculation.cs">
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

namespace Aspose.Tasks.Cloud.Sdk.Tests.Reports
{
    [TestFixture]
    internal sealed class TestRecalculation : BaseTestContext
    {
        [Test]
        public void TestRecalculateProjectWithErrors()
        {
            var remoteName = UploadFileToStorage("sample.mpp");

            var responseAfterAdd = TasksApi.PostTask(new PostTaskRequest
            {
                Name = remoteName,
                Folder = this.DataFolder,
                TaskName = "NewTaskName"
            });

            Assert.AreEqual(HttpStatusCode.Created.ToString(), responseAfterAdd.Status);

            int taskUid = responseAfterAdd.TaskItem.Uid.Value;

            var response = TasksApi.GetTask(new GetTaskRequest
            {
                Name = remoteName,
                Folder = this.DataFolder,
                TaskUid = taskUid
            });

            Assert.AreEqual(HttpStatusCode.OK.ToString(), response.Status);
            Assert.IsNotNull(response.Task);
            var t = response.Task;
            t.Name = "New task Name";
            t.ActualStart = new DateTime(2000, 10, 20);
            t.ActualFinish = new DateTime(2000, 10, 09);
            t.Cost = 100;

            var responseAfterUpdate = TasksApi.PutTask(new PutTaskRequest
            {
                Task = t,
                TaskUid = taskUid,
                Name = remoteName,
                Folder = this.DataFolder,
                Recalculate = false,
            });

            Assert.AreEqual(HttpStatusCode.OK.ToString(), responseAfterUpdate.Status);

            var recalculationResponse = TasksApi.PutRecalculateProject(new PutRecalculateProjectRequest()
            {
                FileName = remoteName,
                Folder = this.DataFolder,
                Name = remoteName,
                Mode = CalculationMode.None,
                Validate = true
            });

            Assert.AreEqual(HttpStatusCode.OK.ToString(), recalculationResponse.Status);
            var validationResult = recalculationResponse.Result;
            Assert.AreEqual(ProjectValidationState.HasErrors, validationResult.ValidationState);
            Assert.AreEqual("Actual start date of task is greater than actual finish date. Task name: New task Name; Actual start date: 10/20/2000 00:00:00; Actual finish date: 10/09/2000 00:00:00", validationResult.ValidationErrorMessage);
        }


        [Test]
        public void TestRecalculateResource()
        {
            var remoteName = UploadFileToStorage("Home move plan.mpp");

            var response = TasksApi.PutRecalculateProjectResourceFields(new PutRecalculateProjectResourceFieldsRequest
            {
                Name = remoteName,
                Folder = this.DataFolder,
            });

            Assert.AreEqual("OK", response.Status);
        }

        [Test]
        public void TestRecalculateUncompleteWork()
        {
            var remoteName = UploadFileToStorage("Home move plan.mpp");

            var response = TasksApi.PutRecalculateProjectUncompleteWorkToStartAfter(new PutRecalculateProjectUncompleteWorkToStartAfterRequest
            {
                Name = remoteName,
                Folder = this.DataFolder,
                After = new DateTime(2010, 10, 10)
            });

            Assert.AreEqual("OK", response.Status);
        }

        [Test]
        public void TestRecalculateProjectWorkAsComplete()
        {
            var remoteName = UploadFileToStorage("Home move plan.mpp");

            var response = TasksApi.PutRecalculateProjectWorkAsComplete(new PutRecalculateProjectWorkAsCompleteRequest
            {
                Name = remoteName,
                Folder = this.DataFolder,
                CompleteThrough = new DateTime(2010, 10, 10)
            });

            Assert.AreEqual("OK", response.Status);
        }
    }
}
