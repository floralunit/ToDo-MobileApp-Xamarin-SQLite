﻿using FloralMobileApp.Services;
using FloralMobileApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FloralMobileApp.Views
{
    public partial class ItemsPage
    {
        ItemsViewModel _viewModel;
        public ItemsPage(string menuTitle)
        {
            InitializeComponent();
            BindingContext = _viewModel = new ItemsViewModel(menuTitle);
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearingAsync();
        }
    }
}