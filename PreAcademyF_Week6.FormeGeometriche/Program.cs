// See https://aka.ms/new-console-template for more information
using PreAcademyF_Week6.FormeGeometriche;
using System.Collections;

Console.WriteLine("Forme geometriche");

//Realizzare un'interfaccia Forma che rappresenti una forma geometrica,
//e che preveda dei metodi per inserire le dimensioni da tastiera, stampare a video le dimensioni,
//calcolare il perimetro e calcolare l'area. 
//Implementare tale interfaccia nelle classi concrete Rettangolo, Triangolo e Cerchio,
//e poi derivare dalla classe Rettangolo la classe Quadrato.
//Realizzare poi un’app console che
//permetta all'utente di inserire degli oggetti di tipo Forma da tastiera, e di stampare sullo schermo le dimensioni,
//area e perimetro di tutte le forme inserite.


Console.WriteLine("Figure geometriche");
bool continua = true;
while (continua)
{
    Console.WriteLine("--------------------------------Menu----------------------------");
    Console.WriteLine("1. Inserisci figura geometrica");
    Console.WriteLine("2. Stampa figure geometriche della lista");
    Console.WriteLine("3. Stampa perimetro di tutte le figure geometriche della lista");
    Console.WriteLine("4. Stampa area di tutte le figure geometriche della lista");
    Console.WriteLine("0. Exit");


    int scelta;
    do
    {
        Console.WriteLine("Seleziona una tra le possibili opzioni");
    } while (!(int.TryParse(Console.ReadLine(), out scelta) && scelta >= 0 && scelta <= 4));

    switch (scelta)
    {
        case 1:
            InserisciFigura();
            break;
        case 2:
            StampaFigure();
            break;
        case 3:
            StampaPerimetroFigure();
            break;
        case 4:
            StampaAreaFigure();
            break;
        case 0:
            continua = false;
            break;
    }
}


void StampaPerimetroFigure()
{
    if (FormeManager.formeGeometriche.Count == 0)
    {
        Console.WriteLine("Lista vuota");
    }
    else
    {
        Console.WriteLine("\nEcco i Perimetri delle figure presenti nella lista:\n");
        foreach (var item in FormeManager.formeGeometriche)
        {
            Console.WriteLine($"{item.ToString()} - Perimetro: {item.CalcolaPerimetro()}");
        }
    }
}

void StampaAreaFigure()
{
    if (FormeManager.formeGeometriche.Count == 0)
    {
        Console.WriteLine("Lista vuota");
    }
    else
    {
        Console.WriteLine("\nEcco le Aree delle figure presenti nella lista:\n");
        foreach (var item in FormeManager.formeGeometriche)
        {
            Console.WriteLine($"{item.ToString()} - Area: {item.CalcolaArea()}");
        }
    }
}
    void StampaFigure()
{
    if (FormeManager.formeGeometriche.Count == 0)
    {
        Console.WriteLine("Lista vuota");
    }
    else
    {
        Console.WriteLine("\nEcco le figure presenti nella lista:\n");
        foreach (var item in FormeManager.formeGeometriche)
        {
            Console.WriteLine(item.ToString());
        }
    }
}

void InserisciFigura()
{
    Console.WriteLine("1.Rettangolo");
    Console.WriteLine("2.Quadrato");
    Console.WriteLine("3.Triangolo");
    Console.WriteLine("4.Cerchio");
    int scelta;
    do
    {
        Console.WriteLine("Quale figura vuoi inserire?");
    } while (!(int.TryParse(Console.ReadLine(), out scelta) && scelta >= 1 && scelta <= 4));

    switch (scelta)
    {
        case 1:
            Rettangolo r = CreaRettangolo();
            FormeManager.AddFigura(r);
            break;
        case 2:
            Quadrato q = CreaQuadrato();
            FormeManager.AddFigura(q);
            break;
        case 3:
            Triangolo t = CreaTriangolo();
            FormeManager.AddFigura(t);
            break;
        case 4:
            Cerchio c = CreaCerchio();
            FormeManager.AddFigura(c);
            break;
    }
}

Rettangolo CreaRettangolo()
{
    Console.WriteLine("Crea il tuo rettangolo");
    Console.WriteLine("Inserisci il valore della base");
    double b;
    while (!(double.TryParse(Console.ReadLine(), out b) && b > 0))
    {
        Console.WriteLine("Valore errato");
    }

    Console.WriteLine("Inserisci il valore dell''altezza");
    double h;
    while (!(double.TryParse(Console.ReadLine(), out h) && h > 0))
    {
        Console.WriteLine("Valore errato");
    }

    return new Rettangolo(b, h);
}

Quadrato CreaQuadrato()
{
    Console.WriteLine("Crea il tuo Quadrato");
    Console.WriteLine("Inserisci il valore del lato");
    double l;
    while (!(double.TryParse(Console.ReadLine(), out l) && l > 0))
    {
        Console.WriteLine("Valore errato");
    }
    return new Quadrato(l);
}
Triangolo CreaTriangolo()
{
    Console.WriteLine("Crea il tuo Triangolo");
    Console.WriteLine("Inserisci il valore della base");
    double b;
    while (!(double.TryParse(Console.ReadLine(), out b) && b > 0))
    {
        Console.WriteLine("Valore errato");
    }

    Console.WriteLine("Inserisci il valore dell''altezza");
    double h;
    while (!(double.TryParse(Console.ReadLine(), out h) && h > 0))
    {
        Console.WriteLine("Valore errato");
    }
    Console.WriteLine("Inserisci il valore del cateto1");
    double c1;
    while (!(double.TryParse(Console.ReadLine(), out c1) && c1 > 0))
    {
        Console.WriteLine("Valore errato");
    }
    Console.WriteLine("Inserisci il valore del cateto2");
    double c2;
    while (!(double.TryParse(Console.ReadLine(), out c2) && c2 > 0))
    {
        Console.WriteLine("Valore errato");
    }
    return new Triangolo(b, h, c1, c2);
}
Cerchio CreaCerchio()
{
    Console.WriteLine("Crea il tuo Cerchio");
    Console.WriteLine("Inserisci il valore del raggio");
    double r;
    while (!(double.TryParse(Console.ReadLine(), out r) && r > 0))
    {
        Console.WriteLine("Valore errato");
    }
    return new Cerchio(r);
}
