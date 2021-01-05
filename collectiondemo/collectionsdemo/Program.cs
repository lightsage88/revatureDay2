using System;
using System.Collections;
using System.Collections.Generic;


namespace collectionsdemo
{
    class Program
    {
        static void Main(string[] args)
        {
                            //the 5 here is to specify the size of the array
            // int[] myNumbers = new int[5];
            // myNumbers[0] = 10;
            // myNumbers[1] = 20;
            // myNumbers[2] = 30;
            // // myNumbers[3] = 40;
            // // myNumbers[4] = 50;
            
            // System.Console.WriteLine(myNumbers[1]);

    //         int[] favNumbers = new int[10];
    //         int total_even = 0;
    //         int total_odd = 0;
    // int total = 0;
    //             for(int i = 0; i < favNumbers.Length; i++)
    //             {
    //                 System.Console.WriteLine("Enter Number : " +  Convert.ToInt32(i + 1));
    //                 int number = Convert.ToInt32(Console.ReadLine());
    //                 favNumbers[i] = number;
    //                 total += number;
    //                 if(number % 2 == 0) {
    //                     total_even ++;
    //                 } 
    //                 else
    //                 {
    //                     total_odd ++;
    //                 }
    //             favNumbers[9] = Convert.ToInt32(108.99);
    //             Console.Clear();
    //             System.Console.WriteLine("Summary");
    //             System.Console.WriteLine("amount of Odd numbers are : " + total_odd);
    //             System.Console.WriteLine("amount of Even numbers are : " + total_even);
    //             System.Console.WriteLine("Sum : " + total);

    //             Console.ReadLine();

        // ArrayList myList = new ArrayList();
        // int[] myNumbers = new int[5];
        // myList.Add(10);
        // myList.Add(10.5);
        // myList.Add("Nine");
        // myList.Add(true);
        // myList.Add(myNumbers);
        //     myList.Add(10);
        // myList.Add(10.5);
        // myList.Add("Nine");
        // myList.Add(true);

        // myList.Add(10);
        // myList.Add(10.5);
        // myList.Add("Nine");
        // myList.Add(true);

        // myList.Add(10);
        // myList.Add(10.5);
        // myList.Add("Nine");
        // myList.Add(true);

        // foreach (var item in myList)
        // {
        //     System.Console.WriteLine(item);
        // }

        // System.Console.WriteLine("Total Strength " + myList.Count);

        // Console.ReadLine();
        
        // List<int> favoriteNumbers = new List<int>();
        // favoriteNumbers.Add(10);
        // favoriteNumbers.Add(10);
        // favoriteNumbers.Add(10);
        // favoriteNumbers.Add(10);
        // favoriteNumbers.Add(10);
        // favoriteNumbers.Add(10);

        // foreach (var item in favoriteNumbers)
        // {
        //     System.Console.WriteLine(item);
        // }
        // Console.ReadLine();

        // SortedList friends = new SortedList();
        // friends.Add("Steve");
        // friends.Add("Jennifer");
        // friends.Add("Ronald");

        // Dictionary<int, string> guestList = new Dictionary<int, string>();
        // guestList.Add(101, "Steve");
        // guestList.Add(102, "Steve");
        // guestList.Add(103, "Steve");
        // guestList.Add(104, "Steve");

        // Hashtable guestList2 = new Hashtable();
        // guestList2.Add("one", "Nikhil");
        // guestList2.Add(2, "Ronald");
        // guestList2.Add("Donald", 3);

        // SortedList<int,string> friends = new System.Collections.Generic.SortedList<int, string>();
        // friends.Add(11, "Rudolph");
        // friends.Add(23, "Wolbocho");
        // friends.Add(32, "Grundy");
        // friends.Add(2, "Billy");

        // foreach (var item in friends)
        // {
        //     System.Console.WriteLine(item.Value);
        // }

        // for (int i = 0; i<= friends.Count; i++)
        // {
        //     // System.Console.WriteLine(friends[i]);
        //     System.Console.WriteLine(friends.GetValueList());
        // }

        // List<Employee> empList = new List<Employee>()
        // {
        //     new Employee(){empNo = 101, empName = "Steven", empCity="New York", empDesignation = "Chair Person", empSalary=9000},
        //     new Employee(){empNo = 101, empName = "Ronald", empCity="New York", empDesignation = "Chair Person", empSalary=9000},
        //     new Employee(){empNo = 101, empName = "Earle", empCity="New York", empDesignation = "Chair Person", empSalary=9000},
        //     new Employee(){empNo = 101, empName = "Lloyd", empCity="New York", empDesignation = "Chair Person", empSalary=9000},
        //     new Employee(){empNo = 101, empName = "Caitlyn", empCity="New York", empDesignation = "Chair Person", empSalary=9000},
        //     new Employee(){empNo = 101, empName = "Vanessa", empCity="New York", empDesignation = "Chair Person", empSalary=9000},
        //     new Employee(){empNo = 101, empName = "Keely", empCity="New York", empDesignation = "Chair Person", empSalary=9000},
        //     new Employee(){empNo = 101, empName = "Katrina", empCity="New York", empDesignation = "Chair Person", empSalary=9000},
        //     new Employee(){empNo = 101, empName = "Clarissa", empCity="New York", empDesignation = "Chair Person", empSalary=9000},
        //     new Employee(){empNo = 101, empName = "Amanda", empCity="New York", empDesignation = "Chair Person", empSalary=9000}
        // };

        // foreach (var item in empList)
        // {
        //     System.Console.WriteLine(item.empName);
        //                 item.HikeSalary();

        //     System.Console.WriteLine(item.empSalary);
        // }
        // System.Console.WriteLine("Total:" + empList.Count);

        Hashtable clients = new Hashtable();
        clients.Add(10, "Infosys");
        clients.Add("One", "Cog");
        
        System.Console.WriteLine(clients.getValue());

        Console.ReadLine();
        }
    }
}
