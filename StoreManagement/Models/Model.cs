using System.Collections.Generic;
using System.Linq;
using StoreManagement.DAL.Entities;
using StoreManagement.DAL.Repositories;
using System.Collections.ObjectModel;

namespace StoreManagement.Models
{
    public class Model
    {
        public ObservableCollection<User> Users { get; set; } = new ObservableCollection<User>();
        public ObservableCollection<Clothes> Clothes { get; set; } = new ObservableCollection<Clothes>();
        public ObservableCollection<Order> Orders { get; set; } = new ObservableCollection<Order>();
        public List<Clothes> CartItems { get; set; } = new List<Clothes>();

        public Model()
        {
            LoadAllData();
        }
        private void LoadAllData()
        {
            var users = UsersRepository.LoadAllUsers();
            foreach (var user in users)
                Users.Add(user);

            var clothes = ClothesRepository.LoadAllClothes();
            foreach (var cloth in clothes)
                Clothes.Add(cloth);

            var orders = OrdersRepository.LoadAllOrders();
            foreach (var order in orders)
                Orders.Add(order);
        }
        public bool AddUserToDB(User user)
        {
            if (!Users.Contains(user) && UsersRepository.AddNewUserToDB(user))
            {
                Users.Add(user);
                return true;
            }
            return false;
        }
        public bool DeleteUser(User user)
        {
            var existingUser = Users.FirstOrDefault(o => o.Id == user.Id);
            if (existingUser != null)
            {
                if (UsersRepository.DeleteUserInDB(existingUser))
                {
                    Users.Remove(existingUser);
                    return true;
                }
            }
            return false;
        }
        public bool AddClothesToDB(Clothes clothes)
        {
            if (!Clothes.Contains(clothes) && ClothesRepository.AddNewClothesToDB(clothes))
            {
                Clothes.Add(clothes);
                return true;
            }
            return false;
        }
        public bool EditClothesToDB(Clothes clothes)
        {
            var existingClothes = Clothes.FirstOrDefault(c => c.Id == clothes.Id);
            if (existingClothes != null)
            {
                if (ClothesRepository.UpdateClothes(clothes))
                {
                    existingClothes.Name = clothes.Name;
                    existingClothes.Category = clothes.Category;
                    existingClothes.Colour = clothes.Colour;
                    existingClothes.Price = clothes.Price;
                    existingClothes.Size = clothes.Size;
                    existingClothes.Amount = clothes.Amount;
                    return true;
                }
            }
            return false;
        }
        public bool DeleteClothes(Clothes clothes)
        {
            var existingClothes = Clothes.FirstOrDefault(o => o.Id == clothes.Id);
            if (existingClothes != null)
            {
                if (ClothesRepository.DeleteClothesInDB(existingClothes))
                {
                    Clothes.Remove(existingClothes);
                    return true;
                }
            }
            return false;
        }
        public bool AddOrderToDB(Order order)
        {
            if (!Orders.Contains(order) && OrdersRepository.AddNewOrderToDB(order))
            {
                Orders.Add(order);
                return true;
            }
            return false;
        }
        public bool DeleteOrder(Order order)
        {
            var existingOrder = Orders.FirstOrDefault(o => o.Id == order.Id);
            if (existingOrder != null)
            {
                if (OrdersRepository.DeleteOrderInDB(existingOrder))
                {
                    Orders.Remove(existingOrder);
                    return true;
                }
            }
            return false;
        }
        public List<Clothes> LoadAllClothes()
        {
            return ClothesRepository.LoadAllClothes();
        }
        public List<User> LoadAllUsers()
        {
            return UsersRepository.LoadAllUsers();
        }
        public List<Order> LoadAllOrders()
        {
            return OrdersRepository.LoadAllOrders();
        }
        public List<Clothes> LoadAvailableClothes()
        {
            return ClothesRepository.LoadAvailableClothes();
        }
        public List<Order> LoadUsersOrders(int clientId)
        {
            return OrdersRepository.LoadUsersOrders(clientId);
        }
        public void UpdateClothes(Clothes clothes)
        {
            ClothesRepository.UpdateClothes(clothes);
        }
        public void AddToCart(Clothes clothes)
        {
            CartItems.Add(clothes);
        }
        public List<Clothes> GetCartItems()
        {
            return CartItems;
        }
        public void RemoveFromCart(Clothes clothes)
        {
            CartItems.Remove(clothes);
        }
        public void ClearCart()
        {
            CartItems.Clear();
        }
        public void RestoreCartItems()
        {
            foreach (var clothes in CartItems)
            {
                clothes.Amount++;
                UpdateClothes(clothes);
            }
            ClearCart();
        }
        public bool IsUsernameTaken(string username)
        {
            return UsersRepository.IsUsernameInDB(username);
        }
    }
}