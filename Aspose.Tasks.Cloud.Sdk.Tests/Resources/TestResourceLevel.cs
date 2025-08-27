
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TestResourceLevel.cs">
//   Copyright (c) 2025 Aspose.Tasks for Cloud
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
using System.Net;
using Task = System.Threading.Tasks.Task;

namespace Aspose.Tasks.Cloud.Sdk.Tests.Tasks
{
    [TestFixture]
    public class TestResourceLevel : BaseTestContext
    {
        [Test]
        public async Task TestLevelTasks()
        {
            var remoteName = await UploadFileToStorageAsync("sample.mpp");

            var resourceResponse = await TasksApi.LevelTasksAsync(new LevelTasksRequest
            {
                Name = remoteName,
                Folder = this.DataFolder
            });

            Assert.AreEqual((int)HttpStatusCode.OK, resourceResponse.Code);
            Assert.IsNotNull(resourceResponse.AffectedTaskUids);
            Assert.AreEqual(2, resourceResponse.AffectedTaskUids.Count);
        }

        [Test]
        public async Task TestLevelTasksWithSpecifiedOptions()
        {
            var remoteName = await UploadFileToStorageAsync("sample.mpp");

            var resourceResponse = await TasksApi.LevelTasksAsync(new LevelTasksRequest
            {
                Name = remoteName,
                Folder = this.DataFolder,
                Options = new LevelingOptions
                {
                    LevelingOrder = LevelingOrder.Standard,
                    ResourceUids = new[] { 2, 999 }
                }
            });

            Assert.AreEqual((int)HttpStatusCode.OK, resourceResponse.Code);
            Assert.IsNotNull(resourceResponse.AffectedTaskUids);
            Assert.AreEqual(1, resourceResponse.AffectedTaskUids.Count);
        }

        [Test]
        public async Task TestСlearLeveling()
        {
            var remoteName = await UploadFileToStorageAsync("sample.mpp");

            var resourceResponse = await TasksApi.СlearLevelingAsync(new ClearLevelingRequest
            {
                Name = remoteName,
                Folder = this.DataFolder
            });

            Assert.AreEqual((int)HttpStatusCode.OK, resourceResponse.Code);
        }

        [Test]
        public async Task TestСlearLevelingWithSpecifiedTaskUids()
        {
            var remoteName = await UploadFileToStorageAsync("sample.mpp");

            var resourceResponse = await TasksApi.СlearLevelingAsync(new ClearLevelingRequest
            {
                Name = remoteName,
                Folder = this.DataFolder,
                TaskUids = new[] { 24, 9999 }
            });

            Assert.AreEqual((int)HttpStatusCode.OK, resourceResponse.Code);
        }
    }
}
