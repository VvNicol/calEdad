namespace calEdad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("############# CALCULADORA DE EDAD ##############");
            Console.WriteLine("Introduce tu fecha de Nacimiento (DD/MM/AAAA): ");

            DateTime fchaFinal = Convert.ToDateTime(Console.ReadLine());
            DateTime dateTime = DateTime.Now;

            int day = fchaFinal.Day - dateTime.Day;
            int month = fchaFinal.Month - dateTime.Month;
            int year = dateTime.Year - fchaFinal.Year;

            // Verifica si la fecha actual ha pasado ya el cumpleaños de este año
            if (dateTime.Month < fchaFinal.Month || (dateTime.Month == fchaFinal.Month && dateTime.Day < fchaFinal.Day))
            {
                // Si aún no se ha cumplido el cumpleaños, se resta un año
                year--;
            }

            // Si los dias resultan ser negativos, ajusta los meses y los días
            if (day < 0)
            {
                month--;
                day += DateTime.DaysInMonth(fchaFinal.Year, fchaFinal.Month);
            }

            // Si los meses resultan ser negativos, ajusta los años y los meses
            if (month < 0)
            {
                year--;
                month += 12;
            }

            // Obtiene la cantidad de días en el mes de la fecha de nacimiento
            int daysInMonthFinal = DateTime.DaysInMonth(fchaFinal.Year, fchaFinal.Month);

            if (day > daysInMonthFinal)
            {
                day -= daysInMonthFinal;
                month++;
            }

            Console.WriteLine("Tienes: " + year + " años, " + month + " meses y " + day + " días");


        }
    }
}
