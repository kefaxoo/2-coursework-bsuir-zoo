namespace pet_store
{
    public class Purchases
    {
        private int ID;
        private int billID;
        private int itemID;
        private int count;

        public Purchases(int ID, int billID, int itemID, int count)
        {
            this.ID = ID;
            this.billID = billID;
            this.itemID = itemID;
            this.count = count;
        }

        public int getID() => ID;

        public int getBillID() => billID;

        public int getItemID() => itemID;

        public int getCount() => count;
    }
}
