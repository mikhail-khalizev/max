using System;
using MikhailKhalizev.Processor.x86.Abstractions;

namespace MikhailKhalizev.Processor.x86
{
    public class Block
    {
        public Address Address { get; }
        public Action Action { get; }

        public Block(Address address, Action act)
        {
            Address = address;
            Action = act;
        }
    }
}