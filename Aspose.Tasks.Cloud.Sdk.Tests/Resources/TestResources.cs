
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

using System;
using System.Linq;

using Aspose.Tasks.Cloud.Sdk.Tests.Base;
using Aspose.Tasks.Cloud.Sdk.Model.Requests;
using NUnit.Framework;

namespace Aspose.Tasks.Cloud.Sdk.Tests.Tasks
{
    [TestFixture]
    public class TestResources : BaseTestContext
    {
        [Test]
        public void TestGetResources()
        {
            var remoteName = UploadFileToStorage("NewProductDev.mpp");

            var resourceResponse = TasksApi.GetResources(new GetResourcesRequest
            {
                Name = remoteName,
                Storage = "Tasks",
                Folder = this.DataFolder
            });

            Assert.AreEqual("OK", resourceResponse.Status);
            Assert.IsNotNull(resourceResponse.Resources);
            Assert.AreEqual(2, resourceResponse.Resources.ResourceItem.Count);
            Assert.AreEqual("Project manager", resourceResponse.Resources.ResourceItem[1].Name);
            Assert.AreEqual(1, resourceResponse.Resources.ResourceItem[1].Uid);
            Assert.AreEqual(1, resourceResponse.Resources.ResourceItem[1].Id);
        }

        [Test]
        public void TestAddResource()
        {
            var remoteName = UploadFileToStorage("Home move plan.mpp");

            var resourceResponse = TasksApi.GetResources(new GetResourcesRequest
            {
                Name = remoteName,
                Storage = "Tasks",
                Folder = this.DataFolder
            });

            Assert.AreEqual("OK", resourceResponse.Status);
            var count = resourceResponse.Resources.ResourceItem.Count;

            var postResponse = TasksApi.PostResource(new PostResourceRequest
            {
                Name = remoteName,
                Folder = this.DataFolder,
                ResourceName = "new resource"
            });

            Assert.AreEqual("Created", postResponse.Status);

            resourceResponse = TasksApi.GetResources(new GetResourcesRequest
            {
                Name = remoteName,
                Storage = "Tasks",
                Folder = this.DataFolder
            });


            Assert.AreEqual(count + 1, resourceResponse.Resources.ResourceItem.Count);
            var addedResource = resourceResponse.Resources.ResourceItem.Where(r => r.Uid == postResponse.ResourceItem.Uid).Single();
            Assert.AreEqual("new resource", addedResource.Name);
        }

        [Test]
        public void TestEditResource()
        {
            var remoteName = UploadFileToStorage("sample.mpp");

            var resourceResponse = TasksApi.GetResource(new GetResourceRequest
            {
                Name = remoteName,
                Storage = "Tasks",
                Folder = this.DataFolder,
                ResourceUid = 1
            });

            Assert.AreEqual("OK", resourceResponse.Status);
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

            var putResponse = TasksApi.PutResource(new PutResourceRequest
            {
                Name = remoteName,
                Folder = this.DataFolder,
                ResourceUid = 1,
                Resource = resource,
                Recalculate = false,
                Mode = Model.CalculationMode.None
            });

            Assert.AreEqual("OK", putResponse.Status);

            resourceResponse = TasksApi.GetResource(new GetResourceRequest
            {
                Name = remoteName,
                Storage = "Tasks",
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
        public void TestDeleteResource()
        {
            var remoteName = UploadFileToStorage("Home move plan.mpp");

            var deleteResponse = TasksApi.DeleteResource(new DeleteResourceRequest
            {
                Name = remoteName,
                Storage = "Tasks",
                Folder = this.DataFolder,
                ResourceUid = 0
            });

            Assert.AreEqual("OK", deleteResponse.Status);

            var resourceResponse = TasksApi.GetResources(new GetResourcesRequest
            {
                Name = remoteName,
                Storage = "Tasks",
                Folder = this.DataFolder
            });

            Assert.AreEqual("OK", resourceResponse.Status);
            Assert.AreEqual(0, resourceResponse.Resources.ResourceItem.Count);
        }
    }
}
