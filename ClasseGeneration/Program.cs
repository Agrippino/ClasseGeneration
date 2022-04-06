//----------VATIABILI GLOBALI-------------
int alunniIscritti = 0;
int SedieDisponibili = 10;
string[] nomiAlunni = new string[SedieDisponibili];
string[] cognomiAlunni = new string[SedieDisponibili];
int[] etaAlunni = new int[SedieDisponibili];
int[] etaMediaAlunni = calcolaEtaMediaClasse(etaAlunni, alunniIscritti);

//-----------FUNZIONI---------

void aggiungiAlunnno(string nomi, string cognomi, int eta)
{
    if (alunniIscritti < SedieDisponibili)
    {
        nomiAlunni[alunniIscritti] = nomi;
        cognomiAlunni[alunniIscritti] = cognomi;
        etaAlunni[alunniIscritti] = eta;
        alunniIscritti++;
    }
    else
    {
        Console.WriteLine("Mi dispaice ma l'aula è piena");
    }
}
void rimuoviAlunni()
{
    if (SedieDisponibili > 0)
    {
        alunniIscritti--;
        nomiAlunni[alunniIscritti] = "";
        cognomiAlunni[alunniIscritti] = "";
        etaAlunni[alunniIscritti] = 0;
    }
    else
    {
        Console.WriteLine("Mi dispaice l'aula è vuota");
    }
}


//----------PROGAMMA PRINCIPALE--------------

Console.WriteLine("Il numero di alunni presenti nell'aula è: " + alunniIscritti);

while (true)
{
    Console.Write("Si è iscritto un nuovo alunno alla classe [aggiungi/rimuovi] ?");
    string Risposta = Console.ReadLine();

    switch (Risposta)
    {
        case "aggiungi":
            Console.WriteLine("Qual è il nome dell'alunno: ");
            string nomeAlunno = Console.ReadLine();
            Console.WriteLine("Qual è il congnome dell'alunno: ");
            string cognomeAlunno = Console.ReadLine();
            Console.WriteLine("Quanti anni ha l'alunno: ");
            int etaAlunno = int.Parse(Console.ReadLine());
            aggiungiAlunnno(nomeAlunno, cognomeAlunno, etaAlunno);
            break;
        case "rimuovi":
            rimuoviAlunni();
            break;
        default:
            Console.WriteLine("Mi dispiace inserisci un opzione valida");
            break;
    }

    Console.WriteLine("Il numero di alunni presenti nell'aula è: " + alunniIscritti);
    StampaArrayNomi(nomiAlunni);
    StampaArrayCognomi(cognomiAlunni);
    StampaArrayeta(etaAlunni);

}



//---------FUNZIONE ETA-------------
Console.WriteLine("Vuoi stampare l'età media della classe [si/no]?");
string etaMediaClasse = Console.ReadLine();

switch (etaMediaClasse)
{
    case "si":
        Console.WriteLine(etaMediaClasse);
        break;
    case "no":
        Console.WriteLine("");
        break;
}


int calcolaEtaMediaClasse(int Eta, int numeroAlunno)
{
    int somma = Eta / numeroAlunno;
    return somma;
}


//----------STAMPA ARRAY--------

void StampaArrayNomi(string[] array)
{
    int ultimoIndiceArray = array.Length - 1;
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == ultimoIndiceArray)
        {
            Console.Write(array[i]);
        }
        else
        {
            Console.Write(array[i] + ", ");
        }
    }
    Console.WriteLine("]");
}

void StampaArrayCognomi(string[] array)
{
    int ultimoIndiceArray = array.Length - 1;
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == ultimoIndiceArray)
        {
            Console.Write(array[i]);
        }
        else
        {
            Console.Write(array[i] + ", ");
        }
    }
    Console.WriteLine("]");
}

void StampaArrayeta(int[] array)
{
    int ultimoIndiceArray = array.Length - 1;
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == ultimoIndiceArray)
        {
            Console.Write(array[i]);
        }
        else
        {
            Console.Write(array[i] + ", ");
        }
    }
    Console.WriteLine("]");
}
