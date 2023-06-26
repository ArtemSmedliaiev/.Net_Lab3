namespace Lab3__Net.MainModel
{
    public class Processor : Product
    {
        public string? connectorType { get; set; }
        public int numberOfCores { get; set; }
        public int frequency { get; set; }

        public Processor()
        {

        }

        public Processor(int ID, string Name, int Price, string ConnectorType, int Cores, int Frequency)
        {
            Id = ID;
            name = Name;
            price = Price;
            connectorType = ConnectorType;
            numberOfCores = Cores;
            frequency = Frequency;
        }

        public override string GetInfo()
        {
            return $"Назва: {name} \n" +
                   $"Ціна: {price} \n" +
                   $"Тип роз’єму: {connectorType} \n" +
                   $"Кількість ядер: {numberOfCores} \n" +
                   $"Тактова частота: {frequency} \n";
        }
    }
}
