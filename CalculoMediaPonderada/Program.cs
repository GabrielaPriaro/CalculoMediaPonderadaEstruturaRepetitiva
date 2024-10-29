//obs: Utilizando estruturta repetitiva For:
//Problema "media_ponderada" (adaptado de URI 1079)
//Leia um valor inteiro N, que representa o número de casos de teste que vem a seguir. Cada caso de
//teste consiste de 3 valores reais, para os quais você deverá calcular e mostrar a média ponderada, sendo
//que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem peso 5. Vale lembrar
//que a média ponderada é a soma de todos os valores multiplicados pelo seu respectivo peso, dividida pela soma dos pesos. 

using System.Globalization;

namespace CalculoMediaPonderada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            double numero1, numero2, numero3, mediaPonderada;

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Quantos casos serão digitados? ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite tres numeros:");
                numero1 = double.Parse(Console.ReadLine(), CI);
                numero2 = double.Parse(Console.ReadLine(), CI);
                numero3 = double.Parse(Console.ReadLine(), CI);

                mediaPonderada = (numero1 * 2 + numero2 * 3 + numero3 * 5) / 10;

                Console.WriteLine($"MEDIA PONDERADA = {mediaPonderada.ToString("F1", CI)}");
            } 
        }
    }
}
