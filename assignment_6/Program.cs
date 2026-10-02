using System.Net.NetworkInformation;

namespace assignment_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //==========================================Part1=========================
            // Array of Employees with size 3
            Employee[] EmpArr = new Employee[3];

            // Input handling without runtime errors
            for (int i = 0; i < EmpArr.Length; i++)
            {
                Console.WriteLine($"--- Enter Details for Employee {i + 1} ---");
                EmpArr[i] = CreateEmployeeFromInput(i + 1);
            }

            Console.WriteLine("\n================ Employee Details ================");
            foreach (var emp in EmpArr)
            {
                Console.WriteLine(emp.ToString());
            }

            //=================================================Part 2=======================
            Shape shape = new Shape(2, 3);
            Console.WriteLine(shape.Area()); // Output: 6

            Cube cube = new Cube(2, 3, 4);
            Console.WriteLine(cube.Area()); // Output: 24

            Shape shapeRef = new Cube(2, 3, 4);
            Console.WriteLine(shapeRef.Area()); /* Output: 6 Method hiding uses Static / Early Binding,
            //                                     * where method calls are bound at compile time based on the declared reference type (Shape),
            //                                     * not the actual instance type in memory (Cube).*/

            object obj = new Cube(1, 2, 3);
            Console.WriteLine(obj.ToString());/* Output: (Width = 1, Height = 2) 
            /* override uses Late / Dynamic Binding, resolving the method call at runtime using*/

            Person doc = new Doctor { ID = 1, Name = "Dr. Alice", Age = 35, Specialty = "Cardiology" };
            Person eng = new Engineer { ID = 2, Name = "Eng. Bob", Age = 28, Field = "Software" };

            ProcessPerson(doc);
            ProcessPerson(eng);
            /*person.Greet() is resolved at compile time (Static Binding)
             * because Greet() is non-virtual. The compiler binds it to Person.Greet() based on the parameter type Person. 
             * person.Display() is resolved at runtime (Dynamic Binding)
             * because Display() is virtual in Person and override in Doctor/Engineer.   */

            /*Removing (Virtual) from Display()
             The C# compiler warns that Display() in the derived class matches an inherited member signature, 
            but because the base version is not virtual, it cannot be overridden.
            If left unchanged without new, the compiler defaults to method hiding (new), breaking dynamic polymorphism.   */


            //======================================Part 3==============================
            /*
             * Q15. Fill in the comparison table from your own experiments:
                Feature	                            Static Binding (new)	                       Dynamic Binding (override)

                Keyword in base	                    None (Standard method)                          virtual (or abstract)
                Keyword in derived	                    New                                               Override
                Resolved at		                        Compile Time                                      Runtime
                Behavior via base reference	            Executes base class implementation            Executes derived class implementation

             */


        }
        public static void ProcessPerson(Person person)
        {
            person.Greet();   // Resolved at Compile Time (Static Binding)
            person.Display(); // Resolved at Runtime (Dynamic Binding)
        }

        private static Employee CreateEmployeeFromInput(int empnum)
        {
            Employee emp =new Employee();

            int id;
            do { Console.Write("Enter ID (Integer): "); }
            while (!int.TryParse(Console.ReadLine(), out id) || id <= 0);
            emp.Id = id;

            string name;
            do
            {
                Console.Write("Enter Name: ");
                name = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(name));
            emp.Name = name;


            if (empnum == 1) emp.securityLevel = SecurityLevel.DBA;
            else if (empnum == 2) emp.securityLevel = SecurityLevel.Guest;
            else emp.securityLevel = SecurityLevel.SecurityOfficer;




            decimal salary;
            do { Console.Write("Enter Salary: "); }
            while (!decimal.TryParse(Console.ReadLine(), out salary) || salary < 0 ||salary<7000);
            emp.Salary = salary;

            Gender gender;
            do { Console.Write("Enter Gender (M/F): "); }
            while (!Enum.TryParse(Console.ReadLine(), true, out gender));
            emp.Gender = gender;
            int d, m, y;
            do { Console.Write("Enter Hire Day (1-31): "); } while (!int.TryParse(Console.ReadLine(), out d) || d < 1 || d > 31);
            do { Console.Write("Enter Hire Month (1-12): "); } while (!int.TryParse(Console.ReadLine(), out m) || m < 1 || m > 12);
            do { Console.Write("Enter Hire Year: "); } while (!int.TryParse(Console.ReadLine(), out y) || y < 1900 || y > DateTime.Now.Year);

            emp.HireDate = new HiringDate(d, m, y);
            return emp;
        }
    }
}
