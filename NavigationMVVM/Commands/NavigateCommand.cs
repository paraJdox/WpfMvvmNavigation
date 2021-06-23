using NavigationMVVM.Services;
using NavigationMVVM.ViewModels;

namespace NavigationMVVM.Commands
{
    public class NavigateCommand<TViewModel> : CommandBase
        where TViewModel : ViewModelBase
    {
        private readonly NavigationService<TViewModel> _navigationService;

        public NavigateCommand(NavigationService<TViewModel> navigationService)
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
