﻿using Prism;
using Prism.Ioc;
using MyVet.Prism.ViewModels;
using MyVet.Prism.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MyVet.Common.Services;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace MyVet.Prism
{
    public partial class App
    {
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MTM3Njg0QDMxMzcyZTMyMmUzMGUvQlg3Tnk5ODRGQ01pbzNnWmEyWHdWcExaaUVOQ0FKODZGNDFpekRtd2M9");
            InitializeComponent();

            await NavigationService.NavigateAsync("NavigationPage/LoginPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<IApiService, ApiService>();
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<LoginPage, LoginPageViewModel>();
            containerRegistry.RegisterForNavigation<PetsPage, PetsPageViewModel>();
            containerRegistry.RegisterForNavigation<PetPage, PetPageViewModel>();
containerRegistry.RegisterForNavigation<HistoriesPage, HistoriesPageViewModel>();        containerRegistry.RegisterForNavigation<HistoryPage, HistoryPageViewModel>();containerRegistry.RegisterForNavigation<PetTabbedPage, PetTabbedPageViewModel>(); containerRegistry.RegisterForNavigation<VeterinaryMasterDetailPage, VeterinaryMasterDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<AgendaPage, AgendaPageViewModel>();
            containerRegistry.RegisterForNavigation<MapPage, MapPageViewModel>();
            containerRegistry.RegisterForNavigation<ProfilePage, ProfilePageViewModel>();
        }
    }
}
