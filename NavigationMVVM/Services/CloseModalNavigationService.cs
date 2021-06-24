using NavigationMVVM.Stores;

namespace NavigationMVVM.Services
{
    public class CloseModalNavigationService : INavigationService
    {
        private readonly ModalNavigationStore _modalNavigationStore;

        public CloseModalNavigationService(ModalNavigationStore modalNavigationStore)
        {
            _modalNavigationStore = modalNavigationStore;
        }

        //Closes the modal dialog
        public void Navigate()
        {
            _modalNavigationStore.Close();
        }
    }
}
