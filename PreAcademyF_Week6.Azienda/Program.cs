// See https://aka.ms/new-console-template for more information
using PreAcademyF_Week6.Azienda;

Console.WriteLine("Hello, World!");
//In un’azienda lavorano Tecnici, Stagisti e Manager.

//Tecnico: Nome, Cognome, Paga Oraria, Codice Fiscale

//Stagista: Nome, Cognome, Compenso Mensile fisso

//Manager: è un Tecnico. Ha un bonus Mensile in più rispetto al tecnico. 

//Per ogni dipendente deve essere possibile stampare i dati anagrafici (nome e cognome),
//il ruolo(se si tratta di Stagista, Tecnico o Manager), Stampare lo stipendio, stampare le ferie.



//Dati d = new Dati() { Nome="Tizio", Cognome="Tizi", CF="codiceF"};

//Tecnico t2 = new Tecnico(d);

Tecnico t = new Tecnico("Mario", "Rossi", "cfmariorossi");
Stagista s = new Stagista("Renata", "Carriero");
Manager m = new Manager("Giuseppe", "Bianchi", "cfgiuseppeB", 20);
m.StampaRuolo();
List<Dipendente> dipendentiAzienda= new List<Dipendente>();
dipendentiAzienda.Add(m);
dipendentiAzienda.Add(t);
dipendentiAzienda.Add(s);

foreach (var item in dipendentiAzienda)
{
    item.StampaDatiAnagrafici();
    item.StampaRuolo();
    item.StampaStipendio();
    item.StampaFerie();
    Console.WriteLine("----------------------------");
}


