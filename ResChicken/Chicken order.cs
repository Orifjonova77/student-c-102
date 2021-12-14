using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResChicken
{
    class Chicken_order
    {
    private int quantity;

        public Chicken_order(int quantity)
        {
            this.quantity = quantity;
        }
        public int GetQuantity()
        {
            return quantity;
        }
        public void CutUp()
        {
        }
        public void Cook()
        {
        }
    }
}
