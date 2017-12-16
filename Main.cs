using System;
using Persona.cs;

namespace ZeKi{
	class MainClass{
		public static void Main (string[] args){
			Persona juan = new Persona("Juan", 18);
			Console.WriteLine(Persona.Nombre() + " " + Persona.Edad());
		}
	}
}