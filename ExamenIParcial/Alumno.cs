
namespace ExamenIParcial
{

    interface IAsignatura
    {
        double CalcularNotaFinal();
        double CalcularNotaFinal(double nota1, double nota2, double nota3);
        string MensajeNotaFinal(double notaFinal);
        void Imprimir();
    }


    public class Alumno 

    {

        public string Nombre {  get; set; }
        public string NumeroCuenta { get; set; }
        public string Email {  get; set; }

        public Alumno(string nombre, string numeroCuenta, string email)
        {
            Nombre = nombre;
            NumeroCuenta = numeroCuenta;
            Email = email;

        }

        public void MostrarDatos()
        {
            Console.WriteLine($"---------------------------------");
            Console.WriteLine($"Nombre del Alumno: {Nombre}");
            Console.WriteLine($"Numero de Cuenta: {NumeroCuenta}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"---------------------------------");

        }


    }
}
