using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleAbstractClass.Entities
{
    public class Designer : Employee
    {
        public override void Readjustment()
        {
            Salary += 500;
        }
    }
}
