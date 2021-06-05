using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class User
    {
        private string firstname;
        private DateTime birthday;
        private string birthplace;

        public User(string firstname, DateTime birthday, string birthplace)
        {
            this.firstname = firstname;
            this.birthday = birthday;
            this.birthplace = birthplace;
        }

        private int calculateAge()
        {
            return DateTime.Now.Year - birthday.Year;
        }

        public string getInfo()
        {
            return $"Cześć {firstname} urodziłeś się w {birthplace} i masz {calculateAge()} lat";
        }
    }
}
