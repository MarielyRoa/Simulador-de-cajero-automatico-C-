//3- Simulador de Cajero Automático
// Objetivo: Lógica condicional, switch, funciones.
// Descripción: Simula un cajero con las siguientes opciones:

// Consultar saldo

// Depositar

// Retirar

// Ver historial de transacciones

// Salir

using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

class Program
{
    public static int[] deposito = new int[] { };
    public static int[] retiro = new int[] { };
    public static bool continuar = true;
    static void Main(string[] args)
    {
        while (continuar)
        {

            Console.WriteLine("==============================");
            Console.WriteLine("      CAJERO AUTOMATICO       ");
            Console.WriteLine("==============================");
            Console.WriteLine("      MENU DE OPCIONES        ");
            Console.WriteLine("1. Consultar Saldo            ");
            Console.WriteLine("2. Depositar                  ");
            Console.WriteLine("3. Retirar                    ");
            Console.WriteLine("4. Ver historial de transaccion");
            Console.WriteLine("5. Salir                      ");
            string opcion = Console.ReadLine() ?? "";

            switch (opcion)
            {
                case "1":
                    ConsultarSaldo();
                    break;
                case "2":
                    Depositar();
                    break;
                case "3":
                    Retirar();
                    break;
                case "4":
                    VerHistorial();
                    break;
                case "5":
                    Console.WriteLine("Esta seguro que desea salir?");
                    string salir = Console.ReadLine()?.ToLower() ?? "";
                    if (salir != "si" && salir != "s")
                    {
                        Console.WriteLine("Opcion cancelada");

                    }
                    else
                    {
                        continuar = false;
                    }
                    break;
                default:
                    Console.WriteLine("Opcion invalida");
                    break;
            }
        }
    }

    public static double Saldos()
    {
        int totalretiro = 0;
        int totaldeposito = 0;

        for (int i = 0; i < deposito.Length; i++)
        {
            totaldeposito += deposito[i];
        }

        for (int i = 0; i < retiro.Length; i++)
        {
            totalretiro += retiro[i];
        }

        return totaldeposito - totalretiro;
    }

    public static void ConsultarSaldo()
    {
        Console.WriteLine("==============================");
        Console.WriteLine("     CONSULTAR SALDO          ");
        Console.WriteLine("==============================");

        Console.WriteLine($"Saldo disponible: RD${Saldos():F}");

    }

    public static void Depositar()
    {
        Console.WriteLine("==============================");
        Console.WriteLine("     DEPOSITAR                ");
        Console.WriteLine("==============================");

        Console.WriteLine("Ingrese el monto: ");
        int monto = Convert.ToInt32(Console.ReadLine());

        Array.Resize(ref deposito, deposito.Length + 1);
        deposito[deposito.Length - 1] = monto;
        Console.WriteLine("Deposito completado"); 
    }

    public static void Retirar()
    {
        Console.WriteLine("==============================");
        Console.WriteLine("     RETIRAR                  ");
        Console.WriteLine("==============================");

        Console.WriteLine("Ingrese el monto: ");
        int montoRetirar = Convert.ToInt32(Console.ReadLine());

        if (montoRetirar <= Saldos())
        {
            Array.Resize(ref retiro, retiro.Length + 1);
            retiro[retiro.Length - 1] = montoRetirar;

            Console.WriteLine("Retiro completado"); 
        }
        else
        {
            Console.WriteLine("Saldo fuera de rango");
        }

        Array.Resize(ref retiro, retiro.Length + 1); 
    }

    public static void VerHistorial()
    {
        Console.WriteLine("Total de depositos: ");
        for (int i = 0; i < deposito.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {deposito[i]:F}");
        }

        Console.WriteLine("Total de retiros: ");
        for (int i = 0; i < retiro.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {retiro[i]:F}");
        }

        Console.WriteLine($"Saldo disponible: RD${Saldos():F}");
   
    }

}