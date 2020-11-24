using System;

namespace Preco_do_alcool_ou_da_gasolina
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Selecione um tipo de combustível");
            Console.WriteLine("A - Álcool");
            Console.WriteLine("G - Gasolina");
            string combustivel = Console.ReadLine();
            Console.WriteLine("Digite a quantidade de combustível");
            float quantidadeCombustivel = float.Parse(Console.ReadLine());

            float precoAlcool = 4.9f;
            float precoGasolina = 5.3f;
            float percAlcool1 = 0.05f;
            float percAlcool2 = 0.03f;
            float percGasolina1 = 0.06f;
            float percGasolina2 = 0.04f;
            float retornoDesconto;

            switch (combustivel.ToLower())
            {
                case "a":
                    ExibirValorPago(AplicarDesconto(quantidadeCombustivel, precoAlcool, percAlcool1, percAlcool2));
                    break;
                case "g":
                    retornoDesconto = AplicarDesconto(quantidadeCombustivel, precoGasolina, percGasolina1, percGasolina2);
                    ExibirValorPago(retornoDesconto);
                    break;
                default:
                    Console.WriteLine("Opção Inválida");
                    break;
            }
        }
        static float AplicarDesconto(float litros, float preco, float perc1, float perc2){
            if(litros>20){
                float valorTotal = litros * preco;
                float desconto = (litros * preco) * perc1;
                return valorTotal - desconto;
            }else{
                float valorTotal = litros * preco;
                float desconto = (litros * preco) * perc2;
                return valorTotal - desconto;
            }
        }//fim Aplicar Desconto

        static void ExibirValorPago(float valor){
            Console.WriteLine($"O valor total a ser pago é de: {valor}");
        }
    }
}
