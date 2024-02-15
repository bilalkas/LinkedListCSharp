using System;
namespace Praktikum13
{
	public class Auto
	{
		private String _hersteller = "";
		public int Baujahr { get; set; }

		public Auto(String hersteller, int baujahr)
		{
			Hersteller = hersteller;
			Baujahr = baujahr;
		}

		public String Hersteller
		{
			get { return _hersteller; }
			set { _hersteller = value; }
		}

		public override String ToString()
		{
			return $"Hersteller: {Hersteller} gebaut in {Baujahr}";
		}
	}
}

