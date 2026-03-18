using System;
using System.Collections.Generic;
using System.Text;
namespace AbiturientApp
{
            public class TAbiturient{
            public string Familia;
            public int Shkola;
            public int Shifr;
            public int Balli;
        public override string ToString()
        {
            return $"{Familia} (Школа {Shkola}, Шифр {Shifr}, Баллы {Balli})";
        }
    }
   
}
