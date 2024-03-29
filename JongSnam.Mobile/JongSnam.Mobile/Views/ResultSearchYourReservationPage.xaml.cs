﻿using System;
using JongSnam.Mobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JongSnam.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ResultSearchYourReservationPage : ContentPage
    {
        ResultSearchYourReservationViewModel _viewModel;
        public ResultSearchYourReservationPage(string UserName, string StoreName, DateTime StartDate, DateTime EndDate)
        {
            InitializeComponent();
            BindingContext = _viewModel = new ResultSearchYourReservationViewModel(UserName, StoreName, StartDate, EndDate);
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}