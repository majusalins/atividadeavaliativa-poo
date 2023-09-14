using System;
using System.Collections.Generic;

public class Gabarito
{
    List<char> alternativas = new List<char>();

    public Gabarito()
    {
        alternativas.Add('A');
        alternativas.Add('B');
        alternativas.Add('C');
        alternativas.Add('D');
        alternativas.Add('E');
    }
    public char RespostaQuestao(int numquestao)
    {
        return alternativas[numquestao];
    }
}