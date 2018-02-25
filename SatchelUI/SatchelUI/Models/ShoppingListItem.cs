using System;
using System.Collections.Generic;
using System.Text;

namespace SatchelUI.Models
{
    class ShoppingListItem
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool Purchased { get; set; }
    }
}
