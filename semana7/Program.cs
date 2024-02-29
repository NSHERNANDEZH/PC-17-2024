class desafio2
 
    {
        static void Main(string[] args) 
        {
            double velocidadInicial, aceleracion, tiempo;

            Console.Write("Ingrese la velocidad Inicial");
            velocidadInicial = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Ingrese la aceleración");
            aceleracion = Convert.ToDouble(Console.ReadLine());

            
            Console.Write("Ingrese el tiempo");
            tiempo = Convert.ToDouble(Console.ReadLine());

            double velocidadfinal = velocidadInicial + aceleracion * tiempo;

            Console.WriteLine("La velocidad final  es:" + velocidadfinal );


            // Segundo Ejercicio 

             Console.WriteLine("Ingrese su nombre");
          string sNombre = Console.ReadLine();
          
          Console.WriteLine("Ingrese su carne");
          string sCarne = Console.ReadLine();

          Console.WriteLine("Bienvenido " + sNombre + "-" + sCarne);

          Console.WriteLine("Ingrese una cantidad en quetzales (entre 0 y 999.99):");
        double cantidad = Convert.ToDouble(Console.ReadLine());

        if (cantidad < 0 || cantidad > 999.99)
        {
            Console.WriteLine("La cantidad ingresada está fuera del rango permitido.");
            return;
        }


        int billetes100 = (int)(cantidad / 100);
        cantidad %= 100;

        int billetes50 = (int)(cantidad / 50);
        cantidad %= 50;

        int billetes20 = (int)(cantidad / 20);
        cantidad %= 20;

        int billetes10 = (int)(cantidad / 10);
        cantidad %= 10;

        int billetes5 = (int)(cantidad / 5);
        cantidad %= 5;

        int monedas1 = (int)cantidad;
        cantidad -= monedas1;

        int monedas25 = (int)(cantidad / 0.25);
        cantidad -= monedas25 * 0.25;

        int monedas1Centavo = (int)(cantidad / 0.01);

        Console.WriteLine($"{billetes100} de Q 100");
        Console.WriteLine($"{billetes50} de Q 50");
        Console.WriteLine($"{billetes20} de Q 20");
        Console.WriteLine($"{billetes10} de Q 10");
        Console.WriteLine($"{billetes5} de Q 5");
        Console.WriteLine($"{monedas1} de Q 1");
        Console.WriteLine($"{monedas25} de Q 0.25");
        Console.WriteLine($"{monedas1Centavo} de Q 0.01");


 
        }
    }
 
