using System;
using Xamarin.Forms;

namespace PluginSample
{
	public partial class PluginSamplePage : ContentPage
	{
		public PluginSamplePage()
		{
			InitializeComponent();
		}

		private void OnClicked(object sender, EventArgs e)
		{
			this.label.Text = AssemblyTimeStamp.TimeStampUtil.GetAssemblyTimeStamp().ToString();
		}
	}
}
