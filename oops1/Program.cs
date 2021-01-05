using System;

namespace oops1
{

    class HR : Employee 
    {
        string v_hrType;

        public string HRType
        {
            get { return v_hrType; }
            set { v_hrType = value; }
        }
    }

    class Manager : Employee
    {
         string v_mType;

        public string MRType
        {
            get { return v_mType; }
            set { v_mType = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Employee empObj = new Employee();
            Employee empObj2 = new Employee();
            Employee empObj3 = new Employee();
            HR hrObj = new HR();
            Manager mObj = new Manager();
            // mObj.GetSalary
            hrObj.HRType = "Technical HR";

            empObj.EmployeeNumber = 101;
            empObj.EmployeeName = "Nikhil";
            empObj.EmployeeDesignation = "Trainer";
            empObj.EmployeeSalary = 12000;

            Console.WriteLine("~~~~~~~~~~ Employee Management Software ~~~~~~~~~~~~~");
            System.Console.WriteLine("Employee Number is: " + empObj.EmployeeNumber);
            System.Console.WriteLine("Employee Name is: " + empObj.EmployeeName);
            System.Console.WriteLine("Employee Works As: " + empObj.EmployeeDesignation);
            System.Console.WriteLine("Employee Annual Salary: " + empObj.EmployeeSalary * 12);

            System.Console.WriteLine(empObj.GetEmpInfo());
            System.Console.WriteLine(empObj.GetSalary());
            System.Console.WriteLine(empObj.GetBonus(25));

            Console.ReadLine();
            
            

        }
    }
}
