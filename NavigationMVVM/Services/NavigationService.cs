using NavigationMVVM.Stores;
using NavigationMVVM.ViewModels;
using System;

namespace NavigationMVVM.Services
{
    /// <summary>
    /// All Navigation can just go through this service and call Navigate() 
    /// to set the _navigationStore's CurrentViewModel
    /// to whatever ViewModel that we want to create when we instantiated this NavigationService
    /// 
    /// (the Func<TViewModel> createViewModel) is the ViewModel that we want to create
    /// </summary>
    public class NavigationService<TViewModel> : INavigationService<TViewModel> where TViewModel : ViewModelBase

    {
        private readonly NavigationStore _navigationStore;
        private readonly Func<TViewModel> _createViewModel;

        public NavigationService(NavigationStore navigationStore, Func<TViewModel> createViewModel)
        {
            _navigationStore = navigationStore;
            _createViewModel = createViewModel;
        }

        public void Navigate()
        {
            _navigationStore.CurrentViewModel = _createViewModel();
        }
    }
}
