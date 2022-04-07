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
//RepositoryAudiolibriMOCK repositoryAudioLibri = new RepositoryAudiolibriMOCK();
//RepositoryLibriCartaceiMOCK repositoryLibriCartacei = new RepositoryLibriCartaceiMOCK();
RepositoryAudioLibriDbADO repositoryAudioLibri = new RepositoryAudioLibriDbADO();
RepositoryLibriCartaceiDbADO repositoryLibriCartacei = new RepositoryLibriCartaceiDbADO();


bool continua = true;
while (continua)
{
    Console.WriteLine("---------------------------MENU-------------------");
    Console.WriteLine("1. Stampa tutti i libri");
    Console.WriteLine("2. Stampa tutti i libri cartacei");
    Console.WriteLine("3. Stampa tutti gli audiolibrilibri");
    Console.WriteLine("4. Modifica quantità in magazzino di un libro cartaceo");
    Console.WriteLine("5. Modifica la durata in minuti di un audiolibro");
    Console.WriteLine("6. Cercare per titolo tutti i film");
    Console.WriteLine("7. Inserire un nuovo libro cartaceo o audiolibro");
    Console.WriteLine("\n0. Exit");

    int scelta;
    do
    {
        Console.WriteLine("scegli cosa fare!");
    } while (!(int.TryParse(Console.ReadLine(), out scelta) && scelta >= 0 && scelta <= 7));

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
        case 4:
            ModificaQuantitàLibroCartaceo();
            break;
        case 5:
            ModificaDurataAudiolibro();
            break;
        case 6:
            
            break;
        case 7:
            InserisciNuovoLibro();
            break;
        case 0:
            continua = false;
            Console.WriteLine("Arrivederci!");
            break;
    }
}

void InserisciNuovoLibro()
{
    Console.WriteLine("Quale libro vuoi inserire?");
    Console.WriteLine("1. Libro Cartaceo");
    Console.WriteLine("2. Audiolibro");
    int scelta;
    while (!(int.TryParse(Console.ReadLine(), out scelta) && scelta >= 1 && scelta <= 2))
    {
        Console.WriteLine("Errore. Riprova:");
    }
    switch (scelta)
    {
        case 1:
            int isbn;
            Console.WriteLine("Inserisci ISBN");
            while (!(int.TryParse(Console.ReadLine(), out isbn) && isbn > 0 && repositoryLibriCartacei.GetByISBN(isbn) == null))
            {
                Console.WriteLine("Formato errato e/o codice isbn già presente. Riprova");
            }

            Console.WriteLine("Inserisci titolo");
            string titolo = Console.ReadLine();
            Console.WriteLine("Inserisci autore");
            string autore = Console.ReadLine();

            int numPagine;
            Console.WriteLine("Inserisci numero pagine");
            while (!(int.TryParse(Console.ReadLine(), out numPagine) && numPagine > 0))
            {
                Console.WriteLine("Formato errato. Deve essere un intero. Riprova");
            }
            int scorteInMagazzino;
            Console.WriteLine("Inserisci scorte in magazzino");
            while (!(int.TryParse(Console.ReadLine(), out scorteInMagazzino) && scorteInMagazzino > 0))
            {
                Console.WriteLine("Formato errato. Deve essere un intero. Riprova");
            }

            var libroCartaceo = new LibroCartaceo(titolo, autore, isbn, numPagine, scorteInMagazzino);
            bool esito = repositoryLibriCartacei.Aggiungi(libroCartaceo);
            if (esito)
            {
                Console.WriteLine("Aggiunto correttamente");
            }
            else
            {
                Console.WriteLine("Errore. Non è stato possibile aggiungere!");
            }
            break;
        case 2:

            int isbn1;
            Console.WriteLine("Inserisci ISBN");
            while (!(int.TryParse(Console.ReadLine(), out isbn1) && isbn1 > 0 && repositoryAudioLibri.GetByISBN(isbn1) == null))
            {
                Console.WriteLine("Formato errato e/o codice isbn già presente. Riprova. Riprova");
            }
            Console.WriteLine("Inserisci titolo");
            string tit = Console.ReadLine();
            Console.WriteLine("Inserisci autore");
            string aut = Console.ReadLine();

            int durata;
            Console.WriteLine("Inserisci numero pagine");
            while (!(int.TryParse(Console.ReadLine(), out durata) && durata > 0))
            {
                Console.WriteLine("Formato errato. Deve essere un intero. Riprova");
            }

            var audiolibro = new AudioLibro(tit, aut, isbn1, durata);

            bool esito1 = repositoryAudioLibri.Aggiungi(audiolibro);
            if (esito1)
            {
                Console.WriteLine("Aggiunto correttamente");
            }
            else
            {
                Console.WriteLine("Errore. Non è stato possibile aggiungere!");
            }
            break;
    }
}

void ModificaQuantitàLibroCartaceo()
{
    StampaTuttiILibriCartacei();
    Console.WriteLine("Quale Libro vuoi modificare? Inserisci l'isbn");
    int isbnLibrodaModificare;

    while (!(int.TryParse(Console.ReadLine(), out isbnLibrodaModificare)))
    {
        Console.WriteLine("Valore errato. Riprova:");
    }

    var libroEsistente = repositoryLibriCartacei.GetByISBN(isbnLibrodaModificare);
    if (libroEsistente == null)
    {
        Console.WriteLine("Non esiste nessun libro cartaceo con questo isbn");
    }
    else
    {
        int quantità;
        Console.WriteLine("Qual è la nuova quantità?");
        while (!(int.TryParse(Console.ReadLine(), out quantità) && quantità > 0))
        {
            Console.WriteLine("Valore errato. Riprova:");
        }

        bool esito = repositoryLibriCartacei.ModificaQuantita(libroEsistente.ISBN, quantità);
        if (esito == true)
        {
            Console.WriteLine("Modifica effettuata");
        }
        else
        {
            Console.WriteLine("Errore generico");
        }
    }
}

void VisualizzaTutti()
{
    Console.WriteLine("Tutti i libri della biblioteca sono:");
    var audiolibri = repositoryAudioLibri.GetAll();
    var libriCartacei = repositoryLibriCartacei.GetAll();
    List<Libro> listaCompleta = new List<Libro>();
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
    if (audiolibri.Count == 0)
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
    var listaLibri = repositoryLibriCartacei.GetAll();
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
void ModificaDurataAudiolibro()
{
    StampaTuttiGliAudiolibri();
    Console.WriteLine("Quale Libro vuoi modificare? Inserisci l'isbn");
    int isbnlibrodaModificare;

    while (!(int.TryParse(Console.ReadLine(), out isbnlibrodaModificare)))
    {
        Console.WriteLine("Valore errato. Riprova:");
    }

    var libroEsistente = repositoryAudioLibri.GetByISBN(isbnlibrodaModificare);
    if (libroEsistente == null)
    {
        Console.WriteLine("Non esiste nessun audiolibro con questo isbn");
    }
    else
    {
        int durata;
        Console.WriteLine("Qual è la nuova durata?");
        while (!(int.TryParse(Console.ReadLine(), out durata) && durata > 0))
        {
            Console.WriteLine("Valore errato. Riprova:");
        }

        bool esito = repositoryAudioLibri.ModificaDurata(libroEsistente.ISBN, durata);
        if (esito == true)
        {
            Console.WriteLine("Modifica effettuata");
        }
        else
        {
            Console.WriteLine("Errore generico");
        }
    }
}
