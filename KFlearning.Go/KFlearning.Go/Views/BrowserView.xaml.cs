﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KFlearning.Go.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BrowserView : ContentPage
    {
        public BrowserView()
        {
            InitializeComponent();
            w.Source = "https://google.com";
        }
    }
}