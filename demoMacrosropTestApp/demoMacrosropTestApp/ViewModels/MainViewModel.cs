using System;
using System.Windows.Input;
using Xamarin.Forms;
using demoMacrosropTestApp.Interfaces;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Collections.ObjectModel;
using demoMacrosropTestApp.Services.Cameras;
using demoMacrosropTestApp.Common;

namespace demoMacrosropTestApp.ViewModels
{
	public class MainViewModel : BaseViewModel
	{
		private readonly INavigator _navigator;
		private readonly ICameraConfiguration _cameraConfig;

		public MainViewModel(INavigator navigator, ICameraConfiguration cameraConfig)
		{
			_navigator = navigator;
			_cameraConfig = cameraConfig;
			Task.Run(async () => await ExecuteLoadCamerasCommand());
		}

        #region Fields
        ObservableCollection<Camera> cameras;
		public ObservableCollection<Camera> Cameras
		{
			get => cameras;
			set => SetProperty(ref cameras, value);
		}
        #endregion


        #region Commands
        async Task ExecuteLoadCamerasCommand()
		{
			try
			{
				Cameras = new ObservableCollection<Camera>(await _cameraConfig.GetConfigurationAsync());				
				States = Controls.StateContainer.States.Normal;
			}
			catch (Exception ex)
			{
				States = Controls.StateContainer.States.Error;
				Debug.WriteLine(ex);
			}
			finally
			{
				States = Controls.StateContainer.States.Normal;
			}
		}
		void OnCameraSelected(Camera item)
		{
			if (item == null)
				return;

			_navigator.PushAsync<DetailCameraPage, Camera>(item);
		}

		public Command<Camera> CameraTapped => new Command<Camera>(OnCameraSelected);
		public ICommand LoadConfigs => new Command(async () => await ExecuteLoadCamerasCommand());
		public ICommand NextPageCommand => new Command(() =>
		{
			_navigator.PushAsync<DetailCameraPage>();
		});
        #endregion
    }
}
