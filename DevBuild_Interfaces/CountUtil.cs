using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevBuild_Interfaces {
    class CountUtil {
        public static void Count(ICountable c, int MaxCount) {
            for (int i = 0; i < MaxCount; i++) {
                c.IncrementCount();
                Console.WriteLine(c.GetCountString());
            }
            Console.WriteLine();
        }
    }
}
