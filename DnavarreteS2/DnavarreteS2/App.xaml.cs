﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DnavarreteS2
{
    public partial class App : Application
    {
        public App ()
        {
            InitializeComponent();

            MainPage = new Calificaciones();
        }

        protected override void OnStart ()
        {
        }

        protected override void OnSleep ()
        {
        }

        protected override void OnResume ()
        {
        }
    }
}

