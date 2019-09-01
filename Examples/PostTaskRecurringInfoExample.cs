using System;
using Aspose.Tasks.Cloud.Sdk;
using Aspose.Tasks.Cloud.Sdk.Model;
using Aspose.Tasks.Cloud.Sdk.Model.Requests;

namespace aspose.tasks.csharp
{
    class PostTaskRecurringInfoExample : BaseContext
    {
        public void run()
        {
            var configuration = new Configuration { AppKey = BaseContext.AppKey, AppSid = BaseContext.AppSid };
            TasksApi api = new TasksApi(configuration);

            RecurringInfo recurringInfo = new RecurringInfo
            {
                RecurrencePattern = RecurrencePattern.Weekly,
                Occurrences = 4,
                WeeklyRepetitions = 3,
                WeeklyDays = WeekDayType.Thursday | WeekDayType.Wednesday,
                StartDate = new DateTime(2018, 1, 1),
                EndDate = new DateTime(2018, 12, 31),
                UseEndDate = true
            };

            var response = api.PostTaskRecurringInfo(new PostTaskRecurringInfoRequest
            {
                Name = "sample.mpp",
                Storage = "Tasks",
                Folder = "",
                ParentTaskUid = 0,
                RecurringInfo = recurringInfo,
                TaskName = "New recurring task",
                CalendarName = "Standard"
            });
            Console.WriteLine(response.Code);
        }
    }
}
