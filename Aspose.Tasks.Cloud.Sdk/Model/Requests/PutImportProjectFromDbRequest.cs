// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PutImportProjectFromDbRequest.cs">
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
namespace Aspose.Tasks.Cloud.Sdk.Model.Requests 
{
    using System;
    using System.Collections.Generic;

    using Aspose.Tasks.Cloud.Sdk.Model; 

    /// <summary>
    /// Request model for <see cref="Aspose.Tasks.Cloud.Sdk.Api.TasksApi.PutImportProjectFromDb" /> operation.
    /// </summary>  
    public class PutImportProjectFromDbRequest  
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PutImportProjectFromDbRequest"/> class.
        /// </summary>        
        public PutImportProjectFromDbRequest()
        {
        }


        /// <summary>
        /// The type of source database. The supported values are (Msp, Mpd, Primavera).
        /// </summary>  
        public ProjectDatabaseType DatabaseType { get; set; }

        /// <summary>
        /// Uid of the project to import.
        /// </summary>  
        public string ProjectUid { get; set; }

        /// <summary>
        /// The name of the resulting file.
        /// </summary>  
        public string Filename { get; set; }

        /// <summary>
        /// The connection string to the source database.
        /// </summary>  
        public string ConnectionString { get; set; }

        /// <summary>
        /// Format of the resulting file. The import to Mpp format is not supported.
        /// </summary>  
        public ProjectFileFormat Format { get; set; }

        /// <summary>
        /// The document folder.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Schema of Microsoft project database (if applicable)
        /// </summary>  
        public string DatabaseSchema { get; set; }
    }
}
