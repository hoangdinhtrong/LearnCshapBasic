using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attribute.Demo
{
    [Serializable]
    [Test("Attribute test", Quantity = 10)]
    public class AttributeExample
    {
    }

    public class TestAttribute: System.Attribute
    {
        private readonly string name;
        public int Quantity;

        public TestAttribute(string name) { this.name = name; }

        public string Name => name;
    }
}
