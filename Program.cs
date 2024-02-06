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
            int year = fchaFinal.Year - dateTime.Year;

            if (day < 0)
            {
                month--;
                day += DateTime.DaysInMonth(fchaFinal.Year, fchaFinal.Month);
            }

            if (month < 0)
            {
                year++;
                month += 12;
            }

            int daysInMonthFinal = DateTime.DaysInMonth(fchaFinal.Year, fchaFinal.Month);

            if (day > daysInMonthFinal)
            {
                day -= daysInMonthFinal;
                month++;
            }

            Console.WriteLine("Tienes: " + year + " años, " + month + " meses y " + day + " dias");


        }
    }
}
