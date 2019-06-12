using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiTarea2.Models;

namespace WebApiTarea2.Services
{
    public interface IInventarioServices
    {
        InventarioItems AddInventarioItems(InventarioItems items);

        Dictionary<string, InventarioItems> GetInventorioItems();
    }
}
