using System;

namespace TemposAtras.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                DateTime data;  // cria uma variavel date time 
                data = DateTime.Now;    //armazena na variavel "data" e a hora atual

                Console.WriteLine("Informe a data que deseja calcular: ");
                DateTime dataInformada = Convert.ToDateTime(Console.ReadLine());

                Console.WriteLine();
              
                TimeSpan intervaloDeTempo;
                intervaloDeTempo = data - dataInformada;

                //double resultado = intervaloDeTempo.Days;

                
                  
                  Console.WriteLine(intervaloDeTempo.TotalDays.ToString());

                if (intervaloDeTempo.TotalDays <= 6)
                {
                    Console.WriteLine(intervaloDeTempo + " dias");
                }

                if(intervaloDeTempo.TotalDays > 7)
                {
                    intervaloDeTempo
                }


                Console.ReadLine();
            }while (true);
        }
    }
}
