using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_v14
{
    internal class BookPrice : Book
    {
        public int Salary { get; set; }

        public int Discount(int Salary, int Year)
        {
            int result;
            if (2022-Year > 5)
            {
                result = Salary - (Salary * 20 / 100);
            }
            else
            {
                result = Salary;
            }
            return result;

        }
        
    }
}
