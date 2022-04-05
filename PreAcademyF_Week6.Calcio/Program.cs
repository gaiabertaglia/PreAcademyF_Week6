// See https://aka.ms/new-console-template for more information
using PreAcademyF_Week6.Calcio;

Console.WriteLine("Calcio");
// gli atleti hanno nome, cognome, età

// Calciatori hannno ruolo e numero maglia(ruoli = centrocampista e difensore portiere e attaccante)

// Portieri hanno di default il numero maglia = 1 e il numero gol subiti

// gli attaccanti hanno il numero gol fatti a partita

// Una squadra di calcio è formata da 11 calciatori di cui
// un portiere
// 4 difensori
// 4 centrocampisti
// 2 attaccanti

//Per svolgere una partita serve anche un arbitro(l'arbitro è un atleta)

Portiere p = new Portiere("Antonio", "Donnarumma", 20, 99);
Calciatore d1 = new Calciatore("Alessio", "Romagnoli", 22, 13, Ruolo.Difensore);
Calciatore c1 = new Calciatore("Sandro", "Tonali", 30, 8, Ruolo.Centrocapista);
Attaccante a1 = new Attaccante("Daniel", "Maldini", 25, 20);

List<Calciatore> milan = new List<Calciatore>();


SquadraManager.AddCalciatore(p, milan);
SquadraManager.AddCalciatore(d1, milan);
SquadraManager.AddCalciatore(c1, milan);
SquadraManager.AddCalciatore(a1, milan);

Console.WriteLine("La formazione è :");
foreach (var item in milan)
{
    Console.WriteLine(item.ToString());
}

Portiere p1 = new Portiere("Gigi", "Buffon", 40);
SquadraManager.AddCalciatore(p1, milan);

Console.ReadLine();
