
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="VbaTests.cs">
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
    [TestFixture]
    internal sealed class VbaTests : BaseTestContext
    {
        [Test]
        public async Task TestGetVbaProject()
        {
            var remoteName = await UploadFileToStorageAsync("VbaProject3.mpp");
            var vbaResponse = await TasksApi.GetVbaProjectAsync(new GetVbaProjectRequest()
            {
                Name = remoteName,
                Folder = this.DataFolder
            });

            Assert.AreEqual((int)HttpStatusCode.OK, vbaResponse.Code);
            Assert.IsNotNull(vbaResponse.VbaProject);
            Assert.IsNotNull(vbaResponse.VbaProject.Modules);

            Assert.AreEqual(7, vbaResponse.VbaProject.Modules.Count);
            Assert.AreEqual("Module1", vbaResponse.VbaProject.Modules[0].Name);
            Assert.IsTrue(vbaResponse.VbaProject.Modules[0].SourceCode.StartsWith("Type MEMORYSTATUS"));
        }
    }
}
