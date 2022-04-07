// See https://aka.ms/new-console-template for more information
using PreAcademyF_Week6.Biblioteca;

Console.WriteLine("Hello, World!");

// Creare un programma per la gestione di libri da parte del proprietario del biblioteca
// I libri hanno titolo - autore - codice ISBN -> abstract
// Gli audiolibri hanno anche la durata in minuti
// I libri cartacei hanno il numero di pagine e la quantità in magazzino

// Il proprietario può
// vedere tutti i libri stampando titolo, autore e se è o no audiolibro
// vedere tutta la lista di libri cartacei
// vedere tutta la lista di audiolibri
// Modificare la quantità in magazzino di un libro cartaceo 
// Modificare la durata in minuti di un audiolibro
// Cercare per titolo tutti i film (Se inserisce un titolo gli viene mostrato sia il libro cartaceo che l'audiolibro)
// Può inserire un nuovo libro cartaceo o audiolibro 
// Nota:prima di inserirlo verificare che non sia già presente tramite codice ISBN


// Gestire il db sia in connected mode che i repository mock


Console.WriteLine("Benvenuto nella Biblioteca");
RepositoryAudiolibriMOCK repositoryAudioLibri = new RepositoryAudiolibriMOCK();
RepositoryLibriCartaceiMOCK repositoryLibriCartacei = new RepositoryLibriCartaceiMOCK();


bool continua = true;
while (continua)
{
    Console.WriteLine("---------------------------MENU-------------------");
    Console.WriteLine("1. Stampa tutti i libri");
    Console.WriteLine("2. Stampa tutti i libri cartacei");
    Console.WriteLine("3. Stampa tutti gli audiolibrilibri");

    Console.WriteLine("\n0. Exit");

    int scelta;
    do
    {
        Console.WriteLine("scegli cosa fare!");
    } while (!(int.TryParse(Console.ReadLine(), out scelta) && scelta >= 0 && scelta <= 3));

    switch (scelta)
    {
        case 1:
            //Visualizzare Tutti i libri
            VisualizzaTutti();
            break;
        case 2:
            StampaTuttiILibriCartacei();
            break;
        case 3:
            StampaTuttiGliAudiolibri();
            break;
        case 0:
            continua = false;
            Console.WriteLine("Arrivederci!");
            break;
    }
}

void VisualizzaTutti()
{
    Console.WriteLine("Tutti i libri della biblioteca sono:");
    var audiolibri = repositoryAudioLibri.GetAll();
    var libriCartacei=repositoryLibriCartacei.GetAll();
    List<Libro> listaCompleta=new List<Libro>();
    listaCompleta.AddRange(audiolibri);
    listaCompleta.AddRange(libriCartacei);

    foreach (var item in listaCompleta)
    {
        Console.WriteLine(item.ToString());
    }

}

void StampaTuttiGliAudiolibri()
{
    var audiolibri = repositoryAudioLibri.GetAll();
    if(audiolibri.Count == 0)
    {
        Console.WriteLine("Lista vuota");
    }
    else
    {
        Console.WriteLine("Ecco tutti gli audiolibri");
        foreach (var item in audiolibri)
        {
            Console.WriteLine(item.ToString());
        }
    }
    
}

void StampaTuttiILibriCartacei()
{
    var listaLibri=repositoryLibriCartacei.GetAll();
    if (listaLibri.Count == 0)
    {
        Console.WriteLine("Lista vuota");
    }
    else
    {
        Console.WriteLine("Ecco tutti i libri cartacei");
        foreach (var item in listaLibri)
        {
            Console.WriteLine(item);
        }
    }
}