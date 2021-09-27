
using System;
using Autofac;
using Xamarin.Forms;
using demoMacrosropTestApp.Interfaces;
using demoMacrosropTestApp.Services;
using demoMacrosropTestApp.Services.Cameras;

namespace demoMacrosropTestApp.Bootstrap.Modules
{
	public class DependencyRegistrationModule : Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			builder.RegisterType<ViewFactory>().As<IViewFactory>().SingleInstance();
			builder.RegisterType<Navigator>().As<INavigator>().SingleInstance();
			builder.RegisterType<CameraConfiguration>().As<ICameraConfiguration>().SingleInstance();
			builder.Register<INavigation>(context => Application.Current.MainPage.Navigation).SingleInstance();
		}
	}
}
