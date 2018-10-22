
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TestCalendars.cs">
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
using Aspose.Tasks.Cloud.Sdk.Model;
using Aspose.Tasks.Cloud.Sdk.Model.Requests;
using NUnit.Framework;
using System.Collections.Generic;
using System.Net;

namespace Aspose.Tasks.Cloud.Sdk.Tests.DocumentProperties
{
    [TestFixture]
    internal sealed class TestCalendars : BaseTestContext
    {
        [Test]
        public void TestGetCalendars()
        {
            var remoteName = UploadFileToStorage("Home move plan.mpp");

            var response = TasksApi.GetCalendars(new GetCalendarsRequest
            {
                Name = remoteName,
                Folder = this.DataFolder
            });

            Assert.AreEqual((int)HttpStatusCode.OK, response.Code);
            Assert.AreEqual(1, response.Calendars.List.Count);
            Assert.AreEqual("Standard", response.Calendars.List[0].Name);
            Assert.AreEqual(1L, response.Calendars.List[0].Uid);
        }

        [Test]
        public void TestGetCalendarByUid()
        {
            var remoteName = UploadFileToStorage("Home move plan.mpp");

            var response = TasksApi.GetCalendar(new GetCalendarRequest
            {
                Name = remoteName,
                Folder = this.DataFolder,
                CalendarUid = 1
            });

            Assert.AreEqual((int)HttpStatusCode.OK, response.Code);
            Assert.IsNotNull(response.Calendar);
            Assert.AreEqual("Standard", response.Calendar.Name);
            Assert.AreEqual(1, response.Calendar.Uid);
            Assert.AreEqual(true, response.Calendar.IsBaseCalendar);
            Assert.AreEqual(false, response.Calendar.IsBaselineCalendar);
            Assert.AreEqual(7, response.Calendar.Days.Count);
        }

        [Test]
        public void TestAddNewCalendar()
        {
            var remoteName = UploadFileToStorage("Home move plan.mpp");

            var response = TasksApi.PostCalendar(new PostCalendarRequest
            {
                Name = remoteName,
                Folder = this.DataFolder,
                Calendar = new Calendar
                {
                    Name = "My new calendar",
                    Days = new List<WeekDay>
                    {
                        new WeekDay { DayType = DayType.Sunday, DayWorking = false },
                        new WeekDay { DayType = DayType.Monday, DayWorking = true, FromDate = DateTime.MinValue.Add(TimeSpan.FromHours(8)), ToDate = DateTime.MinValue.Add(TimeSpan.FromHours(17)),
                            WorkingTimes = new List<WorkingTime>
                            {
                                new WorkingTime { FromTime = DateTime.MinValue.Add(TimeSpan.FromHours(8)), ToTime = DateTime.MinValue.Add(TimeSpan.FromHours(13))},
                                new WorkingTime { FromTime = DateTime.MinValue.Add(TimeSpan.FromHours(14)), ToTime = DateTime.MinValue.Add(TimeSpan.FromHours(17))}
                            }
                        }
                        },
                    IsBaseCalendar = false,
                    IsBaselineCalendar = false
                }
            });

            Assert.AreEqual((int)HttpStatusCode.Created, response.Code);
            var createdCalendarUid = response.CalendarItem.Uid;

            var getResponse = TasksApi.GetCalendar(new GetCalendarRequest
            {
                Name = remoteName,
                Folder = this.DataFolder,
                CalendarUid = createdCalendarUid
            });

            Assert.AreEqual((int)HttpStatusCode.OK, getResponse.Code);
            Assert.IsNotNull(getResponse.Calendar);

            Assert.AreEqual("My new calendar", getResponse.Calendar.Name);
            Assert.AreEqual(7, getResponse.Calendar.Days.Count);

            var monday = getResponse.Calendar.Days.FirstOrDefault(d => d.DayType == DayType.Monday);
            Assert.IsNotNull(monday);

            Assert.AreEqual(2, monday.WorkingTimes.Count);
            Assert.AreEqual(TimeSpan.FromHours(8), monday.WorkingTimes[0].FromTime.Value.TimeOfDay);
            Assert.AreEqual(TimeSpan.FromHours(13), monday.WorkingTimes[0].ToTime.Value.TimeOfDay);
            Assert.AreEqual(TimeSpan.FromHours(14), monday.WorkingTimes[1].FromTime.Value.TimeOfDay);
            Assert.AreEqual(TimeSpan.FromHours(17), monday.WorkingTimes[1].ToTime.Value.TimeOfDay);
        }

