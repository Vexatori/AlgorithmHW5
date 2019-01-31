using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmHW5
{
    public class TNode : ICloneable
    {
        public int Value { get; set; }
        public TNode Next { get; set; }
        public object Clone()
        {
            return new TNode
            {
                Value = this.Value,
                Next = this.Next
            };
        }
    }
}
