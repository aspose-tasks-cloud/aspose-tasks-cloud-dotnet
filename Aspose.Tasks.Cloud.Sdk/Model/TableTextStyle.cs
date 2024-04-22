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
    /// Represents a text style in a view table.
    /// </summary>
    public class TableTextStyle
    {
        /// <summary>
        /// Gets a row unique id. Return -1 if the style is to be applied to all rows of a view.
        /// </summary>
        public int RowUid { get; set; }

        /// <summary>
        /// Gets or sets a field the style is to be applied to.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public Field Field { get; set; }

        /// <summary>
        /// Returns a value of the TextItemType enum.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public TextItemType ItemType { get; set; }

        /// <summary>
        /// Gets or sets color of the text.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public Colors Color { get; set; }

        /// <summary>
        /// Gets or sets background pattern of the text style.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public BackgroundPattern BackgroundPattern { get; set; }

        /// <summary>
        /// Gets or sets background color of the text style.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public Colors BackgroundColor { get; set; }
    }
}
