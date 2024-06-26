﻿
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TestReport.cs">
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
using System.Net;
using System.Text;
using Task = System.Threading.Tasks.Task;

namespace Aspose.Tasks.Cloud.Sdk.Tests.Reports
{
    [TestFixture]
    internal sealed class TestReport : BaseTestContext
    {
        [Test]
        public async Task TestGetReportPdf()
        {
            var remoteName = await UploadFileToStorageAsync("Home move plan.mpp");
            var response = await TasksApi.GetReportPdfAsync(new GetReportPdfRequest()
            { 
                Type = ReportType.Milestones,
                Name = remoteName,
                Folder = this.DataFolder
            });

            Assert.IsTrue(response.Length > 0);
            var buffer = new byte[4];
            response.Read(buffer, 0, 4);
            Assert.AreEqual("%PDF", Encoding.ASCII.GetString(buffer));
        }

        [Test]
        public async Task TestGetCriticalPath()
        {
            var remoteName = await UploadFileToStorageAsync("Home move plan.mpp");
            var response = await TasksApi.GetCriticalPathAsync(new GetCriticalPathRequest()
            {
                Name = remoteName,
                Folder = this.DataFolder
            });

            Assert.AreEqual((int)HttpStatusCode.OK, response.Code);
            Assert.AreEqual(76, response.Tasks.TaskItem.Count);
        }

        [Test]
        public async Task TestGetRiskAnalysisReport()
        {
            var remoteName = await UploadFileToStorageAsync("Home move plan.mpp");
            var response = await TasksApi.GetRiskAnalysisReportAsync(new GetRiskAnalysisReportRequest()
            {
                DistributionType = ProbabilityDistributionType.Normal,
                ConfidenceLevel = ConfidenceLevel.CL85,
                Optimistic = 80,
                Pessimistic = 130,
                Iterations = 200,
                TaskUid = 1,
                Name = remoteName,
                Folder = this.DataFolder
            });

            Assert.IsTrue(response.Length > 0);
            var buffer = new byte[4];
            response.Read(buffer, 0, 4);
            Assert.AreEqual("%PDF", Encoding.ASCII.GetString(buffer));
        }
    }
}
