using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c602eebd-66ca-40e7-bd25-69d7972341e3")]
        public void Method_100e_d68c()
        {
            ii(0x100e_d68c, 5); mov(eax, memd_a32[ds, 0x101c_3964]);    /* mov eax, [0x101c3964] */
            ii(0x100e_d691, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_d694, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_d696, 2); if(jnzd(0x100e_d6af, 0x17)) goto l_0x100e_d6af; /* jnz 0x100ed6af */
            ii(0x100e_d698, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_d69b, 7); cmp(ax, memw_a32[ds, 0x101c_3968]);     /* cmp ax, [0x101c3968] */
            ii(0x100e_d6a2, 2); if(jld(0x100e_d6ad, 0x9)) goto l_0x100e_d6ad; /* jl 0x100ed6ad */
            ii(0x100e_d6a4, 4); mov(memb_a32[ss, ebp - 0xc], 0x2);      /* mov byte [ebp-0xc], 0x2 */
            ii(0x100e_d6a8, 5); if(jmpd_func(0x100e_d760, 0xb3)) return; /* jmp 0x100ed760 */
        l_0x100e_d6ad:
            ii(0x100e_d6ad, 2); jmpd(0x100e_d6e1, 0x32); goto l_0x100e_d6e1; /* jmp 0x100ed6e1 */
        l_0x100e_d6af:
            ii(0x100e_d6af, 5); mov(eax, memd_a32[ds, 0x101c_3966]);    /* mov eax, [0x101c3966] */
            ii(0x100e_d6b4, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_d6b7, 6); cmp(eax, memd_a32[ds, 0x101c_a550]);    /* cmp eax, [0x101ca550] */
            ii(0x100e_d6bd, 2); if(jgd(0x100e_d6c8, 0x9)) goto l_0x100e_d6c8; /* jg 0x100ed6c8 */
            ii(0x100e_d6bf, 4); mov(memb_a32[ss, ebp - 0xc], 0x2);      /* mov byte [ebp-0xc], 0x2 */
            ii(0x100e_d6c3, 5); if(jmpd_func(0x100e_d760, 0x98)) return; /* jmp 0x100ed760 */
        l_0x100e_d6c8:
            ii(0x100e_d6c8, 5); mov(eax, memd_a32[ds, 0x101c_3966]);    /* mov eax, [0x101c3966] */
            ii(0x100e_d6cd, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_d6d0, 6); cmp(eax, memd_a32[ds, 0x101c_a797]);    /* cmp eax, [0x101ca797] */
            ii(0x100e_d6d6, 2); if(jgd(0x100e_d6e1, 0x9)) goto l_0x100e_d6e1; /* jg 0x100ed6e1 */
            ii(0x100e_d6d8, 4); mov(memb_a32[ss, ebp - 0xc], 0x3);      /* mov byte [ebp-0xc], 0x3 */
            ii(0x100e_d6dc, 5); if(jmpd_func(0x100e_d760, 0x7f)) return; /* jmp 0x100ed760 */
        l_0x100e_d6e1:
            ii(0x100e_d6e1, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x100e_d6e5, 5); if(jmpd_func(0x100e_d760, 0x76)) return; /* jmp 0x100ed760 */
        }
    }
}
