using System;

namespace MikhailKhalizev.Processor.x86.BinToCSharp
{
    public class MethodInfoAttribute : Attribute
    {
        public MethodInfoAttribute(string guid)
        {
            Guid = Guid.Parse(guid);
        }

        public Guid Guid { get; set; }
    }
}