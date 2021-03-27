﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using JongSnam.Mobile.Models;
using JongSnam.Mobile.Services.Interfaces;
using JongSnamService.Models;
using Xamarin.Forms;

namespace JongSnam.Mobile.ViewModels
{
    public class CommentViewModel : BaseViewModel
    {
        private readonly IReviewServices _reviewService;

        private IsOpen _ratting;
        private string _message;

        public Command SaveCommand { get; }

        public List<IsOpen> Rattings { get; set; } = new List<IsOpen>()
        {
        new IsOpen(){Name = "คะแนน 1 ดาว", RattingValue = 1},
        new IsOpen(){Name = "คะแนน 2 ดาว", RattingValue = 2},
        new IsOpen(){Name = "คะแนน 3 ดาว", RattingValue = 3},
        new IsOpen(){Name = "คะแนน 4 ดาว", RattingValue = 4},
        new IsOpen(){Name = "คะแนน 5 ดาว", RattingValue = 5}
        };
        public IsOpen Ratting
        {
            get => _ratting;
            set
            {
                _ratting = value;
                OnPropertyChanged(nameof(Ratting));
            }
        }

        public string Message
        {
            get => _message;
            set
            {
                _message = value;
                OnPropertyChanged(nameof(Message));
            }
        }

        public CommentViewModel()
        {
            _reviewService = DependencyService.Get<IReviewServices>();

            SaveCommand = new Command(async () => await OnSaveCommand());
        }

        async Task OnSaveCommand()
        {
            var request = new ReviewRequest
            {
                StoreId = storeId,
                UserId = 5,
                Message = Message,
                Rating = Ratting.RattingValue
            };
            var statusSaved = await _reviewService.AddReview(request);
            if (statusSaved)
            {
                await Shell.Current.DisplayAlert("แจ้งเตือน!", "ข้อมูลถูกบันทึกเรียบร้อยแล้ว", "ตกลง");
            }
            else
            {
                await Shell.Current.DisplayAlert("แจ้งเตือน!", "ไม่สามารถบันทึกข้อมูลได้", "ตกลง");
            }
            await Shell.Current.GoToAsync("..");


        }

        internal void OnAppearing()
        {
            IsBusy = true;
        }
    }
}
