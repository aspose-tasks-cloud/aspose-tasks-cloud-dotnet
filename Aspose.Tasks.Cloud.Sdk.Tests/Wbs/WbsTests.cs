
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="WbsTests.cs">
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

namespace Aspose.Tasks.Cloud.Sdk.Tests.Tasks
{
    using System.Collections.Generic;

    [TestFixture]
    internal sealed class WbsTests : BaseTestContext
    {
        [Test]
        public async Task TestGetWbsDefinition()
        {
            var remoteName = await UploadFileToStorageAsync("WBSDefinition.mpp");
            var response = await TasksApi.GetWbsDefinitionAsync(new GetWbsDefinitionRequest()
            {
                Name = remoteName,
                Folder = this.DataFolder
            });

            Assert.AreEqual((int)HttpStatusCode.OK, response.Code);
            Assert.IsTrue((bool)response.WBSDefinition.GenerateWBSCode);
            Assert.IsTrue((bool)response.WBSDefinition.VerifyUniqueness);
        }

        [Test]
        public async Task TestRenumberWbsCode()
        {
            var remoteName = await UploadFileToStorageAsync("WBSDefinition.mpp");
            var response = await TasksApi.PutRenumberWbsCodeAsync(new PutRenumberWbsCodeRequest()
            {
                Name = remoteName,
                Folder = this.DataFolder,
                TaskUids = new List<int?>()
            });

            Assert.AreEqual((int)HttpStatusCode.OK, response.Code);
        }
    }
}