namespace LR2
{
    public struct Product
    {
        public string Name_;
        public int Price_;
        public int Stock_;

        public Product(string name, int price, int stock)
        {
            Name_ = name;
            Price_ = price;
            Stock_ = stock;
        }
    }
}
