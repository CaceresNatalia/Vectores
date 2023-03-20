using System;

namespace ej2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Hacer un programa que solicite 10  números enteros y los guarde en un vector.
            //Luego recorrer ese vector para calcular el promedio. Mostrar por pantalla los valores que son mayores al promedio.

            int acu=0;
            float promedio;
            int [] vector = new int [10];

            for (int x = 0; x < 10; x++){

                Console.WriteLine("Ingrese un nro:");
                vector[x] = int.Parse(Console.ReadLine());

                
                
            }

            for(int x = 0; x < 10; x++){

                acu+= vector[x];

            }

            promedio = acu/10;
            Console.WriteLine("El promedio es " + promedio);

            for(int x = 0; x < 10; x++){

                if (vector[x] > promedio)
                    Console.WriteLine(vector[x] + " es mayor que el promedio");

            }


        }
    }
}
