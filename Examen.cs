using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenEstructuraDatos
{

    //------------------NUMEROS SECUENCIALES----------------
    public class Examen
    {
        //public void numerosSecuencia(int num1, int num2)
        //{
        //    if (num1 == num2)
        //    {
        //        Console.WriteLine("Los numeros son iguales");
        //    }

        //    for (int i = num1; i <= num2; i++)
        //    {
        //        Console.WriteLine($"La secuencia de los numeros es {i}");
        //    }

        //    for (int i = num1; i >= num2; i--)
        //    {
        //        Console.WriteLine($"La secuenciua de los numeros es {i}");
        //    }

        //}




        //-----------------TABLAS DE MULTIPLICAR-----------------

        public void tablaMultiplicar(int num1)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{num1} X {i} = {num1 * i}");
            }
        }




        //----------------------CURP---------------------

        //public void (string curp)
        //{

        //}


    }

}
