
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TestRecurringInfo.cs">
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

namespace Aspose.Tasks.Cloud.Sdk.Tests.Tasks
{
    [TestFixture]
    public class TestRecurringInfo : BaseTestContext
    {
        [Test]
        public async Task TestGetTaskRecurringInfo()
        {
            var remoteName = await UploadFileToStorageAsync("sample.mpp");

            var response = await TasksApi.GetTaskRecurringInfoAsync(new GetTaskRecurringInfoRequest
            {
                Name = remoteName,
                Folder = this.DataFolder,
                TaskUid = 6
            });

            Assert.AreEqual((int)HttpStatusCode.OK, response.Code);
            Assert.IsNotNull(response.RecurringInfo);

            var entity = response.RecurringInfo;
            Assert.AreEqual(2, (int)entity.Occurrences);
            Assert.AreEqual(RecurrencePattern.Monthly, entity.RecurrencePattern);
            Assert.AreEqual(true, entity.UseEndDate);
            Assert.AreEqual(false, entity.MonthlyUseOrdinalDay);
            Assert.AreEqual(1, entity.MonthlyDay);
            Assert.AreEqual(WeekDayType.None, entity.WeeklyDays);
            Assert.AreEqual(OrdinalNumber.Second, entity.YearlyOrdinalNumber);
        }

        [Test]
        public async Task TestUpdateTaskRecurringInfo()
        {
            var remoteName = await UploadFileToStorageAsync("sample.mpp");

            var response = await TasksApi.GetTaskRecurringInfoAsync(new GetTaskRecurringInfoRequest
                                                             {
                                                                 Name = remoteName,
                                                                 Folder = this.DataFolder,
                                                                 TaskUid = 6
                                                             });

            Assert.AreEqual((int)HttpStatusCode.OK, response.Code);
            Assert.IsNotNull(response.RecurringInfo);

            var recurringInfo = response.RecurringInfo;
            recurringInfo.Occurrences = 10;

            var putResponse = await TasksApi.PutTaskRecurringInfoAsync(new PutTaskRecurringInfoRequest
                                                             {
                                                                 Name = remoteName,
                                                                 Folder = this.DataFolder,
                                                                 TaskUid = 6,
                                                                 RecurringInfo = recurringInfo
                                                             });

            Assert.AreEqual((int)HttpStatusCode.OK, putResponse.Code);

            response = await TasksApi.GetTaskRecurringInfoAsync(new GetTaskRecurringInfoRequest
                                                         {
                                                             Name = remoteName,
                                                             Folder = this.DataFolder,
                                                             TaskUid = 6
                                                         });

            Assert.AreEqual((int)HttpStatusCode.OK, response.Code);
            Assert.IsNotNull(response.RecurringInfo);

            var entity = response.RecurringInfo;
            Assert.AreEqual(10, (int)entity.Occurrences);
            Assert.AreEqual(RecurrencePattern.Monthly, entity.RecurrencePattern);
            Assert.AreEqual(true, entity.UseEndDate);
            Assert.AreEqual(false, entity.MonthlyUseOrdinalDay);
            Assert.AreEqual(1, entity.MonthlyDay);
            Assert.AreEqual(WeekDayType.None, entity.WeeklyDays);
            Assert.AreEqual(OrdinalNumber.Second, entity.YearlyOrdinalNumber);
        }

        [Test]
        public async Task TestAddRecurringTask()
        {
            var remoteName = await UploadFileToStorageAsync("sample.mpp");

            RecurringInfo recurringInfo = new RecurringInfo
                                              {
                                                  RecurrencePattern = RecurrencePattern.Weekly,
                                                  Occurrences = 4,
                                                  WeeklyRepetitions = 3,
                                                  WeeklyDays = WeekDayType.Thursday | WeekDayType.Wednesday,
                                                  StartDate = new DateTime(2018, 1, 1, 8, 0, 0),
                                                  EndDate = new DateTime(2018, 12, 31),
                                                  UseEndDate = true
                                              };

            var response = await TasksApi.PostTaskRecurringInfoAsync(new PostTaskRecurringInfoRequest
                                                          {
                                                              Name = remoteName,
                                                              Folder = this.DataFolder,
                                                              ParentTaskUid = 0,
                                                              RecurringInfo = recurringInfo,
                                                              TaskName = "New recurring task",
                                                              CalendarName = "Standard"
                                                          });

            Assert.AreEqual((int)HttpStatusCode.Created, response.Code);
            Assert.IsNotNull(response.TaskItem);

            var getTaskResponse = await TasksApi.GetTaskAsync(
                new GetTaskRequest
                    {
                        Name = remoteName,
                        Folder = this.DataFolder,
                        TaskUid = response.TaskItem.Uid
                    });

            Assert.AreEqual((int)HttpStatusCode.OK, getTaskResponse.Code);
            Assert.AreEqual(18, getTaskResponse.Task.SubtasksUids.Count);
            var lastTaskUid = getTaskResponse.Task.SubtasksUids.Max();

            getTaskResponse = await TasksApi.GetTaskAsync(
                new GetTaskRequest
                    {
                        Name = remoteName,
                        Folder = this.DataFolder,
                        TaskUid = lastTaskUid.Value
                });

            Assert.AreEqual(new DateTime(2018, 12, 27, 8, 0, 0), getTaskResponse.Task.Start);
        }
    }
}
