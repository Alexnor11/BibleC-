namespace Enum
{
    internal class Program
        
    {
        enum WeekDays { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday };

        static void Main(string[] args)
        {
            string[] WeekDaysRussianNames =
            {
                "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"
            };

            WeekDays day = WeekDays.Friday;

            Console.WriteLine("Сегодня " +  day);
            Console.WriteLine("Сегодня " + WeekDaysRussianNames[(int)day]);
            Console.WriteLine("Номер дня " + ((int)day + 1));

            int dayIndex = (int)day + 1;
            Console.WriteLine("Номер дня " + dayIndex);

            if (day == WeekDays.Friday)
            {
                Console.WriteLine("Скоро выходной");
            }

            int i = 1;
            Console.WriteLine(i);
            int j = i++ ;
            Console.WriteLine(j);
            Console.WriteLine(i);
        }
    }
}
