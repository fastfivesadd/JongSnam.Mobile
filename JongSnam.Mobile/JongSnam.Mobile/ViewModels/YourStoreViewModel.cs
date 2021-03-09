﻿using JongSnam.Mobile.Models;
using JongSnam.Mobile.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace JongSnam.Mobile.ViewModels
{
    public class YourStoreViewModel : BaseViewModel
    {
        public ObservableCollection<Item> Items { get; }

        public Command LoadItemsCommand { get; }

        public Command AddStoreCommand { get; }

        public Command UpdateStoreCommand { get; }

        public Command YourFieldCommand { get; }

        public YourStoreViewModel()
        {
            Items = new ObservableCollection<Item>();

            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());

            AddStoreCommand = new Command(OnAddStore);

            UpdateStoreCommand = new Command<Item>(OnUpdateStore);

            YourFieldCommand = new Command<Item>(OnYourField);
        }

        async Task ExecuteLoadItemsCommand()
        {
            IsBusy = true;

            try
            {
                Items.Clear();

                var items = new ObservableCollection<Item> {
                    new Item{
                        Text = "The goals",
                        Description = "ggg"
                    },
                    new Item
                    {
                        Text = "ร้าน Happy มอใหม่",
                        Description = "gfgasdf"
                    },
                    new Item
                    {
                        Text = "ร้าน Happy ท่าขอนยาง",
                        Description = "gfgasdf"
                    },
                    new Item
                    {
                        Text = "Soccer pro บางนา",
                        Description = "gfgasdf"
                    }
                };

                foreach (var item in items)
                {
                    Items.Add(item);
                }
                
            }
            catch
            {

            }
            finally
            {
                IsBusy = false;
            }
        }

        async void OnAddStore(object obj)
        {
            await Shell.Current.GoToAsync(nameof(AddStorePage));
        }

        async void OnUpdateStore(Item item)
        {
            await Shell.Current.GoToAsync(nameof(UpdateStorePage));
        }
        async void OnYourField(Item item)
        {

            await Shell.Current.GoToAsync(nameof(YourFieldPage));
        }


        public void OnAppearing()
        {
            IsBusy = true;
        }
    }
}
