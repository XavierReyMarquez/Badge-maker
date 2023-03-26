using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CatWorx.BadgeMaker
{
  class Program
  {
  static List<Employee> GetEmployees()
  {
    List<Employee> employees = new List<Employee>();
    while(true)
    {
      Console.WriteLine("Enter first name (leave empty to exit): ");

      string firstName  = Console.ReadLine() ?? "";
      // or if something else is added.
      if (firstName  =="")
      {
        break;
      }
      

      Console.Write("Enter last name: ");
      string lastName = Console.ReadLine() ?? "";
      Console.Write("Enter ID: ");
      int id = Int32.Parse(Console.ReadLine() ?? "");
      Console.Write("Enter Photo URL:");
      string photoUrl = Console.ReadLine() ?? "";
      Employee currentEmployee = new Employee(firstName, lastName, id, photoUrl);
      employees.Add(currentEmployee);
    }
      return employees;
    }
//   static void PrintEmployees(List<Employee> employees)
//       {
//         for (int i = 0; i < employees.Count; i++) 
// {
//   string template = "{0,-10}\t{1,-20}\t{2}";
//   Console.WriteLine(String.Format(template, employees[i].GetId(), employees[i].GetFullName(), employees[i].GetPhotoUrl()));
// }
//     }
  async static Task Main(string[] args)
    {
      List<Employee> employees = new List<Employee>();
      employees = GetEmployees();

      Util.PrintEmployees(employees);
      Util.MakeCSV(employees);
      await Util.MakeBadges(employees);
    }   
  }
}