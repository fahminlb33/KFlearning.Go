﻿using KFlearning.Go.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KFlearning.Go
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ShellView();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}