using ECorp.backend;


namespace ECorp.frontend
{
    public static class Display
    {
        public static void DisplayEmployees(List<Employee> employees)
        {
            Console.Clear();
            Console.WriteLine("ID | IMIĘ I NAZWISKO | DATA UR. | STANOWISKO");
            foreach (Employee emp in employees)
            {   

                Console.WriteLine($"{emp.Id.ToString()} | {emp.FirstName} {emp.LastName} | {emp.BirthDate.Date.ToString("dd-MM-yyyy")} | {emp.Worksite}");
            }
        }

        public static int DisplayMenu()
        {
            Console.WriteLine();    
            Console.WriteLine("WYBIERZ OPCJĘ:");
            Console.WriteLine("1 => LISTA WSZYSTKICH PRACOWNIKÓW");
            Console.WriteLine("2 => WYLICZ PENSJĘ PRACOWNIKA");
            Console.WriteLine("3 => ZAKOŃCZ PROGRAM");
            Console.WriteLine("WYBIERZ 1, 2 LUB 3:");
            var answer = Console.ReadLine();
            int number;
            number = int.TryParse(answer, out number) ? number : 0;
            return number;
        }
        public static string AskForEmployeeId(bool displayError)
        {
            Console.Clear();
            Console.WriteLine();
            if (displayError)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("BRAK PRACOWNIKA O PODANYM ID");
                Console.ForegroundColor = ConsoleColor.White;
            }
              
            Console.WriteLine("PROSZĘ PODAĆ ID PRACOWNIKA DLA KTÓREGO ZOSTANIE WYLICZONE WYNAGRODZENIE: ");
            string answer = Console.ReadLine();
            //int employee_id;
            //employee_id = int.TryParse(answer, out employee_id) ? employee_id : 0;
            return answer;//employee_id;
        }
        public static void DisplayEmployeeDetails(Employee employee)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("WYLICZANIE WYNAGRODZENIA PRACOWNIKA");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("DANE PRACOWNIKA:");
            Console.WriteLine($"IMIE I NAZWISKO: {employee.FirstName} {employee.LastName}");
            Console.WriteLine($"WIEK: {DateTime.Today.Year - employee.BirthDate.Year} lat");
            Console.WriteLine($"STANOWISKO: {employee.Worksite}");
            if ( employee.Worksite == "urzędnik")
            {
                Console.WriteLine($"PENSJA STAŁA: {employee.Salary} zł");
            }
            else if(employee.Worksite == "pracownik fizyczny")
            {
                Console.WriteLine($"STAWKA GODZINOWA: {employee.HourlyWage} zł/h");
            }
        }

        public static int AskForWorkDays()
        {
            Console.WriteLine();
            Console.WriteLine("PROSZĘ PODAĆ ILOŚĆ PRZEPRACOWANYCH DNI PRZEZ PRACOWNIKA(MAX.20):");
            var answer = Console.ReadLine();
            int days;
            days = int.TryParse((answer), out days) ? days : 0;
            return days;
        }
        public static decimal AskForBonus()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("PROSZĘ PODAĆ KWOTĘ PREMII DLA PRACOWNIKA:");
            var answer = Console.ReadLine();
            decimal bonus;
            bonus = decimal.TryParse((answer), out bonus) ? bonus : decimal.Zero;
            return bonus;
        }
        public static void DisplaySalary(Salary salary)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine($"WYNAGRODZENIE PRACOWNIKA BRUTTO WYNOSI: {salary.Gross} zł");
            if (salary.Tax>0)
            {
                Console.WriteLine($"POTRĄCONY PODATEK (18%): {salary.Tax} zł");
            }
            else
            {
                Console.WriteLine("BRAK PODATKU");
            }

            Console.WriteLine($"DO WYPŁATY: {salary.Net} zł");
            Console.ReadKey();
            Console.Clear();
        }
        public static void DisplaySalaryError()
        {
            Console.Clear();
            Console.WriteLine() ;   
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("NIEPRAWIDŁOWE DANE. NIE MOŻNA WYLICZYĆ WYNAGRODZENIA");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
        }
    }
}
