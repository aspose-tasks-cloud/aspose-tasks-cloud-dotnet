
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TestCalendarWorkWeeks.cs">
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
using Aspose.Tasks.Cloud.Sdk.Model;
using Aspose.Tasks.Cloud.Sdk.Model.Requests;
using NUnit.Framework;
using System.Linq;

namespace Aspose.Tasks.Cloud.Sdk.Tests.DocumentProperties
{
    /// <summary>
    /// Only get operation is supported now for calendar's work weeks.
    /// </summary>
    [TestFixture]
    internal sealed class TestCalendarWorkWeeks : BaseTestContext
    {
        [Test]
        public void TestGetCalendarWorkWeeks()
        {
            var remoteName = UploadFileToStorage("CalendarWorkWeeks.mpp");

            var calendarsReponse = TasksApi.GetCalendars(new GetCalendarsRequest
            {
                Name = remoteName,
                Folder = this.DataFolder
            });

            Assert.AreEqual(HttpStatusCode.OK.ToString(), calendarsReponse.Status);
            Assert.IsNotNull(calendarsReponse.Calendars);

            var calendarUid = calendarsReponse.Calendars.List.Where(c => c.Name == "Test work weeks").
                Select(c => c.Uid)
                .FirstOrDefault();

            var getResponse = TasksApi.GetCalendarWorkWeeks(new GetCalendarWorkWeeksRequest
            {
                Name = remoteName,
                Folder = this.DataFolder,
                CalendarUid = calendarUid
            });

            Assert.AreEqual(HttpStatusCode.OK.ToString(), getResponse.Status);
            Assert.IsNotNull(getResponse.CalendarWorkWeeks);


            Assert.AreEqual(1, getResponse.CalendarWorkWeeks.Count);
            var workWeek = getResponse.CalendarWorkWeeks[0];

            Assert.AreEqual("Work week 1", workWeek.Name);
            Assert.AreEqual(new DateTime(2018, 1, 1), workWeek.FromDate.Value.Date);
            Assert.AreEqual(new DateTime(2018, 1, 7), workWeek.ToDate.Value.Date);

            Assert.AreEqual(4, workWeek.WeekDays.Count);
            Assert.AreEqual(true, workWeek.WeekDays[0].DayWorking);
            Assert.AreEqual(DayType.Monday, workWeek.WeekDays[0].DayType);
            Assert.AreEqual(1, workWeek.WeekDays[0].WorkingTimes.Count);
            Assert.AreEqual(new TimeSpan(11, 30, 0), workWeek.WeekDays[0].WorkingTimes[0].FromTime.Value.TimeOfDay);
            Assert.AreEqual(new TimeSpan(12, 30, 0), workWeek.WeekDays[0].WorkingTimes[0].ToTime.Value.TimeOfDay);

            Assert.AreEqual(false, workWeek.WeekDays[1].DayWorking);
            Assert.AreEqual(DayType.Tuesday, workWeek.WeekDays[1].DayType);
            Assert.AreEqual(0, workWeek.WeekDays[1].WorkingTimes.Count);

            Assert.AreEqual(true, workWeek.WeekDays[2].DayWorking);
            Assert.AreEqual(DayType.Wednesday, workWeek.WeekDays[2].DayType);
            Assert.AreEqual(2, workWeek.WeekDays[2].WorkingTimes.Count);

            Assert.AreEqual(new TimeSpan(9, 30, 0), workWeek.WeekDays[2].WorkingTimes[0].FromTime.Value.TimeOfDay);
            Assert.AreEqual(new TimeSpan(13, 23, 0), workWeek.WeekDays[2].WorkingTimes[0].ToTime.Value.TimeOfDay);
            Assert.AreEqual(new TimeSpan(14, 45, 0), workWeek.WeekDays[2].WorkingTimes[1].FromTime.Value.TimeOfDay);
            Assert.AreEqual(new TimeSpan(18, 45, 0), workWeek.WeekDays[2].WorkingTimes[1].ToTime.Value.TimeOfDay);

            Assert.AreEqual(true, workWeek.WeekDays[3].DayWorking);
            Assert.AreEqual(DayType.Saturday, workWeek.WeekDays[3].DayType);
            Assert.AreEqual(1, workWeek.WeekDays[3].WorkingTimes.Count);

            Assert.AreEqual(new TimeSpan(9, 0, 0), workWeek.WeekDays[3].WorkingTimes[0].FromTime.Value.TimeOfDay);
            Assert.AreEqual(new TimeSpan(10, 0, 0), workWeek.WeekDays[3].WorkingTimes[0].ToTime.Value.TimeOfDay);
        }
    }
}
