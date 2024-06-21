using StoreManagement.DAL.Entities;
using System.Collections.Generic;

namespace StoreManagement.Views.ClientViews
{
    public interface IClientProductsView
    {
        void DisplayAvailableClothes(List<Clothes> clothes);
        Clothes GetSelectedClothes();
        void ShowMessage(string message);
    }
}
