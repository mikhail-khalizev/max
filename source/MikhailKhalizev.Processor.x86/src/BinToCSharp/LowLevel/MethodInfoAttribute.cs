using System;

namespace MikhailKhalizev.Processor.x86.BinToCSharp
{
    public class MethodInfoAttribute : Attribute
    {
        public string _id { get; }

        public MethodInfoAttribute(string id)
        {
            _id = id;
        }

        public Guid Guid => Guid.Parse(_id);
    }
}