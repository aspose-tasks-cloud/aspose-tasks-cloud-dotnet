using System;
using System.Text;

namespace Aspose.Tasks.Cloud.Sdk.Model
{
    /// <summary>
    /// Brief info about the published project available on Project Online.
    /// </summary>
    public class ProjectInfo
    {
        /// <summary>
        /// The unique identifier of the project.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// The name of the project.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The date and time when the project was created.
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Value indicating whether the project is checked out.
        /// </summary>
        public bool IsCheckedOut { get; set; }

        /// <summary>
        /// The most recent date when the project was published.
        /// </summary>
        public DateTime LastPublishedDate { get; set; }

        /// <summary>
        /// The most recent date when the project was saved.
        /// </summary>
        public DateTime LastSavedDate { get; set; }

        /// <summary>
        /// The description of the project.
        /// </summary>
        public string Description { get; set; }
        
        

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
            var sb = new StringBuilder();
            sb.Append("class CalendarItem {\n");
            sb.Append("  Id: ").Append(this.Id).Append("\n");
            sb.Append("  Name: ").Append(this.Name).Append("\n");
            sb.Append("  CreatedDate: ").Append(this.CreatedDate).Append("\n");
            sb.Append("  IsCheckedOut: ").Append(this.IsCheckedOut).Append("\n");
            sb.Append("  LastPublishedDate: ").Append(this.LastPublishedDate).Append("\n");
            sb.Append("  LastSavedDate: ").Append(this.LastSavedDate).Append("\n");
            sb.Append("  Description: ").Append(this.Description).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}