using Lab3__Net.ExtraClasses;
using Lab3__Net.MainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3__Net.Builders.BuilderInterfaces
{
    internal interface IMotherboardBuilder
    {
        void BuildMotherboardName(ProperValueEnter valueEnter);

        void BuildPrice(ProperValueEnter valueEnter);

        void BuildSocketType(ProperValueEnter valueEnter);

        void BuildChipset(ProperValueEnter valueEnter);

        void BuildProcessorCount(ProperValueEnter valueEnter);

        void BuildRAMType(ProperValueEnter valueEnter);

        void BuildFrequency(ProperValueEnter valueEnter);

        Motherboard GetMotherboard();
    }
}
