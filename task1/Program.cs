using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Podaj swoje imię :");
                var userFirstName = GetNotEmptyString();

                Console.WriteLine("Podaj rok urodzenia :");
                var yearOfBirth = GetInput();

                Console.WriteLine("Podaj miesiąc urodzenia : ");
                var monthOfBirth = GetInput();

                Console.WriteLine("Podaj dzień urodzenia : ");
                var dayOfBirth = GetInput();

                Console.WriteLine("Podaj miejsce urodzenia : ");
                var placeOfBirth = GetNotEmptyString();

                var dateOfBirth = new DateTime(yearOfBirth, monthOfBirth, dayOfBirth);

                User user = new User(userFirstName, dateOfBirth, placeOfBirth);
                Console.WriteLine(user.getInfo());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }

        private static string GetNotEmptyString()
        {
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                throw new Exception("Wartość userFirstName nie może być pusta");
            }

            return input;
        }

        private static int GetInput()
        {
            if(!int.TryParse(Console.ReadLine(), out int input))
            {
                throw new Exception("Podana wartość jest nieprawidłowa");
            }

            return input;
        }


    }
}