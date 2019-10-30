
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TestCalendarExceptions.cs">
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
using System.Net;
using Task = System.Threading.Tasks.Task;

namespace Aspose.Tasks.Cloud.Sdk.Tests.DocumentProperties
{
    [TestFixture]
    internal sealed class TestCalendarExceptions : BaseTestContext
    {
        [Test]
        public async Task TestGetCalendarExceptions()
        {
            var remoteName = await UploadFileToStorageAsync("Calenar with exception.mpp");

            var getResponse = await TasksApi.GetCalendarExceptionsAsync(new GetCalendarExceptionsRequest
            {
                Name = remoteName,
                Folder = this.DataFolder,
                CalendarUid = 1
            });

            Assert.AreEqual((int)HttpStatusCode.OK, getResponse.Code);
            Assert.IsNotNull(getResponse.CalendarExceptions);
            Assert.AreEqual(1, getResponse.CalendarExceptions.Count);

            var calendarException = getResponse.CalendarExceptions[0];
            Assert.AreEqual(true, calendarException.DayWorking);
            CollectionAssert.AreEqual(new[] { DayType.Monday }, calendarException.DaysOfWeek);
            Assert.AreEqual(new DateTime(2018, 02, 13), calendarException.FromDate);
            Assert.AreEqual(new DateTime(2018, 04, 9), calendarException.ToDate.Value.Date);

            Assert.AreEqual(Month.Undefined, calendarException.Month);
            Assert.AreEqual(MonthItemType.Undefined, calendarException.MonthItem);
            Assert.AreEqual(MonthPosition.Undefined, calendarException.MonthPosition);
            Assert.AreEqual(CalendarExceptionType.Weekly, calendarException.Type);
            Assert.AreEqual(8, calendarException.Occurrences);
            Assert.AreEqual(1, calendarException.Period);
            Assert.AreEqual(2, calendarException.WorkingTimes.Count);
            Assert.AreEqual(TimeSpan.FromHours(9), calendarException.WorkingTimes[0].FromTime.Value.TimeOfDay);
            Assert.AreEqual(new TimeSpan(12, 34, 0), calendarException.WorkingTimes[0].ToTime.Value.TimeOfDay);
            Assert.AreEqual(new TimeSpan(15, 11, 0), calendarException.WorkingTimes[1].FromTime.Value.TimeOfDay);
            Assert.AreEqual(new TimeSpan(17, 30, 0), calendarException.WorkingTimes[1].ToTime.Value.TimeOfDay);
        }

        [Test]
        public async Task TestAddCalendarException()
        {
            var remoteName = await UploadFileToStorageAsync("New project 2013.mpp");

            var calendarException = new CalendarException
            {
                Name = "Non-working day exception",
                DayWorking = false,
                FromDate = new DateTime(2014, 10, 28),
                ToDate = new DateTime(2015, 08, 5),
                Occurrences = 10,
                Type = CalendarExceptionType.MonthlyByDay,
                EnteredByOccurrences = true,
                MonthDay = 5,
                Period = 1
            };

            var response = await TasksApi.PostCalendarExceptionAsync(new PostCalendarExceptionRequest
            {
                CalendarUid = 1,
                CalendarException = calendarException,
                Name = remoteName,
                Folder = this.DataFolder
            });

            Assert.AreEqual((int)HttpStatusCode.Created, response.Code);

            var getResponse = await TasksApi.GetCalendarExceptionsAsync(new GetCalendarExceptionsRequest
            {
                Name = remoteName,
                Folder = this.DataFolder,
                CalendarUid = 1
            });

            Assert.AreEqual((int)HttpStatusCode.OK, getResponse.Code);
            Assert.IsNotNull(getResponse.CalendarExceptions);
            Assert.AreEqual(1, getResponse.CalendarExceptions.Count);

            AssertCalendarExceptionsAreEqual(calendarException, getResponse.CalendarExceptions[0]);
        }

