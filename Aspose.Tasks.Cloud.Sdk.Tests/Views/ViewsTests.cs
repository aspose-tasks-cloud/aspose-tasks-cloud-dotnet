
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ViewsTests.cs">
//   Copyright (c) 2024 Aspose.Tasks for Cloud
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

using Aspose.Tasks.Cloud.Sdk.Model;
using Aspose.Tasks.Cloud.Sdk.Model.Requests;
using Aspose.Tasks.Cloud.Sdk.Tests.Base;
using NUnit.Framework;
using System.Net;
using Task = System.Threading.Tasks.Task;

namespace Aspose.Tasks.Cloud.Sdk.Tests.ViewsTests
{
    [TestFixture]
    internal sealed class ViewsTests : BaseTestContext
    {
        [Test]
        public async Task TestGetViews()
        {
            var remoteName = await UploadFileToStorageAsync("Home move plan.mpp");
            var response = await TasksApi.GetViewsAsync(new GetViewsRequest()
            {
                Name = remoteName,
                Folder = this.DataFolder
            });

            Assert.AreEqual((int)HttpStatusCode.OK, response.Code);
            Assert.IsNotNull(response.Views);
            var views = response.Views;

            Assert.IsNotNull(views);
            var ganttChartView = views[0];
            Assert.IsNotNull(ganttChartView);
            Assert.AreEqual(true, ganttChartView.ShowInMenu);
            Assert.AreEqual(ItemType.TaskItem, ganttChartView.Type);
            Assert.AreEqual(ViewScreen.Gantt, ganttChartView.Screen);
            Assert.AreEqual("&Gantt Chart", ganttChartView.Name);
            Assert.AreEqual(1, ganttChartView.Uid);
        }

        [Test]
        public async Task TestGetAllTableTextStyles()
        {
            var remoteName = await UploadFileToStorageAsync("NewProductDev.mpp");
            var response = await TasksApi.GetAllTableTextStylesAsync(new GetAllTableTextStylesRequest()
            {
                Name = remoteName,
                ViewUid = 2,
                Folder = this.DataFolder
            });

            Assert.AreEqual((int)HttpStatusCode.OK, response.Code);

            Assert.AreEqual(8, response.Items.Length);
        }

        [Test]
        public async Task TestGetTableTextStyle()
        {
            var remoteName = await UploadFileToStorageAsync("NewProductDev.mpp");
            var response = await TasksApi.GetTableTextStyleAsync(new GetTableTextStyleRequest()
            {
                Name = remoteName,
                ViewUid = 2,
                RowUid = 29,
                Folder = this.DataFolder
            });

            Assert.AreEqual((int)HttpStatusCode.OK, response.Code);

            var tableTextStyle = response.TableTextStyle;
            Assert.IsNotNull(tableTextStyle);
            Assert.AreEqual(29, tableTextStyle.RowUid);
            Assert.AreEqual(Field.Undefined, tableTextStyle.Field);
            Assert.AreEqual(TextItemType.Allocated, tableTextStyle.ItemType);
            Assert.AreEqual(Colors.Transparent, tableTextStyle.Color);
            Assert.AreEqual(BackgroundPattern.Hollow, tableTextStyle.BackgroundPattern);
            Assert.AreEqual(Colors.Transparent, tableTextStyle.BackgroundColor);
        }

        [Test]
        public async Task TestCreateTableTextStyle()
        {
            var remoteName = await UploadFileToStorageAsync("Home move plan.mpp");
            var newTableTextStyle = new TableTextStyle
            {
                RowUid = 3,
                Field = Field.TaskName,
                ItemType = TextItemType.Allocated,
                Color = Colors.Red,
                BackgroundPattern = BackgroundPattern.Hollow,
                BackgroundColor = Colors.GreenYellow,
            };
            var createResponse = await TasksApi.CreateTableTextStyleAsync(new CreateTableTextStyleRequest()
            {
                Name = remoteName,
                ViewUid = 1,
                Folder = this.DataFolder,
                TableTextStyle = newTableTextStyle
            });

            Assert.AreEqual((int)HttpStatusCode.Created, createResponse.Code);

            var getResponse = await TasksApi.GetTableTextStyleAsync(new GetTableTextStyleRequest()
            {
                Name = remoteName,
                ViewUid = 1,
                RowUid = 3,
                Folder = this.DataFolder
            });

            var receivedTableTextStyle = getResponse.TableTextStyle;
            Assert.IsNotNull(receivedTableTextStyle);
            Assert.AreEqual(newTableTextStyle.RowUid, receivedTableTextStyle.RowUid);
            Assert.AreEqual(newTableTextStyle.Field, receivedTableTextStyle.Field);
            Assert.AreEqual(newTableTextStyle.ItemType, receivedTableTextStyle.ItemType);
            Assert.AreEqual(newTableTextStyle.Color, receivedTableTextStyle.Color);
            Assert.AreEqual(newTableTextStyle.BackgroundPattern, receivedTableTextStyle.BackgroundPattern);
            Assert.AreEqual(newTableTextStyle.BackgroundColor, receivedTableTextStyle.BackgroundColor);
        }

        [Test]
        public async Task TestUpdateTableTextStyle()
        {
            var remoteName = await UploadFileToStorageAsync("NewProductDev.mpp");
            var getRequest = new GetTableTextStyleRequest()
            {
                Name = remoteName,
                ViewUid = 2,
                RowUid = 29,
                Folder = this.DataFolder
            };
            var getResponse = await TasksApi.GetTableTextStyleAsync(getRequest);
            Assert.AreEqual(Colors.Transparent, getResponse.TableTextStyle.Color);
            Assert.AreEqual(Colors.Transparent, getResponse.TableTextStyle.BackgroundColor);

            getResponse.TableTextStyle.Color = Colors.OrangeRed;
            getResponse.TableTextStyle.BackgroundColor = Colors.DodgerBlue;

            var updateResponse = await TasksApi.UpdateTableTextStyleAsync(new UpdateTableTextStyleRequest()
            {
                Name = remoteName,
                ViewUid = 2,
                Folder = this.DataFolder,
                TableTextStyle = getResponse.TableTextStyle
            });
            Assert.AreEqual((int)HttpStatusCode.OK, updateResponse.Code);

            getResponse = await TasksApi.GetTableTextStyleAsync(getRequest);
            Assert.AreEqual(Colors.OrangeRed, getResponse.TableTextStyle.Color);
            Assert.AreEqual(Colors.DodgerBlue, getResponse.TableTextStyle.BackgroundColor);
        }

        [Test]
        public async Task TestDeleteTableTextStyle()
        {
            var remoteName = await UploadFileToStorageAsync("NewProductDev.mpp");
            var getResponse = await TasksApi.GetAllTableTextStylesAsync(new GetAllTableTextStylesRequest()
            {
                Name = remoteName,
                ViewUid = 2,
                Folder = this.DataFolder
            });
            Assert.AreEqual(8, getResponse.Items.Length);

            var deleteResponse = await TasksApi.DeleteTableTextStyleAsync(new DeleteTableTextStyleRequest()
            {
                Name = remoteName,
                ViewUid = 2,
                RowUid = 29,
                Folder = this.DataFolder,
            });
            Assert.AreEqual((int)HttpStatusCode.OK, deleteResponse.Code);

            getResponse = await TasksApi.GetAllTableTextStylesAsync(new GetAllTableTextStylesRequest()
            {
                Name = remoteName,
                ViewUid = 2,
                Folder = this.DataFolder
            });
            Assert.AreEqual(7, getResponse.Items.Length);
        }
    }
}
