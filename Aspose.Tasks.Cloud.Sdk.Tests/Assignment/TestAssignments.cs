
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

using Aspose.Tasks.Cloud.Sdk.Model;
using Aspose.Tasks.Cloud.Sdk.Model.Requests;
using Aspose.Tasks.Cloud.Sdk.Tests.Base;
using NUnit.Framework;
using System;
using System.Linq;
using System.Net;
using Task = System.Threading.Tasks.Task;
using TD = Aspose.Tasks.Cloud.Sdk.Model.TimephasedData;

namespace Aspose.Tasks.Cloud.Sdk.Tests.Tasks
{

    [TestFixture]
    public class TestAssignments : BaseTestContext
    {
        [Test]
        public async Task TestGetAssignments()
        {
            var remoteName = await UploadFileToStorageAsync("NewProductDev.mpp");

            var response = await TasksApi.GetAssignmentsAsync(new GetAssignmentsRequest
            {
                Name = remoteName,
                Folder = this.DataFolder
            });
            Assert.AreEqual((int)HttpStatusCode.OK, response.Code);
            Assert.IsNotNull(response.Assignments);
            Assert.AreEqual(6, response.Assignments.AssignmentItem.Count);
            Assert.AreEqual(34, response.Assignments.AssignmentItem[0].TaskUid);
            Assert.AreEqual(63, response.Assignments.AssignmentItem[0].Uid);
            Assert.AreEqual("/63", response.Assignments.AssignmentItem[0].Link.Href);
        }

        [Test]
        public async Task TestGetAssignment()
        {
            var remoteName = await UploadFileToStorageAsync("NewProductDev.mpp");

            var response = await TasksApi.GetAssignmentAsync(new GetAssignmentRequest
            {
                AssignmentUid = 63,
                Name = remoteName,
                Folder = this.DataFolder
            });

            Assert.AreEqual((int)HttpStatusCode.OK, response.Code);
            Assert.IsNotNull(response.Assignment);
            Assert.AreEqual(TimeSpan.FromHours(8), response.Assignment.RegularWork);
            Assert.AreEqual(TimeSpan.FromHours(8), response.Assignment.RemainingWork);
            Assert.AreEqual(new DateTime(2012, 7, 9, 8, 0, 0), response.Assignment.Start.Value);
        }

        [Test]
        public async Task TestGetResourceAssignments()
        {
            var remoteName = await UploadFileToStorageAsync("NewProductDev.mpp");

            var response = await TasksApi.GetResourceAssignmentsAsync(new GetResourceAssignmentsRequest
            {
                ResourceUid = 1,
                Name = remoteName,
                Folder = this.DataFolder
            });

            Assert.AreEqual((int)HttpStatusCode.OK, response.Code);
            Assert.IsNotNull(response.Assignments);
            Assert.AreEqual(6, response.Assignments.List.Count);
            Assert.IsTrue(response.Assignments.List.All(a => a.ResourceUid == 1));
        }

        [Test]
        public async Task TestAddAssignment()
        {
            var remoteName = await UploadFileToStorageAsync("NewProductDev.mpp");

            var response = await TasksApi.PostAssignmentAsync(new PostAssignmentRequest
            {
                ResourceUid = 1,
                Units = 0.5D,
                TaskUid = 0,
                Name = remoteName,
                Folder = this.DataFolder
            });

            Assert.AreEqual((int)HttpStatusCode.OK, response.Code);
            Assert.IsNotNull(response.AssignmentItem);
            var assignmentUid = response.AssignmentItem.Uid;

            var getResponse = await TasksApi.GetAssignmentAsync(new GetAssignmentRequest
            {
                AssignmentUid = assignmentUid,
                Name = remoteName,
                Folder = this.DataFolder
            });

            var getTaskResponse = await TasksApi.GetTaskAsync(new GetTaskRequest
            {
                TaskUid = 0,
                Name = remoteName,
                Folder = this.DataFolder
            });

            Assert.AreEqual((int)HttpStatusCode.OK, getResponse.Code);
            Assert.IsNotNull(getResponse.Assignment);
            Assert.AreEqual(0, getResponse.Assignment.TaskUid);
            Assert.AreEqual(1, getResponse.Assignment.ResourceUid);

            Assert.AreEqual(getTaskResponse.Task.Start, getResponse.Assignment.Start);
            Assert.AreEqual(getTaskResponse.Task.Finish, getResponse.Assignment.Finish);
            Assert.AreEqual(getTaskResponse.Task.Work, getResponse.Assignment.Work);
            Assert.AreEqual(getTaskResponse.Task.Cost, getResponse.Assignment.Cost);
        }

