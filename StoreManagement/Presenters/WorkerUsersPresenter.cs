using StoreManagement.Models;
using StoreManagement.Views.WorkerViews;

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
            _view.DisplayUsers(_model.LoadAllUsers());
        }
        public Model Model => _model;
    }
}
