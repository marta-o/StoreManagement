using StoreManagement.DAL.Entities;
using System.Collections.Generic;

namespace StoreManagement.Views.WorkerViews
{
    public interface IWorkerUsersView
    {
        void DisplayUsers(List<User> users);
        User GetSelectedUsers();
        void ShowMessage(string message);
    }
}
