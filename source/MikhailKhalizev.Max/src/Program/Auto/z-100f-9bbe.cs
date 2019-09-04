using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_9bbe-e2568f1")]
        public void Method_100f_9bbe()
        {
            ii(0x100f_9bbe, 7); test(memb[ds, 0x101c_38d4], 0x10);      /* test byte [0x101c38d4], 0x10 */
            ii(0x100f_9bc5, 2); if(jz(0x100f_9bf3, 0x2c)) goto l_0x100f_9bf3; /* jz 0x100f9bf3 */
            ii(0x100f_9bc7, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x100f_9bca, 3); mov(eax, memd[ds, eax + 4]);            /* mov eax, [eax+0x4] */
            ii(0x100f_9bcd, 3); add(eax, 0xe);                          /* add eax, 0xe */
            ii(0x100f_9bd0, 6); cmp(eax, memd[ds, 0x101c_38d0]);        /* cmp eax, [0x101c38d0] */
            ii(0x100f_9bd6, 2); if(jg(0x100f_9bf3, 0x1b)) goto l_0x100f_9bf3; /* jg 0x100f9bf3 */
            ii(0x100f_9bd8, 7); cmp(memb[ds, 0x101c_3911], 0);          /* cmp byte [0x101c3911], 0x0 */
            ii(0x100f_9bdf, 2); if(jnz(0x100f_9be7, 6)) goto l_0x100f_9be7; /* jnz 0x100f9be7 */
            ii(0x100f_9be1, 4); mov(memb[ss, ebp - 68], 1);             /* mov byte [ebp-0x44], 0x1 */
            ii(0x100f_9be5, 2); jmp(0x100f_9beb, 4); goto l_0x100f_9beb; /* jmp 0x100f9beb */
        l_0x100f_9be7:
            ii(0x100f_9be7, 4); mov(memb[ss, ebp - 68], 0);             /* mov byte [ebp-0x44], 0x0 */
        l_0x100f_9beb:
            ii(0x100f_9beb, 3); mov(al, memb[ss, ebp - 68]);            /* mov al, [ebp-0x44] */
            ii(0x100f_9bee, 5); mov(memb[ds, 0x101c_3911], al);         /* mov [0x101c3911], al */
        l_0x100f_9bf3:
            ii(0x100f_9bf3, 5); if(jmp_func(0x100f_a7df, 0xbe7)) return; /* jmp 0x100fa7df */
        }
    }
}
