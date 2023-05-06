using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEvent.Demo
{
    public class Calculator
    {
        #region Delegate and Func
        //public delegate int Calculate(int input);

        //public int Execute(Calculate calculate, int input)
        //{
        //    return calculate(input);
        //}

        //public int Execute(Func<int, int> calculate, int input)
        //{
        //    return calculate(input);
        //}
        #endregion

        #region Delegate and Action
        //public delegate void Print(int input);
        //public int Execute(Func<int, int> calculate, Print print, int input)
        //{
        //    var result = calculate(input);
        //    print(result);
        //    return result;
        //}

        //public int Execute(Func<int, int> calulate, Action<int> print, int input)
        //{
        //    var result = calulate(input);
        //    print(result);
        //    return result;
        //}
        #endregion

        #region Delegate and Event
        public event Action<object, CalculatorEventArgs>? Calculate;

        public void RaiseEvent(string name)
        {
            Calculate?.Invoke(this, new CalculatorEventArgs() { Name = name });
        }

        public int Execute(Func<int, int> calulate, Action<int> print, int input)
        {
            var result = calulate(input);
            print(result);
            return result;
        }
        #endregion
    }
}
