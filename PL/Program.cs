using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{

    public class Program
    {
        static void Main(string[] args)
        {
            int programa = 0;
            Console.WriteLine("Bienvenido");
            Console.WriteLine("Elija la entidad a utilizar");
            Console.WriteLine("1.- Ejercicio empleado");
            Console.WriteLine("2.- Ejercicio mayor o menor de edad");
            Console.WriteLine("3.- Ejercicio elecciones ");
            programa = int.Parse(Console.ReadLine());
            switch (programa)
            {
                case 1:
                    Empleado empleado1 = new Empleado();
                    Empleado empleado2 = new Empleado();
                    Empleado empleado3 = new Empleado();


                    Console.WriteLine("Datos delos empleados");
                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine("Empleado 1");
                    Console.WriteLine("Nombre: Jacobo");
                    empleado1.Nombre = "Jacobo";
                    Console.WriteLine("Apellido: Agami");
                    empleado1.Apellido = "Agami";
                    Console.WriteLine("Sueldo diario: $500");
                    empleado1.SueldoDiario = 500;
                    CalulaSueldo(empleado1);
                    Console.WriteLine("---------------------------------------");

                    Console.WriteLine("Empleado 2");
                    Console.WriteLine("Nombre: Alvaro");
                    empleado2.Nombre = "Alvaro";
                    Console.WriteLine("Apellido: González");
                    empleado2.Apellido = "González";
                    Console.WriteLine("Sueldo diario: $400");
                    empleado2.SueldoDiario = 400;
                    CalulaSueldo(empleado2);
                    Console.WriteLine("---------------------------------------");

                    Console.WriteLine("Empleado 3");
                    Console.WriteLine("Nombre: Mario");
                    empleado3.Nombre = "Mario";
                    Console.WriteLine("Apellido: Ramón");
                    empleado3.Apellido = "Ramón";
                    Console.WriteLine("Sueldo diario: $300");
                    empleado3.SueldoDiario = 300;
                    CalulaSueldo(empleado3);
                    Console.WriteLine("---------------------------------------");


                    Console.ReadKey();
                    break;
                case 2:
                    MayorMenor();
                    break;
                case 3:
                    Elecciones();
                    break;
            }

        }
        public class Empleado
        {
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public int SueldoDiario { get; set; }

        }
        public static void CalulaSueldo(Empleado empleado)
        {

            Console.WriteLine("Ingrese los dias de trabajo");
            int DiasTrabajados = int.Parse(Console.ReadLine());
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Resumen de los empleados");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Nombre: " + empleado.Nombre);
            Console.WriteLine("Apellido: " + empleado.Apellido);
            Console.WriteLine("Sueldio diario: $" + empleado.SueldoDiario);
            Console.WriteLine("Sueldo total por los dias trabajados: $" + (empleado.SueldoDiario * DiasTrabajados));
            Console.WriteLine("---------------------------------------");

        }
        public static void MayorMenor()
        {
            int Edad = 0, TotalMenores = 0, TotalMayores = 0;
            byte opcion;
            do
            {
                Console.WriteLine("Ingrese la edad de la persona");
                Edad = int.Parse(Console.ReadLine());

                if (Edad <= 17)
                {
                    TotalMenores = TotalMenores + 1;
                }
                else
                {
                    TotalMayores = TotalMayores + 1;
                }
                Console.WriteLine("¿Desea agregar la edad de otra persona? 1.-SI  2.- NO");
                opcion = byte.Parse(Console.ReadLine());
            }
            while (opcion == 1);

            Console.WriteLine("Total de Personas");
            Console.WriteLine("Total de Personas Menores de edad:" + TotalMenores);
            Console.WriteLine("Total de Personas Mayores de edad:" + TotalMayores);

            Console.ReadKey();
        }
        public static void Elecciones()
        {
            int Candidato1 = 0, Candidato2 = 0, Candidato3 = 0;

            Console.WriteLine("Número de votos obtenidos del primer candidato");
            Candidato1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Número de votos obtenidos del segundo candidato");
            Candidato2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Número de votos obtenidos del tercer candidato");
            Candidato3 = int.Parse(Console.ReadLine());

            if (Candidato1 + Candidato2 + Candidato3 != 160)
            {
                Console.WriteLine("Faltan votos por contar");
            }
            else if (Candidato1 >= 54)
            {
                Console.WriteLine("El candidato 1 obtuvo: " + Candidato1 + " votos");
                Console.WriteLine("El candidato 1 es el ganador");
            }
            else if (Candidato2 >= 54)
            {
                Console.WriteLine("El candidato 2 obtuvo: " + Candidato2 + " votos");
                Console.WriteLine("El candidato 2 es el ganador");
            }
            else if (Candidato3 >= 54)
            {
                Console.WriteLine("El candidato 3 obtuvo: " + Candidato3 + " votos");
                Console.WriteLine("El candidato 3 es el ganador");
            }
            else
            {
                Console.WriteLine("No hay ganador");
            }
            Console.ReadKey();
        }

    }

}
