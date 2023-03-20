using System;

namespace ej4
{
    class Program
    {
        static void Main(string[] args)
        {
            //4. Una empresa comercializa 15 tipos de artículos y por cada venta realizada genera un registro
            //con los siguientes datos:

            // - Número de Artículo (1 a 15)
            // - Cantidad Vendida 

            // Puede haber varios registros para el mismo artículo y el último se indica con número de artículo igual a 0.
            // Se pide determinar e informar:
            // a) El número de artículo que más se vendió en total.
            // b) Los números de artículos que no registraron ventas.
            // c) Cuantas unidades se vendieron del número de artículo 10.

            int articulo, venta, ventaMax=0, artMax=0;
            int [] ventaRegistrada = new int [15];

            Console.WriteLine("Ingrese el nro de artículo del 1 al 15 ( o termine con 0)");
            articulo = int.Parse(Console.ReadLine());
            

            while (articulo != 0 ){
                                
                
                ventaRegistrada[articulo-1]+= venta;
                
                                
                Console.WriteLine("Ingrese el nro de artículo del 1 al 15 ( o termine con 0)");
                articulo = int.Parse(Console.ReadLine());

                }

                for (int x = 0; x < 15; x++){

                    if (ventaMax == 0){
                        ventaMax = ventaRegistrada[x];
                        artMax = x+1;
                    } else {
                        if(ventaRegistrada[x]>ventaMax){
                            ventaMax = ventaRegistrada[x];
                            artMax = x+1;
                        }
                    }

                    if(ventaRegistrada[x] == 0)
                    Console.WriteLine("El artículo nro " + (x+1) + " no registra ventas");

                    
                }
                Console.WriteLine("El artículo 10 tuvo una cantidad de ventas de " + ventaRegistrada[9]);

                Console.WriteLine("El artículo que más ventas registró fue el nro " + artMax + " con un total de ventas de " + ventaMax);

              

                

                

            

            
            
            




        }
    }
}
