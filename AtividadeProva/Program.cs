using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeProva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Prova prova = new Prova();

            string nomeAluno, resposta;
            int notaAluno = 0, op = 0;

            do
            {

                Console.WriteLine("Digite o nome do aluno: ");
                nomeAluno = Console.ReadLine();

                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Insira  a resposta da " + (i + 1) + "ª questão: ");
                    resposta = Console.ReadLine().ToUpper();
                    prova.RespostaAluno(resposta);
                }

                prova.QuantidadeAcertos();
                prova.Notas();

                if (prova.provaNotaMaior == null)
                {
                    prova.provaNotaMaior = prova;
                }

                if (prova.nota > prova.provaNotaMaior.nota)
                {
                    prova.provaNotaMaior = prova;
                }

                Console.WriteLine("\n -------------- RESULTADO --------------");
                Console.WriteLine("Nome: " + nomeAluno);
                Console.WriteLine("Quantidade de acertos na prova: " + prova.quantAcertos);
                Console.WriteLine("Nota: " + prova.nota);
                Console.WriteLine("Maior nota: " + prova.provaNotaMaior.nota);
                Console.WriteLine("\n Insira '1' para adicionar outro aluno, ou qualquer outro número para finalizar: ");
                op = Convert.ToInt32(Console.ReadLine());

                prova.nota = 0;
                prova.quantAcertos = 0;
                prova.respostas.Clear();

            } while (op == 1);


            Console.ReadKey();

        }

    }
}
