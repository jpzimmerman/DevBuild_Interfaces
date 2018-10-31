using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevBuild_Interfaces {
    public class CountableAnimal : ICountable {

        public string Name { get; set; }
        public int TotalCount { get; set; }

        public CountableAnimal(string name, int totalCount) {
            Name = name;
            TotalCount = totalCount;
        }

        public int GetCount() => TotalCount;

        public virtual string GetCountString() {
            return $"{GetCount()} {GetType().Name.ToLower()}";
        }

        public void IncrementCount() => TotalCount++;

        public void ResetCount() => TotalCount = 0;
    }
}
