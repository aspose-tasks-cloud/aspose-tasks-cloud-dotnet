
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TestOutlineCodes.cs">
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
using System.Threading.Tasks;

namespace Aspose.Tasks.Cloud.Sdk.Tests.Tasks
{
    [TestFixture]
    public class TestOutlineCodes : BaseTestContext
    {
        [Test]
        public async Task TestGetOutlineCodes()
        {
            var remoteName = await UploadFileToStorageAsync("NewProductDev.mpp");

            var response = await TasksApi.GetOutlineCodesAsync(new GetOutlineCodesRequest
            {
                Name = remoteName,
                Folder = this.DataFolder
            });

            Assert.AreEqual((int)HttpStatusCode.OK, response.Code);
            Assert.IsNotNull(response.OutlineCodes);
            Assert.AreEqual(2, response.OutlineCodes.List.Count);
        }

        [Test]
        public async Task TestGetOutlineCode()
        {
            var remoteName = await UploadFileToStorageAsync("NewProductDev.mpp");

            var response = await TasksApi.GetOutlineCodeByIndexAsync(new GetOutlineCodeByIndexRequest
            {
                Index = 1,
                Name = remoteName,
                Folder = this.DataFolder
            });

            Assert.AreEqual((int)HttpStatusCode.OK, response.Code);
            Assert.IsNotNull(response.OutlineCode);
            Assert.AreEqual("F45D601B-70C5-E311-A5BA-D43D7E937F92", response.OutlineCode.Guid);
        }

        [Test]
        public async Task TestDeleteOutlineCodeByIndex()
        {
            var remoteName = await UploadFileToStorageAsync("NewProductDev.mpp");

            var response = await TasksApi.DeleteOutlineCodeByIndexAsync(new DeleteOutlineCodeByIndexRequest
            {
                Index = 1,
                Name = remoteName,
                Folder = this.DataFolder
            });

            Assert.AreEqual((int)HttpStatusCode.OK, response.Code);

            var getResponse = await TasksApi.GetOutlineCodesAsync(new GetOutlineCodesRequest
            {
                Name = remoteName,
                Folder = this.DataFolder
            });

            Assert.AreEqual((int)HttpStatusCode.OK, getResponse.Code);
            Assert.IsNotNull(getResponse.OutlineCodes);
            Assert.AreEqual(1, getResponse.OutlineCodes.List.Count);
            Assert.AreEqual(1, getResponse.OutlineCodes.List[0].Index);
        }
    }
}
