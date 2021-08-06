using System;

namespace C__proyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero_1= 5;
            int numero_2= 6;
            int numero_3= 10;
            int resultado_1=0;
            int resultado_2=0;

            Console.WriteLine("Presentado por Juan Diego Rodriguez Riaño");
            Console.WriteLine ("Tenemos 3 numeros, el primero es {0}, el segundo es {1}, y el tercero es {2}", numero_1,numero_2,numero_3);
            Console.WriteLine ("Ahora, lo siguiente que haremos sera una suma");
            resultado_1= numero_1+numero_2;
            Console.WriteLine ("La suma de los primeros dos numeros son: {0}", resultado_1);
            resultado_2= (numero_1+numero_2)*numero_3;
            Console.WriteLine ("Ahora la suma de los dos numeros con el tercer numero multiplicado es: {0}", resultado_2);


        }
    }
}