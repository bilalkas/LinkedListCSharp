using System;
namespace Praktikum13
{
	public class Fuhrpark
	{
		List.LinkedList<Auto> list = new();

		public Fuhrpark()
		{
		}

		public void Aufnehmen(Auto a)
		{
			list.AddFirst(a);
		}

		public void Delete(int i)
		{
			list.Remove(i);
		}

		public void Inventur()
		{
			List.LinkedList<Auto>.ListIterator a = list.GetIterator();
			while (a.HasNext())
			{
				Console.WriteLine(a.Next().ToString());
			}
		}

		public double BerechneFlottenalter()
		{
			int count = 0;
			double alter = 0;

            List.LinkedList<Auto>.ListIterator a = list.GetIterator();
            while (a.HasNext())
			{
				alter += a.Next().Baujahr;
				count++;
			}

			return alter / count;
        }

    }
}

