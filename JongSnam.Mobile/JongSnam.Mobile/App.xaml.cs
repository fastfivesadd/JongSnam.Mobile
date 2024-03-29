﻿using JongSnam.Mobile.Constants;
using JongSnam.Mobile.Models;
using JongSnam.Mobile.Services;
using JongSnam.Mobile.Services.Implementations;
using JongSnam.Mobile.Services.Interfaces;
using JongSnam.Mobile.SqliteRepository;
using JongSnam.Mobile.SqliteRepository.Interfaces;
using JongSnam.Mobile.Views;
using Xamarin.Essentials;
using Xamarin.Forms;

[assembly: ExportFont("fa-solid-900.ttf")]
[assembly: ExportFont("fa-regular-400.ttf", Alias = "FontAwesome")]
[assembly: ExportFont("materialdesignicons-webfont.ttf", Alias = "MyIcon")]
namespace JongSnam.Mobile
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<IRepository<UserModel>, Repository<UserModel>>();
            DependencyService.Register<IConnectivityService, ConnectivityService>();
            DependencyService.Register<IConfigurationService, ConfigurationService>();
            DependencyService.Register<IFieldServices, FieldServices>();
            DependencyService.Register<IPaymentServices, PaymentServices>();
            DependencyService.Register<IReservationServices, ReservationServices>();
            DependencyService.Register<IReviewServices, ReviewServices>();
            DependencyService.Register<IStoreServices, StoreServices>();
            DependencyService.Register<IUsersServices, UsersServices>();
            DependencyService.Register<IAddressServices, AddressServices>();
            DependencyService.Register<IEnumServices, EnumServices>();
            DependencyService.Register<IAuthenticationServices, AuthenticationServices>();
            DependencyService.Register<MockDataStore>();

            var userType = Preferences.Get(AuthorizeConstants.UserTypeKey, string.Empty);

            if (userType == "Owner")
            {
                MainPage = new AppShell();
            }
            else if(userType == "Customer")
            {
                MainPage = new AppShellCustomer();
            }
            else
            {
                Application.Current.MainPage = new NavigationPage(new LoginPage());
            }

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
