//                                    PROGRAMMA PRINCIPALE


Console.Write("Quanti cibi vorresti inserire? ");
string stringElementi = Console.ReadLine();

int intElementi = int.Parse(stringElementi);
string[] cibiPreferiti = new string [intElementi];



for(int i = 0; i < intElementi; i++)
{
    cibiPreferiti[i] = Console.ReadLine();
}


int lunghezza = LunghezzaClassifica(cibiPreferiti);


Console.WriteLine($"\n\n\nLa mia classifica di piatti  preferiti è composta da ben {lunghezza} piatti.");

Classifica(cibiPreferiti);

CiboPref(cibiPreferiti);

CiboNotPref(cibiPreferiti);


Console.WriteLine("Ed ora a grande richiesta stamperemo i cibi che si trovano più in mezzo. \n\n\n");

StampaArrayMediana(cibiPreferiti);

//IndiciMedianaArray(cibiPreferiti);





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

/*
void IndiciMedianaArray(string[] array)
{
    int lunghezzaArray = array.Length;
    int[] indici = new int[2];
    int indice;
    int indiceSuppl;


    if(lunghezzaArray%2 == 0) 
    {
        indice = lunghezzaArray / 2;
        StampaArrayMediana(indice, array);
        indiceSuppl = lunghezzaArray / 2 - 1;
        StampaArrayMediana(indiceSuppl, array);
    }
    else
    {
        indice = lunghezza / 2;
        StampaArrayMediana(indice, array);
    }
    
    
}


void StampaArrayMediana(int indiceDaStampare , string[] array)
{
    Console.WriteLine(array[indiceDaStampare]);
}



*/

//***************************************************** FUNZIONE PROIBITA ****************************************************




(int, int) IndiciMedianaArray(int lunghezzaArray)
{
   
    int indice;
    int indiceSuppl;


    if (lunghezzaArray % 2 == 0)
    {
        indice = lunghezzaArray / 2;
        indiceSuppl = lunghezzaArray / 2 - 1;
    }
    else
    {
        indice = lunghezza / 2;
        indiceSuppl = -1;
    }

    return (indice, indiceSuppl);
}


void StampaArrayMediana(string[] array)
{
    int lunghezza = array.Length;
    var indici = IndiciMedianaArray(lunghezza);

    Console.WriteLine(array[indici.Item1]);
    if(indici.Item2 != -1)
    {
        Console.WriteLine(array[indici.Item2]);
    }
    
    
    
}


