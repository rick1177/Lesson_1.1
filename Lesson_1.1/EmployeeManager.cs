using System.Collections.Generic;
using System.Reflection;

namespace Lesson_01
{
    public class EmployeeManager
    {
        private List<Employee> employees;
        private static EmployeeManager instance;
        public static int count;

        public static EmployeeManager Instance
        {
            get
            {
                if (instance == null) instance = new EmployeeManager();

                return instance;
            }
        }

        public EmployeeManager()
        {
            employees = new List<Employee>();
        }

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
            count++;
        }

        public void AddManager(Manager manager)
        {
            employees.Add(manager);
            count++;
        }

        public void RemoveEmployee(Employee employee)
        {
            employees.Remove(employee);
            count--;
        }

        public void RemoveManager(Manager manager)
        {
            employees.Remove(manager);
            count--;
        }

        public List<Employee> GetEmployees()
        {
            return employees;
        }

        public T FindByField<T>(string fieldName, object fieldValue) where T : Employee
        {
            foreach (var employee in employees)
                if (employee is T && employee.GetType().GetField(
                        fieldName, BindingFlags.Public | BindingFlags.Instance
                    ).GetValue(employee).Equals(fieldValue))
                    return (T)employee;
            return null;
        }

        public void Update<T>(T employee, Dictionary<string, object> fieldsToUpdate) where T : Employee
        {
            if (employee is T && fieldsToUpdate != null)
                foreach (var kvp in fieldsToUpdate)
                {
                    var fieldName = kvp.Key;
                    var newValue = kvp.Value;
                    var field = employee.GetType().GetField(fieldName,
                        BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                    if (field != null) field.SetValue(employee, newValue);
                }
        }

        public int GetNumberOfEmployees()
        {
            return count;
        }
    }
}