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
    internal class ProcessorBuilder : IProcessorBuilder
    {
        private Processor processor;

        public ProcessorBuilder()
        {
            processor = new();
        }
        public void BuildConnectorType(ProperValueEnter valueEnter)
        {
            processor.connectorType = valueEnter.StringValueEnter("Введіть потрібний тип роз'єму:");
        }

        public void BuildFrequency(ProperValueEnter valueEnter)
        {
            processor.frequency = valueEnter.IntValueEnter("Введіть потрібну частоту:");
        }

        public void BuildNumberOfCores(ProperValueEnter valueEnter)
        {
            processor.numberOfCores = valueEnter.IntValueEnter("Введіть потрібне число ядер:");
        }

        public void BuildPrice(ProperValueEnter valueEnter)
        {
            processor.price = valueEnter.IntValueEnter("Введіть потрібну ціну:");
        }

        public void BuildProcessorName(ProperValueEnter valueEnter)
        {
            processor.name = valueEnter.StringValueEnter("Введіть потрібне ім'я:");
        }

        public Processor GetProcessor()
        {
            return processor;
        }
    }
}
