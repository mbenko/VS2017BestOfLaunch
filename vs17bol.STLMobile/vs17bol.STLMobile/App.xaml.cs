using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace vs17bol.STLMobile
{
    public static class MyViewModelLocator
    {
        static MyDataViewModel _model;
        public static MyDataViewModel MyDataVM => _model ?? (_model = new MyDataViewModel());
    }

    public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

			MainPage = new vs17bol.STLMobile.MainPage();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
