using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevBuild_Interfaces {
    public class CountTestApp {

        public void StartApp() {
            Alligator henryTheAlligator = new Alligator(name: "Henry", totalCount: 0);
            Sheep blackieTheSheep = new Sheep(name: "Blackie", totalCount: 0);

            Console.WriteLine("Counting Alligators...\n");
            CountUtil.Count(henryTheAlligator, 3);
            Console.WriteLine("Counting sheep...\n");
            CountUtil.Count(blackieTheSheep, 2);

            Sheep clonedSheep = (Sheep)blackieTheSheep.Clone();
            clonedSheep.Name = "Roy";
            clonedSheep.ResetCount();
            blackieTheSheep.ResetCount();
            CountUtil.Count(clonedSheep, 3);
            CountUtil.Count(blackieTheSheep, 1);
        }
    }
}
