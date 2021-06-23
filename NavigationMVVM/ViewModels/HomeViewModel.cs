using NavigationMVVM.Commands;
using NavigationMVVM.Services;
using System.Windows.Input;

namespace NavigationMVVM.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        public string WelcomeMessage => "Welcome to my application.";

        public NavigationBarViewModel NavigationBarViewModel { get; }

        public ICommand NavigateAccountCommand { get; }

        public HomeViewModel(NavigationBarViewModel navigationBarViewModel, NavigationService<LoginViewModel> loginNavigationService)
        {
            NavigationBarViewModel = navigationBarViewModel;

            NavigateAccountCommand = new NavigateCommand<LoginViewModel>(loginNavigationService);
        }
    }
}
