using System;

namespace Ej_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
        string[] diasSemana= {"lunes", "martes", "miercoles", "jueves", "viernes"};
        int dias=5;
          for (int i=dias-1 ;i >=0; i-- )
          {
          Console.WriteLine( "dia: " + diasSemana[i]);
          }

        Console.WriteLine("presiones una tecla para terminar...");
        Console.ReadKey();

           
        }
    }
}
