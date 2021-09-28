using System;
using System.Linq;
using static Core.Helper;
namespace Business
{
    public class Calculator
    {
        public int Sum(params int[] numbers) => numbers.Aggregate(0, (sum, b) => Add(sum, b));
    }
}
