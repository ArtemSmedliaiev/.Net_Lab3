using Lab3__Net.ExtraClasses;
using Lab3__Net.MainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3__Net.Builders.BuilderInterfaces
{
    internal interface IHardDriveBuilder
    {
        void BuildHardDriveName(ProperValueEnter valueEnter);

        void BuildPrice(ProperValueEnter valueEnter);

        void BuildStorageCapacity(ProperValueEnter valueEnter);

        void BuildVelocity(ProperValueEnter valueEnter);

        void BuildConnectorInterface(ProperValueEnter valueEnter);

        HardDrive GetHardDrive();
    }
}
