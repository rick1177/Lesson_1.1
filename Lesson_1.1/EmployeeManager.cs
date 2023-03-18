using System.Collections.Generic;
using System.Reflection;

// ReSharper disable All

namespace Lesson_01
{
    public sealed class EmployeeManager
    {
        /*
         * Данная строка создает и инициализирует статическое и неизменяемое поле instance
         * типа EmployeeManager. Это поле будет хранить единственный экземпляр класса EmployeeManager,
         * который будет доступен всем другим частям программы.
         
         * Таким образом, данный код реализует паттерн проектирования "Singleton",
         * который гарантирует, что класс EmployeeManager будет создан только один раз,
         * и все обращения к нему будут использовать один и тот же экземпляр класса.
         */

        private readonly List<Employee> employees = new List<Employee>();
        private static EmployeeManager instance;

        /*
         * В данном примере с помощью статического конструктора (метода с модификатором static)
         * и конструктора с модификатором доступа private ограничивается доступ к конструктору
         * класса EmployeeManager. Это делается для того, чтобы класс мог создаваться только
         * внутри самого себя (например, в методах класса), а не извне.
         *
         * Статический конструктор вызывается один раз при первом обращении к статическому члену
         * класса (например, к статическому полю). В данном примере он используется для инициализации
         * статического поля instance, которое хранит ссылку на единственный экземпляр класса
         * EmployeeManager. Без такой инициализации ссылка на объект не будет создана и соответствующий
         * объект не будет создан при первом обращении к нему.
         * 
         * Конструктор с модификатором доступа private ограничивает доступ к конструктору класса
         * EmployeeManager только внутри самого класса. Это делается для того, чтобы объекты
         * класса могли создаваться только внутри класса и никакой другой код не мог создать
         * экземпляры класса. Таким образом, реализуется синглтон-паттерн, когда существует только
         * один экземпляр класса в приложении.
         */
        static EmployeeManager()
        {
        }

        private EmployeeManager()
        {
        }

        public static EmployeeManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new EmployeeManager();
                }

                return instance;
            }
        }

        private static int count = 0;

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
            count++;
        }

        public void RemoveEmployee(Employee employee)
        {
            employees.Remove(employee);
            Employee.delete_employee();
            count--;
        }

        public List<Employee> GetEmployees()
        {
            return employees;
        }

        public void UpdateEmployee(Employee employee)
        {
            // Найти и заменить существующий объект Employee в списке
            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i].IDEmployee == employee.IDEmployee)
                {
                    employees[i] = employee;
                    break;
                }
            }
        }

        public Employee FindEmployeeByField(string fieldName, object fieldValue)
        {
            // Проход по каждому элементу списка и проверка заданного поля на соответствие
            foreach (Employee employee in employees)
            {
                var field = typeof(Employee).GetField(fieldName, BindingFlags.Public | BindingFlags.Instance);

                if (field != null && field.GetValue(employee).Equals(fieldValue))
                {
                    return employee;
                }
            }

            return null;
        }


        public void UpdateEmployee(string employeeId, Dictionary<string, object> fieldsToUpdate)
        {
            // Найти и обновить существующий объект Employee в списке
            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i].IDEmployee == employeeId)
                {
                    foreach (var kvp in fieldsToUpdate)
                    {
                        var field = typeof(Employee).GetField(kvp.Key,
                            BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                        if (field != null)
                        {
                            field.SetValue(employees[i], kvp.Value);
                        }
                    }

                    break;
                }
            }
        }

        public int GetNumberOfEmployees()
        {
            return count;
        }
    }
}