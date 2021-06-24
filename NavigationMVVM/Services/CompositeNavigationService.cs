using System.Collections.Generic;

namespace NavigationMVVM.Services
{
    /// <summary>
    /// This does multiple navigations at once (e.g. closing a modal, then navigating to a different page)
    /// </summary>
    public class CompositeNavigationService : INavigationService
    {
        private readonly IEnumerable<INavigationService> _navigationServices;

        public CompositeNavigationService(params INavigationService[] navigationServices)
        {
            _navigationServices = navigationServices;
        }

        public void Navigate()
        {
            foreach (INavigationService navigationService in _navigationServices)
            {
                navigationService.Navigate();
            }
        }
    }
}
