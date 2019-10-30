
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TestTasksExtendedAttributes.cs">
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

namespace Aspose.Tasks.Cloud.Sdk.Tests.Tasks
{
    [TestFixture]
    public class TestTasksExtendedAttributes : BaseTestContext
    {
        [Test]
        public async Task TestEditTaskExtendedAttributeLookupValue()
        {
            var remoteName = await UploadFileToStorageAsync("NewProductDev.mpp");

            var newExtendedAttribute = new ExtendedAttributeDefinition
            {
                CalculationType = CalculationType.Lookup,
                CfType = CustomFieldType.Text,
                FieldName = "Text3",
                ElementType = ElementType.Task,
                Alias = "New Field",
                ValueList = new List<Value>
                {
                    new Value { Description = "descr1", Val = "Internal", Id = 111 },
                    new Value { Description = "descr2", Val = "External", Id = 112 }
                }
            };

            var putAttributeResponse = await TasksApi.PutExtendedAttributeAsync(new PutExtendedAttributeRequest
            {
                ExtendedAttribute = newExtendedAttribute,
                Name = remoteName,
                Folder = this.DataFolder
            });

            Assert.AreEqual((int)HttpStatusCode.OK, putAttributeResponse.Code);
            var taskResponse = await TasksApi.GetTaskAsync(new GetTaskRequest
            {
                TaskUid = 27,
                Name = remoteName,
                Folder = this.DataFolder
            });

            Assert.AreEqual((int)HttpStatusCode.OK, taskResponse.Code);
            Assert.IsNotNull(taskResponse.Task);

            taskResponse.Task.ExtendedAttributes.Add(
                new ExtendedAttribute { LookupValueId = 112, FieldId = putAttributeResponse.ExtendedAttribute.FieldId });

            var putTaskResponse = await TasksApi.PutTaskAsync(new PutTaskRequest
            {
                TaskUid = 27,
                Task = taskResponse.Task,
                Name = remoteName,
                Folder = this.DataFolder
            });

            Assert.AreEqual((int)HttpStatusCode.OK, putTaskResponse.Code);

            taskResponse = await TasksApi.GetTaskAsync(new GetTaskRequest
            {
                TaskUid = 27,
                Name = remoteName,
                Folder = this.DataFolder
            });

            Assert.AreEqual((int)HttpStatusCode.OK, taskResponse.Code);
            Assert.IsNotNull(taskResponse.Task);
            Assert.AreEqual(1, taskResponse.Task.ExtendedAttributes.Count);
            Assert.AreEqual("188743737", taskResponse.Task.ExtendedAttributes[0].FieldId);
            Assert.AreEqual(112, taskResponse.Task.ExtendedAttributes[0].LookupValueId);
        }

        [Test]
        public async Task TestEditTaskExtendedAttributeDateValue()
        {
            var remoteName = await UploadFileToStorageAsync("NewProductDev.mpp");

            var newExtendedAttribute = new ExtendedAttributeDefinition
            {
                CalculationType = CalculationType.None,
                CfType = CustomFieldType.Finish,
                FieldName = "Finish4",
                ElementType = ElementType.Task,
                Alias = "Custom Finish Field"
            };

            var putAttributeResponse = await TasksApi.PutExtendedAttributeAsync(new PutExtendedAttributeRequest
            {
                ExtendedAttribute = newExtendedAttribute,
                Name = remoteName,
                Folder = this.DataFolder
            });

            Assert.AreEqual((int)HttpStatusCode.OK, putAttributeResponse.Code);
            var taskResponse = await TasksApi.GetTaskAsync(new GetTaskRequest
            {
                TaskUid = 27,
                Name = remoteName,
                Folder = this.DataFolder
            });

            Assert.AreEqual((int)HttpStatusCode.OK, taskResponse.Code);
            Assert.IsNotNull(taskResponse.Task);

            taskResponse.Task.ExtendedAttributes.Add(
                new ExtendedAttribute
                    {
                        DateValue = new DateTime(2018, 03, 04, 12, 30, 0),
                        FieldId = "188743742"
                });

            var putTaskResponse = await TasksApi.PutTaskAsync(new PutTaskRequest
            {
                TaskUid = 27,
                Task = taskResponse.Task,
                Name = remoteName,
                Folder = this.DataFolder
            });

            Assert.AreEqual((int)HttpStatusCode.OK, putTaskResponse.Code);

            taskResponse = await TasksApi.GetTaskAsync(new GetTaskRequest
            {
                TaskUid = 27,
                Name = remoteName,
                Folder = this.DataFolder
            });

            Assert.AreEqual((int)HttpStatusCode.OK, taskResponse.Code);
            Assert.IsNotNull(taskResponse.Task);
            Assert.AreEqual(1, taskResponse.Task.ExtendedAttributes.Count);
            Assert.AreEqual("188743742", taskResponse.Task.ExtendedAttributes[0].FieldId);
            Assert.AreEqual(new DateTime(2018, 03, 04, 12, 30, 0), taskResponse.Task.ExtendedAttributes[0].DateValue);
        }

