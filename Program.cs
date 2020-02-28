using System;
using System.Data;

namespace MetodoStatico4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Excepciones.ExceptTest(age: 19);


            Console.WriteLine("Ingresa 1er valor:");

            int valor1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresa 2do valor");
            int valor2 = Convert.ToInt32(Console.ReadLine());

            var valorSuma = Helpers.sumar(valor1, valor2);
            var valorTotalSuma = valorSuma;

            Console.WriteLine(valorTotalSuma);

            var valorResta = Helpers.restar(valor1, valor2);
            var valorTotalResta = valorResta;

            Console.WriteLine(valorTotalResta);


            //var valorSuma = Helpers.sumar(valor1: 8, valor2: 5);
            //var valorTotalSuma = valorSuma;

            //var valorResta = Helpers.restar(valor1: 9, valor2: 6);
            //var valorTotalResta = valorResta;

            //Console.WriteLine(valorTotal);



            // // DataTable dt = TablasHelper.CreaTablaUsuario();
            // // dt = TablasHelper.LlenaTablaUsuario(dt, usuarios);



            //Named Constructor
            //NamedConstructor named = NamedConstructor.SingUpAgain("Dayana");

            //ExceptTest(19);
        }

        //static void ExceptTest(int age)
        //{
        //    if (age == 0)
        //    {
        //        throw new Exception("Valor invalido");
        //    }
        //    if (age < 17)
        //    {
        //        throw new Exception("No puede ingresar, es menor de edad");
        //    }
        //    if (age > 18)
        //    {
        //        throw new Exception("Puedes Ingresar");
        //    }
        //}
    }
}
