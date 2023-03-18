

class Program
{
    static double CalcularAreaCirculo(double radio)
    {
        return Math.PI * radio * radio;
    }

    static double CalcularPerimetroRectangulo(double ancho, double altura)
    {
        return 2 * (ancho + altura);
    }

    static double CalcularPromedio(List<int> numeros)
    {
        int suma = 0;
        foreach (int num in numeros)
        {
            suma += num;
        }
        return (double)suma / numeros.Count;
    }

    static bool EsPar(int numero)
    {
        return numero % 2 == 0;
    }

    static string ConvertirAMayusculas(string cadena)
    {
        return cadena.ToUpper();
    }

    static double CalcularDistanciaEntrePuntos(double x1, double y1, double x2, double y2)
    {
        double dx = x2 - x1;
        double dy = y2 - y1;
        return Math.Sqrt(dx * dx + dy * dy);
    }

    static int CalcularSumaNaturales(int n)
    {
        return n * (n + 1) / 2;
    }

    static int CalcularFactorial(int n)
    {
        if (n <= 1)
        {
            return 1;
        }
        return n * CalcularFactorial(n - 1);
    }

    static void Main(string[] args)
    {
        // Consola
        Console.WriteLine("El área del círculo de radio 5 es: " + CalcularAreaCirculo(5));
        Console.WriteLine("El perímetro del rectángulo de ancho 3 y altura 4 es: " + CalcularPerimetroRectangulo(3, 4));
        List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };
        Console.WriteLine("El promedio de la lista {1, 2, 3, 4, 5} es: " + CalcularPromedio(numeros));
        Console.WriteLine("El número 7 es par? " + EsPar(7));
        Console.WriteLine("La cadena \"Hola Mundo\" en mayúsculas es: " + ConvertirAMayusculas("Hola Mundo"));
        Console.WriteLine("La distancia entre los puntos (1, 2) y (4, 6) es: " + CalcularDistanciaEntrePuntos(1, 2, 4, 6));
        Console.WriteLine("La suma de los primeros 10 números naturales es: " + CalcularSumaNaturales(10));
        Console.WriteLine("El factorial de 5 es: " + CalcularFactorial(5));
    }
}