        [Test]
        public async Task TestAddAssignmentWithCost()
        {
            var remoteName = await UploadFileToStorageAsync("Cost_Res.mpp");

            var response = await TasksApi.PostAssignmentAsync(new PostAssignmentRequest
            {
                ResourceUid = 1,
                Cost = 2,
                TaskUid = 0,
                Name = remoteName,
                Folder = this.DataFolder
            });

            Assert.AreEqual((int)HttpStatusCode.OK, response.Code);
            Assert.IsNotNull(response.AssignmentItem);
            var assignmentUid = response.AssignmentItem.Uid;

            var getResponse = await TasksApi.GetAssignmentAsync(new GetAssignmentRequest
            {
                AssignmentUid = assignmentUid,
                Name = remoteName,
                Folder = this.DataFolder
            });

            Assert.AreEqual((int)HttpStatusCode.OK, getResponse.Code);
            Assert.IsNotNull(getResponse.Assignment);
            Assert.AreEqual(0, getResponse.Assignment.TaskUid);
            Assert.AreEqual(2, getResponse.Assignment.Cost);
        }

        [Test]
        public async Task TestEditAssignment()
        {
            var remoteName = await UploadFileToStorageAsync("NewProductDev.mpp");

            var response = await TasksApi.GetAssignmentAsync(new GetAssignmentRequest
            {
                AssignmentUid = 63,
                Name = remoteName,
                Folder = this.DataFolder
            });

            Assert.AreEqual((int)HttpStatusCode.OK, response.Code);
            Assert.IsNotNull(response.Assignment);

            response.Assignment.TaskUid = 0;

            var putResponse = await TasksApi.PutAssignmentAsync(new PutAssignmentRequest
            {
                Mode = CalculationMode.Automatic,
                Recalculate = true,
                AssignmentUid = 63,
                Assignment = response.Assignment,
                Name = remoteName,
                Folder = this.DataFolder
            });

            Assert.AreEqual((int)HttpStatusCode.OK, putResponse.Code);

            var getResponse = await TasksApi.GetAssignmentsAsync(new GetAssignmentsRequest
            {
                Name = remoteName,
                Folder = this.DataFolder
            });

            Assert.AreEqual((int)HttpStatusCode.OK, getResponse.Code);
            Assert.IsFalse(getResponse.Assignments.AssignmentItem.Any(a => a.TaskUid == 34 && a.ResourceUid == 1));
            Assert.IsTrue(getResponse.Assignments.AssignmentItem.Any(a => a.TaskUid == 0 && a.ResourceUid == 1 && a.Uid == 63));
        }

