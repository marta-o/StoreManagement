using StoreManagement.DAL.Entities;
using System.Collections.Generic;

namespace StoreManagement.Views.WorkerViews
{
    public interface IWorkerProductsView
    {
        void DisplayAllClothes(List<Clothes> clothes);
        Clothes GetSelectedClothes();
        void ShowMessage(string message);        
    }
}
