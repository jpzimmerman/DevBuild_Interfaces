using System;

namespace DevBuild_Interfaces {
    public class Sheep : CountableAnimal, ICloneable {

        public Sheep(string name, int totalCount) : base(name, totalCount) {
        }

        public object Clone() {
            return this.MemberwiseClone();
        }

        public override string GetCountString() => $"{TotalCount} {Name}";
    }
}
