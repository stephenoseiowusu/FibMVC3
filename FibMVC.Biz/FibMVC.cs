using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibMVC.Biz
{
    public class FibMVC
    {
        public static String returnnum(int num)
        {
            String that = "0,1,";
            int before2 = 0;
            int before = 1;
            for(int loop = 0; loop < num; loop ++)
            {
                
                int sum = before + before2;
                that += sum + ",";
                before2 = before;
                before = sum;
            }
            return that;
        }
    }
}
