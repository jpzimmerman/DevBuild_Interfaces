using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevBuild_Interfaces {
    class Program {
        static void Main(string[] args) {
            CountTestApp testApp = new CountTestApp();
            testApp.StartApp();

            while (true) { }
        }
    }
}
