using System;
using System.Linq;
namespace dividestring
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena = "Esta es una prueba de muchas palabras diferentes para saber si esta funcionando el progrma despues de unas cuantas pruebas pero quiero ver si con textos de mayor cantidad puede divdir las columnas"; //entrada
            int j;  //contador
            int maximoL = 50;  //maximo de lineas por substring
            int caracteresporlinea = 20; //caracteres por linea
            char[] input = cadena.ToCharArray();  //convertir cadena a un arreglo
            string subcadena;    //subcadena del tamaño deseado

            while (input.Length > 0)
            {
                //reset slide content and length
                subcadena = string.Empty;
                j = 0;

                //loop para ir sacando lineas
                while ((subcadena.Split('\n').Length < maximoL) && (j < caracteresporlinea))
                {
                    j = j + 1;
                    subcadena = new string(input.Take(j).ToArray()).PadRight(caracteresporlinea - j);//padright para llenar espacios en blanco
                }

                //imprimir sub cadena
                Console.WriteLine(subcadena);


                //limpiar cadena
                input = input.Skip(j).ToArray();
            }

            Console.Read();
        }
    }
}
