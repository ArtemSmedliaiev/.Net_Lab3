using Lab3__Net.Builders;
using Lab3__Net.ExtraClasses;
using Lab3__Net.MainModel;
using Lab3__Net.PresentationLayer;

internal class Program
{
    static void Pause()
    {
        Console.WriteLine("\nДля продовження натисніть будь-яку клавішу");
        Console.ReadKey();
        Console.Clear();
    }

    static void MenuRunner(Menu menu, MenuItemSelector selector, string text)
    {
        while (!menu.IsExitWanted)
        {
            Console.Clear();
            menu.PrintMenu(text);
            menu.ExecuteSelectedItem(selector.SelectItem());
            Pause();
        }
    }

    static void PrintConfig(Pattern pattern, ConfigDeterminer determiner)
    {
        var config = determiner.GetConfiguration(pattern).PrintConfiguration;
    }

    public static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;

        Pattern pattern = new();
        Configuration configuration = new();
        ConfigDeterminer determiner = new();
        ProperValueEnter valueEnter = new();

        HardDriveBuilder hardDriveBuilder = new HardDriveBuilder();
        MotherboardBuilder motherboardBuilder = new MotherboardBuilder();
        ProcessorBuilder processorBuilder = new ProcessorBuilder();
        RAMBuilder rAMBuilder = new RAMBuilder();

        Menu mainMenu = new();
        Menu motherboardMenu = new();
        Menu processorMenu = new();
        Menu hardDriveMenu = new();
        Menu ramMenu = new();

        MenuItemSelector mainMenuSelector = new(1, 6);
        MenuItemSelector motherboardMenuSelector = new(1, 9);
        MenuItemSelector processorMenuSelector = new(1, 7);
        MenuItemSelector hardDriveMenuSelector = new(1, 7);
        MenuItemSelector ramMenuSelector = new(1, 8);

        

        mainMenu.Items = new()
            {
                new MenuItem("1. Обрати параметри материнської плати",
                    () => MenuRunner(motherboardMenu, motherboardMenuSelector, "Оберіть за яким параметром материнської плати створювати шаблон пошуку:")),

                new MenuItem("2. Обрати параметри процессору",
                    () => MenuRunner(processorMenu, processorMenuSelector, "Оберіть за яким параметром процессору створювати шаблон пошуку:")),

                new MenuItem("3. Обрати параметри жортского диску",
                    () => MenuRunner(hardDriveMenu,hardDriveMenuSelector, "Оберіть за яким параметром жорсткого диску створювати шаблон пошуку:")),

                new MenuItem("4. Обрати параметри оперативної пам'яті",
                    () => MenuRunner(ramMenu, ramMenuSelector, "Оберіть за яким параметром оперативної пам'яті створювати шаблон пошуку:")),

                new MenuItem("5. Показати конфігурацію товарів за шаблоном", 
                    () => determiner.GetConfiguration(pattern).PrintConfiguration()),

                new MenuItem("6. Завершити роботу",
                    () => mainMenu.IsExitWanted = true)
            };

        motherboardMenu.Items = new()
            {
                new MenuItem("1. Обрати параметр типу сокету",
                    () => motherboardBuilder.BuildSocketType(valueEnter)),

                new MenuItem("2. Обрати параметр чипсету",
                    () => motherboardBuilder.BuildChipset(valueEnter)),

                new MenuItem("3. Обрати число процессорів",
                    () => motherboardBuilder.BuildProcessorCount(valueEnter)),

                new MenuItem("4. Обрати параметр типу оперативної пам'яті",
                    () => motherboardBuilder.BuildRAMType(valueEnter)),

                new MenuItem("5. Обрати параметр частоти",
                    () => motherboardBuilder.BuildFrequency(valueEnter)),

                new MenuItem("6. Обрати за ім'ям",
                    () => motherboardBuilder.BuildMotherboardName(valueEnter)),

                new MenuItem("7. Обрати за ціною",
                    () => motherboardBuilder.BuildPrice(valueEnter)),

                new MenuItem("8. Зберегти шаблон",
                    ()=> pattern.motherboard = motherboardBuilder.GetMotherboard()),

                new MenuItem("9. Повернутися до головного меню",
                    () => motherboardMenu.IsExitWanted = true)
            };

        processorMenu.Items = new()
            {
                new MenuItem("1. Обрати параметр типу роз'єму",
                    () => processorBuilder.BuildConnectorType(valueEnter)),

                new MenuItem("2. Обрати параметр числа ядер",
                    () => processorBuilder.BuildNumberOfCores(valueEnter)),

                new MenuItem("3. Обрати параметр частоти",
                    () => processorBuilder.BuildFrequency(valueEnter)),

                new MenuItem("4. Обрати за ім'ям",
                    () => processorBuilder.BuildProcessorName(valueEnter)),

                new MenuItem("5. Обрати за ціною",
                    () => processorBuilder.BuildPrice(valueEnter)),

                new MenuItem("6. Зберегти шаблон",
                    ()=> pattern.processor = processorBuilder.GetProcessor()),

                new MenuItem("7. Повернутися до головного меню",
                    () => processorMenu.IsExitWanted = true)
            };

        hardDriveMenu.Items = new()
            {
                new MenuItem("1. Обрати параметр місткості накопичувача",
                    () => hardDriveBuilder.BuildStorageCapacity(valueEnter)),

                new MenuItem("2. Обрати параметр швидкості",
                    () => hardDriveBuilder.BuildVelocity(valueEnter)),

                new MenuItem("3. Обрати параметр інтерфейсу підключення",
                    () => hardDriveBuilder.BuildConnectorInterface(valueEnter)),

                new MenuItem("4. Обрати за ім'ям",
                    () => hardDriveBuilder.BuildHardDriveName(valueEnter)),

                new MenuItem("5. Обрати за ціною",
                    () => hardDriveBuilder.BuildPrice(valueEnter)),

                new MenuItem("6. Зберегти шаблон",
                    ()=> pattern.hardDrive = hardDriveBuilder.GetHardDrive()),

                new MenuItem("7. Повернутися до головного меню",
                    () => hardDriveMenu.IsExitWanted = true)
            };

        ramMenu.Items = new()
            {
                new MenuItem("1. Обрати параметр обсягу пам'яті",
                    () => rAMBuilder.BuildAmount(valueEnter)),

                new MenuItem("2. Обрати параметр типу пам'яті",
                    () => rAMBuilder.BuildType(valueEnter)),

                new MenuItem("3. Обрати параметр частоти",
                    () => rAMBuilder.BuildFrequency(valueEnter)),

                new MenuItem("4. Обрати параметр кількості планок",
                    () => rAMBuilder.BuildBaresNumber(valueEnter)),

                new MenuItem("5. Обрати за ім'ям",
                    () => rAMBuilder.BuildRAMName(valueEnter)),

                new MenuItem("6. Обрати за ціною",
                    () => rAMBuilder.BuildPrice(valueEnter)),

                new MenuItem("7. Зберегти шаблон",
                    ()=> pattern.ram = rAMBuilder.GetRAM()),

                new MenuItem("8. Повернутися до головного меню",
                    () => ramMenu.IsExitWanted = true)
            };

        MenuRunner(mainMenu, mainMenuSelector, "Меню заповнення шаблону для побудови конфігурацій");

        determiner.GetConfiguration(pattern).PrintConfiguration();
    }
}