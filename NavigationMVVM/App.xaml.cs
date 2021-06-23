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

        public App()
        {
            _accountStore = new AccountStore();
            _navigationStore = new NavigationStore();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            INavigationService<HomeViewModel> homeNavigationService = CreateHomeNavigationService();
            homeNavigationService.Navigate();

            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_navigationStore)
            };
            MainWindow.Show();

            base.OnStartup(e);
        }

        private INavigationService<HomeViewModel> CreateHomeNavigationService()
        {
            //use LayoutNavigationService if you need the View to be in a Layout 
            return new LayoutNavigationService<HomeViewModel>(
                _navigationStore,
                () => new HomeViewModel(CreateLoginNavigationService()),
                CreateNavigationBarViewModel);
        }

        private INavigationService<LoginViewModel> CreateLoginNavigationService()
        {
            //use NavigationService if you don't need the View to be in a Layout 
            return new NavigationService<LoginViewModel>(
                _navigationStore,
                () => new LoginViewModel(_accountStore, CreateAccountNavigationService()));
        }

        private INavigationService<AccountViewModel> CreateAccountNavigationService()
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
