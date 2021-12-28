using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaNet.Model.Entities
{
    class Stock
    {
        public int Id { get; set; }
        public int MinLimit { get; set; }
        public int Cantity { get; set; }
        public DateTime DueDate { get; set; }
        public ICollection<Product> ListProducts { get; set; }

    }
}
