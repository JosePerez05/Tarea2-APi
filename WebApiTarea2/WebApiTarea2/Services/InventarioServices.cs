using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiTarea2.Models;

namespace WebApiTarea2.Services
{
    public class InventarioServices : IInventarioServices
    {
        private readonly Dictionary<string, InventarioItems> _inventarioItems;

        public InventarioServices() {
            _inventarioItems = new Dictionary<string, InventarioItems>();
        }
        public InventarioItems AddInventarioItems(InventarioItems items)
        {
            _inventarioItems.Add(items.NombrePro, items);

            return items;
        }

        public Dictionary<string, InventarioItems> GetInventorioItems()
        {
            return _inventarioItems;
        }
    }
}
