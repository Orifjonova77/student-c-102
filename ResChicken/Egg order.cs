using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResChicken
{
    class Egg_order
    {
     private static Random rnd = new Random();
        private int quantity;
        private int quality = rnd.Next(101);
        private static int qualityCounter = 0;
        public Egg_order(int quantity)
        {
            this.quantity = quantity;
            qualityCounter++;
        }
        public int GetQuantity()
        {
            return quantity;
        }
        public int? GetQuality()
        {

            if (qualityCounter % 2 == 1)
            {
                return quality;
            }
            else
            {
                return null;
            }
        }
        public void Crack()
        {
            if (GetQuality() < 25)
                throw new Exception("Качество:" + GetQuality() + " яйцо испорчено!");
        }
        public void DiscardShell()
        {
        }
        public void Cook()
        {
        }
    }
}