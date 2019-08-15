using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("bb7e641f-edb8-463f-a374-defda5651443")]
        public void Method_1013_12a6()
        {
            ii(0x1013_12a6, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1013_12ab, 5); calld(Definitions.sys_check_available_stack_size, 0x3_4aa2); /* call 0x10165d52 */
            ii(0x1013_12b0, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_12b1, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_12b2, 1); pushd(esi);                             /* push esi */
            ii(0x1013_12b3, 1); pushd(edi);                             /* push edi */
            ii(0x1013_12b4, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_12b5, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_12b7, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1013_12bd, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_12c0, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1013_12c3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_12c6, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1013_12c9, 7); mov(memb_a32[ds, 0x101c_61b2], 0);      /* mov byte [0x101c61b2], 0x0 */
            ii(0x1013_12d0, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_12d3, 5); calld(0x1012_f003, -0x22d5);            /* call 0x1012f003 */
            ii(0x1013_12d8, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_12db, 4); cmp(memb_a32[ds, eax + 0x17], 0);       /* cmp byte [eax+0x17], 0x0 */
            ii(0x1013_12df, 2); if(jnzd(0x1013_12ee, 0xd)) goto l_0x1013_12ee; /* jnz 0x101312ee */
            ii(0x1013_12e1, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1013_12e6, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_12e9, 5); calld(0x1013_0c16, -0x6d8);             /* call 0x10130c16 */
        l_0x1013_12ee:
            ii(0x1013_12ee, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_12f0, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_12f1, 1); popd(edi);                              /* pop edi */
            ii(0x1013_12f2, 1); popd(esi);                              /* pop esi */
            ii(0x1013_12f3, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_12f4, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_12f5, 1); retd(); return;                         /* ret */
        }
    }
}
