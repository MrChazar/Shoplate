using ShoplateAPP.Models;

namespace ShoplateAPP.Repositories
{
    public interface IItemRepository
    {
        IEnumerable<Item> GetAll();

        Item? GetItem(int id);

        IEnumerable<Item> GetEveryUnordered();

        IEnumerable<Item> SearchItemByName(string name); 

        void AddItem(int id, string name, string description, string image, decimal price);

        void DeleteItem(int id);

        public void ChangeItemData(int id, string name, string description, string image, decimal price);

    }
}
