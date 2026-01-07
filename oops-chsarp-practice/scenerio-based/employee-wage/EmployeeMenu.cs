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
           
            Console.WriteLine("0 Exit");

            choice=int.Parse(Console.ReadLine());

            if(choice==1){
                emp.AddEmployee();
            }

        }while(choice!=0);
    }
}
