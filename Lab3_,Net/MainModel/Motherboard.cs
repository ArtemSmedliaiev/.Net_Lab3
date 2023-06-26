namespace Lab3__Net.MainModel
{
    public class Motherboard : Product
    {
        public string? socketType { get; set; }
        public string? chipset { get; set; }
        public int processorCount { get; set; }
        public string? RAMtype { get; set; }
        public int frequency { get; set; }

        public Motherboard()
        {

        }
        public Motherboard(int ID, string Name, int Price, string SocketType, string Chipset, int ProcessorCount, string RAMType, int Frequency)
        {
            Id = ID;
            name = Name;
            price = Price;
            socketType = SocketType;
            chipset = Chipset;
            processorCount = ProcessorCount;
            RAMtype = RAMType;
            frequency = Frequency;
        }

        public override string GetInfo()
        {
            return $"Назва: {name} \n" +
                   $"Ціна: {price} \n" +
                   $"Тип сокету: {socketType} \n" +
                   $"Чипсет: {chipset} \n" +
                   $"Тип оперативної пам'яті: {RAMtype} \n" +
                   $"Частота системної шини: {frequency} \n";
        }
    }
}
