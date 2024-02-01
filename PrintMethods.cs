using System;
using System.Data;
using System.Collections.Generic; 
using MySql.Data;
using Dapper;
using MySql.Data.MySqlClient;
using System.ComponentModel.Design;
class printMethods
{
    public static void PrintEmployees()
    {
        System.Console.WriteLine("************Employees*************");
        List<dynamic> empList = CompanyDatabase.GetAllEmployees();
        foreach (dynamic e in empList)
        {
        Console.WriteLine("Name: " + e.Name + ", Birthdate: " + e.Birthdate + ", Sex: " + e.Sex + ", Salary: " + e.Salary + ", ManagerID: " + e.ManagerID + ", BranchID: " + e.BranchID);
        }
    }
    public static void PrintAllManagers()
    {
        System.Console.WriteLine("*****Managers******");
        List<dynamic>mgrList = CompanyDatabase.GetAllManagers();
        foreach (dynamic m in mgrList)
        {
            Console.WriteLine("managerId: " + m.id + ", Name: " + m.name);
        }
    }
    public static void PrintInsertEmployee()
{
    System.Console.WriteLine("********Insert New Employee********");
    System.Console.Write("Enter the first name: ");
    string name = Console.ReadLine();
    
    Console.Clear();
    Console.WriteLine("Enter the birthdate in the format xxxx-xx-xx:");
    string birthDateStr = Console.ReadLine();
    if (!DateTime.TryParse(birthDateStr, out DateTime birthDate))
    {
        Console.WriteLine("Invalid date format. Please enter the date in the format xxxx-xx-xx.");
        return;
    }

    Console.Clear();
    string sex = ChooseSex();
    Console.Clear();
    System.Console.WriteLine("Enter the employees salary, only in numbers");
    int salary = int.Parse(Console.ReadLine());
    Console.Clear();
    
    int managerId = int.Parse(Console.ReadLine());
    int branchId = int.Parse(Console.ReadLine());

    CompanyDatabase.InsertEmployee(name, birthDate, sex, salary, managerId, branchId);
}

public static string ChooseSex()
{
    string sex;
    
    do
    {
        Console.WriteLine("What sex? Choose between: [F] / [M]");
        sex = Console.ReadLine().ToUpper();

        if (sex != "M" && sex != "F")
        {
            Console.WriteLine("Invalid input, please enter either [F] / [M]");
        }

    } while (sex != "M" && sex != "F");

    return sex;
}
}