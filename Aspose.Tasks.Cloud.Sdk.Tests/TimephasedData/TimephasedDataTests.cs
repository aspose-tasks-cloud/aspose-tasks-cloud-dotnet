
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TimephasedDataTests.cs">
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

using System.Net;

using Aspose.Tasks.Cloud.Sdk.Tests.Base;
using Aspose.Tasks.Cloud.Sdk.Model.Requests;
using NUnit.Framework;
using Aspose.Tasks.Cloud.Sdk.Model;

namespace Aspose.Tasks.Cloud.Sdk.Tests.TimephasedData
{
    [TestFixture]
    internal sealed class TimephasedDataTests : BaseTestContext
    {
        [Test]
        public void TestGetTaskTimephasedData()
        {
            var remoteName = UploadFileToStorage("NewProductDev.mpp");
            var response = TasksApi.GetTaskTimephasedData(new GetTaskTimephasedDataRequest()
            {
                TaskUid = 27,
                Name = remoteName,
                Folder = this.DataFolder,
                Type = TimephasedDataType.TaskWork
            });

            Assert.AreEqual((int)HttpStatusCode.OK, response.Code);
            Assert.IsNotNull(response.Items);
            var timephasedDataItems = response.Items;
            Assert.IsNotNull(timephasedDataItems);
            Assert.IsTrue(timephasedDataItems.Count > 0);

            for (int i = 0; i < timephasedDataItems.Count; i++)
            {
                Assert.AreEqual(TimephasedDataType.TaskWork, timephasedDataItems[i].TimephasedDataType);
                Assert.AreEqual(27, timephasedDataItems[i].Uid);
            }
        }

        [Test]
        public void TestGetResourceTimephasedData()
        {
            var remoteName = UploadFileToStorage("NewProductDev.mpp");
            var response = TasksApi.GetResourceTimephasedData(new GetResourceTimephasedDataRequest()
            {
                ResourceUid = 1,
                Name = remoteName,
                Folder = this.DataFolder,
                Type = TimephasedDataType.ResourceWork,
            });

            Assert.AreEqual((int)HttpStatusCode.OK, response.Code);
            Assert.IsNotNull(response.Items);
            var timephasedDataItems = response.Items;
            Assert.IsNotNull(timephasedDataItems);
            Assert.IsTrue(timephasedDataItems.Count > 0);

            for (int i = 0; i < timephasedDataItems.Count; i++)
            {
                Assert.AreEqual(TimephasedDataType.ResourceWork, timephasedDataItems[i].TimephasedDataType);
                Assert.AreEqual(1, timephasedDataItems[i].Uid);
            }
        }

        [Test]
        public void TestGetResourceAssignmentTimephasedData()
        {
            var remoteName = UploadFileToStorage("NewProductDev.mpp");
            var response = TasksApi.GetAssignmentTimephasedData(new GetAssignmentTimephasedDataRequest()
            {
                AssignmentUid = 66,
                Name = remoteName,
                Folder = this.DataFolder,
                Type = TimephasedDataType.AssignmentWork
            });

            Assert.AreEqual((int)HttpStatusCode.OK, response.Code);
            Assert.IsNotNull(response.Items);
            var timephasedDataItems = response.Items;
            Assert.IsNotNull(timephasedDataItems);
            Assert.IsTrue(timephasedDataItems.Count > 0);

            for (int i = 0; i < timephasedDataItems.Count; i++)
            {
                Assert.AreEqual(TimephasedDataType.AssignmentWork, timephasedDataItems[i].TimephasedDataType);
                Assert.AreEqual(66, timephasedDataItems[i].Uid);
            }
        }
    }
}
