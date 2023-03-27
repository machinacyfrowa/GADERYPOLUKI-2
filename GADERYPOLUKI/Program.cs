﻿string gaderypoluki(string text)
{
    //para G->A, A->G
    text = text.Replace('G', '@');
    text = text.Replace('A', 'G');
    text = text.Replace('@', 'A');

    //para D->E, E->D
    text = text.Replace('D', '@');
    text = text.Replace('E', 'D');
    text = text.Replace('@', 'E');

    //para R->Y, Y->R
    text = text.Replace('R', '@');
    text = text.Replace('Y', 'R');
    text = text.Replace('@', 'Y');

    //para P->O, O->P
    text = text.Replace('P', '@');
    text = text.Replace('O', 'P');
    text = text.Replace('@', 'O');

    //para L->U, U->L
    text = text.Replace('L', '@');
    text = text.Replace('U', 'L');
    text = text.Replace('@', 'U');

    //para K->I, I->K
    text = text.Replace('K', '@');
    text = text.Replace('I', 'K');
    text = text.Replace('@', 'I');

    return text;
}
string gaderypoluki2(string text)
{
    string newText = "";
    foreach(char c in text)
    {
        switch(c)
        {
            case 'A':
                newText += 'G';
                break;
            case 'G':
                newText += 'A';
                break;
        }
    }
    return newText;
}

string text = "ALA MA KOTA";

string text1 = gaderypoluki(text);

Console.WriteLine("Funkcja gaderypoluki(): " + text1);

string text2 = gaderypoluki2(text);

Console.WriteLine("Funkcja gaderypoluki2(): " + text2);