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

        public Item(Item item, int count)
        {
            ID = item.GetID();
            name = item.GetName();
            price = item.GetPrice();
            category = item.GetCategory();
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

        public static bool operator ==(Item i1, Item i2)
        {
            if (i1.GetID() == i2.GetID())
            {
                if (i1.GetName() == i2.GetName())
                {
                    if (i1.GetPrice() == i2.GetPrice())
                    {
                        if (i1.GetCategory() == i2.GetCategory())
                        {
                            if (i1.GetCount() == i2.GetCount())
                            {
                                return true;
                            }
                        }
                    }
                }
            }

            return false;
        }

        public static bool operator !=(Item i1, Item i2)
        {
            return !(i1 == i2);
        }
    }
}
