﻿using JongSnam.Mobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JongSnam.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailYourReservationPage : ContentPage
    {
        DetailYourReservationViewModel _viewModel;
        public DetailYourReservationPage(int reservationId)
        {
            InitializeComponent();
            BindingContext = _viewModel = new DetailYourReservationViewModel(reservationId);
        }
    }
}