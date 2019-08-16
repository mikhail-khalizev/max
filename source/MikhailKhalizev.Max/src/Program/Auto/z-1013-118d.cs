using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("f6bd5e3f-31dc-46ba-9886-e69b6deeb5d3")]
        public void Method_1013_118d()
        {
            ii(0x1013_118d, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1013_1192, 5); calld(Definitions.sys_check_available_stack_size, 0x3_4bbb); /* call 0x10165d52 */
            ii(0x1013_1197, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_1198, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_1199, 1); pushd(esi);                             /* push esi */
            ii(0x1013_119a, 1); pushd(edi);                             /* push edi */
            ii(0x1013_119b, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_119c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_119e, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1013_11a4, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_11a7, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1013_11aa, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_11ad, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1013_11b0, 7); mov(memb_a32[ds, 0x101c_61b1], 0x1);    /* mov byte [0x101c61b1], 0x1 */
            ii(0x1013_11b7, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_11b9, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_11bc, 6); mov(eax, memd_a32[ds, eax + 0xbe]);     /* mov eax, [eax+0xbe] */
            ii(0x1013_11c2, 5); calld(0x100c_fb73, -0x6_1654);          /* call 0x100cfb73 */
            ii(0x1013_11c7, 7); mov(memb_a32[ds, 0x101c_61b0], 0);      /* mov byte [0x101c61b0], 0x0 */
            ii(0x1013_11ce, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_11d1, 5); calld(0x1012_f003, -0x21d3);            /* call 0x1012f003 */
            ii(0x1013_11d6, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_11d9, 4); cmp(memb_a32[ds, eax + 0x17], 0);       /* cmp byte [eax+0x17], 0x0 */
            ii(0x1013_11dd, 2); if(jzd(0x1013_11e8, 0x9)) goto l_0x1013_11e8; /* jz 0x101311e8 */
            ii(0x1013_11df, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_11e2, 4); cmp(memb_a32[ds, eax + 0x17], 0x1);     /* cmp byte [eax+0x17], 0x1 */
            ii(0x1013_11e6, 2); if(jnzd(0x1013_11f5, 0xd)) goto l_0x1013_11f5; /* jnz 0x101311f5 */
        l_0x1013_11e8:
            ii(0x1013_11e8, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1013_11ed, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_11f0, 5); calld(0x1013_0c16, -0x5df);             /* call 0x10130c16 */
        l_0x1013_11f5:
            ii(0x1013_11f5, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_11f7, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_11f8, 1); popd(edi);                              /* pop edi */
            ii(0x1013_11f9, 1); popd(esi);                              /* pop esi */
            ii(0x1013_11fa, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_11fb, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_11fc, 1); retd(); return;                         /* ret */
        }
    }
}