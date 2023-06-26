using Lab3__Net.MainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace Lab3__Net.ExtraClasses
{
    public class ConfigDeterminer
    {
        Configuration config = new();
        DataList data = new();

        private List<Motherboard> GetMotherboards(Motherboard ?mbpattern)
        {
            List<Motherboard> result = data.motherboards;

            if (mbpattern == null)
            {
                return result;
            }
            if (!(mbpattern?.socketType == null)) 
            {
                result = result.Select(mb => mb).Where(mb => mb?.socketType == mbpattern?.socketType).ToList(); 
            }
            if (!(mbpattern?.chipset == null))
            {
                result = result.Select(mb => mb).Where(mb => mb?.chipset == mbpattern?.chipset).ToList();
            }
            if (!(mbpattern?.processorCount == 0))
            {
                result = result.Select(mb => mb).Where(mb => mb?.processorCount == mbpattern?.processorCount).ToList();
            }
            if (!(mbpattern?.RAMtype == null))
            {
                result = result.Select(mb => mb).Where(mb => mb?.RAMtype == mbpattern?.RAMtype).ToList();
            }
            if (!(mbpattern?.frequency == 0))
            {
                result = result.Select(mb => mb).Where(mb => mb?.frequency == mbpattern?.frequency).ToList();
            }
            if (!(mbpattern?.name == null))
            {
                result = result.Select(mb => mb).Where(mb => mb?.name == mbpattern?.name).ToList();
            }
            if (!(mbpattern?.price == 0))
            {
                result = result.Select(mb => mb).Where(mb => mb?.price == mbpattern?.price).ToList();
            }
            return result;
        }

        private List<Processor> GetProcessors(Processor ?prpattern)
        {
            List<Processor> result = data.processors;

            if (prpattern == null)
            {
                return result;
            }
            if (!(prpattern?.connectorType == null))
            {
                result = result.Select(pr => pr).Where(pr => pr?.connectorType == prpattern?.connectorType).ToList();
            }
            if (!(prpattern?.numberOfCores == 0))
            {
                result = result.Select(pr => pr).Where(pr => pr?.numberOfCores == prpattern?.numberOfCores).ToList();
            }
            if (!(prpattern?.frequency == 0))
            {
                result = result.Select(pr => pr).Where(pr => pr?.frequency == prpattern?.frequency).ToList();
            }
            if (!(prpattern?.name == null))
            {
                result = result.Select(pr => pr).Where(pr => pr?.name == prpattern?.name).ToList();
            }
            if (!(prpattern?.price == 0))
            {
                result = result.Select(pr => pr).Where(pr => pr?.price == prpattern?.price).ToList();
            }
            return result;
        }

        private List<HardDrive> GetHardDrives(HardDrive ?hdpattern)
        {
            List<HardDrive> result = data.hardDrives;
            if(hdpattern == null)
            {
                return result;
            }
            if (!(hdpattern?.storageCapacity == 0))
            {
                result = result.Select(hd => hd).Where(hd => hd?.storageCapacity == hdpattern?.storageCapacity).ToList();
            }
            if (!(hdpattern?.velocity == 0))
            {
                result = result.Select(hd => hd).Where(hd => hd?.velocity == hdpattern?.velocity).ToList();
            }
            if (!(hdpattern?.connectionInterface == null))
            {
                result = result.Select(hd => hd).Where(hd => hd?.connectionInterface == hdpattern?.connectionInterface).ToList();
            }
            if (!(hdpattern?.name == null))
            {
                result = result.Select(hd => hd).Where(hd => hd?.name == hdpattern?.name).ToList();
            }
            if (!(hdpattern?.price == 0))
            {
                result = result.Select(hd => hd).Where(hd => hd?.price == hdpattern?.price).ToList();
            }
            return result;
        }

        private List<RAM> GetRAMs(RAM ?rampattern)
        {

            List<RAM> result = data.RAMs;

            if (rampattern == null)
            {
                return result;
            }
            if (!(rampattern?.amount == 0))
            {
                result = result.Select(ram => ram).Where(ram => ram?.amount == rampattern?.amount).ToList();
            }
            if (!(rampattern?.frequency == 0))
            {
                result = result.Select(ram => ram).Where(ram => ram?.frequency == rampattern?.frequency).ToList();
            }
            if (!(rampattern?.barsNumber == 0))
            {
                result = result.Select(ram => ram).Where(ram => ram?.barsNumber == rampattern?.barsNumber).ToList();
            }
            if (!(rampattern?.type == null))
            {
                result = result.Select(ram => ram).Where(ram => ram?.type == rampattern?.type).ToList();
            }
            if (!(rampattern?.name == null))
            {
                result = result.Select(ram => ram).Where(ram => ram?.name == rampattern?.name).ToList();
            }
            if (!(rampattern?.price == 0))
            {
                result = result.Select(ram => ram).Where(ram => ram?.price == rampattern?.price).ToList();
            }
            return result;
        }

        public Configuration GetConfiguration(Pattern pattern)
        {
            config.motherboards = GetMotherboards(pattern.motherboard);
            config.processors = GetProcessors(pattern.processor);
            config.hardDrives = GetHardDrives(pattern.hardDrive);
            config.RAMs = GetRAMs(pattern.ram);

            return config;
        }
    }
}
