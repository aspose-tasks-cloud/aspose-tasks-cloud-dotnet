// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="BaseTestContext.cs">
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
using Newtonsoft.Json;
using NUnit.Framework;
using System.Collections.Generic;
using System.IO;

namespace Aspose.Tasks.Cloud.Sdk.Tests.Base
{

    /// <summary>
    /// Base class for all tests
    /// </summary>
    [TestFixture]
    public abstract class BaseTestContext
    {
        protected const string BaseProductUri = "https://api.aspose.cloud";

        private readonly Keys keys;
        private readonly IList<DeleteRequest> clearingRequests;

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseTestContext"/> class.
        /// </summary>
        protected BaseTestContext()
        {
            // To run tests with your own credentials please substitute the credentials below
            // this.keys = new Keys { AppKey = "your app key", AppSid = "your app sid" };
            var serverCreds = DirectoryHelper.GetPath("Settings", "servercreds.json", Path.GetDirectoryName(TestContext.CurrentContext.TestDirectory));
            this.keys = JsonConvert.DeserializeObject<Keys>(File.ReadAllText(serverCreds));
            if (this.keys == null)
            {
                throw new FileNotFoundException("servercreds.json doesn't contain AppKey and AppSid");
            }

            var configuration = new Configuration { ApiBaseUrl = BaseProductUri, AppKey = this.keys.AppKey, AppSid = this.keys.AppSid };
            this.TasksApi = new TasksApi(configuration);
            this.StorageApi = new StorageApi(configuration);
            clearingRequests = new List<DeleteRequest>();
        }

        [OneTimeTearDown]
        public void Clean()
        {
            foreach (var request in clearingRequests)
            {
                var response = this.StorageApi.DeleteFile(request);
                Assert.That(response, Is.Not.Null.And.Property("Code").EqualTo(200));
            }
        }

        /// <summary>
        /// Uploads a test data file to storage and returns the name of the uploaded file.
        /// </summary>
        protected string UploadFileToStorage(string localName)
        {
            var remoteName = "TempFile_" + localName.Replace(".mpp", string.Empty) + ".mpp";
            var fullName = Path.Combine(this.DataFolder, remoteName);
            var directory = Path.GetDirectoryName(Path.GetDirectoryName(TestContext.CurrentContext.TestDirectory));

            using (var fileStream = File.OpenRead(Path.Combine(directory, GetDataDir(), localName)))
            {

                var postRequest = new PostCreateRequest(fullName, fileStream, storage: "Tasks");
                var response = this.StorageApi.UploadFile(postRequest);
                PrepareClearingRequest(postRequest);

            }

            return remoteName;
        }

        private void PrepareClearingRequest(PostCreateRequest postRequest)
        {
            clearingRequests.Add(new DeleteRequest(postRequest.Path, postRequest.VersionId, postRequest.Storage));
        }

        /// <summary>
        /// Base path to test data        
        /// </summary>
        protected static string BaseTestDataPath
        {
            get
            {
                return "Temp/SdkTests/TestData";
            }
        }

        /// <summary>
        /// Base path to output data
        /// </summary>
        protected static string BaseTestOutPath => "TestOut";

        /// <summary>
        /// Returns common folder with source test files
        /// </summary>
        protected static string CommonFolder => "Common/";

        protected string DataFolder => Path.Combine(BaseTestDataPath, this.GetType().Name);

        /// <summary>
        /// Storage API
        /// </summary>
        protected StorageApi StorageApi { get; set; }

        /// <summary>
        /// Tasks API
        /// </summary>
        protected TasksApi TasksApi { get; set; }

        /// <summary>
        /// AppSid
        /// </summary>
        protected string AppSid => this.keys.AppSid;

        /// <summary>
        /// AppSid
        /// </summary>
        protected string AppKey => this.keys.AppKey;

        /// <summary>
        /// Returns test data path
        /// </summary>
        /// <param name="subfolder">subfolder for specific tests</param>
        /// <returns>test data path</returns>
        protected static string GetDataDir(string subfolder = null)
        {
            return Path.Combine("TestData", string.IsNullOrEmpty(subfolder) ? string.Empty : subfolder);
        }

        private class Keys
        {
            public string AppSid { get; set; }

            public string AppKey { get; set; }
        }
    }
}