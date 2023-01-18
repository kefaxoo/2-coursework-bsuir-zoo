namespace pet_store
{
    public class Bill
    {
        private int ID;
        private string date;
        private string time;
        private double sum;
        private double givenSum;
        private double change;
        private string typeOfMoney;

        public Bill(int ID, string date, string time, double sum, double givenSum, double change, string typeOfMoney)
        {
            this.ID = ID;
            this.date = date;
            this.time = time;
            this.sum = sum;
            this.givenSum = givenSum;
            this.change = change;
            this.typeOfMoney = typeOfMoney;
        }

        public int getID() => ID;

        public string getDate() => date;

        public string getTime() => time;

        public double getSum() => sum;

        public double getGivenSum() => givenSum;

        public double getChange() => change;

        public string getTypeOfMoney() => typeOfMoney;
    }
}
