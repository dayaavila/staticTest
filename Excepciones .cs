using System;
using System.Collections.Generic;
using System.Text;

namespace MetodoStatico4
{
    public class Excepciones
    {

        public Excepciones()
        {

        }
        public static void ExceptTest(int age)
        {
            if (age == 0)
            {
                throw new Exception("Valor invalido");
            }
            if (age < 17)
            {
                throw new Exception("No puede ingresar, es menor de edad");
            }
            if (age > 18)
            {
                throw new Exception("Puedes Ingresar");
            }
        }
    }
}
