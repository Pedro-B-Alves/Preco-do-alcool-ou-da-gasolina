using System;

namespace Preco_do_alcool_ou_da_gasolina
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual foi o tipo de combustível? A para álcool e G para gasolina");
            string tipo = Console.ReadLine();
            Console.WriteLine("Quantos litros foram?");
            double litros = float.Parse(Console.ReadLine());

            if(tipo == "A"){
                if(litros<=20){
                    double pagar = litros*0.147;
                    Console.WriteLine($"O valor a pagar é {pagar} Reais");
                }else if(litros>20){
                    double pagar = litros*0.245;
                    Console.WriteLine($"O valor a pagar é {pagar} Reais");
                }
            }else if(tipo == "G"){
                if(litros<=20){
                    double pagar = litros*0.212;
                    Console.WriteLine($"O valor a pagar é {pagar} Reais");
                }else if(litros>20){
                    double pagar = litros*0.318;
                    Console.WriteLine($"O valor a pagar é {pagar} Reais");
                }
            }else{
                Console.WriteLine($"Você digitou um tipo inválido");
            }
        }
    }
}
