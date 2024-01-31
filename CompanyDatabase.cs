using System;
using System.Data;
using System.Collections.Generic; 
using MySql.Data;
using Dapper;
using MySql.Data.MySqlClient;
using System.ComponentModel.Design;

static class CompanyDatabase
{
    static string connectionString = "server=localhost;database=companydatabase;uid=root;pwd=root";
    static IDbConnection connection = new MySqlConnection(connectionString);

    public static List<dynamic> GetAllEmployees()
    {
        string sql = "SELECT employee.name AS Name, employee.birthDate AS Birthdate, employee.salary AS Salary, employee.managerId AS ManagerID, employee.branchId AS BranchID " + 
        "FROM employee";
        var allEmployees = connection.Query<dynamic>(sql).ToList();
        return allEmployees;
    }   
    public static void InsertEmployee(string name, int birthdate, string sex, int salary, int managerId, int branchId)
    {
            string sql=$"INSERT INTO employee VALUES(\"{name}\", {birthdate}, {sex}, {salary}, {managerId}, {branchId});";
            connection.Execute(sql);
    }
}



