
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TestDocumentProperties.cs">
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
using System.Linq;
using System.Net;
using Task = System.Threading.Tasks.Task;

namespace Aspose.Tasks.Cloud.Sdk.Tests.DocumentProperties
{
    [TestFixture]
    internal sealed class TestDocumentProperties : BaseTestContext
    {
        [Test]
        public async Task TestGetDocumentProperties()
        {
            var remoteName = await UploadFileToStorageAsync("Home move plan.mpp");

            var response = await TasksApi.GetDocumentPropertiesAsync(new GetDocumentPropertiesRequest
            {
                Name = remoteName,
                Folder = this.DataFolder
            });

            Assert.AreEqual((int)HttpStatusCode.OK, response.Code);
            Assert.AreEqual(51, response.Properties.List.Count);
            Assert.AreEqual("Title", response.Properties.List[0].Name);
            Assert.AreEqual("Home Move", response.Properties.List[0].Value);
        }

        [Test]
        public async Task TestGetDocumentProperty()
        {
            var remoteName = await UploadFileToStorageAsync("Home move plan.mpp");

            var response = await TasksApi.GetDocumentPropertyAsync(new GetDocumentPropertyRequest
            {
                Name = remoteName,
                Folder = this.DataFolder,
                PropertyName = "Title"
            });

            Assert.AreEqual((int)HttpStatusCode.OK, response.Code);
            Assert.IsNotNull(response.Property);
            Assert.AreEqual("Title", response.Property.Name);
            Assert.AreEqual("Home Move", response.Property.Value);
        }

        [Test]
        public async Task TestEditDocumentProperty()
        {
            var remoteName = await UploadFileToStorageAsync("Home move plan.mpp");

            var putResponse = await TasksApi.PutDocumentPropertyAsync(new PutDocumentPropertyRequest
            {
                Name = remoteName,
                Folder = this.DataFolder,
                PropertyName = "Title",
                Property = new DocumentProperty
                {
                    Name = "Title", 
                    Value = "New title value"
                }
            });

            var response = await TasksApi.GetDocumentPropertiesAsync(new GetDocumentPropertiesRequest
            {
                Name = remoteName,
                Folder = this.DataFolder
            });

            Assert.AreEqual((int)HttpStatusCode.OK, response.Code);
            Assert.AreEqual(51, response.Properties.List.Count);
            Assert.AreEqual("Title", response.Properties.List[0].Name);
            Assert.AreEqual("New title value", response.Properties.List[0].Value);
        }

        [Test]
        public async Task TestEditDocumentPropertyViaPost()
        {
            var remoteName = await UploadFileToStorageAsync("Home move plan.mpp");

            var putResponse = await TasksApi.PostDocumentPropertyAsync(new PostDocumentPropertyRequest
            {
                Name = remoteName,
                Folder = this.DataFolder,
                PropertyName = "Title",
                Property = new DocumentProperty
                {
                    Name = "Title",
                    Value = "New title value"
                }
            });

            var response = await TasksApi.GetDocumentPropertiesAsync(new GetDocumentPropertiesRequest
            {
                Name = remoteName,
                Folder = this.DataFolder
            });

            Assert.AreEqual((int)HttpStatusCode.OK, response.Code);
            Assert.AreEqual(51, response.Properties.List.Count);
            Assert.AreEqual("Title", response.Properties.List[0].Name);
            Assert.AreEqual("New title value", response.Properties.List[0].Value);
        }

        [Test]
        public async Task TestAddNonExistingDocumentProperty()
        {
            var remoteName = await UploadFileToStorageAsync("Home move plan.mpp");

            var postResponse = await TasksApi.PostDocumentPropertyAsync(new PostDocumentPropertyRequest
            {
                Name = remoteName,
                Folder = this.DataFolder,
                PropertyName = "new property",
                Property = new DocumentProperty
                {
                    Name = "new property",
                    Value = "New property value"
                }
            });

            var response = await TasksApi.GetDocumentPropertiesAsync(new GetDocumentPropertiesRequest
            {
                Name = remoteName,
                Folder = this.DataFolder
            });

            Assert.AreEqual((int)HttpStatusCode.OK, response.Code);
            Assert.AreEqual(51, response.Properties.List.Count);
            Assert.IsNull(response.Properties.List.Where(p => p.Name == "new property").FirstOrDefault());
        }
    }
}
