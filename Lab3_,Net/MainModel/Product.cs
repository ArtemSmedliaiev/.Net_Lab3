namespace Lab3__Net.MainModel
{
    public abstract class Product
    {
        public int Id { get; set; }
        public string? name { get; set; }
        public int price { get; set; }

        public abstract string GetInfo();
    }
}
