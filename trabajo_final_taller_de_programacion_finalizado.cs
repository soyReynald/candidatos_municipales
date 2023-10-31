using System;
using System.Linq;
using System.Collections.Generic;

/******************************************/
/* Código Realizado por Reynald M. Rodriguez
/* Para el Grupo #3 de la Universidad Del Caribe
**************************************/


public class Program
{
	public static void Statistics () {
		
		string[] candidatos = {"Josue", "Elizabeth", "Pedro", "Luis", "Samuel"};
			int i = 0;
	      // Arreglo de votos
	      int[] votos_de_candidatos = {500, 560, 450, 470, 520};
		  
		  int[] votos_de_candidato_genero_f = {256, 388, 109, 372, 490};
		  int[] votos_de_candidato_genero_m = {244, 172, 341, 98, 253};
	      
	      // Arreglo de genero sexual
	      string[] generos_sexuales = {"M", "F", "M", "M", "M"};
	      
	      Console.WriteLine("Saludos, Bienvenido al Municipio El Seibo \n");
	      
	      int nCandidatos = candidatos.Count();
	      int nVotosPorCandidatos = votos_de_candidatos.Count();
	    
	      
	      // Total de votos
	      float totalDeVotos = 0;
	      do {
	        if(totalDeVotos > 0) {
	          totalDeVotos = votos_de_candidatos[i] + totalDeVotos;
	        } else {
	          totalDeVotos = votos_de_candidatos[i];
	        }
	       i++;
	  	  } while (i < nCandidatos);
	  	  
	  	  
	  	  // Porcentaje total
	  	  float porcentajeTotalDeVotos = (totalDeVotos / 100);
	  	  
	  	  // Porcentaje de votos por candidatos
	  	  float[] porcentajesEnNumero = new float[nCandidatos];
	  	  string nombresParaPorcentajes = "";
	  	  int limitOfTheCicle = nCandidatos;
	  
	  	  for (i = 0; i < limitOfTheCicle; i++){
	  	      
	  	   porcentajesEnNumero[i] = (votos_de_candidatos[i] * porcentajeTotalDeVotos)/100;
	  	   double porcentajePorCandidato = Math.Round(porcentajesEnNumero[i], 2);
	  	   // Asignando a cada candidato su porcentaje
	        nombresParaPorcentajes += "Candidato: " + candidatos[i] + " Votos: " + votos_de_candidatos[i] + "\n Porcentaje: " + porcentajePorCandidato	 + "%  Femeninos: " + votos_de_candidato_genero_f[i]  + " Masculinos: " + votos_de_candidato_genero_m[i] + "\n \n ";	  	    
	  	  }
	  	  
	  	  
	  	  Console.WriteLine(nombresParaPorcentajes);
	  	  
	  	  
	  	  // Total de votos Masculinos
	  	  Console.WriteLine("Total de votos masculinos: " + votos_de_candidato_genero_m.Sum());
	  	  // Total de votos Femeninos
	  	  Console.WriteLine("Total de votos femeninos: " + votos_de_candidato_genero_f.Sum());
	  	  Console.WriteLine("El total de Votos es: " + totalDeVotos);
	  	  Console.WriteLine("Porcentaje a partir de votos actuales: " + porcentajeTotalDeVotos + "%");

	}

	public static void Main()
	{ 
	  Console.WriteLine("¿Cuál candidato quieres evaluar o desea ver todas las estadisticas? \n");
	  Console.WriteLine("Candidato = Ponga el nombre del candidato /Estadisticas = Escriba la letra: \"E\" \n");
	  
	  string optionSelectedByUser = "";
	  optionSelectedByUser = Console.ReadLine();
	  // Arreglo de nombres
	  string[] candidatos = {"Josue", "Elizabeth", "Pedro", "Luis", "Samuel"};
	  string candidatoAEvaluar;
	  
	  if (optionSelectedByUser != "E") {
	  	Console.WriteLine("Escoja uno de estos candidatos: \n");
	    for (int i = 0; i < candidatos.Count(); i++) {
	      Console.WriteLine("Candidato #" + (i+1) + ": " + candidatos[i]);
	    }
		
	    candidatoAEvaluar = Console.ReadLine();
	    Console.WriteLine("\n > Usted escogio: " + candidatoAEvaluar + "\n");
		
		for (int i = 0; i < candidatos.Count(); i++) {
			string candidatoToEvaluateInScope = candidatos[i];
			
			if ( candidatoToEvaluateInScope.Contains(candidatoAEvaluar)) {
				// Arreglo de votos por candidato
				int[] votos_de_candidatos = {500, 560, 450, 470, 520};
				// Arreglo de genero sexual
			      string[] generos_sexuales = {"M", "F", "M", "M", "M"};
			      
			      Console.WriteLine("Saludos, Bienvenido al Municipio El Seibo \n");
			      
			      int nCandidatos = candidatos.Count();
			      int nVotosPorCandidatos = votos_de_candidatos.Count();
				
					 int maxValue = votos_de_candidatos.Max();
 					 int maxIndex = votos_de_candidatos.ToList().IndexOf(maxValue);
					 string candidatoConMayorVotos = candidatos[maxIndex];
					 Console.WriteLine("Estamos evaluando a: " + candidatoToEvaluateInScope + " \n ");
					 
					 string[] VerEstadisticas = {"S", "N"};
					 string respuestaDelUsuarioParaLasEstadisticas = "";
					 
					 if(candidatos[i] == candidatoConMayorVotos) {
					 	Console.WriteLine("Felicidades! El candidato con mayor votos fue: " + candidatoConMayorVotos);
						Console.WriteLine("\n ¿Deseas ver las estadisticas completas? S/N");
						respuestaDelUsuarioParaLasEstadisticas = Console.ReadLine();
						if (respuestaDelUsuarioParaLasEstadisticas == VerEstadisticas[0]){
							Statistics();
						} else {
							Console.WriteLine("Gracias por usar nuestro software");
						}
					 } else {
					 	Console.WriteLine("Lo sentimos. El candidato no es el que tiene más votos, sino: " + candidatoConMayorVotos);
						Console.WriteLine("\n ¿Deseas ver las estadisticas completas? S/N");
						respuestaDelUsuarioParaLasEstadisticas = Console.ReadLine();
						if (respuestaDelUsuarioParaLasEstadisticas == VerEstadisticas[0]){
							Statistics();
						} else {
							Console.WriteLine("Gracias por usar nuestro software");
						}
					 }
					
				break;
			}
		}
	  } else if (optionSelectedByUser == "E") {
	  	  Statistics();
	  }
	  
	}
}