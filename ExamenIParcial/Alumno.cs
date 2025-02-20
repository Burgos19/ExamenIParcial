
namespace ExamenIParcial
{
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
            Console.WriteLine($"Nombre del Alumno: {Nombre}");
            Console.WriteLine($"Numero de Cuenta: {NumeroCuenta}");
            Console.WriteLine($"Email: {Email}");

        }


    }
}
