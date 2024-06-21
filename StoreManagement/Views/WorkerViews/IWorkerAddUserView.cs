using System;

namespace StoreManagement.Views.WorkerViews
{
    public interface IWorkerAddUserView
    {
        string UserName { get; }
        string Surname { get; }
        string Address { get; }
        string Phone { get; }
        string Username { get; }
        string Password { get; }
        event EventHandler AddUser;
        void ClearFields();
        void ShowMessage(string message);
    }
}
