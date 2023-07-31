using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraOO {
    public class Calculadora {
        //private int opcao { get; set; }

        public Calculadora() {
        }

        public void Iniciar() {
            EscolherOpcaoMenu();
        }

        public static void Menu() {
            Console.WriteLine("");
            Console.WriteLine("### CALCULADORA ###");
            Console.WriteLine("-------------------");
            Console.WriteLine("Escolha uma das operações:");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("0 - Sair");
            Console.Write("Opção: ");
        }

        private static int ValidarOpcaoMenu() {
            int opcaoMenu = 0;
            bool opcaoValida = false;
            do {
                try {
                    Menu();
                    opcaoMenu = int.Parse(Console.ReadLine());
                    if (opcaoMenu >= 0 && opcaoMenu <= 4) {
                        opcaoValida = true;
                    } else {
                        Console.WriteLine("Opcao inválida!");
                    }
                } catch (Exception e) {
                    Console.WriteLine("Opcao deve ser numérica!");
                }
            } while (!opcaoValida);
            return opcaoMenu;
        }

        private static void EscolherOpcaoMenu() {
            int opcao = ValidarOpcaoMenu();
            double a, b, resposta = 0.0;
            while (opcao != 0) {
                a = LerNumero("Digite o primeiro número: ");
                b = LerNumero("Digite o segundo número: ");
                switch (opcao) {
                    case 1:
                        resposta = Soma(a, b);
                        break;
                    case 2:
                        resposta = Subtracao(a, b);
                        break;
                    case 3:
                        resposta = Multiplicacao(a, b);
                        break;
                    case 4:
                        resposta = Divisao(a, b);
                        break;
                }
                Console.WriteLine("Resposta = " + resposta);
                opcao = ValidarOpcaoMenu();
            }
        }

        private static double LerNumero(string mensagem) {
            double numero = 0.0;
            bool numeroValido = false;

            while (!numeroValido) {
                try {
                    Console.Write(mensagem);
                    numero = double.Parse(Console.ReadLine());
                    numeroValido = true;
                } catch (Exception e) {
                    Console.WriteLine("Não é um número, tente novamente");
                }
            }
            return numero;
        }

        private static double Soma(double a, double b) {
            return a + b;
        }

        private static double Subtracao(double a, double b) {
            return a - b;
        }

        private static double Multiplicacao(double a, double b) {
            return a * b;
        }

        private static double Divisao(double a, double b) {
            double resposta = 0.0;
            if (b != 0) {
                resposta = a / b;
            } else {
                Console.WriteLine("Erro, divisão por zero!");
            }
            return resposta;
        }
    }
}
