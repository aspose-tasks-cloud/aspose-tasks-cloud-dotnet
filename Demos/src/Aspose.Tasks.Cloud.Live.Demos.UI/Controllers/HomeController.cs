using Aspose.Tasks.Cloud.Live.Demos.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aspose.Tasks.Cloud.Live.Demos.UI.Controllers
{
	public class HomeController : BaseController
	{
	
		public override string Product => (string)RouteData.Values["productname"];
		

		public ActionResult Default()
		{
			ViewBag.PageTitle = "Project Managemen Creator & Viewer for Cloud (C# REST SDK)";
			ViewBag.MetaDescription = "Enable your C#, ASP.NET &amp; other .NET code to rapidly develop cloud-based Project Management applications to manipulate &amp; convert MS Project &amp; Primavera docs.";
			var model = new LandingPageModel(this);

			return View(model);
		}
	}
}
