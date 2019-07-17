using System.Net;

namespace Aspose.Tasks.Cloud.Sdk
{
    /// <summary>
    ///     Error code
    /// </summary>
    public class StatusCode
    {
        /// <summary>
        ///     Code
        /// </summary>
        public string Code { set; get; }

        /// <summary>
        ///     The status code as <see cref="System.Net.HttpStatusCode"/>
        /// </summary>
        public HttpStatusCode HttpStatusCode { set; get; }

        /// <summary>
        ///     Description
        /// </summary>
        public string Description { set; get; }
    }
}
