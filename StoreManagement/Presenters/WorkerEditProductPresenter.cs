using StoreManagement.DAL.Entities;
using StoreManagement.Models;
using StoreManagement.Views.WorkerViews;
using System;

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
            if (!ValidateInput())
                return;

            int productId = _view.ProductId;
            string productName = _view.ProductName;
            string category = _view.Category;
            string colour = _view.Colour;
            int price = int.Parse(_view.Price);
            string productSize = _view.ProductSize;
            int amount = int.Parse(_view.Amount);

            Clothes newClothes = new Clothes
            {
                Id = productId,
                Name = productName,
                Category = category,
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
        private bool ValidateInput()
        {
            int temp;
            if (!int.TryParse(_view.Price, out temp))
            {
                _view.ShowMessage("Invalid price format.");
                return false;
            }
            if (!int.TryParse(_view.Amount, out temp))
            {
                _view.ShowMessage("Invalid amount format.");
                return false;
            }
            return true;
        }
    }
}