        [Test]
        public async Task TestEditCalendarException()
        {
            var remoteName = await UploadFileToStorageAsync("Calenar with exception.mpp");

            var getResponse = await TasksApi.GetCalendarExceptionsAsync(new GetCalendarExceptionsRequest
            {
                Name = remoteName,
                Folder = this.DataFolder,
                CalendarUid = 1
            });

            Assert.AreEqual((int)HttpStatusCode.OK, getResponse.Code);

            var calendarException = getResponse.CalendarExceptions[0];

            calendarException.DaysOfWeek = new List<DayType> { DayType.Thursday, DayType.Friday };
            calendarException.WorkingTimes = new List<WorkingTime> { new WorkingTime() { FromTime = DateTime.MinValue + TimeSpan.FromHours(9), ToTime = DateTime.MinValue + TimeSpan.FromHours(17) } };
            calendarException.Occurrences = 10;
            calendarException.EnteredByOccurrences = true;
            calendarException.Period = 1;
            calendarException.Name = "Non-working day exception";
            calendarException.DayWorking = true;
            calendarException.FromDate = new DateTime(2014, 10, 28);
            calendarException.ToDate = new DateTime(2015, 08, 5);

            var response = await TasksApi.PutCalendarExceptionAsync(new PutCalendarExceptionRequest
            {
                CalendarUid = 1,
                Index = calendarException.Index,
                CalendarException = calendarException,
                Name = remoteName,
                Folder = this.DataFolder
            });

            Assert.AreEqual((int)HttpStatusCode.OK, response.Code);

            getResponse = await TasksApi.GetCalendarExceptionsAsync(new GetCalendarExceptionsRequest
            {
                Name = remoteName,
                Folder = this.DataFolder,
                CalendarUid = 1
            });

            Assert.AreEqual((int)HttpStatusCode.OK, getResponse.Code);
            Assert.IsNotNull(getResponse.CalendarExceptions);
            Assert.AreEqual(1, getResponse.CalendarExceptions.Count);

            AssertCalendarExceptionsAreEqual(calendarException, getResponse.CalendarExceptions[0]);
        }

        [Test]
        public async Task TestDeleteCalendarException()
        {
            var remoteName = await UploadFileToStorageAsync("Calenar with exception.mpp");

            var response = await TasksApi.DeleteCalendarExceptionAsync(new DeleteCalendarExceptionRequest
            {
                Name = remoteName,
                Folder = this.DataFolder,
                CalendarUid = 1,
                Index = 1
            });

            Assert.AreEqual((int)HttpStatusCode.OK, response.Code);

            var getResponse = await TasksApi.GetCalendarExceptionsAsync(new GetCalendarExceptionsRequest
            {
                Name = remoteName,
                Folder = this.DataFolder,
                CalendarUid = 1
            });

            Assert.AreEqual((int)HttpStatusCode.OK, getResponse.Code);
            Assert.IsNotNull(getResponse.CalendarExceptions);
            Assert.AreEqual(0, getResponse.CalendarExceptions.Count);
        }

        private void AssertCalendarExceptionsAreEqual(CalendarException c1, CalendarException c2)
        {
            Assert.AreEqual(c1.Name, c2.Name);
            Assert.AreEqual(c1.DayWorking, c2.DayWorking);
            Assert.AreEqual(c1.EnteredByOccurrences, c2.EnteredByOccurrences);
            Assert.AreEqual(c1.FromDate, c2.FromDate);

            Assert.AreEqual(c1.MonthDay, c2.MonthDay);
            Assert.AreEqual(c1.Occurrences, c2.Occurrences);
            Assert.AreEqual(c1.Period, c2.Period);
            Assert.AreEqual(c1.ToDate.GetValueOrDefault().Date, c2.ToDate.GetValueOrDefault().Date);
            Assert.AreEqual(c1.Type, c2.Type);
            Assert.AreEqual((c1.WorkingTimes?.Count).GetValueOrDefault(), (c2.WorkingTimes?.Count).GetValueOrDefault());
            for (int i = 0; i < (c1.WorkingTimes?.Count).GetValueOrDefault(); i++)
            {
                Assert.AreEqual(c1.WorkingTimes[i].FromTime.Value.TimeOfDay, c2.WorkingTimes[i].FromTime.Value.TimeOfDay);
                Assert.AreEqual(c1.WorkingTimes[i].ToTime.Value.TimeOfDay, c2.WorkingTimes[i].ToTime.Value.TimeOfDay);
            }

            Assert.AreEqual((c1.DaysOfWeek?.Count).GetValueOrDefault(), (c2.DaysOfWeek?.Count).GetValueOrDefault());
            for (int i = 0; i < (c1.DaysOfWeek?.Count).GetValueOrDefault(); i++)
            {
                Assert.AreEqual(c1.DaysOfWeek[i], c2.DaysOfWeek[i]);
            }
        }
    }
}
