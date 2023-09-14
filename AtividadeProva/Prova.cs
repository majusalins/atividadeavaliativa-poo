using System.Collections.Generic;
using System;
using System.Security.Cryptography.X509Certificates;

public class Prova
{
    public List<char> respostas = new List<char>();
    Gabarito gabarito;
    public int quantAcertos = 0, nota = 0;
    public Prova provaNotaMaior;

    public Prova()
    {
        gabarito = new Gabarito();
    }

    public void RespostaAluno(string resposta)
    {

        if (resposta.ToString() != "A" && resposta.ToString() != "B" && resposta.ToString() != "C"
             && resposta.ToString() != "D" && resposta.ToString() != "E")
        {
            Console.WriteLine("Insira uma resposta válida!");
        }

        else
        {
            Console.WriteLine("Sua Resposta: " + resposta);
            this.respostas.Add(Convert.ToChar(resposta));

        }
    }

    public void QuantidadeAcertos()
    {
        for (int i = 0; i < 5; i++)
        {
            if (this.respostas[i] == gabarito.RespostaQuestao(i))
            {
                quantAcertos++;
            }
        }
    }

    public int Notas()
    {
        nota = quantAcertos * 2;
        return nota;
    }

}