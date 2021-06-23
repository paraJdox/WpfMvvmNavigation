using NavigationMVVM.Commands;
using NavigationMVVM.Services;
using NavigationMVVM.Stores;
using System.Windows.Input;

namespace NavigationMVVM.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        public string WelcomeMessage => "Welcome to my application.";

        public ICommand NavigateAccountCommand { get; }

        public HomeViewModel(AccountStore accountStore, NavigationStore navigationStore)
        {
            NavigateAccountCommand = new NavigateCommand<LoginViewModel>(new NavigationService<LoginViewModel>(
                navigationStore,
                () => new LoginViewModel(accountStore, navigationStore)));
        }
    }
}
