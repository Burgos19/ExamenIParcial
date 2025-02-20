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

        Console.Write("Ingrese la primera nota: ");
        int n1 = int.Parse(Console.ReadLine());
        if (n1 < 0 || n1 > 30)
        {
            throw new Exception("La nota del primer parcial no puede ser mayor a 30.");
        }

        Console.Write("Ingrese la segunda nota: ");
        int n2 = int.Parse(Console.ReadLine());
        if (n2 < 0 || n2 > 30)
        {
            throw new Exception("La nota del segundo parcial no puede ser mayor a 30.");
        }
        Console.Write("Ingrese la tercera nota: ");
        int n3 = int.Parse(Console.ReadLine());
        if (n3 < 0 || n3 > 40)
        {
            throw new Exception("La nota del tercer parcial no puede ser mayor a 40.");
        }
        Console.Write("Ingrese el nombre de la asignatura: ");
        string nombreAsignatura = Console.ReadLine();

        Console.Write("Ingrese el horario: ");
        string horario = Console.ReadLine();

        Console.Write("Ingrese el nombre del docente: ");
        string nombreDocente = Console.ReadLine();

        Asignatura asignatura = new Asignatura(nombre, numeroCuenta, email, n1, n2, n3, nombreAsignatura, horario, nombreDocente);
        asignatura.Imprimir();


    }


}