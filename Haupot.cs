using System;
namespace Praktikum13
{
	public class Haupot
	{
		static void Main(String[] arg)
		{
			Fuhrpark fuhr = new Fuhrpark();
			fuhr.Aufnehmen(new Auto("BillGates", 420));
            fuhr.Aufnehmen(new Auto("SteveJobs", 840));
            fuhr.Aufnehmen(new Auto("Xbox", 720));

            fuhr.Inventur();
			Console.WriteLine("Durschnittliches Alter " + fuhr.BerechneFlottenalter());

			fuhr.Delete(0);


			Console.WriteLine("-----");

            fuhr.Inventur();
            Console.WriteLine("Durschnittliches Alter " + fuhr.BerechneFlottenalter());
        }
	}
}

