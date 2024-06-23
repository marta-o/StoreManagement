using StoreManagement.DAL.Entities;
using StoreManagement.Models;
using StoreManagement.Views.WorkerViews;
using System;
using System.Windows.Forms.Design;

namespace StoreManagement.Presenters
{
    public class WorkerUsersPresenter
    {
        private readonly IWorkerUsersView _view;
        private readonly Model _model;

        public WorkerUsersPresenter(IWorkerUsersView view, Model model)
        {
            _view = view;
            _model = model;
            _view.DeleteUser += DeleteUserHandler;
            LoadUsers();
        }
        public Model Model => _model;
        private void LoadUsers()
        {
            var users = _model.LoadAllUsers();
            _view.DisplayUsers(users);
        }
        private void DeleteUserHandler(object sender, EventArgs e)
        {
            try
            {
                User user = _view.GetSelectedUsers();
                if (user != null && _model.DeleteUser(user))
                {
                    _view.ShowMessage("User deleted.");
                    LoadUsers();
                }
            }
            catch (InvalidOperationException ex)
            {
                _view.ShowMessage(ex.Message);
            }
            catch (Exception ex)
            {
                _view.ShowMessage("An unexpected error occurred while deleting the user.");
            }
        }
    }
}
