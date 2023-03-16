namespace ClassLibrary
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int antal { get; set; }
        public decimal price { get; set; }

        //public Product(int id, string name, int antal, float price)
        //{
        //    this.price = price;
        //    this.antal = antal;
        //    this.ID = id;
        //    this.Name = name;
        //}

        public decimal RowPrice()
        {
            return Convert.ToDecimal(antal) * price;           
        }

        public void Remove(int antal)
        {
            this.antal -= antal;
        }

        public void Add(int antal)
        {
            this.antal += antal;
        }
    }
}