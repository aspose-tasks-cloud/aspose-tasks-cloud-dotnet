using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Aspose.Tasks.Cloud.Sdk.Model
{
    /// <summary>
    /// Represents a view in Project
    /// </summary>
    public class View
    {
        /// <summary>
        /// Gets or sets a value indicating whether Microsoft Project shows the single view 
        /// name in the View or the Other Views drop-down lists in the Ribbon
        /// </summary>
        public bool ShowInMenu { get; set; }

        /// <summary>
        /// Gets the type of item in the single view, such as tasks or resources. Read-only.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public ItemType Type { get; set; }

        /// <summary>
        /// Gets the screen type for the single view. Read-only.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public ViewScreen Screen { get; set; }

        /// <summary>
        /// Gets or sets the name of a View object.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets the unique identifier of a view.
        /// </summary>
        public int Uid { get; set; }
    }
}
