using System;

namespace ej3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. Hacer un programa que solicite una cadena de caracteres y dos caracteres sueltos (tres ingresos).
            //El programa deberá generar una cadena donde todas las ocurrencias del primer carácter dado hayan sido
            //reemplazadas por el segundo. Mostrar el resultado en pantalla. Ejemplo:

            //CADENA FUENTE: “La mar estaba serena"
            //CARÁCTER 1: ‘a’ CARÁCTER 2: ‘i’
            //CADENA RESULTADO: “Li mir estibi sereni"

            char caracter1, caracter2, letra;
            char [] cadena = new char [50];
            int indice = 0;

            Console.WriteLine("Ingrese una vocal");
            caracter1 = char.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otra vocal");
            caracter2 = char.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese una oración, letra por letra, termine con un punto.");
                letra = char.Parse(Console.ReadLine());

            while (letra != '.' && indice < 50){

                cadena[indice] = letra;
                letra = char.Parse(Console.ReadLine());

                    indice++;
            }

            cadena[indice] = '\0';

            Console.WriteLine(cadena);
            indice =0;
            while (cadena[indice] != '\0'){

                if(cadena[indice] == caracter1)
                    cadena[indice] = caracter2;
                indice++;
            }

            Console.WriteLine(cadena);

        }
    }
}
