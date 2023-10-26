using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4._1
{

    enum CupSize
    {
        Size, Small, Medium, Large
    }
    enum CoffeeType
    {
       Coffee, Latte, Mocha, Americano, Irish
    }

    enum Milk
    {
        Milk, Oat, Almond, Whole, None
    }
    abstract class Beverages
    {
        public string CustomerName { get; set; }
        public bool ToGo { get; set; }
        public CupSize CupSize { get; set; }
        


    }
    class Coffee : Beverages
    {
        public CoffeeType Type { get; set; }
        public bool Iced { get; set; }
        public int EspressoShots { get; set; }
        public Milk MilkType { get; set; }
    }
    
}
