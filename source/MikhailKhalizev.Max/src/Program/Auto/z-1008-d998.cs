using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_d998-9eb0c3be")]
        public void Method_1008_d998()
        {
            ii(0x1008_d998, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_d99b, 5); calld(0x1008_d6ba, -0x2e6);             /* call 0x1008d6ba */
            ii(0x1008_d9a0, 2); test(al, al);                           /* test al, al */
            ii(0x1008_d9a2, 6); if(jnzd_func(0x1008_db55, 0x1ad)) return; /* jnz 0x1008db55 */
            ii(0x1008_d9a8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_d9ab, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_d9ae, 5); calld(0x1007_6574, -0x1_743f);          /* call 0x10076574 */
            ii(0x1008_d9b3, 4); cmp(memb_a32[ds, eax + 0x3d], 0);       /* cmp byte [eax+0x3d], 0x0 */
            ii(0x1008_d9b7, 2); if(jnzd(0x1008_d9ce, 0x15)) goto l_0x1008_d9ce; /* jnz 0x1008d9ce */
            ii(0x1008_d9b9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_d9bc, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_d9bf, 5); calld(0x1007_6574, -0x1_7450);          /* call 0x10076574 */
            ii(0x1008_d9c4, 5); calld(0x1015_26ac, 0xc_4ce3);           /* call 0x101526ac */
            ii(0x1008_d9c9, 3); cmp(eax, memd_a32[ss, ebp - 0x4]);      /* cmp eax, [ebp-0x4] */
            ii(0x1008_d9cc, 2); if(jzd(0x1008_d9d0, 0x2)) goto l_0x1008_d9d0; /* jz 0x1008d9d0 */
        l_0x1008_d9ce:
            ii(0x1008_d9ce, 2); jmpd(0x1008_d9ef, 0x1f); goto l_0x1008_d9ef; /* jmp 0x1008d9ef */
        l_0x1008_d9d0:
            ii(0x1008_d9d0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_d9d3, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1008_d9d6, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_d9d9, 3); mov(ebx, memd_a32[ds, eax + 0x2]);      /* mov ebx, [eax+0x2] */
            ii(0x1008_d9dc, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_d9df, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_d9e2, 5); calld(0x1007_65d0, -0x1_7417);          /* call 0x100765d0 */
            ii(0x1008_d9e7, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_d9e9, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_d9ec, 3); calld_abs(memd_a32[ds, ebx + 0x44]);    /* call dword [ebx+0x44] */
        l_0x1008_d9ef:
            ii(0x1008_d9ef, 5); if(jmpd_func(0x1008_db55, 0x161)) return; /* jmp 0x1008db55 */
        }
    }
}
