using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibraryAddition
{
    public abstract class Expression
    {
        public abstract int Evalue();

        public abstract string Format();
    }
}