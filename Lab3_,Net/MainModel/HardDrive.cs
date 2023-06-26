namespace Lab3__Net.MainModel
{
    public class HardDrive : Product
    {
        public int storageCapacity { get; set; }
        public int velocity { get; set; }
        public string? connectionInterface { get; set; }

        public HardDrive()
        {

        }
        public HardDrive(int ID, string Name, int Price, int StorageCapacity, int Velocity, string ConInt)
        {
            Id = ID;
            name = Name;
            price = Price;
            storageCapacity = StorageCapacity;
            velocity = Velocity;
            connectionInterface = ConInt;
        }

        public override string GetInfo()
        {
            return $"Назва: {name} \n" +
                   $"Ціна: {price} \n" +
                   $"Місткість накопичувача: {storageCapacity} \n" +
                   $"Швидкість: {velocity} \n" +
                   $"Iнтерфейс підключення: {connectionInterface} \n";
        }
    }
}
