
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

using System;
using System.Linq;

using Aspose.Tasks.Cloud.Sdk.Tests.Base;
using Aspose.Tasks.Cloud.Sdk.Model;
using Aspose.Tasks.Cloud.Sdk.Model.Requests;
using NUnit.Framework;

namespace Aspose.Tasks.Cloud.Sdk.Tests.DocumentProperties
{
    [TestFixture]
    internal sealed class TestDocumentProperties : BaseTestContext
    {
        [Test]
        public void TestGetDocumentProperties()
        {
            var remoteName = UploadFileToStorage("Home move plan.mpp");

            var response = TasksApi.GetDocumentProperties(new GetDocumentPropertiesRequest
            {
                Name = remoteName,
                Folder = this.DataFolder
            });

            Assert.AreEqual(HttpStatusCode.OK.ToString(), response.Status);
            Assert.AreEqual(48, response.Properties.List.Count);
            Assert.AreEqual("Title", response.Properties.List[0].Name);
            Assert.AreEqual("Home Move", response.Properties.List[0].Value);
        }

        [Test]
        public void TestGetDocumentProperty()
        {
            var remoteName = UploadFileToStorage("Home move plan.mpp");

            var response = TasksApi.GetDocumentProperty(new GetDocumentPropertyRequest
            {
                Name = remoteName,
                Folder = this.DataFolder,
                PropertyName = "Title"
            });

            Assert.AreEqual(HttpStatusCode.OK.ToString(), response.Status);
            Assert.IsNotNull(response.Property);
            Assert.AreEqual("Title", response.Property.Name);
            Assert.AreEqual("Home Move", response.Property.Value);
        }

        [Test]
        public void TestEditDocumentProperty()
        {
            var remoteName = UploadFileToStorage("Home move plan.mpp");

            var putResponse = TasksApi.PutDocumentProperty(new PutDocumentPropertyRequest
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

            var response = TasksApi.GetDocumentProperties(new GetDocumentPropertiesRequest
            {
                Name = remoteName,
                Folder = this.DataFolder
            });

            Assert.AreEqual(HttpStatusCode.OK.ToString(), response.Status);
            Assert.AreEqual(48, response.Properties.List.Count);
            Assert.AreEqual("Title", response.Properties.List[0].Name);
            Assert.AreEqual("New title value", response.Properties.List[0].Value);
        }

        [Test]
        public void TestEditDocumentPropertyViaPost()
        {
            var remoteName = UploadFileToStorage("Home move plan.mpp");

            var putResponse = TasksApi.PostDocumentProperty(new PostDocumentPropertyRequest
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

            var response = TasksApi.GetDocumentProperties(new GetDocumentPropertiesRequest
            {
                Name = remoteName,
                Folder = this.DataFolder
            });

            Assert.AreEqual(HttpStatusCode.OK.ToString(), response.Status);
            Assert.AreEqual(48, response.Properties.List.Count);
            Assert.AreEqual("Title", response.Properties.List[0].Name);
            Assert.AreEqual("New title value", response.Properties.List[0].Value);
        }

        [Test]
        public void TestAddNonExistingDocumentProperty()
        {
            var remoteName = UploadFileToStorage("Home move plan.mpp");

            var postResponse = TasksApi.PostDocumentProperty(new PostDocumentPropertyRequest
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

            var response = TasksApi.GetDocumentProperties(new GetDocumentPropertiesRequest
            {
                Name = remoteName,
                Folder = this.DataFolder
            });

            Assert.AreEqual(HttpStatusCode.OK.ToString(), response.Status);
            Assert.AreEqual(48, response.Properties.List.Count);
            Assert.IsNull(response.Properties.List.Where(p => p.Name == "new property").FirstOrDefault());
        }
    }
}
