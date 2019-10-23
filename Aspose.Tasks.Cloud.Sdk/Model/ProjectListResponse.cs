using System.Text;

namespace Aspose.Tasks.Cloud.Sdk.Model
{
    public class ProjectListResponse : AsposeResponse
    {
        public ProjectList Projects { get; set; }
        
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
            var sb = new StringBuilder();
            sb.Append("class ProjectListResponse {\n");
            sb.Append("  List: ").Append(this.Projects).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}