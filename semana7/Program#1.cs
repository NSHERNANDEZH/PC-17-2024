class PROGRAM
 
    {
        static void Main(string[] args) 
        {


         Console.WriteLine("Mi segundo programa");


        Console.WriteLine("Ingrese su nombre");
          string sNombre = Console.ReadLine();

          Console.WriteLine("Ingrese su edad");
          string sEdad = Console.ReadLine();

          Console.WriteLine("Ingrese su carrera");
          string sCarrera = Console.ReadLine();

          Console.WriteLine("Ingrese su carne");
          string sCarne = Console.ReadLine();

          Console.WriteLine("Soy " + sNombre + " tengo " + sEdad + " años y estudio la carrera de " + sCarrera +
          " Mi número de carné es " + sCarne);

          Console.ReadKey();
        }
    }
