using System;

namespace SISTEMADEALUNOS{

    public class Aluno
    {

        //PROPRIEDADE DA CLASSE
        public string nome {get; set;} 
        // get = variavel pode ser lida  
        // set = variavel pode ser modificada
        public double nota1 {get; set;}

        public double nota2 {get; set;}
    
        public Aluno(string nome, double nota1, double nota2) // construtor da classe
        {
            this.nome = nome;
            this.nota1 = nota1;
            this.nota2 = nota2;
        }

        public void ExibirResultado ()
        {
            double media = CalcularMedia();    
            Console.WriteLine($"\nAluno: {nome}");
            Console.WriteLine ($"Media: {media}");

        if (media >= 6.0)
        {
            Console.WriteLine("Status: Aprovado");
        }   
         else
        {
            Console.WriteLine("Status: Reprovado");    
        }
 
        }

    public double CalcularMedia()
    {
        return (nota1 + nota2) / 2;
    }

    }

}