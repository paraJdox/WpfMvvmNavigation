using NavigationMVVM.Models;

namespace NavigationMVVM.Stores
{
    /// <summary>
    /// This is where the current account for the application is stored
    /// </summary>
    public class AccountStore
    {
        private Account _currentAccount;

        public Account CurrentAccount
        {
            get => _currentAccount;
            set
            {
                _currentAccount = value;
            }
        }

        public bool IsLoggedIn => CurrentAccount != null;
    }
}
