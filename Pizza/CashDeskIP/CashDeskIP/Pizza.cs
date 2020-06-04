using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashDeskIP
{
    class Pizza
    {
        String name = "";
        double price = 0;
        public Pizza(String name, double price)
        {
            this.name = name;
            this.price = price;
        }

        public void SetName(String name)
        {
            this.name = name;
        }
        public void SetPrice(double price)
        {
            this.price=price;
        }
        public String GetName()
        {
            return name;
        }
        public double GetPrice()
        {
            return price;
        }
        
    }
}
