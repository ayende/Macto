using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Castle.Windsor;
using Castle.Windsor.Installer;
using Raven.Client;
using Raven.Client.Document;
using HibernatingRhinos.Macto.Infrastructure.Windsor;

namespace HibernatingRhinos.Macto
{
	public class MvcApplication : System.Web.HttpApplication
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}

		public static void RegisterRoutes(RouteCollection routes)
		{
			routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
			routes.Ignore("favicon.ico");

			routes.MapRoute(
				"Default", // Route name
				"{controller}/{action}/{id}", // URL with parameters
				new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
			);

		}

		protected void Application_Start()
		{
			AreaRegistration.RegisterAllAreas();

			RegisterGlobalFilters(GlobalFilters.Filters);
			RegisterRoutes(RouteTable.Routes);

			CreateRavenDbDocumentStore();
			BootstrapContainer();
		}

		protected void Application_End()
		{
			container.Dispose();
			var store = Application.Get("RavenDbDocumentStore") as IDocumentStore;
			if (store != null)
				store.Dispose();
		}

		public static IDocumentStore DocumentStore { get { return HttpContext.Current.Application["RavenDbDocumentStore"] as IDocumentStore; } }
		private void CreateRavenDbDocumentStore()
		{
			IDocumentStore store = new DocumentStore() { ConnectionStringName = "RavenDB" }.Initialize();
			Application.Add("RavenDbDocumentStore", store);
		}

		private static IWindsorContainer container;
		private static void BootstrapContainer()
		{
			container = new WindsorContainer()
				.Install(FromAssembly.This());
			var controllerFactory = new WindsorControllerFactory(container.Kernel);
			ControllerBuilder.Current.SetControllerFactory(controllerFactory);
		}
	}
}