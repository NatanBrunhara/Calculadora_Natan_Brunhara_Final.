namespace Calculadora_Natan_Brunhara
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("Escolha uma operação:");
                Console.WriteLine("1. Soma (+)");
                Console.WriteLine("2. Subtração (-)");
                Console.WriteLine("3. Multiplicação (*)");
                Console.WriteLine("4. Divisão (/)");

                Console.Write("Qual a conta pra hoje, patrão?: ");
                string valor = Console.ReadLine();

                string[] numeros = valor.Split(' ');
                if (numeros.Length != 3)
                {
                    Console.WriteLine("Opa, algo deu errado.");
                    continuar = PerguntarSeDesejaContinuar();
                    continue;
                }

                if (!double.TryParse(numeros[0], out double num1) ||
                    !double.TryParse(numeros[2], out double num2))
                {
                    Console.WriteLine("ainda não entendo não numeros, mas quem sabe depois.");
                    continuar = PerguntarSeDesejaContinuar();
                    continue;
                }

                double resultado = 0;

                switch (numeros[1])
                {
                    case "+":
                        resultado = num1 + num2;
                        break;
                    case "-":
                        resultado = num1 - num2;
                        break;
                    case "*":
                        resultado = num1 * num2;
                        break;
                    case "/":
                        if (num2 != 0)
                            resultado = num1 / num2;
                        else
                            Console.WriteLine("Dividir por 0 não rola.");
                        break;
                    default:
                        Console.WriteLine("Operador inválido.");
                        continuar = PerguntarSeDesejaContinuar();
                        continue;
                }

                Console.WriteLine($"O resultado de {numeros} é: {resultado}");

                continuar = PerguntarSeDesejaContinuar();
            }
        }

       static bool PerguntarSeDesejaContinuar()
        {
            Console.Write("quer tentar de novo? (S/N): ");
            string resposta = Console.ReadLine().ToUpper();

            return (resposta == "S");
        }
    }
}
