﻿using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Windows.UI.Xaml.Controls;
using Uno.UI.Samples.Controls;

namespace UITests.Shared.Windows_UI_Xaml_Controls.ComboBox
{
	[SampleControlInfo("ComboBox", "ComboBox_Virtualizing")]
	public sealed partial class ComboBox_Virtualizing : Page
	{
		public ComboBox_Virtualizing()
		{
			Items = Enumerable.Range(0, 12000).Select(i => i.ToString()).ToList();

			var s = new Stopwatch();
			InitializeComponent();
			s.Start();
			DataContext = this;
			textBlock.Text = s.Elapsed.ToString("G");
			s.Stop();
		}

		public List<string> Items { get; set; }
	}
}
