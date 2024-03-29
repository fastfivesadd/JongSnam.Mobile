﻿using JongSnam.Mobile.Models;
using JongSnam.Mobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JongSnam.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListFieldPage : ContentPage
    {
        ListFieldViewModel _viewModel;
        public ListFieldPage(StoreDtoModel storeDto)
        {
            InitializeComponent();
            BindingContext = _viewModel = new ListFieldViewModel(storeDto);
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}