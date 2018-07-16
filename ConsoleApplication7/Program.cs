using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    public enum Discount : ulong
    {
        name, family, ShortName = 5, age, sex
    }

    public enum ResultCode { success, warning, error}
    class Program
    {
        static void Main(string[] args)
        {
            Discount d = Discount.name;

            //се пары значений
            Array enumData = Enum.GetValues(d.GetType());
            foreach (var item in enumData)
            {
                Console.WriteLine("name: {0}-{0:D}",item);
            }

            ////поиск по значению
            //var result = 5;
            //if (!Enum.IsDefined(typeof(ResultCode), result))
            //{
            //    throw new InvalidOperationException("Enum out of range");
            //}


            // поиск по имени
            string option = "success";
            var resultStr = (ResultCode)Enum.Parse(typeof(ResultCode), option);

            if (resultStr==ResultCode.success)
            {
                Console.WriteLine("!!!"); ;
            }
        }
    }
}
