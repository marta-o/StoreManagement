using System;

namespace StoreManagement.Views.StartViews
{
    public interface IAddNewUserView
    {
        string UserName { get; }
        string Surname { get; }
        string Address { get; }
        string Phone { get; }
        string Username { get; }
        string Password { get; }
        string Type { get; }
        event EventHandler AddUser;
        void ShowMessage(string message);
    }
}
