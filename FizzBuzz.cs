using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{


    public string FizzBuzz(int number)
    {
        Console.WriteLine("Enter a number from 1-100");
        answer = Convert.ToInt32(Console.ReadLine());

        if (number % 3 == 0)
        {
            answer = "Fizz"
          }

        if (number % 5 == 0)
        {
            answer += "Buzz"
        }
        return answer;


    }

}