        [Test]
        public async Task TestEditTaskExtendedAttributeDurationValue()
        {
            var remoteName = await UploadFileToStorageAsync("NewProductDev.mpp");

            var newExtendedAttribute = new ExtendedAttributeDefinition
            {
                CalculationType = CalculationType.None,
                CfType = CustomFieldType.Duration,
                FieldName = "Duration3",
                ElementType = ElementType.Task,
                Alias = "Custom Duration Field"
            };

            var putAttributeResponse = await TasksApi.PutExtendedAttributeAsync(new PutExtendedAttributeRequest
            {
                ExtendedAttribute = newExtendedAttribute,
                Name = remoteName,
                Folder = this.DataFolder
            });

            Assert.AreEqual((int)HttpStatusCode.OK, putAttributeResponse.Code);
            var taskResponse = await TasksApi.GetTaskAsync(new GetTaskRequest
            {
                TaskUid = 27,
                Name = remoteName,
                Folder = this.DataFolder
            });

            Assert.AreEqual((int)HttpStatusCode.OK, taskResponse.Code);
            Assert.IsNotNull(taskResponse.Task);

            taskResponse.Task.ExtendedAttributes.Add(
                new ExtendedAttribute
                {
                    DurationValue = new Duration { TimeSpan = TimeSpan.FromHours(4), TimeUnit = TimeUnitType.Minute },
                    FieldId = "188743785"
                });

            var putTaskResponse = await TasksApi.PutTaskAsync(new PutTaskRequest
            {
                TaskUid = 27,
                Task = taskResponse.Task,
                Name = remoteName,
                Folder = this.DataFolder
            });

            Assert.AreEqual((int)HttpStatusCode.OK, putTaskResponse.Code);

            taskResponse = await TasksApi.GetTaskAsync(new GetTaskRequest
            {
                TaskUid = 27,
                Name = remoteName,
                Folder = this.DataFolder
            });

            Assert.AreEqual((int)HttpStatusCode.OK, taskResponse.Code);
            Assert.IsNotNull(taskResponse.Task);
            Assert.AreEqual(1, taskResponse.Task.ExtendedAttributes.Count);
            Assert.AreEqual("188743785", taskResponse.Task.ExtendedAttributes[0].FieldId);
            Assert.IsNotNull(taskResponse.Task.ExtendedAttributes[0].DurationValue);
            Assert.AreEqual(TimeSpan.FromHours(4), taskResponse.Task.ExtendedAttributes[0].DurationValue.TimeSpan);
        }

