using System;

sealed class EmployeeMenu{
    IEmployee emp;

    public EmployeeMenu(){
        emp=new EmployeeUtilityImpl(); // Upcasting
    }

    public void ShowMenu(){
        int choice;
        do{
            Console.WriteLine("1 Add Employee");
            Console.WriteLine("2 Check Attendance");
            Console.WriteLine("3 Calculate Daily Wage");
            Console.WriteLine("4 Calculate Monthly Wage");
            Console.WriteLine("5 Calculate Wage Till Condition");
            Console.WriteLine("0 Exit");

            choice=int.Parse(Console.ReadLine());

            if(choice>=2 && choice<=5){
                Console.WriteLine("Enter Employee Id");
                int empId=int.Parse(Console.ReadLine());

                switch(choice){
                    case 2:
                        emp.CheckAttendance(empId);
                        break;
                    case 3:
                        emp.CalculateDailyWage(empId);
                        break;
                    case 4:
                        emp.CalculateMonthlyWage(empId);
                        break;
                    case 5:
                        emp.CalculateWageTillCondition(empId);
                        break;
                }
            }
            else if(choice==1){
                emp.AddEmployee();
            }

        }while(choice!=0);
    }
}
