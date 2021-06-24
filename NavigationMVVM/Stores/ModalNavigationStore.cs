using NavigationMVVM.ViewModels;
using System;

namespace NavigationMVVM.Stores
{
    /// <summary>
    /// Stores the modal navigation state of the application
    /// </summary>
    public class ModalNavigationStore
    {
        //Raises a notification, so when the CurrentViewModel changes, the View will be changed
        public event Action CurrentViewModelChanged;

        private ViewModelBase _currentViewModel;

        //Determines what View we are currently on
        public ViewModelBase CurrentViewModel
        {
            get => _currentViewModel;
            set
            {
                _currentViewModel?.Dispose();
                _currentViewModel = value;
                OnCurrentViewModelChanged();
            }
        }
        public bool IsOpen => CurrentViewModel != null;

        //Closes the modal
        public void Close()
        {
            CurrentViewModel = null;
        }

        private void OnCurrentViewModelChanged()
        {
            CurrentViewModelChanged?.Invoke();
        }
    }
}
