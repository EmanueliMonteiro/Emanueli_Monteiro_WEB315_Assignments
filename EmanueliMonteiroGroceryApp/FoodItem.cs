using System;

namespace EmanueliMonteiroGroceryApp.Data
{
    public class FoodItem
    {
        public string Item { get; set; }

        public int Quantity { get; set; }

        public string Section { get; set; }

        public int Price { get; set; }

        public DateTime ExpirationDate { get; set; }

    }
}
