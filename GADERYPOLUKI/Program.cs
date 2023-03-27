string gaderypoluki(string text)
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
    text = text.Replace('L', '@');
    text = text.Replace('U', 'L');
    text = text.Replace('@', 'U');

    return text;
}


string text = "ALA MA KOTA";

text = gaderypoluki(text);

Console.WriteLine(text);