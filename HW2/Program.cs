using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    class Program
    {
        //enum HTTP_Errors
        //{
        //    Bad_Request = 400,
        //    Unauthorized,
        //    Payment_Required,
        //    Forbidden,
        //    Not_Found,
        //    Method_Not_Allowed,
        //    Not_Acceptable,
        //    Proxy_Authentication_Required,
        //    Request_Timeout,
        //    Conflict, Gone,
        //    Length_Required,
        //    Payload_Too_Large,
        //    URI_Too_Long,
        //    Unsupported_Media_Type,
        //    Range_Not_Satisfiable,
        //    Expectation_Failed,
        //    I_am_a_teapot
        //}
        static void Main(string[] args)
        {
            #region read 3 float numbers and check: are they all belong to the range [-5,5].
            //Console.Write("Enter 3 numbers belong to the range [-5, 5]: ");
            //float firstNumber = float.Parse(Console.ReadLine());
            //float secondNumber = float.Parse(Console.ReadLine());
            //float fridNumber = float.Parse(Console.ReadLine());

            //if (firstNumber > -5.0 && firstNumber < 5.0)
            //{
            //   Console.WriteLine("The number '{0}'is belong to the range[-5, 5]", firstNumber);
            //}
            //else if (secondNumber > -5.0 && secondNumber < 5.0)
            //{
            //   Console.WriteLine("The number '{0}'is belong to the range[-5, 5]", secondNumber);
            //}
            //else if (fridNumber > -5.0 && fridNumber < 5.0)
            //{
            //   Console.WriteLine("The number '{0}'is belong to the range[-5, 5]", fridNumber);
            //}
            //else
            //{
            //   Console.WriteLine("The number '{0}'is not belong to the range[-5, 5]", number);
            //}

            //Console.ReadKey();
            #endregion

            #region [read 3 integers and write max and min of them.]

            Console.Write("Enter 3 number :");
            int firstDigit = Int32.Parse(Console.ReadLine());
            int secondDigit = Int32.Parse(Console.ReadLine());
            int thirDigit = Int32.Parse(Console.ReadLine());

            if (firstDigit <= secondDigit && firstDigit <= thirDigit && secondDigit < thirDigit)
            {

                Console.WriteLine("Min number ='{0}' and Max = '{1}'", firstDigit, thirDigit);
            }
            else
            {
                Console.WriteLine("Min number ='{0}' and Max = '{1}'", firstDigit, secondDigit);
            }
            
            Console.ReadKey();

            #endregion

            //read number of HTTP Error(400, 401, 402, ...)
            #region
            //Console.Write("Enter digit Erorr: ");
            //int digit;
            //digit = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Your error digit'{0}' ,and error name '{1}'", digit, (HTTP_Errors)digit);
            #endregion

            Dog myDog;
            Console.WriteLine("Write Name :");
            myDog.name = Console.ReadLine();
            Console.WriteLine("Write mark :");
            myDog.mark = Console.ReadLine();
            Console.WriteLine("Write age :");
            myDog.age = byte.Parse(Console.ReadLine());

            Console.WriteLine(myDog.ToString());

            Console.ReadKey();
        }

        public struct Dog
        {
            public string name;
            public string mark;
            public byte age;

            public override string ToString()
            {
                return ($"You entered name of dog '{name}' mark '{mark}' and age '{age}'");
            }
        }

    }
}
