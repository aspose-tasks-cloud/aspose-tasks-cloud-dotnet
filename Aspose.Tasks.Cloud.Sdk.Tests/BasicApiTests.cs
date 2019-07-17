// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="BasicApiTests.cs">
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
using System.IO;
using System.Linq;
using System.Text;

namespace Aspose.Tasks.Cloud.Sdk.Tests
{
    [TestFixture]
    public class BasicApiTests : BaseTestContext
    {
        [Test]
        public void TestHandleNonExistingFile()
        {
            string name = "notExistingFile.mpp";
            var response = this.TasksApi.GetTasks(new GetTasksRequest()
            {
                Name = name
            });

            Assert.IsNull(response);
        }

        /// <summary>
        /// Check if all API methods have covered by tests
        /// </summary>
        [Test]
        public void TestApiCoverage()
        {
            var methods = typeof(TasksApi).GetMethods()
                .Where(p => p.IsPublic && p.DeclaringType != typeof(object))
                .Select(p => p.Name)
                .ToList();
            var unitTestFolder = DirectoryHelper.GetRootSdkFolder();
            var unitTestFiles = DirectoryHelper.GetFilesByExtension(unitTestFolder, ".cs", SearchOption.AllDirectories).ToList();
            var filesContent = unitTestFiles.Select(File.ReadAllText).ToList();
            var strBuilder = new StringBuilder();
            foreach (var methodInfo in methods)
            {
                if (filesContent.All(p => !p.Contains(methodInfo)))
                {
                    strBuilder.AppendFormat("Uncovered api method {0}\n", methodInfo);
                }
            }

            Assert.IsTrue(strBuilder.Length == 0, strBuilder.ToString());
        }
    }
}
