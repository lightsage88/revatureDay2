public class Employee 
{
    //List of Variables - these are intriniscally private
    int v_empNo;
    string v_empName;
    string v_empDesignation;
    double v_empSalary;

    //Properties - these are typically public
    public int EmployeeNumber
    {
        get { return v_empNo; }
        set { v_empNo = value; }
    }

    public string EmployeeName
    {
        get { return v_empName; }
        set { v_empName = value; }
    }
    //the value comes from the user

    public string EmployeeDesignation
    {
        get { return v_empDesignation; }
        set { v_empDesignation = value; }
    }

    public double EmployeeSalary
    {
        get { return v_empSalary; }
        set { v_empSalary = value; }
    }


    //functions 8:06am
    public string GetEmpInfo() 
    {
        return this.EmployeeName + " Works as " + this.EmployeeDesignation;
    }

    public double GetSalary()
    {
        return this.EmployeeSalary;
    }

    public double GetBonus(int percentage)
    {
        return (this.EmployeeSalary * percentage) / 100;
    }


}