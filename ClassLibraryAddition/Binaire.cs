using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibraryAddition
{
    public abstract class Binaire : Expression
    {
        private Expression op1;
        private Expression op2;

        public Binaire(Expression op1, Expression op2)
        {
            this.Op1 = op1;
            this.Op2 = op2;
        }

        protected Expression Op1
        {
            get {
                return op1;
            }
            set
            {
                op1 = value;
            }
        }

        protected Expression Op2
        {
            get {
                return op2;
            }
            set
            {
                op2 = value;
            }
        }


    }
}