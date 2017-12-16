namespace ZeKi{
	class Persona{

		string nombre;
		int edad  = 0;	

		Persona(string nombre, int edad){
			this.nombre = nombre;
			this.edad = edad;
		}

		int Edad(){
			return edad;
		}

		string Nombre(){
			return nombre;
		}
	}
}