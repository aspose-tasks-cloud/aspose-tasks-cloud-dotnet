﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aspose.Tasks.Cloud.Sdk.Model.Requests
{
    /// <summary>
    /// Request model for <see cref="Sdk.Api.TasksApi.CreateTableTextStyle" /> operation.
    /// </summary>  
    public class CreateTableTextStyleRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTableTextStyleRequest"/> class.
        /// </summary>        
        public CreateTableTextStyleRequest()
        {
        }

        /// <summary>
        /// The name of the file.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Uid of the view.
        /// </summary>  
        public int ViewUid { get; set; }

        /// <summary>
        /// A DTO of TableTextStyle to create
        /// </summary>
        public TableTextStyle TableTextStyle { get; set; }

        /// <summary>
        /// The document storage.
        /// </summary>  
        public string Storage { get; set; }

        /// <summary>
        /// The document folder.
        /// </summary>  
        public string Folder { get; set; }
    }
}
