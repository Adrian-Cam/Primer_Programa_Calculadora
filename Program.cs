using System;

class Program
{
    static void Main()
    {
        double num1, num2, Res;
        int options;

        while (true)
        {
            try
            {
                Console.WriteLine("\n------ CALCULADORA ------");
                Console.WriteLine("Presione 5 para salir, o Enter para continuar");
//Tuve que colocar esta variable porque olvide la opcion de cerrar el programa, y se me estaba complicando agregarla al switch y el ReadLine de la variable options. 

                string entrada = Console.ReadLine();
                if (entrada == "5")
                {
                    Console.WriteLine("Saliendo del programa...");
                    break;
                }

                Console.Write("Ingrese el primer numero a calcular: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Ingrese el segundo numero a calcular: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Seleccione una opcion:");
                Console.WriteLine("1 Suma");
                Console.WriteLine("2 Resta");
                Console.WriteLine("3 Multiplicacion");
                Console.WriteLine("4 Division");

                options = Convert.ToInt32(Console.ReadLine());

                switch (options)
                {
                    case 1:
                        Res = num1 + num2;
                        Console.WriteLine("Resultado: " + Res);
                        break;
                    case 2:
                        Res = num1 - num2;
                        Console.WriteLine("Resultado: " + Res);
                        break;
                    case 3:
                        Res = num1 * num2;
                        Console.WriteLine("Resultado: " + Res);
                        break;
                    case 4:
                        if (num2 == 0)
                        {
                            Console.WriteLine("Error, no se puede dividir entre 0");
                        }
                        else
                        {
                            Res = num1 / num2;
                            Console.WriteLine("Resultado: " + Res);
                        }
                        break;
                    default:
                        Console.WriteLine("Error. Ingrese un numero valido");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Ingrese un numero valido");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrio un error: " + ex.Message);
            }
        }
    }
}