        [Test]
        public async Task TestEditTaskExtendedAttributeFlagValue()
        {
            var remoteName = await UploadFileToStorageAsync("NewProductDev.mpp");

            var newExtendedAttribute = new ExtendedAttributeDefinition
            {
                CalculationType = CalculationType.None,
                CfType = CustomFieldType.Flag,
                FieldName = "Flag12",
                ElementType = ElementType.Task,
                Alias = "Custom Flag Field"
            };

            var putAttributeResponse = await TasksApi.PutExtendedAttributeAsync(new PutExtendedAttributeRequest
            {
                ExtendedAttribute = newExtendedAttribute,
                Name = remoteName,
                Folder = this.DataFolder
            });

            Assert.AreEqual((int)HttpStatusCode.OK, putAttributeResponse.Code);
            var taskResponse = await TasksApi.GetTaskAsync(new GetTaskRequest
            {
                TaskUid = 27,
                Name = remoteName,
                Folder = this.DataFolder
            });

            Assert.AreEqual((int)HttpStatusCode.OK, taskResponse.Code);
            Assert.IsNotNull(taskResponse.Task);

            taskResponse.Task.ExtendedAttributes.Add(
                new ExtendedAttribute
                {
                    FlagValue = true,
                    FieldId = "188743973"
                });

            var putTaskResponse = await TasksApi.PutTaskAsync(new PutTaskRequest
            {
                TaskUid = 27,
                Task = taskResponse.Task,
                Name = remoteName,
                Folder = this.DataFolder
            });

            Assert.AreEqual((int)HttpStatusCode.OK, putTaskResponse.Code);

            taskResponse = await TasksApi.GetTaskAsync(new GetTaskRequest
            {
                TaskUid = 27,
                Name = remoteName,
                Folder = this.DataFolder
            });

            Assert.AreEqual((int)HttpStatusCode.OK, taskResponse.Code);
            Assert.IsNotNull(taskResponse.Task);
            Assert.AreEqual(1, taskResponse.Task.ExtendedAttributes.Count);
            Assert.AreEqual("188743973", taskResponse.Task.ExtendedAttributes[0].FieldId);
            Assert.AreEqual(true, taskResponse.Task.ExtendedAttributes[0].FlagValue);
        }

        [Test]
        public async Task TestEditTaskExtendedAttributeCostValue()
        {
            var remoteName = await UploadFileToStorageAsync("NewProductDev.mpp");

            var newExtendedAttribute = new ExtendedAttributeDefinition
            {
                CalculationType = CalculationType.None,
                CfType = CustomFieldType.Cost,
                FieldName = "Cost10",
                ElementType = ElementType.Task,
                Alias = "Custom Cost Field"
            };

            var putAttributeResponse = await TasksApi.PutExtendedAttributeAsync(new PutExtendedAttributeRequest
            {
                ExtendedAttribute = newExtendedAttribute,
                Name = remoteName,
                Folder = this.DataFolder
            });

            Assert.AreEqual((int)HttpStatusCode.OK, putAttributeResponse.Code);
            var taskResponse = await TasksApi.GetTaskAsync(new GetTaskRequest
            {
                TaskUid = 27,
                Name = remoteName,
                Folder = this.DataFolder
            });

            Assert.AreEqual((int)HttpStatusCode.OK, taskResponse.Code);
            Assert.IsNotNull(taskResponse.Task);

            taskResponse.Task.ExtendedAttributes.Add(
                new ExtendedAttribute
                {
                    NumericValue = 115.99m,
                    FieldId = "188743944"
                });

            var putTaskResponse = await TasksApi.PutTaskAsync(new PutTaskRequest
            {
                TaskUid = 27,
                Task = taskResponse.Task,
                Name = remoteName,
                Folder = this.DataFolder
            });

            Assert.AreEqual((int)HttpStatusCode.OK, putTaskResponse.Code);

            taskResponse = await TasksApi.GetTaskAsync(new GetTaskRequest
            {
                TaskUid = 27,
                Name = remoteName,
                Folder = this.DataFolder
            });

            Assert.AreEqual((int)HttpStatusCode.OK, taskResponse.Code);
            Assert.IsNotNull(taskResponse.Task);
            Assert.AreEqual(1, taskResponse.Task.ExtendedAttributes.Count);
            Assert.AreEqual("188743944", taskResponse.Task.ExtendedAttributes[0].FieldId);
            Assert.AreEqual(115.99m, taskResponse.Task.ExtendedAttributes[0].NumericValue);
        }

