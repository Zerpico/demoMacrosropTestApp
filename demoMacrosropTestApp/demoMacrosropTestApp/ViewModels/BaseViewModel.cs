using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using demoMacrosropTestApp.Controls.StateContainer;
using demoMacrosropTestApp.Interfaces;

namespace demoMacrosropTestApp.ViewModels
{
	public abstract class BaseViewModel : IViewModelBase
	{
        private States states = States.Normal;
        public States States
        {
            get => states;
            set => SetProperty(ref states, value);
        }

        public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged([CallerMemberName] string propertyname = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
		}

        protected bool SetProperty<T>(ref T backingStore, T value,
            [CallerMemberName] string propertyName = "",
            Action onChanged = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
                return false;

            backingStore = value;
            onChanged?.Invoke();
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}
