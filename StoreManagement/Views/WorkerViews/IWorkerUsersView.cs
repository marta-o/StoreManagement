using StoreManagement.DAL.Entities;
using System;
using System.Collections.Generic;

namespace StoreManagement.Views.WorkerViews
{
    public interface IWorkerUsersView
    {
        void DisplayUsers(List<User> users);
        User GetSelectedUsers();
        event EventHandler DeleteUser;
        void ShowMessage(string message);
    }
}
