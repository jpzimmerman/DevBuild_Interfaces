using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevBuild_Interfaces {
    interface ICountable {
        void IncrementCount();
        void ResetCount();
        int GetCount();
        string GetCountString();
    }
}
