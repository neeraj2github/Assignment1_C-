using System;

public class Employee
{
    private int Id;
    private string Name;
    private string DepartmentName;

    public delegate void MethodCalledEventHandler(object sender, EventArgs e);
    public event MethodCalledEventHandler MethodCalled;

    public Employee(int id, string name, string departmentName)
    {
        Id = id;
        Name = name;
        DepartmentName = departmentName;
    }

    public int GetId()
    {
        OnMethodCalled("GetId");
        return Id;
    }

    public string GetName()
    {
        OnMethodCalled("GetName");
        return Name;
    }

    public string GetDepartmentName()
    {
        OnMethodCalled("GetDepartmentName");
        return DepartmentName;
    }

    public void UpdateId(int id)
    {
        Id = id;
    }

    public void UpdateName(string name)
    {
        Name = name;
    }

    public void UpdateDepartmentName(string departmentName)
    {
        DepartmentName = departmentName;
    }
    

    protected virtual void OnMethodCalled(string methodName)
    {
        MethodCalled?.Invoke(this, EventArgs.Empty);
        Console.WriteLine("{0} method called", methodName);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the employee id: ");
        int id = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the employee name: ");
        string name = Console.ReadLine();

        Console.WriteLine("Enter the employee department name: ");
        string departmentName = Console.ReadLine();

        Employee employee = new Employee(id, name, departmentName);

        Console.WriteLine("Employee id: " + employee.GetId());
        Console.WriteLine("Employee name: " + employee.GetName());
        Console.WriteLine("Employee department name: " + employee.GetDepartmentName());
    }
}