using Lab3__Net.Builders.BuilderInterfaces;
using Lab3__Net.ExtraClasses;
using Lab3__Net.MainModel;

namespace Lab3__Net.Builders
{
    public class HardDriveBuilder : IHardDriveBuilder
    {
        private HardDrive hardDrive;

        public HardDriveBuilder()
        {
            hardDrive = new();
        }

        public void BuildConnectorInterface(ProperValueEnter valueEnter)
        {
            hardDrive.connectionInterface = valueEnter.StringValueEnter("Введіть потрібний інтерфейс підключення:");
        }

        public void BuildHardDriveName(ProperValueEnter valueEnter)
        {
            hardDrive.name = valueEnter.StringValueEnter("Введіть потрібне ім'я:");
        }

        public void BuildPrice(ProperValueEnter valueEnter)
        {
            hardDrive.price = valueEnter.IntValueEnter("Введіть потрібну ціну:");
        }

        public void BuildStorageCapacity(ProperValueEnter valueEnter)
        {
            hardDrive.storageCapacity = valueEnter.IntValueEnter("Введіть потрібну місткість накопичувача:");
        }

        public void BuildVelocity(ProperValueEnter valueEnter)
        {
            hardDrive.velocity = valueEnter.IntValueEnter("Введіть потрібну швидкість:");
        }

        public HardDrive GetHardDrive()
        {
            return hardDrive;
        }
    }
}
