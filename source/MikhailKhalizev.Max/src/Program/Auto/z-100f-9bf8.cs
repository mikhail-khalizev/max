using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_9bf8-5dbf0207")]
        public void Method_100f_9bf8()
        {
            ii(0x100f_9bf8, 7); test(memb_a32[ds, 0x101c_38d4], 0x10);  /* test byte [0x101c38d4], 0x10 */
            ii(0x100f_9bff, 2); if(jzd(0x100f_9c1a, 0x19)) goto l_0x100f_9c1a; /* jz 0x100f9c1a */
            ii(0x100f_9c01, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x100f_9c03, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100f_9c05, 6); mov(ax, memw_a32[ds, 0x101c_38c0]);     /* mov ax, [0x101c38c0] */
            ii(0x100f_9c0b, 5); add(eax, 0xa);                          /* add eax, 0xa */
            ii(0x100f_9c10, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100f_9c13, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_9c15, 5); calld(0x1010_1620, 0x7a06);             /* call 0x10101620 */
        l_0x100f_9c1a:
            ii(0x100f_9c1a, 5); if(jmpd_func(0x100f_a7df, 0xbc0)) return; /* jmp 0x100fa7df */
        }
    }
}
