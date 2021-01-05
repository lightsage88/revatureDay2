class Employee
{
    public int empNo {get; set;}
    public string empName {get; set;}
    public double empSalary {get; set;}
    public string empCity {get; set;}
    //
    public string empDesignation {get; set;}


    public void HikeSalary()
    {
       empSalary += 600;
    }
}