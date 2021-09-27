using demoMacrosropTestApp.Services.Cameras;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using demoMacrosropTestApp.Common;

namespace demoMacrosropTestApp.ViewModels
{
	public class DetailCameraPage : BaseViewModel
	{		
		public DetailCameraPage(Camera camera)
        {
            States = Controls.StateContainer.States.Loading;
            LoadCameraInfo(camera);
            States = Controls.StateContainer.States.Normal;
        }

        #region Fields
        private Guid id;
        private string name;
        private string description;
        private string deviceInfo;
        private bool isDisabled;
        private bool isSoundOn;
        private bool isArchivingEnabled;
        private bool allowedRealtime;
        private string serverName;
        private string serverUrl;
        private string serverPrimaryIp;
        private short serverPrimaryPort;

        public Guid Id
        {
            get => id;
            set => SetProperty(ref id, value);
        }
        public string Name
        {
            get => name;
            set => SetProperty(ref name, value);
        }
        public string Description
        {
            get => description;
            set => SetProperty(ref description, value);
        }
        public string DeviceInfo
        {
            get => deviceInfo;
            set => SetProperty(ref deviceInfo, value);
        }
        public bool IsDisabled
        {
            get => isDisabled;
            set => SetProperty(ref isDisabled, value);
        }
        public bool IsSoundOn
        {
            get => isSoundOn;
            set => SetProperty(ref isSoundOn, value);
        }
        public bool IsArchivingEnabled
        {
            get => isArchivingEnabled;
            set => SetProperty(ref isArchivingEnabled, value);
        }
        public bool AllowedRealtime
        {
            get => allowedRealtime;
            set => SetProperty(ref allowedRealtime, value);
        }
        public string ServerName
        {
            get => serverName;
            set => SetProperty(ref serverName, value);
        }
        public string ServerUrl
        {
            get => serverUrl;
            set => SetProperty(ref serverUrl, value);
        }
        public string ServerPrimaryIp
        {
            get => serverPrimaryIp;
            set => SetProperty(ref serverPrimaryIp, value);
        }
        public short ServerPrimaryPort
        {
            get => serverPrimaryPort;
            set => SetProperty(ref serverPrimaryPort, value);
        }

        #endregion

        private void LoadCameraInfo(Camera camera)
        {
            Id = camera.Id;
            Name = camera.Name;
            Description = camera.Description;
            DeviceInfo = camera.DeviceInfo;
            IsDisabled = camera.IsDisabled;
            IsSoundOn = camera.IsSoundOn;
            isArchivingEnabled = camera.IsArchivingEnabled;
            AllowedRealtime = camera.AllowedRealtime;
            ServerName = camera.Server.Name;
            ServerUrl = camera.Server.Url;
            ServerPrimaryIp = camera.Server.PrimaryIp;
            ServerPrimaryPort = camera.Server.PrimaryPort;
        }
    }
}
