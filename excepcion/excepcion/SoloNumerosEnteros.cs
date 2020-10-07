using System;
using System.Collections.Generic;
using System.Text;

namespace excepcion
{
    public class SoloNumerosEnteros:ApplicationException
    {
        private readonly int numeroo;
        public int Numeroo { get { return numeroo; } }

        public SoloNumerosEnteros(int v, string message) : base(message)
        {
            this.numeroo = v;
        }
    }
}
