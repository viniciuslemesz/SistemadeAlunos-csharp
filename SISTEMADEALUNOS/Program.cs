using System;
using System.Globalization; // importa a cultura variavel
    
namespace SISTEMADEALUNOS
{

    class Program
    {
        static void Main (string[] args) //metodo que executa o programa
        {
            Console.WriteLine("Digite o nome do aluno: "); //Impressao de mensagem
            string nome = Console.ReadLine(); // le e armazena uma variavel string

            Console.WriteLine("Digite a primeiro nota: "); //Impressao de mensagem
            double nota1 = double.Parse( // le como texto e converte para double("ponto")
                Console.ReadLine(),
                CultureInfo.InvariantCulture // garante o separador decimal
            );
        
            Console.WriteLine("Digite a segunda nota: ");
            double nota2 = double.Parse(
                Console.ReadLine(),
                CultureInfo.InvariantCulture
            );

            Aluno aluno = new Aluno(nome, nota1, nota2);

            aluno.ExibirResultado();


        }
    }
}