using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    partial class Auto
    {
        public void WriteToAuto(Auto readAuto)
        {
            SetMark(readAuto.GetMark());
            SetModel(readAuto.GetModel());
            SetTypeOfBody(readAuto.GetTypeOfBody());
            SetMaxSpeed(readAuto.GetMaxSpeed());
            SetEngineCapacity(readAuto.GetEngineCapacity());
            SetDateOfManufacture(readAuto.GetDateOfManufacture());
        }
    }
}
