using System;

sealed class EmployeeMenu
{
    IEmployee emp;

    public EmployeeMenu()
    {
        emp = new EmployeeUtilityImpl(); // Upcasting
    }

    public void ShowMenu()
    {
        int choice;
        do
        {
            Console.WriteLine("1 UC1 Attendance");
            Console.WriteLine("2 UC2 Daily Wage");
            Console.WriteLine("3 UC3 Part Time Wage");
            Console.WriteLine("4 UC4 Monthly Wage");
            Console.WriteLine("5 UC5 Wage Till Condition");
            Console.WriteLine("0 Exit");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    emp.UC1_CheckAttendance();
                    break;
                case 2:
                    emp.UC2_DailyWage();
                    break;
                case 3:
                    emp.UC3_PartTimeWage();
                    break;
                case 4:
                    emp.UC4_MonthlyWage();
                    break;
                case 5:
                    emp.UC5_WageTillCondition();
                    break;
            }
        } while (choice != 0);
    }
}
