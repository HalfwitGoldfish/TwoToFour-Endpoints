using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TwoToFour_Endpoints.Services
{
    public class Add2NumbersServices
    {
        public string Add(int num1, int num2)
        {
            return $"The Sum of {num1} and {num2} is {num1 + num2}.";
        }
    }
}