using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeciseOop.Helper;
internal class Validate<T>
{
    public static T CheckReadLine()
    {
        var typeCode = Type.GetTypeCode(typeof(T));
        Object obj = new(); 
        bool flag = false;
        while(!flag)
        {
            flag= true;
            try {
                var str = Console.ReadLine();
                if(string.IsNullOrEmpty(str) )
                {
                    throw new Exception("Error,Null or Emptu");
                }
                switch (typeCode) {
                    case TypeCode.String: 
                        obj = str; 
                        break;
                    case TypeCode.Int32:
                        obj = Convert.ToInt32(str);
                        if ((int)obj<0)
                        {
                            throw new Exception("Please enter again greater than 0");
                        }
                        break;
                    case TypeCode.Double:
                        obj = Convert.ToDouble(str);
                        if ((Double)obj < 0)
                        {
                            throw new Exception("Please enter again greater than 0");
                        }
                        break;
                    case TypeCode.DateTime: 
                        var date = DateTime.TryParseExact(
                            str, new[] {"d/M/yyyy","d-M-yyyy"},
                            new CultureInfo("vi-VN"),
                            DateTimeStyles.None,out var t)? 
                            t:throw new Exception("Datetime wrong (d-M-yyyy or d/M/yyyy)");
                        obj = date.Add(DateTime.Now.TimeOfDay);
                        break;
                    default:
                        obj = null;
                        break;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine($"{e.GetType()}:{e.Message},please enter again");
                flag= false;
            }
            
        }
        return (T)obj;
    }
}
