using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("6a6bba81-b623-4499-8645-48ae734bb22d")]
        public void Method_100f_9c1f()
        {
            ii(0x100f_9c1f, 7); test(memb_a32[ds, 0x101c_38d4], 0x10);  /* test byte [0x101c38d4], 0x10 */
            ii(0x100f_9c26, 2); if(jzd(0x100f_9c3f, 0x17)) goto l_0x100f_9c3f; /* jz 0x100f9c3f */
            ii(0x100f_9c28, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x100f_9c2a, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100f_9c2c, 6); mov(ax, memw_a32[ds, 0x101c_38c0]);     /* mov ax, [0x101c38c0] */
            ii(0x100f_9c32, 3); sub(eax, 0xa);                          /* sub eax, 0xa */
            ii(0x100f_9c35, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100f_9c38, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_9c3a, 5); calld(0x1010_1620, 0x79e1);             /* call 0x10101620 */
        l_0x100f_9c3f:
            ii(0x100f_9c3f, 5); if(jmpd_func(0x100f_a7df, 0xb9b)) return; /* jmp 0x100fa7df */
        }
    }
}
