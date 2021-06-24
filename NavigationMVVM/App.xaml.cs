using NavigationMVVM.Services;
using NavigationMVVM.Stores;
using NavigationMVVM.ViewModels;
using System.Windows;

namespace NavigationMVVM
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly AccountStore _accountStore; //represents the account store that we will be using all throughout the application
        private readonly NavigationStore _navigationStore;
        private readonly ModalNavigationStore _modalNavigationStore;

        public App()
        {
            _accountStore = new AccountStore();
            _navigationStore = new NavigationStore();
            _modalNavigationStore = new ModalNavigationStore();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            INavigationService homeNavigationService = CreateHomeNavigationService();
            homeNavigationService.Navigate();

            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_navigationStore, _modalNavigationStore)
            };
            MainWindow.Show();

            base.OnStartup(e);
        }

        private INavigationService CreateHomeNavigationService()
        {
            //use LayoutNavigationService if you need the View to be in a Layout 
            return new LayoutNavigationService<HomeViewModel>(
                _navigationStore,
                () => new HomeViewModel(CreateLoginNavigationService()),
                CreateNavigationBarViewModel);
        }

        private INavigationService CreateLoginNavigationService()
        {
            CompositeNavigationService navigationService = new CompositeNavigationService(
                 new CloseModalNavigationService(_modalNavigationStore),
                 CreateAccountNavigationService()
                );

            return new ModalNavigationService<LoginViewModel>(
                _modalNavigationStore,
                () => new LoginViewModel(_accountStore, navigationService));
        }

        private INavigationService CreateAccountNavigationService()
        {
            //use LayoutNavigationService if you need the View to be in a Layout 
            return new LayoutNavigationService<AccountViewModel>(
                 _navigationStore,
                 () => new AccountViewModel(_accountStore, CreateHomeNavigationService()),
                 CreateNavigationBarViewModel);
        }

        private NavigationBarViewModel CreateNavigationBarViewModel()
        {
            return new NavigationBarViewModel(
                           _accountStore,
                           CreateHomeNavigationService(),
                           CreateAccountNavigationService(),
                           CreateLoginNavigationService()
                       );
        }
    }
}
