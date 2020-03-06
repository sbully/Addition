using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibraryAddition
{
    public class Nombre : Expression
    {
        private int valeur;

        public Nombre(Int32 valeur)
        {
            this.valeur = valeur;
        }

        public override int Evalue()
        {
            return valeur;
        }

        public override string Format()
        {
            return this.ToString();
        }

        public override string ToString()
        {
            return valeur.ToString();
        }
    }
}