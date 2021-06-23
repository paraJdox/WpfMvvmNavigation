using NavigationMVVM.Stores;
using NavigationMVVM.ViewModels;
using System;

namespace NavigationMVVM.Services
{
    /// <summary>
    /// We set our current ViewModel here (if our ViewModel has parameters)
    /// </summary>
    /// <typeparam name="TParameter">The parameters required for the ViewModel that we want to navigate to</typeparam>
    /// <typeparam name="TViewModel">ViewModel that we want to navigate to</typeparam>
    public class ParameterNavigationService<TParameter, TViewModel>
        where TViewModel : ViewModelBase
        //To support multiple parameters, create an object to hold all the parameters, and use that object at the TParameter type   
    {
        private readonly NavigationStore _navigationStore;
        private readonly Func<TParameter, TViewModel> _createViewModel;

        public ParameterNavigationService(NavigationStore navigationStore, Func<TParameter, TViewModel> createViewModel)
        {
            _navigationStore = navigationStore;
            _createViewModel = createViewModel;
        }

        public void Navigate(TParameter parameter)
        {
            //Set the CurrentViewModel to a ViewModel that has parameter/s
            _navigationStore.CurrentViewModel = _createViewModel(parameter);
        }
    }
}