        [Test]
        public void TestAddEmptyCalendar()
        {
            var remoteName = UploadFileToStorage("Home move plan.mpp");

            var exception = Assert.Throws<ApiException>
                (() =>
                {
                    TasksApi.PostCalendar(new PostCalendarRequest
                    {
                        Name = remoteName,
                        Folder = this.DataFolder,
                        Calendar = new Calendar
                        {
                            Name = "My new calendar",
                            Days = new List<WeekDay>
                            {
                                new WeekDay { DayType = DayType.Sunday, DayWorking = false },
                                new WeekDay
                                {
                                    DayType = DayType.Monday,
                                    DayWorking = true,
                                    FromDate = DateTime.MinValue.Add(TimeSpan.FromHours(8)),
                                    ToDate = DateTime.MinValue.Add(TimeSpan.FromHours(17)),
                                    WorkingTimes = new List<WorkingTime> {}
                                }
                            },
                            IsBaseCalendar = false,
                            IsBaselineCalendar = false
                        }
                    });
                });

            Assert.AreEqual(400, exception.ErrorCode);
            Assert.AreEqual("InvalidParameters", exception.ReasonCode);
            Assert.AreEqual("Calendar should have at least one working time defined", exception.Message);
        }

        [Test]
        public void TestEditExistingCalendar()
        {
            var remoteName = UploadFileToStorage("Home move plan.mpp");

            var response = TasksApi.PutCalendar(new PutCalendarRequest
            {
                CalendarUid = 1,
                Name = remoteName,
                Folder = this.DataFolder,
                Calendar = new Calendar
                {
                    Uid = 1,
                    Name = "Modified calendar",
                    Days = new List<WeekDay>
                    {
                        new WeekDay { DayType = DayType.Sunday, DayWorking = false },
                        new WeekDay { DayType = DayType.Monday, DayWorking = true, FromDate = DateTime.MinValue.Add(TimeSpan.FromHours(8)), ToDate = DateTime.MinValue.Add(TimeSpan.FromHours(17)),
                            WorkingTimes = new List<WorkingTime>
                            {
                                new WorkingTime { FromTime = DateTime.MinValue.Add(TimeSpan.FromHours(8)), ToTime = DateTime.MinValue.Add(TimeSpan.FromHours(13))},
                                new WorkingTime { FromTime = DateTime.MinValue.Add(TimeSpan.FromHours(14)), ToTime = DateTime.MinValue.Add(TimeSpan.FromHours(17))}
                            }
                        }
                        },
                    IsBaseCalendar = false,
                    IsBaselineCalendar = false
                }
            });

            Assert.AreEqual((int)HttpStatusCode.OK, response.Code);

            var getResponse = TasksApi.GetCalendar(new GetCalendarRequest
            {
                Name = remoteName,
                Folder = this.DataFolder,
                CalendarUid = 1
            });

            Assert.AreEqual((int)HttpStatusCode.OK, getResponse.Code);
            Assert.IsNotNull(getResponse.Calendar);

            Assert.AreEqual("Modified calendar", getResponse.Calendar.Name);
            Assert.AreEqual(7, getResponse.Calendar.Days.Count);

            var monday = getResponse.Calendar.Days.FirstOrDefault(d => d.DayType == DayType.Monday);
            Assert.IsNotNull(monday);

            Assert.AreEqual(2, monday.WorkingTimes.Count);
            Assert.AreEqual(TimeSpan.FromHours(8), monday.WorkingTimes[0].FromTime.Value.TimeOfDay);
            Assert.AreEqual(TimeSpan.FromHours(13), monday.WorkingTimes[0].ToTime.Value.TimeOfDay);
            Assert.AreEqual(TimeSpan.FromHours(14), monday.WorkingTimes[1].FromTime.Value.TimeOfDay);
            Assert.AreEqual(TimeSpan.FromHours(17), monday.WorkingTimes[1].ToTime.Value.TimeOfDay);
        }


        [Test]
        public void TestDeleteCalendarByUid()
        {
            var remoteName = UploadFileToStorage("CalendarWorkWeeks.mpp");

            var response = TasksApi.DeleteCalendar(new DeleteCalendarRequest
            {
                Name = remoteName,
                Folder = this.DataFolder,
                CalendarUid = 3
            });

            Assert.AreEqual((int)HttpStatusCode.OK, response.Code);

            var getResponse = TasksApi.GetCalendars(new GetCalendarsRequest
            {
                Name = remoteName,
                Folder = this.DataFolder
            });

            Assert.AreEqual((int)HttpStatusCode.OK, getResponse.Code);
            Assert.AreEqual(1, getResponse.Calendars.List.Count);
            Assert.AreEqual(1L, getResponse.Calendars.List[0].Uid);
        }
    }
}
