using WebApiTarea2.Models;

namespace WebApiTarea2.Controllers
{
    internal interface IInventoryServices
    {
        object AddInventorioItems(InventarioItems items);
    }
}