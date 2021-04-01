using AutoPractice7.Common;
using AutoPractice7.CSV.Models;
using ConsoleTables;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace AutoPractice7.CSV
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = Path.Combine(PathHelper.SolutionFolderPath, "Files", "CsvFile.csv");
            List<EmployeeDto> dataWithLinq = File.ReadAllLines(filePath)
                                                        .Skip(1)
                                                        .Select(line => new EmployeeDto().GetData(line))
                                                        .ToList();

            List<EmployeeDto> data = MyCsvReader.ReadData<EmployeeDto>(filePath);

            PrintEmployeesTable(data);

            Console.ReadLine();
        }

        static void PrintEmployeesTable(List<EmployeeDto> employees)
        {
            List<string> headers = new List<string>();
            foreach (PropertyInfo prop in typeof(EmployeeDto).GetProperties())
            {
                headers.Add(prop.Name);
            }

            ConsoleTable table = new ConsoleTable(headers.ToArray()); 
            foreach (EmployeeDto employee in employees)
            {
                table.AddRow(employee.Id,
                            employee.FirstName,
                            employee.LastName,
                            employee.DateOfBirth.ToString("MM/dd/yyyy"),
                            employee.Age,
                            employee.Salary);
            }

            Console.WriteLine(table);

        }
    }
}
