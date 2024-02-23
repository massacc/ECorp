// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");





using ECorp.backend;
using ECorp.frontend;

List<Employee> employees = Employees.CreateEmployees();



while (true)
{
    
    var user_choice = Display.DisplayMenu();
    
    if(user_choice == 1)
    {
        Display.DisplayEmployees(employees);
       
    }
    else if(user_choice == 2)
    {
        bool employeeNotExist =  false;
        while (true)
        {
            var emp_id = Display.AskForEmployeeId(employeeNotExist);
            var currentEmployee = Employees.EmployeesList.Where(x => x.Id.ToString() == emp_id.ToString()).ToList();
            if (currentEmployee.Count() > 0)
            {
                Display.DisplayEmployeeDetails(currentEmployee[0]);
                var work_days = Display.AskForWorkDays();
                decimal bonus = Display.AskForBonus();
                try
                {
                    Display.DisplaySalary(new Salary(currentEmployee[0], work_days, bonus));
                    user_choice = 1;
                    break;
                }
                catch
                {
                    Display.DisplaySalaryError();
                }
            

            }
            else
            {
                employeeNotExist = true;
            }
               
   
        
        }
        
    }
    else if(user_choice == 3) 
    {
        break;
    }
   
     

}

