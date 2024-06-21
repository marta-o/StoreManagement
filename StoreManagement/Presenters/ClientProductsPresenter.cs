using StoreManagement.Views.ClientViews;
using StoreManagement.Models;

namespace StoreManagement.Presenters
{
    public class ClientProductsPresenter
    {
        private readonly IClientProductsView _view;
        private readonly Model _model;
        private readonly int _clientId;
        public ClientProductsPresenter(IClientProductsView clientProductsView, Model model, int clientId)
        {
            _view = clientProductsView;
            _model = model;
            _clientId = clientId; 
            LoadAvailableClothes();  
        }
        public Model Model => _model;
        public void LoadAvailableClothes()
        {
            _view.DisplayAvailableClothes(_model.LoadAvailableClothes());
        }
        public void AddToCart()
        { 
            var selectedClothes = _view.GetSelectedClothes();
            if (selectedClothes != null)
            {
                _model.AddToCart(selectedClothes);
                selectedClothes.Amount--;
                _model.UpdateClothes(selectedClothes);
                _view.ShowMessage("Item added to cart");
            }
            LoadAvailableClothes();
        }
        public void Logout()
        {
            _model.RestoreCartItems();
        }
    }
}
