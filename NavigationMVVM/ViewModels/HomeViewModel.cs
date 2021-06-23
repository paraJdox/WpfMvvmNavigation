using NavigationMVVM.Commands;
using NavigationMVVM.Services;
using System.Windows.Input;

namespace NavigationMVVM.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        public string WelcomeMessage => "Welcome to my application.";

        public ICommand NavigateAccountCommand { get; }

        public HomeViewModel(INavigationService<LoginViewModel> loginNavigationService)
        {
            NavigateAccountCommand = new NavigateCommand<LoginViewModel>(loginNavigationService);
        }
    }
}
