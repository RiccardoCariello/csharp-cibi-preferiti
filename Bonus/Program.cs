//                                    PROGRAMMA PRINCIPALE



Console.Write("Quanti cibi vorresti inserire? ");

Console.ReadLine(numeroElementi);



string cibiPreferiti = [];
int lunghezza = LunghezzaClassifica(cibiPreferiti);


Console.WriteLine($"La mia classifica di piatti  preferiti è composta da ben {lunghezza} piatti.");

Classifica(cibiPreferiti);

CiboPref(cibiPreferiti);

CiboNotPref(cibiPreferiti);




//******************************************************************************************************************
//
//                                              FUNZIONI
//
//******************************************************************************************************************



int LunghezzaClassifica(string[] array)
{
    int lunghezza = array.Length;
    return lunghezza;
}

void Classifica(string[] array)
{
    Console.WriteLine("Vuoi sapere esattamente quali sono i miei piatti? e va bene. \n");
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(i + 1 + "- " + array[i]);
    }
}


void CiboPref(string[] array)
{
    Console.WriteLine("Il mio cibo preferito è indubbiamente un bel piatto di : " + array[0]);
}

void CiboNotPref(string[] array)
{
    int i = array.Length - 1;
    Console.WriteLine("Il cibo che meno preferisco invece è inubbiamente un piatto di :" + array[i]);
}