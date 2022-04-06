// See https://aka.ms/new-console-template for more information
using PreAcademyF_Week6.FormeGeometriche;

internal class Quadrato: Rettangolo
{
    public Quadrato(double lato) : base(lato, lato)
    {

    }
    public override string ToString()
    {
        return $"Quadrato: lato={Base}";
    }
}