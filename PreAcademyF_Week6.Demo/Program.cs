// See https://aka.ms/new-console-template for more information
using PreAcademyF_Week6.Demo;

Console.WriteLine("Hello, World!");

//Persona p1 = new Persona("Renata", "Carriero", new DateTime(1987, 04, 01));
//Persona.Saluta(p1); //statico
//p1.Saluta(); //di istanza


Studente s1 = new Studente("Mario", "Rossi",new DateTime(1980, 01, 01));
s1.Saluta();

ClasseStatica.Parole.Add("pippo");

foreach (var item in ClasseStatica.Parole)
{
    Console.WriteLine(item);
}
//Persona persona=new Persona();
Persona p = new Studente("Maria", "Rossa", new DateTime(1980, 01, 01));
p.Saluta();
p.Saluta2();
//p.SalutaTutti();


Persona p1 = s1;

Docente d = new Docente("Dante", "Alighieri", new DateTime(1999, 01,01), 100);

IRepository<Studente> miaListaStudenti = new RepositoryStudentiMock();
bool esito = miaListaStudenti.Aggiungi(s1);


IRepository<Persona> elencoPersone= new RepositoryPersonaMock();
elencoPersone.Aggiungi(s1);
elencoPersone.Aggiungi(d);

foreach (var item in elencoPersone.GetAll())
{
    Console.WriteLine(item.Nome + item.Cognome);
    item.Saluta2();
    Console.WriteLine(item.ToString());
    Console.WriteLine("---------------------");
}

Persona nuovaPersona = new Persona("Francesca", "Collari", new DateTime(1999, 10,10));


miaListaStudenti.Aggiungi((Studente)nuovaPersona);

Console.WriteLine("---------------------");

foreach (var item in miaListaStudenti.GetAll())
{
    Console.WriteLine(item.ToString());
}

