using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_topic
{
    public  class ConditionalStatement
    {
         int i;
        string j;

        public void NameFill()
        {
            i = 45;
            j = "Ade";

            if (i == 45 && j == "Ade")
            {
                Console.WriteLine($"{j} will be {i} next year June");
            }
            else
            {
                Console.WriteLine("Information not received");
            }


        }
    }

}
