using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_a680-1d168b1b")]
        public void Method_100f_a680()
        {
            ii(0x100f_a680, 6); mov(ecx, memd_a32[ds, 0x101c_3908]);    /* mov ecx, [0x101c3908] */
            ii(0x100f_a686, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100f_a689, 6); mov(ebx, memd_a32[ds, 0x101c_3906]);    /* mov ebx, [0x101c3906] */
            ii(0x100f_a68f, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100f_a692, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x100f_a695, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a69a, 5); calld(0x1007_65d0, -0x8_40cf);          /* call 0x100765d0 */
            ii(0x100f_a69f, 5); calld(0x100f_9465, -0x123f);            /* call 0x100f9465 */
            ii(0x100f_a6a4, 2); test(al, al);                           /* test al, al */
            ii(0x100f_a6a6, 2); if(jzd(0x100f_a6cc, 0x24)) goto l_0x100f_a6cc; /* jz 0x100fa6cc */
            ii(0x100f_a6a8, 6); mov(ecx, memd_a32[ds, 0x101c_3908]);    /* mov ecx, [0x101c3908] */
            ii(0x100f_a6ae, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100f_a6b1, 6); mov(ebx, memd_a32[ds, 0x101c_3906]);    /* mov ebx, [0x101c3906] */
            ii(0x100f_a6b7, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100f_a6ba, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x100f_a6bd, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_a6c2, 5); calld(0x1007_65d0, -0x8_40f7);          /* call 0x100765d0 */
            ii(0x100f_a6c7, 5); calld(0x100f_939e, -0x132e);            /* call 0x100f939e */
        l_0x100f_a6cc:
            ii(0x100f_a6cc, 5); if(jmpd_func(0x100f_a75d, 0x8c)) return; /* jmp 0x100fa75d */
        }
    }
}
