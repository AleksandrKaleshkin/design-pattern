using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MyLibrary
{
    public class DecoyDuck : Duck
    {
        public override string Display()
        {
            return "Display" + this.GetType();
        }
    }
}