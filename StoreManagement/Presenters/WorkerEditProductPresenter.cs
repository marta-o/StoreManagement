using StoreManagement.DAL.Entities;
using StoreManagement.Models;
using StoreManagement.Views.WorkerViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement.Presenters
{
    public class WorkerEditProductPresenter
    {
        private readonly IWorkerEditProductView _view;
        private readonly Model _model;

        public WorkerEditProductPresenter(IWorkerEditProductView view, Model model)
        {
            _view = view;
            _model = model;
            _view.SaveProduct += SaveProduct;
        }
        public Model Model => _model;
        private void SaveProduct(object sender, EventArgs e)
        {
            int productId = _view.ProductId;
            string productName = _view.ProductName;
            string type = _view.Type;
            string colour = _view.Colour;
            int price = _view.Price;
            string productSize = _view.ProductSize;
            int amount = _view.Amount;

            Clothes newClothes = new Clothes
            {
                Id = productId,
                Name = productName,
                Category = type,
                Colour = colour,
                Price = price,
                Size = productSize,
                Amount = amount
            };

            if (_model.EditClothesToDB(newClothes))
            {
                _view.ClearForm();
                _view.ShowMessage("Product changed successfully.");
            }
            else
            {
                _view.ShowMessage("Error changing product.");
            }
        }
    }
}
