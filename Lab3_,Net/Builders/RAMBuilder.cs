using Lab3__Net.Builders.BuilderInterfaces;
using Lab3__Net.ExtraClasses;
using Lab3__Net.MainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3__Net.Builders
{
    internal class RAMBuilder : IRAMBuilder
    {
        private RAM ram;

        public RAMBuilder()
        {
            ram = new();
        }

        public void BuildAmount(ProperValueEnter valueEnter)
        {
            ram.amount = valueEnter.IntValueEnter("Введіть потрібний обсяг:");
        }

        public void BuildBaresNumber(ProperValueEnter valueEnter)
        {
            ram.barsNumber = valueEnter.IntValueEnter("Введіть потрібну кількість планок:");
        }

        public void BuildFrequency(ProperValueEnter valueEnter)
        {
            ram.frequency = valueEnter.IntValueEnter("Введіть потрібну частоту:");
        }

        public void BuildPrice(ProperValueEnter valueEnter)
        {
            ram.price = valueEnter.IntValueEnter("Введіть потрібну ціну:");
        }

        public void BuildRAMName(ProperValueEnter valueEnter)
        {
            ram.name = valueEnter.StringValueEnter("Введіть потрібне ім'я:");
        }

        public void BuildType(ProperValueEnter valueEnter)
        {
            ram.type = valueEnter.StringValueEnter("Введіть потрібний тип:");
        }

        public RAM GetRAM()
        {
            return ram;
        }
    }
}
