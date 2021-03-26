﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JongSnam.Mobile.ViewModels;
using JongSnamService.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JongSnam.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DayGraphPage : ContentPage
    {
        DayGraphViewModel _viewModel;
        public DayGraphPage(ObservableCollection<ReservationDto> items)
        {
            InitializeComponent();
            BindingContext = _viewModel = new DayGraphViewModel(items);
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}