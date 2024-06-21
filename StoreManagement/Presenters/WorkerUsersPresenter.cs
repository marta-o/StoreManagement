using StoreManagement.Models;
using StoreManagement.Views.WorkerViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement.Presenters
{
    public class WorkerUsersPresenter
    {
        private IWorkerUsersView _view;
        private Model _model;

        public WorkerUsersPresenter(IWorkerUsersView view, Model model)
        {
            _view = view;
            _model = model;
        }
        public Model Model => _model;
    }
}
