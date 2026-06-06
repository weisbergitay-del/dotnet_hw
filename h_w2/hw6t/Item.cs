using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw6t
{
    internal class Item
    {

        public int Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }

        public Item(int code, string name, string description, int price)
        {
            this.Code = code;
            this.Name = name;
            this.Description = description;
            this.Price = price;
        }


    }
}
