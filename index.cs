using System;
class Program{
    static void Main(string[] args) {
        Console.WriteLine("Clica enter para continuar..");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Sistema Carregando");
        Thread.Sleep(2000);
        int i = 0;
        while (i != 1) {
            Console.Clear();
            Console.WriteLine("[1] Calcular");
            Console.WriteLine("[2] Sobre");
            Console.WriteLine("[3] Sair ");
            int resposta = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Carregando as informações");
            Thread.Sleep(1000);
            if(resposta == 1) {
                Console.Clear();
                int il = 0;
                while(il != 1) {
                Console.WriteLine("Fala os números");
                double s1 = double.Parse(Console.ReadLine());
                double s2 = double.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Beleza, agora seleciona qual vai ser");

                Console.WriteLine("[1] Adição ");
                Console.WriteLine("[2] Subtração ");
                Console.WriteLine("[3] Divisão ");
                Console.WriteLine("[4] Multiplicação ");
                Console.WriteLine("[5] Sair ");


                double Resultado = 0.0;
                int seleciona = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (seleciona) {
                case 1:
                    Resultado = s1 + s2;
                    Console.WriteLine("Resultado " + Resultado);
                    break;

                case 2:
                    Resultado = s1 - s2;
                    Console.WriteLine("Resultado " + Resultado);
                    break;
                
                case 3:
                    Resultado = s1 / s2;
                    Console.WriteLine("Resultado " + Resultado);
                    break;
                
                case 4:
                    Resultado = s1 * s2;
                    Console.WriteLine("Resultado " + Resultado);
                    break;

                case 5:
                   il = 1;
                   Console.WriteLine("Voltando Ao Inicio");
                   break;

                default:
                    Console.WriteLine("Informação Invalida!");
                    il = 1;
                    break;
                
                }
                Thread.Sleep(3000);
                Console.Clear();
              

                }
            }

            else if (resposta == 2) {
                Console.Clear();
                Console.WriteLine("Calculadora Simples Em CMD (Feito Em C#)");
                Console.WriteLine("Voltando... ");
                Thread.Sleep(4000);
            }
            else if(resposta == 3) {
                 i = 1;
            
            }
        }
    }
}
