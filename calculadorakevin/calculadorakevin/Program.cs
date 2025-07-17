using System.Reflection.Metadata;

class CalculadoraKevin
{
    static void Main ()
    {
        double num1, num2 = 0;
        bool salir = false;
        while (!salir)
        {
            MostratMenu();
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Sumar();
                    break;
                    case "2":
                    Restar();
                    break;
                    case "3":
                    Multi();
                    break;
                case "4":
                    Divi();
                        break;
                    case "5":
                    Raiz();
                    break;
                    case "6":
                    Expo();
                    break;
                    case "7":
                    salir = true;
                    Console.WriteLine("bye, bye");
                    break;
                default:
                     Console.WriteLine("no esta esa opcion en el menu");
                    break;

            }
            if (!salir)
            {
                Console.WriteLine("Presione cualquier tecla para continuar");
                Console.ReadKey();
            }

        }
    }
    static void MostratMenu()
    {
        Console.WriteLine("CALCULADORA");
        Console.WriteLine("1. Sumar");
        Console.WriteLine("2. Restar");
        Console.WriteLine("3. Multiplicar");
        Console.WriteLine("4. Dividir");
        Console.WriteLine("5. Raíz cuadrada");
        Console.WriteLine("6. Exponente");
        Console.WriteLine("7. Salir");

    }
    static double LeerNumero(string mensaje)
    {
         Console.Write(mensaje);
        return Convert.ToDouble(Console.ReadLine());
    }
    static void Sumar()
    {
        double num1 = LeerNumero("Ingrese el primer número: ");
        double num2 = LeerNumero("Ingrese el segundo número: ");
       
        Console.WriteLine($"El resultado de la suma es: {num1 + num2}");
    }
    static void  Restar()
    {
        double num1 = LeerNumero("Ingrese el primer número: ");
        double num2 = LeerNumero("Ingrese el segundo número: ");
       
        Console.WriteLine($"El resultado de la resta es: {num1 - num2}");
    }
    static void Multi()
    {
        double num1 = LeerNumero("Ingrese el primer número: ");
        double num2 = LeerNumero("Ingrese el segundo número: ");
      
        Console.WriteLine($"El resultado de la multiplicacion es: {num1 * num2}");
    }
    static void Divi()
    {
        double num1 = LeerNumero("Ingrese el primer número: ");
        double num2 = LeerNumero("Ingrese el segundo número: ");
        
        Console.WriteLine($"El resultado de la suma es: {num1 / num2}");
    }
    static void Raiz()
    {
        double num1 = LeerNumero("Ingrese un número: ");
       if (num1 < 0)
        {
            Console.WriteLine("No se puede calcular la raíz cuadrada de un número negativo.");
            return;
        }
       else
        {             
            Console.WriteLine($"La raíz cuadrada es: {Math.Sqrt(num1)}");
        }
    }
    static void Expo()
    {
         double num1 = LeerNumero("Ingrese la base: ");
        double num2 = LeerNumero("Ingrese el exponente: ");
        
        Console.WriteLine($"El resultado de {num1} elevado a {num2} es: {Math.Pow(num1, num2)}");
    }
        



}
        
