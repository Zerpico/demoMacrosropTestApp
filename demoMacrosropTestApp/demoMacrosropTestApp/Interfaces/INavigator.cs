using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace demoMacrosropTestApp.Interfaces
{
	public interface INavigator
	{
		Task PopAsync();
		Task PopToRootAsync();
		Task PushAsync<TViewModel>() where TViewModel : class, IViewModelBase;
		Task PushAsync<TViewModel, P>(P parameter) where TViewModel : class, IViewModelBase;
		Task PushModalAsync<TViewModel>() where TViewModel : class, IViewModelBase;
	}
}
