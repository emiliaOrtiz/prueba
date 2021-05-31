/*
 * Created by SharpDevelop.
 * User: rikuk
 * Date: 28/5/2021
 * Time: 21:48
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace prueba
{
	class Program
	{
		public static void Main(string[] args)
		{
			int indicador=0;
			
			do{
			
			Console.WriteLine("Ingrese nombre");
			string nombre=Console.ReadLine();
			Console.WriteLine("Hello "+nombre);
			Console.ReadKey(true);
			
			Console.WriteLine("continuar : 1 o 0");
			indicador=int.Parse(Console.ReadLine());
			}
			//soy un codigo modificado para subir a github
			
			while(indicador.Equals(1));
			
			
		}
	}
}