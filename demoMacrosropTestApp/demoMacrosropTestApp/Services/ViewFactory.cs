﻿using System;
using System.Collections.Generic;
using Autofac;
using Xamarin.Forms;
using demoMacrosropTestApp.Interfaces;
using Autofac.Core;

namespace demoMacrosropTestApp.Services
{
	public class ViewFactory : IViewFactory
	{
		private readonly IDictionary<Type, Type> _map = new Dictionary<Type, Type>();
		private readonly IComponentContext _componentContext;

		public ViewFactory(IComponentContext componentContext)
		{
			_componentContext = componentContext;
		}

		public void Register<TViewModel, TView>() where TViewModel : class, IViewModelBase where TView : Page
		{
			_map[typeof(TViewModel)] = typeof(TView);
		}

		public Page Resolve<TViewModel>() where TViewModel : class, IViewModelBase
		{
			var viewModel = _componentContext.Resolve<TViewModel>();
			var viewType = _map[typeof(TViewModel)];
			var view = _componentContext.Resolve(viewType) as Page;

			view.BindingContext = viewModel;
			return view;
		}

		public Page Resolve<TViewModel, P>(P parameter) where TViewModel : class, IViewModelBase
		{
			var viewModel = _componentContext.Resolve<TViewModel>(
				new TypedParameter(typeof(P), parameter));
			var viewType = _map[typeof(TViewModel)];
			var view = _componentContext.Resolve(viewType) as Page;

			view.BindingContext = viewModel;
			return view;
		}
	}
}
