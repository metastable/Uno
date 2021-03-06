﻿using System.Windows.Input;
using Windows.UI.Core;
using Uno.UI.Samples.UITests.Helpers;

namespace SamplesApp.Windows_UI_Xaml_Controls.ToggleSwitchControl.Models
{
	public class ToggleSwitchViewModel : ViewModelBase
	{
		private bool _isOn = true;

		public ToggleSwitchViewModel(CoreDispatcher dispatcher) : base(dispatcher)
		{
			Flip = CreateCommand(OnFlip);
		}

		private void OnFlip() => IsOn = !IsOn;

		public bool IsOn
		{
			get => _isOn;
			set
			{
				_isOn = value;
				RaisePropertyChanged();
			}
		}

		public ICommand Flip { get; }
	}
}
