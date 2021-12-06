using System;

namespace _03ExercicioEscolar
{
    class Program
    {
        static void Main(string[] args)
        {
           //instanciar objeto da classe aluno
           Aluno a = new Aluno();
           a.nome = "Aurora";
           a.nota1 = 10;
           a.nota2 = 8;
           a.mensagem();
        }
   
       
    }
}