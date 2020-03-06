using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibraryAddition
{
    public class Addition : Binaire
    {
        public Addition(Expression op1, Expression op2) : base(op1,op2)
        {
           
        }

        public override int Evalue()
        {
            return (this.Op1.Evalue() + this.Op2.Evalue());
        }

        public override string Format()
        {
            return Op1.Format() + " + " + Op2.Format();
        }

        public override string ToString()
        {
            return  Format() + " = "+ this.Evalue();
        }
    }
}