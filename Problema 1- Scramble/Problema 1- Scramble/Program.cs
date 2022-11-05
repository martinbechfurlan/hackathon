using System;
using System.Collections.Generic;

namespace Problema_1__Scramble
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaración de variables
            string cadenaUno;
            string cadenaDos;
            bool validar=false;


            Console.WriteLine("Ingreso cadena uno >>");
            char[] c1 = Console.ReadLine().ToLower().ToCharArray();

            Console.WriteLine("Ingreso cadena uno >>");
            char[] c2 = Console.ReadLine().ToLower().ToCharArray();

            
            validar = validarPalabra(c1, c2);

            if (validar){
                Console.Write("// Las cadenas si son equvalentes");
            }
            else{
                Console.Write("// Las cadenas No son equvalentes");
            }

        
        }



        public static bool validarPalabra(char[] cadenaUno, char[] cadenaDos)
        {

            if (cadenaUno.Length == cadenaDos.Length)
            {
                List<Char> letra = new List<Char>();
                List<int> cantidad = new List<int>();
                int cont = 0;

                for (int i = 0; i < cadenaUno.Length; i++){
                    cont = 0;
                    if (cadenaUno[i] != Convert.ToChar(0))
                    {
                        letra.Add(cadenaUno[i]);


                        //contar cuantas veces se repite  el caracter
                        for (int j = 0; j < cadenaUno.Length; j++)
                        {
                            if (letra[letra.Count - 1] == cadenaUno[j])
                            {
                                cont++;
                                cadenaUno[j] = Convert.ToChar(0);
                            }
                        }
                        cantidad.Add(cont);
                    }
                }
               
                //validar
                for (int i = 0; i < letra.Count; i++){
                    cont = 0;
                  //  Console.WriteLine(cantidad[i]);
                    for (int j = 0; j < cadenaUno.Length; j++){
                        if (letra[i] == cadenaDos[j]){                         
                            cont++;
                        }
                    }
                   if(cantidad[i] != cont){
                        return false;
                    }

                }
            }
            else{
                return false;
            }
            return true;
        }
    }
}
