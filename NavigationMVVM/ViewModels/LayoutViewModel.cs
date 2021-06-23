namespace NavigationMVVM.ViewModels
{
    public class LayoutViewModel : ViewModelBase
    {
        public LayoutViewModel(NavigationBarViewModel navigationBarViewModel, ViewModelBase contentViewModel)
        {
            NavigationBarViewModel = navigationBarViewModel;
            ContentViewModel = contentViewModel;
        }

        public NavigationBarViewModel NavigationBarViewModel { get; }
        public ViewModelBase ContentViewModel { get; } // the ViewModel(page) that is inside the LayoutViewModel

        //disposes all child viewmodels that are on a viewmodel
        public override void Dispose()
        {
            NavigationBarViewModel.Dispose();
            ContentViewModel.Dispose();
            base.Dispose();
        }
    }
}
