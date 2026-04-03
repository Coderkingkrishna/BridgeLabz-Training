using System;
class Employee{
	private String EmployeeName;
	private int EmployeeId;
	private double Salary;
	public Employee(String EmployeeName, int EmployeeId, double Salary){
		this.EmployeeName = EmployeeName;
		this.EmployeeId = EmployeeId;
		this.Salary = Salary;
	}
	public void Display(){
		Console.WriteLine("Name : "+EmployeeName+"\nEmployeeId : "+EmployeeId+"\nSalary : "+Salary);
	}
}

class User{
	static void Main(){
		Employee Jame = new Employee("Jame", 123, 1000.1);
		Jame.Display();
	}
}