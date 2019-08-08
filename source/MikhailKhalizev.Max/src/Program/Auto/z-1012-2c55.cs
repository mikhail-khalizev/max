using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("765227b6-4b20-4215-a1ba-4c765853cd1a")]
        public void Method_1012_2c55()
        {
            ii(0x1012_2c55, 3); rol(memd_a32[ds, esi], 0x75);           /* rol dword [esi], 0x75 */
            ii(0x1012_2c58, 6); and(memb_a32[ds, eax + 0x40], bh);      /* and [eax+0x40], bh */
            ii(0x1012_2c5e, 5); calld(0x1007_5fdc, -0xa_cc87);          /* call 0x10075fdc */
            ii(0x1012_2c63, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1012_2c65, 2); if(jnzd(0x1012_2c6d, 0x6)) goto l_0x1012_2c6d; /* jnz 0x10122c6d */
            ii(0x1012_2c67, 4); mov(memb_a32[ss, ebp - 0x40], 0x1);     /* mov byte [ebp-0x40], 0x1 */
            ii(0x1012_2c6b, 2); jmpd(0x1012_2c71, 0x4); goto l_0x1012_2c71; /* jmp 0x10122c71 */
        l_0x1012_2c6d:
            ii(0x1012_2c6d, 4); mov(memb_a32[ss, ebp - 0x40], 0);       /* mov byte [ebp-0x40], 0x0 */
        l_0x1012_2c71:
            ii(0x1012_2c71, 3); mov(al, memb_a32[ss, ebp - 0x40]);      /* mov al, [ebp-0x40] */
            ii(0x1012_2c74, 5); mov(memb_a32[ds, 0x101c_814a], al);     /* mov [0x101c814a], al */
        l_0x1012_2c79:
            ii(0x1012_2c79, 5); mov(eax, 0x101c_39c8);                  /* mov eax, 0x101c39c8 */
            ii(0x1012_2c7e, 5); calld(0x1010_6084, -0x1_cbff);          /* call 0x10106084 */
            ii(0x1012_2c83, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_2c86, 4); mov(memb_a32[ds, eax + 0x31], 0x1);     /* mov byte [eax+0x31], 0x1 */
            ii(0x1012_2c8a, 5); if(jmpd_func(0x1012_31ce, 0x53f)) return; /* jmp 0x101231ce */
        }
    }
}