        [Test]
        public async Task TestEditAssignmentWithTimephasedDataAndBaselines()
        {
            var remoteName = await UploadFileToStorageAsync("sample.mpp");

            var response = await TasksApi.GetAssignmentAsync(new GetAssignmentRequest
            {
                AssignmentUid = 1,
                Name = remoteName,
                Folder = this.DataFolder
            });

            Assert.AreEqual((int)HttpStatusCode.OK, response.Code);
            Assert.IsNotNull(response.Assignment);

            var assignment = response.Assignment;
            assignment.Cost = 100;
            assignment.Start = new DateTime(2001, 10, 10);
            assignment.Finish = new DateTime(2002, 10, 10);
            assignment.ActualWork = new TimeSpan(10, 10, 10);
            assignment.ActualCost = 100;
            assignment.ActualStart = new DateTime(2001, 10, 11);
            assignment.ActualFinish = new DateTime(2002, 10, 11);
            assignment.ActualOvertimeWork = new TimeSpan(100, 10, 0);
            assignment.Work = new TimeSpan(80, 0, 0);
            assignment.Uid = 1;
            assignment.Vac = 10;
            assignment.WorkContour = WorkContourType.Contoured;
            assignment.TimephasedData.Clear();
            assignment.TimephasedData.Add(new TD
            {
                Uid = assignment.Uid,
                Start = new DateTime(2001, 10, 10, 9, 0, 0, 0),
                Finish = new DateTime(2001, 10, 10, 14, 0, 0, 0),
                Unit = TimeUnitType.Hour,
                Value = TimeSpan.FromHours(4).ToString(),
                TimephasedDataType = TimephasedDataType.AssignmentRemainingWork
            });
            assignment.Baselines.Add(new AssignmentBaseline
            {
                BaselineNumber = BaselineType.Baseline1,
                Start = new DateTime(2002, 10, 10)
            });

            var putResponse = await TasksApi.PutAssignmentAsync(new PutAssignmentRequest
            {
                Mode = CalculationMode.None,
                Recalculate = false,
                AssignmentUid = assignment.Uid,
                Assignment = assignment,
                Name = remoteName,
                Folder = this.DataFolder
            });

            Assert.AreEqual(HttpStatusCode.OK.ToString(), putResponse.Status);
            Assert.IsNotNull(putResponse.Assignment);
            var assignmentAfterUpdate = putResponse.Assignment;
            var baselinesAfterUpdate = assignmentAfterUpdate.Baselines;
            Assert.AreEqual(1, baselinesAfterUpdate.Count);
            Assert.AreEqual(BaselineType.Baseline1, baselinesAfterUpdate[0].BaselineNumber);
            Assert.AreEqual(assignment.Baselines[0].Start, baselinesAfterUpdate[0].Start);

            var timephasedDataAfterUpdate = assignmentAfterUpdate.TimephasedData;
            var td = timephasedDataAfterUpdate[0];
            Assert.AreEqual(1, timephasedDataAfterUpdate.Count);
            Assert.AreEqual(assignment.TimephasedData[0].Uid, td.Uid);
            Assert.AreEqual(assignment.TimephasedData[0].Start, td.Start);
            Assert.AreEqual(assignment.TimephasedData[0].Finish, td.Finish);
            Assert.AreEqual(assignment.TimephasedData[0].Unit, td.Unit);
            Assert.AreEqual("PT4H0M0S", td.Value.ToString());
            Assert.AreEqual(assignment.TimephasedData[0].TimephasedDataType, td.TimephasedDataType);

            Assert.AreNotEqual(assignment.Cost, assignmentAfterUpdate.Cost, "Calculated fields must be overwritten");
            Assert.AreEqual(assignment.Start, assignmentAfterUpdate.Start);
            Assert.AreEqual(assignment.Finish, assignmentAfterUpdate.Finish);
            Assert.AreEqual(assignment.Work, assignmentAfterUpdate.Work);
            Assert.AreEqual(assignment.ActualWork, assignmentAfterUpdate.ActualWork);
            Assert.AreEqual(assignment.ActualStart, assignmentAfterUpdate.ActualStart);
            Assert.AreEqual(assignment.ActualFinish, assignmentAfterUpdate.ActualFinish);
            Assert.AreEqual(assignment.ActualOvertimeWork, assignmentAfterUpdate.ActualOvertimeWork);
            Assert.AreEqual(assignment.Vac, assignmentAfterUpdate.Vac);
            Assert.AreEqual(assignment.Uid, assignmentAfterUpdate.Uid);
        }

        [Test]
        public async Task TestDeleteAssignment()
        {
            var remoteName = await UploadFileToStorageAsync("NewProductDev.mpp");

            var response = await TasksApi.DeleteAssignmentAsync(new DeleteAssignmentRequest
            {
                AssignmentUid = 63,
                Name = remoteName,
                Folder = this.DataFolder
            });

            Assert.AreEqual((int)HttpStatusCode.OK, response.Code);

            var getResponse = await TasksApi.GetAssignmentsAsync(new GetAssignmentsRequest
            {
                Name = remoteName,
                Folder = this.DataFolder
            });

            Assert.AreEqual((int)HttpStatusCode.OK, getResponse.Code);
            Assert.IsNull(getResponse.Assignments.AssignmentItem.FirstOrDefault(a => a.TaskUid == 34 && a.ResourceUid == 1));
            Assert.IsNull(getResponse.Assignments.AssignmentItem.FirstOrDefault(a => a.Uid == 63));
        }
    }
}
