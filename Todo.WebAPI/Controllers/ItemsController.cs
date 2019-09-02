using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Todo.Domain.Interfaces;
using Todo.Domain.Models;
using Todo.WebAPI.Requests;

namespace Todo.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private IItemCommands _itemCommands;
        private IItemQueries _itemQueries;

        public ItemsController(IItemCommands itemCommands, IItemQueries itemQueries)
        {
            _itemCommands = itemCommands;
            _itemQueries = itemQueries;
        }

        // GET: api/Items
        [HttpGet]
        public ActionResult<IList<Item>> GetItems()
        {
            throw new NotImplementedException();
        }

        // GET: api/Items/5
        [HttpGet("{id}", Name = "Get")]
        public ActionResult<Item> GetItem(int id)
        {
            throw new NotImplementedException();
        }

        // POST: api/Items
        [HttpPost]
        public void CreateItem([FromBody] CreateItemRequest itemRequest)
        {
            throw new NotImplementedException();
        }

        // PUT: api/Items/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] UpdateItemRequest itemRequest)
        {
            throw new NotImplementedException();
        }

        // DELETE: api/Items/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
