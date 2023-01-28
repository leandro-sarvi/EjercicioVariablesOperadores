namespace EjercicioVariablesOperadores
{
    class Program
    {
        public static void Main(string[] args)
        {
            Boolean sabeOrnot;
            Console.WriteLine("Ingrese nombre: ");
            String? nombre = Console.ReadLine();
            Console.WriteLine("Ingrese Apellido: ");
            String? apellido = Console.ReadLine();
            Console.WriteLine("Ingrese Edad: ");
            String? edad = Console.ReadLine();
            Console.WriteLine("Sabe programar? ");
            String? programa= Console.ReadLine();
            if (programa.Equals("si"))
            {
                Console.WriteLine("Nombre: " + nombre);
                Console.WriteLine("Apellido: " + apellido);
                Console.WriteLine("Edad: " + edad);
                Console.WriteLine("Sabe programar...");
            }
            else
            {
                Console.WriteLine("Nombre: " + nombre);
                Console.WriteLine("Apellido: " + apellido);
                Console.WriteLine("Edad: " + edad);
                Console.WriteLine("No sabe programar...");
            }
        }
    }
}
