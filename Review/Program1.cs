using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeePayrollLeaveManagement
{
    
    public abstract class Employee
    {
        public int EmployeeId { get; }
        public string Name { get; }
        public Department? Department { get; internal set; }

        protected Employee(int employeeId, string name)
        {
            EmployeeId = employeeId;
            Name = name;
        }

        
        public abstract decimal CalculatePay();

        public override string ToString()
        {
            return $"{EmployeeId} - {Name}";
        }
    }

   
    public class FullTimeEmployee : Employee
    {
        public decimal MonthlySalary { get; }
        public decimal Benefits { get; }

        public FullTimeEmployee(
            int employeeId,
            string name,
            decimal monthlySalary,
            decimal benefits)
            : base(employeeId, name)
        {
            MonthlySalary = monthlySalary;
            Benefits = benefits;
        }

        public override decimal CalculatePay()
        {
            return MonthlySalary + Benefits;
        }
    }

   
    public class ContractEmployee : Employee
    {
        public decimal HourlyRate { get; }
        public int HoursWorked { get; set; }

        public ContractEmployee(
            int employeeId,
            string name,
            decimal hourlyRate)
            : base(employeeId, name)
        {
            HourlyRate = hourlyRate;
        }

        public override decimal CalculatePay()
        {
            return HourlyRate * HoursWorked;
        }
    }

    
    public class Manager : FullTimeEmployee
    {
        public Manager(
            int employeeId,
            string name,
            decimal monthlySalary,
            decimal benefits)
            : base(employeeId, name, monthlySalary, benefits)
        {
        }

        // Only Manager has this capability.
        public void ApproveLeave(LeaveRequest request)
        {
            if (Department == null)
            {
                throw new InvalidOperationException(
                    "Manager is not assigned to a department.");
            }

            if (request.Employee.Department != Department)
            {
                throw new InvalidOperationException(
                    "Manager can only approve leave for employees in their department.");
            }

            request.Approve(this);
        }
    }

    
    public class Department
    {
        private readonly List<Employee> employees = new();

        public string Name { get; }

        public IReadOnlyList<Employee> Employees => employees.AsReadOnly();

        public Department(string name)
        {
            Name = name;
        }

        public void AddEmployee(Employee employee)
        {
            if (employee.Department == this)
                return;

            // Employee can be transferred from another department.
            employee.Department?.RemoveEmployee(employee);

            employees.Add(employee);
            employee.Department = this;
        }

        public void RemoveEmployee(Employee employee)
        {
            if (employees.Remove(employee))
            {
                if (employee.Department == this)
                {
                    employee.Department = null;
                }
            }
        }

        public override string ToString()
        {
            return Name;
        }
    }

   
    public class Company
    {
        private readonly List<Department> departments = new();

        public string Name { get; }

        public IReadOnlyList<Department> Departments =>
            departments.AsReadOnly();

        public Company(string name)
        {
            Name = name;
        }

        public void AddDepartment(Department department)
        {
            if (!departments.Contains(department))
            {
                departments.Add(department);
            }
        }
    }


    public class Payroll
    {
        public Employee Employee { get; }
        public DateTime PayPeriodStart { get; }
        public DateTime PayPeriodEnd { get; }
        public decimal Amount { get; }

        public Payroll(
            Employee employee,
            DateTime payPeriodStart,
            DateTime payPeriodEnd)
        {
            if (employee == null)
                throw new ArgumentNullException(nameof(employee));

            if (payPeriodEnd < payPeriodStart)
                throw new ArgumentException(
                    "Pay period end cannot be before start.");

            Employee = employee;
            PayPeriodStart = payPeriodStart;
            PayPeriodEnd = payPeriodEnd;

            
            Amount = employee.CalculatePay();
        }

        public void PrintPayroll()
        {
            Console.WriteLine("----- Payroll -----");
            Console.WriteLine($"Employee: {Employee.Name}");
            Console.WriteLine($"Employee ID: {Employee.EmployeeId}");
            Console.WriteLine(
                $"Pay Period: {PayPeriodStart:dd-MM-yyyy} to {PayPeriodEnd:dd-MM-yyyy}");
            Console.WriteLine($"Pay: {Amount:C}");
            Console.WriteLine();
        }
    }

  
    public enum LeaveStatus
    {
        Pending,
        Approved,
        Rejected
    }


    public class LeaveRequest
    {
        public Employee Employee { get; }
        public DateTime StartDate { get; }
        public DateTime EndDate { get; }
        public string Reason { get; }

        public LeaveStatus Status { get; private set; }

        public Manager? ApprovedBy { get; private set; }

        public LeaveRequest(
            Employee employee,
            DateTime startDate,
            DateTime endDate,
            string reason)
        {
            if (employee == null)
                throw new ArgumentNullException(nameof(employee));

            if (endDate < startDate)
                throw new ArgumentException(
                    "End date cannot be before start date.");

            Employee = employee;
            StartDate = startDate;
            EndDate = endDate;
            Reason = reason;
            Status = LeaveStatus.Pending;
        }

        internal void Approve(Manager manager)
        {
            Status = LeaveStatus.Approved;
            ApprovedBy = manager;
        }

        public void PrintRequest()
        {
            Console.WriteLine("----- Leave Request -----");
            Console.WriteLine($"Employee: {Employee.Name}");
            Console.WriteLine(
                $"Dates: {StartDate:dd-MM-yyyy} to {EndDate:dd-MM-yyyy}");
            Console.WriteLine($"Reason: {Reason}");
            Console.WriteLine($"Status: {Status}");

            if (ApprovedBy != null)
            {
                Console.WriteLine($"Approved By: {ApprovedBy.Name}");
            }

            Console.WriteLine();
        }
    }

  
    public class PayrollProcessor
    {
        public Payroll ProcessPayroll(
            Employee employee,
            DateTime startDate,
            DateTime endDate)
        {
            

            return new Payroll(employee, startDate, endDate);
        }
    }

 
    class Program
    {
        static void Main()
        {
           
            Company company = new Company("ABC Technologies");

            
            Department development = new Department("Development");
            Department hr = new Department("Human Resources");

            company.AddDepartment(development);
            company.AddDepartment(hr);

            
            FullTimeEmployee employee1 =
                new FullTimeEmployee(
                    101,
                    "Alice",
                    60000m,
                    5000m);

            ContractEmployee employee2 =
                new ContractEmployee(
                    102,
                    "Bob",
                    500m);

            Manager manager =
                new Manager(
                    103,
                    "John",
                    80000m,
                    10000m);

            
            employee2.HoursWorked = 160;

            development.AddEmployee(employee1);
            development.AddEmployee(employee2);
            development.AddEmployee(manager);

            Console.WriteLine("Employees in Development:");
            foreach (Employee employee in development.Employees)
            {
                Console.WriteLine(employee);
            }

            Console.WriteLine();

            Console.WriteLine("Transferring Bob to HR...");

            hr.AddEmployee(employee2);

            Console.WriteLine();

            Console.WriteLine("Employees in Development:");
            foreach (Employee employee in development.Employees)
            {
                Console.WriteLine(employee);
            }

            Console.WriteLine();

            Console.WriteLine("Employees in HR:");
            foreach (Employee employee in hr.Employees)
            {
                Console.WriteLine(employee);
            }

            Console.WriteLine();

            PayrollProcessor processor = new PayrollProcessor();

            Payroll payroll1 = processor.ProcessPayroll(
                employee1,
                new DateTime(2026, 8, 1),
                new DateTime(2026, 8, 31));

            Payroll payroll2 = processor.ProcessPayroll(
                employee2,
                new DateTime(2026, 8, 1),
                new DateTime(2026, 8, 31));

            payroll1.PrintPayroll();
            payroll2.PrintPayroll();

            LeaveRequest leaveRequest =
                new LeaveRequest(
                    employee1,
                    new DateTime(2026, 9, 1),
                    new DateTime(2026, 9, 5),
                    "Personal work");

            Console.WriteLine("Before approval:");
            leaveRequest.PrintRequest();

            // Manager approves the request.
            manager.ApproveLeave(leaveRequest);

            Console.WriteLine("After approval:");
            leaveRequest.PrintRequest();
        }
    }
}