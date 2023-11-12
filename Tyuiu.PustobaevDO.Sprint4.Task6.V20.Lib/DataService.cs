using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.PustobaevDO.Sprint4.Task6.V20.Lib
{
    public class DataService : ISprint4Task6V0
    {
        public string[] Calculate(string[] array)
        {
            string[] names = Array.FindAll(array, x => x.Length < 10);
            return names;
        }

        int ISprint4Task6V0.Calculate(string[] array)
        {
            throw new NotImplementedException();
        }
    }
}
