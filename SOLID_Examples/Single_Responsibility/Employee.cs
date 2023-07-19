using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility
{
    public class Employee
    {
        //FIELDS
        //Variables used to store information, always private
        //Lowercase naming convention, beginning with _
        //Only necessary when we have custom business rules to apply


        //PROPERTIES
        //Publicly accessible versions of the fields, always public
        //PascalCase naming convention
        //Can be used to enforce custom business rules with fields OR
        //can be used without fields to create "Automatic Properties"

        public int EmployeeId { get; set; }

        public string Name { get; set; }

        public decimal Salary { get; set; }


        //CONSTRUCTORS
        //Special methods used to "construct" objects of this type
        //PascalCase naming convention, always have the name of the class followed by parens ()
        //Always public
        //If no constructors are created in the class, we automatically have access to a default,
        //parameterless constructor.
        //We can also create constructors that accept parameters, which we can assign to properties.
        //If we create any constructors in the class, we lose access to the defualt, parameterless one
        //unless we explicitely add it back in.

        //Default, parameterless, "unqualified" constructor
        public Employee() { }

        //"Fully Qualified" Constructor
        public Employee(int employeeId, string name, decimal salary)
        {
            EmployeeId = employeeId;
            Name = name;
            Salary = salary;
        }

        //METHODS
        //Sets of instructions to be performed using an object of this type,
        //its properties, or other methods
        //PascalCase, always end with parens ()

        public void GenerateReport(Employee em)
        {
            //Code to generate a report for an employee goes here.

            //This should probably be in a separate Report class in order
            //to adhere to the Single Responsibility principle.
        }


    }
}
