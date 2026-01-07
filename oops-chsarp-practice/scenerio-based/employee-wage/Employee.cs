class Employee{
    private int empId;
    private int wagePerHour;
    private int empType; //1 Full Time 2 Part Time

    public void SetEmpId(int empId){
        this.empId=empId;
    }

    public int GetEmpId(){
        return empId;
    }

    public void SetWagePerHour(int wagePerHour){
        this.wagePerHour=wagePerHour;
    }

    public int GetWagePerHour(){
        return wagePerHour;
    }

    public void SetEmpType(int empType){
        this.empType=empType;
    }

    public int GetEmpType(){
        return empType;
    }
    public override string ToString(){
        return "Employee Id: "+empId+" Wage Per Hour: "+wagePerHour+" Employee Type: "+empType;
    }
}
