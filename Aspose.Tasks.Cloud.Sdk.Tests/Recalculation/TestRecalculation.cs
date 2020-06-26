
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

using Aspose.Tasks.Cloud.Sdk.Model;
using Aspose.Tasks.Cloud.Sdk.Model.Requests;
using Aspose.Tasks.Cloud.Sdk.Tests.Base;
using NUnit.Framework;
using System;
using System.Net;
using Task = System.Threading.Tasks.Task;

namespace Aspose.Tasks.Cloud.Sdk.Tests.Reports
{
    [TestFixture]
    internal sealed class TestRecalculation : BaseTestContext
    {
        [Test]
        public async Task TestRecalculateProjectWithErrors()
        {
            var remoteName = await UploadFileToStorageAsync("sample.mpp");

            var responseAfterAdd = await TasksApi.PostTaskAsync(new PostTaskRequest
            {
                Name = remoteName,
                Folder = this.DataFolder,
                TaskName = "NewTaskName"
            });

            Assert.AreEqual((int)HttpStatusCode.Created, responseAfterAdd.Code);

            int taskUid = responseAfterAdd.TaskItem.Uid.Value;

            var response = await TasksApi.GetTaskAsync(new GetTaskRequest
            {
                Name = remoteName,
                Folder = this.DataFolder,
                TaskUid = taskUid
            });

            Assert.AreEqual((int)HttpStatusCode.OK, response.Code);
            Assert.IsNotNull(response.Task);
            var t = response.Task;
            t.Name = "New task Name";
            t.ActualStart = new DateTime(2000, 10, 20);
            t.ActualFinish = new DateTime(2000, 10, 09);
            t.Cost = 100;

            var responseAfterUpdate = await TasksApi.PutTaskAsync(new PutTaskRequest
            {
                Task = t,
                TaskUid = taskUid,
                Name = remoteName,
                Folder = this.DataFolder,
                Recalculate = false,
            });

            Assert.AreEqual((int)HttpStatusCode.OK, responseAfterUpdate.Code);

            var recalculationResponse = await TasksApi.PutRecalculateProjectAsync(new PutRecalculateProjectRequest()
            {
                FileName = remoteName,
                Folder = this.DataFolder,
                Name = remoteName,
                Mode = CalculationMode.None,
                Validate = true
            });

            Assert.AreEqual((int)HttpStatusCode.OK, recalculationResponse.Code);
            var validationResult = recalculationResponse.Result;
            Assert.AreEqual(ProjectValidationState.Valid, validationResult.ValidationState);
        }


        [Test]
        public async Task TestRecalculateResource()
        {
            var remoteName = await UploadFileToStorageAsync("Home move plan.mpp");

            var response = await TasksApi.PutRecalculateProjectResourceFieldsAsync(new PutRecalculateProjectResourceFieldsRequest
            {
                Name = remoteName,
                Folder = this.DataFolder,
            });

            Assert.AreEqual((int)HttpStatusCode.OK, response.Code);
        }

        [Test]
        public async Task TestRecalculateUncompleteWork()
        {
            var remoteName = await UploadFileToStorageAsync("Home move plan.mpp");

            var response = await TasksApi.PutRecalculateProjectUncompleteWorkToStartAfterAsync(new PutRecalculateProjectUncompleteWorkToStartAfterRequest
            {
                Name = remoteName,
                Folder = this.DataFolder,
                After = new DateTime(2010, 10, 10)
            });

            Assert.AreEqual((int)HttpStatusCode.OK, response.Code);
        }

        [Test]
        public async Task TestRecalculateProjectWorkAsComplete()
        {
            var remoteName = await UploadFileToStorageAsync("Home move plan.mpp");

            var response = await TasksApi.PutRecalculateProjectWorkAsCompleteAsync(new PutRecalculateProjectWorkAsCompleteRequest
            {
                Name = remoteName,
                Folder = this.DataFolder,
                CompleteThrough = new DateTime(2010, 10, 10)
            });

            Assert.AreEqual((int)HttpStatusCode.OK, response.Code);
        }
    }
}
