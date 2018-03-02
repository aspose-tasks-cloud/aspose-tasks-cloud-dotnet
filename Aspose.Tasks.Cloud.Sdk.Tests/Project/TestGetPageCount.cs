﻿
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

using System;

using Aspose.Tasks.Cloud.Sdk.Tests.Base;
using Aspose.Tasks.Cloud.Sdk.Model.Requests;
using NUnit.Framework;
using Aspose.Tasks.Cloud.Sdk.Model;

namespace Aspose.Tasks.Cloud.Sdk.Tests.Project
{
    [TestFixture]
    internal sealed class TestGetPageCount : BaseTestContext
    {
        [Test]
        public void TestGetPageCountWithPresentationFormat()
        {
            var remoteName = UploadFileToStorage("Home move plan.mpp");

            var response = TasksApi.GetPageCount(new GetPageCountRequest
            {
                PresentationFormat = PresentationFormat.TaskUsage,
                Timescale = Timescale.Months,
                Name = remoteName,
                Folder = this.DataFolder,
            });

            Assert.AreEqual(HttpStatusCode.OK.ToString(), response.Status);
            Assert.AreEqual(6, response.PageCount);
        }

        [Test]
        public void TestGetPageCountWithPresentationFormatAndDateInterval()
        {
            var remoteName = UploadFileToStorage("Home move plan.mpp");

            var response = TasksApi.GetPageCount(new GetPageCountRequest
            {
                PresentationFormat = PresentationFormat.TaskUsage,
                Timescale = Timescale.Months,
                Name = remoteName,
                Folder = this.DataFolder,
                StartDate = new DateTime(2004, 1, 1),
                EndDate = new DateTime(2004, 2, 28)
            });

            Assert.AreEqual(HttpStatusCode.OK.ToString(), response.Status);
            Assert.AreEqual(6, response.PageCount);
        }
    }
}
