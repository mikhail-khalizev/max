using System;

namespace MikhailKhalizev.Processor.x86.BinToCSharp
{
    public class MethodInfoAttribute : Attribute
    {
        public string Id { get; }

        public MethodInfoAttribute(string id)
        {
            Id = id;
        }
    }
}