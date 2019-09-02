using System;
using System.Collections.Generic;
using System.Text;
using Todo.Domain.Models;

namespace Todo.Domain.Interfaces
{
    public interface IItemDataAccess
    {
        Item GetItem();
        void CreateItem();
        void UpdateItem(Item item);
    }
}
