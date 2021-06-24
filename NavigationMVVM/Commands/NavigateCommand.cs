using NavigationMVVM.Services;

namespace NavigationMVVM.Commands
{
    public class NavigateCommand : CommandBase
    {
        private readonly INavigationService _navigationService;

        public NavigateCommand(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public override void Execute(object parameter)
        {
            //This will navigate to whatever ViewModel is configured in our _navigationService callback (_createViewModel)
            _navigationService.Navigate();
        }
    }
}
