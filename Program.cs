using System;
using System.Data;
using System.Collections.Generic; 
using MySql.Data;
using Dapper;
using MySql.Data.MySqlClient;
using System.ComponentModel.Design;
namespace CsDatabaseConsoleProgram
{
    class Program
    {
        static void Main()
        {
            bool isRunning = true;
            while(isRunning)
            {
                Console.WriteLine("[1] Show Employees");    
                Console.WriteLine("[2] Insert new employee");
                    
                    
                    
                int select = int.Parse(Console.ReadLine());    
                    
                    switch(select)
                    {
                        case 1:
                            printMethods.PrintEmployees();
                        break; 
                        case 2:

                        break;
                    }
            }
            

        }
    
 


 }
}