// See https://aka.ms/new-console-template for more information
using PreAcademyF_Week6.ADO;

Console.WriteLine("Hello, World!");

// L'utente può:
// Vedere tutti i film nella videoteca
// Cercere i film per genere
// Cercare i film per titolo
// Cercare i film che hanno una durata minore di tot minuti
// Cercare i film di un genere che hanno anche una durata maggiore di tot minuti
// Stampare il numero di film nella videoteca

// Far scegliere all'utente i soli generi presenti
// oppure gestire se non trova film con il genere inserito

Console.WriteLine("Benvenuti nella Videoteca");
//ManagerMock repository = new ManagerMock();
//ManagerDB repository=new ManagerDB();
IManager repository = new ManagerDB();
bool continua = true;
while (continua)
{
    Console.WriteLine("---------------------------MENU-------------------");
    Console.WriteLine("1. Stampa Film della videoteca");
    Console.WriteLine("2. Cerca Film per genere");
    Console.WriteLine("3. Cerca Film per titolo");
    Console.WriteLine("4. Cerca Film che hanno una durata minore di tot minuti");
    Console.WriteLine("5. Cerca Film di un genere che hanno anche una durata maggiore di tot minuti");
    Console.WriteLine("6. Stampa il numero di film nella videoteca");
    Console.WriteLine("7. Inserisci un nuovo Film");
    Console.WriteLine("8. Modifica durata di un Film");
    Console.WriteLine("9. Elimina Film");

    Console.WriteLine("\n0. Exit");

    int scelta;
    do
    {
        Console.WriteLine("scegli cosa fare!");
    } while (!(int.TryParse(Console.ReadLine(), out scelta) && scelta >= 0 && scelta <= 9));

    switch (scelta)
    {
        case 1:
            Console.WriteLine("I film presenti nella videoteca sono: ");
            repository.GetAllFilms();
            break;
        case 2:
            Console.WriteLine("I film di quale genere vuoi vedere?");
            string g= Console.ReadLine();
            repository.GetFilmByGenere(g);
            break;
        case 3:
            Console.WriteLine("Inserisci il Titolo da ricercare:\n");
            string titolo = Console.ReadLine();
            repository.GetFilmByTitolo(titolo);
            break;
        case 4:
            int durata;
            Console.WriteLine("Inserisci la durata Max. (Ti verranno restituiti i film con durano di meno):\n");

            while (!(int.TryParse(Console.ReadLine(), out durata) && durata > 0))
            {
                Console.WriteLine("Valore errato. Riprova:");
            }
            repository.GetFilmByDurataMaggioreDi(durata);
            break;
        case 5:
            Console.WriteLine("Inserisci il genere da ricercare:\n");
            string genere = Console.ReadLine();
            int d;
            Console.WriteLine("Inserisci la durata Min:\n");

            while (!(int.TryParse(Console.ReadLine(), out d) && d > 0))
            {
                Console.WriteLine("Valore errato. Riprova:");
            }
            repository.GetFilmByGenereEDurataMinoreDi(genere, d);
            break;
        case 6:
            repository.GetNumeroDiFilm();
            break;
        case 7:
            Console.WriteLine("Inserisci il titolo del nuovo film");
            string t= Console.ReadLine();
            Console.WriteLine("Inserisci il genere del nuovo film");
            string gener = Console.ReadLine();
            Console.WriteLine("Inserisci la durata del nuovo film");
            int dur = int.Parse(Console.ReadLine());
            repository.InserisciFilm(t, gener, dur);
            break;
        case 8:
            Console.WriteLine("Inserisci l'id del film da modificare");
            int idFilm = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserisci la nuova durata del film");
            int nuovaDurata = int.Parse(Console.ReadLine());
            repository.ModificaDurataFilm(idFilm, nuovaDurata);
            break;
        case 9:
            Console.WriteLine("Inserisci l'id del film da eliminare");
            int idFilmDaEliminare = int.Parse(Console.ReadLine());            
            repository.EliminaFilm(idFilmDaEliminare);
            break;
        case 0:
            continua = false;
            break;
    }
}