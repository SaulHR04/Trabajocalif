using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2AC1_D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables
            string nombre, apellido, segundoApellido, telefono, matricula;
            string curso;
            byte u1, u2, u3, u4, u5;
            // preguntas de entrada
            Console.WriteLine("Cual es tu nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Cual es tu apellido");
            apellido = Console.ReadLine();
            Console.WriteLine("Cual es tu segundo apellido");
            segundoApellido = Console.ReadLine();
            Console.WriteLine("Cual es tu telefono");
            telefono = Console.ReadLine();
            Console.WriteLine("Cual es tu matricula");
            matricula = Console.ReadLine();
            //fin de preguntas de entrada
            Console.Clear();
            //preguntas de la asignatura
            Console.WriteLine("Cual es el nombre del curso");
            curso = Console.ReadLine();
            
            Console.WriteLine("Cuanto sacaste en la Unidad 1 (0-100");
            u1 = Convert.ToByte(Console.ReadLine());
            //inicio de if para comprobar si acredito
            if (u1 >= 70)
            {
                Console.WriteLine("Acreditaste");
            }
            else
            {
                Console.WriteLine("No Acredito");
            }
            Console.WriteLine("Cuanto sacaste en la Unidad 2 (0-100");
            u2 = Convert.ToByte(Console.ReadLine());
        
            if (u2 >= 70)
            {
                Console.WriteLine("Acreditaste");
            }
            else
            {
                Console.WriteLine("No Acredito");
                
        }
         Console.WriteLine("Cuanto sacaste en la Unidad 3 (0-100");
          u3 = Convert.ToByte(Console.ReadLine());
        if (u3 >= 70)
{
    Console.WriteLine("Acreditaste");
}
         else
{
    Console.WriteLine("No Acredito");

   
}
Console.WriteLine("Cuanto sacaste en la Unidad 4 (0-100");
u4 = Convert.ToByte(Console.ReadLine());
                
                if (u4 >= 70)
                    Console.WriteLine("Acreditaste");
                else
                {
                    Console.WriteLine("No Acredito");

                    Console.WriteLine("Cuanto sacaste en la Unidad 4 (0-100");
                    u4 = Convert.ToByte(Console.ReadLine());
                }
                if (u4 >= 70)
                {
                    Console.WriteLine("Acreditaste");
                }
                else
                {
                    Console.WriteLine("No Acredito");
                }
                Console.WriteLine("Cuanto sacaste en la Unidad 5 (0-100");
                u5 = Convert.ToByte(Console.ReadLine());

             if (u5 >= 70)
            {
                Console.WriteLine("Acreditaste");
            }
            else
            {
                Console.WriteLine("No Acredito");
            }
             //fin de if

        }
    }
}
