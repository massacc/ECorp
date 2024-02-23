using System;


namespace ECorp.backend
{
    public class Salary
    {
        private Employee _employee;
        private int _workDays;
        private decimal _bonus;
        public decimal Gross { get; private set; } = decimal.Zero;
        public decimal Net { get; private set; } = decimal.Zero;
        public decimal Tax { get; private set; } = decimal.Zero;
        
        public Salary(Employee employee, int work_days, decimal bonus) 
        {
            if (work_days < 1 | work_days > 20) 
            {
                throw new ArgumentOutOfRangeException();
            }
            _employee = employee;
            _workDays = work_days;
            _bonus = bonus;

            

            Calculate();
        }

        private void Calculate()
        {
            if (_employee.Worksite == "urzędnik")
            {
                if (_workDays == 20)
                {
                    Gross = decimal.Round(_employee.Salary + _bonus,2);
                }
                else if(_workDays<20)
                {
                    Gross = decimal.Round(0.8m * _employee.Salary,2);
                }
            }

            if (_employee.Worksite =="pracownik fizyczny")
            {
                Gross = (decimal)_workDays * _employee.HourlyWage * 8m;

                if (_workDays == 20)
                {
                    Gross = Gross + _bonus;
                }
            }

            if (DateTime.Now.Year - _employee.BirthDate.Year <= 26)
            {
                Net = Gross;
            }
            else
            {
                Tax = 0.18m * Gross;
                Net = Gross - Tax;
            }
        }
    }
}
