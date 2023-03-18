using System.Collections.Generic;

namespace Lesson_01
{
    public class Manager : Employee
    {
        private float bonus;
        protected static float min_bonus = 0;

        public Manager() : base()
        {
            this.bonus = min_bonus;
        }
        
        public Manager(float _bonus) : base()
        {
            this.bonus = _bonus;
        }

        public Manager(Dictionary<string, string> nameDict, float _salary) : base(nameDict, _salary)
        {
            this.bonus = min_bonus;
        }

        public Manager(Dictionary<string, string> nameDict, float _salary, float _bonus) : base(nameDict, _salary)
        {
            this.bonus = _bonus;
        }

        public Manager(Dictionary<string, string> nameDict) : base(nameDict)
        {
            this.bonus = min_bonus;
        }

        public float get_bonus()
        {
            return this.bonus;
        }
        
        public void set_bonus(float bonus)
        {
            this.bonus = bonus;
        }
        
        public override float get_salary()
        {
            return base.get_salary() + this.bonus;
        }
        
        public override string ToString()
        {
            var temp_str = string.Join(" ",
                $"{base.IDEmployee} ({base.Id}):".TrimEnd('.'),
                $"{base.first_name}".TrimEnd('.'),
                $"{base.middle_name}".TrimEnd('.'),
                $"{base.second_name},",
                "оклад:",
                $"{base.salary}",
                ",", "бонус:",
                $"{this.bonus}");
            return temp_str;
        }
    }
}


/*using System.Windows.Forms.VisualStyles;

namespace Lesson_01
{
    public class Manager: Employee
    {
        private float bonus;
        private static int min_bonus = 12000;
        private static int manager_count;

        public Manager(
            string _first_name,
            string _middle_name,
            string _second_name,
            float _salary,
            float _bonus=0):base(
                _first_name,
                _middle_name,
                _second_name,
                _salary)
        {
            if (_bonus == 0)
            {
                this.bonus = min_bonus;
            }
            this.bonus = _bonus;
        }
        
        
        public Manager(
            string _first_name,
            string _second_name,
            float _salary,
            float _bonus=0):base(
            _first_name,
            _second_name,
            _salary)
        {
            if (_bonus == 0)
            {
                this.bonus = min_bonus;
            }
            this.bonus = _bonus;
        }
        
        public Manager(
            string _first_name,
            string _middle_name,
            string _second_name,
            float _bonus=0):base(
            _first_name,
            _middle_name,
            _second_name)
        {
            if (_bonus == 0)
            {
                this.bonus = min_bonus;
            }
            this.bonus = _bonus;
        }
        
        public Manager(
            string _first_name,
            string _second_name,
            float _bonus=0):base(
            _first_name,
            _second_name)
        {
            if (_bonus == 0)
            {
                this.bonus = min_bonus;
            }
            this.bonus = _bonus;
        }
        
        public Manager(
            float _bonus):base()
        {
            this.bonus = _bonus;
        }
        
        public static int get_min_bonus()
        {
            return min_bonus;
        }
        
        // Метод увеличесния статического знания
        public static void set_min_bonus(int value)
        {
            min_bonus += value;
        }
        
        public static int get_manager_count()
        {
            return manager_count;
        }
        
        
        public override float get_salary()
        {
            return base.get_salary() + this.bonus;
        }
        
        
    }
}*/