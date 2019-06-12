using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApiTarea2.Models;
using WebApiTarea2.Services;


namespace WebApiTarea2.Controllers
{
    [Route("v1/")]
    [ApiController]
    public class InventarioController : ControllerBase 
    {
        private readonly IInventoryServices _services;

        public InventarioController(IInventoryServices services) {

            _services = services;
        }

        [HttpPost]
        [Route("AddInventarioItems")]
        public ActionResult<InventarioItems> AddInventarioItems(InventarioItems items)
        {
            var inventarioItems = _services.AddInventorioItems(items);

            if (inventarioItems == null)
            {
                return NotFound();
            }
            return inventarioItems;
        }
        [HttpGet]
        [Route ("GetInventarioItems")]
        public ActionResult<Dictionary<string, InventarioItems>> GetInventorioItems()
        {
            var inventarioItems = _services.GetInventorioItems();

            if (inventarioItems.Count == 0)
            {
                return NotFound();

            }
        }
    }
}