using ExamenEstructuraDatos;

internal class Program
{
    private static void Main(string[] args)
    {

        //------------------NUMEROS SECUENCIALES----------------
        //Examen secuenciaNumeros = new Examen();
        //Console.WriteLine("ingrese el primer numero");
        //int numero = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("ingrese el segundo numero");
        //int numero2 = Convert.ToInt32(Console.ReadLine());
        //secuenciaNumeros.numerosSecuencia(numero, numero2);


        //-----------------TABLAS DE MULTIPLICAR-----------------
        Examen multiplicarNumero = new Examen();
        Console.WriteLine("Ingrese el numero a multiplicar");
        int multiplicar = Convert.ToInt32(Console.ReadLine());
        multiplicarNumero.tablaMultiplicar(multiplicar);

    }


}