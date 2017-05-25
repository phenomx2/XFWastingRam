﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace XFWastingRam
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            // The root page of your application

            var bootstraper = new AppBootstraper();
            MainPage = bootstraper.CreateMainPage();
            //MainPage = new TodoList();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
