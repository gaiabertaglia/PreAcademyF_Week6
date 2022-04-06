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

    Console.WriteLine("\n0. Exit");

    int scelta;
    do
    {
        Console.WriteLine("scegli cosa fare!");
    } while (!(int.TryParse(Console.ReadLine(), out scelta) && scelta >= 0 && scelta <= 6));

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

            break;
        case 4:

            break;
        case 5:

            break;
        case 6:

            break;
        case 0:
            continua = false;
            break;
    }

}