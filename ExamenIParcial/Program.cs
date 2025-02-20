using ExamenIParcial;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el nombre del alumno: ");
        string nombre = Console.ReadLine();

        Console.Write("Ingrese el número de cuenta: ");
        string numeroCuenta = Console.ReadLine();

        Console.Write("Ingrese el email del alumno: ");
        string email = Console.ReadLine();

        Alumno alumno = new Alumno(nombre, numeroCuenta, email);
        alumno.MostrarDatos();
    }
}