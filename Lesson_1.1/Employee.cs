using System.Collections.Generic;
using System.Collections.Specialized;
using System.Runtime.CompilerServices;

namespace Lesson_01
{
    public class Employee
    {
        protected static int nextId = 0;

        protected string first_name;
        protected string middle_name;
        protected string second_name;
        protected float salary;
        protected static float min_salary = 12000;
        public string IDEmployee;
        protected static int employee_count;
        public int Id;


        public Employee()
        {
            employee_count += 1;
            first_name = "Тест_" + employee_count.ToString();
            middle_name = "Тестович_" + employee_count.ToString();
            second_name = "Тестов_" + employee_count.ToString();
            salary = min_salary;
            IDEmployee = employee_count.ToString() +
                         first_name[0].ToString() +
                         middle_name[0].ToString() +
                         second_name[0].ToString();
            SetId(GetNextId());
        }

        public Employee(Dictionary<string, string> nameDict, float _salary)
        {
            employee_count += 1;
            this.first_name = nameDict.TryGetValue("first_name", out var first_name) ? first_name : "Тест_";
            this.middle_name = nameDict.TryGetValue("middle_name", out var middle_name) ? middle_name : "Тестович_";
            this.second_name = nameDict.TryGetValue("second_name", out var second_name) ? second_name : "Тестов_";
            this.first_name = this.first_name == "" ? "Тест_" + employee_count.ToString() : this.first_name;
            this.middle_name = this.middle_name == "" ? "Тестович_" + employee_count.ToString() : this.middle_name;
            this.second_name = this.second_name == "" ? "Тестов_" + employee_count.ToString() : this.second_name;
            salary = _salary;
            IDEmployee = employee_count.ToString() +
                         this.first_name[0].ToString() +
                         this.middle_name[0].ToString() +
                         this.second_name[0].ToString();
            SetId(GetNextId());
        }

        public Employee(Dictionary<string, string> nameDict)
        {
            employee_count += 1;
            this.first_name = nameDict.TryGetValue("first_name", out var first_name)
                ? first_name
                : "Тест_" + employee_count.ToString();
            this.middle_name = nameDict.TryGetValue("middle_name", out var middle_name)
                ? middle_name
                : "Тестович_" + employee_count.ToString();
            this.second_name = nameDict.TryGetValue("second_name", out var second_name)
                ? second_name
                : "Тестов_" + employee_count.ToString();
            this.first_name = this.first_name == "" ? "Тест_" + employee_count.ToString() : this.first_name;
            this.middle_name = this.middle_name == "" ? "Тестович_" + employee_count.ToString() : this.middle_name;
            this.second_name = this.second_name == "" ? "Тестов_" + employee_count.ToString() : this.second_name;

            salary = min_salary;
            IDEmployee = employee_count.ToString() +
                         this.first_name[0].ToString() +
                         this.middle_name[0].ToString() +
                         this.second_name[0].ToString();
            SetId(GetNextId());
        }

        public virtual float get_salary()
        {
            return salary;
        }


        public void change_employee(Employee emp,
            string f_n = "",
            string m_n = "",
            string s_n = "",
            long s = -1)
        {
            if (f_n != "") emp.first_name = f_n;
            if (m_n != "") emp.middle_name = m_n;
            if (s_n != "") emp.second_name = s_n;

            if (s != -1) emp.salary = s;
        }


        public static float get_min_salary()
        {
            return min_salary;
        }

        // Метод увеличесния статического знания
        public static void set_min_salary(int value)
        {
            min_salary += value;
        }

        public static int get_employee_count()
        {
            return employee_count;
        }

        public static void delete_employee()
        {
            employee_count -= 1;
        }

        override
            public string ToString()
        {
            var temp_str = string.Join(" ",
                $"{IDEmployee} ({Id}):".TrimEnd('.'),
                $"{first_name}".TrimEnd('.'),
                $"{middle_name}".TrimEnd('.'),
                $"{second_name},",
                "оклад:",
                $"{salary}");
            return temp_str;
        }

        private void SetId(int id)
        {
            Id = id;
        }

        private int GetId(int id)
        {
            return Id;
        }

        private static int GetNextId()
        {
            nextId += 1;
            return nextId;
        }
    }
}