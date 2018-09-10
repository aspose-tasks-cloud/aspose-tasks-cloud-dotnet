
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TestExtendedAttributes.cs">
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

using System.Collections.Generic;
using System.Net;

using Aspose.Tasks.Cloud.Sdk.Tests.Base;
using Aspose.Tasks.Cloud.Sdk.Model;
using Aspose.Tasks.Cloud.Sdk.Model.Requests;
using NUnit.Framework;

namespace Aspose.Tasks.Cloud.Sdk.Tests.Tasks
{
    [TestFixture]
    public class TestExtendedAttributes : BaseTestContext
    {
        [Test]
        public void TestGetExtendedAttributes()
        {
            var remoteName = UploadFileToStorage("NewProductDev.mpp");

            var response = TasksApi.GetExtendedAttributes(new GetExtendedAttributesRequest
            {
                Name = remoteName,
                Folder = this.DataFolder
            });

            Assert.AreEqual((int)HttpStatusCode.OK, response.Code);
            Assert.IsNotNull(response.ExtendedAttributes);
            Assert.AreEqual(2, response.ExtendedAttributes.List.Count);
        }

        [Test]
        public void TestGetExtendedAttribute()
        {
            var remoteName = UploadFileToStorage("NewProductDev.mpp");

            var response = TasksApi.GetExtendedAttributeByIndex(new GetExtendedAttributeByIndexRequest
            {
                Index = 1,
                Name = remoteName,
                Folder = this.DataFolder
            });

            Assert.AreEqual((int)HttpStatusCode.OK, response.Code);
            Assert.IsNotNull(response.ExtendedAttribute);
            Assert.AreEqual("Text1", response.ExtendedAttribute.FieldName);
            Assert.AreEqual(CalculationType.Lookup, response.ExtendedAttribute.CalculationType);
            Assert.AreEqual(1, response.ExtendedAttribute.ValueList.Count);
            Assert.AreEqual("descr", response.ExtendedAttribute.ValueList[0].Description);
            Assert.AreEqual(1, response.ExtendedAttribute.ValueList[0].Id);
        }

        [Test]
        public void TestAddExtendedAttributeDefinition()
        {
            var remoteName = UploadFileToStorage("NewProductDev.mpp");

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

            var response = TasksApi.PutExtendedAttribute(new PutExtendedAttributeRequest
            {
                ExtendedAttribute = newExtendedAttribute,
                Name = remoteName,
                Folder = this.DataFolder
            });

            Assert.AreEqual((int)HttpStatusCode.OK, response.Code);
            Assert.IsNotNull(response.ExtendedAttribute);

            Assert.AreEqual("Text3", response.ExtendedAttribute.FieldName);
            Assert.AreEqual("New Field", response.ExtendedAttribute.Alias);
            Assert.AreEqual("188743737", response.ExtendedAttribute.FieldId);

            var addedAttributeIndex = response.ExtendedAttribute.Index;


            var getResponse = TasksApi.GetExtendedAttributeByIndex(new GetExtendedAttributeByIndexRequest
            {
                Index = addedAttributeIndex,
                Name = remoteName,
                Folder = this.DataFolder

            });

            Assert.AreEqual((int)HttpStatusCode.OK, getResponse.Code);
            Assert.IsNotNull(getResponse.ExtendedAttribute);

            var extendedAttribute = getResponse.ExtendedAttribute;


            Assert.AreEqual("188743737", extendedAttribute.FieldId);
            Assert.AreEqual("Text3", extendedAttribute.FieldName);
            Assert.AreEqual(CustomFieldType.Text, extendedAttribute.CfType);
            Assert.AreEqual("New Field", extendedAttribute.Alias);
            var valueList = extendedAttribute.ValueList;
            Assert.AreEqual(2, valueList.Count);

            Assert.AreEqual(111, valueList[0].Id);
            Assert.AreEqual("Internal", valueList[0].Val);
            Assert.AreEqual("descr1", valueList[0].Description);

            Assert.AreEqual(112, valueList[1].Id);
            Assert.AreEqual("External", valueList[1].Val);
            Assert.AreEqual("descr2", valueList[1].Description);
        }

        [Test]
        public void TestEditExtendedAttributeDefinition()
        {
            var remoteName = UploadFileToStorage("NewProductDev.mpp");

            var response = TasksApi.GetExtendedAttributeByIndex(new GetExtendedAttributeByIndexRequest
            {
                Index = 1,
                Name = remoteName,
                Folder = this.DataFolder
            });

            Assert.AreEqual((int)HttpStatusCode.OK, response.Code);
            Assert.IsNotNull(response.ExtendedAttribute);

            var extendedAttributeToEdit = response.ExtendedAttribute;
            extendedAttributeToEdit.CalculationType = CalculationType.None;
            extendedAttributeToEdit.ValueList.Clear();
            extendedAttributeToEdit.CfType = CustomFieldType.Text;
            extendedAttributeToEdit.FieldName = "Text1";
            extendedAttributeToEdit.ElementType = ElementType.Task;
            extendedAttributeToEdit.Alias = "Edited field";

            var putResponse = TasksApi.PutExtendedAttribute(new PutExtendedAttributeRequest
            {
                ExtendedAttribute = extendedAttributeToEdit,
                Name = remoteName,
                Folder = this.DataFolder
            });

            Assert.AreEqual((int)HttpStatusCode.OK, response.Code);
            Assert.IsNotNull(response.ExtendedAttribute);

            Assert.AreEqual("Text1", putResponse.ExtendedAttribute.FieldName);
            Assert.AreEqual("Edited field", putResponse.ExtendedAttribute.Alias);
            Assert.AreEqual("188743731", putResponse.ExtendedAttribute.FieldId);

            var getResponse = TasksApi.GetExtendedAttributeByIndex(new GetExtendedAttributeByIndexRequest
            {
                Index = putResponse.ExtendedAttribute.Index,
                Name = remoteName,
                Folder = this.DataFolder

            });

            Assert.AreEqual((int)HttpStatusCode.OK, getResponse.Code);
            Assert.IsNotNull(getResponse.ExtendedAttribute);

            var extendedAttribute = getResponse.ExtendedAttribute;

            Assert.AreEqual("188743731", extendedAttribute.FieldId);
            Assert.AreEqual("Text1", extendedAttribute.FieldName);
            Assert.AreEqual(CustomFieldType.Text, extendedAttribute.CfType);
            Assert.AreEqual("Edited field", extendedAttribute.Alias);
            Assert.AreEqual(0, extendedAttribute.ValueList.Count);

        }

        [Test]
        public void TestDeleteExtendedAttribute()
        {
            var remoteName = UploadFileToStorage("NewProductDev.mpp");

            var deleteResponse = TasksApi.DeleteExtendedAttributeByIndex(new DeleteExtendedAttributeByIndexRequest
            {
                Index = 1,
                Name = remoteName,
                Folder = this.DataFolder
            });

            Assert.AreEqual((int)HttpStatusCode.OK, deleteResponse.Code);

            var response = TasksApi.GetExtendedAttributes(new GetExtendedAttributesRequest
            {
                Name = remoteName,
                Folder = this.DataFolder
            });

            Assert.AreEqual((int)HttpStatusCode.OK, response.Code);
            Assert.IsNotNull(response.ExtendedAttributes);
            Assert.AreEqual(1, response.ExtendedAttributes.List.Count);
        }
    }
}
