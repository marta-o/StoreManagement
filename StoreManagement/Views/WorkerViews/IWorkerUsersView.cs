using StoreManagement.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement.Views.WorkerViews
{
    public interface IWorkerUsersView
    {
        void DisplayAllUsers(List<User> users);
        User GetSelectedUsers();
        void ShowMessage(string message);
    }
}
