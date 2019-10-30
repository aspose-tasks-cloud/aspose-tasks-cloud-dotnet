
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TestResources.cs">
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
    public class TestResources : BaseTestContext
    {
        [Test]
        public async Task TestGetResources()
        {
            var remoteName = await UploadFileToStorageAsync("NewProductDev.mpp");

            var resourceResponse = await TasksApi.GetResourcesAsync(new GetResourcesRequest
            {
                Name = remoteName,
                Folder = this.DataFolder
            });

            Assert.AreEqual((int)HttpStatusCode.OK, resourceResponse.Code);
            Assert.IsNotNull(resourceResponse.Resources);
            Assert.AreEqual(2, resourceResponse.Resources.ResourceItem.Count);
            Assert.AreEqual("Project manager", resourceResponse.Resources.ResourceItem[1].Name);
            Assert.AreEqual(1, resourceResponse.Resources.ResourceItem[1].Uid);
            Assert.AreEqual(1, resourceResponse.Resources.ResourceItem[1].Id);
        }

        [Test]
        public async Task TestAddResource()
        {
            var remoteName = await UploadFileToStorageAsync("Home move plan.mpp");

            var resourceResponse = await TasksApi.GetResourcesAsync(new GetResourcesRequest
            {
                Name = remoteName,
                Folder = this.DataFolder
            });

            Assert.AreEqual((int)HttpStatusCode.OK, resourceResponse.Code);
            var count = resourceResponse.Resources.ResourceItem.Count;

            var postResponse = await TasksApi.PostResourceAsync(new PostResourceRequest
            {
                Name = remoteName,
                Folder = this.DataFolder,
                ResourceName = "new resource"
            });

            Assert.AreEqual((int)HttpStatusCode.Created, postResponse.Code);

            resourceResponse = await TasksApi.GetResourcesAsync(new GetResourcesRequest
            {
                Name = remoteName,
                Folder = this.DataFolder
            });


            Assert.AreEqual(count + 1, resourceResponse.Resources.ResourceItem.Count);
            var addedResource = resourceResponse.Resources.ResourceItem.Where(r => r.Uid == postResponse.ResourceItem.Uid).Single();
            Assert.AreEqual("new resource", addedResource.Name);
        }

        [Test]
        public async Task TestEditResource()
        {
            var remoteName = await UploadFileToStorageAsync("sample.mpp");

            var resourceResponse = await TasksApi.GetResourceAsync(new GetResourceRequest
            {
                Name = remoteName,
                Folder = this.DataFolder,
                ResourceUid = 1
            });

            Assert.AreEqual((int)HttpStatusCode.OK, resourceResponse.Code);
            Assert.IsNotNull(resourceResponse.Resource);

            var resource = resourceResponse.Resource;
            resource.Name = "Modified Resource1";
            resource.Cost = 200;
            resource.Start = new DateTime(2000, 10, 10);
            resource.Work = new TimeSpan(100, 10, 0);
            resource.Finish = new DateTime(2000, 10, 10);
            resource.OvertimeWork = new TimeSpan(100, 0, 0);
            resource.StandardRate = 101;
            resource.Baselines.Add(new Model.Baseline
            {
                BaselineNumber = Model.BaselineType.Baseline1,
                Cost = 44,
            });

            var putResponse = await TasksApi.PutResourceAsync(new PutResourceRequest
            {
                Name = remoteName,
                Folder = this.DataFolder,
                ResourceUid = 1,
                Resource = resource,
                Recalculate = false,
                Mode = Model.CalculationMode.None
            });

            Assert.AreEqual((int)HttpStatusCode.OK, putResponse.Code);

            resourceResponse = await TasksApi.GetResourceAsync(new GetResourceRequest
            {
                Name = remoteName,
                Folder = this.DataFolder,
                ResourceUid = 1
            });

            var resourceAfterModification = putResponse.Resource;

            Assert.AreEqual(1, resourceAfterModification.Baselines.Count);
            Assert.AreEqual(Model.BaselineType.Baseline1, resourceAfterModification.Baselines[0].BaselineNumber);
            Assert.AreEqual(44m, resourceAfterModification.Baselines[0].Cost);
            Assert.AreEqual(resource.StandardRate, resourceAfterModification.StandardRate);
            Assert.AreEqual(resource.Start, resourceAfterModification.Start);
            Assert.AreEqual(resource.Work, resourceAfterModification.Work);
            Assert.AreEqual(resource.Finish, resourceAfterModification.Finish);
            Assert.AreEqual(resource.OvertimeWork, resourceAfterModification.OvertimeWork);
            Assert.AreEqual(resource.Cost, resourceAfterModification.Cost);
        }

        [Test]
        public async Task TestDeleteResource()
        {
            var remoteName = await UploadFileToStorageAsync("Home move plan.mpp");

            var deleteResponse = await TasksApi.DeleteResourceAsync(new DeleteResourceRequest
            {
                Name = remoteName,
                Folder = this.DataFolder,
                ResourceUid = 0
            });

            Assert.AreEqual((int)HttpStatusCode.OK, deleteResponse.Code);

            var resourceResponse = await TasksApi.GetResourcesAsync(new GetResourcesRequest
            {
                Name = remoteName,
                Folder = this.DataFolder
            });

            Assert.AreEqual((int)HttpStatusCode.OK, resourceResponse.Code);
            Assert.AreEqual(0, resourceResponse.Resources.ResourceItem.Count);
        }
    }
}
