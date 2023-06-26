using Lab3__Net.MainModel;

namespace Lab3__Net.ExtraClasses
{
    public class DataList
    {
        public List<Motherboard> motherboards { get; } = new()
        {
            new Motherboard()
            {
                Id = 5,
                name = "Asus TUF Gaming B550M-Plus",
                price = 4600,
                chipset = "AMD B550",
                processorCount = 1,
                RAMtype = "4 x DDR4 DIMM",
                frequency = 4400
            },
            new Motherboard()
            {
                Id = 1,
                name = "Asus TUF Gaming B550M-Plus",
                price = 4600,
                chipset = "AMD B550",
                processorCount = 1,
                RAMtype = "4 x DDR4 DIMM",
                frequency = 4400
            },

            new Motherboard()
            {
                Id = 2,
                name = "gigabyte B450 AORUS PRO",
                price = 3500,
                chipset = "AMD B450",
                processorCount = 1,
                RAMtype = "4 x DDR4 DIMM",
                frequency = 3600
            },

            new Motherboard()
            {
                Id = 3,
                name = "msi MAG B560 TOMAHAWK WIFI",
                price = 5500,
                chipset = "Intel B560",
                processorCount = 1,
                RAMtype = "4 x DDR4 DIMM",
                frequency = 5000
            },

            new Motherboard()
            {
                Id = 4,
                name = "asrock B460M Pro4",
                price = 2900,
                chipset = "Intel B460",
                processorCount = 1,
                RAMtype = "4 x DDR4 DIMM",
                frequency = 2933
            }

        };
        public List<Processor> processors { get; } = new()
        {
            new Processor()
            {
                Id = 1,
                name = "AMD Ryzen 5",
                price = 5700,
                connectorType = "Socket AM4",
                numberOfCores = 6,
                frequency = 3500
            },
            new Processor() 
            {
                Id = 2,
                name = "AMD Ryzen 5",
                price = 5700,
                connectorType = "Socket AM4",
                numberOfCores = 6,
                frequency = 3500
            },
            new Processor()
            {
                Id = 3,
                name = "Intel Core i7",
                price = 8900,
                connectorType = "LGA 1200",
                numberOfCores = 8,
                frequency = 3800
            },
            new Processor()
            {
                Id = 4,
                name = "AMD Ryzen 7",
                price = 9900,
                connectorType = "Socket AM4",
                numberOfCores = 8,
                frequency = 4200
            },
            new Processor()
            {
                Id = 5,
                name = "Intel Core i5",
                price = 5500,
                connectorType = "LGA 1151",
                numberOfCores = 6,
                frequency = 3600
            }

        };
        public List<HardDrive> hardDrives { get; } = new()
        {
            new HardDrive()
            {
                Id = 1,
                name = "Transcend StoreJet",
                price = 2500,
                storageCapacity = 1000,
                velocity = 5,
                connectionInterface = "USB 2.0"
            },
            new HardDrive()
            {
                Id = 2,
                name = "Transcend StoreJet",
                price = 2500,
                storageCapacity = 1000,
                velocity = 5,
                connectionInterface = "USB 2.0"
            },

            new HardDrive()
            {
                Id = 3,
                name = "Seagate Barracuda",
                price = 3200,
                storageCapacity = 2000,
                velocity = 7,
                connectionInterface = "SATA 6Gb/s"
            },

            new HardDrive()
            {
                Id = 4,
                name = "Western Digital My Passport",
                price = 1800,
                storageCapacity = 500,
                velocity = 5,
                connectionInterface = "USB 3.0"
            },

            new HardDrive()
            {
                Id = 5,
                name = "Samsung 870 EVO",
                price = 4100,
                storageCapacity = 1000,
                velocity = 10,
                connectionInterface = "SATA 6Gb/s"
            }
        };
        public List<RAM> RAMs { get; } = new()
        {
            new RAM()
            {
                Id = 1,
                name = "Kingston Fury",
                amount = 16,
                type = "DDR4 SDRAM",
                frequency = 3200,
                barsNumber = 2
            },
            new RAM()
            {
                Id = 2,
                name = "Corsair Vengeance",
                amount = 8,
                type = "DDR4 SDRAM",
                frequency = 3000,
                barsNumber = 2
            },

            new RAM()
            {
                Id = 3,
                name = "G.Skill Trident Z",
                amount = 32,
                type = "DDR4 SDRAM",
                frequency = 3600,
                barsNumber = 4
            },

            new RAM()
            {
                Id = 4,
                name = "Crucial Ballistix",
                amount = 16,
                type = "DDR4 SDRAM",
                frequency = 3200,
                barsNumber = 2
            },

            new RAM()
            {
                Id = 5,
                name = "Team T-Force Vulcan",
                amount = 16,
                type = "DDR4 SDRAM",
                frequency = 3000,
                barsNumber = 2
            }
        };
    }
}
