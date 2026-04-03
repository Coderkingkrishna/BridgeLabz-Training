using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

class EmployeeSerialization
{
    [DataContract]
    class Employee
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Department { get; set; }

        [DataMember]
        public double Salary { get; set; }
    }

    static void Main()
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee
            {
                Id = 1,
                Name = "A",
                Department = "IT",
                Salary = 50000,
            },
            new Employee
            {
                Id = 2,
                Name = "B",
                Department = "HR",
                Salary = 40000,
            },
        };

        string path = "employees.json";

        // Serialize
        DataContractJsonSerializer serializer = new DataContractJsonSerializer(
            typeof(List<Employee>)
        );

        using (FileStream fs = new FileStream(path, FileMode.Create))
        {
            serializer.WriteObject(fs, employees);
        }

        // Deserialize
        using (FileStream fs = new FileStream(path, FileMode.Open))
        {
            var list = (List<Employee>)serializer.ReadObject(fs);

            foreach (var e in list)
                Console.WriteLine(e.Id + " " + e.Name + " " + e.Department + " " + e.Salary);
        }
    }
}
