// See https://aka.ms/new-console-template for more information
using PreAcademyF_Week6.FormeGeometriche;

internal static class FormeManager
{
    public static List<IForma> formeGeometriche = new List<IForma>();

    internal static bool AddFigura(IForma figura)
    {
        //TODO Controllo se nella lista esiste già una figura uguale , ovvero dello stesso tipo e con dati uguali.
        
        formeGeometriche.Add(figura);
        return true;
    }
}