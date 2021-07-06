using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8.Master
{
    public static class Helper
    {
        public static int VerificaInput(int max)
        {
            var conversione = int.TryParse(Console.ReadLine(), out int result);
            while(conversione == false || result < 0 || result > max)
            {
                conversione = int.TryParse(Console.ReadLine(), out result);
            }
            return result;
        }

    }
}
