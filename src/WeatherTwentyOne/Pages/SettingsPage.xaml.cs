﻿using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;
using WeatherTwentyOne.ViewModels;

namespace WeatherTwentyOne.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SettingsPage : ContentPage
    {
        public SettingsPage()
        {
            InitializeComponent();

            BindingContext = new SettingsViewModel();

            NavBar.ActiveTab = "Settings";
        }
    }
}