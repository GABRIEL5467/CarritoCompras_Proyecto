﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarritoCompras
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new View.PageLogin();
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