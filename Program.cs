using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
//sanjeevan@outlook.com
//Jeevan Sivagnanasuntharam
//USAGE
//4925000000000079 is a valid creditcard number
//Mod10("492500000000007") will return 9

namespace KontrollNummerKID
{
    class Program
    {
        public static int Mod10(string kid)
        {
            bool isOne = false;
            int controlNumber = 0;
            foreach (char number in kid.Reverse())
            {
                var intNumber = Int32.Parse(number.ToString());
                var sum = isOne ? intNumber : 2 * intNumber;
                if (sum > 9)
                {
                    sum = (sum%10) + 1;
                }
                isOne = !isOne;
                controlNumber += sum;
            }
            return (10 - (controlNumber % 10)) % 10 == 0 ? 0 : 10 - (controlNumber % 10) ;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Mod10("492500000000007"));
            Console.ReadLine();
        }
    }
}
