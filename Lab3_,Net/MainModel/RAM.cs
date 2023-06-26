namespace Lab3__Net.MainModel
{
    public class RAM : Product
    {
        public int amount { get; set; }
        public string? type { get; set; }
        public int frequency { get; set; }
        public int barsNumber { get; set; }

        public RAM()
        {
            
        }

        public RAM(int ID, string Name, int Price, int Amount, string Type, int Frequency, int BarsNumber)
        {
            Id = ID;
            name = Name;
            price = Price;
            amount = Amount;
            type = Type;
            frequency = Frequency;
            barsNumber = BarsNumber;
        }

        public override string GetInfo()
        {
            return $"Назва: {name} \n" +
                   $"Ціна: {price} \n" +
                   $"Oбсяг: {amount} \n" +
                   $"Тип: {type} \n" +
                   $"Частота: {frequency} \n" +
                   $"Kількість планок: {barsNumber}";
        }
    }
}
