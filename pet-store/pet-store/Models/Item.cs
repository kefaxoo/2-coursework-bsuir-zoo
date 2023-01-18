using System;
using System.Collections.Generic;
using System.Text;

namespace pet_store
{
    public class Item
    {
        private int ID;
        private string name;
        private double price;
        private string category;
        private int count;

        public Item(int ID, string name, double price, string category, int count)
        {
            this.ID = ID;
            this.name = name;
            this.price = price;
            this.category = category;
            this.count = count;
        }

        public int GetID() => ID;

        public string GetName() => name;

        public double GetPrice() => price;

        public string GetCategory() => category;

        public int GetCount() => count;

        public void SetName(string name) => this.name = name;

        public void SetPrice(double price) => this.price = price;

        public void SetCategory(string category) => this.category = category;

        public void SetCount(int count) => this.count = count;
    }
}
