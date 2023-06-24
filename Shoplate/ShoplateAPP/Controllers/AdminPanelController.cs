using Microsoft.AspNetCore.Mvc;
using ShoplateAPP.Models;
using ShoplateAPP.Repositories;

namespace ShoplateAPP.Controllers
{
    public class AdminPanelController : Controller
    {

        private readonly IItemRepository _itemrepository;
        private readonly IUserRepository _userrepository;


        public AdminPanelController(IItemRepository iitemRepository, IUserRepository iuserrepository)
        {
            _itemrepository = iitemRepository;
            _userrepository = iuserrepository;
        }

        public IActionResult Items(string sortOrder, string minPrice, string maxPrice, string name)
        {
            IEnumerable<Item> items = _itemrepository.GetAll();

            if (!string.IsNullOrEmpty(name))
            {
                items = items.Where(item => item.Name.Contains(name));
            }

            if (!string.IsNullOrEmpty(minPrice) && decimal.TryParse(minPrice, out decimal minPriceValue))
            {
                items = items.Where(item => item.Price >= minPriceValue);
            }

            if (!string.IsNullOrEmpty(maxPrice) && decimal.TryParse(maxPrice, out decimal maxPriceValue))
            {
                items = items.Where(item => item.Price <= maxPriceValue);
            }

            if (!string.IsNullOrEmpty(sortOrder))
            {
                if (sortOrder == "ascending")
                {
                    items = items.OrderBy(item => item.Price);
                }
                else if (sortOrder == "descending")
                {
                    items = items.OrderByDescending(item => item.Price);
                }
            }

            return View(items);
        }

        public IActionResult ChangeDetails(int id)
        {
            Item item = _itemrepository.GetItem(id);
            return View(item);
        }

        [HttpPost]
        public IActionResult ChangeDetails(int id, string name, string description, string image, decimal price)
        {
            if (ModelState.IsValid)
            {
                _itemrepository.ChangeItemData(id, name, description, image, price);
                return RedirectToAction("Items");
            }

            return View("items");
        }

        public IActionResult AddItem()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddItem(int id, string name, string description, string image, decimal price)
        {
            if (ModelState.IsValid)
            {
                _itemrepository.AddItem(id,name,description,image,price);
                return RedirectToAction("Items");
            }

            return View("items");
        }

        [HttpPost]
        public IActionResult DeleteItem(int id) 
        {
            _itemrepository.DeleteItem(id);
            return RedirectToAction("Items");
        }

    }
}
