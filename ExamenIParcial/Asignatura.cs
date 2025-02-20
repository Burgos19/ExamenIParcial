

using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ExamenIParcial
{
    public class Asignatura : Alumno
    {

        public int N1 { get; set; }
        public int N2 { get; set; }
        public int N3 { get; set; }
        public string NombreAsignatura { get; set; }
        public string Horario { get; set; }
        public string NombreDocente { get; set; }

        public Asignatura(string nombre, string numeroCuenta, string email, int n1, int n2, int n3, string nombreAsignatura, string horario, string nombreDocente)
        : base(nombre, numeroCuenta, email)

        {
            N1 = n1;
            N2 = n2;
            N3 = n3;
            NombreAsignatura = nombreAsignatura;
            Horario = horario;
            NombreDocente= nombreDocente;

        }

        public double CalcularNotaFinal()
        {
            return (N1 + N2 + N3) / 3.0;
        }

        public double CalcularNotaFinal(int nota1, int nota2, int nota3)
        {
            return (nota1 + nota2 + nota3) / 3.0;
        }

        public string MensajeNotaFinal(double notaFinal)
        {
            if (notaFinal >= 0 && notaFinal <= 59)
            {
                return "Reprobado";
            }
            else if (notaFinal >= 60 && notaFinal <= 79)
            {
                return "Bueno";
            }
            else if (notaFinal >= 80 && notaFinal <= 89)
            {
                return "Muy Bueno";
            }
            else if (notaFinal >= 90 && notaFinal <= 100)
            {
                return "Sobresaliente";
            }
            else
            {
                return "Nota inválida"; 
            }
        }
    


        public void Imprimir()
        {
            MostrarDatos();
            Console.WriteLine($"---------------------------------------------");
            Console.WriteLine($"Asignatura: {NombreAsignatura}");
            Console.WriteLine($"Horario: {Horario}");
            Console.WriteLine($"Docente: {NombreDocente}");
            double notaFinal = CalcularNotaFinal();
            Console.WriteLine($"Nota Final: {notaFinal}");
            Console.WriteLine($"Estado: {MensajeNotaFinal(notaFinal)}");
            Console.WriteLine($"---------------------------------------------");

        }

    }
}
