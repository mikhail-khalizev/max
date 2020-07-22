using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_0fc8-96eb1e64")]
        public void /* sys */ sys_write_port()
        {
            ii(0x1018_0fc8, 1);  push(ebx);                            /* push ebx */
            ii(0x1018_0fc9, 2);  mov(ebx, eax);                        /* mov ebx, eax */
            ii(0x1018_0fcb, 2);  mov(al, dl);                          /* mov al, dl */
            ii(0x1018_0fcd, 2);  mov(edx, ebx);                        /* mov edx, ebx */
            ii(0x1018_0fcf, 1);  outb(dx, al);                         /* out dx, al */
            ii(0x1018_0fd0, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1018_0fd1, 1);  ret();                                /* ret */
        }
    }
}
