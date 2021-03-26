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
    public partial class MonthGraphPage : ContentPage
    {
        MonthGraphViewModel _viewModel;

        public MonthGraphPage(ObservableCollection<ReservationDto> items)
        {
            InitializeComponent();

            BindingContext = _viewModel = new MonthGraphViewModel(items);
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}