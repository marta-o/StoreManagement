using StoreManagement.DAL.Entities;
using StoreManagement.Models;
using StoreManagement.Views.WorkerViews;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StoreManagement.Presenters
{
    public class WorkerProductsPresenter
    {
        private readonly IWorkerProductsView _view;
        private readonly Model _model;
        public WorkerProductsPresenter(IWorkerProductsView view, Model model)
        {
            _view = view;
            _model = model;
            _view.DeleteClothes += DeleteClothesHandler;
            LoadClothes();
        }
        public Model Model => _model;
        public void LoadClothes()
        {
            var clothes = _model.LoadAllClothes();
            _view.DisplayAllClothes(clothes);
        }
        private void DeleteClothesHandler(object sender, EventArgs e)
        {
            try
            {
                Clothes clothes = _view.GetSelectedClothes();
                if (clothes != null && _model.DeleteClothes(clothes))
                {
                    _view.ShowMessage("Clothes deleted.");
                    LoadClothes();
                }
            }
            catch (InvalidOperationException ex)
            {
                _view.ShowMessage(ex.Message);
            }
            catch (Exception ex)
            {
                _view.ShowMessage("An unexpected error occurred while deleting the clothes.");
            }
        }
        public List<Clothes> FilterClothes(string type, string color, string size, string amount)
        {
            var filteredClothes = _model.LoadAllClothes()
                .Where(c =>
                    (string.IsNullOrEmpty(type) || c.Category == type) &&
                    (string.IsNullOrEmpty(color) || c.Colour == color) &&
                    (string.IsNullOrEmpty(size) || c.Size == size) &&
                    (string.IsNullOrEmpty(amount) || c.Amount == int.Parse(amount)))
                .ToList();

            return filteredClothes;
        }
    }
}
