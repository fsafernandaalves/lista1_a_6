using System;

namespace Lista3
{
    class Program
    {
        static void Main(string[] args)
        {

            // QUESTÃO 01 //
            int digitos, a, b, c, d;


            Console.WriteLine("Digite um numero de 4 digitos: ");
            digitos = int.Parse(Console.ReadLine());

            a = digitos / 1000;
            a = a + 7;

            b = digitos / 100;
            b = b % 10;
            b = b + 7;

            c = digitos / 10;
            c = c % 10;
            c = c + 7;

            d = digitos / 1;
            d = d % 10;
            d = d + 7;

            Console.Write(c);
            Console.Write(d);
            Console.Write(a);
            Console.Write(b);


            Console.Write("\n\n\nAperte enter para a proxima questão");
            Console.ReadKey();
            Console.Clear();

            // QUESTÃO 02 //

            int saldo = 0;

            Console.WriteLine("Informe o saldo: \n");
            saldo = Convert.ToInt32(Console.ReadLine());

            Cliente cliente = new Cliente(saldo, 200, 500, 450, 5000);
            Console.WriteLine("Novo saldo: \n");
            Console.WriteLine(cliente.NovoSaldo());

            cliente.AtualizaSaldo();

            if (cliente.Limiteestourado())
                Console.WriteLine("Limite estourado!");
            else
                Console.WriteLine("Crédito Disponivel!");

            Console.ReadKey();
            Console.Clear();

            // QUESTÃO 03 //

            bool par = true;
            bool impar = false;
            int valor03;

            Console.Write("Digite um valor de 0 a 10: \n\n");
            valor03 = int.Parse(Console.ReadLine());

            if (valor03 % 2 == 0)
            {
                Console.Write(par);
            }

            else if (valor03 % 2 != 0)
            {
                Console.Write(impar);
            }

                Console.Write("\n\n\nAperte enter para a proxima questão");
                Console.ReadKey();
                Console.Clear();


            // QUESTÃO 04 //

            int ladoa, ladob, ladoc;

            Console.Write("Digite um valor para o lado A: ");
            ladoa = int.Parse(Console.ReadLine());

            Console.Write("Digite um valor para o lado B: ");
            ladob = int.Parse(Console.ReadLine());

            Console.Write("Digite um valor para o lado C: ");
            ladoc = int.Parse(Console.ReadLine());


            if (ladoa == ladob && ladoa == ladoc)
            {
                Console.Write("\n\n O triângulo é equilátero");
            }

            else if (ladoa != ladob && ladoa != ladoc && ladoc != ladob)
            {
                Console.Write("\n\n O triângulo é escaleno");
            }

            else 
            {
                Console.Write("\n\n O triângulo é isoceles");
            }


            Console.Write("\n\n\nAperte enter para a proxima questão");
            Console.ReadKey();
            Console.Clear();


            // QUESTÃO 05 //

            string entrada = "";
            string letra;
            int maximo;
            string[] vogal = { "a", "e", "i", "o", "u" };
            string resultado = "";

            do
            {
                Console.Write("Digite a letra desejada: ");
                letra = Console.ReadLine();
                maximo = letra.Length;
                if (maximo > 1)
                {
                    Console.WriteLine("\nO numero de caracteres digitados não é permitido.");
                }
                else
                {
                    entrada = letra[0].ToString();
                }
            } while (maximo > 1);

            Console.WriteLine(entrada);

            for (int i = 0; i < vogal.Length; i++)
            {
                if (letra == vogal[i])
                {
                    resultado = "\nA letra " + letra + " é uma vogal";
                    break;
                }
            }

            if (resultado == "")
            {
                resultado = "\nA letra " + letra + " é uma consoante";
            }

            Console.WriteLine(resultado);
            Console.ReadLine();

            Console.ReadKey();
            Console.Clear();

            // QUESTÃO 06 //

            int numerof;
            int dd;
            int p;
            p = 0;

            Console.WriteLine("\nDigite um número: ");
            numerof = int.Parse(Console.ReadLine());

            for (dd = 1; dd <= numerof; dd++)
            {
                if (numerof % dd == 0)
                {
                    p = p + 1;
                }
            }

            if (p > 2)
            {
                Console.WriteLine("{0} É um número primo", numerof);
            }

            else
            {
                Console.WriteLine("{0} Não é um número primo", numerof);
            }

            Console.ReadLine();
            Console.ReadKey();
            Console.Clear();
        }
    }
    }


    





