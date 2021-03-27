﻿using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using JongSnam.Mobile.Services.Interfaces;
using JongSnam.Mobile.Views;
using JongSnamService.Models;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using Xamarin.Forms;

namespace JongSnam.Mobile.ViewModels
{
    public class ReviewViewModel : BaseViewModel
    {
        public PlotModel BarModel { get; set; }

        private readonly IReviewServices _reviewServices;
        private int _page = 1;
        private int _pageSize = 2;

        public ObservableCollection<ReviewDto> Items { get; }

        public Command LoadDetailReview { get; set; }

        public Command LoadReview { get; }

        public Command<ReviewDto> ItemTapped { get; }

        private double _ratingsum;
        private double _textComment;

        public double RatingSum
        {
            get => _ratingsum;
            set
            {
                _ratingsum = value;
                OnPropertyChanged(nameof(RatingSum));
            }
        }

        public double TextComment
        {
            get => _textComment;
            set
            {
                _textComment = value;
                OnPropertyChanged(nameof(TextComment));
            }
        }


        public ReviewViewModel(int storeId = 0)
        {
            BarModel = new PlotModel
            {
                LegendPlacement = LegendPlacement.Outside,
                LegendPosition = LegendPosition.BottomCenter,
                LegendOrientation = LegendOrientation.Horizontal,
                LegendBorderThickness = 0,
                LegendPadding = 200,
                Title = "Rating Store",
                Background = OxyColor.Parse("#f5f5f3")
            };

            //BarModel = CreateBarChart(storeId).Result;

            _reviewServices = DependencyService.Get<IReviewServices>();

            Items = new ObservableCollection<ReviewDto>();

            Task.Run(async () => await ExecuteLoadItemsCommand(storeId));

            LoadDetailReview = new Command(async () => await LoadDetailReviews(storeId, _page, _pageSize));

            LoadReview = new Command(async () => await LoadReviews(storeId));

            ItemTapped = new Command<ReviewDto>(OnComment);
        }

        async void OnComment(ReviewDto reviewDto)
        {
            if (reviewDto == null)
            {
                return;
            }
            await Shell.Current.Navigation.PushAsync(new CommentPage());
        }

        async Task<SumaryRatingDto> LoadDetailReviews(int storeId, int page, int size)
        {
            var result = await _reviewServices.GetReviewByStoreId(storeId, page, size);

            size = size + 2;

            return result;
        }
        async Task LoadReviews(int storeId)
        {
            if (storeId == 0)
                return;
            IsBusy = true;
            try
            {
                Items.Clear();
                var items = await _reviewServices.GetReviewByStoreId(storeId, _page, _pageSize);

                foreach (var item in items.Collection)
                {
                    Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }

        async Task ExecuteLoadItemsCommand(int storeId)
        {
            if (storeId == 0)
                return;
            IsBusy = true;
            try
            {
                var items = await _reviewServices.GetReviewByStoreId(storeId, _page, 100);


                var resultRating = (double)items.SummaryRating;

                RatingSum = Math.Round(resultRating, 1);

                CategoryAxis xaxis = new CategoryAxis
                {
                    Position = AxisPosition.Left,
                    MajorGridlineStyle = LineStyle.Solid,
                    MinorGridlineStyle = LineStyle.Dot
                };
                xaxis.Labels.Add("1");
                xaxis.Labels.Add("2");
                xaxis.Labels.Add("3");
                xaxis.Labels.Add("4");
                xaxis.Labels.Add("5");

                LinearAxis yaxis = new LinearAxis
                {
                    Position = AxisPosition.Bottom,
                    MinimumPadding = 0,
                    MaximumPadding = 0.06,
                    AbsoluteMinimum = 0,
                    MajorGridlineStyle = LineStyle.Dot,
                    MinorGridlineStyle = LineStyle.Dot
                };

                var s1 = new BarSeries { };
                s1.Items.Add(new BarItem { Value = items.TotalOne ?? 0 });
                s1.Items.Add(new BarItem { Value = items.TotalTwo ?? 0 });
                s1.Items.Add(new BarItem { Value = items.TotalThree ?? 0 });
                s1.Items.Add(new BarItem { Value = items.TotalFour ?? 0 });
                s1.Items.Add(new BarItem { Value = items.TotalFive ?? 0 });

                BarModel.Series.Add(s1);
                BarModel.Axes.Add(xaxis);
                BarModel.Axes.Add(yaxis);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }

        internal void OnAppearing()
        {
            IsBusy = true;
        }
    }
}