        [Test]
        public async Task TestEditTaskExtendedAttributeNumberValue()
        {
            var remoteName = await UploadFileToStorageAsync("NewProductDev.mpp");

            var newExtendedAttribute = new ExtendedAttributeDefinition
            {
                CalculationType = CalculationType.None,
                CfType = CustomFieldType.Number,
                FieldName = "Number9",
                ElementType = ElementType.Task,
                Alias = "Custom Number Field"
            };

            var putAttributeResponse = await TasksApi.PutExtendedAttributeAsync(new PutExtendedAttributeRequest
            {
                ExtendedAttribute = newExtendedAttribute,
                Name = remoteName,
                Folder = this.DataFolder
            });

            Assert.AreEqual((int)HttpStatusCode.OK, putAttributeResponse.Code);
            var taskResponse = await TasksApi.GetTaskAsync(new GetTaskRequest
            {
                TaskUid = 27,
                Name = remoteName,
                Folder = this.DataFolder
            });

            Assert.AreEqual((int)HttpStatusCode.OK, taskResponse.Code);
            Assert.IsNotNull(taskResponse.Task);

            taskResponse.Task.ExtendedAttributes.Add(
                new ExtendedAttribute
                {
                    NumericValue = 99.99m,
                    FieldId = "188743985"
                });

            var putTaskResponse = await TasksApi.PutTaskAsync(new PutTaskRequest
            {
                TaskUid = 27,
                Task = taskResponse.Task,
                Name = remoteName,
                Folder = this.DataFolder
            });

            Assert.AreEqual((int)HttpStatusCode.OK, putTaskResponse.Code);

            taskResponse = await TasksApi.GetTaskAsync(new GetTaskRequest
            {
                TaskUid = 27,
                Name = remoteName,
                Folder = this.DataFolder
            });

            Assert.AreEqual((int)HttpStatusCode.OK, taskResponse.Code);
            Assert.IsNotNull(taskResponse.Task);
            Assert.AreEqual(1, taskResponse.Task.ExtendedAttributes.Count);
            Assert.AreEqual("188743985", taskResponse.Task.ExtendedAttributes[0].FieldId);
            Assert.AreEqual(99.99m, taskResponse.Task.ExtendedAttributes[0].NumericValue);
        }

        [Test]
        public async Task TestEditTaskExtendedAttributeTextValue()
        {
            var remoteName = await UploadFileToStorageAsync("NewProductDev.mpp");

            var newExtendedAttribute = new ExtendedAttributeDefinition
            {
                CalculationType = CalculationType.None,
                CfType = CustomFieldType.Text,
                FieldName = "Text1",
                ElementType = ElementType.Task,
                Alias = "Custom Text Field"
            };

            var putAttributeResponse = await TasksApi.PutExtendedAttributeAsync(new PutExtendedAttributeRequest
            {
                ExtendedAttribute = newExtendedAttribute,
                Name = remoteName,
                Folder = this.DataFolder
            });

            Assert.AreEqual((int)HttpStatusCode.OK, putAttributeResponse.Code);
            var taskResponse = await TasksApi.GetTaskAsync(new GetTaskRequest
            {
                TaskUid = 27,
                Name = remoteName,
                Folder = this.DataFolder
            });

            Assert.AreEqual((int)HttpStatusCode.OK, taskResponse.Code);
            Assert.IsNotNull(taskResponse.Task);

            taskResponse.Task.ExtendedAttributes.Add(
                new ExtendedAttribute
                {
                    TextValue = "Test value",
                    FieldId = "188743731"
                });

            var putTaskResponse = await TasksApi.PutTaskAsync(new PutTaskRequest
            {
                TaskUid = 27,
                Task = taskResponse.Task,
                Name = remoteName,
                Folder = this.DataFolder
            });

            Assert.AreEqual((int)HttpStatusCode.OK, putTaskResponse.Code);

            taskResponse = await TasksApi.GetTaskAsync(new GetTaskRequest
            {
                TaskUid = 27,
                Name = remoteName,
                Folder = this.DataFolder
            });

            Assert.AreEqual((int)HttpStatusCode.OK, taskResponse.Code);
            Assert.IsNotNull(taskResponse.Task);
            Assert.AreEqual(1, taskResponse.Task.ExtendedAttributes.Count);
            Assert.AreEqual("188743731", taskResponse.Task.ExtendedAttributes[0].FieldId);
            Assert.AreEqual("Test value", taskResponse.Task.ExtendedAttributes[0].TextValue);
        }
    }
}
