using Lab3__Net.ExtraClasses;
using Lab3__Net.MainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3__Net.Builders.BuilderInterfaces
{
    internal interface IRAMBuilder
    {
        void BuildRAMName(ProperValueEnter valueEnter);

        void BuildPrice(ProperValueEnter valueEnter);

        void BuildAmount(ProperValueEnter valueEnter);

        void BuildType(ProperValueEnter valueEnter);

        void BuildFrequency(ProperValueEnter valueEnter);

        void BuildBaresNumber(ProperValueEnter valueEnter);

        RAM GetRAM();
    }
}
