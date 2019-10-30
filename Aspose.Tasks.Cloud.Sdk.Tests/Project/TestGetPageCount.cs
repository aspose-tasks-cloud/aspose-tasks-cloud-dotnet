
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TestGetPageCount.cs">
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
using System.Net;
using Task = System.Threading.Tasks.Task;

namespace Aspose.Tasks.Cloud.Sdk.Tests.Project
{
    [TestFixture]
    internal sealed class TestGetPageCount : BaseTestContext
    {
        [Test]
        public async Task TestGetPageCountWithPresentationFormat()
        {
            var remoteName = await UploadFileToStorageAsync("Home move plan.mpp");

            var response = await TasksApi.GetPageCountAsync(new GetPageCountRequest
            {
                PresentationFormat = PresentationFormat.TaskUsage,
                Timescale = Timescale.Months,
                Name = remoteName,
                Folder = this.DataFolder,
            });

            Assert.AreEqual((int)HttpStatusCode.OK, response.Code);
            Assert.AreEqual(2, response.PageCount);
        }

        [Test]
        public async Task TestGetPageCountWithPresentationFormatAndDateInterval()
        {
            var remoteName = await UploadFileToStorageAsync("Home move plan.mpp");

            var response = await TasksApi.GetPageCountAsync(new GetPageCountRequest
            {
                PresentationFormat = PresentationFormat.TaskUsage,
                Timescale = Timescale.Months,
                Name = remoteName,
                Folder = this.DataFolder,
                StartDate = new DateTime(2004, 1, 1),
                EndDate = new DateTime(2004, 2, 28)
            });

            Assert.AreEqual((int)HttpStatusCode.OK, response.Code);
            Assert.AreEqual(2, response.PageCount);
        }
    }
}
