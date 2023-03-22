using System.Collections.Generic;

namespace Lesson_01
{
    public class Manager : Employee
    {
        private float bonus;
        protected static float min_bonus = 0;

        public Manager() : base()
        {
            bonus = min_bonus;
        }

        public Manager(float _bonus) : base()
        {
            bonus = _bonus;
        }

        public Manager(Dictionary<string, string> nameDict, float _salary) : base(nameDict, _salary)
        {
            bonus = min_bonus;
        }

        public Manager(Dictionary<string, string> nameDict, float _salary, float _bonus) : base(nameDict, _salary)
        {
            bonus = _bonus;
        }

        public Manager(Dictionary<string, string> nameDict) : base(nameDict)
        {
            bonus = min_bonus;
        }

        public float get_bonus()
        {
            return bonus;
        }

        public void set_bonus(float bonus)
        {
            this.bonus = bonus;
        }

        public override float get_salary()
        {
            return base.get_salary() + bonus;
        }

        public override string ToString()
        {
            var temp_str = string.Join(" ",
                $"{IDEmployee} ({Id}):".TrimEnd('.'),
                $"{first_name}".TrimEnd('.'),
                $"{middle_name}".TrimEnd('.'),
                $"{second_name},",
                "оклад:",
                $"{salary}",
                ",", "бонус:",
                $"{bonus}");
            return temp_str;
        }
    }
}