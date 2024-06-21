using System;

namespace StoreManagement.Views.WorkerViews
{
    public interface IWorkerAddProductView
    {
        string ProductName { get; }
        string Type { get; }  
        string Colour { get; }
        string Price { get; }  
        string ProductSize { get; }
        string Amount { get; }
        event EventHandler SaveProduct;
        void ShowMessage(string message);
        void ClearForm();
    }
}
