using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Aspose.Tasks.Cloud.Sdk
{
    /// <summary>
    ///     Storage status codes
    /// </summary>
    internal static class StatusCodes
    {
        /// <summary>
        ///     Operation Failed. The authentication data is incorrect.
        /// </summary>
        public static StatusCode ErrorAuthentication = new StatusCode()
        {
            Code = "errorAuthentication",
            HttpStatusCode = HttpStatusCode.Unauthorized,
            Description = "Operation Failed. The authentication data is incorrect."
        };

        /// <summary>
        ///     Operation Failed. General Error.
        /// </summary>
        public static StatusCode Error = new StatusCode()
        {
            Code = "error",
            HttpStatusCode = HttpStatusCode.BadRequest,
            Description = "Operation Failed. General Error."
        };

        /// <summary>
        ///     Operation Failed. The input data did not pass validation.
        /// </summary>
        public static StatusCode ErrorInvalidInputData = new StatusCode()
        {
            Code = "errorInvalidInputData",
            HttpStatusCode = HttpStatusCode.BadRequest,
            Description = "Operation Failed. The input data is not valid."
        };

        /// <summary>
        ///     Operation Failed. Internal error.
        /// </summary>
        public static StatusCode InternalError = new StatusCode()
        {
            Code = "internalError",
            HttpStatusCode = HttpStatusCode.InternalServerError,
            Description = "Operation Failed. Internal error."
        };
    }
}
