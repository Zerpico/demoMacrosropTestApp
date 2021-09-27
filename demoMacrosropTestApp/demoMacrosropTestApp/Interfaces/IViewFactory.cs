using Autofac.Core;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace demoMacrosropTestApp.Interfaces
{
	public interface IViewFactory
	{
		void Register<TViewModel, TView>() where TViewModel : class, IViewModelBase where TView : Page;
		Page Resolve<TViewModel>() where TViewModel : class, IViewModelBase;
		Page Resolve<TViewModel, P>(P parameter) where TViewModel : class, IViewModelBase;
	}
}
