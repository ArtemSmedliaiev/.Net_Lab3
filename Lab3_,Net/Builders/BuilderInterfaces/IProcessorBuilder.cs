using Lab3__Net.ExtraClasses;
using Lab3__Net.MainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3__Net.Builders.BuilderInterfaces
{
    internal interface IProcessorBuilder
    {
        void BuildProcessorName(ProperValueEnter valueEnter);

        void BuildPrice(ProperValueEnter valueEnter);

        void BuildConnectorType(ProperValueEnter valueEnter);

        void BuildNumberOfCores(ProperValueEnter valueEnter);

        void BuildFrequency(ProperValueEnter valueEnter);

        Processor GetProcessor();
    }
}
