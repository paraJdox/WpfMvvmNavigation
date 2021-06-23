using NavigationMVVM.Models;
using System;

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
                CurrentAccountChanged?.Invoke();
            }
        }
        public bool IsLoggedIn => CurrentAccount != null;

        public event Action CurrentAccountChanged;

        public void Logout()
        {
            CurrentAccount = null;
        }
    }
}
