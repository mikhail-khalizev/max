using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_15c9-48040f17")]
        public void Method_1016_15c9()
        {
            ii(0x1016_15c9, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1016_15ce, 5); calld(Definitions.sys_check_available_stack_size, 0x477f); /* call 0x10165d52 */
            ii(0x1016_15d3, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_15d4, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_15d5, 1); pushd(edx);                             /* push edx */
            ii(0x1016_15d6, 1); pushd(esi);                             /* push esi */
            ii(0x1016_15d7, 1); pushd(edi);                             /* push edi */
            ii(0x1016_15d8, 1); pushd(ebp);                             /* push ebp */
            ii(0x1016_15d9, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1016_15db, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1016_15e1, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1016_15e4, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1016_15e6, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1016_15e9, 3); mov(al, memb_a32[ds, edx + 0x26]);      /* mov al, [edx+0x26] */
            ii(0x1016_15ec, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1016_15ef, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_15f2, 5); calld(0x1007_623c, -0xe_b3bb);          /* call 0x1007623c */
            ii(0x1016_15f7, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1016_15fa, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_15fd, 4); cmp(memb_a32[ds, eax + 0x4d], 0);       /* cmp byte [eax+0x4d], 0x0 */
            ii(0x1016_1601, 2); if(jnzd(0x1016_1618, 0x15)) goto l_0x1016_1618; /* jnz 0x10161618 */
            ii(0x1016_1603, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_1606, 4); mov(memb_a32[ds, eax + 0x60], 0);       /* mov byte [eax+0x60], 0x0 */
            ii(0x1016_160a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_160d, 4); mov(memb_a32[ds, eax + 0x61], 0);       /* mov byte [eax+0x61], 0x0 */
            ii(0x1016_1611, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_1614, 4); mov(memb_a32[ds, eax + 0x62], 0);       /* mov byte [eax+0x62], 0x0 */
        l_0x1016_1618:
            ii(0x1016_1618, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1016_161a, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_161b, 1); popd(edi);                              /* pop edi */
            ii(0x1016_161c, 1); popd(esi);                              /* pop esi */
            ii(0x1016_161d, 1); popd(edx);                              /* pop edx */
            ii(0x1016_161e, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_161f, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_1620, 1); retd();                                 /* ret */
        }
    }
}
