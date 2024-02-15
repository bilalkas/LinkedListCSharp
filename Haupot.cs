using System;
namespace Praktikum13
{
	public class Haupt
	{
		static void Main(String[] arg)
		{
			Fuhrpark fuhr = new Fuhrpark();
			fuhr.Aufnehmen(new Auto("Bilal", 420));
            		fuhr.Aufnehmen(new Auto("K", 840));
            		fuhr.Aufnehmen(new Auto("a", 720));

            		fuhr.Inventur();
			Console.WriteLine("Durschnittliches Alter " + fuhr.BerechneFlottenalter());

			fuhr.Delete(0);


			Console.WriteLine("-----");

            		fuhr.Inventur();
            		Console.WriteLine("Durschnittliches Alter " + fuhr.BerechneFlottenalter());
        	}
	}
}

