using StoreManagement.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement.Views.WorkerViews
{
    public  interface IWorkerEditProductView
    {
        int ProductId { get; }
        string ProductName { get; }
        string Type { get; }
        string Colour { get; }
        int Price { get; }
        string ProductSize { get; }
        int Amount { get; }
        event EventHandler SaveProduct;
        void ShowMessage(string message);
        void PopulateForm(Clothes clothes);
        void ClearForm();
    }
}
