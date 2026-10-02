using System;
using System.Collections.Generic;
using System.Text;

namespace assignment_6
{
    public enum Gender
    {
        M,
        F
    }
    [Flags] 
    public enum SecurityLevel
    {
        Guest = 1,
        Developer = 2,
        Secretary = 4,
        DBA = 8,
        SecurityOfficer = Guest | Developer | Secretary | DBA // Full permissions
    }
    internal class Employee
    {
        public int Id {  get; set; }
        public SecurityLevel securityLevel {  get; set; }
        private string _name=string.Empty;
        private decimal _salary ;
        public  HiringDate HireDate { get; set; }
        public Gender Gender { get; set; }

        public string Name
        {
            get {  return _name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Name cannot be empty.");
                _name = value;
            }
        }
        public decimal Salary
        {
            get { return _salary; }
            set
            {
                if (value <7000)
                    throw new ArgumentOutOfRangeException(nameof(Salary), "Salary cannot be less than 7000");
                _salary = value;
            }
        }
        public Employee()
        {
            HireDate = new HiringDate();
        }

        public Employee(int id, string name, SecurityLevel securityLevel, decimal salary, HiringDate hireDate, Gender gender)
        {
            Id = id;
            Name = name;
            this.securityLevel = securityLevel;
            Salary = salary;
            HireDate = hireDate;
            Gender = gender;
        }

        public override string ToString()
        {
            return string.Format(
                "ID: {0}   | Name: {1} | Gender: {2} | Security: {3} | Salary: {4,12:C} | Hire Date: {5}",
                Id, Name, Gender, securityLevel, Salary, HireDate
            );
        }

    }
}
