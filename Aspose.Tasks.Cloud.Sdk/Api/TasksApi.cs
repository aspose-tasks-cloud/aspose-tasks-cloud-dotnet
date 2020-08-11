// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TasksApi.cs">
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

using System;
using System.Collections.Generic;
using System.IO;
using Aspose.Tasks.Cloud.Sdk.RequestHandlers;

namespace Aspose.Tasks.Cloud.Sdk
{
    using Aspose.Tasks.Cloud.Sdk.Model;
    using Aspose.Tasks.Cloud.Sdk.Model.Requests;
    using System.Net;
    using System.Text.RegularExpressions;

    /// <summary>
    /// Aspose.Tasks for Cloud API.
    /// </summary>
    public partial class TasksApi
    {
        private readonly ApiInvoker apiInvoker;
        private readonly Configuration configuration;

        /// <summary>
        /// Initializes a new instance of the <see cref="TasksApi"/> class.
        /// </summary>
        /// <param name="apiKey">
        /// The api Key.
        /// </param>
        /// <param name="appSid">
        /// The app Sid.
        /// </param>
        public TasksApi(string apiKey, string appSid)
            : this(new Configuration {AppKey = apiKey, AppSid = appSid})
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TasksApi"/> class.
        /// </summary>    
        /// <param name="configuration">Configuration settings</param>
        public TasksApi(Configuration configuration)
        {
            this.configuration = configuration;

            var requestHandlers = new List<IRequestHandler>();
            requestHandlers.Add(new OAuthRequestHandler(this.configuration));
            requestHandlers.Add(new DebugLogRequestHandler(this.configuration));
            requestHandlers.Add(new ApiExceptionRequestHandler());
            requestHandlers.Add(new AuthWithSignatureRequestHandler(this.configuration));
            this.apiInvoker = new ApiInvoker(requestHandlers);
        }

        /// <summary>
        /// Deletes a project assignment with all references to it. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteAssignmentRequest" /></param> 
        /// <returns><see cref="AsposeResponse"/></returns>            
        public AsposeResponse DeleteAssignment(DeleteAssignmentRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException("Missing required parameter 'name' when calling DeleteAssignment",
                    StatusCodes.ErrorInvalidInputData);
            }

            // verify the required parameter 'assignmentUid' is set
            if (request.AssignmentUid == null)
            {
                throw new ApiException("Missing required parameter 'assignmentUid' when calling DeleteAssignment",
                    StatusCodes.ErrorInvalidInputData);
            }

            // create path and map variables
            var resourcePath =
                UnescapePath(this.configuration.GetApiRootUrl() + "/tasks/{name}/assignments/{assignmentUid}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "assignmentUid", request.AssignmentUid);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fileName", request.FileName);

            try
            {
                var response = this.apiInvoker.InvokeApi(
                    resourcePath,
                    "DELETE",
                    null,
                    null,
                    null);
                if (response != null)
                {
                    return (AsposeResponse) SerializationHelper.Deserialize(response, typeof(AsposeResponse));
                }

                return null;
            }
            catch (ApiException ex)
            {
                if (ex.HttpStatusCode == HttpStatusCode.NotFound)
                {
                    return null;
                }

                throw;
            }
        }

        /// <summary>
        /// Deletes a project calendar 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteCalendarRequest" /></param> 
        /// <returns><see cref="AsposeResponse"/></returns>            
        public AsposeResponse DeleteCalendar(DeleteCalendarRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException("Missing required parameter 'name' when calling DeleteCalendar",
                    StatusCodes.ErrorInvalidInputData);
            }

            // verify the required parameter 'calendarUid' is set
            if (request.CalendarUid == null)
            {
                throw new ApiException("Missing required parameter 'calendarUid' when calling DeleteCalendar",
                    StatusCodes.ErrorInvalidInputData);
            }

            // create path and map variables
            var resourcePath =
                UnescapePath(this.configuration.GetApiRootUrl() + "/tasks/{name}/calendars/{calendarUid}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "calendarUid", request.CalendarUid);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fileName", request.FileName);

