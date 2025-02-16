using System;
using System.Collections.Generic;
using System.Linq;

// PII_2025_I_T2_EQUIPO1

namespace Loteria
{git
    class Program
    {
        // Estructuras para almacenar la información de los jugadores
        struct JugadorDiario
        {
            public string Nombre;
            public int[] Numeros;
        }

        struct JugadorSemanal
        {
            public string Nombre;
            public int[] Numeros;
        }

        // Diccionario para almacenar los jugadores mensuales (clave: número, valor: nombre)
        static Dictionary<int, string> JugadoresMensuales = new Dictionary<int, string>();

        static void Main(string[] args)
        {
            int opcion;

            do
            {
                // Menú principal
                Console.WriteLine("\n--- Menú de Lotería ---");
                Console.WriteLine("1. Vender Diario");
                Console.WriteLine("2. Vender Semanal");
                Console.WriteLine("3. Vender Mensual");
                Console.WriteLine("4. Juego Diario");
                Console.WriteLine("5. Juego Semanal");
                Console.WriteLine("6. Juego Mensual");
                Console.WriteLine("7. Salir");
                Console.Write("Seleccione una opción: ");

                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            VenderDiario();
                            break;
                        case 2:
                            VenderSemanal();
                            break;
                        case 3:
                            VenderMensual();
                            break;
                        case 4:
                            JuegoDiario();
                            break;
                        case 5:
                            JuegoSemanal();
                            break;
                        case 6:
                            JuegoMensual();
                            break;
                        case 7:
                            Console.WriteLine("¡Gracias por jugar!");
                            break;
                        default:
                            Console.WriteLine("Opción no válida. Intente de nuevo.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Entrada no válida. Debe ingresar un número.");
                }

            } while (opcion != 7);
        }

        // Métodos para cada opción del menú

        static void VenderDiario()
        {
            Console.Write("Ingrese el nombre del jugador: ");
            string nombre = Console.ReadLine();

            int[] numeros = new int[5];
            Console.WriteLine("Ingrese 5 números únicos entre 0 y 100:");

            for (int i = 0; i < 5; i++)
            {
                int numero;
                do
                {
                    Console.Write($"Número {i + 1}: ");
                    if (!int.TryParse(Console.ReadLine(), out numero) || numero < 0 || numero > 100 || numeros.Contains(numero))
                    {
                        Console.WriteLine("Entrada no válida. Debe ingresar un número único entre 0 y 100.");
                    }
                } while (numero < 0 || numero > 100 || numeros.Contains(numero));
                numeros[i] = numero;
            }

            // Aquí puedes guardar la información del jugador y sus números
            Console.WriteLine("¡Venta exitosa!");
        }

        static void VenderSemanal()
        {
            Console.Write("Ingrese el nombre del jugador: ");
            string nombre = Console.ReadLine();

            int[] numeros = new int[2];
            Console.WriteLine("Ingrese 2 números únicos entre 0 y 100:");

            for (int i = 0; i < 2; i++)
            {
                int numero;
                do
                {
                    Console.Write($"Número {i + 1}: ");
                    if (!int.TryParse(Console.ReadLine(), out numero) || numero < 0 || numero > 100 || numeros.Contains(numero))
                    {
                        Console.WriteLine("Entrada no válida. Debe ingresar un número único entre 0 y 100.");
                    }
                } while (numero < 0 || numero > 100 || numeros.Contains(numero));
                numeros[i] = numero;
            }

            // Aquí puedes guardar la información del jugador y sus números
            Console.WriteLine("¡Venta exitosa!");
        }

        static void VenderMensual()
        {
            Console.Write("Ingrese el número para la lotería mensual: ");
            int numero;
            if (!int.TryParse(Console.ReadLine(), out numero) || numero < 0)
            {
                Console.WriteLine("Entrada no válida. Debe ingresar un número mayor o igual a 0.");
                return;
            }

            Console.Write("Ingrese el nombre del jugador: ");
            string nombre = Console.ReadLine();

            JugadoresMensuales[numero] = nombre;

            Console.WriteLine("¡Venta exitosa!");
        }

        static void JuegoDiario()
        {
            Random random = new Random();
            int[] numerosGanadores = new int[5];

            Console.WriteLine("\n--- Sorteo de Lotería Diaria ---");
            for (int i = 0; i < 5; i++)
            {
                numerosGanadores[i] = random.Next(0, 101);
                Console.Write($"{numerosGanadores[i]} ");
            }
            Console.WriteLine();

            // Aquí puedes comparar los números ganadores con los números de los jugadores
            // y determinar los ganadores y sus premios.
        }

        static void JuegoSemanal()
        {
            Random random = new Random();
            int[] numerosGanadores = new int[2];

            Console.WriteLine("\n--- Sorteo de Lotería Semanal ---");
            for (int i = 0; i < 2; i++)
            {
                numerosGanadores[i] = random.Next(0, 101);
                Console.Write($"{numerosGanadores[i]} ");
            }
            Console.WriteLine();

            // Aquí puedes comparar los números ganadores con los números de los jugadores
            // y determinar los ganadores y sus premios.
        }

        static void JuegoMensual()
        {
            Random random = new Random();
            int numeroGanador = random.Next(0, 101);

            Console.WriteLine("\n--- Sorteo de Lotería Mensual ---");
            Console.WriteLine($"Número ganador: {numeroGanador}");

            // Aquí puedes buscar el ganador en el diccionario JugadoresMensuales
            // y mostrar su nombre y el premio.
        }
    }
}