// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ApiExceptionRequestHandler.cs">
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

namespace Aspose.Tasks.Cloud.Sdk.RequestHandlers
{
    using System;
    using System.IO;
    using System.Net;

    using Aspose.Tasks.Cloud.Sdk;
    using Internal;

    internal class ApiExceptionRequestHandler : IRequestHandler
    {
        public string ProcessUrl(string url)
        {
            return url;
        }

        public void BeforeSend(WebRequest request, Stream streamToSend)
        {            
        }

        public void ProcessResponse(HttpWebResponse response, Stream resultStream)
        {
            if (response.StatusCode != HttpStatusCode.OK)
            {
                this.ThrowApiException(response, resultStream);
            }
        }

        private void ThrowApiException(HttpWebResponse webResponse, Stream resultStream)
        {
            try
            {
                resultStream.Position = 0;
                using (var responseReader = new StreamReader(resultStream))
                {
                    var responseData = responseReader.ReadToEnd();
                    if (string.IsNullOrEmpty(responseData))
                    {
                        if (webResponse.StatusCode == HttpStatusCode.Unauthorized)
                        {
                            var message = webResponse.GetResponseHeader("WWW-Authenticate");
                            throw new ApiException(message,
                                StatusCodes.ErrorAuthentication.Code,
                                StatusCodes.ErrorAuthentication.HttpStatusCode);
                        }
                        else
                        {
                            throw new ApiException("An error occured.",
                                StatusCodes.Error.Code,
                                webResponse.StatusCode);
                        }
                    }

                    var errorResponse = (TasksApiErrorResponse)SerializationHelper.Deserialize(responseData, typeof(TasksApiErrorResponse));

                    if (errorResponse == null)
                    {
                        errorResponse = new TasksApiErrorResponse
                        {
                            Error = new ApiException(responseData,
                            StatusCodes.Error.Code,
                            webResponse.StatusCode)
                        };
                    }
                    
                    else if(errorResponse.Error.HttpStatusCode == default(HttpStatusCode))
                    {
                        errorResponse.Error.HttpStatusCode = webResponse.StatusCode;
                    }

                    throw errorResponse.Error;
                }
            }
            catch (ApiException)
            {
                throw;
            }
            catch (Exception)
            {
                throw new ApiException(webResponse.StatusDescription,
                    StatusCodes.Error.Code,
                    webResponse.StatusCode);
            }
        }
    }
}