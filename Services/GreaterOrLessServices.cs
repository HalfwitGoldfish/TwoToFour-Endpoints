using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.ObjectPool;

namespace TwoToFour_Endpoints.Services
{
    public class GreaterOrLessServices
    {
        public string GreaterOrLess(int num1, int num2)
        {
            if(num1 < num2){
                string firstNum = $"{num1} is less than {num2}";
                string secondNum = $"{num2} is greater than {num1}";
                return $"{firstNum}\n{secondNum}";
            }else if(num1 > num2){
                string firstNum = $"{num1} is greater than {num2}";
                string secondNum = $"{num2} is less than {num1}";
                return $"{firstNum}\n{secondNum}";
            }else{
                return $"{num1} is equal to {num2}";
            }
        }
    }
}