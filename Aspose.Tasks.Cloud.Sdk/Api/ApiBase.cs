using System.Collections.Generic;
using Aspose.Tasks.Cloud.Sdk.RequestHandlers;

namespace Aspose.Tasks.Cloud.Sdk
{
    public abstract class ApiBase
    {        
        protected readonly ApiInvoker apiInvoker;
        protected readonly Configuration configuration; 
        
        internal ApiBase(Configuration configuration)
        {
            this.configuration = configuration;
            
            var requestHandlers = new List<IRequestHandler>();
            requestHandlers.Add(new OAuthRequestHandler(this.configuration));
            requestHandlers.Add(new DebugLogRequestHandler(this.configuration));
            requestHandlers.Add(new ApiExceptionRequestHandler());
            requestHandlers.Add(new AuthWithSignatureRequestHandler(this.configuration));
            this.apiInvoker = new ApiInvoker(requestHandlers);
        }
    }
}