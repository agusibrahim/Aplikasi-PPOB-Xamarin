using App9test1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using App9test1.Views;
using Xamarin.Forms;

namespace App9test1
{
	public partial class App : Application
	{
        public static Page globalpage;
	    public static Page main;
		public App ()
		{
			InitializeComponent();
            main= new LoginPage();
            //NavigationPage.SetHasNavigationBar(this, false);
            MainPage =new NavigationPage(main);//new NavigationPage( new App9test1.TabbedPage1());
            DependencyService.Get<NavigationInterface>().SetNavigation(MainPage);
            globalpage = MainPage;
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
