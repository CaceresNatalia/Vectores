﻿using System;

namespace ej1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Hacer un programa que solicite 10 números enteros y los guarde en un vector.
            //Luego recorrer los elementos y determinar e informar cuál es el valor máximo y su posición dentro del vector.

            int max=0, pos=0;
            int [] vector = new int [10];

            for (int x = 0; x < 10; x++){
                Console.WriteLine("Ingrese un nro:");
                vector[x] = int.Parse(Console.ReadLine());

                
            }

            for(int x = 0; x < 10; x++){

                if(vector[x] > max){
                    max = vector[x];
                    pos = x+1;
                }


            }

            Console.WriteLine("El mayor es " + max + " y su posición es la " + pos);


        }
    }
}