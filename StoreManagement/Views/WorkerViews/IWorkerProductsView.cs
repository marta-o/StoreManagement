using StoreManagement.DAL.Entities;
using System;
using System.Collections.Generic;

namespace StoreManagement.Views.WorkerViews
{
    public interface IWorkerProductsView
    {
        void DisplayAllClothes(List<Clothes> clothes);
        Clothes GetSelectedClothes();
        event EventHandler DeleteClothes;
        void ShowMessage(string message);        
    }
}
