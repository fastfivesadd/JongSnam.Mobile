﻿using System;
using JongSnam.Mobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JongSnam.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ReviewPage : ContentPage
    {
        ReviewViewModel _viewModel;

        private int _storeId;

        public ReviewPage(int storeId)
        {
            InitializeComponent();
            BindingContext = _viewModel = new ReviewViewModel(storeId);

            _storeId = storeId;
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }

        async void StartCall(object sender, EventArgs e)
        {
            await Shell.Current.Navigation.PushAsync(new CommentPage(_storeId));
        }
    }
}