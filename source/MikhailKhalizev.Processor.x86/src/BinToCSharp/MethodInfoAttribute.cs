using System;

namespace MikhailKhalizev.Processor.x86.BinToCSharp
{
    public class MethodInfoAttribute : Attribute
    {
        private readonly string _guid;

        public MethodInfoAttribute(string guid)
        {
            _guid = guid;
        }

        public Guid Guid => Guid.Parse(_guid);
    }
}