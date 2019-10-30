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

using System;
using Aspose.Tasks.Cloud.Sdk.Model.Requests;
using Aspose.Tasks.Cloud.Sdk.Tests.Base;
using NUnit.Framework;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Aspose.Tasks.Cloud.Sdk.Tests
{
    [TestFixture]
    public class BasicApiTests : BaseTestContext
    {
        private static readonly Func<MethodInfo, bool> AsyncMethodFilteringPredicate = m =>
            m.IsPublic && m.ReturnType.IsGenericType
                       && m.ReturnType.GetGenericTypeDefinition() == typeof(Task<>);
        
        [Test]
        public async Task TestHandleNonExistingFile()
        {
            string name = "notExistingFile.mpp";
            var response = await this.TasksApi.GetTasksAsync(new GetTasksRequest()
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
                .Where(AsyncMethodFilteringPredicate)
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

        /// <summary>
        /// Check if all API methods have sync and async versions and async versions has correct name pattern
        /// </summary>
        [Test]
        public void TestApiSyncAndAsyncMethodsEquivalence()
        {
            var allMethods = typeof(TasksApi).GetMethods().Where(m => m.DeclaringType != typeof(object));
            var asyncMethods = allMethods.Where(AsyncMethodFilteringPredicate);
            
            var asyncMethodsWithWrongNamePattern = asyncMethods.Select(m => m.Name).Where(n => !n.Contains("Async"));
            Assert.That(asyncMethodsWithWrongNamePattern, Is.Empty);

            var syncMethods = allMethods.Except(asyncMethods);
            Assert.AreEqual(syncMethods.Count(), asyncMethods.Count());
        }
    }
}
