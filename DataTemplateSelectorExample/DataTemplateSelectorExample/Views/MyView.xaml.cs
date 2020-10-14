﻿using DataTemplateSelectorExample.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DataTemplateSelectorExample.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyView : ContentPage
    {
        public MyView()
        {
            InitializeComponent();
            BindingContext = ViewModelLocator.MyViewModel;
        }

    }
}