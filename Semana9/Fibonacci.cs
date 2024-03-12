using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Ingrese la cantidad de números de la secuencia Fibonacci que desea calcular:");
        int cuenta;
        //se solicita que el numero de la cuenta sea mayor a cero
        while (!int.TryParse(Console.ReadLine(), out cuenta) || cuenta <= 0)
        {
            Console.WriteLine("Por favor, ingrese un número entero positivo mayor que cero.");
        }

//se utiliza un bucle for para  que en cada iteración se incrementa en 1
        Console.WriteLine("Secuencia Fibonacci:");
        for (int i = 0; i < cuenta; i++)
        {
            Console.Write(Fibonacci(i) + " ");
        }
    }

    static int Fibonacci(int n)
    {
        if (n <= 1)
        {
            return n;
        }
        else
        {
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
