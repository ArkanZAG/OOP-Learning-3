namespace ConsoleApp1;

public class Employee
{
    public IRoles role;
    private string employeesName;

    public Employee(IRoles role, string employeesName)
    {
        this.role = role;
        this.employeesName = employeesName;
    }

    private void DoJob()
    {
        role.DoJob();
    }

}