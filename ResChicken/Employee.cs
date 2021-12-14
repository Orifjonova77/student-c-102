using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResChicken
{
    class Employee
    {
        public Employee() { }
        private Object R_Zakaz;
        private int orderCounter = 1;
        private bool checkBtnPrepare = false, checkOrder = false;
        public Object NewRequest(int quantity, string item)
        {
            if (quantity <= 0)
                throw new Exception("Вы ввели не положительное число!");
            if (orderCounter % 3 == 0)
            {
                if (item == "chicken")
                    item = "egg";
                else
                    item = "chicken";
            }
            checkBtnPrepare = true;
            checkOrder = true;
            orderCounter++;
            if (item == "chicken")
            {
                Chicken_order chicken = new Chicken_order(quantity);
                R_Zakaz = chicken;
                return chicken;
            }
            else if (item == "egg")
            {
                Egg_order egg = new Egg_order(quantity);
                R_Zakaz = egg;
                return egg;
            }
            else
            {
                throw new Exception("I can not cook {item}");
            }
        }
        public Object CopyRequest()
        {
            if (R_Zakaz == null)
                throw new Exception("Ещё нет заказа!");
            checkBtnPrepare = true;
            return R_Zakaz;
        }
        public string Incpect(Object zakaz)
        {
            if (zakaz is Egg_order)
            {
                string messege;
                Egg_order egg = (Egg_order)zakaz;
                messege = "" + egg.GetQuality();
                egg.Crack();
                return "" + messege;
            }
            else return "";
        }
        public string PreparedFood()
        {
            if (!checkOrder)
                throw new Exception("Заказов ещё нет!");
            if (!checkBtnPrepare)
                throw new Exception("Заказ уже приготовлена!");
            checkBtnPrepare = false;
            if (R_Zakaz is Chicken_order)
            {
                Chicken_order chicken = (Chicken_order)R_Zakaz;
                for (int i = 0; i < chicken.GetQuantity(); i++)
                {
                    chicken.CutUp();
                }
                chicken.Cook();
                return chicken.GetQuantity() +  " штук куриц приготовленo!";
            }
            else if (R_Zakaz is Egg_order)
            {
                Egg_order egg = (Egg_order)R_Zakaz;
                for (int i = 0; i < egg.GetQuantity(); i++)
                {
                    egg.Crack();
                }
                egg.Cook();
                return egg.GetQuantity() + " штук яйцо приготовленo!";
            }
            else
            {
                throw new Exception("I can not cook your order!");
            }

        }
        public string Inspect(Object zakaz)
        {
            if (zakaz is Chicken_order)
                return "";
            else
            {
                Egg_order egg = (Egg_order)zakaz;
                return "" + egg.GetQuality();
            }
        }
    }
}

