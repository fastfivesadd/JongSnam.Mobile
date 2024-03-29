﻿using System.Threading.Tasks;
using JongSnam.Mobile.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JongSnam.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class YourProFilePage : ContentPage
    {
        YourProFileViewModel _viewModel;

        public YourProFilePage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new YourProFileViewModel();

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            Task.Run(async () => await _viewModel.OnAppearingAsync());
        }
    }
}