            try
            {
                var response = this.apiInvoker.InvokeApi(
                    resourcePath,
                    "DELETE",
                    null,
                    null,
                    null);
                if (response != null)
                {
                    return (AsposeResponse) SerializationHelper.Deserialize(response, typeof(AsposeResponse));
                }

                return null;
            }
            catch (ApiException ex)
            {
                if (ex.HttpStatusCode == HttpStatusCode.NotFound)
                {
                    return null;
                }

                throw;
            }
        }

        /// <summary>
        /// Deletes calendar exception from calendar exceptions collection. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteCalendarExceptionRequest" /></param> 
        /// <returns><see cref="AsposeResponse"/></returns>            
        public AsposeResponse DeleteCalendarException(DeleteCalendarExceptionRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException("Missing required parameter 'name' when calling DeleteCalendarException",
                    StatusCodes.ErrorInvalidInputData);
            }

            // verify the required parameter 'calendarUid' is set
            if (request.CalendarUid == null)
            {
                throw new ApiException("Missing required parameter 'calendarUid' when calling DeleteCalendarException",
                    StatusCodes.ErrorInvalidInputData);
            }

            // verify the required parameter 'index' is set
            if (request.Index == null)
            {
                throw new ApiException("Missing required parameter 'index' when calling DeleteCalendarException",
                    StatusCodes.ErrorInvalidInputData);
            }

            // create path and map variables
            var resourcePath = UnescapePath(this.configuration.GetApiRootUrl() +
                                            "/tasks/{name}/calendars/{calendarUid}/calendarExceptions/{index}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "calendarUid", request.CalendarUid);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fileName", request.FileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);

            try
            {
                var response = this.apiInvoker.InvokeApi(
                    resourcePath,
                    "DELETE",
                    null,
                    null,
                    null);
                if (response != null)
                {
                    return (AsposeResponse) SerializationHelper.Deserialize(response, typeof(AsposeResponse));
                }

                return null;
            }
            catch (ApiException ex)
            {
                if (ex.HttpStatusCode == HttpStatusCode.NotFound)
                {
                    return null;
                }

                throw;
            }
        }

        /// <summary>
        /// Delete a project extended attribute. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteExtendedAttributeByIndexRequest" /></param> 
        /// <returns><see cref="AsposeResponse"/></returns>            
        public AsposeResponse DeleteExtendedAttributeByIndex(DeleteExtendedAttributeByIndexRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException("Missing required parameter 'name' when calling DeleteExtendedAttributeByIndex",
                    StatusCodes.ErrorInvalidInputData);
            }

            // verify the required parameter 'index' is set
            if (request.Index == null)
            {
                throw new ApiException("Missing required parameter 'index' when calling DeleteExtendedAttributeByIndex",
                    StatusCodes.ErrorInvalidInputData);
            }

            // create path and map variables
            var resourcePath =
                UnescapePath(this.configuration.GetApiRootUrl() + "/tasks/{name}/extendedAttributes/{index}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);

            try
            {
                var response = this.apiInvoker.InvokeApi(
                    resourcePath,
                    "DELETE",
                    null,
                    null,
                    null);
                if (response != null)
                {
                    return (AsposeResponse) SerializationHelper.Deserialize(response, typeof(AsposeResponse));
                }

                return null;
            }
            catch (ApiException ex)
            {
                if (ex.HttpStatusCode == HttpStatusCode.NotFound)
                {
                    return null;
                }

                throw;
            }
        }

        /// <summary>
        /// Deletes a project outline code 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteOutlineCodeByIndexRequest" /></param> 
        /// <returns><see cref="AsposeResponse"/></returns>            
        public AsposeResponse DeleteOutlineCodeByIndex(DeleteOutlineCodeByIndexRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException("Missing required parameter 'name' when calling DeleteOutlineCodeByIndex",
                    StatusCodes.ErrorInvalidInputData);
            }

            // verify the required parameter 'index' is set
            if (request.Index == null)
            {
                throw new ApiException("Missing required parameter 'index' when calling DeleteOutlineCodeByIndex",
                    StatusCodes.ErrorInvalidInputData);
            }

            // create path and map variables
            var resourcePath = UnescapePath(this.configuration.GetApiRootUrl() + "/tasks/{name}/outlineCodes/{index}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);

            try
            {
                var response = this.apiInvoker.InvokeApi(
                    resourcePath,
                    "DELETE",
                    null,
                    null,
                    null);
                if (response != null)
                {
                    return (AsposeResponse) SerializationHelper.Deserialize(response, typeof(AsposeResponse));
                }

                return null;
            }
            catch (ApiException ex)
            {
                if (ex.HttpStatusCode == HttpStatusCode.NotFound)
                {
                    return null;
                }

                throw;
            }
        }

        /// <summary>
        /// Deletes a project resource with all references to it 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteResourceRequest" /></param> 
        /// <returns><see cref="AsposeResponse"/></returns>            
        public AsposeResponse DeleteResource(DeleteResourceRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException("Missing required parameter 'name' when calling DeleteResource",
                    StatusCodes.ErrorInvalidInputData);
            }

            // verify the required parameter 'resourceUid' is set
            if (request.ResourceUid == null)
            {
                throw new ApiException("Missing required parameter 'resourceUid' when calling DeleteResource",
                    StatusCodes.ErrorInvalidInputData);
            }

            // create path and map variables
            var resourcePath =
                UnescapePath(this.configuration.GetApiRootUrl() + "/tasks/{name}/resources/{resourceUid}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "resourceUid", request.ResourceUid);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fileName", request.FileName);

            try
            {
                var response = this.apiInvoker.InvokeApi(
                    resourcePath,
                    "DELETE",
                    null,
                    null,
                    null);
                if (response != null)
                {
                    return (AsposeResponse) SerializationHelper.Deserialize(response, typeof(AsposeResponse));
                }

                return null;
            }
            catch (ApiException ex)
            {
                if (ex.HttpStatusCode == HttpStatusCode.NotFound)
                {
                    return null;
                }

                throw;
            }
        }

        /// <summary>
        /// Deletes a project task with all references to it and rebuilds tasks tree. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteTaskRequest" /></param> 
        /// <returns><see cref="AsposeResponse"/></returns>            
        public AsposeResponse DeleteTask(DeleteTaskRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException("Missing required parameter 'name' when calling DeleteTask",
                    StatusCodes.ErrorInvalidInputData);
            }

            // verify the required parameter 'taskUid' is set
            if (request.TaskUid == null)
            {
                throw new ApiException("Missing required parameter 'taskUid' when calling DeleteTask",
                    StatusCodes.ErrorInvalidInputData);
            }

            // create path and map variables
            var resourcePath = UnescapePath(this.configuration.GetApiRootUrl() + "/tasks/{name}/tasks/{taskUid}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "taskUid", request.TaskUid);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fileName", request.FileName);

            try
            {
                var response = this.apiInvoker.InvokeApi(
                    resourcePath,
                    "DELETE",
                    null,
                    null,
                    null);
                if (response != null)
                {
                    return (AsposeResponse) SerializationHelper.Deserialize(response, typeof(AsposeResponse));
                }

                return null;
            }
            catch (ApiException ex)
            {
                if (ex.HttpStatusCode == HttpStatusCode.NotFound)
                {
                    return null;
                }

                throw;
            }
        }

        /// <summary>
        /// Delete task link. 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteTaskLinkRequest" /></param> 
        /// <returns><see cref="AsposeResponse"/></returns>            
        public AsposeResponse DeleteTaskLink(DeleteTaskLinkRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException("Missing required parameter 'name' when calling DeleteTaskLink",
                    StatusCodes.ErrorInvalidInputData);
            }

            // verify the required parameter 'index' is set
            if (request.Index == null)
            {
                throw new ApiException("Missing required parameter 'index' when calling DeleteTaskLink",
                    StatusCodes.ErrorInvalidInputData);
            }

            // create path and map variables
            var resourcePath = UnescapePath(this.configuration.GetApiRootUrl() + "/tasks/{name}/taskLinks/{index}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fileName", request.FileName);

            try
            {
                var response = this.apiInvoker.InvokeApi(
                    resourcePath,
                    "DELETE",
                    null,
                    null,
                    null);
                if (response != null)
                {
                    return (AsposeResponse) SerializationHelper.Deserialize(response, typeof(AsposeResponse));
                }

                return null;
            }
            catch (ApiException ex)
            {
                if (ex.HttpStatusCode == HttpStatusCode.NotFound)
                {
                    return null;
                }

                throw;
            }
        }

        /// <summary>
        /// Read project assignment with the specified Uid. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetAssignmentRequest" /></param> 
        /// <returns><see cref="AssignmentResponse"/></returns>            
        public AssignmentResponse GetAssignment(GetAssignmentRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException("Missing required parameter 'name' when calling GetAssignment",
                    StatusCodes.ErrorInvalidInputData);
            }

            // verify the required parameter 'assignmentUid' is set
            if (request.AssignmentUid == null)
            {
                throw new ApiException("Missing required parameter 'assignmentUid' when calling GetAssignment",
                    StatusCodes.ErrorInvalidInputData);
            }

            // create path and map variables
            var resourcePath =
                UnescapePath(this.configuration.GetApiRootUrl() + "/tasks/{name}/assignments/{assignmentUid}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "assignmentUid", request.AssignmentUid);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);

            try
            {
                var response = this.apiInvoker.InvokeApi(
                    resourcePath,
                    "GET",
                    null,
                    null,
                    null);
                if (response != null)
                {
                    return (AssignmentResponse) SerializationHelper.Deserialize(response, typeof(AssignmentResponse));
                }

                return null;
            }
            catch (ApiException ex)
            {
                if (ex.HttpStatusCode == HttpStatusCode.NotFound)
                {
                    return null;
                }

                throw;
            }
        }

        /// <summary>
        /// Get timescaled data for an assignment with the specified Uid. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetAssignmentTimephasedDataRequest" /></param> 
        /// <returns><see cref="TimephasedDataResponse"/></returns>            
        public TimephasedDataResponse GetAssignmentTimephasedData(GetAssignmentTimephasedDataRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException("Missing required parameter 'name' when calling GetAssignmentTimephasedData",
                    StatusCodes.ErrorInvalidInputData);
            }

            // verify the required parameter 'assignmentUid' is set
            if (request.AssignmentUid == null)
            {
                throw new ApiException(
                    "Missing required parameter 'assignmentUid' when calling GetAssignmentTimephasedData",
                    StatusCodes.ErrorInvalidInputData);
            }

            // create path and map variables
            var resourcePath = UnescapePath(this.configuration.GetApiRootUrl() +
                                            "/tasks/{name}/assignments/{assignmentUid}/timeScaleData");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "assignmentUid", request.AssignmentUid);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "type", request.Type);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "startDate", request.StartDate);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "endDate", request.EndDate);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);

            try
            {
                var response = this.apiInvoker.InvokeApi(
                    resourcePath,
                    "GET",
                    null,
                    null,
                    null);
                if (response != null)
                {
                    return (TimephasedDataResponse) SerializationHelper.Deserialize(response,
                        typeof(TimephasedDataResponse));
                }

                return null;
            }
            catch (ApiException ex)
            {
                if (ex.HttpStatusCode == HttpStatusCode.NotFound)
                {
                    return null;
                }

                throw;
            }
        }

        /// <summary>
        /// Get project&#39;s assignment items. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetAssignmentsRequest" /></param> 
        /// <returns><see cref="AssignmentItemsResponse"/></returns>            
        public AssignmentItemsResponse GetAssignments(GetAssignmentsRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException("Missing required parameter 'name' when calling GetAssignments",
                    StatusCodes.ErrorInvalidInputData);
            }

            // create path and map variables
            var resourcePath = UnescapePath(this.configuration.GetApiRootUrl() + "/tasks/{name}/assignments");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);

            try
            {
                var response = this.apiInvoker.InvokeApi(
                    resourcePath,
                    "GET",
                    null,
                    null,
                    null);
                if (response != null)
                {
                    return (AssignmentItemsResponse) SerializationHelper.Deserialize(response,
                        typeof(AssignmentItemsResponse));
                }

                return null;
            }
            catch (ApiException ex)
            {
                if (ex.HttpStatusCode == HttpStatusCode.NotFound)
                {
                    return null;
                }

                throw;
            }
        }

        /// <summary>
        /// Get a project&#39;s calendar with the specified Uid. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetCalendarRequest" /></param> 
        /// <returns><see cref="CalendarResponse"/></returns>            
        public CalendarResponse GetCalendar(GetCalendarRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException("Missing required parameter 'name' when calling GetCalendar",
                    StatusCodes.ErrorInvalidInputData);
            }

            // verify the required parameter 'calendarUid' is set
            if (request.CalendarUid == null)
            {
                throw new ApiException("Missing required parameter 'calendarUid' when calling GetCalendar",
                    StatusCodes.ErrorInvalidInputData);
            }

            // create path and map variables
            var resourcePath =
                UnescapePath(this.configuration.GetApiRootUrl() + "/tasks/{name}/calendars/{calendarUid}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "calendarUid", request.CalendarUid);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);

            try
            {
                var response = this.apiInvoker.InvokeApi(
                    resourcePath,
                    "GET",
                    null,
                    null,
                    null);
                if (response != null)
                {
                    return (CalendarResponse) SerializationHelper.Deserialize(response, typeof(CalendarResponse));
                }

                return null;
            }
            catch (ApiException ex)
            {
                if (ex.HttpStatusCode == HttpStatusCode.NotFound)
                {
                    return null;
                }

                throw;
            }
        }

        /// <summary>
        /// Get a list of calendar&#39;s exceptions. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetCalendarExceptionsRequest" /></param> 
        /// <returns><see cref="CalendarExceptionsResponse"/></returns>            
        public CalendarExceptionsResponse GetCalendarExceptions(GetCalendarExceptionsRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException("Missing required parameter 'name' when calling GetCalendarExceptions",
                    StatusCodes.ErrorInvalidInputData);
            }

            // verify the required parameter 'calendarUid' is set
            if (request.CalendarUid == null)
            {
                throw new ApiException("Missing required parameter 'calendarUid' when calling GetCalendarExceptions",
                    StatusCodes.ErrorInvalidInputData);
            }

            // create path and map variables
            var resourcePath = UnescapePath(this.configuration.GetApiRootUrl() +
                                            "/tasks/{name}/calendars/{calendarUid}/calendarExceptions");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "calendarUid", request.CalendarUid);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);

            try
            {
                var response = this.apiInvoker.InvokeApi(
                    resourcePath,
                    "GET",
                    null,
                    null,
                    null);
                if (response != null)
                {
                    return (CalendarExceptionsResponse) SerializationHelper.Deserialize(response,
                        typeof(CalendarExceptionsResponse));
                }

                return null;
            }
            catch (ApiException ex)
            {
                if (ex.HttpStatusCode == HttpStatusCode.NotFound)
                {
                    return null;
                }

                throw;
            }
        }

        /// <summary>
        /// Gets the collection of work weeks of the specified calendar. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetCalendarWorkWeeksRequest" /></param> 
        /// <returns><see cref="CalendarWorkWeeksResponse"/></returns>            
        public CalendarWorkWeeksResponse GetCalendarWorkWeeks(GetCalendarWorkWeeksRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException("Missing required parameter 'name' when calling GetCalendarWorkWeeks",
                    StatusCodes.ErrorInvalidInputData);
            }

            // verify the required parameter 'calendarUid' is set
            if (request.CalendarUid == null)
            {
                throw new ApiException("Missing required parameter 'calendarUid' when calling GetCalendarWorkWeeks",
                    StatusCodes.ErrorInvalidInputData);
            }

            // create path and map variables
            var resourcePath = UnescapePath(this.configuration.GetApiRootUrl() +
                                            "/tasks/{name}/calendars/{calendarUid}/workWeeks");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "calendarUid", request.CalendarUid);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);

            try
            {
                var response = this.apiInvoker.InvokeApi(
                    resourcePath,
                    "GET",
                    null,
                    null,
                    null);
                if (response != null)
                {
                    return (CalendarWorkWeeksResponse) SerializationHelper.Deserialize(response,
                        typeof(CalendarWorkWeeksResponse));
                }

                return null;
            }
            catch (ApiException ex)
            {
                if (ex.HttpStatusCode == HttpStatusCode.NotFound)
                {
                    return null;
                }

                throw;
            }
        }

        /// <summary>
        /// Read project calendar items. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetCalendarsRequest" /></param> 
        /// <returns><see cref="CalendarItemsResponse"/></returns>            
        public CalendarItemsResponse GetCalendars(GetCalendarsRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException("Missing required parameter 'name' when calling GetCalendars",
                    StatusCodes.ErrorInvalidInputData);
            }

            // create path and map variables
            var resourcePath = UnescapePath(this.configuration.GetApiRootUrl() + "/tasks/{name}/calendars");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);

            try
            {
                var response = this.apiInvoker.InvokeApi(
                    resourcePath,
                    "GET",
                    null,
                    null,
                    null);
                if (response != null)
                {
                    return (CalendarItemsResponse) SerializationHelper.Deserialize(response,
                        typeof(CalendarItemsResponse));
                }

                return null;
            }
            catch (ApiException ex)
            {
                if (ex.HttpStatusCode == HttpStatusCode.NotFound)
                {
                    return null;
                }

                throw;
            }
        }

        /// <summary>
        /// Returns the list of the tasks which must be completed on time for a project to finish on schedule. Each task of the project is represented as a task item here, which is light-weighted task representation of the project task.. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetCriticalPathRequest" /></param> 
        /// <returns><see cref="TaskItemsResponse"/></returns>            
        public TaskItemsResponse GetCriticalPath(GetCriticalPathRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException("Missing required parameter 'name' when calling GetCriticalPath",
                    StatusCodes.ErrorInvalidInputData);
            }

            // create path and map variables
            var resourcePath = UnescapePath(this.configuration.GetApiRootUrl() + "/tasks/{name}/criticalPath");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);

            try
            {
                var response = this.apiInvoker.InvokeApi(
                    resourcePath,
                    "GET",
                    null,
                    null,
                    null);
                if (response != null)
                {
                    return (TaskItemsResponse) SerializationHelper.Deserialize(response, typeof(TaskItemsResponse));
                }

                return null;
            }
            catch (ApiException ex)
            {
                if (ex.HttpStatusCode == HttpStatusCode.NotFound)
                {
                    return null;
                }

                throw;
            }
        }

        /// <summary>
        /// Get a collection of a project&#39;s document properties. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentPropertiesRequest" /></param> 
        /// <returns><see cref="DocumentPropertiesResponse"/></returns>            
        public DocumentPropertiesResponse GetDocumentProperties(GetDocumentPropertiesRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException("Missing required parameter 'name' when calling GetDocumentProperties",
                    StatusCodes.ErrorInvalidInputData);
            }

            // create path and map variables
            var resourcePath = UnescapePath(this.configuration.GetApiRootUrl() + "/tasks/{name}/documentproperties");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);

            try
            {
                var response = this.apiInvoker.InvokeApi(
                    resourcePath,
                    "GET",
                    null,
                    null,
                    null);
                if (response != null)
                {
                    return (DocumentPropertiesResponse) SerializationHelper.Deserialize(response,
                        typeof(DocumentPropertiesResponse));
                }

                return null;
            }
            catch (ApiException ex)
            {
                if (ex.HttpStatusCode == HttpStatusCode.NotFound)
                {
                    return null;
                }

                throw;
            }
        }

        /// <summary>
        /// Get a document property by name. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetDocumentPropertyRequest" /></param> 
        /// <returns><see cref="DocumentPropertyResponse"/></returns>            
        public DocumentPropertyResponse GetDocumentProperty(GetDocumentPropertyRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException("Missing required parameter 'name' when calling GetDocumentProperty",
                    StatusCodes.ErrorInvalidInputData);
            }

            // verify the required parameter 'propertyName' is set
            if (request.PropertyName == null)
            {
                throw new ApiException("Missing required parameter 'propertyName' when calling GetDocumentProperty",
                    StatusCodes.ErrorInvalidInputData);
            }

            // create path and map variables
            var resourcePath = UnescapePath(this.configuration.GetApiRootUrl() +
                                            "/tasks/{name}/documentproperties/{propertyName}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "propertyName", request.PropertyName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);

            try
            {
                var response = this.apiInvoker.InvokeApi(
                    resourcePath,
                    "GET",
                    null,
                    null,
                    null);
                if (response != null)
                {
                    return (DocumentPropertyResponse) SerializationHelper.Deserialize(response,
                        typeof(DocumentPropertyResponse));
                }

                return null;
            }
            catch (ApiException ex)
            {
                if (ex.HttpStatusCode == HttpStatusCode.NotFound)
                {
                    return null;
                }

                throw;
            }
        }

        /// <summary>
        /// Get a project extended attribute definition with the specified index. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetExtendedAttributeByIndexRequest" /></param> 
        /// <returns><see cref="ExtendedAttributeResponse"/></returns>            
        public ExtendedAttributeResponse GetExtendedAttributeByIndex(GetExtendedAttributeByIndexRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException("Missing required parameter 'name' when calling GetExtendedAttributeByIndex",
                    StatusCodes.ErrorInvalidInputData);
            }

            // verify the required parameter 'index' is set
            if (request.Index == null)
            {
                throw new ApiException("Missing required parameter 'index' when calling GetExtendedAttributeByIndex",
                    StatusCodes.ErrorInvalidInputData);
            }

            // create path and map variables
            var resourcePath =
                UnescapePath(this.configuration.GetApiRootUrl() + "/tasks/{name}/extendedAttributes/{index}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);

            try
            {
                var response = this.apiInvoker.InvokeApi(
                    resourcePath,
                    "GET",
                    null,
                    null,
                    null);
                if (response != null)
                {
                    return (ExtendedAttributeResponse) SerializationHelper.Deserialize(response,
                        typeof(ExtendedAttributeResponse));
                }

                return null;
            }
            catch (ApiException ex)
            {
                if (ex.HttpStatusCode == HttpStatusCode.NotFound)
                {
                    return null;
                }

                throw;
            }
        }

        /// <summary>
        /// Get a project&#39;s extended attributes. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetExtendedAttributesRequest" /></param> 
        /// <returns><see cref="ExtendedAttributeItemsResponse"/></returns>            
        public ExtendedAttributeItemsResponse GetExtendedAttributes(GetExtendedAttributesRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException("Missing required parameter 'name' when calling GetExtendedAttributes",
                    StatusCodes.ErrorInvalidInputData);
            }

            // create path and map variables
            var resourcePath = UnescapePath(this.configuration.GetApiRootUrl() + "/tasks/{name}/extendedAttributes");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);

            try
            {
                var response = this.apiInvoker.InvokeApi(
                    resourcePath,
                    "GET",
                    null,
                    null,
                    null);
                if (response != null)
                {
                    return (ExtendedAttributeItemsResponse) SerializationHelper.Deserialize(response,
                        typeof(ExtendedAttributeItemsResponse));
                }

                return null;
            }
            catch (ApiException ex)
            {
                if (ex.HttpStatusCode == HttpStatusCode.NotFound)
                {
                    return null;
                }

                throw;
            }
        }

        /// <summary>
        /// Get outline code by index. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetOutlineCodeByIndexRequest" /></param> 
        /// <returns><see cref="OutlineCodeResponse"/></returns>            
        public OutlineCodeResponse GetOutlineCodeByIndex(GetOutlineCodeByIndexRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException("Missing required parameter 'name' when calling GetOutlineCodeByIndex",
                    StatusCodes.ErrorInvalidInputData);
            }

            // verify the required parameter 'index' is set
            if (request.Index == null)
            {
                throw new ApiException("Missing required parameter 'index' when calling GetOutlineCodeByIndex",
                    StatusCodes.ErrorInvalidInputData);
            }

            // create path and map variables
            var resourcePath = UnescapePath(this.configuration.GetApiRootUrl() + "/tasks/{name}/outlineCodes/{index}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);

            try
            {
                var response = this.apiInvoker.InvokeApi(
                    resourcePath,
                    "GET",
                    null,
                    null,
                    null);
                if (response != null)
                {
                    return (OutlineCodeResponse) SerializationHelper.Deserialize(response, typeof(OutlineCodeResponse));
                }

                return null;
            }
            catch (ApiException ex)
            {
                if (ex.HttpStatusCode == HttpStatusCode.NotFound)
                {
                    return null;
                }

                throw;
            }
        }

        /// <summary>
        /// Get a project&#39;s outline codes. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetOutlineCodesRequest" /></param> 
        /// <returns><see cref="OutlineCodeItemsResponse"/></returns>            
        public OutlineCodeItemsResponse GetOutlineCodes(GetOutlineCodesRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException("Missing required parameter 'name' when calling GetOutlineCodes",
                    StatusCodes.ErrorInvalidInputData);
            }

            // create path and map variables
            var resourcePath = UnescapePath(this.configuration.GetApiRootUrl() + "/tasks/{name}/outlineCodes");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);

            try
            {
                var response = this.apiInvoker.InvokeApi(
                    resourcePath,
                    "GET",
                    null,
                    null,
                    null);
                if (response != null)
                {
                    return (OutlineCodeItemsResponse) SerializationHelper.Deserialize(response,
                        typeof(OutlineCodeItemsResponse));
                }

                return null;
            }
            catch (ApiException ex)
            {
                if (ex.HttpStatusCode == HttpStatusCode.NotFound)
                {
                    return null;
                }

                throw;
            }
        }

        /// <summary>
        /// Returns page count for the project to be rendered using given Timescale and PresentationFormat  or specified PageSize. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetPageCountRequest" /></param> 
        /// <returns><see cref="PageCountResponse"/></returns>            
        public PageCountResponse GetPageCount(GetPageCountRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException("Missing required parameter 'name' when calling GetPageCount",
                    StatusCodes.ErrorInvalidInputData);
            }

            // create path and map variables
            var resourcePath = UnescapePath(this.configuration.GetApiRootUrl() + "/tasks/{name}/pagecount");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "pageSize", request.PageSize);
            resourcePath =
                UrlHelper.AddQueryParameterToUrl(resourcePath, "presentationFormat", request.PresentationFormat);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "timescale", request.Timescale);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "startDate", request.StartDate);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "endDate", request.EndDate);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);

            try
            {
                var response = this.apiInvoker.InvokeApi(
                    resourcePath,
                    "GET",
                    null,
                    null,
                    null);
                if (response != null)
                {
                    return (PageCountResponse) SerializationHelper.Deserialize(response, typeof(PageCountResponse));
                }

                return null;
            }
            catch (ApiException ex)
            {
                if (ex.HttpStatusCode == HttpStatusCode.NotFound)
                {
                    return null;
                }

                throw;
            }
        }

        /// <summary>
        /// Get Uids of projects contained in the file. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetProjectIdsRequest" /></param> 
        /// <returns><see cref="ProjectIdsResponse"/></returns>            
        public ProjectIdsResponse GetProjectIds(GetProjectIdsRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException("Missing required parameter 'name' when calling GetProjectIds",
                    StatusCodes.ErrorInvalidInputData);
            }

            // create path and map variables
            var resourcePath = UnescapePath(this.configuration.GetApiRootUrl() + "/tasks/{name}/projectids");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);

            try
            {
                var response = this.apiInvoker.InvokeApi(
                    resourcePath,
                    "GET",
                    null,
                    null,
                    null);
                if (response != null)
                {
                    return (ProjectIdsResponse) SerializationHelper.Deserialize(response, typeof(ProjectIdsResponse));
                }

                return null;
            }
            catch (ApiException ex)
            {
                if (ex.HttpStatusCode == HttpStatusCode.NotFound)
                {
                    return null;
                }

                throw;
            }
        }

        /// <summary>
        /// Returns created report in PDF format. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetReportPdfRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream GetReportPdf(GetReportPdfRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException("Missing required parameter 'name' when calling GetReportPdf",
                    StatusCodes.ErrorInvalidInputData);
            }

            // verify the required parameter 'type' is set
            if (request.Type == null)
            {
                throw new ApiException("Missing required parameter 'type' when calling GetReportPdf",
                    StatusCodes.ErrorInvalidInputData);
            }

            // create path and map variables
            var resourcePath = UnescapePath(this.configuration.GetApiRootUrl() + "/tasks/{name}/report");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "type", request.Type);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);

            try
            {
                return this.apiInvoker.InvokeBinaryApi(
                    resourcePath,
                    "GET",
                    null,
                    null,
                    null);
            }
            catch (ApiException ex)
            {
                if (ex.HttpStatusCode == HttpStatusCode.NotFound)
                {
                    return null;
                }

                throw;
            }
        }

        /// <summary>
        /// Get project resource. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetResourceRequest" /></param> 
        /// <returns><see cref="ResourceResponse"/></returns>            
        public ResourceResponse GetResource(GetResourceRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException("Missing required parameter 'name' when calling GetResource",
                    StatusCodes.ErrorInvalidInputData);
            }

            // verify the required parameter 'resourceUid' is set
            if (request.ResourceUid == null)
            {
                throw new ApiException("Missing required parameter 'resourceUid' when calling GetResource",
                    StatusCodes.ErrorInvalidInputData);
            }

            // create path and map variables
            var resourcePath =
                UnescapePath(this.configuration.GetApiRootUrl() + "/tasks/{name}/resources/{resourceUid}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "resourceUid", request.ResourceUid);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);

            try
            {
                var response = this.apiInvoker.InvokeApi(
                    resourcePath,
                    "GET",
                    null,
                    null,
                    null);
                if (response != null)
                {
                    return (ResourceResponse) SerializationHelper.Deserialize(response, typeof(ResourceResponse));
                }

                return null;
            }
            catch (ApiException ex)
            {
                if (ex.HttpStatusCode == HttpStatusCode.NotFound)
                {
                    return null;
                }

                throw;
            }
        }

        /// <summary>
        /// Get resource&#39;s assignments. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetResourceAssignmentsRequest" /></param> 
        /// <returns><see cref="AssignmentsResponse"/></returns>            
        public AssignmentsResponse GetResourceAssignments(GetResourceAssignmentsRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException("Missing required parameter 'name' when calling GetResourceAssignments",
                    StatusCodes.ErrorInvalidInputData);
            }

            // verify the required parameter 'resourceUid' is set
            if (request.ResourceUid == null)
            {
                throw new ApiException("Missing required parameter 'resourceUid' when calling GetResourceAssignments",
                    StatusCodes.ErrorInvalidInputData);
            }

            // create path and map variables
            var resourcePath = UnescapePath(this.configuration.GetApiRootUrl() +
                                            "/tasks/{name}/resources/{resourceUid}/assignments");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "resourceUid", request.ResourceUid);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);

            try
            {
                var response = this.apiInvoker.InvokeApi(
                    resourcePath,
                    "GET",
                    null,
                    null,
                    null);
                if (response != null)
                {
                    return (AssignmentsResponse) SerializationHelper.Deserialize(response, typeof(AssignmentsResponse));
                }

                return null;
            }
            catch (ApiException ex)
            {
                if (ex.HttpStatusCode == HttpStatusCode.NotFound)
                {
                    return null;
                }

                throw;
            }
        }

        /// <summary>
        /// Get timescaled data for a resource with the specified Uid. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetResourceTimephasedDataRequest" /></param> 
        /// <returns><see cref="TimephasedDataResponse"/></returns>            
        public TimephasedDataResponse GetResourceTimephasedData(GetResourceTimephasedDataRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException("Missing required parameter 'name' when calling GetResourceTimephasedData",
                    StatusCodes.ErrorInvalidInputData);
            }

            // verify the required parameter 'resourceUid' is set
            if (request.ResourceUid == null)
            {
                throw new ApiException(
                    "Missing required parameter 'resourceUid' when calling GetResourceTimephasedData",
                    StatusCodes.ErrorInvalidInputData);
            }

            // create path and map variables
            var resourcePath = UnescapePath(this.configuration.GetApiRootUrl() +
                                            "/tasks/{name}/resources/{resourceUid}/timeScaleData");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "resourceUid", request.ResourceUid);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "type", request.Type);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "startDate", request.StartDate);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "endDate", request.EndDate);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);

            try
            {
                var response = this.apiInvoker.InvokeApi(
                    resourcePath,
                    "GET",
                    null,
                    null,
                    null);
                if (response != null)
                {
                    return (TimephasedDataResponse) SerializationHelper.Deserialize(response,
                        typeof(TimephasedDataResponse));
                }

                return null;
            }
            catch (ApiException ex)
            {
                if (ex.HttpStatusCode == HttpStatusCode.NotFound)
                {
                    return null;
                }

                throw;
            }
        }

        /// <summary>
        /// Get a project&#39;s resources. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetResourcesRequest" /></param> 
        /// <returns><see cref="ResourceItemsResponse"/></returns>            
        public ResourceItemsResponse GetResources(GetResourcesRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException("Missing required parameter 'name' when calling GetResources",
                    StatusCodes.ErrorInvalidInputData);
            }

            // create path and map variables
            var resourcePath = UnescapePath(this.configuration.GetApiRootUrl() + "/tasks/{name}/resources");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);

            try
            {
                var response = this.apiInvoker.InvokeApi(
                    resourcePath,
                    "GET",
                    null,
                    null,
                    null);
                if (response != null)
                {
                    return (ResourceItemsResponse) SerializationHelper.Deserialize(response,
                        typeof(ResourceItemsResponse));
                }

                return null;
            }
            catch (ApiException ex)
            {
                if (ex.HttpStatusCode == HttpStatusCode.NotFound)
                {
                    return null;
                }

                throw;
            }
        }

        /// <summary>
        /// Performs a risk analysys using Monte Carlo simulation and creates a risk analysis report. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetRiskAnalysisReportRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream GetRiskAnalysisReport(GetRiskAnalysisReportRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException("Missing required parameter 'name' when calling GetRiskAnalysisReport",
                    StatusCodes.ErrorInvalidInputData);
            }

            // verify the required parameter 'taskUid' is set
            if (request.TaskUid == null)
            {
                throw new ApiException("Missing required parameter 'taskUid' when calling GetRiskAnalysisReport",
                    StatusCodes.ErrorInvalidInputData);
            }

            // create path and map variables
            var resourcePath = UnescapePath(this.configuration.GetApiRootUrl() + "/tasks/{name}/riskAnalysisReport");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "taskUid", request.TaskUid);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "distributionType", request.DistributionType);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "optimistic", request.Optimistic);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "pessimistic", request.Pessimistic);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "confidenceLevel", request.ConfidenceLevel);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "iterations", request.Iterations);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fileName", request.FileName);

            try
            {
                return this.apiInvoker.InvokeBinaryApi(
                    resourcePath,
                    "GET",
                    null,
                    null,
                    null);
            }
            catch (ApiException ex)
            {
                if (ex.HttpStatusCode == HttpStatusCode.NotFound)
                {
                    return null;
                }

                throw;
            }
        }

        /// <summary>
        /// Read project task. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetTaskRequest" /></param> 
        /// <returns><see cref="TaskResponse"/></returns>            
        public TaskResponse GetTask(GetTaskRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException("Missing required parameter 'name' when calling GetTask",
                    StatusCodes.ErrorInvalidInputData);
            }

            // verify the required parameter 'taskUid' is set
            if (request.TaskUid == null)
            {
                throw new ApiException("Missing required parameter 'taskUid' when calling GetTask",
                    StatusCodes.ErrorInvalidInputData);
            }

            // create path and map variables
            var resourcePath = UnescapePath(this.configuration.GetApiRootUrl() + "/tasks/{name}/tasks/{taskUid}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "taskUid", request.TaskUid);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);

            try
            {
                var response = this.apiInvoker.InvokeApi(
                    resourcePath,
                    "GET",
                    null,
                    null,
                    null);
                if (response != null)
                {
                    return (TaskResponse) SerializationHelper.Deserialize(response, typeof(TaskResponse));
                }

                return null;
            }
            catch (ApiException ex)
            {
                if (ex.HttpStatusCode == HttpStatusCode.NotFound)
                {
                    return null;
                }

                throw;
            }
        }

        /// <summary>
        /// Get task assignments. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetTaskAssignmentsRequest" /></param> 
        /// <returns><see cref="AssignmentsResponse"/></returns>            
        public AssignmentsResponse GetTaskAssignments(GetTaskAssignmentsRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException("Missing required parameter 'name' when calling GetTaskAssignments",
                    StatusCodes.ErrorInvalidInputData);
            }

            // verify the required parameter 'taskUid' is set
            if (request.TaskUid == null)
            {
                throw new ApiException("Missing required parameter 'taskUid' when calling GetTaskAssignments",
                    StatusCodes.ErrorInvalidInputData);
            }

            // create path and map variables
            var resourcePath =
                UnescapePath(this.configuration.GetApiRootUrl() + "/tasks/{name}/tasks/{taskUid}/assignments");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "taskUid", request.TaskUid);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);

            try
            {
                var response = this.apiInvoker.InvokeApi(
                    resourcePath,
                    "GET",
                    null,
                    null,
                    null);
                if (response != null)
                {
                    return (AssignmentsResponse) SerializationHelper.Deserialize(response, typeof(AssignmentsResponse));
                }

                return null;
            }
            catch (ApiException ex)
            {
                if (ex.HttpStatusCode == HttpStatusCode.NotFound)
                {
                    return null;
                }

                throw;
            }
        }

        /// <summary>
        /// Get a project document. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetTaskDocumentRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream GetTaskDocument(GetTaskDocumentRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException("Missing required parameter 'name' when calling GetTaskDocument",
                    StatusCodes.ErrorInvalidInputData);
            }

            // create path and map variables
            var resourcePath = UnescapePath(this.configuration.GetApiRootUrl() + "/tasks/{name}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);

            try
            {
                return this.apiInvoker.InvokeBinaryApi(
                    resourcePath,
                    "GET",
                    null,
                    null,
                    null);
            }
            catch (ApiException ex)
            {
                if (ex.HttpStatusCode == HttpStatusCode.NotFound)
                {
                    return null;
                }

                throw;
            }
        }

        /// <summary>
        /// Get a project document in the specified format 
        /// </summary>
        /// <param name="request">Request. <see cref="GetTaskDocumentWithFormatRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream GetTaskDocumentWithFormat(GetTaskDocumentWithFormatRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException("Missing required parameter 'name' when calling GetTaskDocumentWithFormat",
                    StatusCodes.ErrorInvalidInputData);
            }

            // verify the required parameter 'format' is set
            if (request.Format == null)
            {
                throw new ApiException("Missing required parameter 'format' when calling GetTaskDocumentWithFormat",
                    StatusCodes.ErrorInvalidInputData);
            }

            // create path and map variables
            var resourcePath = UnescapePath(this.configuration.GetApiRootUrl() + "/tasks/{name}/format");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "format", request.Format);
            resourcePath =
                UrlHelper.AddQueryParameterToUrl(resourcePath, "returnAsZipArchive", request.ReturnAsZipArchive);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);

            try
            {
                return this.apiInvoker.InvokeBinaryApi(
                    resourcePath,
                    "GET",
                    null,
                    null,
                    null);
            }
            catch (ApiException ex)
            {
                if (ex.HttpStatusCode == HttpStatusCode.NotFound)
                {
                    return null;
                }

                throw;
            }
        }

        /// <summary>
        /// Get tasks&#39; links of a project. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetTaskLinksRequest" /></param> 
        /// <returns><see cref="TaskLinksResponse"/></returns>            
        public TaskLinksResponse GetTaskLinks(GetTaskLinksRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException("Missing required parameter 'name' when calling GetTaskLinks",
                    StatusCodes.ErrorInvalidInputData);
            }

            // create path and map variables
            var resourcePath = UnescapePath(this.configuration.GetApiRootUrl() + "/tasks/{name}/taskLinks");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);

            try
            {
                var response = this.apiInvoker.InvokeApi(
                    resourcePath,
                    "GET",
                    null,
                    null,
                    null);
                if (response != null)
                {
                    return (TaskLinksResponse) SerializationHelper.Deserialize(response, typeof(TaskLinksResponse));
                }

                return null;
            }
            catch (ApiException ex)
            {
                if (ex.HttpStatusCode == HttpStatusCode.NotFound)
                {
                    return null;
                }

                throw;
            }
        }

        /// <summary>
        /// Get recurring info for a task with the specified Uid 
        /// </summary>
        /// <param name="request">Request. <see cref="GetTaskRecurringInfoRequest" /></param> 
        /// <returns><see cref="RecurringInfoResponse"/></returns>            
        public RecurringInfoResponse GetTaskRecurringInfo(GetTaskRecurringInfoRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException("Missing required parameter 'name' when calling GetTaskRecurringInfo",
                    StatusCodes.ErrorInvalidInputData);
            }

            // verify the required parameter 'taskUid' is set
            if (request.TaskUid == null)
            {
                throw new ApiException("Missing required parameter 'taskUid' when calling GetTaskRecurringInfo",
                    StatusCodes.ErrorInvalidInputData);
            }

            // create path and map variables
            var resourcePath =
                UnescapePath(this.configuration.GetApiRootUrl() + "/tasks/{name}/tasks/{taskUid}/recurringInfo");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "taskUid", request.TaskUid);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);

            try
            {
                var response = this.apiInvoker.InvokeApi(
                    resourcePath,
                    "GET",
                    null,
                    null,
                    null);
                if (response != null)
                {
                    return (RecurringInfoResponse) SerializationHelper.Deserialize(response,
                        typeof(RecurringInfoResponse));
                }

                return null;
            }
            catch (ApiException ex)
            {
                if (ex.HttpStatusCode == HttpStatusCode.NotFound)
                {
                    return null;
                }

                throw;
            }
        }

        /// <summary>
        /// Get timescaled data for a task with the specified Uid. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetTaskTimephasedDataRequest" /></param> 
        /// <returns><see cref="TimephasedDataResponse"/></returns>            
        public TimephasedDataResponse GetTaskTimephasedData(GetTaskTimephasedDataRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException("Missing required parameter 'name' when calling GetTaskTimephasedData",
                    StatusCodes.ErrorInvalidInputData);
            }

            // verify the required parameter 'taskUid' is set
            if (request.TaskUid == null)
            {
                throw new ApiException("Missing required parameter 'taskUid' when calling GetTaskTimephasedData",
                    StatusCodes.ErrorInvalidInputData);
            }

            // create path and map variables
            var resourcePath =
                UnescapePath(this.configuration.GetApiRootUrl() + "/tasks/{name}/tasks/{taskUid}/timeScaleData");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "taskUid", request.TaskUid);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "type", request.Type);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "startDate", request.StartDate);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "endDate", request.EndDate);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);

            try
            {
                var response = this.apiInvoker.InvokeApi(
                    resourcePath,
                    "GET",
                    null,
                    null,
                    null);
                if (response != null)
                {
                    return (TimephasedDataResponse) SerializationHelper.Deserialize(response,
                        typeof(TimephasedDataResponse));
                }

                return null;
            }
            catch (ApiException ex)
            {
                if (ex.HttpStatusCode == HttpStatusCode.NotFound)
                {
                    return null;
                }

                throw;
            }
        }

        /// <summary>
        /// Get a project&#39;s tasks. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetTasksRequest" /></param> 
        /// <returns><see cref="TaskItemsResponse"/></returns>            
        public TaskItemsResponse GetTasks(GetTasksRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException("Missing required parameter 'name' when calling GetTasks",
                    StatusCodes.ErrorInvalidInputData);
            }

            // create path and map variables
            var resourcePath = UnescapePath(this.configuration.GetApiRootUrl() + "/tasks/{name}/tasks");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);

            try
            {
                var response = this.apiInvoker.InvokeApi(
                    resourcePath,
                    "GET",
                    null,
                    null,
                    null);
                if (response != null)
                {
                    return (TaskItemsResponse) SerializationHelper.Deserialize(response, typeof(TaskItemsResponse));
                }

                return null;
            }
            catch (ApiException ex)
            {
                if (ex.HttpStatusCode == HttpStatusCode.NotFound)
                {
                    return null;
                }

                throw;
            }
        }

        /// <summary>
        /// Returns VBA project. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetVbaProjectRequest" /></param> 
        /// <returns><see cref="VbaProjectResponse"/></returns>            
        public VbaProjectResponse GetVbaProject(GetVbaProjectRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException("Missing required parameter 'name' when calling GetVbaProject",
                    StatusCodes.ErrorInvalidInputData);
            }

            // create path and map variables
            var resourcePath = UnescapePath(this.configuration.GetApiRootUrl() + "/tasks/{name}/vbaproject");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);

            try
            {
                var response = this.apiInvoker.InvokeApi(
                    resourcePath,
                    "GET",
                    null,
                    null,
                    null);
                if (response != null)
                {
                    return (VbaProjectResponse) SerializationHelper.Deserialize(response, typeof(VbaProjectResponse));
                }

                return null;
            }
            catch (ApiException ex)
            {
                if (ex.HttpStatusCode == HttpStatusCode.NotFound)
                {
                    return null;
                }

                throw;
            }
        }

        /// <summary>
        /// Get a project&#39;s WBS Definition. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetWbsDefinitionRequest" /></param> 
        /// <returns><see cref="WBSDefinitionResponse"/></returns>            
        public WBSDefinitionResponse GetWbsDefinition(GetWbsDefinitionRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException("Missing required parameter 'name' when calling GetWbsDefinition",
                    StatusCodes.ErrorInvalidInputData);
            }

            // create path and map variables
            var resourcePath = UnescapePath(this.configuration.GetApiRootUrl() + "/tasks/{name}/wbsDefinition");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);

            try
            {
                var response = this.apiInvoker.InvokeApi(
                    resourcePath,
                    "GET",
                    null,
                    null,
                    null);
                if (response != null)
                {
                    return (WBSDefinitionResponse) SerializationHelper.Deserialize(response,
                        typeof(WBSDefinitionResponse));
                }

                return null;
            }
            catch (ApiException ex)
            {
                if (ex.HttpStatusCode == HttpStatusCode.NotFound)
                {
                    return null;
                }

                throw;
            }
        }

        /// <summary>
        /// Adds a new assignment to a project and returns assignment item in a response. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostAssignmentRequest" /></param> 
        /// <returns><see cref="AssignmentItemResponse"/></returns>            
        public AssignmentItemResponse PostAssignment(PostAssignmentRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException("Missing required parameter 'name' when calling PostAssignment",
                    StatusCodes.ErrorInvalidInputData);
            }

            // verify the required parameter 'taskUid' is set
            if (request.TaskUid == null)
            {
                throw new ApiException("Missing required parameter 'taskUid' when calling PostAssignment",
                    StatusCodes.ErrorInvalidInputData);
            }

            // verify the required parameter 'resourceUid' is set
            if (request.ResourceUid == null)
            {
                throw new ApiException("Missing required parameter 'resourceUid' when calling PostAssignment",
                    StatusCodes.ErrorInvalidInputData);
            }

            // create path and map variables
            var resourcePath = UnescapePath(this.configuration.GetApiRootUrl() + "/tasks/{name}/assignments");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "taskUid", request.TaskUid);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "resourceUid", request.ResourceUid);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "units", request.Units);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "cost", request.Cost);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fileName", request.FileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);

            try
            {
                var response = this.apiInvoker.InvokeApi(
                    resourcePath,
                    "POST",
                    null,
                    null,
                    null);
                if (response != null)
                {
                    return (AssignmentItemResponse) SerializationHelper.Deserialize(response,
                        typeof(AssignmentItemResponse));
                }

                return null;
            }
            catch (ApiException ex)
            {
                if (ex.HttpStatusCode == HttpStatusCode.NotFound)
                {
                    return null;
                }

                throw;
            }
        }

        /// <summary>
        /// Adds a new calendar to project file. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostCalendarRequest" /></param> 
        /// <returns><see cref="CalendarItemResponse"/></returns>            
        public CalendarItemResponse PostCalendar(PostCalendarRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException("Missing required parameter 'name' when calling PostCalendar",
                    StatusCodes.ErrorInvalidInputData);
            }

            // verify the required parameter 'calendar' is set
            if (request.Calendar == null)
            {
                throw new ApiException("Missing required parameter 'calendar' when calling PostCalendar",
                    StatusCodes.ErrorInvalidInputData);
            }

            // create path and map variables
            var resourcePath = UnescapePath(this.configuration.GetApiRootUrl() + "/tasks/{name}/calendars");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fileName", request.FileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            var postBody = SerializationHelper.Serialize(request.Calendar); // http body (model) parameter
            try
            {
                var response = this.apiInvoker.InvokeApi(
                    resourcePath,
                    "POST",
                    postBody,
                    null,
                    null);
                if (response != null)
                {
                    return (CalendarItemResponse) SerializationHelper.Deserialize(response,
                        typeof(CalendarItemResponse));
                }

                return null;
            }
            catch (ApiException ex)
            {
                if (ex.HttpStatusCode == HttpStatusCode.NotFound)
                {
                    return null;
                }

                throw;
            }
        }

        /// <summary>
        /// Adds a new calendar exception to a calendar. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostCalendarExceptionRequest" /></param> 
        /// <returns><see cref="AsposeResponse"/></returns>            
        public AsposeResponse PostCalendarException(PostCalendarExceptionRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException("Missing required parameter 'name' when calling PostCalendarException",
                    StatusCodes.ErrorInvalidInputData);
            }

            // verify the required parameter 'calendarUid' is set
            if (request.CalendarUid == null)
            {
                throw new ApiException("Missing required parameter 'calendarUid' when calling PostCalendarException",
                    StatusCodes.ErrorInvalidInputData);
            }

            // verify the required parameter 'calendarException' is set
            if (request.CalendarException == null)
            {
                throw new ApiException(
                    "Missing required parameter 'calendarException' when calling PostCalendarException",
                    StatusCodes.ErrorInvalidInputData);
            }

            // create path and map variables
            var resourcePath = UnescapePath(this.configuration.GetApiRootUrl() +
                                            "/tasks/{name}/calendars/{calendarUid}/calendarExceptions");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "calendarUid", request.CalendarUid);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fileName", request.FileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            var postBody = SerializationHelper.Serialize(request.CalendarException); // http body (model) parameter
            try
            {
                var response = this.apiInvoker.InvokeApi(
                    resourcePath,
                    "POST",
                    postBody,
                    null,
                    null);
                if (response != null)
                {
                    return (AsposeResponse) SerializationHelper.Deserialize(response, typeof(AsposeResponse));
                }

                return null;
            }
            catch (ApiException ex)
            {
                if (ex.HttpStatusCode == HttpStatusCode.NotFound)
                {
                    return null;
                }

                throw;
            }
        }

        /// <summary>
        /// Set/create document property. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostDocumentPropertyRequest" /></param> 
        /// <returns><see cref="DocumentPropertyResponse"/></returns>            
        public DocumentPropertyResponse PostDocumentProperty(PostDocumentPropertyRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException("Missing required parameter 'name' when calling PostDocumentProperty",
                    StatusCodes.ErrorInvalidInputData);
            }

            // verify the required parameter 'propertyName' is set
            if (request.PropertyName == null)
            {
                throw new ApiException("Missing required parameter 'propertyName' when calling PostDocumentProperty",
                    StatusCodes.ErrorInvalidInputData);
            }

            // verify the required parameter 'property' is set
            if (request.Property == null)
            {
                throw new ApiException("Missing required parameter 'property' when calling PostDocumentProperty",
                    StatusCodes.ErrorInvalidInputData);
            }

            // create path and map variables
            var resourcePath = UnescapePath(this.configuration.GetApiRootUrl() +
                                            "/tasks/{name}/documentproperties/{propertyName}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "propertyName", request.PropertyName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "filename", request.Filename);
            var postBody = SerializationHelper.Serialize(request.Property); // http body (model) parameter
            try
            {
                var response = this.apiInvoker.InvokeApi(
                    resourcePath,
                    "POST",
                    postBody,
                    null,
                    null);
                if (response != null)
                {
                    return (DocumentPropertyResponse) SerializationHelper.Deserialize(response,
                        typeof(DocumentPropertyResponse));
                }

                return null;
            }
            catch (ApiException ex)
            {
                if (ex.HttpStatusCode == HttpStatusCode.NotFound)
                {
                    return null;
                }

                throw;
            }
        }

        /// <summary>
        /// Add a new resource to a project. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostResourceRequest" /></param> 
        /// <returns><see cref="ResourceItemResponse"/></returns>            
        public ResourceItemResponse PostResource(PostResourceRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException("Missing required parameter 'name' when calling PostResource",
                    StatusCodes.ErrorInvalidInputData);
            }

            // create path and map variables
            var resourcePath = UnescapePath(this.configuration.GetApiRootUrl() + "/tasks/{name}/resources");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "resourceName", request.ResourceName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "beforeResourceId", request.BeforeResourceId);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fileName", request.FileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);

            try
            {
                var response = this.apiInvoker.InvokeApi(
                    resourcePath,
                    "POST",
                    null,
                    null,
                    null);
                if (response != null)
                {
                    return (ResourceItemResponse) SerializationHelper.Deserialize(response,
                        typeof(ResourceItemResponse));
                }

                return null;
            }
            catch (ApiException ex)
            {
                if (ex.HttpStatusCode == HttpStatusCode.NotFound)
                {
                    return null;
                }

                throw;
            }
        }

        /// <summary>
        /// Add a new task to a project. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostTaskRequest" /></param> 
        /// <returns><see cref="TaskItemResponse"/></returns>            
        public TaskItemResponse PostTask(PostTaskRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException("Missing required parameter 'name' when calling PostTask",
                    StatusCodes.ErrorInvalidInputData);
            }

            // create path and map variables
            var resourcePath = UnescapePath(this.configuration.GetApiRootUrl() + "/tasks/{name}/tasks");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "taskName", request.TaskName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "beforeTaskId", request.BeforeTaskId);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fileName", request.FileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);

            try
            {
                var response = this.apiInvoker.InvokeApi(
                    resourcePath,
                    "POST",
                    null,
                    null,
                    null);
                if (response != null)
                {
                    return (TaskItemResponse) SerializationHelper.Deserialize(response, typeof(TaskItemResponse));
                }

                return null;
            }
            catch (ApiException ex)
            {
                if (ex.HttpStatusCode == HttpStatusCode.NotFound)
                {
                    return null;
                }

                throw;
            }
        }

        /// <summary>
        /// Get a project document in the specified format and with the specified save options. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostTaskDocumentWithFormatRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PostTaskDocumentWithFormat(PostTaskDocumentWithFormatRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException("Missing required parameter 'name' when calling PostTaskDocumentWithFormat",
                    StatusCodes.ErrorInvalidInputData);
            }

            // verify the required parameter 'format' is set
            if (request.Format == null)
            {
                throw new ApiException("Missing required parameter 'format' when calling PostTaskDocumentWithFormat",
                    StatusCodes.ErrorInvalidInputData);
            }

            // verify the required parameter 'saveOptions' is set
            if (request.SaveOptions == null)
            {
                throw new ApiException(
                    "Missing required parameter 'saveOptions' when calling PostTaskDocumentWithFormat",
                    StatusCodes.ErrorInvalidInputData);
            }

            // create path and map variables
            var resourcePath = UnescapePath(this.configuration.GetApiRootUrl() + "/tasks/{name}/format");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "format", request.Format);
            resourcePath =
                UrlHelper.AddQueryParameterToUrl(resourcePath, "returnAsZipArchive", request.ReturnAsZipArchive);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            var postBody = SerializationHelper.Serialize(request.SaveOptions); // http body (model) parameter
            try
            {
                return this.apiInvoker.InvokeBinaryApi(
                    resourcePath,
                    "POST",
                    postBody,
                    null,
                    null);
            }
            catch (ApiException ex)
            {
                if (ex.HttpStatusCode == HttpStatusCode.NotFound)
                {
                    return null;
                }

                throw;
            }
        }

        /// <summary>
        /// Adds a new task link to a project. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostTaskLinkRequest" /></param> 
        /// <returns><see cref="AsposeResponse"/></returns>            
        public AsposeResponse PostTaskLink(PostTaskLinkRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException("Missing required parameter 'name' when calling PostTaskLink",
                    StatusCodes.ErrorInvalidInputData);
            }

            // verify the required parameter 'taskLink' is set
            if (request.TaskLink == null)
            {
                throw new ApiException("Missing required parameter 'taskLink' when calling PostTaskLink",
                    StatusCodes.ErrorInvalidInputData);
            }

            // create path and map variables
            var resourcePath = UnescapePath(this.configuration.GetApiRootUrl() + "/tasks/{name}/taskLinks");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fileName", request.FileName);
            var postBody = SerializationHelper.Serialize(request.TaskLink); // http body (model) parameter
            try
            {
                var response = this.apiInvoker.InvokeApi(
                    resourcePath,
                    "POST",
                    postBody,
                    null,
                    null);
                if (response != null)
                {
                    return (AsposeResponse) SerializationHelper.Deserialize(response, typeof(AsposeResponse));
                }

                return null;
            }
            catch (ApiException ex)
            {
                if (ex.HttpStatusCode == HttpStatusCode.NotFound)
                {
                    return null;
                }

                throw;
            }
        }

        /// <summary>
        /// Adds a new recurring task. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostTaskRecurringInfoRequest" /></param> 
        /// <returns><see cref="TaskItemResponse"/></returns>            
        public TaskItemResponse PostTaskRecurringInfo(PostTaskRecurringInfoRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException("Missing required parameter 'name' when calling PostTaskRecurringInfo",
                    StatusCodes.ErrorInvalidInputData);
            }

            // verify the required parameter 'parentTaskUid' is set
            if (request.ParentTaskUid == null)
            {
                throw new ApiException("Missing required parameter 'parentTaskUid' when calling PostTaskRecurringInfo",
                    StatusCodes.ErrorInvalidInputData);
            }

            // verify the required parameter 'taskName' is set
            if (request.TaskName == null)
            {
                throw new ApiException("Missing required parameter 'taskName' when calling PostTaskRecurringInfo",
                    StatusCodes.ErrorInvalidInputData);
            }

            // verify the required parameter 'recurringInfo' is set
            if (request.RecurringInfo == null)
            {
                throw new ApiException("Missing required parameter 'recurringInfo' when calling PostTaskRecurringInfo",
                    StatusCodes.ErrorInvalidInputData);
            }

            // verify the required parameter 'calendarName' is set
            if (request.CalendarName == null)
            {
                throw new ApiException("Missing required parameter 'calendarName' when calling PostTaskRecurringInfo",
                    StatusCodes.ErrorInvalidInputData);
            }

            // create path and map variables
            var resourcePath = UnescapePath(this.configuration.GetApiRootUrl() + "/tasks/{name}/tasks/recurringInfo");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "parentTaskUid", request.ParentTaskUid);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "taskName", request.TaskName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "calendarName", request.CalendarName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fileName", request.FileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            var postBody = SerializationHelper.Serialize(request.RecurringInfo); // http body (model) parameter
            try
            {
                var response = this.apiInvoker.InvokeApi(
                    resourcePath,
                    "POST",
                    postBody,
                    null,
                    null);
                if (response != null)
                {
                    return (TaskItemResponse) SerializationHelper.Deserialize(response, typeof(TaskItemResponse));
                }

                return null;
            }
            catch (ApiException ex)
            {
                if (ex.HttpStatusCode == HttpStatusCode.NotFound)
                {
                    return null;
                }

                throw;
            }
        }

        /// <summary>
        /// Updates resources assignment with the specified Uid. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutAssignmentRequest" /></param> 
        /// <returns><see cref="AssignmentResponse"/></returns>            
        public AssignmentResponse PutAssignment(PutAssignmentRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException("Missing required parameter 'name' when calling PutAssignment",
                    StatusCodes.ErrorInvalidInputData);
            }

            // verify the required parameter 'assignmentUid' is set
            if (request.AssignmentUid == null)
            {
                throw new ApiException("Missing required parameter 'assignmentUid' when calling PutAssignment",
                    StatusCodes.ErrorInvalidInputData);
            }

            // verify the required parameter 'assignment' is set
            if (request.Assignment == null)
            {
                throw new ApiException("Missing required parameter 'assignment' when calling PutAssignment",
                    StatusCodes.ErrorInvalidInputData);
            }

            // create path and map variables
            var resourcePath =
                UnescapePath(this.configuration.GetApiRootUrl() + "/tasks/{name}/assignments/{assignmentUid}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "assignmentUid", request.AssignmentUid);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "mode", request.Mode);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "recalculate", request.Recalculate);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fileName", request.FileName);
            var postBody = SerializationHelper.Serialize(request.Assignment); // http body (model) parameter
            try
            {
                var response = this.apiInvoker.InvokeApi(
                    resourcePath,
                    "PUT",
                    postBody,
                    null,
                    null);
                if (response != null)
                {
                    return (AssignmentResponse) SerializationHelper.Deserialize(response, typeof(AssignmentResponse));
                }

                return null;
            }
            catch (ApiException ex)
            {
                if (ex.HttpStatusCode == HttpStatusCode.NotFound)
                {
                    return null;
                }

                throw;
            }
        }

        /// <summary>
        /// Edits an existing project calendar. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutCalendarRequest" /></param> 
        /// <returns><see cref="AsposeResponse"/></returns>            
        public AsposeResponse PutCalendar(PutCalendarRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException("Missing required parameter 'name' when calling PutCalendar",
                    StatusCodes.ErrorInvalidInputData);
            }

            // verify the required parameter 'calendarUid' is set
            if (request.CalendarUid == null)
            {
                throw new ApiException("Missing required parameter 'calendarUid' when calling PutCalendar",
                    StatusCodes.ErrorInvalidInputData);
            }

            // verify the required parameter 'calendar' is set
            if (request.Calendar == null)
            {
                throw new ApiException("Missing required parameter 'calendar' when calling PutCalendar",
                    StatusCodes.ErrorInvalidInputData);
            }

            // create path and map variables
            var resourcePath = UnescapePath(this.configuration.GetApiRootUrl() + "/tasks/{name}/calendars");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "calendarUid", request.CalendarUid);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fileName", request.FileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            var postBody = SerializationHelper.Serialize(request.Calendar); // http body (model) parameter
            try
            {
                var response = this.apiInvoker.InvokeApi(
                    resourcePath,
                    "PUT",
                    postBody,
                    null,
                    null);
                if (response != null)
                {
                    return (AsposeResponse) SerializationHelper.Deserialize(response, typeof(AsposeResponse));
                }

                return null;
            }
            catch (ApiException ex)
            {
                if (ex.HttpStatusCode == HttpStatusCode.NotFound)
                {
                    return null;
                }

                throw;
            }
        }

        /// <summary>
        /// Updates calendar exception. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutCalendarExceptionRequest" /></param> 
        /// <returns><see cref="AsposeResponse"/></returns>            
        public AsposeResponse PutCalendarException(PutCalendarExceptionRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException("Missing required parameter 'name' when calling PutCalendarException",
                    StatusCodes.ErrorInvalidInputData);
            }

            // verify the required parameter 'calendarUid' is set
            if (request.CalendarUid == null)
            {
                throw new ApiException("Missing required parameter 'calendarUid' when calling PutCalendarException",
                    StatusCodes.ErrorInvalidInputData);
            }

            // verify the required parameter 'index' is set
            if (request.Index == null)
            {
                throw new ApiException("Missing required parameter 'index' when calling PutCalendarException",
                    StatusCodes.ErrorInvalidInputData);
            }

            // verify the required parameter 'calendarException' is set
            if (request.CalendarException == null)
            {
                throw new ApiException(
                    "Missing required parameter 'calendarException' when calling PutCalendarException",
                    StatusCodes.ErrorInvalidInputData);
            }

            // create path and map variables
            var resourcePath = UnescapePath(this.configuration.GetApiRootUrl() +
                                            "/tasks/{name}/calendars/{calendarUid}/calendarExceptions/{index}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "calendarUid", request.CalendarUid);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fileName", request.FileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            var postBody = SerializationHelper.Serialize(request.CalendarException); // http body (model) parameter
            try
            {
                var response = this.apiInvoker.InvokeApi(
                    resourcePath,
                    "PUT",
                    postBody,
                    null,
                    null);
                if (response != null)
                {
                    return (AsposeResponse) SerializationHelper.Deserialize(response, typeof(AsposeResponse));
                }

                return null;
            }
            catch (ApiException ex)
            {
                if (ex.HttpStatusCode == HttpStatusCode.NotFound)
                {
                    return null;
                }

                throw;
            }
        }

        /// <summary>
        /// Set/create document property. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutDocumentPropertyRequest" /></param> 
        /// <returns><see cref="DocumentPropertyResponse"/></returns>            
        public DocumentPropertyResponse PutDocumentProperty(PutDocumentPropertyRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException("Missing required parameter 'name' when calling PutDocumentProperty",
                    StatusCodes.ErrorInvalidInputData);
            }

            // verify the required parameter 'propertyName' is set
            if (request.PropertyName == null)
            {
                throw new ApiException("Missing required parameter 'propertyName' when calling PutDocumentProperty",
                    StatusCodes.ErrorInvalidInputData);
            }

            // verify the required parameter 'property' is set
            if (request.Property == null)
            {
                throw new ApiException("Missing required parameter 'property' when calling PutDocumentProperty",
                    StatusCodes.ErrorInvalidInputData);
            }

            // create path and map variables
            var resourcePath = UnescapePath(this.configuration.GetApiRootUrl() +
                                            "/tasks/{name}/documentproperties/{propertyName}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "propertyName", request.PropertyName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "filename", request.Filename);
            var postBody = SerializationHelper.Serialize(request.Property); // http body (model) parameter
            try
            {
                var response = this.apiInvoker.InvokeApi(
                    resourcePath,
                    "PUT",
                    postBody,
                    null,
                    null);
                if (response != null)
                {
                    return (DocumentPropertyResponse) SerializationHelper.Deserialize(response,
                        typeof(DocumentPropertyResponse));
                }

                return null;
            }
            catch (ApiException ex)
            {
                if (ex.HttpStatusCode == HttpStatusCode.NotFound)
                {
                    return null;
                }

                throw;
            }
        }

        /// <summary>
        /// Add a new extended attribute definition to a project or  updates existing attribute definition (with the same FieldId). 
        /// </summary>
        /// <param name="request">Request. <see cref="PutExtendedAttributeRequest" /></param> 
        /// <returns><see cref="ExtendedAttributeItemResponse"/></returns>            
        public ExtendedAttributeItemResponse PutExtendedAttribute(PutExtendedAttributeRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException("Missing required parameter 'name' when calling PutExtendedAttribute",
                    StatusCodes.ErrorInvalidInputData);
            }

            // verify the required parameter 'extendedAttribute' is set
            if (request.ExtendedAttribute == null)
            {
                throw new ApiException(
                    "Missing required parameter 'extendedAttribute' when calling PutExtendedAttribute",
                    StatusCodes.ErrorInvalidInputData);
            }

            // create path and map variables
            var resourcePath = UnescapePath(this.configuration.GetApiRootUrl() + "/tasks/{name}/extendedAttributes");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fileName", request.FileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            var postBody = SerializationHelper.Serialize(request.ExtendedAttribute); // http body (model) parameter
            try
            {
                var response = this.apiInvoker.InvokeApi(
                    resourcePath,
                    "PUT",
                    postBody,
                    null,
                    null);
                if (response != null)
                {
                    return (ExtendedAttributeItemResponse) SerializationHelper.Deserialize(response,
                        typeof(ExtendedAttributeItemResponse));
                }

                return null;
            }
            catch (ApiException ex)
            {
                if (ex.HttpStatusCode == HttpStatusCode.NotFound)
                {
                    return null;
                }

                throw;
            }
        }

        /// <summary>
        /// Imports project from database with the specified connection string and saves it to specified file with the specified format. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutImportProjectFromDbRequest" /></param> 
        /// <returns><see cref="AsposeResponse"/></returns>            
        public AsposeResponse PutImportProjectFromDb(PutImportProjectFromDbRequest request)
        {
            // verify the required parameter 'databaseType' is set
            if (request.DatabaseType == null)
            {
                throw new ApiException("Missing required parameter 'databaseType' when calling PutImportProjectFromDb",
                    StatusCodes.ErrorInvalidInputData);
            }

            // verify the required parameter 'connectionString' is set
            if (request.ConnectionString == null)
            {
                throw new ApiException(
                    "Missing required parameter 'connectionString' when calling PutImportProjectFromDb",
                    StatusCodes.ErrorInvalidInputData);
            }

            // verify the required parameter 'projectUid' is set
            if (request.ProjectUid == null)
            {
                throw new ApiException("Missing required parameter 'projectUid' when calling PutImportProjectFromDb",
                    StatusCodes.ErrorInvalidInputData);
            }

            // verify the required parameter 'filename' is set
            if (request.Filename == null)
            {
                throw new ApiException("Missing required parameter 'filename' when calling PutImportProjectFromDb",
                    StatusCodes.ErrorInvalidInputData);
            }

            // create path and map variables
            var resourcePath = UnescapePath(this.configuration.GetApiRootUrl() + "/tasks/importfromdb");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "databaseType", request.DatabaseType);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "projectUid", request.ProjectUid);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "filename", request.Filename);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "format", request.Format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "databaseSchema", request.DatabaseSchema);
            var postBody = SerializationHelper.Serialize(request.ConnectionString); // http body (model) parameter
            try
            {
                var response = this.apiInvoker.InvokeApi(
                    resourcePath,
                    "PUT",
                    postBody,
                    null,
                    null);
                if (response != null)
                {
                    return (AsposeResponse) SerializationHelper.Deserialize(response, typeof(AsposeResponse));
                }

                return null;
            }
            catch (ApiException ex)
            {
                if (ex.HttpStatusCode == HttpStatusCode.NotFound)
                {
                    return null;
                }

                throw;
            }
        }

        /// <summary>
        /// Imports project from primavera db formats (Primavera SQLite .db or Primavera xml) and saves it to specified file with the specified format. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutImportProjectFromFileRequest" /></param> 
        /// <returns><see cref="AsposeResponse"/></returns>            
        public AsposeResponse PutImportProjectFromFile(PutImportProjectFromFileRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException("Missing required parameter 'name' when calling PutImportProjectFromFile",
                    StatusCodes.ErrorInvalidInputData);
            }

            // verify the required parameter 'projectUid' is set
            if (request.ProjectUid == null)
            {
                throw new ApiException("Missing required parameter 'projectUid' when calling PutImportProjectFromFile",
                    StatusCodes.ErrorInvalidInputData);
            }

            // verify the required parameter 'filename' is set
            if (request.Filename == null)
            {
                throw new ApiException("Missing required parameter 'filename' when calling PutImportProjectFromFile",
                    StatusCodes.ErrorInvalidInputData);
            }

            // create path and map variables
            var resourcePath = UnescapePath(this.configuration.GetApiRootUrl() + "/tasks/{name}/import");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "projectUid", request.ProjectUid);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "filename", request.Filename);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fileType", request.FileType);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outputFileFormat", request.OutputFileFormat);

            try
            {
                var response = this.apiInvoker.InvokeApi(
                    resourcePath,
                    "PUT",
                    null,
                    null,
                    null);
                if (response != null)
                {
                    return (AsposeResponse) SerializationHelper.Deserialize(response, typeof(AsposeResponse));
                }

                return null;
            }
            catch (ApiException ex)
            {
                if (ex.HttpStatusCode == HttpStatusCode.NotFound)
                {
                    return null;
                }

                throw;
            }
        }

        /// <summary>
        /// Imports project from Project Online and saves it to specified file. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutImportProjectFromFileRequest" /></param> 
        /// <returns><see cref="AsposeResponse"/></returns>            
        public AsposeResponse PutImportProjectFromProjectOnline(PutImportProjectFromProjectOnlineRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(
                    "Missing required parameter 'name' when calling PutImportProjectFromProjectOnline",
                    StatusCodes.ErrorInvalidInputData);
            }

            // verify the required parameter 'siteUrl' is set
            if (request.SiteUrl == null)
            {
                throw new ApiException(
                    "Missing required parameter 'siteUrl' when calling PutImportProjectFromProjectOnline",
                    StatusCodes.ErrorInvalidInputData);
            }

            // verify the required parameter 'guid' is set
            if (request.Guid == null)
            {
                throw new ApiException(
                    "Missing required parameter 'guid' when calling PutImportProjectFromProjectOnline",
                    StatusCodes.ErrorInvalidInputData);
            }

            // create path and map variables
            var resourcePath =
                UnescapePath(this.configuration.GetApiRootUrl() + "/tasks/{name}/importfromprojectonline");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "siteUrl", request.SiteUrl);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "format", request.Format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "userName", request.UserName);

            var body = SerializationHelper.Serialize(request.Guid);
            var header = new Dictionary<string, string>();
            if (request.Token != null)
            {
                header.Add("x-project-online-token", request.Token);
            }

            if (request.XSharepointPassword != null)
            {
                header.Add("x-sharepoint-password", request.XSharepointPassword);
            }

            try
            {
                var response = this.apiInvoker.InvokeApi(
                    resourcePath,
                    "PUT",
                    body,
                    header,
                    null);
                if (response != null)
                {
                    return (AsposeResponse) SerializationHelper.Deserialize(response, typeof(AsposeResponse));
                }

                return null;
            }
            catch (ApiException ex)
            {
                if (ex.HttpStatusCode == HttpStatusCode.NotFound)
                {
                    return null;
                }

                throw;
            }
        }

        /// <summary>
        /// Move one task to another parent task 
        /// </summary>
        /// <param name="request">Request. <see cref="PutMoveTaskRequest" /></param> 
        /// <returns><see cref="AsposeResponse"/></returns>            
        public AsposeResponse PutMoveTask(PutMoveTaskRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException("Missing required parameter 'name' when calling PutMoveTask",
                    StatusCodes.ErrorInvalidInputData);
            }

            // verify the required parameter 'taskUid' is set
            if (request.TaskUid == null)
            {
                throw new ApiException("Missing required parameter 'taskUid' when calling PutMoveTask",
                    StatusCodes.ErrorInvalidInputData);
            }

            // verify the required parameter 'parentTaskUid' is set
            if (request.ParentTaskUid == null)
            {
                throw new ApiException("Missing required parameter 'parentTaskUid' when calling PutMoveTask",
                    StatusCodes.ErrorInvalidInputData);
            }

            // create path and map variables
            var resourcePath = UnescapePath(this.configuration.GetApiRootUrl() + "/tasks/{name}/tasks/{taskUid}/move");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "taskUid", request.TaskUid);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "parentTaskUid", request.ParentTaskUid);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fileName", request.FileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);

            try
            {
                var response = this.apiInvoker.InvokeApi(
                    resourcePath,
                    "PUT",
                    null,
                    null,
                    null);
                if (response != null)
                {
                    return (AsposeResponse) SerializationHelper.Deserialize(response, typeof(AsposeResponse));
                }

                return null;
            }
            catch (ApiException ex)
            {
                if (ex.HttpStatusCode == HttpStatusCode.NotFound)
                {
                    return null;
                }

                throw;
            }
        }

        /// <summary>
        /// Move a task to another position under the same parent and the same outline level 
        /// </summary>
        /// <param name="request">Request. <see cref="PutMoveTaskToSiblingRequest" /></param> 
        /// <returns><see cref="AsposeResponse"/></returns>            
        public AsposeResponse PutMoveTaskToSibling(PutMoveTaskToSiblingRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException("Missing required parameter 'name' when calling PutMoveTaskToSibling",
                    StatusCodes.ErrorInvalidInputData);
            }

            // verify the required parameter 'taskUid' is set
            if (request.TaskUid == null)
            {
                throw new ApiException("Missing required parameter 'taskUid' when calling PutMoveTaskToSibling",
                    StatusCodes.ErrorInvalidInputData);
            }

            // verify the required parameter 'beforeTaskUid' is set
            if (request.BeforeTaskUid == null)
            {
                throw new ApiException("Missing required parameter 'beforeTaskUid' when calling PutMoveTaskToSibling",
                    StatusCodes.ErrorInvalidInputData);
            }

            // create path and map variables
            var resourcePath =
                UnescapePath(this.configuration.GetApiRootUrl() + "/tasks/{name}/tasks/{taskUid}/moveToSibling");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "taskUid", request.TaskUid);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "beforeTaskUid", request.BeforeTaskUid);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fileName", request.FileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);

            try
            {
                var response = this.apiInvoker.InvokeApi(
                    resourcePath,
                    "PUT",
                    null,
                    null,
                    null);
                if (response != null)
                {
                    return (AsposeResponse) SerializationHelper.Deserialize(response, typeof(AsposeResponse));
                }

                return null;
            }
            catch (ApiException ex)
            {
                if (ex.HttpStatusCode == HttpStatusCode.NotFound)
                {
                    return null;
                }

                throw;
            }
        }

        /// <summary>
        /// Reschedules all project tasks ids, outline levels, start/finish dates, sets early/late dates, calculates slacks, work and cost fields. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutRecalculateProjectRequest" /></param> 
        /// <returns><see cref="ProjectRecalculateResponse"/></returns>            
        public ProjectRecalculateResponse PutRecalculateProject(PutRecalculateProjectRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException("Missing required parameter 'name' when calling PutRecalculateProject",
                    StatusCodes.ErrorInvalidInputData);
            }

            // create path and map variables
            var resourcePath = UnescapePath(this.configuration.GetApiRootUrl() + "/tasks/{name}/recalculate/project");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "mode", request.Mode);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "validate", request.Validate);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fileName", request.FileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);

            try
            {
                var response = this.apiInvoker.InvokeApi(
                    resourcePath,
                    "PUT",
                    null,
                    null,
                    null);
                if (response != null)
                {
                    return (ProjectRecalculateResponse) SerializationHelper.Deserialize(response,
                        typeof(ProjectRecalculateResponse));
                }

                return null;
            }
            catch (ApiException ex)
            {
                if (ex.HttpStatusCode == HttpStatusCode.NotFound)
                {
                    return null;
                }

                throw;
            }
        }

        /// <summary>
        /// Recalculate project resource fields 
        /// </summary>
        /// <param name="request">Request. <see cref="PutRecalculateProjectResourceFieldsRequest" /></param> 
        /// <returns><see cref="AsposeResponse"/></returns>            
        public AsposeResponse PutRecalculateProjectResourceFields(PutRecalculateProjectResourceFieldsRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(
                    "Missing required parameter 'name' when calling PutRecalculateProjectResourceFields",
                    StatusCodes.ErrorInvalidInputData);
            }

            // create path and map variables
            var resourcePath =
                UnescapePath(this.configuration.GetApiRootUrl() + "/tasks/{name}/recalculate/resourceFields");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fileName", request.FileName);

            try
            {
                var response = this.apiInvoker.InvokeApi(
                    resourcePath,
                    "PUT",
                    null,
                    null,
                    null);
                if (response != null)
                {
                    return (AsposeResponse) SerializationHelper.Deserialize(response, typeof(AsposeResponse));
                }

                return null;
            }
            catch (ApiException ex)
            {
                if (ex.HttpStatusCode == HttpStatusCode.NotFound)
                {
                    return null;
                }

                throw;
            }
        }

        /// <summary>
        /// Recalculate project uncomplete work 
        /// </summary>
        /// <param name="request">Request. <see cref="PutRecalculateProjectUncompleteWorkToStartAfterRequest" /></param> 
        /// <returns><see cref="AsposeResponse"/></returns>            
        public AsposeResponse PutRecalculateProjectUncompleteWorkToStartAfter(
            PutRecalculateProjectUncompleteWorkToStartAfterRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(
                    "Missing required parameter 'name' when calling PutRecalculateProjectUncompleteWorkToStartAfter",
                    StatusCodes.ErrorInvalidInputData);
            }

            // verify the required parameter 'after' is set
            if (request.After == null)
            {
                throw new ApiException(
                    "Missing required parameter 'after' when calling PutRecalculateProjectUncompleteWorkToStartAfter",
                    StatusCodes.ErrorInvalidInputData);
            }

            // create path and map variables
            var resourcePath = UnescapePath(this.configuration.GetApiRootUrl() +
                                            "/tasks/{name}/recalculate/uncompleteWorkToStartAfter");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fileName", request.FileName);
            var postBody = SerializationHelper.Serialize(request.After); // http body (model) parameter
            try
            {
                var response = this.apiInvoker.InvokeApi(
                    resourcePath,
                    "PUT",
                    postBody,
                    null,
                    null);
                if (response != null)
                {
                    return (AsposeResponse) SerializationHelper.Deserialize(response, typeof(AsposeResponse));
                }

                return null;
            }
            catch (ApiException ex)
            {
                if (ex.HttpStatusCode == HttpStatusCode.NotFound)
                {
                    return null;
                }

                throw;
            }
        }

        /// <summary>
        /// Recalculate project work as complete  
        /// </summary>
        /// <param name="request">Request. <see cref="PutRecalculateProjectWorkAsCompleteRequest" /></param> 
        /// <returns><see cref="AsposeResponse"/></returns>            
        public AsposeResponse PutRecalculateProjectWorkAsComplete(PutRecalculateProjectWorkAsCompleteRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException(
                    "Missing required parameter 'name' when calling PutRecalculateProjectWorkAsComplete",
                    StatusCodes.ErrorInvalidInputData);
            }

            // verify the required parameter 'completeThrough' is set
            if (request.CompleteThrough == null)
            {
                throw new ApiException(
                    "Missing required parameter 'completeThrough' when calling PutRecalculateProjectWorkAsComplete",
                    StatusCodes.ErrorInvalidInputData);
            }

            // create path and map variables
            var resourcePath = UnescapePath(this.configuration.GetApiRootUrl() +
                                            "/tasks/{name}/recalculate/projectWorkAsComplete");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "setZeroOrHundredPercentCompleteOnly",
                request.SetZeroOrHundredPercentCompleteOnly);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fileName", request.FileName);
            var postBody = SerializationHelper.Serialize(request.CompleteThrough); // http body (model) parameter
            try
            {
                var response = this.apiInvoker.InvokeApi(
                    resourcePath,
                    "PUT",
                    postBody,
                    null,
                    null);
                if (response != null)
                {
                    return (AsposeResponse) SerializationHelper.Deserialize(response, typeof(AsposeResponse));
                }

                return null;
            }
            catch (ApiException ex)
            {
                if (ex.HttpStatusCode == HttpStatusCode.NotFound)
                {
                    return null;
                }

                throw;
            }
        }

        /// <summary>
        /// Renumber WBS code of passed tasks (if specified) or all project&#39;s tasks. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutRenumberWbsCodeRequest" /></param> 
        /// <returns><see cref="AsposeResponse"/></returns>            
        public AsposeResponse PutRenumberWbsCode(PutRenumberWbsCodeRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException("Missing required parameter 'name' when calling PutRenumberWbsCode",
                    StatusCodes.ErrorInvalidInputData);
            }

            // verify the required parameter 'taskUids' is set
            if (request.TaskUids == null)
            {
                throw new ApiException("Missing required parameter 'taskUids' when calling PutRenumberWbsCode",
                    StatusCodes.ErrorInvalidInputData);
            }

            // create path and map variables
            var resourcePath = UnescapePath(this.configuration.GetApiRootUrl() + "/tasks/{name}/renumberWbsCode");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fileName", request.FileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            var postBody = SerializationHelper.Serialize(request.TaskUids); // http body (model) parameter
            try
            {
                var response = this.apiInvoker.InvokeApi(
                    resourcePath,
                    "PUT",
                    postBody,
                    null,
                    null);
                if (response != null)
                {
                    return (AsposeResponse) SerializationHelper.Deserialize(response, typeof(AsposeResponse));
                }

                return null;
            }
            catch (ApiException ex)
            {
                if (ex.HttpStatusCode == HttpStatusCode.NotFound)
                {
                    return null;
                }

                throw;
            }
        }

        /// <summary>
        /// Updates resource with the specified Uid 
        /// </summary>
        /// <param name="request">Request. <see cref="PutResourceRequest" /></param> 
        /// <returns><see cref="ResourceResponse"/></returns>            
        public ResourceResponse PutResource(PutResourceRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException("Missing required parameter 'name' when calling PutResource",
                    StatusCodes.ErrorInvalidInputData);
            }

            // verify the required parameter 'resourceUid' is set
            if (request.ResourceUid == null)
            {
                throw new ApiException("Missing required parameter 'resourceUid' when calling PutResource",
                    StatusCodes.ErrorInvalidInputData);
            }

            // verify the required parameter 'resource' is set
            if (request.Resource == null)
            {
                throw new ApiException("Missing required parameter 'resource' when calling PutResource",
                    StatusCodes.ErrorInvalidInputData);
            }

            // create path and map variables
            var resourcePath =
                UnescapePath(this.configuration.GetApiRootUrl() + "/tasks/{name}/resources/{resourceUid}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "resourceUid", request.ResourceUid);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "mode", request.Mode);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "recalculate", request.Recalculate);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fileName", request.FileName);
            var postBody = SerializationHelper.Serialize(request.Resource); // http body (model) parameter
            try
            {
                var response = this.apiInvoker.InvokeApi(
                    resourcePath,
                    "PUT",
                    postBody,
                    null,
                    null);
                if (response != null)
                {
                    return (ResourceResponse) SerializationHelper.Deserialize(response, typeof(ResourceResponse));
                }

                return null;
            }
            catch (ApiException ex)
            {
                if (ex.HttpStatusCode == HttpStatusCode.NotFound)
                {
                    return null;
                }

                throw;
            }
        }

        /// <summary>
        /// Updates special task getting by task UID 
        /// </summary>
        /// <param name="request">Request. <see cref="PutTaskRequest" /></param> 
        /// <returns><see cref="TaskResponse"/></returns>            
        public TaskResponse PutTask(PutTaskRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException("Missing required parameter 'name' when calling PutTask",
                    StatusCodes.ErrorInvalidInputData);
            }

            // verify the required parameter 'taskUid' is set
            if (request.TaskUid == null)
            {
                throw new ApiException("Missing required parameter 'taskUid' when calling PutTask",
                    StatusCodes.ErrorInvalidInputData);
            }

            // verify the required parameter 'task' is set
            if (request.Task == null)
            {
                throw new ApiException("Missing required parameter 'task' when calling PutTask",
                    StatusCodes.ErrorInvalidInputData);
            }

            // create path and map variables
            var resourcePath = UnescapePath(this.configuration.GetApiRootUrl() + "/tasks/{name}/tasks/{taskUid}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "taskUid", request.TaskUid);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "mode", request.Mode);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "recalculate", request.Recalculate);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fileName", request.FileName);
            var postBody = SerializationHelper.Serialize(request.Task); // http body (model) parameter
            try
            {
                var response = this.apiInvoker.InvokeApi(
                    resourcePath,
                    "PUT",
                    postBody,
                    null,
                    null);
                if (response != null)
                {
                    return (TaskResponse) SerializationHelper.Deserialize(response, typeof(TaskResponse));
                }

                return null;
            }
            catch (ApiException ex)
            {
                if (ex.HttpStatusCode == HttpStatusCode.NotFound)
                {
                    return null;
                }

                throw;
            }
        }

        /// <summary>
        /// Updates existing task link. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutTaskLinkRequest" /></param> 
        /// <returns><see cref="TaskLinkResponse"/></returns>            
        public TaskLinkResponse PutTaskLink(PutTaskLinkRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException("Missing required parameter 'name' when calling PutTaskLink",
                    StatusCodes.ErrorInvalidInputData);
            }

            // verify the required parameter 'index' is set
            if (request.Index == null)
            {
                throw new ApiException("Missing required parameter 'index' when calling PutTaskLink",
                    StatusCodes.ErrorInvalidInputData);
            }

            // verify the required parameter 'taskLink' is set
            if (request.TaskLink == null)
            {
                throw new ApiException("Missing required parameter 'taskLink' when calling PutTaskLink",
                    StatusCodes.ErrorInvalidInputData);
            }

            // create path and map variables
            var resourcePath = UnescapePath(this.configuration.GetApiRootUrl() + "/tasks/{name}/taskLinks/{index}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "index", request.Index);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fileName", request.FileName);
            var postBody = SerializationHelper.Serialize(request.TaskLink); // http body (model) parameter
            try
            {
                var response = this.apiInvoker.InvokeApi(
                    resourcePath,
                    "PUT",
                    postBody,
                    null,
                    null);
                if (response != null)
                {
                    return (TaskLinkResponse) SerializationHelper.Deserialize(response, typeof(TaskLinkResponse));
                }

                return null;
            }
            catch (ApiException ex)
            {
                if (ex.HttpStatusCode == HttpStatusCode.NotFound)
                {
                    return null;
                }

                throw;
            }
        }

        /// <summary>
        /// Updates existing task&#39;s recurring info. Note that task should be already recurring. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutTaskRecurringInfoRequest" /></param> 
        /// <returns><see cref="AsposeResponse"/></returns>            
        public AsposeResponse PutTaskRecurringInfo(PutTaskRecurringInfoRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null)
            {
                throw new ApiException("Missing required parameter 'name' when calling PutTaskRecurringInfo",
                    StatusCodes.ErrorInvalidInputData);
            }

            // verify the required parameter 'taskUid' is set
            if (request.TaskUid == null)
            {
                throw new ApiException("Missing required parameter 'taskUid' when calling PutTaskRecurringInfo",
                    StatusCodes.ErrorInvalidInputData);
            }

            // verify the required parameter 'recurringInfo' is set
            if (request.RecurringInfo == null)
            {
                throw new ApiException("Missing required parameter 'recurringInfo' when calling PutTaskRecurringInfo",
                    StatusCodes.ErrorInvalidInputData);
            }

            // create path and map variables
            var resourcePath =
                UnescapePath(this.configuration.GetApiRootUrl() + "/tasks/{name}/tasks/{taskUid}/recurringInfo");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "taskUid", request.TaskUid);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fileName", request.FileName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            var postBody = SerializationHelper.Serialize(request.RecurringInfo); // http body (model) parameter
            try
            {
                var response = this.apiInvoker.InvokeApi(
                    resourcePath,
                    "PUT",
                    postBody,
                    null,
                    null);
                if (response != null)
                {
                    return (AsposeResponse) SerializationHelper.Deserialize(response, typeof(AsposeResponse));
                }

                return null;
            }
            catch (ApiException ex)
            {
                if (ex.HttpStatusCode == HttpStatusCode.NotFound)
                {
                    return null;
                }

                throw;
            }
        }

        /// <summary>
        /// Gets the list of published projects in the current Project Online account.
        /// </summary>
        /// <param name="request">Request. <see cref="GetProjectListRequest" /></param> 
        /// <returns><see cref="ProjectListResponse"/></returns>            
        public ProjectListResponse GetProjectList(GetProjectListRequest request)
        {
            // verify the required parameter 'siteUrl' is set
            if (request.SiteUrl == null)
            {
                throw new ApiException("Missing required parameter 'siteUrl' when calling GetProjectList",
                    StatusCodes.ErrorInvalidInputData);
            }

            // create path and map variables
            var resourcePath = UnescapePath(this.configuration.GetApiRootUrl() + "/tasks/projectonline/projectlist");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "siteUrl", request.SiteUrl);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "userName", request.UserName);


            var header = new Dictionary<string, string>();
            if (request.Token != null)
            {
                header.Add("x-project-online-token", request.Token);
            }

            if (request.XSharepointPassword != null)
            {
                header.Add("x-sharepoint-password", request.XSharepointPassword);
            }

            try
            {
                var response = this.apiInvoker.InvokeApi(
                    resourcePath,
                    "GET",
                    null,
                    header,
                    null,
                    null);
                if (response != null)
                {
                    return (ProjectListResponse) SerializationHelper.Deserialize(response, typeof(ProjectListResponse));
                }

                return null;
            }
            catch (ApiException ex)
            {
                if (ex.HttpStatusCode == HttpStatusCode.NotFound)
                {
                    return null;
                }

                throw;
            }
        }

        /// <summary>
        ///  Creates new project in Project Server\\Project Online instance.
        /// </summary>
        /// <param name="request">Request. <see cref="CreateNewProjectRequest" /></param> 
        /// <returns><see cref="AsposeResponse"/></returns>            
        public AsposeResponse CreateNewProject(CreateNewProjectRequest request)
        {
            // verify the required parameter 'Name' is set
            if (request.Name == null)
            {
                throw new ApiException("Missing required parameter 'Name' when calling CreateNewProject",
                    StatusCodes.ErrorInvalidInputData);
            }

            // verify the required parameter 'SiteUrl' is set
            if (request.SiteUrl == null)
            {
                throw new ApiException("Missing required parameter 'SiteUrl' when calling CreateNewProject",
                    StatusCodes.ErrorInvalidInputData);
            }

            // create path and map variables
            var resourcePath =
                UnescapePath(this.configuration.GetApiRootUrl() + "/tasks/projectOnline/{siteUrl}/{name}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "siteUrl", request.SiteUrl);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);

            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "userName", request.UserName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);


            var header = new Dictionary<string, string>();
            if (request.XProjectOnlineToken != null)
            {
                header.Add("x-project-online-token", request.XProjectOnlineToken);
            }

            if (request.XSharepointPassword != null)
            {
                header.Add("x-sharepoint-password", request.XSharepointPassword);
            }

            string body = null;
            if (request.SaveOptions != null)
            {
                body = SerializationHelper.Serialize(request.SaveOptions);
            }

            try
            {
                var response = this.apiInvoker.InvokeApi(
                    resourcePath,
                    "POST",
                    body,
                    header,
                    null,
                    null);
                if (response != null)
                {
                    return (AsposeResponse) SerializationHelper.Deserialize(response, typeof(AsposeResponse));
                }

                return null;
            }
            catch (ApiException ex)
            {
                if (ex.HttpStatusCode == HttpStatusCode.NotFound)
                {
                    return null;
                }

                throw;
            }
        }

        /// <summary>
        ///  Updates existing project in Project Server\\Project Online instance. The existing project will be overwritten.
        /// </summary>
        /// <param name="request">Request. <see cref="CreateNewProjectRequest" /></param> 
        /// <returns><see cref="AsposeResponse"/></returns>            
        public AsposeResponse UpdateProject(UpdateProjectRequest request)
        {
            // verify the required parameter 'Name' is set
            if (request.Name == null)
            {
                throw new ApiException("Missing required parameter 'Name' when calling CreateNewProject",
                    StatusCodes.ErrorInvalidInputData);
            }

            // verify the required parameter 'SiteUrl' is set
            if (request.SiteUrl == null)
            {
                throw new ApiException("Missing required parameter 'SiteUrl' when calling CreateNewProject",
                    StatusCodes.ErrorInvalidInputData);
            }

            // create path and map variables
            var resourcePath =
                UnescapePath(this.configuration.GetApiRootUrl() + "/tasks/projectOnline/{siteUrl}/{name}");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "siteUrl", request.SiteUrl);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);

            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "userName", request.UserName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);


            var header = new Dictionary<string, string>();
            if (request.XProjectOnlineToken != null)
            {
                header.Add("x-project-online-token", request.XProjectOnlineToken);
            }

            if (request.XSharepointPassword != null)
            {
                header.Add("x-sharepoint-password", request.XSharepointPassword);
            }

            string body = null;
            if (request.SaveOptions != null)
            {
                body = SerializationHelper.Serialize(request.SaveOptions);
            }

            try
            {
                var response = this.apiInvoker.InvokeApi(
                    resourcePath,
                    "PUT",
                    body,
                    header,
                    null,
                    null);
                if (response != null)
                {
                    return (AsposeResponse) SerializationHelper.Deserialize(response, typeof(AsposeResponse));
                }

                return null;
            }
            catch (ApiException ex)
            {
                if (ex.HttpStatusCode == HttpStatusCode.NotFound)
                {
                    return null;
                }

                throw;
            }
        }

        /// <summary>
        /// Upload file 
        /// </summary>
        /// <param name="request">Request. <see cref="PostCreateRequest" /></param>
        /// <returns><see cref="UploadResponse"/></returns>    
        public UploadResponse UploadFile(PostCreateRequest request)
        {
            var url = BuildUrl(request.Path, (object) request.VersionId, (object) request.Storage);
            var formParams = new Dictionary<string, object>();
            if (request.File != null)
                formParams.Add("file", (object) this.apiInvoker.ToFileInfo(request.File, "File"));
            try
            {
                string json = this.apiInvoker.InvokeApi(url, "PUT", (string) null, (Dictionary<string, string>) null,
                    formParams, "application/json");
                if (json != null)
                    return (UploadResponse) SerializationHelper.Deserialize(json, typeof(UploadResponse));
                return (UploadResponse) null;
            }
            catch (ApiException ex)
            {
                if (ex.HttpStatusCode == HttpStatusCode.NotFound)
                    return (UploadResponse) null;
                throw;
            }
        }


        /// <summary>
        /// Delete file 
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteRequest" /></param>
        /// <returns><see cref="DeleteResponse"/></returns>    
        public DeleteResponse DeleteFile(DeleteRequest request)
        {
            if (request.Path == null)
                throw new ApiException("Missing required parameter 'path' when calling DeleteFile",
                    StatusCodes.ErrorInvalidInputData);

            var url = BuildUrl(request.Path, (object) request.VersionId, (object) request.Storage);
            var formParams = new Dictionary<string, object>();

            try
            {
                string json = this.apiInvoker.InvokeApi(url, "DELETE", (string) null, (Dictionary<string, string>) null,
                    formParams, "application/json");

                if (string.IsNullOrEmpty(json))
                    return new DeleteResponse {Code = 200, Status = "OK"};

                return (DeleteResponse) SerializationHelper.Deserialize(json, typeof(DeleteResponse));
            }
            catch (ApiException ex)
            {
                if (ex.HttpStatusCode == HttpStatusCode.NotFound)
                    return (DeleteResponse) null;
                throw;
            }
        }

        /// <summary>
        /// Download file 
        /// </summary>
        /// <param name="request">Request. <see cref="DownloadFileRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>    
        public Stream DownloadFile(DownloadFileRequest request)
        {
            var url = BuildUrl(request.Path, (object) request.VersionId, (object) request.Storage);

            return this.apiInvoker.InvokeBinaryApi(url, "GET", null, null, null);
        }

        private string BuildUrl(string path, object versionId, object storage)
        {
            string baseUrl = Regex
                .Replace(this.configuration.GetApiRootUrl() + "/tasks/storage/file", "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");

            var preparedPath = path
                .Replace(@"\", "/")
                .Replace(" ", "%20");

            baseUrl += string.Format("/{0}", preparedPath);

            return UrlHelper
                .AddQueryParameterToUrl(UrlHelper
                    .AddQueryParameterToUrl(baseUrl, "versionId", versionId), "storage", storage);
        }

        private static string UnescapePath(string path)
        {
            return Regex.Replace(path, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
        }
    }
}