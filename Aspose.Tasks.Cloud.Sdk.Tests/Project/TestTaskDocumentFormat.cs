
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TestTaskDocumentFormat.cs">
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
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using System.IO;
using Task = System.Threading.Tasks.Task;

namespace Aspose.Tasks.Cloud.Sdk.Tests.Project
{
    [TestFixture]
    internal sealed class TestTaskDocumentFormat : BaseTestContext
    {
        [Test]
        public async Task TestGetDocumentInCsvFormat()
        {
            var remoteName = await UploadFileToStorageAsync("Home move plan.mpp");

            var response = await TasksApi.GetTaskDocumentWithFormatAsync(new GetTaskDocumentWithFormatRequest
            {
                Format = ProjectFileFormat.Csv,
                Name = remoteName,
                Folder = this.DataFolder,
            });

            Assert.IsNotNull(response);
            Assert.IsTrue(response.Length > 0);
            response.Seek(0, SeekOrigin.Begin);

            using (var sr = new StreamReader(response))
            {
                var headersLine = sr.ReadLine();

                var line1 = sr.ReadLine();
                Assert.AreEqual("ID;Task_Name;Outline_Level;Duration;Start_Date;Finish_Date;Percent_Comp;Cost;Work", headersLine);
                Assert.AreEqual("1;Five to Eight Weeks Before Moving;1;16 days;Thu 01.01.04 08:00;Thu 22.01.04 17:00;0%;$0;0 hrs", line1);
            }
        }

        [Test]
        public async Task TestGetDocumentInCsvFormatWithSaveOptions()
        {
            var remoteName = await UploadFileToStorageAsync("Home move plan.mpp");

            // SaveOptions parameters is a json-serialized representation of 
            // Aspose.Tasks's SaveOptions class or its format-specific inheritors (Like CsvOptions, etc):
            // See Aspose.Tasks reference: https://apireference.aspose.com/net/tasks/aspose.tasks.saving/saveoptions

            var saveOptionsSerialized = "{ \"TextDelimiter\":\"Comma\", \"IncludeHeaders\":false,\"NonExistingTestProperty\":false," +
                "\"View\":{ \"Columns\":[{Type:\"GanttChartColumn\",\"Name\":\"TestColumn1\",\"Property\":\"Name\",\"Width\":120}," +
                "{Type:\"GanttChartColumn\",\"Name\":\"TestColumn2\",\"Property\":\"Duration\",\"Width\":120}]}}";

            var saveOptions = JObject.Parse(saveOptionsSerialized);

            var response = await TasksApi.PostTaskDocumentWithFormatAsync(new PostTaskDocumentWithFormatRequest
            {
                Format = ProjectFileFormat.Csv,
                Name = remoteName,
                Folder = this.DataFolder,
                SaveOptions = saveOptions
            });

            Assert.IsNotNull(response);
            Assert.IsTrue(response.Length > 0);
            response.Seek(0, SeekOrigin.Begin);

            using (var sr = new StreamReader(response))
            {
                var line1 = sr.ReadLine();
                Assert.AreEqual("Five to Eight Weeks Before Moving,16 days", line1);
            }
        }

        [Test]
        public async Task TestGetDocumentAsZippedHtml()
        {
            var remoteName = await UploadFileToStorageAsync("Home move plan.mpp");

            var response = await TasksApi.GetTaskDocumentWithFormatAsync(new GetTaskDocumentWithFormatRequest
                                                                  {
                                                                       Format = ProjectFileFormat.Html,
                                                                       Name = remoteName,
                                                                       Folder = this.DataFolder,
                                                                       ReturnAsZipArchive = true
                                                                   });

            Assert.IsNotNull(response);
            Assert.IsTrue(response.Length > 0);
        }
    }
}
