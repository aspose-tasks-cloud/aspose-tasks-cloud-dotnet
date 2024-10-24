
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TestPrimaveraProperties.cs">
//   Copyright (c) 2022 Aspose.Tasks for Cloud
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
using System.Net;
using Aspose.Tasks.Cloud.Sdk.Model;
using Aspose.Tasks.Cloud.Sdk.Model.Requests;
using Aspose.Tasks.Cloud.Sdk.Tests.Base;
using NUnit.Framework;
using Task = System.Threading.Tasks.Task;

namespace Aspose.Tasks.Cloud.Sdk.Tests.Tasks
{
    [TestFixture]
    public class TestPrimaveraProperties : BaseTestContext
    {
        [Test]
        public async Task TestGetPrimaveraTaskProperties()
        {
            var remoteName = await UploadFileToStorageAsync("p6_multiproject.xml");

            var response = await TasksApi.GetPrimaveraTaskPropertiesAsync(new GetPrimaveraTaskPropertiesRequest
            {
                Name = remoteName,
                Folder = this.DataFolder,
                TaskUid = 1
            });

            Assert.AreEqual((int)HttpStatusCode.OK, response.Code);
            Assert.IsNotNull(response.PrimaveraProperties);

            var entity = response.PrimaveraProperties;
            Assert.AreEqual(0, (int)entity.SequenceNumber);
            Assert.AreEqual("A1040", entity.ActivityId);
            Assert.AreEqual(new DateTime(2000, 10, 12, 8, 0, 0), entity.RemainingEarlyStart);
            Assert.AreEqual(new DateTime(2000, 10, 12, 17, 0, 0), entity.RemainingEarlyFinish);
            Assert.AreEqual(new DateTime(2000, 10, 12, 8, 0, 0), entity.RemainingLateStart);
            Assert.AreEqual(new DateTime(2000, 10, 12, 17, 0, 0), entity.RemainingLateFinish);
            Assert.AreEqual("Fixed Units", entity.RawDurationType);
            Assert.AreEqual("Task Dependent", entity.RawActivityType);
            Assert.AreEqual("Units", entity.RawCompletePercentType);
            Assert.AreEqual("Not Started", entity.RawStatus);
            Assert.AreEqual(PrimaveraDurationType.FixedUnits, entity.DurationType);
            Assert.AreEqual(PrimaveraActivityType.TaskDependent, entity.ActivityType);
            Assert.AreEqual(PrimaveraPercentCompleteType.Units, entity.PercentCompleteType);
        }
        
    }
}