using StoreManagement.Models;
using StoreManagement.Views.WorkerViews;
using System;
using StoreManagement.DAL.Entities;

namespace StoreManagement.Presenters
{
    public class WorkerAddProductPresenter
    {
        private readonly IWorkerAddProductView _view;
        private readonly Model _model;
        public WorkerAddProductPresenter(IWorkerAddProductView view, Model model)
        {
            _view = view;
            _model = model;
           _view.SaveProduct += SaveProductHandler;
        }
        public Model Model => _model;
        private void SaveProductHandler(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            string productName = _view.ProductName;
            string type = _view.Type;
            string colour = _view.Colour;
            int price = int.Parse(_view.Price);
            string size = _view.ProductSize;
            int amount = int.Parse(_view.Amount);

            Clothes newClothes = new Clothes
            {
                Name = productName,
                Category = type,
                Colour = colour,
                Price = price,
                Size = size,
                Amount = amount
            };

            if (_model.AddClothesToDB(newClothes))
            {
                _view.ClearForm();
                _view.ShowMessage("Product added successfully.");
            }
            else
            {
                _view.ShowMessage("Error adding product.");
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
