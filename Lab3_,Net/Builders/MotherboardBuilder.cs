using Lab3__Net.Builders.BuilderInterfaces;
using Lab3__Net.ExtraClasses;
using Lab3__Net.MainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Lab3__Net.Builders
{
    public class MotherboardBuilder : IMotherboardBuilder
    {
        private Motherboard motherboard;

        public MotherboardBuilder()
        {
            motherboard = new();
        }

        public void BuildChipset(ProperValueEnter valueEnter)
        {
            motherboard.chipset = valueEnter.StringValueEnter("Введіть потрібний чипсет:");
        }

        public void BuildFrequency(ProperValueEnter valueEnter)
        {
            motherboard.frequency = valueEnter.IntValueEnter("Введіть потрібну частоту:");
        }

        public void BuildMotherboardName(ProperValueEnter valueEnter)
        {
            motherboard.name = valueEnter.StringValueEnter("Введіть потрібне ім'я:");
        }

        public void BuildPrice(ProperValueEnter valueEnter)
        {
            motherboard.price = valueEnter.IntValueEnter("Введіть потрібну ціну:");
        }

        public void BuildProcessorCount(ProperValueEnter valueEnter)
        {
            motherboard.processorCount = valueEnter.IntValueEnter("Введіть потрібнe число процессорів:");
        }

        public void BuildRAMType(ProperValueEnter valueEnter)
        {
            motherboard.RAMtype = valueEnter.StringValueEnter("Введіть потрібний тип оперативної пам'яті:");
        }

        public void BuildSocketType(ProperValueEnter valueEnter)
        {
            motherboard.socketType = valueEnter.StringValueEnter("Введіть потрібний тип сокету:");
        }

        public Motherboard GetMotherboard()
        {
            return motherboard;
        }
    }
}
