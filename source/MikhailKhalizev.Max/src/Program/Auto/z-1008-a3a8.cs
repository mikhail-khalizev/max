using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_a3a8-e9e018fc")]
        public void Method_1008_a3a8()
        {
            ii(0x1008_a3a8, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1008_a3ad, 5); calld(Definitions.sys_check_available_stack_size, 0xd_b9a0); /* call 0x10165d52 */
            ii(0x1008_a3b2, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_a3b3, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_a3b4, 1); pushd(edx);                             /* push edx */
            ii(0x1008_a3b5, 1); pushd(esi);                             /* push esi */
            ii(0x1008_a3b6, 1); pushd(edi);                             /* push edi */
            ii(0x1008_a3b7, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_a3b8, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_a3ba, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1008_a3c0, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1008_a3c3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_a3c6, 4); mov(ax, memw_a32[ds, eax + 0xe]);       /* mov ax, [eax+0xe] */
            ii(0x1008_a3ca, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_a3cd, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_a3d0, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_a3d2, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_a3d3, 1); popd(edi);                              /* pop edi */
            ii(0x1008_a3d4, 1); popd(esi);                              /* pop esi */
            ii(0x1008_a3d5, 1); popd(edx);                              /* pop edx */
            ii(0x1008_a3d6, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_a3d7, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_a3d8, 1); retd(); return;                         /* ret */
        }
    }
}
