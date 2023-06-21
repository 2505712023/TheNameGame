namespace HelperMethods
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
         
            Console.WriteLine("The Name Game");

            Console.Write("What's your first name? ");
            string firstName = Console.ReadLine();

            Console.Write("What's your last name? ");
            string lastName = Console.ReadLine();

            Console.Write("In what city you where born? ");
            string cityName = Console.ReadLine();

            /*
            char[] firstNameArray = firstName.ToCharArray();
            Array.Reverse(firstNameArray);

            char[] lastNameArray = lastName.ToCharArray();
            Array.Reverse(lastNameArray);

            char[] cityNameArray = cityName.ToCharArray();
            Array.Reverse(cityNameArray);

            string result = "";

            foreach (char item in firstNameArray)
            {
                result += item;
            }

            result += " ";

            foreach (char item in lastNameArray)
            {
                result += item;
            }

            result += " ";

            foreach (char item in cityNameArray)
            {
                result += item;
            }

            Console.WriteLine("Result= " + result);

            Console.ReadLine();
         }
         */

            Console.Write("Result= ");
            string reversedFirstname = ReverseString(firstName);
            string reversedLastname = ReverseString(lastName);
            string reversedCityname = ReverseString(cityName);

            Console.Write(string.Format("{0} {1} {2}", 
                reversedFirstname, 
                reversedLastname, 
                reversedCityname));

            Console.ReadLine();
        }

        private static string  ReverseString(string message)
        {
            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);
            return string.Concat(messageArray);
        }
    }

}

