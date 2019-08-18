using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_760c-7d4bbd0")]
        public void Method_1012_760c()
        {
            ii(0x1012_760c, 5); calld(0x1012_5d1f, -0x18f2);            /* call 0x10125d1f */
            ii(0x1012_7611, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1012_7613, 6); if(jzd_func(0x1012_85f9, 0xfe0)) return; /* jz 0x101285f9 */
            ii(0x1012_7619, 6); mov(ax, memw_a32[ds, 0x101c_59f1]);     /* mov ax, [0x101c59f1] */
            ii(0x1012_761f, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1012_7622, 6); mov(ax, memw_a32[ds, 0x101c_59f3]);     /* mov ax, [0x101c59f3] */
            ii(0x1012_7628, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1012_762b, 5); mov(al, memb_a32[ds, 0x101c_59f0]);     /* mov al, [0x101c59f0] */
            ii(0x1012_7630, 3); mov(memb_a32[ss, ebp - 0xc], al);       /* mov [ebp-0xc], al */
            ii(0x1012_7633, 5); if(jmpd_func(0x1012_85cc, 0xf94)) return; /* jmp 0x101285cc */
        }
    }
}
