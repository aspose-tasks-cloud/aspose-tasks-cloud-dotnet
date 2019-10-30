// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TestReadProject.cs">
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
using System.Net;
using Task = System.Threading.Tasks.Task;

namespace Aspose.Tasks.Cloud.Sdk.Tests.Project
{
    [TestFixture]
    internal sealed class TestReadProject : BaseTestContext
    {
        [Test]
        public async Task TestGetProjectIds()
        {
            var remoteName = await UploadFileToStorageAsync("p6_multiproject.xml");

            var response = await TasksApi.GetProjectIdsAsync(new GetProjectIdsRequest
            {
                Name = remoteName,
                Folder = this.DataFolder
            });

            Assert.AreEqual((int)HttpStatusCode.OK, response.Code);
            CollectionAssert.AreEquivalent(new string[] { "1", "111" } , response.ProjectIds);
        }

        [Test]
        public async Task TestReadXer()
        {
            var remoteName = await UploadFileToStorageAsync("testXer.xer");

            var response = await TasksApi.GetTaskDocumentAsync(new GetTaskDocumentRequest
            {
                Name = remoteName,
                Folder = this.DataFolder
            });

            Assert.IsTrue(response.Length > 0);
        }
    }
}
