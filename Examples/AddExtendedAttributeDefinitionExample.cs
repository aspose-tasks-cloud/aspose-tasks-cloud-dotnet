using System;
using Aspose.Tasks.Cloud.Sdk;
using Aspose.Tasks.Cloud.Sdk.Model;
using Aspose.Tasks.Cloud.Sdk.Model.Requests;
using System.Collections.Generic;

namespace aspose.tasks.csharp
{
    class AddExtendedAttributeExample : BaseContext
    {
        static void Main(string[] args)
        {
            var configuration = new Configuration { AppKey = BaseContext.AppKey, AppSid = BaseContext.AppSid };
            TasksApi api = new TasksApi(configuration);
            var newExtendedAttribute = new ExtendedAttributeDefinition
            {
                CalculationType = CalculationType.Lookup,
                CfType = CustomFieldType.Text,
                FieldName = "Text3",
                ElementType = ElementType.Task,
                Alias = "New Field",
                ValueList = new List<Value>
                {
                    new Value { Description = "descr1", Val = "Internal", Id = 111 },
                    new Value { Description = "descr2", Val = "External", Id = 112 }
                }
            };
            var response = api.GetExtendedAttributes(new GetExtendedAttributesRequest
            {
                Name = "NewProductDev.mpp",
                Folder = ""
            });
            Console.WriteLine(response.Code);
        }
    }
}