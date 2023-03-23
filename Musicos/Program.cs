﻿class Musico
{
    public string Nombre{get;set;}
    public Musico(string n){Nombre=n;}//constructor
    
    public void Saluda(){Console.WriteLine("Hola soy {0}",Nombre);}

    public virtual void Toca()
    {
        Console.WriteLine($"{Nombre}, esta tocando su instrumento");
    }
}


class Bajista:Musico
{
    public string bajo {get;set;}
    public Bajista(string n,string b):base(n)
    {bajo=b;}

    public override void Toca()
    {
        Console.WriteLine($"{Nombre} tocando su {bajo}");
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        //lista
        List<Musico> bzrrap = new List<Musico>();
        bzrrap.Add(new Musico("Quevedo"));
        bzrrap.Add(new Bajista("Trueno","Flow"));
        bzrrap.Add(new Bajista("VuillanoAntillano","Abanico"));

        foreach(var m in bzrrap)
        {
            m.Saluda();
            m.Toca();
        }


       Musico y= new Musico("Rauw");
       y.Saluda();
       y.Toca();
       Bajista x = new Bajista("Shakira","Flauta");x.Toca();
    }
}