using System;
using Microsoft.Maui.Controls;

namespace Hemligheter
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        protected override void OnAppearing()
        {
			((Window)Parent).Title = App.Title;
			base.OnAppearing();
        }
    }
}
