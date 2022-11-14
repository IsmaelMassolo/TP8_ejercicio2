using System;
/*2) Verificar que cambio se debe realizar el programa de la consigna 1 para que los días de la
semana se muestren en orden inverso.*/
namespace TP8C_
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] diasSemana = {"Lunes","Martes","Miercoles","Jueves","Viernes"};

            for (int i = diasSemana.Length-1; i >= 0; i--)
            {
                Console.WriteLine("Dia de la semana "+(i+1)+" "+diasSemana[i]);
            }
            Console.WriteLine("Presione una tecla para terminar");
            Console.ReadKey();
        }
    }
}
