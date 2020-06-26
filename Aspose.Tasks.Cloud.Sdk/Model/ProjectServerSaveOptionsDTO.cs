using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aspose.Tasks.Cloud.Sdk.Model
{
    /// <summary>
    ///  Allows to specify additional options when project is saved to Project Server or Project Online.
    /// </summary>
    public class ProjectServerSaveOptionsDTO
    {
        /// <summary>
        /// Gets or sets name of a project which is displayed in Project Server\Project Online projects list.
        /// Should be unique within Project Server\Project Online instance. 
        /// Is the value is omitted, the value of Prj.Name property will be used instead.
        /// </summary>
        public string ProjectName { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of a project. Should be unique within Project Server\Project Online instance.
        /// </summary>
        public string ProjectGuid { get; set; }

        /// <summary>
        /// Gets or sets timeout used when waiting for processing of save project request by a Project Server's queue processing service.
        /// The default value for this property is 1 minute. The processing time may be longer for large projects 
        /// or in case when Project Server instance is too busy responding to other requests.
        /// </summary>
        public string Timeout { get; set; }

        /// <summary>
        /// Gets or sets interval between queue job status requests. The default value is 2 seconds.
        /// </summary>
        public string PollingInterval { get; set; }

    }
}
