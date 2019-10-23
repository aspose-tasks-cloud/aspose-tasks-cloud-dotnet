using System.Collections.Generic;
using System.Text;

namespace Aspose.Tasks.Cloud.Sdk.Model
{
    public class ProjectList : LinkElement
    {
        /// <summary>
        /// Gets or sets Projects
        /// </summary>  
        public List<ProjectInfo> ProjectInfo { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
            var sb = new StringBuilder();
            sb.Append("class ProjectList {\n");
            sb.Append("  Projects: ").Append(this.ProjectInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}