using System;
using Autofac;
using System.Collections.Generic;
using System.Text;
using demoMacrosropTestApp.ViewModels;
using demoMacrosropTestApp.Views;

namespace demoMacrosropTestApp.Bootstrap.Modules
{
	public class ViewModelViewRegistrationModule : Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			builder.RegisterType<MainPage>().SingleInstance();
			builder.RegisterType<MainViewModel>().SingleInstance();

			builder.RegisterType<Views.DetailCameraPage>();
			builder.RegisterType<ViewModels.DetailCameraPage>();
		}
	}
}
